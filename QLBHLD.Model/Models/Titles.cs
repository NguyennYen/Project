using QLBHLD.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHLD.Model
{
    [Table("Titles")]
    public class Titles : Auditable
    {   
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string code { get; set; }

        [Required]
        [StringLength(255)]
        public string title_name { get; set; }

        [StringLength(1023)]
        public string remark { get; set; }
    }
}
