﻿using System;

namespace BattleshipsNS
{
	public class ConsoleIO : IConsoleIO
	{
		public void WriteLine(string s)
		{
			Console.WriteLine(s);
		}
		public string ReadLine()
		{
			return Console.ReadLine();
		}
	}
}
