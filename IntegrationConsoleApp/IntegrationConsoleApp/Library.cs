﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationConsoleApp
{
	public class Library
	{
		public int GetInt(string nombre)
		{
			return int.Parse(nombre);
		}
	}
}
