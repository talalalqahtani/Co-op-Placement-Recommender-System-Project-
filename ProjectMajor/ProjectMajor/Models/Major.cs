using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjectMajor.Models
{
    public class Major
    {
        public int Id { get; set; }
        public string Name { get; set;}
        public College College { get; set; }
        [Display(Name = "College")]
        public int CollegeId { get; set; }
    }
}
