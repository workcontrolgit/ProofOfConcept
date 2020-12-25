
namespace ProofOfConcept.Application.Parameters
{
    public class RequestParameter
    {
        const int maxPageSize = 50;
        private int _pageSize = 20;
        public int PageNumber { get; set; } = 1;
        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = (value > maxPageSize) ? maxPageSize : value;
        }
        public RequestParameter()
        {
            this.PageNumber = 1;
            this.PageSize = 10;
        }
        public RequestParameter(int pageNumber, int pageSize)
        {
            this.PageNumber = pageNumber < 1 ? 1 : pageNumber;
            this.PageSize = pageSize > maxPageSize ? _pageSize : pageSize;
        }
    }
}
