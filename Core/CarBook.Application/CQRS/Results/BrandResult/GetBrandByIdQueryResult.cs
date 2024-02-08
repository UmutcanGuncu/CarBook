using System;
using CarBook.Domain.Entities;

namespace CarBook.Application.CQRS.Results.BrandResult
{
	public class GetBrandByIdQueryResult
	{
        public Guid Id { get; set; }
        public string Name { get; set; }
       
    }
}

