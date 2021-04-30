using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ighan.SimpleCMS.StorageModels
{
    public class Page
    {
        public Page()
        {
            PageSliders = new List<PageSlider>();
            PageAddvertisements = new List<PageAddvertisement>();
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Slug { get; set; }

        public string CoverUrl { get; set; }

        public string Content { get; set; }

        public List<PageSlider> PageSliders { get; set; }

        public List<PageAddvertisement> PageAddvertisements { get; set; }
    }
}
