using BenchmarkDotNet.Running;
using StringConcatenationTest;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//BenchmarkRunner.Run<TwoStringsConcatenation>();
			BenchmarkRunner.Run<MultipleStringsConcatenation>();
		}
	}
}
