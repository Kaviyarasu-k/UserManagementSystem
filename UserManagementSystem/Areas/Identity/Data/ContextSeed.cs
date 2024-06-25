using Microsoft.AspNetCore.Identity;
using UserManagementSystem.Data;

namespace UserManagementSystem.Areas.Identity.Data
{
    
    public class ContextSeed
    {
    public static async Task SeedRolesAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
    {
            //Seed Roles
            
        await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Admin.ToString()));
        
        await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Basic.ToString()));
    }

        public static async Task SeedAdminAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Default User
            var defaultUser = new ApplicationUser
            {
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                Name = "kaviyarasuad",
                EmailConfirmed = true,
                PhoneNumberConfirmed = false
            };
            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "Admin_user_123");                    
                    await userManager.AddToRoleAsync(defaultUser, Enums.Roles.Admin.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Enums.Roles.Basic.ToString());
                }

            }
        }




    }


}
