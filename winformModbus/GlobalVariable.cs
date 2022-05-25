using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winformModbus
{
    public class GlobalVariable
    {
        private static GlobalVariable instance;

        public static GlobalVariable getInstance()
        {
            if (instance == null)
                instance = new GlobalVariable();
            return instance;
        }
        //04 06 00 0B 00 03 B8 5C
        private GlobalVariable() { }//01 06 00 C8 00 06 88 36//02 06 00 0B 00 03 B8 3A//04 06 00 0B 00 01 39 9D//05 06 00 0B 00 01 38 4C
        public int[] AddressBaud=new int[10];//01 06 00 C8 00 03 48 35 9600//02 06 00 0B 00 01 39 FB 9600//04 06 00 0B 00 07 B9 9F//05 06 00 0B 00 07 B8 4E
        public int[] BaudRateList = new int[] { 9600, 19200,38400,57600, 115200 };//01 06 00 0B 00 01 39 C8  9600//01 06 00 0B 00 07 B9 CA 115200//
        public string[] SendDataList = new string[] { "01 04 00 00 00 02 71 CB", "04 04 00 00 00 02 71 9E", "05 04 00 00 00 02 70 4F", "02 04 00 00 00 02 71 F8" };
        public byte[] ToByte(string s)
        {
            return s.Split(' ').AsParallel().Select(x => Convert.ToByte(x, 16)).ToArray();
        }
        public byte[] CRC16LH(byte[] pDataBytes)
        {
            ushort crc = 0xffff;
            ushort polynom = 0xA001;

            for (int i = 0; i < pDataBytes.Length; i++)
            {
                crc ^= pDataBytes[i];
                for (int j = 0; j < 8; j++)
                {
                    if ((crc & 0x01) == 0x01)
                    {
                        crc >>= 1;
                        crc ^= polynom;
                    }
                    else
                    {
                        crc >>= 1;
                    }
                }
            }

            byte[] result = BitConverter.GetBytes(crc);
            byte[] rv = new byte[pDataBytes.Length + result.Length];
            System.Buffer.BlockCopy(pDataBytes, 0, rv, 0, pDataBytes.Length);
            System.Buffer.BlockCopy(result, 0, rv, pDataBytes.Length, result.Length);
            return rv;
        }

        /// <summary>
        /// 高位元組在前
        /// </summary>
        /// <param name="pDataBytes"></param>
        /// <returns></returns>
        public byte[] CRC16HL(byte[] pDataBytes)
        {
            ushort crc = 0xffff;
            ushort polynom = 0xA001;

            for (int i = 0; i < pDataBytes.Length; i++)
            {
                crc ^= pDataBytes[i];
                for (int j = 0; j < 8; j++)
                {
                    if ((crc & 0x01) == 0x01)
                    {
                        crc >>= 1;
                        crc ^= polynom;
                    }
                    else
                    {
                        crc >>= 1;
                    }
                }
            }

            byte[] result = BitConverter.GetBytes(crc).Reverse().ToArray(); 
            byte[] rv = new byte[pDataBytes.Length + result.Length];
            System.Buffer.BlockCopy(pDataBytes, 0, rv, 0, pDataBytes.Length);
            System.Buffer.BlockCopy(result, 0, rv, pDataBytes.Length, result.Length);
            return rv;
        }

    }
}
