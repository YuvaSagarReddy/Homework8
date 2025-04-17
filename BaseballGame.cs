using System;
namespace Homework8
{
    public class Solution1
    {
        public int CalPoints(string[] op)
        {
            List<int> list = new List<int>();

            foreach (string s in op)
            {
                if (s == "C")
                {
                    if (list.Count > 0)
                        list.RemoveAt(list.Count - 1);
                }
                else if (s == "D")
                {
                    if (list.Count > 0)
                        list.Add(list[^1] * 2);
                }
                else if (s == "+")
                {
                    if (list.Count >= 2)
                        list.Add(list[^1] + list[^2]);
                }
                else
                {
                    list.Add(Convert.ToInt32(s));
                }
            }

            return list.Sum();
        }
    }

}

