using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InvoiceManagementMVC.Models
{
    public class Extensions
    {
    }

    public partial class InvoiceItem
    {
        public decimal? ItemTotal()
        {
            return Quantity * Price;
        }
    }

    public partial class Invoice
    {
        public decimal? Total()
        {
            decimal? total = 0;
            foreach (var item in this.InvoiceItems)
            {
                total += item.ItemTotal();
            }
            return total;
        }
    }
}
