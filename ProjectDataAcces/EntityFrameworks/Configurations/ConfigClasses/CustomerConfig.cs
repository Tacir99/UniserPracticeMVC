using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectDataAcces.EntityFrameworks.Configurations.Common;
using ProjectEntity.Concrete.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDataAcces.EntityFrameworks.Configurations.ConfigClasses
{
	public class CustomerConfig : BaseConfig<Customer>
	{
		public override void Configure(EntityTypeBuilder<Customer> builder)
		{
			base.Configure(builder);
			builder.Property(x => x.FirsName)
				.HasColumnType("nvarchar(30)");
			builder.Property(x => x.LastName)
				.HasColumnType("nvarchar(30)");

			builder.HasOne(x => x.Address)
				.WithMany(x => x.Customers)
				.HasForeignKey(x => x.AddressId);

		}
	}
}
