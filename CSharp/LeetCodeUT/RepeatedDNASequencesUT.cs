using System;
using NUnit.Framework;
using System.Diagnostics;

namespace LeetCodeUT
{
	public class RepeatedDNASequencesUT:BaseUT
	{
		[TestCase("AAAAACCCCCAAAAACCCCCCAAAAAGGGTTT","AAAAACCCCC,CCCCCAAAAA")]
		[TestCase("AAAAAAAAAAA","AAAAAAAAAA")]
		public void Test (string dna,string result)
		{
			var find = Solution.FindRepeatedDnaSequences (dna);
			foreach (var s in find)
			{
				Console.WriteLine (s);
				Assert.IsTrue (result.Contains (s));
			}
		}
		[Test]
		public void TestLongDNA()
		{
			var dna = ReadFile("DNA.txt");
			DateTime start = DateTime.Now;

			var find = Solution.FindRepeatedDnaSequences (dna);
			Console.WriteLine ("Cost:" + (DateTime.Now - start).TotalSeconds);
			Process proc = Process.GetCurrentProcess ();
			long usedMemory = proc.PrivateMemorySize64;
			Console.WriteLine ("Memory:"+ usedMemory);
			foreach (var s in find)
			{
				Console.WriteLine (s);
			}
		}
	}
}

