using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DataStatsMVC.Areas.Identity
{
    //This class is a custom extension of the UserClaimsPrincipalFactory (it also derives from it) as it is reponsible
    //for added new claims to the default IdentityUser models, however as we have extended the default IdentityUser model
    //(ApplicationUser), we also have to extended the ClaimsPrincipalFactory to add new claims to our custom user model.
    public class ApplicationUserClaimsPrincipalFactory : UserClaimsPrincipalFactory<ApplicationUser, IdentityRole>
    {
        public ApplicationUserClaimsPrincipalFactory(UserManager<ApplicationUser> userManager, 
            IOptions<IdentityOptions> options, RoleManager<IdentityRole> roleManager) : base(userManager, roleManager, options)
        {
        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(ApplicationUser user)
        {
            var identity = await base.GenerateClaimsAsync(user);

            identity.AddClaim(new Claim("Gender", user.Gender));
            identity.AddClaim(new Claim("CareerStart", user.CareerStart.ToShortDateString()));
            identity.AddClaim(new Claim("CurrentlyEmployed", user.CurrentlyEmployed.ToString()));

            return identity;
        }
    }
}
