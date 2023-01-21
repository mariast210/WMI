using System.Collections.Generic;

namespace WMI_Backend.Models.Response
{
    public class PageResponse<T>
	{
        public long TotalCount { get; set; }
        public List<T> Data { get; set; }
    }
}

