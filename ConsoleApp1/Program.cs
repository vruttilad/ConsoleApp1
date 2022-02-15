using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static TvChannels tvC;
        static void Main(string[] args)
        {
            tvC = new TvChannels(3
                );
            tvC.GetSeriesDetails();
            //tvC.Myseries = new CC();
            //tvC.GetSeriesDetails(new TLC());

        }
    }
    interface ISeries
    {
        void LoadSeriesDetails();
    }

    class TvChannels
    {


        private ISeries series = null;
        SeriesLauncher sl = new SeriesLauncher();

        public TvChannels(int index)
        {
            this.series = sl.LaunchEvent(index);
        }

        //private ISeries Series;
        /* public ISeries Myseries
         {
             set 
             {
                 Series = value;
             }
         }*/

        public void GetSeriesDetails()
        {

            this.series.LoadSeriesDetails();

        }


    }

    class SeriesLauncher
    {

        public ISeries LaunchEvent(int index)
        {
            if (index == 1)
                return new CC();
            else if (index == 2)
                return new TLC();
            else
                return new TravelerXp();


        }

    }

    class CC : ISeries
    {

        public void LoadSeriesDetails()
        {
            Console.WriteLine("Welocme to ComedyCenrtal");
            Console.ReadKey();
        }

        /* string ISeries.LoadSeriesDetails()
         {
             string cc= "Welocme to Comedy Central";
             return cc;
         }*/
    }

    class TLC : ISeries
    {
        public void LoadSeriesDetails()
        {
            Console.WriteLine("Welocme to TLC");
            Console.ReadKey();
        }

        /*string ISeries.LoadSeriesDetails()
        {
            string tlc = "Welocme to TLC";
            return tlc;
        }*/
    }

    class TravelerXp : ISeries
    {
        public void LoadSeriesDetails()
        {
            Console.WriteLine("Welocme to Travellers XP");
            Console.ReadKey();
        }

        /*string ISeries.LoadSeriesDetails()
        {
            string txp = "Welocme to Traveler XP";
            return txp;
        }*/
    }
}
