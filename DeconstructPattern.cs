namespace DeconstructPattern
{
	public static class _
	{
		/* Deconstruct<T> for 2 out parameters */
		public static void Deconstruct<T>(this T[] v, out T v0, out T[] v1)
		{
			v0 = default;
			v1 = default;
			if (v.Length < 1)
				return;
			v0 = v[0];
			if (v.Length < 2)
				return;
			v1 = v[1..];
		}

		/* Deconstruct<T> for 3 out parameters */
		public static void Deconstruct<T>(this T[] v, out T v0, out T v1, out T[] v2)
		{
			v0 = default;
			v1 = default;
			v2 = default;
			if (v.Length < 1)
				return;
			v0 = v[0];
			if (v.Length < 2)
				return;
			v1 = v[1];
			if (v.Length < 3)
				return;
			v2 = v[2..];
		}

		/* Deconstruct<T> for 4 out parameters */
		public static void Deconstruct<T>(this T[] v, out T v0, out T v1, out T v2, out T[] v3)
		{
			v0 = default;
			v1 = default;
			v2 = default;
			v3 = default;
			if (v.Length < 1)
				return;
			v0 = v[0];
			if (v.Length < 2)
				return;
			v1 = v[1];
			if (v.Length < 3)
				return;
			v2 = v[2];
			if (v.Length < 4)
				return;
			v3 = v[3..];
		}

		/* Deconstruct<T> for 5 out parameters */
		public static void Deconstruct<T>(this T[] v, out T v0, out T v1, out T v2, out T v3, out T[] v4)
		{
			v0 = default;
			v1 = default;
			v2 = default;
			v3 = default;
			v4 = default;
			if (v.Length < 1)
				return;
			v0 = v[0];
			if (v.Length < 2)
				return;
			v1 = v[1];
			if (v.Length < 3)
				return;
			v2 = v[2];
			if (v.Length < 4)
				return;
			v3 = v[3];
			if (v.Length < 5)
				return;
			v4 = v[4..];
		}

		/* Deconstruct<T> for 6 out parameters */
		public static void Deconstruct<T>(this T[] v, out T v0, out T v1, out T v2, out T v3, out T v4, out T[] v5)
		{
			v0 = default;
			v1 = default;
			v2 = default;
			v3 = default;
			v4 = default;
			v5 = default;
			if (v.Length < 1)
				return;
			v0 = v[0];
			if (v.Length < 2)
				return;
			v1 = v[1];
			if (v.Length < 3)
				return;
			v2 = v[2];
			if (v.Length < 4)
				return;
			v3 = v[3];
			if (v.Length < 5)
				return;
			v4 = v[4];
			if (v.Length < 6)
				return;
			v5 = v[5..];
		}

		/* Deconstruct<T> for 7 out parameters */
		public static void Deconstruct<T>(this T[] v, out T v0, out T v1, out T v2, out T v3, out T v4, out T v5, out T[] v6)
		{
			v0 = default;
			v1 = default;
			v2 = default;
			v3 = default;
			v4 = default;
			v5 = default;
			v6 = default;
			if (v.Length < 1)
				return;
			v0 = v[0];
			if (v.Length < 2)
				return;
			v1 = v[1];
			if (v.Length < 3)
				return;
			v2 = v[2];
			if (v.Length < 4)
				return;
			v3 = v[3];
			if (v.Length < 5)
				return;
			v4 = v[4];
			if (v.Length < 6)
				return;
			v5 = v[5];
			if (v.Length < 7)
				return;
			v6 = v[6..];
		}

		/* Deconstruct<T> for 8 out parameters */
		public static void Deconstruct<T>(this T[] v, out T v0, out T v1, out T v2, out T v3, out T v4, out T v5, out T v6, out T[] v7)
		{
			v0 = default;
			v1 = default;
			v2 = default;
			v3 = default;
			v4 = default;
			v5 = default;
			v6 = default;
			v7 = default;
			if (v.Length < 1)
				return;
			v0 = v[0];
			if (v.Length < 2)
				return;
			v1 = v[1];
			if (v.Length < 3)
				return;
			v2 = v[2];
			if (v.Length < 4)
				return;
			v3 = v[3];
			if (v.Length < 5)
				return;
			v4 = v[4];
			if (v.Length < 6)
				return;
			v5 = v[5];
			if (v.Length < 7)
				return;
			v6 = v[6];
			if (v.Length < 8)
				return;
			v7 = v[7..];
		}

		/* Deconstruct<T> for 9 out parameters */
		public static void Deconstruct<T>(this T[] v, out T v0, out T v1, out T v2, out T v3, out T v4, out T v5, out T v6, out T v7, out T[] v8)
		{
			v0 = default;
			v1 = default;
			v2 = default;
			v3 = default;
			v4 = default;
			v5 = default;
			v6 = default;
			v7 = default;
			v8 = default;
			if (v.Length < 1)
				return;
			v0 = v[0];
			if (v.Length < 2)
				return;
			v1 = v[1];
			if (v.Length < 3)
				return;
			v2 = v[2];
			if (v.Length < 4)
				return;
			v3 = v[3];
			if (v.Length < 5)
				return;
			v4 = v[4];
			if (v.Length < 6)
				return;
			v5 = v[5];
			if (v.Length < 7)
				return;
			v6 = v[6];
			if (v.Length < 8)
				return;
			v7 = v[7];
			if (v.Length < 9)
				return;
			v8 = v[8..];
		}

		/* Deconstruct<T> for 10 out parameters */
		public static void Deconstruct<T>(this T[] v, out T v0, out T v1, out T v2, out T v3, out T v4, out T v5, out T v6, out T v7, out T v8, out T[] v9)
		{
			v0 = default;
			v1 = default;
			v2 = default;
			v3 = default;
			v4 = default;
			v5 = default;
			v6 = default;
			v7 = default;
			v8 = default;
			v9 = default;
			if (v.Length < 1)
				return;
			v0 = v[0];
			if (v.Length < 2)
				return;
			v1 = v[1];
			if (v.Length < 3)
				return;
			v2 = v[2];
			if (v.Length < 4)
				return;
			v3 = v[3];
			if (v.Length < 5)
				return;
			v4 = v[4];
			if (v.Length < 6)
				return;
			v5 = v[5];
			if (v.Length < 7)
				return;
			v6 = v[6];
			if (v.Length < 8)
				return;
			v7 = v[7];
			if (v.Length < 9)
				return;
			v8 = v[8];
			if (v.Length < 10)
				return;
			v9 = v[9..];
		}

		/* Deconstruct<T> for 11 out parameters */
		public static void Deconstruct<T>(this T[] v, out T v0, out T v1, out T v2, out T v3, out T v4, out T v5, out T v6, out T v7, out T v8, out T v9, out T[] v10)
		{
			v0 = default;
			v1 = default;
			v2 = default;
			v3 = default;
			v4 = default;
			v5 = default;
			v6 = default;
			v7 = default;
			v8 = default;
			v9 = default;
			v10 = default;
			if (v.Length < 1)
				return;
			v0 = v[0];
			if (v.Length < 2)
				return;
			v1 = v[1];
			if (v.Length < 3)
				return;
			v2 = v[2];
			if (v.Length < 4)
				return;
			v3 = v[3];
			if (v.Length < 5)
				return;
			v4 = v[4];
			if (v.Length < 6)
				return;
			v5 = v[5];
			if (v.Length < 7)
				return;
			v6 = v[6];
			if (v.Length < 8)
				return;
			v7 = v[7];
			if (v.Length < 9)
				return;
			v8 = v[8];
			if (v.Length < 10)
				return;
			v9 = v[9];
			if (v.Length < 11)
				return;
			v10 = v[10..];
		}

		/* Deconstruct<T> for 12 out parameters */
		public static void Deconstruct<T>(this T[] v, out T v0, out T v1, out T v2, out T v3, out T v4, out T v5, out T v6, out T v7, out T v8, out T v9, out T v10, out T[] v11)
		{
			v0 = default;
			v1 = default;
			v2 = default;
			v3 = default;
			v4 = default;
			v5 = default;
			v6 = default;
			v7 = default;
			v8 = default;
			v9 = default;
			v10 = default;
			v11 = default;
			if (v.Length < 1)
				return;
			v0 = v[0];
			if (v.Length < 2)
				return;
			v1 = v[1];
			if (v.Length < 3)
				return;
			v2 = v[2];
			if (v.Length < 4)
				return;
			v3 = v[3];
			if (v.Length < 5)
				return;
			v4 = v[4];
			if (v.Length < 6)
				return;
			v5 = v[5];
			if (v.Length < 7)
				return;
			v6 = v[6];
			if (v.Length < 8)
				return;
			v7 = v[7];
			if (v.Length < 9)
				return;
			v8 = v[8];
			if (v.Length < 10)
				return;
			v9 = v[9];
			if (v.Length < 11)
				return;
			v10 = v[10];
			if (v.Length < 12)
				return;
			v11 = v[11..];
		}

		/* Deconstruct<T> for 13 out parameters */
		public static void Deconstruct<T>(this T[] v, out T v0, out T v1, out T v2, out T v3, out T v4, out T v5, out T v6, out T v7, out T v8, out T v9, out T v10, out T v11, out T[] v12)
		{
			v0 = default;
			v1 = default;
			v2 = default;
			v3 = default;
			v4 = default;
			v5 = default;
			v6 = default;
			v7 = default;
			v8 = default;
			v9 = default;
			v10 = default;
			v11 = default;
			v12 = default;
			if (v.Length < 1)
				return;
			v0 = v[0];
			if (v.Length < 2)
				return;
			v1 = v[1];
			if (v.Length < 3)
				return;
			v2 = v[2];
			if (v.Length < 4)
				return;
			v3 = v[3];
			if (v.Length < 5)
				return;
			v4 = v[4];
			if (v.Length < 6)
				return;
			v5 = v[5];
			if (v.Length < 7)
				return;
			v6 = v[6];
			if (v.Length < 8)
				return;
			v7 = v[7];
			if (v.Length < 9)
				return;
			v8 = v[8];
			if (v.Length < 10)
				return;
			v9 = v[9];
			if (v.Length < 11)
				return;
			v10 = v[10];
			if (v.Length < 12)
				return;
			v11 = v[11];
			if (v.Length < 13)
				return;
			v12 = v[12..];
		}

		/* Deconstruct<T> for 14 out parameters */
		public static void Deconstruct<T>(this T[] v, out T v0, out T v1, out T v2, out T v3, out T v4, out T v5, out T v6, out T v7, out T v8, out T v9, out T v10, out T v11, out T v12, out T[] v13)
		{
			v0 = default;
			v1 = default;
			v2 = default;
			v3 = default;
			v4 = default;
			v5 = default;
			v6 = default;
			v7 = default;
			v8 = default;
			v9 = default;
			v10 = default;
			v11 = default;
			v12 = default;
			v13 = default;
			if (v.Length < 1)
				return;
			v0 = v[0];
			if (v.Length < 2)
				return;
			v1 = v[1];
			if (v.Length < 3)
				return;
			v2 = v[2];
			if (v.Length < 4)
				return;
			v3 = v[3];
			if (v.Length < 5)
				return;
			v4 = v[4];
			if (v.Length < 6)
				return;
			v5 = v[5];
			if (v.Length < 7)
				return;
			v6 = v[6];
			if (v.Length < 8)
				return;
			v7 = v[7];
			if (v.Length < 9)
				return;
			v8 = v[8];
			if (v.Length < 10)
				return;
			v9 = v[9];
			if (v.Length < 11)
				return;
			v10 = v[10];
			if (v.Length < 12)
				return;
			v11 = v[11];
			if (v.Length < 13)
				return;
			v12 = v[12];
			if (v.Length < 14)
				return;
			v13 = v[13..];
		}

		/* Deconstruct<T> for 15 out parameters */
		public static void Deconstruct<T>(this T[] v, out T v0, out T v1, out T v2, out T v3, out T v4, out T v5, out T v6, out T v7, out T v8, out T v9, out T v10, out T v11, out T v12, out T v13, out T[] v14)
		{
			v0 = default;
			v1 = default;
			v2 = default;
			v3 = default;
			v4 = default;
			v5 = default;
			v6 = default;
			v7 = default;
			v8 = default;
			v9 = default;
			v10 = default;
			v11 = default;
			v12 = default;
			v13 = default;
			v14 = default;
			if (v.Length < 1)
				return;
			v0 = v[0];
			if (v.Length < 2)
				return;
			v1 = v[1];
			if (v.Length < 3)
				return;
			v2 = v[2];
			if (v.Length < 4)
				return;
			v3 = v[3];
			if (v.Length < 5)
				return;
			v4 = v[4];
			if (v.Length < 6)
				return;
			v5 = v[5];
			if (v.Length < 7)
				return;
			v6 = v[6];
			if (v.Length < 8)
				return;
			v7 = v[7];
			if (v.Length < 9)
				return;
			v8 = v[8];
			if (v.Length < 10)
				return;
			v9 = v[9];
			if (v.Length < 11)
				return;
			v10 = v[10];
			if (v.Length < 12)
				return;
			v11 = v[11];
			if (v.Length < 13)
				return;
			v12 = v[12];
			if (v.Length < 14)
				return;
			v13 = v[13];
			if (v.Length < 15)
				return;
			v14 = v[14..];
		}

	}
}
