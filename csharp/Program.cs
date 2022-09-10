using System;
using System.Collections.Generic;
using System.Linq;

var list = new List<Double>{ 6, 3 };

List<Double> halfNumberList = list.Select(n => n / 2).ToList();
halfNumberList.Add(1.5);
halfNumberList.Reverse();
halfNumberList.RemoveAt(halfNumberList.Count - 1);

Console.Write(halfNumberList.Sum());
