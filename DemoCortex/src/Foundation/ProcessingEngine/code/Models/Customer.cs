using System.Collections.Generic;

namespace Demo.Foundation.ProcessingEngine.Models
{
    public class Customer : CustomerBusinessValue
    {
        public Customer()
        {
            Invoices = new List<PurchaseInvoice>();
        }
        public string CustomerId { get; set; }
        public IList<PurchaseInvoice> Invoices { get; set; }
    }
}
