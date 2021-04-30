namespace Ighan.SimpleCMS.StorageModels
{
    public class PageAddvertisement
    {
        public int Id { get; set; }

        public int PageId { get; set; }

        public int AddvertisementId { get; set; }

        public Page Page { get; set; }

        public Addvertisement Addvertisement { get; set; }
    }
}
