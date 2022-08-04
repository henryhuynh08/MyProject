namespace MyProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnID = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnTable = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableData = new System.Windows.Forms.DataGridView();
            this.Attribute_No1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attribute_No2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attribute_No3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attribute_No4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attribute_No5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attribute_No7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attribute_No8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableData)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(367, 84);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 23);
            this.txtID.TabIndex = 0;
            // 
            // btnID
            // 
            this.btnID.Location = new System.Drawing.Point(473, 83);
            this.btnID.Name = "btnID";
            this.btnID.Size = new System.Drawing.Size(75, 23);
            this.btnID.TabIndex = 1;
            this.btnID.Text = "Enter";
            this.btnID.UseVisualStyleBackColor = true;
            this.btnID.Click += new System.EventHandler(this.btnID_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblID.Location = new System.Drawing.Point(404, 120);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(46, 21);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "0000";
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn1.Location = new System.Drawing.Point(241, 165);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(110, 23);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "Empty";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(357, 165);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(110, 23);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "Empty";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(473, 165);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(110, 23);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "Empty";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(589, 165);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(110, 23);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "Empty";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(241, 194);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(110, 23);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "Empty";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(357, 194);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(110, 23);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "Empty";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(473, 194);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(110, 23);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "Empty";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(589, 194);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(110, 23);
            this.btn8.TabIndex = 10;
            this.btn8.Text = "Empty";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(429, 247);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnTable
            // 
            this.btnTable.Location = new System.Drawing.Point(404, 296);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(141, 23);
            this.btnTable.TabIndex = 12;
            this.btnTable.Text = "Show/Hide the List";
            this.btnTable.UseVisualStyleBackColor = true;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(580, 296);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(291, 296);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 14;
            this.btnImport.Text = "Import CSV";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(MyProject.Form1);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // tableData
            // 
            this.tableData.AllowUserToAddRows = false;
            this.tableData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Attribute_No1,
            this.Attribute_No2,
            this.Attribute_No3,
            this.Attribute_No4,
            this.Attribute_No5,
            this.Attribute_No7,
            this.Attribute_No8});
            this.tableData.Location = new System.Drawing.Point(36, 355);
            this.tableData.Name = "tableData";
            this.tableData.ReadOnly = true;
            this.tableData.RowTemplate.Height = 25;
            this.tableData.Size = new System.Drawing.Size(848, 275);
            this.tableData.TabIndex = 15;
            // 
            // Attribute_No1
            // 
            this.Attribute_No1.HeaderText = "Attribute_No1";
            this.Attribute_No1.Name = "Attribute_No1";
            this.Attribute_No1.ReadOnly = true;
            // 
            // Attribute_No2
            // 
            this.Attribute_No2.HeaderText = "Attribute_No2";
            this.Attribute_No2.Name = "Attribute_No2";
            this.Attribute_No2.ReadOnly = true;
            // 
            // Attribute_No3
            // 
            this.Attribute_No3.HeaderText = "Attribute_No3";
            this.Attribute_No3.Name = "Attribute_No3";
            this.Attribute_No3.ReadOnly = true;
            // 
            // Attribute_No4
            // 
            this.Attribute_No4.HeaderText = "Attribute_No4";
            this.Attribute_No4.Name = "Attribute_No4";
            this.Attribute_No4.ReadOnly = true;
            // 
            // Attribute_No5
            // 
            this.Attribute_No5.HeaderText = "Attribute_No6";
            this.Attribute_No5.Name = "Attribute_No5";
            this.Attribute_No5.ReadOnly = true;
            // 
            // Attribute_No7
            // 
            this.Attribute_No7.HeaderText = "Attribute_No7";
            this.Attribute_No7.Name = "Attribute_No7";
            this.Attribute_No7.ReadOnly = true;
            // 
            // Attribute_No8
            // 
            this.Attribute_No8.HeaderText = "Attribute_No8";
            this.Attribute_No8.Name = "Attribute_No8";
            this.Attribute_No8.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(367, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 686);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableData);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTable);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnID);
            this.Controls.Add(this.txtID);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtID;
        private Button btnID;
        private Label lblID;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btnSave;
        private Button btnTable;
        private Button btnExit;
        private Button btnImport;
        private BindingSource form1BindingSource;
        private DataGridViewTextBoxColumn ID;
        private DataGridView tableData;
        private DataGridViewTextBoxColumn Attribute_No1;
        private DataGridViewTextBoxColumn Attribute_No2;
        private DataGridViewTextBoxColumn Attribute_No3;
        private DataGridViewTextBoxColumn Attribute_No4;
        private DataGridViewTextBoxColumn Attribute_No5;
        private DataGridViewTextBoxColumn Attribute_No7;
        private DataGridViewTextBoxColumn Attribute_No8;
        private Label label1;
    }
}