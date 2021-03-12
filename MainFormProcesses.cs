using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ExtraeNombresACarpetas
{
    public partial class MainFormProcesses
    {
        private MainForm mainForm;

        public void ProcessFileStart(MainForm mainForm)
        {
            this.mainForm = mainForm;

            List<string> errors;
            if (ValidateInputs(out errors) == false)
            {
                mainForm.txtResults.ForeColor = Color.Red;
                mainForm.txtResults.Text = FormatErrorsList(errors);
                return;
            }

            try
            {
                List<string> foldersNames = ReadExcelFile();
                if (foldersNames.Count == 0)
                {
                    mainForm.txtResults.ForeColor = Color.Yellow;
                    mainForm.txtResults.Text = "No se encontraron datos en las celdas "
                            + "especificadas.";
                    return;
                }

                CreateFolders(foldersNames);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error desconocido.");
                mainForm.txtResults.Text = ex.ToString();
                return;
            }

            Success();
        }

        private bool ValidateInputs(out List<string> errors)
        {
            errors = new List<string>();

            if (File.Exists(mainForm.txtSourceFilePath.Text) == false)
            {
                errors.Add(FormatError("El archivo seleccionado no se encontró."));
            }
            else if (mainForm.txtSourceFilePath.Text.EndsWith(".xls") == false &&
                    mainForm.txtSourceFilePath.Text.EndsWith(".xlsx") == false)
            {
                errors.Add(FormatError("El archivo debe ser de Excel (*.xls | *.xlsx)"));
            }

            string column = mainForm.txtColumn.Text.Trim().ToUpperInvariant();
            if (column.CompareTo("A") < 0 || column.CompareTo("XFD") > 0)
            {
                errors.Add(FormatError("La celda escrita no es válida."));
            }

            // Start row ; 0 if empty
            decimal numStartRow = string.IsNullOrWhiteSpace(mainForm.numStartRow.Text)
                    ? 0 : mainForm.numStartRow.Value;
            // End row ; 0 if empty
            decimal numEndRow = string.IsNullOrWhiteSpace(mainForm.numEndRow.Text)
                    ? 0 : mainForm.numEndRow.Value;

            if (numStartRow < 1 || numStartRow > 1048576)
            {
                errors.Add(FormatError("La Fila Inicial no puede ser menor que 1 ni "
                        + "mayor que 1,048,576"));
            }

            if (numEndRow < 1 || numEndRow > 1048576)
            {
                errors.Add(FormatError("La Fila Final no puede ser menor que 1 ni "
                        + "mayor que 1,048,576"));
            }

            if (numStartRow > numEndRow)
            {
                errors.Add(FormatError("La Fila Inicial no puede ser mayor que "
                        + "la Fila Final."));
            }

            if (Directory.Exists(mainForm.txtFolderDestination.Text) == false)
            {
                errors.Add(FormatError("La Ruta destino no fue encontrada."));
            }

            // if 0 errors returns true (Valid form)
            return errors.Count == 0;
        }

        private string FormatError(string message)
        {
            string format = "- {0}";
            return string.Format(format, message);
        }

        private string FormatErrorsList(List<string> errors)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var error in errors)
            {
                sb.Append(error);
                sb.Append(Environment.NewLine);
            }

            return sb.ToString();
        }

        private List<string> ReadExcelFile()
        {
            var result = new List<string>();

            string filePath = mainForm.txtSourceFilePath.Text;

            using (var stream = File.Open(
                    filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var reader = ExcelReaderFactory.CreateReader(stream))
            {
                var dataSet = reader.AsDataSet();
                result = ExtractDataFromCells(dataSet);
            }

            return result;
        }

        private void CreateFolders(List<string> foldersNames)
        {
            var basePath = mainForm.txtFolderDestination.Text;

            foreach (var folderName in foldersNames)
            {
                Directory.CreateDirectory(Path.Combine(basePath, folderName));
            }
        }

        private List<string> ExtractDataFromCells(System.Data.DataSet dataSet)
        {
            var result = new List<string>();

            // Always same column
            int columnIndex = ExcelColumnNameToNumber(mainForm.txtColumn.Text);
            // Convert to int
            int startRowIndex = (int)mainForm.numStartRow.Value - 1;
            int endRowIndex = (int)mainForm.numEndRow.Value - 1;

            // From startRow until endRow
            for (int rowIndex = startRowIndex; rowIndex <= endRowIndex; rowIndex++)
            {
                string text = dataSet.Tables[0].Rows[rowIndex][columnIndex].ToString();

                // Ignore blank cells
                if (string.IsNullOrWhiteSpace(text)) continue;

                result.Add(text.Trim());
            }

            return result;
        }

        private int ExcelColumnNameToNumber(string columnName)
        {
            if (string.IsNullOrEmpty(columnName)) throw new ArgumentNullException("columnName");

            columnName = columnName.ToUpperInvariant();

            int sum = 0;

            for (int i = 0; i < columnName.Length; i++)
            {
                sum *= 26;
                sum += (columnName[i] - 'A');
            }

            return sum;
        }

        private void Success()
        {
            System.Diagnostics.Process.Start(mainForm.txtFolderDestination.Text);

            mainForm.txtResults.ForeColor = Color.Lime;
            mainForm.txtResults.Text = "¡Listo! Encuentra tus carpetas en:\n"
                    + Environment.NewLine + Environment.NewLine
                    + mainForm.txtFolderDestination.Text;
        }

    }
}
