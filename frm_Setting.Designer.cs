namespace Stock_Taking_Tool
{
    partial class frm_Setting
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_Save_Connection = new System.Windows.Forms.Button();
            this.txt_Databese = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Test_Connection = new System.Windows.Forms.Button();
            this.txt_Servername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Unit_No = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_Machine_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Cheack_MachineID = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 310);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(919, 305);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_Save_Connection);
            this.tabPage1.Controls.Add(this.txt_Databese);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btn_Test_Connection);
            this.tabPage1.Controls.Add(this.txt_Servername);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(911, 276);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main DB Setting";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_Save_Connection
            // 
            this.btn_Save_Connection.Location = new System.Drawing.Point(462, 153);
            this.btn_Save_Connection.Name = "btn_Save_Connection";
            this.btn_Save_Connection.Size = new System.Drawing.Size(134, 44);
            this.btn_Save_Connection.TabIndex = 9;
            this.btn_Save_Connection.Text = "Save Connection";
            this.btn_Save_Connection.UseVisualStyleBackColor = true;
            this.btn_Save_Connection.Click += new System.EventHandler(this.btn_Save_Connection_Click);
            // 
            // txt_Databese
            // 
            this.txt_Databese.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Databese.Location = new System.Drawing.Point(189, 99);
            this.txt_Databese.Name = "txt_Databese";
            this.txt_Databese.Size = new System.Drawing.Size(589, 30);
            this.txt_Databese.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Database :";
            // 
            // btn_Test_Connection
            // 
            this.btn_Test_Connection.Location = new System.Drawing.Point(304, 153);
            this.btn_Test_Connection.Name = "btn_Test_Connection";
            this.btn_Test_Connection.Size = new System.Drawing.Size(134, 44);
            this.btn_Test_Connection.TabIndex = 2;
            this.btn_Test_Connection.Text = "Test Connection";
            this.btn_Test_Connection.UseVisualStyleBackColor = true;
            this.btn_Test_Connection.Click += new System.EventHandler(this.btn_Test_Connection_Click);
            // 
            // txt_Servername
            // 
            this.txt_Servername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Servername.Location = new System.Drawing.Point(189, 37);
            this.txt_Servername.Name = "txt_Servername";
            this.txt_Servername.Size = new System.Drawing.Size(589, 30);
            this.txt_Servername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Name :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_Cheack_MachineID);
            this.tabPage2.Controls.Add(this.txt_Machine_id);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btn_Save);
            this.tabPage2.Controls.Add(this.txt_Unit_No);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(911, 276);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Unit Details Setting";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Unit No :";
            // 
            // txt_Unit_No
            // 
            this.txt_Unit_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Unit_No.Location = new System.Drawing.Point(217, 29);
            this.txt_Unit_No.Name = "txt_Unit_No";
            this.txt_Unit_No.Size = new System.Drawing.Size(545, 30);
            this.txt_Unit_No.TabIndex = 1;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(217, 151);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(81, 41);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_Machine_id
            // 
            this.txt_Machine_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Machine_id.Location = new System.Drawing.Point(217, 79);
            this.txt_Machine_id.Name = "txt_Machine_id";
            this.txt_Machine_id.Size = new System.Drawing.Size(545, 30);
            this.txt_Machine_id.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Machine Id :";
            // 
            // btn_Cheack_MachineID
            // 
            this.btn_Cheack_MachineID.Location = new System.Drawing.Point(768, 82);
            this.btn_Cheack_MachineID.Name = "btn_Cheack_MachineID";
            this.btn_Cheack_MachineID.Size = new System.Drawing.Size(136, 30);
            this.btn_Cheack_MachineID.TabIndex = 5;
            this.btn_Cheack_MachineID.Text = "Cheack Machine Id";
            this.btn_Cheack_MachineID.UseVisualStyleBackColor = true;
            this.btn_Cheack_MachineID.Click += new System.EventHandler(this.btn_Cheack_MachineID_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(911, 276);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Local Database Setting";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // frm_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 366);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Setting";
            this.Text = "frm_Setting";
            this.Load += new System.EventHandler(this.frm_Setting_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_Databese;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Test_Connection;
        private System.Windows.Forms.TextBox txt_Servername;
        private System.Windows.Forms.Button btn_Save_Connection;
        private System.Windows.Forms.TextBox txt_Machine_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_Unit_No;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Cheack_MachineID;
        private System.Windows.Forms.TabPage tabPage3;
    }
}