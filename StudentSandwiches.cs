using System;
namespace Homework8
{
    public class Solution3
    {
        public int CountStudents(int[] students, int[] sandwiches)
        {
            Queue<int> queue = new Queue<int>(students);
            int i = 0;
            int taken = 0;

            while (queue.Count > 0 && taken < queue.Count)
            {
                if (queue.Peek() == sandwiches[i])
                {
                    queue.Dequeue();
                    i++;
                    taken = 0;
                }
                else
                {
                    queue.Enqueue(queue.Dequeue());
                    taken++;
                }
            }

            return queue.Count;
        }
    }

}

