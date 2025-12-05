using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace frozen_tunnel
{
    internal class Program
    {


        static int num_meltedIce(string tunnel)
        {
            char[] charArray = tunnel.ToCharArray();
            int cnt = 0;

            while (true)
            {
                bool change = false;
                for (int i = 0; i <= charArray.Length-4; i++) //len -4 to avoid aut of range exp.
                {
                    if (charArray[i] == '-' && charArray[i + 1] == '-' && charArray[i + 2] == '-')
                    {
                        if (charArray[i + 3] == 'i')
                        {

                            charArray[i + 3] = '-';
                            cnt++;
                            change=true;
                             




                        }

                    }
                
                }
              if (change==false)  // no change happened if true means there is a change so we have to loop to see if the melted ice makes a triple underscore or not
                    return cnt;
            }
           

        }

        static void Main(string[] args)
        {
            Console.WriteLine("inter a string consists of - or i to represent the tested tunnel : ");
            string tunnel=Console.ReadLine(); //i---i-i
            Console.WriteLine("the tested tunnel is " +tunnel);
            int meltedice=num_meltedIce(tunnel);
            Console.WriteLine("The number of melted ice blocks = " + meltedice);
            
        }
    }
}
