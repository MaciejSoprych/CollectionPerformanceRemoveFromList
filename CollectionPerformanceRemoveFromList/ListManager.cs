using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPerformanceRemoveFromList
{
    public class ListManager
    {
        public List<SaleRecord> RemoveItemsOofN2(List<SaleRecord> records)
        {
            for (int i = 0; i < records.Count-1; i++)
            {
                if (records[i].Value > 100)
                {
                    records.RemoveAt(i);
                }
            }
            return records;
        }

        public List<SaleRecord> RemoveItemsOofN(List<SaleRecord> records)
        {
            records.RemoveAll(r => r.Value > 100);
            return records;
        }
    }
}
