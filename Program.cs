//#define TEST
using System;
using System.Text;
using System.IO;
#if TEST
using DeconstructPattern;
#endif

namespace test_csharp_stuff
{
    static class Program
    {
        static void Main(string[] args)
        {
			#if TEST
			Test();
			#else
			GenerateDeconstructs(15);
			#endif
        }

		static void Test()
		{
#if TEST
			var s = "TEST 10 P 1 2 3".Split(' ');
			var parsed = s switch {
				("TEST", var count, var flag, var rest) => (count, flag, string.Join(" ", rest)),
				("INFO", var rest) => ("", "", string.Join(" ", rest)),
				_ => throw new NotImplementedException(),
			};
			Console.WriteLine(parsed);
#endif
		}

		static void GenerateDeconstructs(int amount)
		{
			var sb = new StringBuilder();
			sb.AppendLine("namespace DeconstructPattern");
			sb.AppendLine("{");
			sb.AppendLine("\tpublic static class _");
			sb.AppendLine("\t{");
			for (int i = 2; i < amount + 1; i++)
			{
				sb.AppendLine($"\t\t/* Deconstruct<T> for {i} out parameters */");
				sb.Append($"\t\tpublic static void Deconstruct<T>(this T[] v");
				for(int j = 0; j < i; j++)
				{
					if (j == i - 1)
					{
						sb.Append($", out T[] v{j}");
					}
					else 
					{
						sb.Append($", out T v{j}");
					}
				}
				sb.AppendLine(")");
				sb.AppendLine("\t\t{");
				for(int j = 0; j < i; j++)
				{
					sb.AppendLine($"\t\t\tv{j} = default;");
				}

				
				for(int j = 0; j < i; j++) 
				{
					sb.AppendLine($"\t\t\tif (v.Length < {(j + 1)})");
					sb.AppendLine($"\t\t\t\treturn;");
					if (j == i - 1)
					{
						sb.AppendLine($"\t\t\tv{j} = v[{j}..];");
					} 
					else
					{
						sb.AppendLine($"\t\t\tv{j} = v[{j}];");
					}
				}
				sb.AppendLine("\t\t}");
				sb.AppendLine();
			}
			sb.AppendLine("\t}");
			sb.AppendLine("}");
			File.WriteAllText("DeconstructPattern.cs", sb.ToString());
		}
    }
}
