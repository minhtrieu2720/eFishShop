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
        Task<ApiResult<string>> Authenticate(LoginRequest request);

        Task<ApiResult<PageResult<UserViewModel>>> GetUsersPagings(GetUserPagingRequest request);

        Task<ApiResult<bool>> RegisterUser(RegisterRequest registerRequest);

        Task<ApiResult<bool>> UpdateUser(Guid id, UserUpdateRequest request);

        Task<ApiResult<UserViewModel>> GetById(Guid id);

        Task<ApiResult<bool>> Delete(Guid id);
    }
}
