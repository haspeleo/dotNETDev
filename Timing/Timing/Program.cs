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

            Console.WriteLine("Using class Session");
            List<Session> learningTime = new List<Session>();
            Session s1 = new Session { Start = "17:07", End = "19:00"};

            Session s2 = new Session  { Start = "16:08", End = "17:48"};
            Session s3 = new Session  { Start = "18:11", End = "20:50"};
            
            Session s4 = new Session  { Start = "16:15", End = "19:40"};

            Session s5 = new Session  { Start = "14:30", End = "18:30"};
            Session s6 = new Session  { Start = "15:50", End = "18:15"};
            Session s7 = new Session  { Start = "16:00", End = "19:00"};
            Session s8 = new Session  { Start = "15:30", End = "18:00"};

            Session s9 = new Session  { Start = "16:15", End = "17:50"};
            Session s10 = new Session { Start = "18:30", End = "20:30"};
            Session s11 = new Session { Start = "22:50", End = "23:45"};
            Session s12 = new Session { Start = "19:15", End = "21:06"};

            Session s13 = new Session { Start = "12:10", End = "13:00"};
            Session s14 = new Session { Start = "13:45", End = "15:50"};
            Session s15 = new Session { Start = "14:30", End = "16:00"};
            Session s16 = new Session { Start = "19:15", End = "20:30"};
            Session s17 = new Session { Start = "15:00", End = "18:13"};
            Session s18= new Session { Start = "20:15", End = "21:20"};


            //for (int i = 1; i <= 18; i++)
            //{
            //    string si = "s" + i;
            //    learningTime.Add((object)si);
            //}

            learningTime.Add(s1);
            learningTime.Add(s2);
            learningTime.Add(s3);
            learningTime.Add(s4);
            learningTime.Add(s5);
            learningTime.Add(s6);
            learningTime.Add(s7);
            learningTime.Add(s8);
            learningTime.Add(s9);
            learningTime.Add(s10);
            learningTime.Add(s11);
            learningTime.Add(s12);
            learningTime.Add(s13);
            learningTime.Add(s14);
            learningTime.Add(s15);
            learningTime.Add(s16);
            learningTime.Add(s17);
            learningTime.Add(s18);

            TimeSpan totalTime = TimeSpan.Parse("00:00");
            foreach (Session item in learningTime)
            {
                totalTime += (TimeSpan)(item.calculateSessionDuration()); 
                
            }

                Console.WriteLine("Total learning time : " + totalTime);
                Console.WriteLine("Total learning time (in hours) : " + totalTime.TotalHours);


                Console.WriteLine(" ************* reading from an XML file **************");


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


            Console.WriteLine("\n\nPress any key to continue ...");
            Console.ReadKey(); 


        }
    }
}
