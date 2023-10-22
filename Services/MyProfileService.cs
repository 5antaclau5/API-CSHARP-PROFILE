using API_CSHARP_PROFILE.Models;
using API_CSHARP_PROFILE.Services.Interface;

namespace API_CSHARP_PROFILE.Services
{
    public class MyProfileService : IMyProfileService
    {
        public MyProfileService()
        {

        }
        public async Task<BaseResponse<string>> ContactApplyAsync()
        {
            var response = new BaseResponse<string>();
            DateTime currenttime = DateTime.Now;
            try
            {

            }
            catch (System.Exception er)
            {

                throw;
            }
            return response;
        }
    }

}