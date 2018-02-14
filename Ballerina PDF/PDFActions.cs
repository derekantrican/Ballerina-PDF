using iText.Kernel.Pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ballerina_PDF
{
    public static class PDFActions
    {
        public static bool RemovePages(string filePath, List<int> indiciesToRemove, bool throwErrors = false)
        {
            try
            {
                #region Setup
                if (!File.Exists(filePath))
                    throw new Exception("File not found");

                if (indiciesToRemove == null ||
                    indiciesToRemove.Count <= 0)
                    throw new Exception("Invalid parameters");

                PdfReader reader = new PdfReader(filePath);
                PdfDocument document = new PdfDocument(reader);
                string tempFilePath = filePath.Replace(".pdf", "-temp.pdf");
                PdfWriter writer = new PdfWriter(tempFilePath);
                PdfDocument tempDocument = new PdfDocument(writer);
                File.SetAttributes(tempFilePath, File.GetAttributes(tempFilePath) | FileAttributes.Hidden);
                #endregion Setup

                #region Logic
                //-----------I don't like this and want to do it "properly"/differently (if I can)--------
                List<int> pageOrder = Enumerable.Range(1, document.GetNumberOfPages()).ToList();
                foreach (int i in indiciesToRemove)
                    pageOrder.Remove(i);

                foreach (int i in pageOrder)
                    tempDocument.AddPage(document.GetPage(i).CopyTo(tempDocument));
                //----------------------------------------------------------------------------------------
                #endregion Logic

                #region Teardown
                document.Close();
                tempDocument.Close();

                File.Delete(filePath);
                File.Move(tempFilePath, filePath); //Renames the tempFilePath to the original filePath
                File.SetAttributes(filePath, File.GetAttributes(filePath) & ~FileAttributes.Hidden); //"unhide" the file (remove the hidden attribute that was associated with the tempFilePath)
                #endregion Logic

                return true;
            }
            catch (Exception ex)
            {
                if (throwErrors)
                    MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace);

                return false;
            }
        }

        public static bool RemoveEvenPages(string filePath, bool throwErrors = false)
        {
            try
            {
                #region Setup
                if (!File.Exists(filePath))
                    throw new Exception("File not found");

                PdfReader reader = new PdfReader(filePath);
                PdfDocument document = new PdfDocument(reader);
                string tempFilePath = filePath.Replace(".pdf", "-temp.pdf");
                PdfWriter writer = new PdfWriter(tempFilePath);
                PdfDocument tempDocument = new PdfDocument(writer);
                File.SetAttributes(tempFilePath, File.GetAttributes(tempFilePath) | FileAttributes.Hidden);
                #endregion Setup

                #region Logic
                //-----------I don't like this and want to do it "properly"/differently (if I can)--------
                List<int> pageOrder = Enumerable.Range(1, document.GetNumberOfPages()).ToList();
                foreach (int i in Enumerable.Range(1, document.GetNumberOfPages()))
                {
                    if (i % 2 == 0)
                        pageOrder.Remove(i);
                }

                foreach (int i in pageOrder)
                    tempDocument.AddPage(document.GetPage(i).CopyTo(tempDocument));
                //----------------------------------------------------------------------------------------
                #endregion Logic

                #region Teardown
                document.Close();
                tempDocument.Close();

                File.Delete(filePath);
                File.Move(tempFilePath, filePath); //Renames the tempFilePath to the original filePath
                File.SetAttributes(filePath, File.GetAttributes(filePath) & ~FileAttributes.Hidden); //"unhide" the file (remove the hidden attribute that was associated with the tempFilePath)
                #endregion Logic

                return true;
            }
            catch (Exception ex)
            {
                if (throwErrors)
                    MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace);

                return false;
            }
        }

        public static bool RemoveOddPages(string filePath, bool throwErrors = false)
        {
            try
            {
                #region Setup
                if (!File.Exists(filePath))
                    throw new Exception("File not found");

                PdfReader reader = new PdfReader(filePath);
                PdfDocument document = new PdfDocument(reader);
                string tempFilePath = filePath.Replace(".pdf", "-temp.pdf");
                PdfWriter writer = new PdfWriter(tempFilePath);
                PdfDocument tempDocument = new PdfDocument(writer);
                File.SetAttributes(tempFilePath, File.GetAttributes(tempFilePath) | FileAttributes.Hidden);
                #endregion Setup

                #region Logic
                //-----------I don't like this and want to do it "properly"/differently (if I can)--------
                List<int> pageOrder = Enumerable.Range(1, document.GetNumberOfPages()).ToList();
                foreach (int i in Enumerable.Range(1, document.GetNumberOfPages()))
                {
                    if (i % 2 != 0)
                        pageOrder.Remove(i);
                }

                foreach (int i in pageOrder)
                    tempDocument.AddPage(document.GetPage(i).CopyTo(tempDocument));
                //----------------------------------------------------------------------------------------
                #endregion Logic

                #region Teardown
                document.Close();
                tempDocument.Close();

                File.Delete(filePath);
                File.Move(tempFilePath, filePath); //Renames the tempFilePath to the original filePath
                File.SetAttributes(filePath, File.GetAttributes(filePath) & ~FileAttributes.Hidden); //"unhide" the file (remove the hidden attribute that was associated with the tempFilePath)
                #endregion Logic

                return true;
            }
            catch (Exception ex)
            {
                if (throwErrors)
                    MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace);

                return false;
            }
        }

        public static bool ReorderPages(string filePath, List<int> newPageOrder, bool throwErrors = false)
        {
            try
            {
                #region Setup
                if (!File.Exists(filePath))
                    throw new Exception("File not found");

                if (newPageOrder == null ||
                    newPageOrder.Count <= 0)
                    throw new Exception("Invalid parameters");

                PdfReader reader = new PdfReader(filePath);
                PdfDocument document = new PdfDocument(reader);
                string tempFilePath = filePath.Replace(".pdf", "-temp.pdf");
                PdfWriter writer = new PdfWriter(tempFilePath);
                PdfDocument tempDocument = new PdfDocument(writer);
                File.SetAttributes(tempFilePath, File.GetAttributes(tempFilePath) | FileAttributes.Hidden);

                if (newPageOrder.Count != document.GetNumberOfPages())
                    return false;
                #endregion Setup

                #region Logic
                foreach (int i in newPageOrder)
                    tempDocument.AddPage(document.GetPage(i).CopyTo(tempDocument));
                #endregion Logic

                #region Teardown
                document.Close();
                tempDocument.Close();

                File.Delete(filePath);
                File.Move(tempFilePath, filePath); //Renames the tempFilePath to the original filePath
                File.SetAttributes(filePath, File.GetAttributes(filePath) & ~FileAttributes.Hidden); //"unhide" the file (remove the hidden attribute that was associated with the tempFilePath)
                #endregion Teardown

                return true;
            }
            catch (Exception ex)
            {
                if (throwErrors)
                    MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace);

                return false;
            }
        }

        public static bool RotatePages(string filePath, List<KeyValuePair<int, int>> indiciesAndAngles, bool throwErrors = false)
        {
            try
            {
                #region Setup
                if (!File.Exists(filePath))
                    throw new Exception("File not found");

                if (indiciesAndAngles == null ||
                    indiciesAndAngles.Count <= 0)
                    throw new Exception("Invalid parameters");

                PdfReader reader = new PdfReader(filePath);
                PdfDocument document = new PdfDocument(reader);
                string tempFilePath = filePath.Replace(".pdf", "-temp.pdf");
                PdfWriter writer = new PdfWriter(tempFilePath);
                PdfDocument tempDocument = new PdfDocument(writer);
                File.SetAttributes(tempFilePath, File.GetAttributes(tempFilePath) | FileAttributes.Hidden);
                #endregion Setup

                #region Logic
                for (int i = 1; i <= document.GetNumberOfPages(); i++)
                    tempDocument.AddPage(document.GetPage(i).CopyTo(tempDocument));

                foreach (KeyValuePair<int, int> indexAnglePair in indiciesAndAngles)
                    tempDocument.GetPage(indexAnglePair.Key).SetRotation(document.GetPage(indexAnglePair.Key).GetRotation() + indexAnglePair.Value);
                #endregion Logic

                #region Teardown
                document.Close();
                tempDocument.Close();

                File.Delete(filePath);
                File.Move(tempFilePath, filePath); //Renames the tempFilePath to the original filePath
                File.SetAttributes(filePath, File.GetAttributes(filePath) & ~FileAttributes.Hidden); //"unhide" the file (remove the hidden attribute that was associated with the tempFilePath)
                #endregion Teardown

                return true;
            }
            catch (Exception ex)
            {
                if (throwErrors)
                    MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace);

                return false;
            }
        }

        public static bool RotateEvenPages(string filePath, int angle, bool throwErrors = false)
        {
            try
            {
                #region Setup
                if (!File.Exists(filePath))
                    throw new Exception("File not found");

                PdfReader reader = new PdfReader(filePath);
                PdfDocument document = new PdfDocument(reader);
                string tempFilePath = filePath.Replace(".pdf", "-temp.pdf");
                PdfWriter writer = new PdfWriter(tempFilePath);
                PdfDocument tempDocument = new PdfDocument(writer);
                File.SetAttributes(tempFilePath, File.GetAttributes(tempFilePath) | FileAttributes.Hidden);
                #endregion Setup

                #region Logic
                for (int i = 1; i <= document.GetNumberOfPages(); i++)
                    tempDocument.AddPage(document.GetPage(i).CopyTo(tempDocument));

                for (int i = 1; i <= document.GetNumberOfPages(); i++)
                {
                    if (i % 2 == 0)
                        tempDocument.GetPage(i).SetRotation(document.GetPage(i).GetRotation() + angle);
                }
                #endregion Logic

                #region Teardown
                document.Close();
                tempDocument.Close();

                File.Delete(filePath);
                File.Move(tempFilePath, filePath); //Renames the tempFilePath to the original filePath
                File.SetAttributes(filePath, File.GetAttributes(filePath) & ~FileAttributes.Hidden); //"unhide" the file (remove the hidden attribute that was associated with the tempFilePath)
                #endregion Teardown

                return true;
            }
            catch (Exception ex)
            {
                if (throwErrors)
                    MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace);

                return false;
            }
        }

        public static bool RotateOddPages(string filePath, int angle, bool throwErrors = false)
        {
            try
            {
                #region Setup
                if (!File.Exists(filePath))
                    throw new Exception("File not found");

                PdfReader reader = new PdfReader(filePath);
                PdfDocument document = new PdfDocument(reader);
                string tempFilePath = filePath.Replace(".pdf", "-temp.pdf");
                PdfWriter writer = new PdfWriter(tempFilePath);
                PdfDocument tempDocument = new PdfDocument(writer);
                File.SetAttributes(tempFilePath, File.GetAttributes(tempFilePath) | FileAttributes.Hidden);
                #endregion Setup

                #region Logic
                for (int i = 1; i <= document.GetNumberOfPages(); i++)
                    tempDocument.AddPage(document.GetPage(i).CopyTo(tempDocument));

                for (int i = 1; i <= document.GetNumberOfPages(); i++)
                {
                    if (i % 2 != 0)
                        tempDocument.GetPage(i).SetRotation(document.GetPage(i).GetRotation() + angle);
                }
                #endregion Logic

                #region Teardown
                document.Close();
                tempDocument.Close();

                File.Delete(filePath);
                File.Move(tempFilePath, filePath); //Renames the tempFilePath to the original filePath
                File.SetAttributes(filePath, File.GetAttributes(filePath) & ~FileAttributes.Hidden); //"unhide" the file (remove the hidden attribute that was associated with the tempFilePath)
                #endregion Teardown

                return true;
            }
            catch (Exception ex)
            {
                if (throwErrors)
                    MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace);

                return false;
            }
        }

        public static bool RotateAllPages(string filePath, int angle, bool throwErrors = false)
        {
            try
            {
                #region Setup
                if (!File.Exists(filePath))
                    throw new Exception("File not found");

                PdfReader reader = new PdfReader(filePath);
                PdfDocument document = new PdfDocument(reader);
                string tempFilePath = filePath.Replace(".pdf", "-temp.pdf");
                PdfWriter writer = new PdfWriter(tempFilePath);
                PdfDocument tempDocument = new PdfDocument(writer);
                File.SetAttributes(tempFilePath, File.GetAttributes(tempFilePath) | FileAttributes.Hidden);
                #endregion Setup

                #region Logic
                for (int i = 1; i <= document.GetNumberOfPages(); i++)
                    tempDocument.AddPage(document.GetPage(i).CopyTo(tempDocument));

                for (int i = 1; i <= document.GetNumberOfPages(); i++)
                    tempDocument.GetPage(i).SetRotation(document.GetPage(i).GetRotation() + angle);
                #endregion Logic

                #region Teardown
                document.Close();
                tempDocument.Close();

                File.Delete(filePath);
                File.Move(tempFilePath, filePath); //Renames the tempFilePath to the original filePath
                File.SetAttributes(filePath, File.GetAttributes(filePath) & ~FileAttributes.Hidden); //"unhide" the file (remove the hidden attribute that was associated with the tempFilePath)
                #endregion Teardown

                return true;
            }
            catch (Exception ex)
            {
                if (throwErrors)
                    MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace);

                return false;
            }
        }

        public static bool MergePDF(string filePath, string filePathToMerge, bool throwErrors = false)
        {
            try
            {
                #region Setup
                if (!File.Exists(filePath) ||
                    !File.Exists(filePathToMerge))
                    throw new Exception("File(s) not found");

                PdfReader reader = new PdfReader(filePath);
                PdfDocument document = new PdfDocument(reader);
                string tempFilePath = filePath.Replace(".pdf", "-temp.pdf");
                PdfWriter writer = new PdfWriter(tempFilePath);
                PdfDocument tempDocument = new PdfDocument(writer);
                File.SetAttributes(tempFilePath, File.GetAttributes(tempFilePath) | FileAttributes.Hidden);

                PdfReader mergeReader = new PdfReader(filePathToMerge);
                PdfDocument mergeDocument = new PdfDocument(mergeReader);
                #endregion Setup

                #region Logic
                for (int i = 1; i <= document.GetNumberOfPages(); i++)
                    tempDocument.AddPage(document.GetPage(i).CopyTo(tempDocument));

                for (int i = 1; i <= mergeDocument.GetNumberOfPages(); i++)
                    tempDocument.AddPage(mergeDocument.GetPage(i).CopyTo(tempDocument));
                #endregion Logic

                #region Teardown
                document.Close();
                tempDocument.Close();

                File.Delete(filePath);
                File.Move(tempFilePath, filePath); //Renames the tempFilePath to the original filePath
                File.SetAttributes(filePath, File.GetAttributes(filePath) & ~FileAttributes.Hidden); //"unhide" the file (remove the hidden attribute that was associated with the tempFilePath)
                #endregion Teardown

                return true;
            }
            catch (Exception ex)
            {
                if (throwErrors)
                    MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace);

                return false;
            }
        }

        public static bool MovePage(string filePath, int oldIndex, int newIndex, bool throwErrors = false)
        {
            try
            {
                #region Setup
                if (!File.Exists(filePath))
                    throw new Exception("File not found");

                if (oldIndex <= 0 || newIndex <= 0)
                    throw new Exception("Invalid parameters");

                PdfReader reader = new PdfReader(filePath);
                PdfDocument document = new PdfDocument(reader);
                string tempFilePath = filePath.Replace(".pdf", "-temp.pdf");
                PdfWriter writer = new PdfWriter(tempFilePath);
                PdfDocument tempDocument = new PdfDocument(writer);
                File.SetAttributes(tempFilePath, File.GetAttributes(tempFilePath) | FileAttributes.Hidden);
                #endregion Setup

                #region Logic
                List<int> pageOrder = Enumerable.Range(1, document.GetNumberOfPages()).ToList();
                pageOrder.Insert(newIndex - 1, oldIndex); //"- 1" because lists are zero-index-based and pages are not
                pageOrder.Remove(oldIndex);

                foreach (int i in pageOrder)
                    tempDocument.AddPage(document.GetPage(i).CopyTo(tempDocument));
                #endregion Logic

                #region Teardown
                document.Close();
                tempDocument.Close();

                File.Delete(filePath);
                File.Move(tempFilePath, filePath); //Renames the tempFilePath to the original filePath
                File.SetAttributes(filePath, File.GetAttributes(filePath) & ~FileAttributes.Hidden); //"unhide" the file (remove the hidden attribute that was associated with the tempFilePath)
                #endregion Teardown

                return true;
            }
            catch (Exception ex)
            {
                if (throwErrors)
                    MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace);

                return false;
            }
        }
    }
}
