﻿using BookStore.Application.Contracts;
using BookStore.Models;

namespace BookStore.Application.Services
{
    public class CustomerService : ICustomerService
    {
        ICustomerRepository _CustomerRepository { get; set; }

        public CustomerService(ICustomerRepository customerRepository) =>
          _CustomerRepository = customerRepository;


        public bool AddCustomer(Customer Customer)
        {
            bool isAdded = _CustomerRepository.Create(Customer);
            if (isAdded)
                _CustomerRepository.Save();
            return isAdded;
        }
        public bool DeleteCustomer(int customerID)
        {
            Customer customer=GetbyId(customerID);
            bool isDeleted = _CustomerRepository.Delete(customer);
            if (isDeleted)
                _CustomerRepository.Save();
            return isDeleted;
        }

        //Recorrect
        public List<Customer> GetAllPagination(int num, int pageIndex) =>
          _CustomerRepository.GetAll().Skip(num * (pageIndex - 1)).Take(num).ToList();
        public Customer GetbyId(int id) => _CustomerRepository.GetById(id);

        public bool UpdateCustomer(Customer Customer)
        {
            Customer UpdCustomer = GetbyId(Customer.Id);
            UpdCustomer.Address = Customer.Address;
            UpdCustomer.UserName = Customer.UserName;
            UpdCustomer.Password = Customer.Password;
            UpdCustomer.FirstName = Customer.FirstName;
            UpdCustomer.LastName = Customer.LastName;
            UpdCustomer.Email = Customer.Email;
            UpdCustomer.Phone = Customer.Phone;
            UpdCustomer.ProfilePic = Customer.ProfilePic;
            bool isUpdated = _CustomerRepository.Update(UpdCustomer);
            if (isUpdated)
                _CustomerRepository.Save();
            return isUpdated;

        }

        public Customer IsLogin(string username, string password) =>
          _CustomerRepository.GetAll().FirstOrDefault(Cust => (Cust.UserName == username && Cust.Password == password));


        public bool IsUsrEmailExisit(string usrEmail) =>
           _CustomerRepository.GetAll().Any(Cust => Cust.Email == usrEmail);

        public bool IsUsrNameExisit(string usrName) =>
          _CustomerRepository.GetAll().Any(Cust => Cust.UserName == usrName);

        public bool IsUsrPhoneExisit(string phone) =>
          _CustomerRepository.GetAll().Any(Cust => Cust.Phone == phone);
        public List<Order> ShowOrders(int CustomerId) =>
         _CustomerRepository.GetCustomerOrders(CustomerId).ToList();
        public void AddToCart(int bookId, int customerId, int quantity) =>
          _CustomerRepository.AddCartItem(bookId, customerId, quantity);
        public bool HasItemInCart(int customerId)
        {
            return _CustomerRepository.HasItemInCart(customerId);
        }

       
    }
}
