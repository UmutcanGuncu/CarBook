using System;
using CarBook.Application.Mediator.Results.FeatureResults;
using MediatR;

namespace CarBook.Application.Mediator.Queries.FeatureQueries
{
	public class GetFeatureQuery : IRequest<List<GetFeatureQueryResult>> //GetFeatureQuery'yi çağırdığımda Liste Olarak GetFeatureQueryResult'u geri döndürecek
	{
		
	}
}

