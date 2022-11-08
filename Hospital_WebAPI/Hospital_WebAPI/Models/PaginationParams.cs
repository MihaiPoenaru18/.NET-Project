namespace Hospital_WebAPI.Models
{
    public class PaginationParams
    {
        private int _maxItemsPerPage = 20;
        private int itemsPerPage;
        public int Page {get;set;}
        public int ItemsPerPage 
        {
            get => itemsPerPage;
            set => itemsPerPage = value > _maxItemsPerPage ? _maxItemsPerPage :value;
        }
    }
}
