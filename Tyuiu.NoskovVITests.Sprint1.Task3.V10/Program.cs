using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NoskovVITests.Sprint1.Task3.V10.Lib;

namespace Tyuiu.NoskovVITests.Sprint1.Task3.V10
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DataService ds = new DataService();
			Console.WriteLine(ds.NumberToMoney(305));
		}
	}
}