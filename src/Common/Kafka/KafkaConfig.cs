namespace Common.Kafka;

public record KafkaConfig
(
	string Hosts,
	string ClientId,
	string Username,
	string Password
);