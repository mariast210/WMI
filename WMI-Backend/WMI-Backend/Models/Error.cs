﻿namespace WMI_Backend.Models
{
    public class Error
	{
		public string Message { get; set; }

		public Error(string message)
		{
			Message = message;
		}
	}
}

