﻿using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("GE", "General Electric");

            string GM = stocks["GM"];

            List<Dictionary<string, double>> purchases = new List<Dictionary<string, double>>();
            purchases.Add (new Dictionary<string, double>(){ {"GE", 230.21} });
            purchases.Add (new Dictionary<string, double>(){ {"GE", 580.98} });
            purchases.Add (new Dictionary<string, double>(){ {"GE", 406.34} });


            /*
    Define a new Dictionary to hold the aggregated purchase information.
    - The key should be a string that is the full company name.
    - The value will be the total valuation of each stock
            

    From the three purchases above, one of the entries
    in this new dictionary will be...
        {"General Electric", 1217.53}

    Replace the questions marks below with the correct types.
*/
Dictionary<string, double> stockReport = new Dictionary<string, double>();

/*
   Iterate over the purchases and record the valuation
   for each stock.
*/
foreach (Dictionary<string, double> purchase in purchases) {
{
    foreach (KeyValuePair<string, double> stock in purchase)
    {
        
        // Does the full company name key already exist in the `stockReport`?
        if (stockReport.ContainsKey(stocks[stock.Key])) {
           stockReport[stocks[stock.Key]] += stock.Value;
       } else {
           stockReport[stocks[stock.Key]] = stock.Value;
       }
        // If it does, update the total valuation
        /*
            If not, add the new key and set its value.
            You have the value of "GE", so how can you look
            the value of "GE" in the `stocks` dictionary
            to get the value of "General Electric"?
        */
    }
}
}
        foreach(KeyValuePair<string, double> item in stockReport){
            Console.WriteLine($"The position in {item.Key} is worth {item.Value}");
        }
    }
    }
}

