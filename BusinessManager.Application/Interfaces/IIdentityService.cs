using BusinessManager.Application.DTOs;
using BusinessManager.Application.Features.Account.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager.Application.Interfaces
{
    public interface IIdentityService
    {
        Task<Result<string>> RegisterAsync(string userName, string password, string email);
        Task<LoginViewModel> LoginAsync(string userName, string password, string email);
    }
}
