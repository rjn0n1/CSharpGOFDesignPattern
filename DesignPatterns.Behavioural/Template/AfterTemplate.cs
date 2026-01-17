using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Template
{
    public abstract class ReportGenerationService
    {
        protected virtual void FetchData() //can use this all custom implemented 
        {
            //will be same
            Console.WriteLine($"Fetching Data");
        }
        public void Generate()
        {
            FetchData();
            FormatDocument();
            Save();
            Email();
        }

        private void Email()
        {
            Console.WriteLine($"Sent Email");
        }

        private void Save()
        {
            Console.WriteLine($"Save");
        }

        protected abstract void FormatDocument();
        
    }

    public class PdfGenerateTemplateService: ReportGenerationService
    {

        protected override void FormatDocument()
        {
            Console.WriteLine($"Formate Pdf Document.");
        }
    }

    public class ExcelGenerateTemplateService : ReportGenerationService
    {

        protected override void FetchData() //can use this all custom implemented 
        {
            //will be same
            Console.WriteLine($"Fetching Data For excel");
        }
        protected override void FormatDocument()
        {
            Console.WriteLine($"Formatting Excel  Document.");
        }
    }
}
