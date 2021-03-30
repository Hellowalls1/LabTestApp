using LabTestApp.Data;
using LabTestApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabTestApp.Repositories
{
    public class UserProfileRepository
    {
        private readonly ApplicationDbContext _context;

        public UserProfileRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public UserProfile GetByFirebaseUserId(string firebaseUserId)
        {
            return _context.User
               .FirstOrDefault(u => u.FirebaseUserId == firebaseUserId);
        }

        

        public void Add(UserProfile userprofile)
        {
            _context.Add(userprofile);
            _context.SaveChanges();
        }
    }
}
