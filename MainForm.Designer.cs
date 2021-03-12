
namespace ExtraeNombresACarpetas
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ofdSelectXls = new System.Windows.Forms.OpenFileDialog();
            this.btnSearchFile = new System.Windows.Forms.Button();
            this.txtSourceFilePath = new System.Windows.Forms.TextBox();
            this.lblColumn = new System.Windows.Forms.Label();
            this.txtColumn = new System.Windows.Forms.TextBox();
            this.lblStartRow = new System.Windows.Forms.Label();
            this.numStartRow = new System.Windows.Forms.NumericUpDown();
            this.numEndRow = new System.Windows.Forms.NumericUpDown();
            this.lblEndRow = new System.Windows.Forms.Label();
            this.tooltip1 = new System.Windows.Forms.ToolTip(this.components);
            this.fbdSelectDestination = new System.Windows.Forms.FolderBrowserDialog();
            this.btnDestinationFolder = new System.Windows.Forms.Button();
            this.txtFolderDestination = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStartRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndRow)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFolderDestination);
            this.groupBox1.Controls.Add(this.btnDestinationFolder);
            this.groupBox1.Controls.Add(this.numEndRow);
            this.groupBox1.Controls.Add(this.lblEndRow);
            this.groupBox1.Controls.Add(this.numStartRow);
            this.groupBox1.Controls.Add(this.lblStartRow);
            this.groupBox1.Controls.Add(this.txtColumn);
            this.groupBox1.Controls.Add(this.lblColumn);
            this.groupBox1.Controls.Add(this.txtSourceFilePath);
            this.groupBox1.Controls.Add(this.btnSearchFile);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuración";
            // 
            // ofdSelectXls
            // 
            this.ofdSelectXls.Filter = "Excel files (*.xls;*.xlsx)|*.xls;*.xlsx|All files (*.*)|*.*";
            // 
            // btnSearchFile
            // 
            this.btnSearchFile.Location = new System.Drawing.Point(6, 19);
            this.btnSearchFile.Name = "btnSearchFile";
            this.btnSearchFile.Size = new System.Drawing.Size(115, 23);
            this.btnSearchFile.TabIndex = 0;
            this.btnSearchFile.Text = "Archivo de Excel...";
            this.tooltip1.SetToolTip(this.btnSearchFile, "Haga click para buscar un archivo");
            this.btnSearchFile.UseVisualStyleBackColor = true;
            this.btnSearchFile.Click += new System.EventHandler(this.btnSearchFile_Click);
            // 
            // txtSourceFilePath
            // 
            this.txtSourceFilePath.Location = new System.Drawing.Point(127, 21);
            this.txtSourceFilePath.Name = "txtSourceFilePath";
            this.txtSourceFilePath.Size = new System.Drawing.Size(227, 20);
            this.txtSourceFilePath.TabIndex = 1;
            this.tooltip1.SetToolTip(this.txtSourceFilePath, "Ruta del archivo Excel a analizar");
            // 
            // lblColumn
            // 
            this.lblColumn.AutoSize = true;
            this.lblColumn.Location = new System.Drawing.Point(73, 50);
            this.lblColumn.Name = "lblColumn";
            this.lblColumn.Size = new System.Drawing.Size(48, 13);
            this.lblColumn.TabIndex = 2;
            this.lblColumn.Text = "Columna";
            this.lblColumn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtColumn
            // 
            this.txtColumn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtColumn.Location = new System.Drawing.Point(128, 48);
            this.txtColumn.MaxLength = 3;
            this.txtColumn.Name = "txtColumn";
            this.txtColumn.Size = new System.Drawing.Size(72, 20);
            this.txtColumn.TabIndex = 3;
            this.txtColumn.Text = "A";
            this.txtColumn.Enter += new System.EventHandler(this.txtColumn_Enter);
            // 
            // lblStartRow
            // 
            this.lblStartRow.AutoSize = true;
            this.lblStartRow.Location = new System.Drawing.Point(68, 75);
            this.lblStartRow.Name = "lblStartRow";
            this.lblStartRow.Size = new System.Drawing.Size(53, 13);
            this.lblStartRow.TabIndex = 4;
            this.lblStartRow.Text = "Fila Inicial";
            this.lblStartRow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numStartRow
            // 
            this.numStartRow.Location = new System.Drawing.Point(127, 73);
            this.numStartRow.Maximum = new decimal(new int[] {
            1048576,
            0,
            0,
            0});
            this.numStartRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numStartRow.Name = "numStartRow";
            this.numStartRow.Size = new System.Drawing.Size(72, 20);
            this.numStartRow.TabIndex = 5;
            this.numStartRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numStartRow.Enter += new System.EventHandler(this.numStartRow_Enter);
            // 
            // numEndRow
            // 
            this.numEndRow.Location = new System.Drawing.Point(127, 99);
            this.numEndRow.Maximum = new decimal(new int[] {
            1048576,
            0,
            0,
            0});
            this.numEndRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEndRow.Name = "numEndRow";
            this.numEndRow.Size = new System.Drawing.Size(72, 20);
            this.numEndRow.TabIndex = 7;
            this.numEndRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEndRow.Enter += new System.EventHandler(this.numEndRow_Enter);
            // 
            // lblEndRow
            // 
            this.lblEndRow.AutoSize = true;
            this.lblEndRow.Location = new System.Drawing.Point(68, 101);
            this.lblEndRow.Name = "lblEndRow";
            this.lblEndRow.Size = new System.Drawing.Size(48, 13);
            this.lblEndRow.TabIndex = 6;
            this.lblEndRow.Text = "Fila Final";
            this.lblEndRow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fbdSelectDestination
            // 
            this.fbdSelectDestination.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            // 
            // btnDestinationFolder
            // 
            this.btnDestinationFolder.Location = new System.Drawing.Point(6, 125);
            this.btnDestinationFolder.Name = "btnDestinationFolder";
            this.btnDestinationFolder.Size = new System.Drawing.Size(115, 23);
            this.btnDestinationFolder.TabIndex = 8;
            this.btnDestinationFolder.Text = "Ruta destino";
            this.tooltip1.SetToolTip(this.btnDestinationFolder, "Haga click para buscar una carpeta destino");
            this.btnDestinationFolder.UseVisualStyleBackColor = true;
            this.btnDestinationFolder.Click += new System.EventHandler(this.btnDestinationFolder_Click);
            // 
            // txtFolderDestination
            // 
            this.txtFolderDestination.Location = new System.Drawing.Point(127, 127);
            this.txtFolderDestination.Name = "txtFolderDestination";
            this.txtFolderDestination.ReadOnly = true;
            this.txtFolderDestination.Size = new System.Drawing.Size(227, 20);
            this.txtFolderDestination.TabIndex = 9;
            this.tooltip1.SetToolTip(this.txtFolderDestination, "Dentro de esta carpeta se crearán las sub-carpetas");
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(18, 177);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(150, 30);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generar Carpetas";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtResults);
            this.groupBox2.Location = new System.Drawing.Point(12, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 136);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado:";
            // 
            // txtResults
            // 
            this.txtResults.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResults.ForeColor = System.Drawing.Color.Lime;
            this.txtResults.Location = new System.Drawing.Point(6, 19);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.Size = new System.Drawing.Size(348, 111);
            this.txtResults.TabIndex = 0;
            this.txtResults.Text = "test";
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(175, 184);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(90, 23);
            this.btnClean.TabIndex = 3;
            this.btnClean.Text = "Limpiar Pantalla";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extrae nombres a carpetas";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStartRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndRow)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog ofdSelectXls;
        private System.Windows.Forms.Button btnSearchFile;
        private System.Windows.Forms.Label lblColumn;
        private System.Windows.Forms.Label lblStartRow;
        private System.Windows.Forms.Label lblEndRow;
        private System.Windows.Forms.ToolTip tooltip1;
        private System.Windows.Forms.FolderBrowserDialog fbdSelectDestination;
        private System.Windows.Forms.Button btnDestinationFolder;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.TextBox txtSourceFilePath;
        internal System.Windows.Forms.TextBox txtColumn;
        internal System.Windows.Forms.NumericUpDown numStartRow;
        internal System.Windows.Forms.NumericUpDown numEndRow;
        internal System.Windows.Forms.TextBox txtFolderDestination;
        internal System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Button btnClean;
    }
}

