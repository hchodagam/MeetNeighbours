using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meetneighbours.DTO
{
    [Table("Category")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryID { get; set; }
        public string Name{ get; set; }
        public string Description { get; set; }
        
        public DateTime AddedOn
        {
            get;
            set; 
        }
        [DefaultValue(1)]
        public bool Active{ get; set; }
        public DateTime? DeactivatedOn { get; set; }
        public int LastUpdatedBy { get; set; }

    }
}
