using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winformModbus
{
    public class ComParam
    {
        public string ComName { get; set; }
        public int Databit { get; set; }
        public int Stopbit { get; set; }
        public int Parity { get; set; }
        public int Baud { get; set; }
        public int Address { get; set; }
        public int FunctionCode { get; set; }
        public int DataStart { get; set; }
        public int DataLength { get; set; }
        public ComParam(string comName,int databit,int stopbit,int parity,int baud,int address,int functionCode)
        {
            ComName = comName;
            Databit = databit;
            Stopbit = stopbit;
            Parity = parity;
            Baud = baud;
            Address = address;
            FunctionCode = functionCode;
        }
    }
}
