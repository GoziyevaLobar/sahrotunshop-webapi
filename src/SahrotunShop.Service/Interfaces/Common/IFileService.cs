using Microsoft.AspNetCore.Http;

namespace SahrotunShop.Service.Interfaces.Common;

public interface IFileService
{
    //return subpath of this image
    public Task<string> UploadImageAsync(IFormFile image);


    public Task<bool> DeleteImageAsync(string subpath);


    //return subpath of this avatar
    public Task<string> UploadAvatarAsync(IFormFile avatar);
    public Task<bool> DeleteAvatarAsync(string subpath);


}
