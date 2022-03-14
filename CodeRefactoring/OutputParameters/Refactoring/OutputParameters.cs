using CodeRefactoring.Comments;
using System;
using System.Collections.Generic;

namespace CodeRefactoring.OutputParameters.Refactoring
{
    public class OutputParameters
    {
        public class CustomerResult
        {
            public IEnumerable<Customer> Customers { get; set; }
            public int TotalCount { get; set; }
        }


        public void DisplayCustomers()
        {
            var result = GetCustomers(pageIndex: 1);

            Console.WriteLine("Total customers: " + result.TotalCount);

            foreach (var customer in result.Customers)
                Console.WriteLine(customer);
        }

        public CustomerResult GetCustomers(int pageIndex)
        {
            int totalCount = 100;
            return new CustomerResult { Customers = new List<Customer>(), TotalCount = totalCount };
        }
    }
}
