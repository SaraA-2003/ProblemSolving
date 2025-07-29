using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problem14
{
    //Define a class for custom made list

    class Record
    {
       
        //properties
        public DateTime startTime { get; set; }

        public DateTime endTime { get; set; }      // hh:mm
         public double powerConsumption { get; set; }  // in kw 

        public Record (DateTime startTime, DateTime endTime, double powerConsumption)
        {
            this.startTime = startTime;
            this.endTime = endTime;
            this.powerConsumption = powerConsumption;
        }



    }

    

    internal class ElectricityUsageOptimizer
    {
        //per kwh
        const double Off_Peak = 0.10;
        const double During_Peak = 0.20;
      

        public static void Run()
        {
              double allRecordsTotal=0;
               
            int i = 0;



            //make list of records
            List<Record> records = new List<Record>{
                new Record(DateTime.Parse("2025-07-29T07:00:00"), DateTime.Parse(" 2025-07-29T09:00:00"), 2.0),
                new Record(DateTime.Parse("2025-07-29T05:30:00"), DateTime.Parse("2025-07-29T06:30:00"), 1.5),
                new Record(DateTime.Parse("2025-07-29T21:30:00"), DateTime.Parse("2025-07-29T22:30:00"), 2.0),
            
            };
            foreach (var part in records)
            {
                double recordTotal=0;
                double TotalP=0;
                double TotalOP=0;
                DateTime temp1 = part.startTime;
                DateTime temp2 = part.endTime;
                double peakH =0;
                double offPeakH =0;

                // Extract hh:mm
                TimeSpan start = temp1.TimeOfDay;
                TimeSpan end = temp2.TimeOfDay;
                //Console.WriteLine($"Start time (hh:mm): {start}");
                //Console.WriteLine($"End time (hh:mm): {end}");

                TimeSpan startPeak = new TimeSpan(6, 0, 0); //also = endOffPeak
                TimeSpan startOffPeak = new TimeSpan(22, 0, 0); //also = endPeak

                DateTime startPeakTime = DateTime.Parse("2025-07-29T06:00:00");
                DateTime endPeakTime = DateTime.Parse("2025-07-29T22:00:00");
                //Console.WriteLine($"Start peak (hh:mm): {startPeak}");
                //Console.WriteLine($"Start offpeak (hh:mm): {startOffPeak}");
                //-----------------------------------------------------//

                //during peak
                if (start >= startPeak && end < startOffPeak) {
                    peakH = (part.endTime - part.startTime).TotalHours;
                    recordTotal = duringPeak(peakH, part.powerConsumption);
                    allRecordsTotal += recordTotal;
                }
                //off peak
                else if (start>= startOffPeak && end < startPeak)
                {
                    offPeakH = (part.endTime - part.startTime).TotalHours;
                    recordTotal = offPeak(offPeakH, part.powerConsumption);
                    allRecordsTotal += recordTotal;
                }
                //--------- case for cross peaks -------------//
                else if(start < startPeak && end > startPeak && end < startOffPeak)
                {
                    offPeakH = (startPeakTime - part.startTime).TotalHours;
                    TotalOP = offPeak(offPeakH, part.powerConsumption);
                    peakH = (part.endTime - startPeakTime).TotalHours;
                    TotalP= duringPeak(peakH, part.powerConsumption);
                    recordTotal = TotalP + TotalOP;
                    allRecordsTotal += recordTotal;
                }
                // Case 4: Crosses from peak into off-peak
                else if (start >= startPeak && start < startOffPeak && end > startOffPeak)
                {
                    peakH = (endPeakTime - part.startTime).TotalHours;
                    TotalP = duringPeak(peakH, part.powerConsumption);
                    offPeakH =(part.endTime - endPeakTime).TotalHours;
                    TotalOP = offPeak(offPeakH, part.powerConsumption);
                    recordTotal = TotalP + TotalOP;
                    allRecordsTotal += recordTotal;
                }
                else if (start < startPeak && end > startOffPeak)
                {
                    double hours = ((startPeak - start) + (end - startOffPeak)).TotalHours;
                    TotalOP = offPeak(hours, part.powerConsumption);
                    peakH = (endPeakTime - startPeakTime).TotalHours;
                    TotalP = duringPeak(peakH, part.powerConsumption);
                    recordTotal = TotalP + TotalOP;
                    allRecordsTotal += recordTotal;
                }
                i++;

                Console.WriteLine($"Record {i}");
                Console.WriteLine($"Total: ${recordTotal:F2}");


            }//end of loop
            Console.WriteLine($"The total of all Records ${allRecordsTotal:F2}");
            
        }//end of run

        static double duringPeak (double hours, double power)
        {
            return (hours * power * During_Peak);

        }
        static double offPeak(double hours, double power)
        {
            return (hours * power * Off_Peak);
        }
    }
}
