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
        public void AddAddressDetail(AddressDetail addressDetail)
        {
            dbContext.AddressDetails.Add(addressDetail);
            dbContext.SaveChanges();
        }

        // Read operation for AddressDetail (get all AddressDetails)
        public List<AddressDetail> GetAllAddressDetails()
        {
            return dbContext.AddressDetails.ToList();
        }

        // Read operation for AddressDetail (get AddressDetail by ID)
        public AddressDetail GetAddressDetailById(int addressId)
        {
            return dbContext.AddressDetails.Find(addressId);
        }

        // Update operation for AddressDetail
        public void UpdateAddressDetail(AddressDetail addressDetail)
        {
            dbContext.Entry(addressDetail).State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        // Delete operation for AddressDetail
        public void DeleteAddressDetail(int addressId)
        {
            var addressDetailToDelete = dbContext.AddressDetails.Find(addressId);
            if (addressDetailToDelete != null)
            {
                dbContext.AddressDetails.Remove(addressDetailToDelete);
                dbContext.SaveChanges();
            }
        }
        public void AddCountry(Country country)
        {
            dbContext.Countries.Add(country);
            dbContext.SaveChanges();
        }

        public List<Country> GetAllCountries()
        {
            return dbContext.Countries.ToList();
        }

        public Country GetCountryById(int countryId)
        {
            return dbContext.Countries.Find(countryId);
        }

        public void UpdateCountry(Country country)
        {
            dbContext.Entry(country).State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        public void DeleteCountry(int countryId)
        {
            var countryToDelete = dbContext.Countries.Find(countryId);
            if (countryToDelete != null)
            {
                dbContext.Countries.Remove(countryToDelete);
                dbContext.SaveChanges();
            }
        }
        // CRUD operations for State entity
        public void AddState(State state)
        {
            dbContext.States.Add(state);
            dbContext.SaveChanges();
        }

        public List<State> GetAllStates()
        {
            return dbContext.States.ToList();
        }

        public State GetStateById(int stateId)
        {
            return dbContext.States.Find(stateId);
        }

        public void UpdateState(State state)
        {
            dbContext.Entry(state).State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        public void DeleteState(int stateId)
        {
            var stateToDelete = dbContext.States.Find(stateId);
            if (stateToDelete != null)
            {
                dbContext.States.Remove(stateToDelete);
                dbContext.SaveChanges();
            }
        }
    }
};
