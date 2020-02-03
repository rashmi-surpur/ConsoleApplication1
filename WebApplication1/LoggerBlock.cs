using Microsoft.Practices.EnterpriseLibrary.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace WebApplication1
{
public class LoggerBlock
    {
        protected LogWriter logWriter;

        public LoggerBlock()
        {
            InitLogging();
        }

        private void InitLogging()
        {
            logWriter = new LogWriterFactory().Create();
            Logger.SetLogWriter(logWriter, false);
        }

        public LogWriter LogWriter
        {
            get
            {
                return logWriter;
            }
        }
    }


public class Executer
{
    LoggerBlock loggerBlock = new LoggerBlock();

    public static void LogMyMsgs()
    {
        new Executer().ReadFile();
    }

    public void ReadFile()
    {
        WriteTraceLog("Application Started!!!");

        string[] lines;
        var list = new List<string>();
        var fileStream = new FileStream(@"D:\ATOS\Repos\RollingFlatFile.log", FileMode.Open, FileAccess.Read);
        using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
        {
            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                WriteTraceLog(line);

                list.Add(line);
            }
                fileStream.Close();
        }

        lines = list.ToArray();

        WriteTraceLog("Application Stopped!!!");
    }
    public void WriteTraceLog(String message)
    {
        loggerBlock.LogWriter.Write(message, "General", 5, 2000, TraceEventType.Information);
    }
}


}  