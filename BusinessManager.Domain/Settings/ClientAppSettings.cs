using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessManager.Domain.Settings
{
    public class ClientAppSettings
    {
        public string Url { get; set; }
        public string EmailConfirmationPath { get; set; }
        public string ResetPasswordPath { get; set; }
    }
}
