using BankBusinessService.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using System.Xml.Linq;

namespace BankBusinessService.Controllers
{
    [Route("api/[controller]")]
    public class UserDashboardController : Controller
    {
        public RestClient client = new RestClient("http://localhost:5116");
        public RestRequest request;
        public RestResponse response;

        public int numOfTransactions = 0;

        // GET: api/UserDashboard/GetProfile/{name}
        [HttpGet("{name}")]
        public IActionResult GetProfile(string name)
        {
            try
            {
                // Fetch user profile
                request = new RestRequest("api/UserProfiles/{name}", Method.Get);
                request.AddUrlSegment("name", name);
                response = client.Execute(request);

                if (!response.IsSuccessful)
                {
                    return StatusCode((int)response.StatusCode, "Failed to retrieve user profile.");
                }

                UserProfile profile = JsonConvert.DeserializeObject<UserProfile>(response.Content);
                if (profile == null)
                {
                    return NotFound("User profile not found.");
                }

                // Fetch account details
                request = new RestRequest("api/Accounts/{id}", Method.Get);
                request.AddUrlSegment("id", profile.UserProfileId);
                response = client.Execute(request);

                if (!response.IsSuccessful)
                {
                    return StatusCode((int)response.StatusCode, "Failed to retrieve account details.");
                }

                Account account = JsonConvert.DeserializeObject<Account>(response.Content);
                if (account == null)
                {
                    return NotFound("Account details not found.");
                }

                // Fetch transactions
                request = new RestRequest("api/Transactions/account/{accountId}", Method.Get);
                request.AddUrlSegment("accountId", account.AccountId);
                response = client.Execute(request);

                if (!response.IsSuccessful)
                {
                    return StatusCode((int)response.StatusCode, "Failed to retrieve transactions.");
                }

                List<Transaction> transactions = JsonConvert.DeserializeObject<List<Transaction>>(response.Content);
                numOfTransactions = transactions.Count;

                // Return JSON response instead of rendering a view
                return Json(new
                {
                    profileID = profile.UserProfileId,
                    name = profile.Name,
                    email = profile.Email,
                    phone = profile.Phone,
                    address = profile.Address,
                    picture = profile.Picture,
                    password = profile.Password,
                    accountNo = account.AccountId,
                    balance = account.Balance,
                    transactionsList = transactions
                });
            }
            catch (JsonSerializationException e)
            {
                return BadRequest("Error in processing JSON response: " + e.Message);
            }
            catch (Exception e)
            {
                return StatusCode(500, "An unexpected error occurred: " + e.Message);
            }
        }

        // PUT: api/UserDashboard/UpdateProfile/{update}
        [HttpPut("{update}")]
        public IActionResult UpdateProfile([FromBody] UserProfile userProfile, [FromQuery] string originalName)
        {
            bool isNameChanged = false;
            try
            {
                if (userProfile == null)
                {
                    return BadRequest("User profile is null.");
                }
                else if (userProfile.Name.Any(char.IsDigit))
                {
                    return BadRequest("Users name cannot have numbers");
                }

                isNameChanged = !string.Equals(originalName, userProfile.Name);


                if (userProfile.Password == "password123")
                {
                    Console.WriteLine("hello");
                    //userProfile.Password = LoginController.HashPassword(userProfile.Password);
                }

                request = new RestRequest("api/UserProfiles/{id}", Method.Put);
                request.AddUrlSegment("id", userProfile.UserProfileId);
                request.RequestFormat = RestSharp.DataFormat.Json;
                request.AddBody(userProfile);
                response = client.Execute(request);

                if (!response.IsSuccessful)
                {
                    return StatusCode((int)response.StatusCode, "Failed to update user profile.");
                }

                // If the name has changed, update the account's name
                if (isNameChanged)
                {
                    request = new RestRequest("api/Accounts/{id}", Method.Get);
                    request.AddUrlSegment("id", userProfile.UserProfileId);
                    response = client.Execute(request);

                    if (!response.IsSuccessful)
                    {
                        return StatusCode((int)response.StatusCode, "Failed to retrieve account.");
                    }

                    Account account = JsonConvert.DeserializeObject<Account>(response.Content);

                    if (account != null)
                    {
                        // Update the account's name to the new name
                        account.AccountHolderName = userProfile.Name;

                        // Send the updated account back to the server
                        request = new RestRequest("api/Accounts/{id}", Method.Put);
                        request.AddUrlSegment("id", account.AccountId);
                        request.RequestFormat = RestSharp.DataFormat.Json;
                        request.AddBody(account);
                        response = client.Execute(request);

                        if (!response.IsSuccessful)
                        {
                            return StatusCode((int)response.StatusCode, "Failed to update account name.");
                        }
                    }

                }

                UserProfile profile = JsonConvert.DeserializeObject<UserProfile>(response.Content);
                return Ok(profile);
            }
            catch (JsonSerializationException e)
            {
                return BadRequest("Error in processing JSON response: " + e.Message);
            }
            catch (Exception e)
            {
                return StatusCode(500, "An unexpected error occurred: " + e.Message);
            }
        }

        // POST: api/UserDashboard/DoTransactions
        [HttpPost]
        public IActionResult DoTransactions([FromBody]Transaction transaction)
        {
            try
            {
                if (transaction == null)
                {
                    return BadRequest("Transaction is null");
                }

                transaction.TransactionId = numOfTransactions++;

                request = new RestRequest("api/Transactions", Method.Post);
                request.RequestFormat = RestSharp.DataFormat.Json;
                request.AddBody(transaction);
                response = client.Execute(request);

                if (!response.IsSuccessful)
                {
                    return StatusCode((int)response.StatusCode, "Failed to process the transaction.");
                }

                Transaction data = JsonConvert.DeserializeObject<Transaction>(response.Content);
                return Ok(data);
            }
            catch (JsonSerializationException e)
            {
                return BadRequest("Error in processing JSON response: " + e.Message);
            }
            catch (Exception e)
            {
                return StatusCode(500, "An unexpected error occurred: " + e.Message);
            }
        }

        // DELETE: api/UserDashboard/Delete/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                // Delete the user profile
                request = new RestRequest("api/UserProfiles/{id}", Method.Delete);
                request.AddUrlSegment("id", id);
                response = client.Execute(request);

                if (!response.IsSuccessful)
                {
                    return StatusCode((int)response.StatusCode, "Failed to update user profile.");
                }

                // Delete the account
                request = new RestRequest("api/Accounts/{id}", Method.Delete);
                request.AddUrlSegment("id", id);
                response = client.Execute(request);

                if (!response.IsSuccessful)
                {
                    return StatusCode((int)response.StatusCode, "Failed to update accounts.");
                }

                return Ok();
            }
            catch (JsonSerializationException e)
            {
                return BadRequest("Error in processing JSON response: " + e.Message);
            }
            catch (Exception e)
            {
                return StatusCode(500, "An unexpected error occurred: " + e.Message);
            }
        }

    }
}