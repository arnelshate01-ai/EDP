using System;
using System.Collections.Generic;
using System.Text;

namespace FrmBasicThread
{
    internal class MyThreadClass
    {
        public static void Thread1()
        {
            Thread thread = Thread.CurrentThread;

            int loopCount = 0;
            while (loopCount != 6)
            {
                
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + loopCount);
                Thread.Sleep(1500);

                loopCount++;
            }
        }
    }
}
