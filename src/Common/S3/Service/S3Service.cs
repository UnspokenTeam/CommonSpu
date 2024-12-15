using Amazon.S3;
using Amazon.S3.Model;

namespace Common.S3.Service;

public class S3Service : IS3Service
{
	private readonly IAmazonS3 _s3Client;

	public S3Service(IAmazonS3 s3Client)
	{
		_s3Client = s3Client;
	}

	public async Task UploadFileAsync(string keyName, Stream data, string bucketName)
	{
		var putRequest = new PutObjectRequest
		{
			BucketName = bucketName,
			Key = keyName,
			InputStream = data
		};

		await _s3Client.PutObjectAsync(putRequest);
	}

	public async Task DeleteFileAsync(string keyName, string bucketName)
	{
		var deleteRequest = new DeleteObjectRequest
		{
			BucketName = bucketName,
			Key = keyName
		};

		await _s3Client.DeleteObjectAsync(deleteRequest);
	}

	public async Task<byte[]> GetFileAsync(string keyName, string bucketName)
	{
		var request = new GetObjectRequest
		{
			BucketName = bucketName,
			Key = keyName
		};

		using var response = await _s3Client.GetObjectAsync(request);
		using var memoryStream = new MemoryStream();
		await response.ResponseStream.CopyToAsync(memoryStream);
		return memoryStream.ToArray();
	}

	public async Task CreateBucketAsync(string bucketName)
	{
		var request = new PutBucketRequest
		{
			BucketName = bucketName
		};

		await _s3Client.PutBucketAsync(request);
	}

	public async Task DeleteBucketAsync(string bucketName)
	{
		var request = new DeleteBucketRequest
		{
			BucketName = bucketName
		};

		await _s3Client.DeleteBucketAsync(request);
	}
}