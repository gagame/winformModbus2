using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winformModbus
{
    public class StatisticDB
    {
        //int _baudrateDB, _addressDB, _functionCodeDB, _pollCountDB, _respionseCountDB;
        public int ID { get; set; }
        public int COM { get; set; }
        public int Baud { get; set; }
        public int DataBits { get; set; }
        public int StopBits { get; set; }
        public int Parity { get; set; }
        public int Address { get; set; }
        public int FunctionCode { get; set; }
        public int PollCount { get; set; }
        public int ResponseCount { get; set; }
        public string Info
        {
            get
            {
                return $"Address:{ Address } Baud:{Baud} Poll:{ PollCount } Response:{ ResponseCount }";
            }
        }

    }
}
