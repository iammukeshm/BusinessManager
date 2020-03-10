using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessManager.Application.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string name, object key, string propertyName)
            : base($"Entity '{name}' with {propertyName} : {key} was not found.")
        {
        }
    }
}
