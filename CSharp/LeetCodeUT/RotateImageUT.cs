using System;
using NUnit.Framework;

namespace LeetCodeUT
{
	public class RotateImageUT:BaseUT
	{
		[Test]
		public void Test1 ()
		{

			int a = 123;
			int b = 456;
			a ^= b;
			b ^= a;
			a ^= b;
			Console.WriteLine (a + "," + b);

			var img = new int[,]{ { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
			Solution.Rotate (img);
			for (var i = 0; i < img.Length; i++)
			{
				if (i % 3 == 0)
				{
					Console.WriteLine ("");
				}
				Console.Write (img [i / 3, i % 3]);
			}
		}
        [Test]
        public void Test2()
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            a = a ^ b ^ c ^ d;
            b = a ^ b ^ c ^ d;
            d = a ^ b ^ c ^ d;
            c = a ^ b ^ c ^ d;
            a = a ^ b ^ c ^ d;
            Console.WriteLine(a + "," + b);


            var img = new int[,] { { 1, 2, 3,4 }, {  5, 6,7,8 }, {9,10,11,12 },{13,14,15,16} };
            Solution.Rotate(img);
            for (var i = 0; i < img.Length; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine("");
                }
                Console.Write(img[i / 4, i % 4]);
            }
        }
	}
}

