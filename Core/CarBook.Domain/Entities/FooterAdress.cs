using System;
using CarBook.Domain.Common;

namespace CarBook.Domain.Entities
{
	public class FooterAdress : BaseEntity
	{
		public string Description { get; set; }
		public string Adress { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
	}
}

