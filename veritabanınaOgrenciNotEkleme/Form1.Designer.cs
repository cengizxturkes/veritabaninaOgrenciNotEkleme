namespace veritabanınaOgrenciNotEkleme
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwExamResult = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TbxExamResult = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxNumber = new System.Windows.Forms.TextBox();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.TbxExamResultUpdate = new System.Windows.Forms.TextBox();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.tbxNumberUpdate = new System.Windows.Forms.TextBox();
            this.lblNumberUpdate = new System.Windows.Forms.Label();
            this.lblExamResultUpdate = new System.Windows.Forms.Label();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwExamResult)).BeginInit();
            this.gbxAdd.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwExamResult
            // 
            this.dgwExamResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwExamResult.Location = new System.Drawing.Point(12, 28);
            this.dgwExamResult.Name = "dgwExamResult";
            this.dgwExamResult.Size = new System.Drawing.Size(458, 150);
            this.dgwExamResult.TabIndex = 0;
            this.dgwExamResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwExamResult_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Exam Result";
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.button1);
            this.gbxAdd.Controls.Add(this.TbxExamResult);
            this.gbxAdd.Controls.Add(this.tbxName);
            this.gbxAdd.Controls.Add(this.tbxNumber);
            this.gbxAdd.Controls.Add(this.label1);
            this.gbxAdd.Controls.Add(this.label3);
            this.gbxAdd.Controls.Add(this.label2);
            this.gbxAdd.Location = new System.Drawing.Point(12, 184);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(215, 234);
            this.gbxAdd.TabIndex = 4;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add a Student";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TbxExamResult
            // 
            this.TbxExamResult.Location = new System.Drawing.Point(73, 129);
            this.TbxExamResult.Name = "TbxExamResult";
            this.TbxExamResult.Size = new System.Drawing.Size(126, 20);
            this.TbxExamResult.TabIndex = 6;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(73, 92);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(126, 20);
            this.tbxName.TabIndex = 5;
            // 
            // tbxNumber
            // 
            this.tbxNumber.Location = new System.Drawing.Point(73, 51);
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.Size = new System.Drawing.Size(126, 20);
            this.tbxNumber.TabIndex = 4;
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.TbxExamResultUpdate);
            this.gbxUpdate.Controls.Add(this.tbxNameUpdate);
            this.gbxUpdate.Controls.Add(this.tbxNumberUpdate);
            this.gbxUpdate.Controls.Add(this.lblNumberUpdate);
            this.gbxUpdate.Controls.Add(this.lblExamResultUpdate);
            this.gbxUpdate.Controls.Add(this.lblNameUpdate);
            this.gbxUpdate.Location = new System.Drawing.Point(258, 184);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(200, 234);
            this.gbxUpdate.TabIndex = 7;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update a Student";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(41, 181);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(126, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // TbxExamResultUpdate
            // 
            this.TbxExamResultUpdate.Location = new System.Drawing.Point(73, 129);
            this.TbxExamResultUpdate.Name = "TbxExamResultUpdate";
            this.TbxExamResultUpdate.Size = new System.Drawing.Size(111, 20);
            this.TbxExamResultUpdate.TabIndex = 6;
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.Location = new System.Drawing.Point(73, 92);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(111, 20);
            this.tbxNameUpdate.TabIndex = 5;
            // 
            // tbxNumberUpdate
            // 
            this.tbxNumberUpdate.Location = new System.Drawing.Point(73, 51);
            this.tbxNumberUpdate.Name = "tbxNumberUpdate";
            this.tbxNumberUpdate.Size = new System.Drawing.Size(111, 20);
            this.tbxNumberUpdate.TabIndex = 4;
            // 
            // lblNumberUpdate
            // 
            this.lblNumberUpdate.AutoSize = true;
            this.lblNumberUpdate.Location = new System.Drawing.Point(6, 54);
            this.lblNumberUpdate.Name = "lblNumberUpdate";
            this.lblNumberUpdate.Size = new System.Drawing.Size(44, 13);
            this.lblNumberUpdate.TabIndex = 1;
            this.lblNumberUpdate.Text = "Number";
            // 
            // lblExamResultUpdate
            // 
            this.lblExamResultUpdate.AutoSize = true;
            this.lblExamResultUpdate.Location = new System.Drawing.Point(6, 132);
            this.lblExamResultUpdate.Name = "lblExamResultUpdate";
            this.lblExamResultUpdate.Size = new System.Drawing.Size(66, 13);
            this.lblExamResultUpdate.TabIndex = 3;
            this.lblExamResultUpdate.Text = "Exam Result";
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Location = new System.Drawing.Point(6, 92);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(35, 13);
            this.lblNameUpdate.TabIndex = 2;
            this.lblNameUpdate.Text = "Name";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.LightCoral;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Location = new System.Drawing.Point(181, 424);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(127, 23);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Delete";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 450);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwExamResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwExamResult)).EndInit();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwExamResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.TextBox TbxExamResult;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox TbxExamResultUpdate;
        private System.Windows.Forms.TextBox tbxNameUpdate;
        private System.Windows.Forms.TextBox tbxNumberUpdate;
        private System.Windows.Forms.Label lblNumberUpdate;
        private System.Windows.Forms.Label lblExamResultUpdate;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.Button btnRemove;
    }
}

