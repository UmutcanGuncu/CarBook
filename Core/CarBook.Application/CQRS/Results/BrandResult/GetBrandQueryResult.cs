using System;
using CarBook.Domain.Entities;

namespace CarBook.Application.CQRS.Results.BrandResult
{
	public class GetBrandQueryResult
	{
        public Guid Id { get; set; }
        public string Name { get; set; }
        
    }
}

