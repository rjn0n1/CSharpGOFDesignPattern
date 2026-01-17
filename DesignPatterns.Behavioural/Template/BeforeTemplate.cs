namespace DesignPatterns.Behavioural.Template
{
    public class PdfReportService
    { 
        private void FetchData()
        {

        }
        public void Generate()
        {
            FetchData();
            FormatPdf();
            Save();
            Email();
        }

        private void Email()
        {
            Console.WriteLine($"Sent Email");
        }

        private void Save()
        {
            Console.WriteLine($"Save Pdf");
        }

        private void FormatPdf()
        {
            Console.WriteLine($"FormatePdf");
        }
    }

    public class ExcelReportService
    {
        private void FetchData()
        {
            Console.WriteLine($"Accessing data for Excel");
        }
        public void Generate()
        {
            FetchData();
            FormatExcel();
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

        private void FormatExcel()
        {
            Console.WriteLine($"Formate Excel File.");
        }
    }
}
