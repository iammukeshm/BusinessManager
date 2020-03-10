using BusinessManager.Application.DTOs;
using BusinessManager.Application.Features.Account.ViewModels;
using BusinessManager.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessManager.Application.Features.Account.Commands
{
    public class LoginUserCommand : IRequest<Result<LoginViewModel>>
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
        public class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, Result<LoginViewModel>>
        {
            private readonly IIdentityService _context;
            public LoginUserCommandHandler(IIdentityService context)
            {
                _context = context;
            }

            public async Task<Result<LoginViewModel>> Handle(LoginUserCommand request, CancellationToken cancellationToken)
            {
                var result = await _context.LoginAsync(request.UserName, request.Password, request.Email);

                return new Result<LoginViewModel>(true, new string[] { string.Format("Successfuly logged in as {0}", request.UserName) }, result);
            }
        }
    }
}
