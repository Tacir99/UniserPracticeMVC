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
	public class AddressConfig : BaseConfig<Address>
	{
		public override void Configure(EntityTypeBuilder<Address> builder)
		{
			base.Configure(builder);
			builder.Property(x => x.AddressDescription)
				.HasColumnType("nvarchar(100)");
			
		}
	}
}
