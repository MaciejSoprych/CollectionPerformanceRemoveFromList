using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace CollectionPerformanceRemoveFromList
{
    public static class TxtReader
    {

        public static List<SaleRecord> GetList()
        {

            List<SaleRecord> results = new List<SaleRecord>();

            System.Reflection.Assembly thisExe = System.Reflection.Assembly.GetExecutingAssembly();
            Stream file = thisExe.GetManifestResourceStream("CollectionPerformanceRemoveFromList.Recources.Zeszyt1.csv");
           
            using (StreamReader streamReader = new StreamReader(file))
            {
                streamReader.ReadLine();
                string txtLine;
                while ((txtLine = streamReader.ReadLine()) != null)
                {
                    streamReader.ReadLine();
                    var record = GetLineCsv(txtLine);
                    results.Add(record);
                }

            }
            return results;
        }
        public static SaleRecord GetLineCsv(string txtLine)
        {
            string[] line = txtLine.Split(';');

            string name = line[0];
            int value = Convert.ToInt32(line[1]);

            SaleRecord saleRecord = new SaleRecord(name, value);
            return saleRecord;
        }
    }
}
