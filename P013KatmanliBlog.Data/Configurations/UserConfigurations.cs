using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P013KatmanliBlog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P013KatmanliBlog.Data.Configurations
{
	public class UserConfigurations : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			builder.Property(x=>x.Name).IsRequired().HasMaxLength(50);
			builder.Property(x=>x.Surname).HasMaxLength(50);
			builder.Property(x=>x.UserName).HasMaxLength(50);
			builder.Property(x=>x.Email).IsRequired().HasMaxLength(100);
			builder.Property(x=>x.Password).IsRequired().HasMaxLength(50);

		}
	}
}
