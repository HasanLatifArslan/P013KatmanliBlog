﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace P013KatmanliBlog.Core.Entities
{
	public class User : IEntity
	{
		public int Id { get; set; }
		[Display(Name = "Ad")]
		public string Name { get; set; }
		[Display(Name = "Soyad")]
		public string? Surname { get; set; }
		[EmailAddress]
		public string Email { get; set; }
		[Display(Name = "Şifre")]
		public string Password { get; set; }
		[Display(Name = "Kullanıcı Adı")]
		public string? UserName { get; set; }
		
		[Display(Name = "Durum")]
		public bool IsActive { get; set; }
		[Display(Name = "Admin?")]
		public bool IsAdmin { get; set; }
		[Display(Name = "Eklenme Tarihi"), ScaffoldColumn(false)]
		public DateTime CreateDate { get; set; } = DateTime.Now;
	}
}
