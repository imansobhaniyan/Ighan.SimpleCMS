using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ighan.SimpleCMS.DataAccessLayer
{
    public class SimpleCMSDbContext : DbContext
    {
        public SimpleCMSDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<StorageModels.Addvertisement> Addvertisements { get; set; }

        public DbSet<StorageModels.ContactInfo> ContactInfos { get; set; }

        public DbSet<StorageModels.Menu> Menus { get; set; }

        public DbSet<StorageModels.Page> Pages { get; set; }

        public DbSet<StorageModels.PageAddvertisement> PageAddvertisements { get; set; }

        public DbSet<StorageModels.PageSlider> PageSliders { get; set; }

        public DbSet<StorageModels.Slide> Slides { get; set; }
    }
}
