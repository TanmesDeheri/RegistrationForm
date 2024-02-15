using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUserManagement.DataAccessLayer
{
    public class DataAccess
    {
        private DemoUserManagementEntities dbContext;

        public DataAccess()
        {
            dbContext = new DemoUserManagementEntities();
        }

        // Create operation
        public void AddUserDetail(UserDetail userDetail)
        {
            dbContext.UserDetails.Add(userDetail);
            dbContext.SaveChanges();
        }

        // Read operation (get all UserDetails)
        public List<UserDetail> GetAllUserDetails()
        {
            return dbContext.UserDetails.ToList();
        }

        // Read operation (get UserDetails by ID)
        public UserDetail GetUserDetailById(int userId)
        {
            return dbContext.UserDetails.Find(userId);
        }

        // Update operation
        public void UpdateUserDetail(UserDetail userDetail)
        {
            dbContext.Entry(userDetail).State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        // Delete operation
        public void DeleteUserDetail(int userId)
        {
            var userDetailToDelete = dbContext.UserDetails.Find(userId);
            if (userDetailToDelete != null)
            {
                dbContext.UserDetails.Remove(userDetailToDelete);
                dbContext.SaveChanges();
            }
        }
    }
};
