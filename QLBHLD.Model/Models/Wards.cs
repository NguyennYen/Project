using QLBHLD.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHLD.Model
{
    [Table("Wards")]
    public class Wards : Auditable
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string code { get; set; }

        [Required]
        [StringLength(255)]
        public string wards_name { get; set; }

        [Required]
        public int district_id { get; set; }

        [ForeignKey("district_id")]
        public virtual Districts Districts{ get;set;}

        [StringLength(1023)]
        public string remark { get; set; }
    }
}
