namespace WinFormsWsdl
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
            this.button2 = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.queryBtn = new System.Windows.Forms.Button();
            this.lblstatus = new System.Windows.Forms.Label();
            this.dataCallList = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 33);
            this.button2.TabIndex = 0;
            this.button2.Text = "Connect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(109, 68);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(743, 20);
            this.txtQuery.TabIndex = 2;
            this.txtQuery.Text = "select Id, Name, Detailed_Products_vod__c, Entity_Display_Name_vod__c from Call2_" +
    "vod__c limit 100";
            this.txtQuery.TextChanged += new System.EventHandler(this.txtQuery_TextChanged);
            // 
            // queryBtn
            // 
            this.queryBtn.Location = new System.Drawing.Point(12, 61);
            this.queryBtn.Name = "queryBtn";
            this.queryBtn.Size = new System.Drawing.Size(91, 33);
            this.queryBtn.TabIndex = 3;
            this.queryBtn.Text = "Query";
            this.queryBtn.UseVisualStyleBackColor = true;
            this.queryBtn.Click += new System.EventHandler(this.queryBtn_Click);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(16, 388);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(0, 13);
            this.lblstatus.TabIndex = 4;
            // 
            // dataCallList
            // 
            this.dataCallList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.dataCallList.Location = new System.Drawing.Point(12, 109);
            this.dataCallList.Name = "dataCallList";
            this.dataCallList.Size = new System.Drawing.Size(840, 269);
            this.dataCallList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.dataCallList.TabIndex = 5;
            this.dataCallList.UseCompatibleStateImageBehavior = false;
            this.dataCallList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Salesforce ID";
            this.columnHeader4.Width = 131;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Call ID";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Account";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ISA";
            this.columnHeader3.Width = 456;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(767, 384);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(85, 22);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(864, 414);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.dataCallList);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.queryBtn);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox listData;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Button queryBtn;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.ListView dataCallList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

