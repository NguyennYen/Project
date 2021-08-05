using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBHLD.Model.Models
{
    [Table("se_function")]
    public class se_function
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int id { get; set; }
        [StringLength(255)]
        public string name { get; set; }
        [ForeignKey("group_id")]
        public virtual hu_protection_size fk_hu_protection_size { get; set; }
        public int fid { get; set; }

    }
}
