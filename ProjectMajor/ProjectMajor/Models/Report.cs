namespace ProjectMajor.Models
{
    public class Report
    {
        public int Id { get; set; }
        public Major MajorChoosen { get; set; }
        public int MajorChoosenId { get; set; }
        public Student Student { get; set; }
        public int StudentId { get; set; }
        public double Result { get; set; }
        public string Recommendation { get; set; }
    }
}
