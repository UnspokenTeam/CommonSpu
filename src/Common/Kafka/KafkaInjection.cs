using Microsoft.Extensions.DependencyInjection;

namespace Common.Kafka;

public static class KafkaInjection
{
	public static void Configure(IServiceCollection services, KafkaConfig configuration)
	{
		var kafkaClient = new KafkaClient(configuration);
		services.AddSingleton<IKafkaClient>(kafkaClient);
	}
}