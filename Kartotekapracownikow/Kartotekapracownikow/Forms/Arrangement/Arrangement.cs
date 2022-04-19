using Aspose.Words;
using Aspose.Words.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kartotekapracownikow.Forms.Arrangement
{
    public partial class Arrangement : Form
    {
        public Arrangement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generatePDF();
        }

        private void generatePDF()
        {
            Document doc = new Document();
            DocumentBuilder builder = new DocumentBuilder(doc);

            Aspose.Words.Font font = builder.Font;
            font.Size = 32;
            font.Bold = true;
            font.Color = System.Drawing.Color.Black;
            font.Name = "Arial";
            font.Underline = Underline.Single;

            // Insert text
            builder.Writeln("This is the first page.");
            builder.Writeln();

            // Change formatting for next elements.
            font.Underline = Underline.None;
            font.Size = 10;
            font.Color = System.Drawing.Color.Blue;

            builder.Writeln("This following is a table");
            // Insert a table
            Table table = builder.StartTable();
            // Insert a cell
            builder.InsertCell();
            // Use fixed column widths.
            table.AutoFit(AutoFitBehavior.AutoFitToContents);
            builder.CellFormat.VerticalAlignment = CellVerticalAlignment.Center;
            builder.Write("This is row 1 cell 1");
            // Insert a cell
            builder.InsertCell();
            builder.Write("This is row 1 cell 2");
            builder.EndRow();
            builder.InsertCell();
            builder.Write("This is row 2 cell 1");
            builder.InsertCell();
            builder.Write("This is row 2 cell 2");
            builder.EndRow();
            builder.EndTable();
            builder.Writeln();

            //// Insert image
            //builder.InsertImage("image.png");
            //// Insert page break 
            builder.InsertBreak(BreakType.PageBreak);
            // all the elements after page break will be inserted to next page.

            // Save the document
            doc.Save("Document.docx");


        }
    }
}
