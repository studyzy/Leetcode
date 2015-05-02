using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
	public partial class Solution
	{
		public IList<string> FindRepeatedDnaSequences(string s) 
		{
			if (s.Length <= 10)
				return new List<string> ();
			var res = new HashSet<string>();
			const int Length = 10;
			var mapping = new Dictionary<char, int> { { 'A', 1 }, { 'C', 2 }, { 'G', 3 }, { 'T', 0 } };
			var hashtableFor10LengthString = new Dictionary<long, int>();
			long rollinghash = 0;

			for (var j = 0; j < Length; j++)
			{
				rollinghash = mapping[s[j]] + (rollinghash <<2);
			}
			hashtableFor10LengthString.Add (rollinghash, 0);
			for (var i = 1; i < s.Length - 9; i++)
			{
				rollinghash = ((rollinghash << 2) + mapping[s[i+9]])&1048575;

				if (hashtableFor10LengthString.ContainsKey(rollinghash))
				{
					res.Add(s.Substring(i, 10));
				}
				else
				{
					hashtableFor10LengthString.Add(rollinghash, i);
				}
			}
			//Console.WriteLine ("Hashtable count:"+ hashtableFor10LengthString.Count);
			return res.ToList();


			//TODO 以下代码虽然是对的，但是Memory Limited，其实我觉得用bool数组很节约内存了啊，不知道为什么还提交不通过。

//			var result=new List<string>();
//			if (s.Length <= 10)
//				return result;
//			
//		
//			var array=new bool[1048576];//1024*1024
//			int x = 0;
//			for(var i=0;i<10;i++)
//			{
//				int step = Encode (s [i]);
//				x = (x << 2) + step;
//			}
//			array [x] = true;
//			for (var i = 10; i < s.Length; i++)
//			{
//				var step = Encode (s [i]);
//				x = ((x << 2) + step)&1048575;
//				if (array [x])
//				{
//					result.Add (Decode(x));
//				}
//				else
//				array [x] = true;
//			}
//			return result;
		}
		//A 00 C 01 G 10 T 11
		private string Decode(int x)
		{
			string code = "";
			for (var i = 0; i < 10; i++)
			{
				var c = x & 3;
				if (c == 0)
					code = "A" + code;
				else
				if (c == 1)
					code = "C" + code;
				else
				if (c == 2)
					code = "G" + code;
				else
					code = "T" + code;
				x = x >> 2;
			}
			return code;
		}
		private int Encode(char c)
		{
			int step = 0;
			if (c == 'C')
				step = 1;
			else
			if (c == 'G')
				step = 2;
			else
			if (c == 'T')
				step = 3;
			return step;
		}
	}
}

