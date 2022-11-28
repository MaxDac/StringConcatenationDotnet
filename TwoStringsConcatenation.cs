using BenchmarkDotNet.Attributes;

namespace ConsoleApp1
{
	[MemoryDiagnoser]
	public class TwoStringsConcatenation
	{
		[Benchmark]
		public string Add2Strings()
		{
			string tenantId = "SysTenant";
			string orgId = "ORGCode";
			return tenantId + orgId;
		}

		[Benchmark]
		public string Join2Strings()
		{
			string tenantId = "SysTenant";
			string orgId = "ORGCode";
			return string.Join("", tenantId, orgId);
		}

		[Benchmark]
		public string Concat2StringAsSpan()
		{
			string tenantId = "SysTenant";
			string orgId = "ORGCode";
			return string.Concat(tenantId.AsSpan(), orgId.AsSpan());
		}

		[Benchmark]
		public string Add2StringsWithCreate()
		{
			string tenantId = "SysTenant";
			string orgId = "ORGCode";
			int length = tenantId.Length + orgId.Length;
			var context = ValueTuple.Create(tenantId, orgId);
			var myString = string.Create(length, context, (span, state) =>
			{
				int index = state.Item1.Length;
				state.Item1.AsSpan().CopyTo(span);
				//state.Item2.AsSpan().CopyTo(span.Slice(index, state.Item2.Length));

			});
			return myString;
		}
	}
}
