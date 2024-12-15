namespace Common.S3.Options;

public record S3Configuration
(
	string Profile,
	string Region,
	string ServiceURL,
	string AccessKey,
	string SecretKey
);