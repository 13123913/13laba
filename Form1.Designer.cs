
namespace WindowsFormsApp9
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("C#");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("VB.NET");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("JAVA");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("PHP");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("JavaScript");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Lang", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("SQLSERVER");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("MYSQL");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("ORACLE");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("DB", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Root", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode10});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.Desktop;
            this.treeView1.Font = new System.Drawing.Font("Rubik", 14.25F);
            this.treeView1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.treeView1.Location = new System.Drawing.Point(22, 76);
            this.treeView1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Узел3";
            treeNode1.Text = "C#";
            treeNode2.Name = "Узел5";
            treeNode2.Text = "VB.NET";
            treeNode3.Name = "Узел6";
            treeNode3.Text = "JAVA";
            treeNode4.Name = "Узел7";
            treeNode4.Text = "PHP";
            treeNode5.Name = "Узел8";
            treeNode5.Text = "JavaScript";
            treeNode6.Name = "Узел1";
            treeNode6.Text = "Lang";
            treeNode7.Name = "Узел10";
            treeNode7.Text = "SQLSERVER";
            treeNode8.Name = "Узел11";
            treeNode8.Text = "MYSQL";
            treeNode9.Name = "Узел12";
            treeNode9.Text = "ORACLE";
            treeNode10.Name = "Узел9";
            treeNode10.Text = "DB";
            treeNode11.Name = "Узел0";
            treeNode11.Text = "Root";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11});
            this.treeView1.Size = new System.Drawing.Size(452, 386);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(22, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(456, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Delete Node";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.WindowText;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Rubik", 14.25F);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(22, 472);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(456, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Задание 2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(505, 557);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Font = new System.Drawing.Font("OpenSymbol", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button2;
        protected System.Windows.Forms.Button button1;
    }
}

