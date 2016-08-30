﻿using System;
using Microsoft.Owin.Hosting;

namespace $safeprojectname$
{
	public class Program
	{
		static void Main()
		{
			var options = new StartOptions
			{
				ServerFactory = "Nowin",
				Port = 8080
			};

			using (WebApp.Start<Startup>(options))
			{
				Console.WriteLine("Running a http server on port 8080");
				Console.ReadKey();
			}
		}
	}
}