using Microsoft.AspNetCore.Identity;
using PortalSystemWebApp.Model;

namespace PortalSystemWebApp.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public List<ProgramClass> EnrolledPrograms { get; } = [];
    }

}
