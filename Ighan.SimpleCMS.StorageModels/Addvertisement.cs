using System.Collections.Generic;

namespace Ighan.SimpleCMS.StorageModels
{
    public class Addvertisement
    {
        public Addvertisement()
        {
            PageAddvertisements = new List<PageAddvertisement>();
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string ImageUrl { get; set; }

        public string Link { get; set; }

        public List<PageAddvertisement> PageAddvertisements { get; set; }
    }
}
