﻿using System;
using Microsoft.Owin.Hosting;

namespace $safeprojectname$
{
	class Program
	{
		static void Main()
		{
			using (WebApp.Start<Startup>("http://+:8080"))
			{
				Console.WriteLine("Running a http server on port 8080");
				Console.ReadLine();
			}
		}
	}
}