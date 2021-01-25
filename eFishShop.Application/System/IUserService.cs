using eFishShop.ViewModels.Common;
using eFishShop.ViewModels.System;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eFishShop.Application.System
{
    public interface IUserService
    {
        Task<string> Authencate(LoginRequest request);

        Task<bool> Register(RegisterRequest request);

        Task<PageResult<UserViewModel>> GetUserPaging(GetUserPagingRequest request);
    }
}
