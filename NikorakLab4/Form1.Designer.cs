namespace NikorakLab4
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
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("CTree");
            this.addToTreeIN = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.isFindStatus = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.isFindIN = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.addToTreeIN.Location = new System.Drawing.Point(982, 40);
            this.addToTreeIN.Name = "textBox1";
            this.addToTreeIN.Size = new System.Drawing.Size(100, 22);
            this.addToTreeIN.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1088, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Додати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addToTreeButton_Click);
            // 
            // label1
            // 
            this.isFindStatus.AutoSize = true;
            this.isFindStatus.Location = new System.Drawing.Point(958, 116);
            this.isFindStatus.Name = "label1";
            this.isFindStatus.Size = new System.Drawing.Size(0, 16);
            this.isFindStatus.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode4.Checked = true;
            treeNode4.Name = "Узел0";
            treeNode4.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode4.Text = "CTree";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(921, 568);
            this.treeView1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1088, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "Провірити";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.isFindButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(952, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 50);
            this.button3.TabIndex = 6;
            this.button3.Text = "Побудувати дерево";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buildTreeButton_Click);
            // 
            // comboBox1
            // 
            this.isFindIN.FormattingEnabled = true;
            this.isFindIN.Location = new System.Drawing.Point(961, 80);
            this.isFindIN.Name = "comboBox1";
            this.isFindIN.Size = new System.Drawing.Size(121, 24);
            this.isFindIN.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 592);
            this.Controls.Add(this.isFindIN);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.isFindStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addToTreeIN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addToTreeIN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label isFindStatus;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox isFindIN;
    }
}

