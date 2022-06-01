using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DermaFram
{
    static class Program
    {

        /*
        static  ILog log = LogManager.GetLogger("Task");

        static void log4net_demo()
        {
            FileInfo fi = new FileInfo("log4net.xml");
            log4net.Config.XmlConfigurator.Configure(fi);
            log4net.GlobalContext.Properties["host"] = Environment.MachineName;


        }
        */
        //
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]



        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new loginpage());


/*
            log4net_demo();
            log.Info("info msg");
            log.Debug("info msg");
            log.Error("ing");
            log.Fatal("vgvhg");*/
        }
    }
}
