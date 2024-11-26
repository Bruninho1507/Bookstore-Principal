namespace Bookstore.Services.Exeptions
{
    public class IntegrityExeption : ApplicationException
    {
        public IntegrityExeption(string? message) : base(message)
        {
        }
    }
}