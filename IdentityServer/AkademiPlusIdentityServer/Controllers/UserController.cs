using AkademiPlusIdentityServer.Dtos;
using AkademiPlusIdentityServer.Models;
using IdentityServer4.Hosting.LocalApiAuthentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using static IdentityServer4.IdentityServerConstants;

namespace AkademiPlusIdentityServer.Controllers
{
    [Authorize(LocalApi.PolicyName)]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(SingUpDto signUpDto)
        {
            var user = new ApplicationUser()
            {
                NameSurname = signUpDto.NameSurname,
                UserName = signUpDto.UserName,
                Email = signUpDto.Email,
                City = signUpDto.City
            };
            await _userManager.CreateAsync(user, signUpDto.Password);

            return Ok("Kayıt Başarılı Oluşturuldu");
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userManager.Users.ToListAsync();
            return Ok(users);
        }
    }
}