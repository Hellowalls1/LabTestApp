using LabTestApp.Data;
using LabTestApp.Models;
using LabTestApp.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace LabTestApp.Controllers
{
    
        [Route("api/[controller]")]
        [ApiController]
        public class PatientController : ControllerBase
        {
            private readonly PatientRepository _patientRepository;
            private readonly UserProfileRepository _userProfileRepository;
            //so controller has access to all of the methods

            public PatientController(ApplicationDbContext context)
            {
                _patientRepository = new PatientRepository(context);
                _userProfileRepository = new UserProfileRepository(context);
            }

            //getting the authorized/current user
            private UserProfile GetCurrentUser()
            {
                var firebaseUserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                return _userProfileRepository.GetByFirebaseUserId(firebaseUserId);
            }
            //not being used
            [Authorize]
            [HttpGet]
            public IActionResult Get()
            {
                return Ok(_patientRepository.GetAll());
            }


            //adding patient and assigning them to the user
            [HttpPost]
            public IActionResult Post(Patient patient)
            {
                var currentUser = GetCurrentUser();
                patient.UserProfileId = currentUser.Id;

                _patientRepository.Add(patient);
                return CreatedAtAction("Get", new { id = patient.Id }, patient);
            }

            //getting item by id
            [Authorize]
            [HttpGet("{id}")]
            public IActionResult Get(int id)
            {
                var item = _patientRepository.GetById(id);
                if (item == null)
                {
                    return NotFound();
                }
                return Ok(item);
            }




            //updating patient 
            [HttpPut("{id}")]
            public IActionResult Put(int id, Patient patient)
            {
                if (id != patient.Id)
                {
                    return BadRequest();
                }
                var currentUser = GetCurrentUser();
                patient.UserProfileId = currentUser.Id;

                _patientRepository.Update(patient);
                return NoContent();
            }
            
        //
            [HttpDelete("{id}")]
            public IActionResult Delete(int id)
            {

                _patientRepository.Delete(id);
                return NoContent();
            }
        }
    }

