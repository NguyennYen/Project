using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHLD.Model.Models
{
<<<<<<< HEAD:QLBHLD.Model/Models/hu_protection.cs
    [Table("hu_protection")]
    public class hu_protection : Auditable 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        //Mã bảo hộ
        [StringLength(50)]
        public string code { get; set; }

        //Tên bảo hộ
        [StringLength(255)]
        public string protection_name { get; set; }
=======
    [Table("se_function_group")]
    public class se_function_group
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int id { get; set; }
        [StringLength(255)]
         public string  name { get; set; }
        [StringLength(1023)]
        public string remark { get; set; }

>>>>>>> 5425160ae37b24cdf02fff4c3460312b07fb9130:QLBHLD.Model/Models/se_function_group.cs
    }
}
