﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectDataAcces.EntityFrameworks.Configurations.Common;
using ProjectEntity.Concrete.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDataAcces.EntityFrameworks.Configurations.ConfigClasses
{
	public class OrderConfig : BaseConfig<Order>
	{
		public override void Configure(EntityTypeBuilder<Order> builder)
		{
			base.Configure(builder);
			builder.Property(x => x.TotalPrice).IsRequired();
			builder.HasOne(x => x.Customer)
				.WithMany(x => x.Orders)
				.HasForeignKey(x => x.CustomerId);
		}
	}
}
