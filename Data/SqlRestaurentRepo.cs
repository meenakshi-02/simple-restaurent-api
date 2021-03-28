using restaurent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restaurent.Data
{
    public class SqlRestaurentRepo : Irestaurentrepo
    {
        private readonly RestaurentContext _context;

        public SqlRestaurentRepo(RestaurentContext context)
        {
            _context = context;
        }


        //Customer
        public IEnumerable<Customer> GetAllCustomer()
        {
            return _context.Customers.ToList();
        }
        public Customer GetCustomerById(int id)
        {
            return _context.Customers.FirstOrDefault(p => p.Id == id);
        }
        public void CreateCustomer(Customer ctr)
        {
            if (ctr == null)
            {
                throw new ArgumentNullException(nameof(ctr));
            }

            _context.Customers.Add(ctr);
        }
        public void UpdateCustomer(Customer ctr)
        {
            //throw new NotImplementedException();
        }
        public void DeleteCustomer(Customer ctr)
        {
            if (ctr == null)
            {
                throw new ArgumentNullException(nameof(ctr));
            }
            _context.Customers.Remove(ctr);
        }


        //MenuItem
        public IEnumerable<MenuItem> GetAllMenuItem()
        {
            return _context.MenuItems.ToList();
        }


        //Order
        public IEnumerable<Order> GetAllOrder()
        {
            return _context.Orders.ToList();
        }
        public Order GetOrderById(int id)
        {
            return _context.Orders.FirstOrDefault(p => p.Id == id);
        }
        public void CreateOrder(Order ord)
        {
            if (ord == null)
            {
                throw new ArgumentNullException(nameof(ord));
            }

            _context.Orders.Add(ord);
        }


        //Transaction
        public IEnumerable<Transaction> GetAllTransaction()
        {
            return _context.Transactions.ToList();
        }
        public Transaction GetTransactionById(int id)
        {
            return _context.Transactions.FirstOrDefault(p => p.Id == id);
        }
        public void CreateTransaction(Transaction tra)
        {
            if (tra == null)
            {
                throw new ArgumentNullException(nameof(tra));
            }

            _context.Transactions.Add(tra);
        }


        //SaveChanges
        public bool SaveChanges()
        {
            return (_context.SaveChanges() >=0);
        }
    }
}
