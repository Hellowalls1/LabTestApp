using LabTestApp.Data;
using LabTestApp.Models;
using LabTestApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabTestApp.Controllers
{
    
       [Route("api/[controller]")]
       [ApiController]

        public class UserProfileController : ControllerBase
        {
            private readonly UserProfileRepository _userProfileRepository;
           
            public UserProfileController(ApplicationDbContext context)
            {
                _userProfileRepository = new UserProfileRepository(context);
               
            }

            [HttpGet("{firebaseUserId}")]
            public IActionResult GetByFirebaseUserId(string firebaseUserId)
            {
                var userProfile = _userProfileRepository.GetByFirebaseUserId(firebaseUserId);
                if (userProfile == null)
                {
                    return NotFound();
                }
                return Ok(userProfile);
            }


            [HttpPost]
            public IActionResult Register(UserProfile userProfile)
            {
                _userProfileRepository.Add(userProfile);
                return CreatedAtAction(
                    nameof(GetByFirebaseUserId), new { firebaseUserId = userProfile.FirebaseUserId }, userProfile);
            }
        }
    }


