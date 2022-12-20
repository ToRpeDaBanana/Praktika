
namespace Praktika
{
    partial class Form2
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
            this.состояниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.владелецDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.коментарийDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.praktikaDataSet18 = new Praktika.PraktikaDataSet18();
            this.ticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketsGG = new Praktika.TicketsGG();
            this.ticketsTableAdapter = new Praktika.TicketsGGTableAdapters.TicketsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.ticketsTableAdapter1 = new Praktika.PraktikaDataSet18TableAdapters.TicketsTableAdapter();
            this.praktikaDataSet28 = new Praktika.PraktikaDataSet28();
            this.ticketsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ticketsTableAdapter2 = new Praktika.PraktikaDataSet28TableAdapters.TicketsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsGG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.состояниеDataGridViewTextBoxColumn,
            this.владелецDataGridViewTextBoxColumn,
            this.коментарийDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ticketsBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(483, 171);
            this.dataGridView1.TabIndex = 0;
            // 
            // состояниеDataGridViewTextBoxColumn
            // 
            this.состояниеDataGridViewTextBoxColumn.DataPropertyName = "Состояние";
            this.состояниеDataGridViewTextBoxColumn.HeaderText = "Состояние";
            this.состояниеDataGridViewTextBoxColumn.Name = "состояниеDataGridViewTextBoxColumn";
            // 
            // владелецDataGridViewTextBoxColumn
            // 
            this.владелецDataGridViewTextBoxColumn.DataPropertyName = "Владелец";
            this.владелецDataGridViewTextBoxColumn.HeaderText = "Владелец";
            this.владелецDataGridViewTextBoxColumn.Name = "владелецDataGridViewTextBoxColumn";
            // 
            // коментарийDataGridViewTextBoxColumn
            // 
            this.коментарийDataGridViewTextBoxColumn.DataPropertyName = "Коментарий";
            this.коментарийDataGridViewTextBoxColumn.HeaderText = "Коментарий";
            this.коментарийDataGridViewTextBoxColumn.Name = "коментарийDataGridViewTextBoxColumn";
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            // 
            // ticketsBindingSource1
            // 
            this.ticketsBindingSource1.DataMember = "Tickets";
            this.ticketsBindingSource1.DataSource = this.praktikaDataSet18;
            // 
            // praktikaDataSet18
            // 
            this.praktikaDataSet18.DataSetName = "PraktikaDataSet18";
            this.praktikaDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketsBindingSource
            // 
            this.ticketsBindingSource.DataMember = "Tickets";
            this.ticketsBindingSource.DataSource = this.ticketsGG;
            // 
            // ticketsGG
            // 
            this.ticketsGG.DataSetName = "TicketsGG";
            this.ticketsGG.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketsTableAdapter
            // 
            this.ticketsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ticketsTableAdapter1
            // 
            this.ticketsTableAdapter1.ClearBeforeFill = true;
            // 
            // praktikaDataSet28
            // 
            this.praktikaDataSet28.DataSetName = "PraktikaDataSet28";
            this.praktikaDataSet28.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketsBindingSource2
            // 
            this.ticketsBindingSource2.DataMember = "Tickets";
            this.ticketsBindingSource2.DataSource = this.praktikaDataSet28;
            // 
            // ticketsTableAdapter2
            // 
            this.ticketsTableAdapter2.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 290);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "s";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsGG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TicketsGG ticketsGG;
        private System.Windows.Forms.BindingSource ticketsBindingSource;
        private TicketsGGTableAdapters.TicketsTableAdapter ticketsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn состояниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn владелецDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn коментарийDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private PraktikaDataSet18 praktikaDataSet18;
        private System.Windows.Forms.BindingSource ticketsBindingSource1;
        private PraktikaDataSet18TableAdapters.TicketsTableAdapter ticketsTableAdapter1;
        private PraktikaDataSet28 praktikaDataSet28;
        private System.Windows.Forms.BindingSource ticketsBindingSource2;
        private PraktikaDataSet28TableAdapters.TicketsTableAdapter ticketsTableAdapter2;
    }
}