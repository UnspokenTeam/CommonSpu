using Amazon;
using Amazon.S3;
using Common.S3.Options;
using Common.S3.Service;
using Microsoft.Extensions.DependencyInjection;

namespace Common.S3;

public static class S3Injection
{
	public static IServiceCollection Configure(IServiceCollection services, S3Configuration s3Config)
	{
		var amazonS3Config = new AmazonS3Config
		{
			RegionEndpoint = RegionEndpoint.GetBySystemName(s3Config.Region),
			ServiceURL = s3Config.ServiceURL,
			ForcePathStyle = true
		};

		var amazonS3Client = new AmazonS3Client(s3Config.AccessKey, s3Config.SecretKey, amazonS3Config);

		services.AddSingleton<IAmazonS3>(amazonS3Client);
		services.AddSingleton<IS3Service, S3Service>();

		return services;
	}
}