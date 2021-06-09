using DependencyInjectionServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionServices.Services
{
	public class ScopedService : IScopedService
	{
		public string Time { get; set; }

		public ScopedService()
		{
			Time = DateTime.UtcNow.ToString("HH:mm:ss.ffffff");
		}
	}
}
