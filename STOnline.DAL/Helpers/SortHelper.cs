using STOnline.DAL.Helpers.QueryParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Linq.Dynamic.Core;

namespace STOnline.DAL.Helpers
{
	public class SortHelper<Entity> : ISortHelper<Entity> where Entity : class
	{
		public IQueryable<Entity> ApplySort(IQueryable<Entity> entities, QueryStringParameters queryString)
		{
			if (!entities.Any())
				return entities;

			if (string.IsNullOrWhiteSpace(queryString.OrderBy))
			{
				return entities;
			}

			var orderParams = queryString.OrderBy.Trim().Split(',');
			var propertyInfos = typeof(Entity).GetProperties(BindingFlags.Public | BindingFlags.Instance);
			var orderQueryBuilder = new StringBuilder();

			foreach (var param in orderParams)
			{
				if (string.IsNullOrWhiteSpace(param))
					continue;

				var propertyFromQueryName = param.Split(" ")[0];
				var objectProperty = propertyInfos.FirstOrDefault(pi => pi.Name.Equals(propertyFromQueryName, StringComparison.InvariantCultureIgnoreCase));

				if (objectProperty == null)
					continue;

				var sortingOrder = param.EndsWith(" desc") ? "descending" : "ascending";

				orderQueryBuilder.Append($"{objectProperty.Name.ToString()} {sortingOrder}, ");
			}

			var orderQuery = orderQueryBuilder.ToString().TrimEnd(',', ' ');

			return entities.OrderBy(orderQuery);
		}
	}
}
