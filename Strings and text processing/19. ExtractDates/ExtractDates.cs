﻿﻿using System;
using System.Globalization;
using System.Text.RegularExpressions;
/// <summary>
/// We extract the dates from the text using regex and then tryparse them in an array of datetimes
/// We write each member of datetime, using Canada culture info, currently appearing as DD/MM/YYYY which is a bit 
/// wrong because Google claims Canada is currently using ISO-8601 standart and dates should be displayed as
/// YYYY-MM-DD. Anyway, might be MS' fault.
/// </summary>
class ExtractDates
{
    static void Main()
    {
        string text = "Here are some valid dates 12.01.2012, 13.05.2013, 28.02.2015 and some invalid ones 01.13.2015, 32.05.2014";
        string pattern = @"\d{2}\.\d{2}\.\d{4}";
        MatchCollection dates = Regex.Matches(text, pattern);
        DateTime[] correctDates = new DateTime[dates.Count];
        for (int i = 0; i < dates.Count; i++)
        {
            if (DateTime.TryParse(dates[i].ToString(), out correctDates[i]))
            {
                Console.WriteLine("{0}", correctDates[i].ToString(new CultureInfo("en-CA")));
            }
        }
    }
}