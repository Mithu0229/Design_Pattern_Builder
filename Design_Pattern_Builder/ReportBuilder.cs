using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Builder
{
    public abstract class ReportBuilder //Creating the Abstract Builder class
    {
        protected Report reportObject;
        public abstract void SetReportType();
        public abstract void SetReportHeader();
        public abstract void SetReportContent();
        public abstract void SetReportFooter();
        public void CreateNewReport()
        {
            reportObject = new Report();
        }
        public Report GetReport()
        {
            return reportObject;
        }
    }
}
