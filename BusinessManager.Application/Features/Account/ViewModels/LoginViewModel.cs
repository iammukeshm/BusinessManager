using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessManager.Application.Features.Account.ViewModels
{
    public class LoginViewModel
    {
        public bool? HasVerifiedEmail { get; set; }
        public bool? TFAEnabled { get; set; }
        public string Token { get; set; }
    }
}
