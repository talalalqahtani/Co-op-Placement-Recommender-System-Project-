using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjectMajor.Models
{
    public class Question
    {
        public int Id { get; set; }

        public string Descrption { get; set; }

        public Major Major { get; set; }
        [Display(Name = "Major")]
        public int MajorId { get; set; }

    }
}
