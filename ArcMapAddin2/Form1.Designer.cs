namespace ArcMapAddin2
{
    partial class Form1
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.meteorological_DataDataSet = new ArcMapAddin2.Meteorological_DataDataSet();
            this.meteorologicalDataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meteorological_DataDataSet1 = new ArcMapAddin2.Meteorological_DataDataSet();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.meteorological_DataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meteorologicalDataDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meteorological_DataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // meteorological_DataDataSet
            // 
            this.meteorological_DataDataSet.DataSetName = "Meteorological_DataDataSet";
            this.meteorological_DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // meteorologicalDataDataSetBindingSource
            // 
            this.meteorologicalDataDataSetBindingSource.DataSource = this.meteorological_DataDataSet;
            this.meteorologicalDataDataSetBindingSource.Position = 0;
            // 
            // meteorological_DataDataSet1
            // 
            this.meteorological_DataDataSet1.DataSetName = "Meteorological_DataDataSet";
            this.meteorological_DataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(71, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(314, 239);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 465);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.meteorological_DataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meteorologicalDataDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meteorological_DataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.BindingSource meteorologicalDataDataSetBindingSource;
        private Meteorological_DataDataSet meteorological_DataDataSet;
        private Meteorological_DataDataSet meteorological_DataDataSet1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}