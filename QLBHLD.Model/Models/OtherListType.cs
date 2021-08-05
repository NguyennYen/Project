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
    [Table("Provinces")]
    public class OtherListType : Auditable
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string code { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }

        [Required]
        public int type_id { get; set; }

        [ForeignKey("type_id")]
        public virtual List_type List_Type { get; set; }

       
        [StringLength(1023)]
        public string remark { get; set; }
    }
}
