namespace Common.Kafka;

public interface IKafkaClient
{
    public Task ProduceMessage<T>(T data, string topic, string id);
}