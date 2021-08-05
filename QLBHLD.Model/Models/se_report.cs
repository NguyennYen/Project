using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHLD.Model.Models
{
<<<<<<< HEAD:QLBHLD.Model/Models/ot_other_list_type.cs
    [Table("ot_other_list_type")]
    public class ot_other_list_type : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [StringLength(50)]
        public string code { get; set; }

        [StringLength(255)]
        public string name { get; set; }
=======
    [Table("se_report")]
    public class se_report
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int id { get; set; }
        [StringLength(50)]
        public string code { get; set; }
        [StringLength(255)]
        public string name { get; set; }

>>>>>>> 5425160ae37b24cdf02fff4c3460312b07fb9130:QLBHLD.Model/Models/se_report.cs
    }
}
