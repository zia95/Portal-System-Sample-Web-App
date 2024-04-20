using PortalSystemWebApp.Data;

namespace PortalSystemWebApp.Model
{
    public class ProgramClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public int GradeLevel { get; set; }
        public int MaxClassSize { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public List<ApplicationUser> EnrolledUsers { get; } = [];
    }
}
