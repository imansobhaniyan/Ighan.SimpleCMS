namespace Ighan.SimpleCMS.StorageModels
{
    public class PageSlider
    {
        public int Id { get; set; }

        public int PageId { get; set; }

        public int SliderId { get; set; }

        public Page Page { get; set; }

        public Slide Slide { get; set; }
    }
}
