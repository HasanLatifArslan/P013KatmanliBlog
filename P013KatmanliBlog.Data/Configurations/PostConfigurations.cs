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
	public class PostConfigurations : IEntityTypeConfiguration<Post>
	{
		public void Configure(EntityTypeBuilder<Post> builder)
		{
			builder.Property(x=>x.Name).IsRequired().HasMaxLength(50);
			builder.Property(x=>x.Description).HasMaxLength(258);
			builder.Property(x=>x.Image).HasMaxLength(50);
			
		}
	}
}
