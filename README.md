# DeconstructPattern
Very simple generic Deconstruct() extension methods to extend pattern matching in C#.

Example:
```csharp
using DeconstructPattern;
namespace Test
{
	class Program
	{
		static void Main(string[] args)
		{
			var s = "TEST 10 P 1 2 3".Split(' ');
			var parsed = s switch {
				("TEST", var count, var flag, var rest) => (count, flag, string.Join(" ", rest)),
				("INFO", var rest) => ("", "", string.Join(" ", rest)),
				_ => throw new NotImplementedException(),
			};
			Console.WriteLine(parsed);
		}
	}
}
```

Could also be used to pattern match on sequential bytes, but I would never recommend using this in anything but throwaway projects.

To use, simply add the DeconstructPattern.cs file to a project and `using DeconstructPattern;`

Program.cs contains the code to generate the deconstruct methods, if you need more than 15 parameters.
