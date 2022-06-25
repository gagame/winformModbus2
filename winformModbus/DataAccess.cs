using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace winformModbus
{
    public class DataAccess
    {
        public List<StatisticDB> GetModbusDB(string com, string baud, string data, string stop, string parity, string add, string func, string poll, string resp)
        {
            if (com != "") com = $"COM = {com}";
            if (baud != "") baud = $"Baud = {baud}";
            if (data != "") data = $"DataBits={data}";
            if (stop != "") stop = $"StopBits={stop}";
            if (parity != "") parity = $"Parity={parity}";
            if (add != "") add = $"Address={add}";
            if (func != "") func = $"FunctionCode={func}";
            if (poll != "") poll = $"PollCount={poll}";
            if (resp != "") resp = $"ResponseCount={resp}";
            StringBuilder sb = new StringBuilder();
            sb.Append(com);
            if (sb.Length != 0&& baud != "") sb.Append(" AND ");
            sb.Append(baud);
            if (sb.Length != 0 && data != "") sb.Append(" AND ");
            sb.Append(data);
            if (sb.Length != 0 && stop != "") sb.Append(" AND ");
            sb.Append(stop);
            if (sb.Length != 0 && parity != "") sb.Append(" AND ");
            sb.Append(parity);
            if (sb.Length != 0 && add != "") sb.Append(" AND ");
            sb.Append(add);
            if (sb.Length != 0 && func != "") sb.Append(" AND ");
            sb.Append(func);
            if (sb.Length != 0 && poll != "") sb.Append(" AND ");
            sb.Append(poll);
            if (sb.Length != 0 && resp != "") sb.Append(" AND ");
            sb.Append(resp);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("modbusDBStrings")))
            {
                var output = connection.Query<StatisticDB>($"select * from TableStatistic where {sb}");
                return output.ToList();
            }
        }

        public void InsertModbusDB(int com, int baud, int dataBits, int stopBits,int parity,int address,int functionCode,int pollCount,int responseCount)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("modbusDBStrings")))
            {
                var output=connection.Execute($"insert into TableStatistic(COM,Baud,DataBits,StopBits,Parity,Address,FunctionCode,PollCount,ResponseCount)  values({com},{baud},{dataBits},{stopBits},{parity},{address},{functionCode},{pollCount},{responseCount})");
                Console.WriteLine($"insert {output} successful");

            }
        }
    }
}
