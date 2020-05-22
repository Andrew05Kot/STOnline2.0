using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.DAL.Helpers.QueryParameters
{
	public abstract class QueryStringParameters
	{
		public string OrderBy { get; set; }

		const int maxPageSize = 20;
		public int PageNumber { get; set; } = 1;

		private int pageSize = 2;
		public int PageSize
		{
			get
			{
				return pageSize;
			}
			set
			{
				pageSize = (value > maxPageSize) ? maxPageSize : value;
			}
		}

		
	}
}
