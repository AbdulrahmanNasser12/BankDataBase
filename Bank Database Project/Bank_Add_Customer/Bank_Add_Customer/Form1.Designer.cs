
namespace Bank_Add_Customer
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
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sSNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTREETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dISTRICTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankDataSet = new Bank_Add_Customer.BankDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cUSTOMERTableAdapter = new Bank_Add_Customer.BankDataSetTableAdapters.CUSTOMERTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.aCCOUNTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aCCOUNTTableAdapter = new Bank_Add_Customer.BankDataSetTableAdapters.ACCOUNTTableAdapter();
            this.aNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSNDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOANTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bALANCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(733, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "Show Customers";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sSNDataGridViewTextBoxColumn,
            this.bNUMDataGridViewTextBoxColumn,
            this.fNAMEDataGridViewTextBoxColumn,
            this.lNAMEDataGridViewTextBoxColumn,
            this.cITYDataGridViewTextBoxColumn,
            this.sTREETDataGridViewTextBoxColumn,
            this.dISTRICTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cUSTOMERBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(733, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(926, 193);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sSNDataGridViewTextBoxColumn
            // 
            this.sSNDataGridViewTextBoxColumn.DataPropertyName = "SSN";
            this.sSNDataGridViewTextBoxColumn.HeaderText = "SSN";
            this.sSNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sSNDataGridViewTextBoxColumn.Name = "sSNDataGridViewTextBoxColumn";
            this.sSNDataGridViewTextBoxColumn.Width = 125;
            // 
            // bNUMDataGridViewTextBoxColumn
            // 
            this.bNUMDataGridViewTextBoxColumn.DataPropertyName = "BNUM";
            this.bNUMDataGridViewTextBoxColumn.HeaderText = "BNUM";
            this.bNUMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bNUMDataGridViewTextBoxColumn.Name = "bNUMDataGridViewTextBoxColumn";
            this.bNUMDataGridViewTextBoxColumn.Width = 125;
            // 
            // fNAMEDataGridViewTextBoxColumn
            // 
            this.fNAMEDataGridViewTextBoxColumn.DataPropertyName = "FNAME";
            this.fNAMEDataGridViewTextBoxColumn.HeaderText = "FNAME";
            this.fNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fNAMEDataGridViewTextBoxColumn.Name = "fNAMEDataGridViewTextBoxColumn";
            this.fNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // lNAMEDataGridViewTextBoxColumn
            // 
            this.lNAMEDataGridViewTextBoxColumn.DataPropertyName = "LNAME";
            this.lNAMEDataGridViewTextBoxColumn.HeaderText = "LNAME";
            this.lNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lNAMEDataGridViewTextBoxColumn.Name = "lNAMEDataGridViewTextBoxColumn";
            this.lNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // cITYDataGridViewTextBoxColumn
            // 
            this.cITYDataGridViewTextBoxColumn.DataPropertyName = "CITY";
            this.cITYDataGridViewTextBoxColumn.HeaderText = "CITY";
            this.cITYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cITYDataGridViewTextBoxColumn.Name = "cITYDataGridViewTextBoxColumn";
            this.cITYDataGridViewTextBoxColumn.Width = 125;
            // 
            // sTREETDataGridViewTextBoxColumn
            // 
            this.sTREETDataGridViewTextBoxColumn.DataPropertyName = "STREET";
            this.sTREETDataGridViewTextBoxColumn.HeaderText = "STREET";
            this.sTREETDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTREETDataGridViewTextBoxColumn.Name = "sTREETDataGridViewTextBoxColumn";
            this.sTREETDataGridViewTextBoxColumn.Width = 125;
            // 
            // dISTRICTDataGridViewTextBoxColumn
            // 
            this.dISTRICTDataGridViewTextBoxColumn.DataPropertyName = "DISTRICT";
            this.dISTRICTDataGridViewTextBoxColumn.HeaderText = "DISTRICT";
            this.dISTRICTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dISTRICTDataGridViewTextBoxColumn.Name = "dISTRICTDataGridViewTextBoxColumn";
            this.dISTRICTDataGridViewTextBoxColumn.Width = 125;
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.bankDataSet;
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "BankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 37);
            this.button1.TabIndex = 32;
            this.button1.Text = "Add Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(117, 363);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(209, 22);
            this.textBox7.TabIndex = 31;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(117, 304);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(209, 22);
            this.textBox6.TabIndex = 30;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(117, 246);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(209, 22);
            this.textBox5.TabIndex = 29;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(117, 183);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(209, 22);
            this.textBox4.TabIndex = 28;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(117, 129);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(209, 22);
            this.textBox3.TabIndex = 27;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(117, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 22);
            this.textBox2.TabIndex = 26;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 22);
            this.textBox1.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "District";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Street";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Branch Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "SSN";
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1584, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 35;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(193, 391);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 37);
            this.button4.TabIndex = 36;
            this.button4.Text = "Update Customer";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aNUMDataGridViewTextBoxColumn,
            this.sSNDataGridViewTextBoxColumn1,
            this.lOANTYPEDataGridViewTextBoxColumn,
            this.bALANCEDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.aCCOUNTBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(941, 206);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(550, 192);
            this.dataGridView2.TabIndex = 47;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(941, 405);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 23);
            this.button5.TabIndex = 46;
            this.button5.Text = "Show Account";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(391, 183);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(107, 34);
            this.button6.TabIndex = 45;
            this.button6.Text = "Add Account";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(451, 138);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(209, 22);
            this.textBox9.TabIndex = 43;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(451, 86);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(209, 22);
            this.textBox10.TabIndex = 42;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(451, 32);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(209, 22);
            this.textBox11.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(338, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "Balance";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(338, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 17);
            this.label10.TabIndex = 38;
            this.label10.Text = "Account Type";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(338, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 17);
            this.label11.TabIndex = 37;
            this.label11.Text = "Acount Number";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1406, 405);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(85, 23);
            this.button7.TabIndex = 48;
            this.button7.Text = "Delete";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(539, 183);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(121, 34);
            this.button8.TabIndex = 49;
            this.button8.Text = "Update Account";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // aCCOUNTBindingSource
            // 
            this.aCCOUNTBindingSource.DataMember = "ACCOUNT";
            this.aCCOUNTBindingSource.DataSource = this.bankDataSet;
            // 
            // aCCOUNTTableAdapter
            // 
            this.aCCOUNTTableAdapter.ClearBeforeFill = true;
            // 
            // aNUMDataGridViewTextBoxColumn
            // 
            this.aNUMDataGridViewTextBoxColumn.DataPropertyName = "ANUM";
            this.aNUMDataGridViewTextBoxColumn.HeaderText = "ANUM";
            this.aNUMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aNUMDataGridViewTextBoxColumn.Name = "aNUMDataGridViewTextBoxColumn";
            this.aNUMDataGridViewTextBoxColumn.Width = 125;
            // 
            // sSNDataGridViewTextBoxColumn1
            // 
            this.sSNDataGridViewTextBoxColumn1.DataPropertyName = "SSN";
            this.sSNDataGridViewTextBoxColumn1.HeaderText = "SSN";
            this.sSNDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.sSNDataGridViewTextBoxColumn1.Name = "sSNDataGridViewTextBoxColumn1";
            this.sSNDataGridViewTextBoxColumn1.Width = 125;
            // 
            // lOANTYPEDataGridViewTextBoxColumn
            // 
            this.lOANTYPEDataGridViewTextBoxColumn.DataPropertyName = "LOAN_TYPE";
            this.lOANTYPEDataGridViewTextBoxColumn.HeaderText = "LOAN_TYPE";
            this.lOANTYPEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lOANTYPEDataGridViewTextBoxColumn.Name = "lOANTYPEDataGridViewTextBoxColumn";
            this.lOANTYPEDataGridViewTextBoxColumn.Width = 125;
            // 
            // bALANCEDataGridViewTextBoxColumn
            // 
            this.bALANCEDataGridViewTextBoxColumn.DataPropertyName = "BALANCE";
            this.bALANCEDataGridViewTextBoxColumn.HeaderText = "BALANCE";
            this.bALANCEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bALANCEDataGridViewTextBoxColumn.Name = "bALANCEDataGridViewTextBoxColumn";
            this.bALANCEDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1793, 450);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private BankDataSet bankDataSet;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private BankDataSetTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTREETDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dISTRICTDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.BindingSource aCCOUNTBindingSource;
        private BankDataSetTableAdapters.ACCOUNTTableAdapter aCCOUNTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSNDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOANTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bALANCEDataGridViewTextBoxColumn;
    }
}

