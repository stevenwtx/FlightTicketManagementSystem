using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            FlightList = new FakeList<Flight> { };
            passList = new FakeList<Passager> { };
 //           init();           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form1 = new Form1();
            form1.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(form1);
           
        }
        
        public static FakeList<Flight> FlightList;
        public static FakeList<Passager> passList;
        public static Dictionary<String,int> flightDic;
        public static Dictionary<String, int> passDic;
        public static int flightindex = 1;
        public static int passindex = 1;
        public static int ordernum=1;
        public static List<string> flightnum;
       
    }

  
}
public class Flight
{
    public String FlightNum { get; set; }
    public String From { get; set; }
    public String Arrival { get; set; }
    public String GetOff { get; set; }
    public String ArrivalTime { get; set; }
    public int Prices { get; set; }
    public double Discount { get; set; }
    public int left{ get; set; }
    public Flight(String s1,String s2,String s3,String s4,String s5,int i1,double d,int i2) {
        FlightNum = s1;
        From = s2;
        Arrival = s3;
        GetOff = s4;
        ArrivalTime = s5;
        Prices = i1;
        Discount = d;
        left = i2;
    }
}

public class Passager
{
    public String Name { get; set; }
    public String IdNum { get; set; }
    public String FlightNum { get; set; }
    public int OrderId { get; set; }
    public int Ticketnum { get; set; }
    public Passager(String s1,string s2,string s3,int s4,int num ){
        Name = s1;
        IdNum = s2;
        FlightNum = s3;
        OrderId = s4;
        Ticketnum = num;
    }
}
