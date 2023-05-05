using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace P013KatmanliBlog.Core.Entities
{
	public class Post : IEntity
	{
		public int Id { get; set; }
		[Display(Name = "İçerik Adı")]
		public string Name { get; set; }
		[Display(Name = "İçerik Açıklaması")]
		public string? Description { get; set; }
		[Display(Name = "Eklenme Tarihi"), ScaffoldColumn(false)]
		public DateTime CreateDate { get; set; } = DateTime.Now;
		[Display(Name = "İçerik Resmi")]
		public string? Image { get; set; }
		[Display(Name = "Kategori")]
		public int CategoryId { get; set; } 
		[Display(Name = "Kategori")]
		public virtual Category? Category { get; set; }
	}
}
