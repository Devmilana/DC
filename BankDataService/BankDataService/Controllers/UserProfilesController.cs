using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BankDataService.Data;
using BankDataService.Models;
using System.Text;

namespace BankDataService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfilesController : ControllerBase
    {
        private readonly DBManager _context;

        public UserProfilesController(DBManager context)
        {
            _context = context;
        }

        // GET: api/UserProfiles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserProfile>>> GetUserProfiles()
        {
            if (_context.UserProfiles == null)
            {
                return NotFound();
            }

            try
            {
                return await _context.UserProfiles.ToListAsync();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error retrieving user profiles: {ex.Message}");
            }
        }

        // GET: api/UserProfiles/[name]
        [HttpGet("{search}")]
        public async Task<ActionResult<UserProfile>> GetUserProfile(string search)
        {
            int id = -1;
            if (string.IsNullOrEmpty(search))
            {
                return BadRequest("Please enter a valid email address or username");
            }

            try
            {
                if (search.Contains("@gmail.com"))
                {
                    foreach (var profile in _context.UserProfiles)
                    {
                        if (profile.Email == search)
                        {
                            id = profile.UserProfileId;
                            break;
                        }
                    }
                }
                else
                {
                    foreach (var profile in _context.UserProfiles)
                    {
                        if (profile.Name == search)
                        {
                            id = profile.UserProfileId;
                            break;
                        }
                    }
                }

                var userProfile = await _context.UserProfiles.FindAsync(id);

                if (userProfile == null || id == -1)
                {
                    return NotFound("The email or username entered does not exist");
                }

                return userProfile;
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error retrieving user profile: {ex.Message}");
            }
        }

        // PUT: api/UserProfiles/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserProfile(int id, UserProfile userProfile)
        {
            if (id != userProfile.UserProfileId)
            {
                return BadRequest("User profile ID mismatch.");
            }

            _context.Entry(userProfile).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserProfileExists(id))
                {
                    return NotFound();
                }
                return StatusCode(StatusCodes.Status500InternalServerError, "Error updating user profile.");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error updating user profile: {ex.Message}");
            }

            return NoContent();
        }

        // POST: api/UserProfiles
        [HttpPost]
        public async Task<ActionResult<UserProfile>> PostUserProfile(UserProfile userProfile)
        {
            if (userProfile == null || string.IsNullOrEmpty(userProfile.Email) || string.IsNullOrEmpty(userProfile.Password))
            {
                return BadRequest("User profile must contain valid email and password.");
            }

            userProfile.Password = DBManager.HashPassword(userProfile.Password);
            userProfile.Picture = DBManager.GenerateLetterImageAsBase64(userProfile.Name[0]);

            try
            {
                // Save profile to DB
                _context.UserProfiles.Add(userProfile);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetUserProfile", new { id = userProfile.UserProfileId }, userProfile);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error saving user profile: {ex.Message}");
            }
        }

        // DELETE: api/UserProfiles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserProfile(int id)
        {
            if (_context.UserProfiles == null)
            {
                return NotFound();
            }

            var userProfile = await _context.UserProfiles.FindAsync(id);
            if (userProfile == null)
            {
                return NotFound();
            }

            try
            {
                _context.UserProfiles.Remove(userProfile);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error deleting user profile: {ex.Message}");
            }

            return NoContent();
        }

        // Check if a user profile exists
        private bool UserProfileExists(int id)
        {
            return (_context.UserProfiles?.Any(e => e.UserProfileId == id)).GetValueOrDefault();
        }
    }
}