namespace ProjectMajor.Models
{
    public class ReportsDTO
    {
        public int Id { get; set; }
        public string MajorChoosen { get; set; }
     
        public string StudentName { get; set; }
        public string CollegeName { get; set; }
        public int Total { get;set; }
        
        public double Result { get; set; }
        public double Pre { get; set; }
        public string Status { get; set; }

    }
}
