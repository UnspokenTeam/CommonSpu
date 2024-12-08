using System.Text.Json;
using Confluent.Kafka;

namespace Common.Kafka;

public class CustomSerializer<T> : ISerializer<T>
{
	public byte[] Serialize(T data, SerializationContext context)
	{
		return JsonSerializer.SerializeToUtf8Bytes(data);
	}
}

public class KafkaClient : IKafkaClient
{
	private readonly ProducerConfig _configuration;

	public KafkaClient(KafkaConfig configuration)
	{
		_configuration = new ProducerConfig
		{
			ClientId = configuration.ClientId,
			BootstrapServers = configuration.Hosts,
			SaslUsername = configuration.Username,
			SaslPassword = configuration.Password,
			SaslMechanism = SaslMechanism.Plain,
			SecurityProtocol = SecurityProtocol.SaslPlaintext,
			EnableSslCertificateVerification = false
		};
	}

	public async Task ProduceMessage<T>(T data, string topic, string id)
	{
		using var producer = new ProducerBuilder<string, T>(_configuration).SetValueSerializer(new CustomSerializer<T>()).SetPartitioner(topic, Partitioner).Build();
		await producer.ProduceAsync
			(
			 topic, new Message<string, T>
			 {
				 Key = id,
				 Value = data
			 }
			);
	}

	private static Partition Partitioner(string topic, int partitioncount, ReadOnlySpan<byte> keydata, bool keyisnull)
	{
		return keyisnull ? Partition.Any : new Partition(keydata.ToArray().GetHashCode() % partitioncount);
	}
}