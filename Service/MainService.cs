using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Logical;

namespace Service
{
    //https://msdn.microsoft.com/ru-ru/library/vstudio/zt39148a%28v=vs.110%29.aspx
    //installutil.exe Service.exe

    public partial class MainService : ServiceBase
    {
        Logical.LogFile file;

        public MainService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            file = new LogFile();

            file.Write("OnStart");
        }

        protected override void OnStop()
        {
            file.Write("OnStop");

            file.Dispose();
        }

        protected override void OnPause()
        {
            file.Write("OnPause");
        }

        protected override void OnContinue()
        {
            file.Write("OnContinue");
        }
    }
}
