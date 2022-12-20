
namespace Praktika
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.logPassBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.logPassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.logPassBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.praktikaDataSet26 = new Praktika.PraktikaDataSet26();
            this.logPassBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.logPassTableAdapter3 = new Praktika.PraktikaDataSet26TableAdapters.LogPassTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.logPassBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logPassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logPassBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logPassBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.logPassBindingSource3;
            this.comboBox1.DisplayMember = "Login";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(145, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // logPassBindingSource1
            // 
            this.logPassBindingSource1.DataMember = "LogPass";

            // 
            // logPassBindingSource
            // 
            this.logPassBindingSource.DataMember = "LogPass";

            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // logPassTableAdapter
            // 

            // 
            // praktikaDataSet23
            // 

            // 
            // logPassBindingSource2
            // 
            this.logPassBindingSource2.DataMember = "LogPass";
            // 
            // logPassTableAdapter2
            // 
            // 
            // praktikaDataSet26
            // 
            this.praktikaDataSet26.DataSetName = "PraktikaDataSet26";
            this.praktikaDataSet26.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logPassBindingSource3
            // 
            this.logPassBindingSource3.DataMember = "LogPass";
            this.logPassBindingSource3.DataSource = this.praktikaDataSet26;
            // 
            // logPassTableAdapter3
            // 
            this.logPassTableAdapter3.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 225);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logPassBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logPassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logPassBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logPassBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
       
        private System.Windows.Forms.BindingSource logPassBindingSource;
        
        private System.Windows.Forms.BindingSource logPassBindingSource1;
        
        private System.Windows.Forms.BindingSource logPassBindingSource2;
        
        private PraktikaDataSet26 praktikaDataSet26;
        private System.Windows.Forms.BindingSource logPassBindingSource3;
        private PraktikaDataSet26TableAdapters.LogPassTableAdapter logPassTableAdapter3;
    }
}

