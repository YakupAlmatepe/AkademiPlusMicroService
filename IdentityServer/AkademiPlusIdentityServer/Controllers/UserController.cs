using AkademiPlusIdentityServer.Dtos;
using AkademiPlusIdentityServer.Models;
using IdentityServer4.Hosting.LocalApiAuthentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
                UserName = signUpDto.UserName,
                Email = signUpDto.Email,
                NameSurname = signUpDto.NameSurname,
                City = signUpDto.City
            };
            await _userManager.CreateAsync(user, signUpDto.Password);

            return Ok("Kullanıcı oluşturuldu");
        }
    }
}

