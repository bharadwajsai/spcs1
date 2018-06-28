using System.IO;
using System.Threading.Tasks;
using google;
using file;

namespace services
{
    public class AdService : IAdService
    {
        //private readonly IUnitOfWork _unitOfWork;
        private readonly IFileRead _fileReadService;
        private readonly IGoogleStorage _googleStorage;

        public AdService(IFileRead fileReadService, IGoogleStorage googleStorage)
        {
            _fileReadService = fileReadService;
            _googleStorage = googleStorage;
        }

        public async Task UploadObjectInGoogleStorageAsync(string bucketName, Stream stream, string objectName, string contentType)
        {
            await _googleStorage.UploadObjectAsync(bucketName, stream, objectName, contentType);
        }

        public void UploadObjectInGoogleStorage(string fileName, int inMemoryCachyExpireDays, string objectName, string bucketName, object anonymousDataObject, string contentType, string CACHE_KEY)
        {
            string content = _fileReadService.FileAsString(fileName, inMemoryCachyExpireDays, CACHE_KEY);
            content = _fileReadService.FillContent(content, anonymousDataObject);
            Stream stream = _fileReadService.FileAsStream(content);
            _googleStorage.UploadObject(bucketName, stream, objectName, contentType);
        }
    }

    public interface IAdService
    {
        void UploadObjectInGoogleStorage(string fileName, int inMemoryCachyExpireDays, string objectName, string bucketName, object anonymousDataObject, string contentType, string CACHE_KEY);
        Task UploadObjectInGoogleStorageAsync(string bucketName, Stream stream, string objectName, string contentType);
        //IEnumerable<TEntity> GetAll<TEntity>() where TEntity : AdVM, new();
    }
}
