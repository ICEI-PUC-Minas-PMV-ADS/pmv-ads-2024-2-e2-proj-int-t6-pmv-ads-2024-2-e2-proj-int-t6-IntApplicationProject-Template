using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;

namespace PetMatch.Controllers
{
    [Route("api/contact")]
    public class ContactController : ControllerBase
    {
        [HttpPost("send-email")]
        public IActionResult SendEmail([FromForm] string name, [FromForm] string email, [FromForm] string message)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(message))
                {
                    return BadRequest(new { success = false, message = "Todos os campos são obrigatórios." });
                }

                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("contato.petmatch@gmail.com", "suxfsdlboqlobwmv"),
                    EnableSsl = true,
                };

                var mailMessage = new MailMessage
                {
                    From = new MailAddress("contato.petmatch@gmail.com"),
                    Subject = "Contato via PetMatch",
                    Body = $"Nome: {name}\nEmail: {email}\n\nMensagem:\n{message}",
                    IsBodyHtml = false,
                };

                mailMessage.To.Add("contato.petmatch@gmail.com");
                smtpClient.Send(mailMessage);

                return Ok(new { success = true, message = "Mensagem enviada com sucesso!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = $"Erro ao enviar: {ex.Message}" });
            }
        }
    }
}