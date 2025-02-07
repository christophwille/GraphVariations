namespace GraphVariations.Common
{
    public class PagedRequestResponse<T>
    {
        public PagedRequestResponse(List<T> entities)
        {
            Entities = entities;
        }
        public PagedRequestResponse(List<T> entities, int pageRequests)
        {
            Entities = entities;
            PageRequests = pageRequests;
        }

        public List<T> Entities { get; set; }
        public int PageRequests { get; set; }
    }
}
