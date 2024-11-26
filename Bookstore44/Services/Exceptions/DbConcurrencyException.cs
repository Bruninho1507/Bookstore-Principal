using System.Runtime.Serialization;

namespace Bookstore.Services.Exceptions
{
    [Serializable]
    internal class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException(string? message) : base(message)
        {

        }

    }
}