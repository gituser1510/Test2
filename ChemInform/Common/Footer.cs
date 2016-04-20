using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace ChemInform.Common
{
    public partial class Footer : PdfPageEventHelper
    {

        // To Add page number dynamically at the end of the pdf page. 
        public override void OnEndPage(PdfWriter writer, Document doc)
        {

            Paragraph footer = new Paragraph((writer.PageNumber + GlobalVariables.PrevTotalPageNumber).ToString(), FontFactory.GetFont(FontFactory.TIMES, 10, iTextSharp.text.Font.NORMAL));
            footer.Alignment = Element.ALIGN_CENTER;
            PdfPTable footerTbl = new PdfPTable(1);
            footerTbl.TotalWidth = 300;
            footerTbl.HorizontalAlignment = Element.ALIGN_CENTER;
            PdfPCell cell = new PdfPCell(footer);
            cell.Border = 0;
            cell.PaddingLeft = 10;
            footerTbl.AddCell(cell);
            footerTbl.WriteSelectedRows(0, -1, 300, 30, writer.DirectContent);
        }

    }
}
