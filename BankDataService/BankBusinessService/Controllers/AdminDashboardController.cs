using BankBusinessService.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;

namespace BankBusinessService.Controllers
{
    [Route("api/[controller]")]
    public class AdminDashboardController : Controller
    {
        public RestClient client = new RestClient("http://localhost:5116");
        public RestRequest request;
        public RestResponse response;

        int numOfAccounts = 0;

        // GET: api/AdminDashboard/GetProfile/{name}
        [HttpGet("{name}")]
        public IActionResult GetProfile(string name)
        {
            request = new RestRequest("api/UserProfiles/{name}", Method.Get);
            request.AddUrlSegment("name", name);
            response = client.Execute(request);
            UserProfile profile = JsonConvert.DeserializeObject<UserProfile>(response.Content);

            // Return JSON response
            return Json(new
            {
                profileID = profile.UserProfileId,
                name = profile.Name,
                email = profile.Email,
                phone = profile.Phone,
                address = profile.Address,
                picture = profile.Picture,
                password = profile.Password
            });
        }

        // GET: api/AdminDashboard/GetAll
        [HttpGet]
        public IActionResult GetAll()
        {
            List<UserProfile> userProfiles = GetAllProfiles();

            request = new RestRequest("api/Transactions", Method.Get);
            response = client.Execute(request);
            List<Transaction> transactions = JsonConvert.DeserializeObject<List<Transaction>>(response.Content);

            return Json(new
            {
                userProfileList = userProfiles,
                transactionsList = transactions
            });
        }

        // PUT: api/AdminDashboard/UpdateProfile
        [HttpPut("{update}")]
        public IActionResult UpdateProfile([FromBody] UserProfile userProfile)
        {
            if (userProfile == null)
            {
                return BadRequest("User profile is null.");
            }
            else if (userProfile.Name.Any(char.IsDigit))
            {
                return BadRequest("Users name cannot have numbers");
            }

            request = new RestRequest("api/UserProfiles/{id}", Method.Put);
            request.AddUrlSegment("id", userProfile.UserProfileId);
            request.RequestFormat = RestSharp.DataFormat.Json;
            request.AddBody(userProfile);
            response = client.Execute(request);

            UserProfile profile = JsonConvert.DeserializeObject<UserProfile>(response.Content);
            return Ok(profile);
        }

        // POST: api/AdminDashboard/CreateAccount
        [HttpPost]
        public IActionResult CreateAccount([FromBody] UserProfile userProfile)
        {
            List<UserProfile> profiles = GetAllProfiles();

            Console.WriteLine("starting creation");
            if (userProfile == null)
            {
                return BadRequest("User profile is null.");
            }
            else if (userProfile.Name.Any(char.IsDigit))
            {
                return BadRequest("Users name cannot have numbers");
            }
            else if (profiles.Any(profile => profile.Name.Equals(userProfile.Name, StringComparison.OrdinalIgnoreCase)))
            {
                return BadRequest("Profile with this name already exists");
            }

            // Increment the number of accounts
            numOfAccounts++;
            userProfile.UserProfileId = numOfAccounts;

            request = new RestRequest("api/UserProfiles", Method.Post);
            request.RequestFormat = RestSharp.DataFormat.Json;
            request.AddBody(userProfile);
            response = client.Execute(request);

            if (!response.IsSuccessful)
            {
                return StatusCode((int)response.StatusCode, response.Content);
            }

            UserProfile profile = JsonConvert.DeserializeObject<UserProfile>(response.Content);

            // Create an account for the new user
            Account newAccount = new Account
            {
                AccountId = userProfile.UserProfileId,
                AccountHolderName = userProfile.Name,
                Balance = 0,
                CreatedAt = DateTime.Now
            };

            request = new RestRequest("api/Accounts", Method.Post);
            request.RequestFormat = RestSharp.DataFormat.Json;
            request.AddBody(newAccount);

            response = client.Execute(request);
            if (!response.IsSuccessful)
            {
                return StatusCode((int)response.StatusCode, "Failed to process the transaction.");
            }
            Account account = JsonConvert.DeserializeObject<Account>(response.Content);
            return Ok();
        }

        // Function to get all user profiles
        public List<UserProfile> GetAllProfiles()
        {
            request = new RestRequest("api/UserProfiles", Method.Get);
            response = client.Execute(request);
            List<UserProfile> userProfiles = JsonConvert.DeserializeObject<List<UserProfile>>(response.Content);
            numOfAccounts = userProfiles.Count();

            return userProfiles;
        }
    }
}
