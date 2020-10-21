using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarcinKrupnikLab3Zadanie.Models
{
    class AddClothe
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR")]
        [DisplayName("Clothe")]
        public string Clothe { get; set; }
        [Required(ErrorMessage = "It is needed")]

        [DisplayName("Price")]
        public int Price { get; set; }

        [DisplayName("Date")]
        public DateTime Date { get; set; }

        public int BrandId { get; set; }
        [ForeignKey("BrandId")]
        public virtual Brand Brand { get; set; }
    }
}
