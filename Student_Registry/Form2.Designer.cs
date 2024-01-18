namespace Student_Registry
{
    partial class studentsform
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            panel1 = new Panel();
            label1 = new Label();
            vScrollBar1 = new VScrollBar();
            label2 = new Label();
            panel2 = new Panel();
            studentname = new Label();
            studentgrades = new Label();
            addgrade = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(20, 61);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(768, 377);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel2);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(760, 339);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(760, 339);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(vScrollBar1);
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 515);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 89);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(699, 36);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(39, 316);
            vScrollBar1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 18);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // panel2
            // 
            panel2.Controls.Add(addgrade);
            panel2.Controls.Add(studentgrades);
            panel2.Controls.Add(studentname);
            panel2.Location = new Point(6, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(748, 165);
            panel2.TabIndex = 0;
            // 
            // studentname
            // 
            studentname.AutoSize = true;
            studentname.Location = new Point(36, 31);
            studentname.Name = "studentname";
            studentname.Size = new Size(59, 25);
            studentname.TabIndex = 0;
            studentname.Text = "label3";
            // 
            // studentgrades
            // 
            studentgrades.AutoSize = true;
            studentgrades.Location = new Point(36, 104);
            studentgrades.Name = "studentgrades";
            studentgrades.Size = new Size(59, 25);
            studentgrades.TabIndex = 1;
            studentgrades.Text = "label4";
            // 
            // addgrade
            // 
            addgrade.Location = new Point(567, 31);
            addgrade.Name = "addgrade";
            addgrade.Size = new Size(112, 34);
            addgrade.TabIndex = 2;
            addgrade.Text = "Add Grade";
            addgrade.UseVisualStyleBackColor = true;
            // 
            // studentsform
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(tabControl1);
            Name = "studentsform";
            Text = "Classes and Students";
            Load += studentsform_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private VScrollBar vScrollBar1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Button addgrade;
        private Label studentgrades;
        private Label studentname;
    }
}