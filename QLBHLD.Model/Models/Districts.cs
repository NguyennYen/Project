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
    [Table("Districts")]
    public class Districts : Auditable
    {

        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string code { get; set; }

        [Required]
        [StringLength(255)]
        public string district_name { get; set; }

       [Required]
        public int province_id { get; set; }

        [ForeignKey("province_id")]
        public virtual Province Province { get; set; }

        [StringLength(1023)]
        public string remark { get; set; }

        public virtual IEnumerable<Wards> Wards { get; set; }
    }
}
