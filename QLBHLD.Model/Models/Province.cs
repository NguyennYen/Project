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
    public class Province : Auditable
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string code { get; set; }

        [Required]
        [StringLength(255)]
        public string province_name { get; set; }

        [Required]
        public int nation_id { get; set; }

        [ForeignKey("nation_id")]
        public virtual Nationalities Nationalities { get; set; }

        [StringLength(1023)]
        public string remark { get; set; }
        
        public virtual IEnumerable<Districts> Districts { get; set; }
    }
}
