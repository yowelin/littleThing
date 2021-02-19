﻿using System;
using System.Collections;

namespace HelloApp
{
    class WeekEnumerator : IEnumerator
    {
        string[] days;
        int position = -1;
        public WeekEnumerator(string[] days)
        {
            this.days = days;
        }
        public object Current
        {
            get
            {
                if (position == -1 || position >= days.Length)
                    throw new InvalidOperationException();
                return days[position];
            }
        }

        public bool MoveNext()
        {
            if (position < days.Length - 1)
            {
                position++;
                return true;
            }
            else
                return false;
        }

        public void Reset()
        {
            position = -1;
        }
    }
    class Week
    {
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday",
                            "Friday", "Saturday", "Sunday" };

        public IEnumerator GetEnumerator()
        {
            return new WeekEnumerator(days);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Week week = new Week();
            foreach (var day in week)
            {
                Console.WriteLine(day);
            }
            Console.Read();
        }
    }
}