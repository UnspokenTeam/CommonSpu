namespace Common.S3.Service;

public interface IS3Service
{
	public Task UploadFileAsync(string keyName, Stream data, string bucketName);

	public Task DeleteFileAsync(string keyName, string bucketName);

	public Task<byte[]> GetFileAsync(string keyName, string bucketName);

	public Task CreateBucketAsync(string bucketName);
	public Task DeleteBucketAsync(string bucketName);
}