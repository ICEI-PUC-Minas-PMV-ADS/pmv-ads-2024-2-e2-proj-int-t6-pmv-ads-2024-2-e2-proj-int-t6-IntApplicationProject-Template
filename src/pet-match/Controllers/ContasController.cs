using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
//using pet_match.Services;
using pet_match.Models;

namespace pet_match.Controllers;


public class AccountController : Controller
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly SignInManager<IdentityUser> _signInManager;


    // precisa configurar um servico de envio de email
    //private readonly IEmailSender _emailSender;
    //public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IEmailSender emailSender)
    //{
    //    _userManager = userManager;
    //    _signInManager = signInManager;
    //    _emailSender = emailSender;
    //}

    [HttpGet]
    public IActionResult Login() => View();

    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        if (!ModelState.IsValid) return View(model);

        var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);
        if (result.Succeeded)
        {
            return RedirectToAction("Index", "Home");
        }

        ModelState.AddModelError(string.Empty, "Credenciais inválidas.");
        return View(model);
    }

    [HttpGet]
    public IActionResult ForgotPassword() => View();

    [HttpPost]
    public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model)
    {
        if (!ModelState.IsValid) return View(model);

        var user = await _userManager.FindByEmailAsync(model.Email);
        if (user == null)
        {
            return RedirectToAction("ForgotPasswordConfirmation");
        }

        var token = await _userManager.GeneratePasswordResetTokenAsync(user);
        var callbackUrl = Url.Action("ResetPassword", "Account", new { token, email = model.Email }, Request.Scheme);

        //await _emailSender.SendEmailAsync(model.Email, "Redefinir Senha",
        //    $"Por favor, redefina sua senha clicando no link: <a href='{callbackUrl}'>Redefinir Senha</a>");

        return RedirectToAction("ForgotPasswordConfirmation");
    }

    [HttpGet]
    public IActionResult ForgotPasswordConfirmation() => View();

    [HttpGet]
    public IActionResult ResetPassword(string token, string email) => View(new ResetPasswordViewModel { Token = token, Email = email });

    [HttpPost]
    public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
    {
        if (!ModelState.IsValid) return View(model);

        var user = await _userManager.FindByEmailAsync(model.Email);
        if (user == null)
        {
            return RedirectToAction("ResetPasswordConfirmation");
        }

        var result = await _userManager.ResetPasswordAsync(user, model.Token, model.Password);
        if (result.Succeeded)
        {
            return RedirectToAction("ResetPasswordConfirmation");
        }

        foreach (var error in result.Errors)
        {
            ModelState.AddModelError(string.Empty, error.Description);
        }
        return View(model);
    }

    [HttpGet]
    public IActionResult ResetPasswordConfirmation() => View();
}
