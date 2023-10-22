using API_CSHARP_PROFILE.Models;

namespace API_CSHARP_PROFILE.Services.Interface
{
    public interface IMyProfileService
    {
        public Task<BaseResponse<string>> ContactApplyAsync();
    }

}