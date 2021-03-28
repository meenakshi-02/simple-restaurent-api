using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using restaurent.Models;

namespace restaurent.Data
{
    public interface Irestaurentrepo
    {
        //Customer
        IEnumerable<Customer> GetAllCustomer();
        Customer GetCustomerById(int id);
        void CreateCustomer(Customer ctr);
        void UpdateCustomer(Customer ctr);
        void DeleteCustomer(Customer ctr);

        //MenuItem
        IEnumerable<MenuItem> GetAllMenuItem();

        //Order
        IEnumerable<Order> GetAllOrder();
        Order GetOrderById(int id);
        void CreateOrder(Order ord);

        //Transaction
        IEnumerable<Transaction> GetAllTransaction();
        Transaction GetTransactionById(int id);
        void CreateTransaction(Transaction tra);

        //SaveChanges
        bool SaveChanges();
    }
}
