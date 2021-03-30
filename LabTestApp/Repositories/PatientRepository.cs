using LabTestApp.Data;
using LabTestApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabTestApp.Repositories
{
    public class PatientRepository
    {
        private readonly ApplicationDbContext _context;

        public PatientRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        //not being used
        public List<Patient> GetAll()
        {
            var All = _context.Patient.Include(i => i.UserProfile)
                                     .OrderByDescending(i => i.LastName)
                                     .ToList();
            return All;
        }

        //adding an item
        //my understanding that SaveChanges saves the item to the database after adding
        public void Add(Patient patient)
        {
            _context.Add(patient);
            _context.SaveChanges();
        }

        public Patient GetById(int id)
        {
            return _context.Patient.Include(i => i.UserProfile)
                .Include(i => i.UserProfileId)
                .FirstOrDefault(i => i.Id == id);
        }

   


        public void Update(Patient patient)
        {
            _context.Entry(patient).State = EntityState.Modified;
            _context.SaveChanges();
        }


        public void Delete(int id)
        {
            var patient = GetById(id);


            _context.Patient.Remove(patient);
            _context.SaveChanges();
        }
    }
}

