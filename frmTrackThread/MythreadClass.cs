using System;
using System.Collections.Generic;
using System.Text;

namespace ThreadPriority
{

    public class MyThreadClass
    {
        public static void Thread1()
        {
            for (int i = 0; i < 3; i++)
            {
                Thread thread = Thread.CurrentThread;
                Thread.Sleep(500);
                Console.WriteLine("Name of Thread: " + thread.Name + " Process = " + i);
            }
        }

        public static void Thread2()
        {
            for (int i = 0; i < 6; i++)
            {
                Thread thread = Thread.CurrentThread;
                Thread.Sleep(1500);
                Console.WriteLine("Name of Thread: " + thread.Name + " Process = " + i);
            }
        }
    }
}