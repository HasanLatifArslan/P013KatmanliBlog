﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace P013KatmanliBlog.Core.Entities
{
	public class Category : IEntity
	{
		public int Id { get; set; }
		[Display(Name = "Ad")]
		public string Name { get; set; }
		[Display(Name = "Açıklama")]
		public string? Description { get; set; }
			
		[Display(Name = "Eklenme Tarihi"), ScaffoldColumn(false)]
		public DateTime CreateDate { get; set; } = DateTime.Now;
	}
}
