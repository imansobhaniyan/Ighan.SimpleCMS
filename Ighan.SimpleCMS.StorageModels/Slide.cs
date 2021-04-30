using System.Collections.Generic;

namespace Ighan.SimpleCMS.StorageModels
{
    public class Slide
    {
        public Slide()
        {
            PageSliders = new List<PageSlider>();
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string ImageUrl { get; set; }

        public string Link { get; set; }

        public List<PageSlider> PageSliders { get; set; }
    }
}
