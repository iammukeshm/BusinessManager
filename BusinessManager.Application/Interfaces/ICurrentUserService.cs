﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessManager.Application.Interfaces
{
    public interface ICurrentUserService
    {
        string UserId { get; }
    }
}
