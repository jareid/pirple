using System;

namespace Homework8
{
    class Program
    {

        static String[] timeAdder(int value1, String label1, int value2, String label2)
        {
            Boolean valid = true;
            String label3 = "";
            TimeSpan time1 = new TimeSpan();
            if (value1 == 1 || value1 == -1)
            {
                if (label1.Equals("second"))
                {
                    time1 = TimeSpan.FromSeconds(value1);
                    label3 = "second";
                }
                else if (label1.Equals("minute"))
                {
                    time1 = TimeSpan.FromMinutes(value1);
                    label3 = "minute";
                }
                else if (label1.Equals("hour"))
                {
                    time1 = TimeSpan.FromHours(value1);
                    label3 = "hour";
                }
                else if (label1.Equals("day"))
                {
                    time1 = TimeSpan.FromDays(value1);
                    label3 = "day";
                } else
                {
                    valid = false;
                }
            }
            else if (value1 > 1 || value1 < -1 || value1 == 0)
            {
                if (label1.Equals("seconds"))
                {
                    time1 = TimeSpan.FromSeconds(value1);
                    label3 = "second";
                }
                else if (label1.Equals("minutes"))
                {
                    time1 = TimeSpan.FromMinutes(value1);
                    label3 = "minute";
                }
                else if (label1.Equals("hours"))
                {
                    time1 = TimeSpan.FromHours(value1);
                    label3 = "hour";
                }
                else if (label1.Equals("days"))
                {
                    time1 = TimeSpan.FromDays(value1);
                    label3 = "day";
                }
                else
                {
                    valid = false;
                }
            }

            TimeSpan time2 = new TimeSpan();
            if (value2 == 1 || value2 == -1)
            {
                if (label2.Equals("second"))
                {
                    time2 = TimeSpan.FromSeconds(value2);
                }
                else if (label2.Equals("minute"))
                {
                    time2 = TimeSpan.FromMinutes(value2);
                }
                else if (label2.Equals("hour"))
                {
                    time2 = TimeSpan.FromHours(value2);
                }
                else if (label2.Equals("day"))
                {
                    time2 = TimeSpan.FromDays(value2);
                }
                else
                {
                    valid = false;
                }
            }
            else if (value2 > 1 || value2 < -1 || value2 == 0)
            {
                if (label2.Equals("seconds"))
                {
                    time2 = TimeSpan.FromSeconds(value2);
                }
                else if (label2.Equals("minutes"))
                {
                    time2 = TimeSpan.FromMinutes(value2);
                }
                else if (label2.Equals("hours"))
                {
                    time2 = TimeSpan.FromHours(value2);
                }
                else if (label2.Equals("days"))
                {
                    time2 = TimeSpan.FromDays(value2);
                }
                else
                {
                    valid = false;
                }
            } 

            label3 = CalculateMatchingLabel(label1, label2);
            int value3 = 0;
            if (valid)
            {
                TimeSpan result = time1.Add(time2);
                if (label3.Equals("day"))
                {
                    value3 = (int)result.TotalDays;
                }
                else if (label3.Equals("hour"))
                {
                    value3 = (int)result.TotalHours;
                }
                else if (label3.Equals("minute"))
                {
                    value3 = (int)result.TotalMinutes;
                }
                else if (label3.Equals("second"))
                {
                    value3 = (int)result.TotalSeconds;
                }

                if (value3 > 1 || value3 < -1)
                {
                    label3 = label3 + "s";
                }

                return new string[]{ value3.ToString(), label3 };
            }
            return new String[] { };
        }

        private static String CalculateMatchingLabel(String label1, String label2)
        {
            String label3;
            label1 = label1.TrimEnd('s');
            label2 = label2.TrimEnd('s');

            if (label1.Equals(label2))
            {
                label3 = label1;
            }
            else
            {
                if (label1.Equals("day"))
                {
                    if (label2.Equals("hour") || label2.Equals("minute") || label2.Equals("second"))
                    {
                        label3 = label2;
                    }
                    else
                    {
                        label3 = label1;
                    }
                }
                else if (label1.Equals("hour"))
                {
                    if (label2.Equals("minute") || label2.Equals("second"))
                    {
                        label3 = label2;
                    }
                    else
                    {
                        label3 = label1;
                    }
                }
                else if (label1.Equals("minute"))
                {
                    if (label2.Equals("second"))
                    {
                        label3 = label2;
                    }
                    else
                    {
                        label3 = label1;
                    }
                }
                else /*if (label1.Equals("second"))*/
                {
                    label3 = label1;
                }
            }

            return label3;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("{" + $"{string.Join(", ", timeAdder(3, "days", 12, "hours"))}" + "}");
            Console.WriteLine("{" + $"{string.Join(", ", timeAdder(1, "day", 12, "hours"))}" + "}");
            Console.WriteLine("{" + $"{string.Join(", ", timeAdder(3, "days", 1, "hour"))}" + "}");
            Console.WriteLine("{" + $"{string.Join(", ", timeAdder(3, "minutes", 12, "minutes"))}" + "}");
            Console.WriteLine("{" + $"{string.Join(", ", timeAdder(1, "minute", 12, "minutes"))}" + "}");
            Console.WriteLine("{" + $"{string.Join(", ", timeAdder(1, "minute", 1, "minute"))}" + "}");
            Console.WriteLine("{" + $"{string.Join(", ", timeAdder(0, "seconds", 1, "minute"))}" + "}");
        }
    }
}
