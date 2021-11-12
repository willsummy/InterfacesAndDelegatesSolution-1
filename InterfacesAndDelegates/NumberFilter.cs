﻿using System;
using System.Collections.Generic;

namespace InterfacesAndDelegates
{

    // public delegate bool FilterMethod(int x);

    // Action<decimal>
   // public delegate void DoBankThing(decimal x);
    public class NumberFilter
    {
      

        public List<int> FilterOutEvens(List<int> numbers)
        {
            // Anonymous Method
            return Filter(numbers, x => x % 2 != 0);
            //return Filter(numbers, delegate (int x)
            //{
            //    return x % 2 != 0;
            //});
        }
        public List<int> FilterOutOdds(List<int> numbers)
        {
            return Filter(numbers, x => x % 2 == 0);
            //return Filter(numbers, delegate (int x)
            //{
            //    return x % 2 == 0;
            //});
        }

        private  List<int> Filter(List<int> numbers, Predicate<int> op)
        {
            var results = new List<int>();
            foreach (var number in numbers)
            {
                if (op(number))
                {
                    results.Add(number);
                }
            }
            return results;
        }

        //private bool IsNotEven(int number)
        //{
        //    return number % 2 != 0;
        //}
        private bool IsEven(int number)
        {
            return number % 2 == 0;
        }

  
    }
}