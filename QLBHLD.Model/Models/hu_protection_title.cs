using QLBHLD.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHLD.Model.Models
{
<<<<<<< HEAD:QLBHLD.Model/Models/ot_other_list.cs
    [Table("ot_other_list")]
    public class ot_other_list: Auditable
=======
    [Table("hu_protection_title")]
    public class hu_protection_title : Auditable
>>>>>>> 5425160ae37b24cdf02fff4c3460312b07fb9130:QLBHLD.Model/Models/hu_protection_title.cs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
<<<<<<< HEAD:QLBHLD.Model/Models/ot_other_list.cs

        [StringLength(50)]
        public string code { get; set; }


        //Tên size ủng/boots size
        //eg: 36,37,38,...
        [StringLength(255)]
        public string name { get; set; }


        //tham chiếu phần other_list_type
        //[ForeignKey("type_id")]
        public int type_id { get; set; }
=======
        [Required]
        [ForeignKey("title_id")]
        public virtual hu_tille fk_hu_title  { get; set; }
        [Required]
        public DateTime effect_date { get; set; }
        [Required]
        public DateTime expire_date { get; set; }
        [StringLength(1023)]
        public string remark { get; set; }
        

>>>>>>> 5425160ae37b24cdf02fff4c3460312b07fb9130:QLBHLD.Model/Models/hu_protection_title.cs
    }
}
