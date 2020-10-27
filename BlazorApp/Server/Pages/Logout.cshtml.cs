using Domain.IdentityManagement.UserAggregate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace BlazorApp.Pwa.Server.Pages
{
    [AllowAnonymous]
    public class LogoutModel : PageModel
    {
        private readonly SignInManager<User> SignInManager;
        private readonly ILogger<LogoutModel> Logger;

        public LogoutModel(
            SignInManager<User> SignInManager,
            ILogger<LogoutModel> Logger)
        {
            this.SignInManager = SignInManager;
            this.Logger = Logger;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(string returnUrl = null)
        {
            await SignInManager.SignOutAsync();
            Logger.LogInformation("User logged out.");

            if (returnUrl != null)            
                return LocalRedirect(returnUrl);            
            else            
                return RedirectToPage();            
        }
    }
}
