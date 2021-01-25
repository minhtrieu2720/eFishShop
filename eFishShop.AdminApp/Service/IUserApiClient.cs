using eFishShop.ViewModels.Common;
using eFishShop.ViewModels.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eFishShop.AdminApp.Services
{
    public interface IUserApiClient
    {
        Task<string> Authenticate(LoginRequest request);
        Task<bool> RegisterUser(RegisterRequest registerRequest);
        Task<PageResult<UserViewModel>> GetUsersPagings(GetUserPagingRequest request);
    }
}
