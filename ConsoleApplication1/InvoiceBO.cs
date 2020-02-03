using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class InvoiceBO
    {
        public static Customer Get_MostValuableCustomer(List<Invoice>  invlist)
        {
            
            var res1 = from i in invlist
                      group i by i.cust.name into cust_amt_list
                      select new
                      {
                          CustName = cust_amt_list.Key,
                          TotalAmt = cust_amt_list.Sum(y => y.amt)
                      };


            double res2 = res1.Max(x => x.TotalAmt);
            var name = res1.FirstOrDefault(x => x.TotalAmt == res2).CustName;

            Customer cust = invlist.FirstOrDefault(x => x.cust.name == name).cust;
            return cust;


        }



        public static void PrintDayWiseRevenue(List<Invoice> invlist)
        {
            var res1 = from i in invlist
                       group i by i.doj into Day_amt_list
                       select new
                       {
                           Date = Day_amt_list.Key,
                           TotalAmt = Day_amt_list.Sum(y => y.amt)
                       };

            foreach(var p in res1)
            {
                Console.WriteLine(p.Date.ToLongDateString() + "\t" + p.TotalAmt);
            }


        }
    }
}
