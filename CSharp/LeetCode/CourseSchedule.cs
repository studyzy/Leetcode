using System;
using System.Collections.Generic;

namespace LeetCode
{
	public partial class Solution 
	{
		private Dictionary<int,List<int>>  courseDict =new Dictionary<int,List<int>> ();
		//key is parent, value is children
		private Dictionary<int,List<int>> courseDep = new Dictionary<int,List<int>> ();
		public bool CanFinish(int numCourses, int[,] prerequisites) 
		{
			courseDep = new Dictionary<int,List<int>> ();
		    courseDict = new Dictionary<int,List<int>> ();
			//Build graph first
			int len = prerequisites.Length;
			for (var i = 0; i < len / 2; i++)
			{
				int course = prerequisites [i, 0];
				int pre = prerequisites [i, 1];
				if (courseDict.ContainsKey (course))
				{
					courseDict [course].Add (pre);
				}
				else
				{
					courseDict.Add (course, new List<int> (){ pre });
				}
			}
			//check graph cycle
			foreach (var key in courseDict.Keys)
			{
				courses = new List<int> ();
				done = new List<int> ();
				var dep = GetAllDependentCourse (key, key);
				courseDep.Add(key,dep);
				Console.WriteLine (key + ":" + String.Join (",", dep));
				if (dep.Contains(key))
				{
					return false;
				}
			}
			return true;
		}
		private List<int> courses = new List<int> ();
		private List<int> done = new List<int> ();
		private List<int> GetAllDependentCourse(int course,int rootCouse)
		{
			done.Add (course);
			if (!courseDict.ContainsKey (course))
			{
				return null;
			}
			foreach (var c in courseDict [course])
			{
				if(!courses.Contains(c))
				courses.Add (c);
			}
			foreach (var c in courseDict[course])
			{
				if (c != rootCouse&& !done.Contains(c))
				{
					List<int> next = null;
					if (courseDep.ContainsKey (c))
					{
						next =(courseDep [c]);
					}
					else
					{
						next = GetAllDependentCourse (c, rootCouse);

					}
					if (next != null)
					{
						foreach (var n in next)
						{
							if(!courses.Contains(n))
								courses.Add (n);
						}
					}
				}
			}
			return courses;
		}


	}
}

