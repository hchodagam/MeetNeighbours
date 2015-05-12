using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meetneighbours.DTO
{
    [Table("BusinessLists")]
    public class BusinessLists
    {
       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BusinessListID { get; set; }
        public string Name { get; set; }
        public string Caption { get; set; }
        public string Description { get; set; }
        public DateTime Since { get; set; }
        public int CategoryID { get; set; }
        public int SubCategoryID { get; set; }
        public int CityID { get; set; }
        public int LocalityID { get; set; }
        public int SBID { get; set; }
        public string HouseNo { get; set; }
        public string Landmark { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string URL { get; set; }
        public string Opening_Hours { get; set; }
        public string Permalink { get; set; }
        public string Contact_Person { get; set; }

    }
}
