using System;
using System.Diagnostics;
using System.Threading;

namespace Fortnite
{
	// Token: 0x02000003 RID: 3
	internal class Program
	{
		// Token: 0x0600000D RID: 13 RVA: 0x000020D8 File Offset: 0x000002D8
		private static void Main(string[] args)
		{
			Console.Title = "CometFN";
			string answer;

			Console.Write("Would you like to launch Astroid now?\n");
			answer = Console.ReadLine();
			if (answer.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
			{
				Console.Clear();
				string str = string.Empty;
				string text = string.Empty;
				foreach (string text2 in args)
				{
					bool flag = text2.Contains("-epicusername=");
					bool flag2 = flag;
					bool flag3 = flag2;
					if (flag3)
					{
						str = text2.Replace("-epicusername=", "");
					}
					text = text + text2 + " ";
				}
				Console.WriteLine("Welcome to Astroid.");
				Thread.Sleep(1000);
				Console.WriteLine("Credits to HeyItsZinx and bolt!");
				Thread.Sleep(1000);
				Console.WriteLine("Launching...");
				Thread.Sleep(2000);
				Process.Start("FortniteClient-Win64-Shipping.exe", text);
				Process[] processes = Process.GetProcesses();
				foreach (Process process in processes)
				{
					bool flag4 = process.ProcessName.Contains("FortniteClient-Win64-Shipping");
					bool flag5 = flag4;
					bool flag6 = flag5;
					if (flag6)
					{
						Console.WriteLine("Fortnite Launched!");
						break;
					}
				}
				Console.Read();
			}
			else if (answer.Equals("no", StringComparison.InvariantCultureIgnoreCase))
			{
				Console.WriteLine("Okay.");
				Thread.Sleep(1000);
				Environment.Exit(0);
			}
		}
	}
}