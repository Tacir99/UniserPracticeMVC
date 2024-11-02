using ProjectEntity.Concrete.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntity.Concrete.Classes
{
	public class Order:BaseEntity
	{
        public Order()
        {
            ParfumOrders = new HashSet<ParfumOrder>();
            Customer = new Customer();
        }
        public int OrderNumber { get; set; }
        public double TotalPrice { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<ParfumOrder> ParfumOrders { get; set; }
    }
}
