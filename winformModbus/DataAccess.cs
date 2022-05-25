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
        public List<StatisticDB> GetModbusDB(int address)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("modbusDBStrings")))
            {
                var output = connection.Query<StatisticDB>($"select * from TableStatistic where Address = '{ address }'").ToList();
                //var output = connection.Query<StatisticDB>("dbo.People_GetByLastName @Address", new { Address = address }).ToList();
                return output;
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
