using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinKrupnikLab3Zadanie.Models
{
    class ClothesMagazineContext : DbContext
    {
        public ClothesMagazineContext() : base("AppContext")
        {

        }

        public virtual DbSet<AddClothe> Clothes { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<AddShoes> Shoes { get; set; }
        public virtual DbSet<BrandShoes> BrandsShoes { get; set; }
    }
}
