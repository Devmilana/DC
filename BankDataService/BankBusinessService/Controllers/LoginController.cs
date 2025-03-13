using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using System.Text;
using BankBusinessService.Models;
using System.Security.Cryptography;

namespace BankBusinessService.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        public bool admin = false;

        // GET: api/Login/userview
        [HttpGet("userview")]
        public IActionResult GetUserView()
        {
            return PartialView("~/Views/Dashboard/UserDashboard.cshtml");
        }

        // GET: api/Login/adminview
        [HttpGet("adminview")]
        public IActionResult GetAdminView()
        {
            return PartialView("~/Views/Dashboard/AdminDashboard.cshtml");
        }

        // POST: api/Login/userAuth
        [HttpPost("userauth")]
        public IActionResult AuthenticateUser([FromBody] User user)
        {
            var response = new { login = false };

            if (user == null)
            {
                return BadRequest("User object is null.");
            }

            try
            {
                // Check if profile exists with given username and password
                if (ProfileExists(user.UserName, user.PassWord))
                {
                    response = new { login = true };
                }
                else
                {
                    response = new { login = false };
                }
            }
            catch (Exception e)
            {
                return StatusCode(500, "An error occurred while authenticating: " + e.Message);
            }

            return Json(response);
        }

        // POST: api/Login/adminAuth
        [HttpPost("adminauth")]
        public IActionResult AuthenticateAdmin([FromBody] User user)
        {
            var response = new { login = false };

            if (user == null)
            {
                return BadRequest("User object is null.");
            }

            try
            {
                // Check if profile exists with given username and password
                if (ProfileExists(user.UserName, user.PassWord))
                {
                    //check if profile is an admin
                    if (admin)
                    {
                        response = new { login = true };
                    }
                    else
                    {
                        response = new { login = false };
                    }
                }
            }
            catch (Exception e)
            {
                return StatusCode(500, "An error occurred while authenticating: " + e.Message);
            }

            return Json(response);
        }

        // Function to get all user profiles
        public List<UserProfile> GetAllProfiles()
        {
            try
            {
                RestClient client = new RestClient("http://localhost:5116");
                RestRequest request = new RestRequest("api/UserProfiles", Method.Get);
                RestResponse response = client.Execute(request);

                if (!response.IsSuccessful)
                {
                    throw new Exception("Failed to retrieve user profiles. Status Code: " + response.StatusCode);
                }

                List<UserProfile> profiles = JsonConvert.DeserializeObject<List<UserProfile>>(response.Content);

                if (profiles == null)
                {
                    throw new Exception("Deserialization returned null. No profiles found.");
                }

                return profiles;
            }
            catch (Exception e)
            {
                throw new Exception("An error occurred while getting user profiles: " + e.Message);
            }
        }

        // Function to check if profile exists
        public bool ProfileExists(string username, string password)
        {
            try
            {
                //password = HashPassword(password);
                List<UserProfile> profiles = GetAllProfiles();

                foreach (var profile in profiles)
                {
                    if (profile.Name.Equals(username) && profile.Password.Equals(password))
                    {
                        if (profile.IsAdmin)
                        {
                            admin = true;
                        }
                        return true;
                    }
                }

                return false;
            }
            catch (Exception e)
            {
                throw new Exception("An error occurred while checking if profile exists: " + e.Message);
            }

        }

        // Function to hash password
        public static string HashPassword(string password)
        {
            try
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                    StringBuilder builder = new StringBuilder();
                    foreach (byte b in bytes)
                    {
                        builder.Append(b.ToString("x2"));
                    }
                    return builder.ToString();
                }
            }
            catch (Exception e)
            {
                throw new Exception("An error occurred while hashing password: " + e.Message);
            }
        }
    }

    public class User
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
    }
}