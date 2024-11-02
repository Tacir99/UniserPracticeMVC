using ProjectEntity.Concrete.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntity.Concrete.Classes
{
	public class Customer : BaseEntity
	{
        public Customer()
        {
            Address = new Address();
            Orders = new HashSet<Order>();
        }
        public string FirsName { get; set; } = string.Empty;
		public string LastName { get; set; } = string.Empty;
		public int PhoneNumber { get; set; }
		public int AddressId{ get; set; }
		public Address Address { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
