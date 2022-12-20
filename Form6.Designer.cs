
namespace Praktika
{
    partial class Form6
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.категорияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наСкладеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.общаяуммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mP3BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.praktikaDataSet19 = new Praktika.PraktikaDataSet19();
            this.mP3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.praktikaDataSet11 = new Praktika.PraktikaDataSet11();
            this.mP3TableAdapter = new Praktika.PraktikaDataSet11TableAdapters.MP3TableAdapter();
            this.praktikaDataSet13 = new Praktika.PraktikaDataSet13();
            this.button1 = new System.Windows.Forms.Button();
            this.mP3TableAdapter1 = new Praktika.PraktikaDataSet19TableAdapters.MP3TableAdapter();
            this.praktikaDataSet27 = new Praktika.PraktikaDataSet27();
            this.mP3BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mP3TableAdapter2 = new Praktika.PraktikaDataSet27TableAdapters.MP3TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mP3BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mP3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mP3BindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.категорияDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.наСкладеDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.общаяуммаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mP3BindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(2, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(723, 255);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // категорияDataGridViewTextBoxColumn
            // 
            this.категорияDataGridViewTextBoxColumn.DataPropertyName = "Категория";
            this.категорияDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.категорияDataGridViewTextBoxColumn.Name = "категорияDataGridViewTextBoxColumn";
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // наСкладеDataGridViewTextBoxColumn
            // 
            this.наСкладеDataGridViewTextBoxColumn.DataPropertyName = "На_Складе";
            this.наСкладеDataGridViewTextBoxColumn.HeaderText = "На_Складе";
            this.наСкладеDataGridViewTextBoxColumn.Name = "наСкладеDataGridViewTextBoxColumn";
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            // 
            // общаяуммаDataGridViewTextBoxColumn
            // 
            this.общаяуммаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.общаяуммаDataGridViewTextBoxColumn.HeaderText = "Общая сумма";
            this.общаяуммаDataGridViewTextBoxColumn.Name = "общаяуммаDataGridViewTextBoxColumn";
            // 
            // mP3BindingSource1
            // 
            this.mP3BindingSource1.DataMember = "MP3";
            this.mP3BindingSource1.DataSource = this.praktikaDataSet19;
            // 
            // praktikaDataSet19
            // 
            this.praktikaDataSet19.DataSetName = "PraktikaDataSet19";
            this.praktikaDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mP3BindingSource
            // 
            this.mP3BindingSource.DataMember = "MP3";
            this.mP3BindingSource.DataSource = this.praktikaDataSet11;
            // 
            // praktikaDataSet11
            // 
            this.praktikaDataSet11.DataSetName = "PraktikaDataSet11";
            this.praktikaDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mP3TableAdapter
            // 
            this.mP3TableAdapter.ClearBeforeFill = true;
            // 
            // praktikaDataSet13
            // 
            this.praktikaDataSet13.DataSetName = "PraktikaDataSet13";
            this.praktikaDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(639, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mP3TableAdapter1
            // 
            this.mP3TableAdapter1.ClearBeforeFill = true;
            // 
            // praktikaDataSet27
            // 
            this.praktikaDataSet27.DataSetName = "PraktikaDataSet27";
            this.praktikaDataSet27.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mP3BindingSource2
            // 
            this.mP3BindingSource2.DataMember = "MP3";
            this.mP3BindingSource2.DataSource = this.praktikaDataSet27;
            // 
            // mP3TableAdapter2
            // 
            this.mP3TableAdapter2.ClearBeforeFill = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mP3BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mP3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mP3BindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PraktikaDataSet11 praktikaDataSet11;
        private System.Windows.Forms.BindingSource mP3BindingSource;
        private PraktikaDataSet11TableAdapters.MP3TableAdapter mP3TableAdapter;
        public System.Windows.Forms.DataGridView dataGridView1;
        private PraktikaDataSet13 praktikaDataSet13;
        private System.Windows.Forms.DataGridViewTextBoxColumn категорияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наСкладеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn общаяуммаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private PraktikaDataSet19 praktikaDataSet19;
        private System.Windows.Forms.BindingSource mP3BindingSource1;
        private PraktikaDataSet19TableAdapters.MP3TableAdapter mP3TableAdapter1;
        private PraktikaDataSet27 praktikaDataSet27;
        private System.Windows.Forms.BindingSource mP3BindingSource2;
        private PraktikaDataSet27TableAdapters.MP3TableAdapter mP3TableAdapter2;
    }
}