﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusCake.Client.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the client
            var client = new StatusCakeClient(
                username: "BunnySpeed",
                accessKey: "oDKwiNBigx1xJcWhxuHi");

            foreach (var test in client.GetPeriods(356486).Result)
            {
                Console.WriteLine(test.Up);
            }
            
            Console.WriteLine("lol");
        }
    }
}
