using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CodeRefactoring.Comments.Refactoring
{
    public class Comments
    {
        private int _payFrequency;
        private DbContext _dbContext;

        public Comments()
        {
            _dbContext = new DbContext();
        }

        public List<Customer> GetCustomers(int countryCode)
        {
            //TODO: We need to get rid of abcd once we revisit this method. Currently, it's 
            // creating a coupling betwen x and y and because of that we're not able to do 
            // xyz. 

            if (countryCode == -1)
                return null;

            throw new NotImplementedException();
        }

        public void SubmitOrder(Order order)
        {
            SaveOrder(order);

            NotifyCustomer(order);
        }

        private void SaveOrder(Order order)
        {
            _dbContext.Orders.Add(order);
            _dbContext.SaveChanges();
        }

        private void NotifyCustomer(Order order)
        {
            var client = new SmtpClient();
            var message = new MailMessage("badcomments@example.com", order.Customer.Email, "Your order was successfully placed.", ".");
            client.Send(message);
        }
    }

    public class DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public void SaveChanges()
        {


        }
    }

    public class DbSet<T>
    {
        public void Add(Order order)
        {


        }
    }
    public class Order
    {
        public Customer Customer { get; set; }
    }

    public class Customer
    {
        public string Email { get; set; }
    }
}
