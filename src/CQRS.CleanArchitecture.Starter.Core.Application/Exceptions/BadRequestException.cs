using System;

namespace CQRS.CleanArchitecture.Starter.Core.Application.Exceptions
{
    public class BadRequestException: ApplicationException
    {
        public BadRequestException(string message): base(message)
        {

        }
    }
}
