namespace WindowsFormsApplication1
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.Automation_Btn = new System.Windows.Forms.Button();
            this.NewIssue_Btn = new System.Windows.Forms.Button();
            this.Attendant_Btn = new System.Windows.Forms.Button();
            this.InsertNewDetail_btn = new System.Windows.Forms.Button();
            this.EquipmentField_btn = new System.Windows.Forms.Button();
            this.SelectFromList_btn = new System.Windows.Forms.Button();
            this.UpdatePartField_btn = new System.Windows.Forms.Button();
            this.SelectPart_Btn = new System.Windows.Forms.Button();
            this.DateQty_btn = new System.Windows.Forms.Button();
            this.GetPrice_btn = new System.Windows.Forms.Button();
            this.InsertIssue_btn = new System.Windows.Forms.Button();
            this.Status_lbl = new System.Windows.Forms.Label();
            this.Finish_btn = new System.Windows.Forms.Button();
            this.PendingList = new System.Windows.Forms.ListBox();
            this.ManualUpdate_lst = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ManualUpdate_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Left;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(864, 735);
            this.webBrowser1.TabIndex = 0;
            // 
            // Automation_Btn
            // 
            this.Automation_Btn.BackColor = System.Drawing.Color.Green;
            this.Automation_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Automation_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Automation_Btn.Location = new System.Drawing.Point(945, 3);
            this.Automation_Btn.Name = "Automation_Btn";
            this.Automation_Btn.Size = new System.Drawing.Size(177, 70);
            this.Automation_Btn.TabIndex = 4;
            this.Automation_Btn.Text = "Start Automation";
            this.Automation_Btn.UseVisualStyleBackColor = false;
            this.Automation_Btn.Click += new System.EventHandler(this.Automation_Btn_Click);
            // 
            // NewIssue_Btn
            // 
            this.NewIssue_Btn.Location = new System.Drawing.Point(1142, 158);
            this.NewIssue_Btn.Name = "NewIssue_Btn";
            this.NewIssue_Btn.Size = new System.Drawing.Size(10, 24);
            this.NewIssue_Btn.TabIndex = 6;
            this.NewIssue_Btn.Text = "Click On  Insert New Issue";
            this.NewIssue_Btn.UseVisualStyleBackColor = true;
            this.NewIssue_Btn.Click += new System.EventHandler(this.NewIssue_Btn_Click);
            // 
            // Attendant_Btn
            // 
            this.Attendant_Btn.Location = new System.Drawing.Point(1142, 188);
            this.Attendant_Btn.Name = "Attendant_Btn";
            this.Attendant_Btn.Size = new System.Drawing.Size(10, 24);
            this.Attendant_Btn.TabIndex = 7;
            this.Attendant_Btn.Text = "Update Attendant\'s Info";
            this.Attendant_Btn.UseVisualStyleBackColor = true;
            this.Attendant_Btn.Click += new System.EventHandler(this.Attendant_Btn_Click);
            // 
            // InsertNewDetail_btn
            // 
            this.InsertNewDetail_btn.Location = new System.Drawing.Point(1142, 218);
            this.InsertNewDetail_btn.Name = "InsertNewDetail_btn";
            this.InsertNewDetail_btn.Size = new System.Drawing.Size(10, 24);
            this.InsertNewDetail_btn.TabIndex = 8;
            this.InsertNewDetail_btn.Text = "Click on Insert New Detail";
            this.InsertNewDetail_btn.UseVisualStyleBackColor = true;
            this.InsertNewDetail_btn.Click += new System.EventHandler(this.InsertNewDetail_btn_Click);
            // 
            // EquipmentField_btn
            // 
            this.EquipmentField_btn.Location = new System.Drawing.Point(1142, 310);
            this.EquipmentField_btn.Name = "EquipmentField_btn";
            this.EquipmentField_btn.Size = new System.Drawing.Size(10, 24);
            this.EquipmentField_btn.TabIndex = 9;
            this.EquipmentField_btn.Text = "Update Equipment Field";
            this.EquipmentField_btn.UseVisualStyleBackColor = true;
            this.EquipmentField_btn.Click += new System.EventHandler(this.EquipmentField_btn_Click);
            // 
            // SelectFromList_btn
            // 
            this.SelectFromList_btn.Location = new System.Drawing.Point(1142, 339);
            this.SelectFromList_btn.Name = "SelectFromList_btn";
            this.SelectFromList_btn.Size = new System.Drawing.Size(10, 24);
            this.SelectFromList_btn.TabIndex = 10;
            this.SelectFromList_btn.Text = "Select Item From List";
            this.SelectFromList_btn.UseVisualStyleBackColor = true;
            this.SelectFromList_btn.Click += new System.EventHandler(this.SelectFromList_btn_Click);
            // 
            // UpdatePartField_btn
            // 
            this.UpdatePartField_btn.Location = new System.Drawing.Point(1142, 247);
            this.UpdatePartField_btn.Name = "UpdatePartField_btn";
            this.UpdatePartField_btn.Size = new System.Drawing.Size(10, 24);
            this.UpdatePartField_btn.TabIndex = 11;
            this.UpdatePartField_btn.Text = "Update Part Field";
            this.UpdatePartField_btn.UseVisualStyleBackColor = true;
            this.UpdatePartField_btn.Click += new System.EventHandler(this.UpdatePartField_btn_Click);
            // 
            // SelectPart_Btn
            // 
            this.SelectPart_Btn.Location = new System.Drawing.Point(1142, 278);
            this.SelectPart_Btn.Name = "SelectPart_Btn";
            this.SelectPart_Btn.Size = new System.Drawing.Size(10, 24);
            this.SelectPart_Btn.TabIndex = 12;
            this.SelectPart_Btn.Text = "Select Part From List";
            this.SelectPart_Btn.UseVisualStyleBackColor = true;
            this.SelectPart_Btn.Click += new System.EventHandler(this.SelectPart_Btn_Click);
            // 
            // DateQty_btn
            // 
            this.DateQty_btn.Location = new System.Drawing.Point(1142, 369);
            this.DateQty_btn.Name = "DateQty_btn";
            this.DateQty_btn.Size = new System.Drawing.Size(10, 24);
            this.DateQty_btn.TabIndex = 13;
            this.DateQty_btn.Text = "Update Date and Qty";
            this.DateQty_btn.UseVisualStyleBackColor = true;
            this.DateQty_btn.Click += new System.EventHandler(this.DateQty_btn_Click);
            // 
            // GetPrice_btn
            // 
            this.GetPrice_btn.Location = new System.Drawing.Point(1142, 398);
            this.GetPrice_btn.Name = "GetPrice_btn";
            this.GetPrice_btn.Size = new System.Drawing.Size(10, 24);
            this.GetPrice_btn.TabIndex = 14;
            this.GetPrice_btn.Text = "Push GetPrice Button";
            this.GetPrice_btn.UseVisualStyleBackColor = true;
            this.GetPrice_btn.Click += new System.EventHandler(this.GetPrice_btn_Click);
            // 
            // InsertIssue_btn
            // 
            this.InsertIssue_btn.Location = new System.Drawing.Point(1142, 428);
            this.InsertIssue_btn.Name = "InsertIssue_btn";
            this.InsertIssue_btn.Size = new System.Drawing.Size(10, 24);
            this.InsertIssue_btn.TabIndex = 15;
            this.InsertIssue_btn.Text = "Click Insert Button";
            this.InsertIssue_btn.UseVisualStyleBackColor = true;
            this.InsertIssue_btn.Click += new System.EventHandler(this.InsertIssue_btn_Click);
            // 
            // Status_lbl
            // 
            this.Status_lbl.AutoSize = true;
            this.Status_lbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status_lbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Status_lbl.Location = new System.Drawing.Point(940, 76);
            this.Status_lbl.Name = "Status_lbl";
            this.Status_lbl.Size = new System.Drawing.Size(16, 25);
            this.Status_lbl.TabIndex = 16;
            this.Status_lbl.Text = ".";
            // 
            // Finish_btn
            // 
            this.Finish_btn.Location = new System.Drawing.Point(1143, 465);
            this.Finish_btn.Name = "Finish_btn";
            this.Finish_btn.Size = new System.Drawing.Size(10, 24);
            this.Finish_btn.TabIndex = 17;
            this.Finish_btn.Text = "Finish Transaction";
            this.Finish_btn.UseVisualStyleBackColor = true;
            this.Finish_btn.Click += new System.EventHandler(this.Finish_btn_Click);
            // 
            // PendingList
            // 
            this.PendingList.FormattingEnabled = true;
            this.PendingList.Location = new System.Drawing.Point(885, 129);
            this.PendingList.MultiColumn = true;
            this.PendingList.Name = "PendingList";
            this.PendingList.Size = new System.Drawing.Size(285, 459);
            this.PendingList.TabIndex = 18;
            // 
            // ManualUpdate_lst
            // 
            this.ManualUpdate_lst.FormattingEnabled = true;
            this.ManualUpdate_lst.Location = new System.Drawing.Point(886, 611);
            this.ManualUpdate_lst.Name = "ManualUpdate_lst";
            this.ManualUpdate_lst.Size = new System.Drawing.Size(284, 95);
            this.ManualUpdate_lst.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1051, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Pending Transactions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1051, 595);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Manual Entry";
            // 
            // ManualUpdate_btn
            // 
            this.ManualUpdate_btn.Location = new System.Drawing.Point(1038, 709);
            this.ManualUpdate_btn.Name = "ManualUpdate_btn";
            this.ManualUpdate_btn.Size = new System.Drawing.Size(132, 23);
            this.ManualUpdate_btn.TabIndex = 21;
            this.ManualUpdate_btn.Text = "Updated";
            this.ManualUpdate_btn.UseVisualStyleBackColor = true;
            this.ManualUpdate_btn.Click += new System.EventHandler(this.ManualUpdate_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 735);
            this.Controls.Add(this.ManualUpdate_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ManualUpdate_lst);
            this.Controls.Add(this.PendingList);
            this.Controls.Add(this.Finish_btn);
            this.Controls.Add(this.Status_lbl);
            this.Controls.Add(this.InsertIssue_btn);
            this.Controls.Add(this.GetPrice_btn);
            this.Controls.Add(this.DateQty_btn);
            this.Controls.Add(this.SelectPart_Btn);
            this.Controls.Add(this.UpdatePartField_btn);
            this.Controls.Add(this.SelectFromList_btn);
            this.Controls.Add(this.EquipmentField_btn);
            this.Controls.Add(this.InsertNewDetail_btn);
            this.Controls.Add(this.Attendant_Btn);
            this.Controls.Add(this.NewIssue_Btn);
            this.Controls.Add(this.Automation_Btn);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button Automation_Btn;
        private System.Windows.Forms.Button NewIssue_Btn;
        private System.Windows.Forms.Button Attendant_Btn;
        private System.Windows.Forms.Button InsertNewDetail_btn;
        private System.Windows.Forms.Button EquipmentField_btn;
        private System.Windows.Forms.Button SelectFromList_btn;
        private System.Windows.Forms.Button UpdatePartField_btn;
        private System.Windows.Forms.Button SelectPart_Btn;
        private System.Windows.Forms.Button DateQty_btn;
        private System.Windows.Forms.Button GetPrice_btn;
        private System.Windows.Forms.Button InsertIssue_btn;
        private System.Windows.Forms.Label Status_lbl;
        private System.Windows.Forms.Button Finish_btn;
        private System.Windows.Forms.ListBox PendingList;
        private System.Windows.Forms.ListBox ManualUpdate_lst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ManualUpdate_btn;
    }
}

