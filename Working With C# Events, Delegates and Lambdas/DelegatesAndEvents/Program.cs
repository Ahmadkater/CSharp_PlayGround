﻿using System;

namespace DelegatesAndEvents
{
    public delegate void WorkPerformedHandler(int Hours , WorkType workType);
    class Program
    {
        static void Main(string[] args)
        {
            WorkPerformedHandler d1 = new WorkPerformedHandler(WorkPerformed1);
            WorkPerformedHandler d2 = new WorkPerformedHandler(WorkPerformed2);

            d1.Invoke(5,WorkType.Golf);
            d2(10,WorkType.GoToMeeting);
        }

        public static void WorkPerformed1(int hours , WorkType work)
        {
            System.Console.WriteLine("WorkPerformed 1 called " + hours.ToString());
        }

        public static void WorkPerformed2(int hours , WorkType work)
        {
            System.Console.WriteLine("WorkPerformed 2 called " + hours.ToString());
        }

    }
}
