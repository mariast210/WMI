using System;
using System.Collections.Generic;

namespace WMI_Backend.Models
{
	public class PageResult<T>
	{
		public long TotalCount { get; set; }
		public List<T> Data { get; set; }
	}
}

