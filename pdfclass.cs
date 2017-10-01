using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
namespace pdfApp
{
    class pdfclass
    {
        
        public static bool MergePDFS(IEnumerable<string> fileNames, string targetPDF)
        {
            bool merged = true;

            using (FileStream stream = new FileStream(targetPDF, FileMode.Create))
            {
                Document document = new Document();
                PdfCopy pdf = new PdfCopy(document, stream);
                PdfReader reader = null;

                try
                {
                    document.Open();
                    foreach(string file in fileNames)
                    {
                        reader = new PdfReader(file);
                        pdf.AddDocument(reader);
                        reader.Close();
                    }
                }
                catch (Exception)
                {
                    merged = false;
                    if(reader != null)
                    {
                        reader.Close();
                    }
                }
                finally
                {
                    if(document != null)
                    {
                        document.Close();
                    }
                }
            }
                return merged;
        }

        public static int countPages(string sourceFile)
        {
            PdfReader reader = new PdfReader(sourceFile);
            int totalPages = reader.NumberOfPages;
            reader.Close();
            return totalPages;
        }

        public static void removePages(String sourceFile, String desFile, int[] keptPages)
        {
            PdfReader reader = new PdfReader(sourceFile);

            using (FileStream fs = new FileStream(desFile, FileMode.Create,FileAccess.Write, FileShare.None))
            {
                using(Document doc = new Document())
                {
                    using(PdfWriter writer = PdfWriter.GetInstance(doc, fs))
                    {
                        doc.Open();

                        foreach(int page in keptPages)
                        {
                            doc.NewPage();
                            writer.DirectContent.AddTemplate(writer.GetImportedPage(reader, page), 0, 0);
                        }

                        doc.Close();
                    }
                }
            }
        }

        //checks the last for chars in a string for .pdf file extension.
        public static string checkFileExtension(string fileName)
        {
            string extension = Path.GetExtension(fileName);
            string correctExtension = ".pdf";
            if (string.IsNullOrEmpty(extension))
            {
                return fileName + correctExtension;
            }
            else if(string.Compare(extension,correctExtension,StringComparison.OrdinalIgnoreCase)!=0 )
            {
                
                fileName= fileName.Replace(extension, correctExtension);
                return fileName;
            }
            else
            {
                return fileName;
            }
        }

        public static void Insert(string first_source, string second_source, string destination,int PageNumber)
        {
            
            //create a document object
            int pageTotal = countPages(first_source);
            var doc = new Document(PageSize.A4);
            //create PdfReader objects to read pages from the source files
            PdfReader reader = new PdfReader(first_source);
            PdfReader reader1 = new PdfReader(second_source);
            //create PdfStamper object to write to the pages read from readers
            PdfStamper stamper = new PdfStamper(reader1, new FileStream(destination, FileMode.Create));

            for(int i = 1; i <= pageTotal; i++)
            {
                PdfImportedPage page = stamper.GetImportedPage(reader, i);
                stamper.InsertPage(PageNumber, reader.GetPageSize(1));
                PdfContentByte pb = stamper.GetUnderContent(PageNumber);
                pb.AddTemplate(page, 0, 0);
                PageNumber++;
            }
            //close the stamper
            stamper.Close();
        }
    }
}
