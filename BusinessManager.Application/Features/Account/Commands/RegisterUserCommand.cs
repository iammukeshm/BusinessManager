using BusinessManager.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessManager.Application.Features.Account.Commands
{
    public class RegisterUserCommand : IRequest
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand>
        {
            private readonly IIdentityService _context;

            public RegisterUserCommandHandler(IIdentityService context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
            {

                var result = await _context.RegisterAsync(request.UserName, request.Password, request.Email);

                return Unit.Value;
                //return BadRequest(result.Errors.Select(x => x.Description));
            }
        }
    }
}
