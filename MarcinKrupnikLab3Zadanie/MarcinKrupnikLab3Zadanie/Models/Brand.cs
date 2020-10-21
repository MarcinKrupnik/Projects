using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MarcinKrupnikLab3Zadanie.Models
{
    class Brand
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Brand")]
        public string BrandName { get; set; }
        [DisplayName("Country of production")]
        public String Country { get; set; }
        public virtual List<AddClothe> Clothes { get; set; }
        public override string ToString()
        {
            return BrandName;
        }
    }
}
