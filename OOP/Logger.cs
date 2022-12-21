using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ToolGameProgram
{
    class Logger
    {
        public static void WriteLog(string message)
        {
            string logpath = "C:/Users/avata/source/repos/OOP/OOP/TestLogs/log.txt";

            using (StreamWriter writer = new StreamWriter(logpath, true))
                writer.WriteLine($"{DateTime.Now} : {message}");
            //{
                //    writer.WriteLine();
                //}
            }
    }
}
