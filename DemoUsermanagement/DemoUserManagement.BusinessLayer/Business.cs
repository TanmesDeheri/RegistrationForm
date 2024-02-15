using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoUserManagement.DataAccessLayer;

namespace DemoUserManagement.BusinessLayer
{
    public class Business
    {
        private readonly DemoUserManagement.DataAccessLayer.DataAccess dataAccessLayer;

        public Business()
        {
            dataAccessLayer = new DemoUserManagement.DataAccessLayer.DataAccess();
        }

        // Create operation
        public void AddUserDetail(DemoUserManagement.DataAccessLayer.UserDetail userDetail)
        {
            dataAccessLayer.AddUserDetail(userDetail);
        }

        // Read operation (get all UserDetails)
        public List<DemoUserManagement.DataAccessLayer.UserDetail> GetAllUserDetails()
        {
            return dataAccessLayer.GetAllUserDetails();
        }

        // Read operation (get UserDetails by ID)
        public DemoUserManagement.DataAccessLayer.UserDetail GetUserDetailById(int userId)
        {
            return dataAccessLayer.GetUserDetailById(userId);
        }

        // Update operation
        public void UpdateUserDetail(DemoUserManagement.DataAccessLayer.UserDetail userDetail)
        {
            dataAccessLayer.UpdateUserDetail(userDetail);
        }

        // Delete operation
        public void DeleteUserDetail(int userId)
        {
            dataAccessLayer.DeleteUserDetail(userId);
        }
        public void AddAddressDetail(AddressDetail addressDetail)
        {
            dataAccessLayer.AddAddressDetail(addressDetail);
        }

        public List<AddressDetail> GetAllAddressDetails()
        {
            return dataAccessLayer.GetAllAddressDetails();
        }

        public AddressDetail GetAddressDetailById(int addressId)
        {
            return dataAccessLayer.GetAddressDetailById(addressId);
        }

        public void UpdateAddressDetail(AddressDetail addressDetail)
        {
            dataAccessLayer.UpdateAddressDetail(addressDetail);
        }

        public void DeleteAddressDetail(int addressId)
        {
            dataAccessLayer.DeleteAddressDetail(addressId);
        }
        // CRUD operations for Country entity
        public void AddCountry(Country country)
        {
            dataAccessLayer.AddCountry(country);
        }

        public List<Country> GetAllCountries()
        {
            return dataAccessLayer.GetAllCountries();
        }

        public Country GetCountryById(int countryId)
        {
            return dataAccessLayer.GetCountryById(countryId);
        }

        public void UpdateCountry(Country country)
        {
            dataAccessLayer.UpdateCountry(country);
        }

        public void DeleteCountry(int countryId)
        {
            dataAccessLayer.DeleteCountry(countryId);
        }
        public void AddState(State state)
        {
            dataAccessLayer.AddState(state);
        }

        public List<State> GetAllStates()
        {
            return dataAccessLayer.GetAllStates();
        }

        public State GetStateById(int stateId)
        {
            return dataAccessLayer.GetStateById(stateId);
        }

        public void UpdateState(State state)
        {
            dataAccessLayer.UpdateState(state);
        }

        public void DeleteState(int stateId)
        {
            dataAccessLayer.DeleteState(stateId);
        }
    }
}
