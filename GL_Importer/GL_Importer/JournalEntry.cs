﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml;

namespace GL_Importer
{
    class JournalEntry
    {
        public int seg1 { get; set; }
        public int seg2 { get; set; }
        public decimal Amount { get; set; }
        public int Account { get; set; }
        public string lineItem { get; set; }

        public static JournalEntry Build(List<string>Data)
        {
            JournalEntry je = new JournalEntry();
            je.seg1 = Convert.ToInt32(Data[0]);
            je.Account = Convert.ToInt32(Data[1]);
            je.seg2 = Convert.ToInt32(Data[2]);
            je.Amount = Convert.ToDecimal(Data[3]);
            je.lineItem = Data[4];
            return je;
        }

        public static string stringConverter(WorkbookPart workBookPart, int index)
        {
            SharedStringItem ssi = new SharedStringItem();
            string text = "";
            ssi = workBookPart.SharedStringTablePart.SharedStringTable.Elements<SharedStringItem>().ElementAt(index);
            text = ssi.InnerText;
            return text;
        }


        
    }
}
