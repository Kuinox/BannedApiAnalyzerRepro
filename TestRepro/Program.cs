using System;
using System.Threading.Tasks;

namespace TestRepro
{
	class Program
	{
		static async Task Main(string[] args)
		{
			await Task.Delay(10, new System.Threading.CancellationToken()); //no warn.
			await Task.Delay(10); //warn
		}
	}
}
