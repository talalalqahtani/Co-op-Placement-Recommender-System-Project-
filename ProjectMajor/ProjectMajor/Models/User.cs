using System.ComponentModel.DataAnnotations;
namespace ProjectMajor.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }    
        public College College { get; set; }
        [Display(Name = "College")]
        public int CollegeId { get; set; }
        public Role Role { get; set; }
        [Display(Name = "Role")]
        public int RoleId { get; set; }
    }
}
