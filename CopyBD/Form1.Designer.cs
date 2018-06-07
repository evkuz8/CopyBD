namespace CopyBD
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
            this.startBtn = new System.Windows.Forms.Button();
            this.labelUniName = new System.Windows.Forms.Label();
            this.labelUniCopName = new System.Windows.Forms.Label();
            this.labelFROM = new System.Windows.Forms.Label();
            this.labelTO = new System.Windows.Forms.Label();
            this.UniNametxt = new System.Windows.Forms.TextBox();
            this.numericUpDownFROM = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTO = new System.Windows.Forms.NumericUpDown();
            this.UniCopyNametxt = new System.Windows.Forms.TextBox();
            this.labelServerName = new System.Windows.Forms.Label();
            this.ServerNametxt = new System.Windows.Forms.TextBox();
            this.SelectBackupPathbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFROM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTO)).BeginInit();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(262, 99);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(116, 23);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // labelUniName
            // 
            this.labelUniName.AutoSize = true;
            this.labelUniName.Location = new System.Drawing.Point(36, 78);
            this.labelUniName.Name = "labelUniName";
            this.labelUniName.Size = new System.Drawing.Size(89, 13);
            this.labelUniName.TabIndex = 1;
            this.labelUniName.Text = "маска имени бд";
            // 
            // labelUniCopName
            // 
            this.labelUniCopName.AutoSize = true;
            this.labelUniCopName.Location = new System.Drawing.Point(0, 104);
            this.labelUniCopName.Name = "labelUniCopName";
            this.labelUniCopName.Size = new System.Drawing.Size(125, 13);
            this.labelUniCopName.TabIndex = 2;
            this.labelUniCopName.Text = "маска  имени копии бд";
            // 
            // labelFROM
            // 
            this.labelFROM.AutoSize = true;
            this.labelFROM.Location = new System.Drawing.Point(243, 78);
            this.labelFROM.Name = "labelFROM";
            this.labelFROM.Size = new System.Drawing.Size(13, 13);
            this.labelFROM.TabIndex = 3;
            this.labelFROM.Text = "с";
            // 
            // labelTO
            // 
            this.labelTO.AutoSize = true;
            this.labelTO.Location = new System.Drawing.Point(328, 78);
            this.labelTO.Name = "labelTO";
            this.labelTO.Size = new System.Drawing.Size(19, 13);
            this.labelTO.TabIndex = 4;
            this.labelTO.Text = "по";
            // 
            // UniNametxt
            // 
            this.UniNametxt.Location = new System.Drawing.Point(131, 75);
            this.UniNametxt.Name = "UniNametxt";
            this.UniNametxt.Size = new System.Drawing.Size(100, 20);
            this.UniNametxt.TabIndex = 5;
            // 
            // numericUpDownFROM
            // 
            this.numericUpDownFROM.Location = new System.Drawing.Point(262, 76);
            this.numericUpDownFROM.Name = "numericUpDownFROM";
            this.numericUpDownFROM.Size = new System.Drawing.Size(45, 20);
            this.numericUpDownFROM.TabIndex = 6;
            // 
            // numericUpDownTO
            // 
            this.numericUpDownTO.Location = new System.Drawing.Point(353, 76);
            this.numericUpDownTO.Name = "numericUpDownTO";
            this.numericUpDownTO.Size = new System.Drawing.Size(45, 20);
            this.numericUpDownTO.TabIndex = 7;
            // 
            // UniCopyNametxt
            // 
            this.UniCopyNametxt.Location = new System.Drawing.Point(131, 101);
            this.UniCopyNametxt.Name = "UniCopyNametxt";
            this.UniCopyNametxt.Size = new System.Drawing.Size(100, 20);
            this.UniCopyNametxt.TabIndex = 8;
            // 
            // labelServerName
            // 
            this.labelServerName.AutoSize = true;
            this.labelServerName.Location = new System.Drawing.Point(16, 24);
            this.labelServerName.Name = "labelServerName";
            this.labelServerName.Size = new System.Drawing.Size(109, 13);
            this.labelServerName.TabIndex = 9;
            this.labelServerName.Text = "Имя/адрес сервера";
            // 
            // ServerNametxt
            // 
            this.ServerNametxt.Location = new System.Drawing.Point(131, 21);
            this.ServerNametxt.Name = "ServerNametxt";
            this.ServerNametxt.Size = new System.Drawing.Size(100, 20);
            this.ServerNametxt.TabIndex = 10;
            // 
            // SelectBackupPathbtn
            // 
            this.SelectBackupPathbtn.Location = new System.Drawing.Point(12, 132);
            this.SelectBackupPathbtn.Name = "SelectBackupPathbtn";
            this.SelectBackupPathbtn.Size = new System.Drawing.Size(161, 23);
            this.SelectBackupPathbtn.TabIndex = 11;
            this.SelectBackupPathbtn.Text = "Выбрать папку для бекапов";
            this.SelectBackupPathbtn.UseVisualStyleBackColor = true;
            this.SelectBackupPathbtn.Visible = false;
            this.SelectBackupPathbtn.Click += new System.EventHandler(this.SelectBackupPathbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "path:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(44, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Пример маски:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(141, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "DBName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(186, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "*count*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Location = new System.Drawing.Point(226, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Copy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 131);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectBackupPathbtn);
            this.Controls.Add(this.ServerNametxt);
            this.Controls.Add(this.labelServerName);
            this.Controls.Add(this.UniCopyNametxt);
            this.Controls.Add(this.numericUpDownTO);
            this.Controls.Add(this.numericUpDownFROM);
            this.Controls.Add(this.UniNametxt);
            this.Controls.Add(this.labelTO);
            this.Controls.Add(this.labelFROM);
            this.Controls.Add(this.labelUniCopName);
            this.Controls.Add(this.labelUniName);
            this.Controls.Add(this.startBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "dbcopier";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFROM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label labelUniName;
        private System.Windows.Forms.Label labelUniCopName;
        private System.Windows.Forms.Label labelFROM;
        private System.Windows.Forms.Label labelTO;
        private System.Windows.Forms.TextBox UniNametxt;
        private System.Windows.Forms.NumericUpDown numericUpDownFROM;
        private System.Windows.Forms.NumericUpDown numericUpDownTO;
        private System.Windows.Forms.TextBox UniCopyNametxt;
        private System.Windows.Forms.Label labelServerName;
        private System.Windows.Forms.TextBox ServerNametxt;
        private System.Windows.Forms.Button SelectBackupPathbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

