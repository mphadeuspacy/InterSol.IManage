using System;

namespace InterSol.IManage.Core.Infrastructure.Exceptions
{
    public class IManageException : Exception
    {
        /// <summary>
        /// Exception type for app exceptions
        /// </summary>
        public IManageException()
        { }

        public IManageException(string message) : base(message)
        { }

        public IManageException(string message, Exception innerException) : base(message, innerException)
        { }
    }
}
