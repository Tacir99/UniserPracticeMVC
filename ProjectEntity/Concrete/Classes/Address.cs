using ProjectEntity.Concrete.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntity.Concrete.Classes
{
	public class Address : BaseEntity
	{
        public Address()
        {
            Customers = new HashSet<Customer>();
        }
        public string AddressDescription { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}
