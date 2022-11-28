using BenchmarkDotNet.Attributes;
using System.Text;

namespace StringConcatenationTest
{
	[MemoryDiagnoser]
	public class MultipleStringsConcatenation
	{
		[ParamsSource(nameof(ValuesForStrings))]
		public string[] Strings { get; set; }

		public IEnumerable<string[]> ValuesForStrings =>
			new[] { 2, 3, 4, 5, 10, 100, 1_000, 10_000 }
				.Select(n =>
					Enumerable
						.Range(0, n)
						.Select(_ => Guid.NewGuid().ToString())
						.ToArray());

		[Benchmark]
		public string AddMultipleStrings()
		{
			var result = string.Empty;
			foreach (var item in Strings)
			{
				result += item;
			}
			return result;
		}

		[Benchmark]
		public string JoinMultipleStrings() =>
			string.Join("", Strings);

		[Benchmark]
		public string ConcatMultipleString() =>
			string.Concat(Strings);

		[Benchmark]
		public string AddMultipleStringsWithCreate()
		{
			var length = Strings.Select(i => i.Length).Sum();
			var myString = string.Create(length, Strings, (span, state) =>
			{
				var index = 0;
				foreach (var item in state)
				{
					item?.AsSpan().CopyTo(span.Slice(index, item.Length));
					index += item?.Length ?? 0;
				}
			});
			return myString;
		}

		[Benchmark]
		public string AddMultipleStringWithStringBuilder()
		{
			var builder = new StringBuilder();
			foreach (var item in Strings)
			{
				builder.Append(item.ToString());
			}
			return builder.ToString();
		}
	}
}
