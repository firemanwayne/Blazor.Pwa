using Domain.IdentityManagement.UserAggregate;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Shared.Models.ViewModels.LoginModel;

namespace BlazorApp.Pwa.Server.Pages
{
    [AllowAnonymous]
    public partial class LoginModel : PageModel
    {

        const string DefaultReturnUrl = "~/";
        const string LockOutPage = "./Lockout";
        const string TwoFactorPage = "./LoginWith2fa";

        private readonly ILogger<LoginModel> Logger;
        private readonly SignInManager<User> SignInManager;

        public LoginModel(
            SignInManager<User> SignInManager,
            ILogger<LoginModel> Logger)
        {
            this.Logger = Logger;
            this.SignInManager = SignInManager;
        }

        [BindProperty]
        public LoginViewModel Input { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
                ModelState.AddModelError(string.Empty, ErrorMessage);

            returnUrl ??= Url.Content(DefaultReturnUrl);

            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ExternalLogins = await GetExternalLogins();

            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content(DefaultReturnUrl);

            ExternalLogins = await GetExternalLogins();

            if (ModelState.IsValid)
            {
                var result = await SignInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, lockoutOnFailure: false);

                if (result.Succeeded)
                {
                    Logger.LogInformation("User logged in.");

                    return LocalRedirect(DefaultReturnUrl);
                }
                if (result.RequiresTwoFactor)
                    return RedirectToPage(TwoFactorPage, new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });

                if (result.IsLockedOut)
                {
                    Logger.LogWarning("User account locked out.");

                    return RedirectToPage(LockOutPage);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return Page();
                }
            }

            return Page();
        }

        async Task<IList<AuthenticationScheme>> GetExternalLogins()
        {
            return (await SignInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }
    }
}
