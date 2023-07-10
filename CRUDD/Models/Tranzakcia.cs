using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDD.Models
{
    public class Tranzakcia
    {


        [Key]
        public int TranzakciaId { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Номер счета")]
        [Required(ErrorMessage = "Это поле является обязательным.")]
        [MaxLength(12, ErrorMessage = "Максимум 12 символов.")]
        public string AccountNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Имя получателя")]
        [Required(ErrorMessage = "Это поле является обязательным.")]
        public string PoluchatelName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Название банка")]
        [Required(ErrorMessage = "Это поле является обязательным.")]
        public string BankName { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        [DisplayName("Быстрый код")]
        [Required(ErrorMessage = "Это поле является обязательным.")]
        [MaxLength(11, ErrorMessage = "Maximum 11 characters only.")]
        public string SWIFTCode { get; set; }

        [Required(ErrorMessage = "Это поле является обязательным.")]
        [DisplayName("Сумма")]
        public int Amout { get; set; }

        [DisplayName("Дата")]
        [DisplayFormat(DataFormatString = "{0:MMM-dd-yy}")]
        public DateTime Data { get; set; }


        //[Key]
        //public int TranzakciaId { get; set; }
        //[Column(TypeName = "nvarchar(12)")]
        //public string AccountNumber { get; set; }
        //[Column(TypeName = "nvarchar(100)")]
        //public string PoluchatelName { get; set; }
        //[Column(TypeName = "nvarchar(100)")]
        //public string BankName { get; set; }
        //[Column(TypeName = "nvarchar(11)")]
        //public string SWIFTCode { get; set; }
        //public int Amout { get; set; }
        //public DateTime Data { get; set; }

    }
}
