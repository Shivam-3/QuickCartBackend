using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using QuickCartAPIDomain.Entities;

namespace QuickCartAPI.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class UserController : ControllerBase
	{
		private readonly UserManager<User> _userManager;
		private readonly SignInManager<User> _signInManager;

		//public UserController(UserManager<User> userManager, SignInManager<User> signInManager)
		//{
		//	_userManager = userManager;
		//	_signInManager = signInManager;
		//}

		//[HttpPost("register")]
		//public async Task<IActionResult> Register([FromBody] RegisterModel model)
		//{
		//	//if (!ModelState.IsValid) return BadRequest(ModelState);

		//	//var user = new User { UserName = model.Email, Email = model.Email, FullName = model.FullName };
		//	//var result = await _userManager.CreateAsync(user, model.Password);

		//	//if (!result.Succeeded) return BadRequest(result.Errors);

		//	return Ok("User registered successfully");
		//}

		//[HttpPost("login")]
		//public async Task<IActionResult> Login([FromBody] LoginModel model)
		//{
		//	//var user = await _userManager.FindByEmailAsync(model.Email);
		//	//if (user == null) return Unauthorized("Invalid credentials");

		//	//var result = await _signInManager.PasswordSignInAsync(user.UserName, model.Password, false, false);
		//	//if (!result.Succeeded) return Unauthorized("Invalid credentials");

		//	return Ok("Login successful");
		//}

		//[Authorize]
		//[HttpGet("profile")]
		//public async Task<IActionResult> GetProfile()
		//{
		//	//var user = await _userManager.GetUserAsync(User);
		//	//if (user == null) return NotFound("User not found");

		//	//return Ok(new { user.Id, user.FullName, user.Email });
		//}
	}
}
