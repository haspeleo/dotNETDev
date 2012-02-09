/*
 * http://stackoverflow.com/questions/510778/add-or-sum-of-hours-like-1330000020-133020-but-how
 * http://support.microsoft.com/kb/307548#4
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Timing
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------Because Time = Money------------");
            Console.Beep(); 

            TimeSpan t1 = TimeSpan.Parse("23:30");
            TimeSpan t2 = TimeSpan.Parse("00:40");
            TimeSpan t3 = t1.Add(t2);
            TimeSpan t4 = t1 + t2;
            Console.WriteLine(t4);
            Console.WriteLine(t3);
            Console.WriteLine(t3.TotalHours);
            Console.WriteLine(t3.TotalMinutes);


            Console.WriteLine("reading from an XML file");


            XmlTextReader reader = new XmlTextReader("Y:\\dotNETDev\\Timing\\Timing\\books.xml");
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.
                        Console.Write("<" + reader.Name);
                        Console.WriteLine(">");
                        break;
                    case XmlNodeType.Text: //Display the text in each element.
                        Console.WriteLine(reader.Value);
                        break;
                    case XmlNodeType.EndElement: //Display the end of the element.
                        Console.Write("</" + reader.Name);
                        Console.WriteLine(">");
                        break;
                }
            }
            Console.ReadLine();

            Console.WriteLine("End reading from xml");




            Console.WriteLine("Using class Session");
            List<Session> learningTime = new List<Session>();
            Session s1 = new Session { Start = "17:07", End = "19:00"};

            Session s2 = new Session { Start = "16:08", End = "17:48"};
            Session s3 = new Session { Start = "18:11", End = "20:50"};
            
            Session s4 = new Session { Start = "16:15", End = "19:40"};

            Session s5 = new Session { Start = "14:30", End = "18:30"};
            Session s6 = new Session { Start = "15:50", End = "18:15"};
            Session s7 = new Session { Start = "16:00", End = "19:00"};
            Session s8 = new Session { Start = "15:30", End = "18:00"};


            TimeSpan totalTime = TimeSpan.Parse("00:00"); 
            foreach (Session item in learningTime)
            {
                totalTime += (TimeSpan)(item.calculateSessionDuration()); 
                
            }

                Console.WriteLine("Total time : " + totalTime); 


            Console.WriteLine("\n\nPress any key to continue ...");
            Console.ReadKey(); 


        }
    }
}
