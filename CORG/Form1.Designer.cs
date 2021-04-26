
namespace CORG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.oneStepButton = new System.Windows.Forms.Button();
            this.executeButton = new System.Windows.Forms.Button();
            this.codeBox = new System.Windows.Forms.RichTextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.sRegisterTab = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tRegisterTab = new System.Windows.Forms.TabPage();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.aRegisterTab = new System.Windows.Forms.TabPage();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.vRegisterTab = new System.Windows.Forms.TabPage();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.hiloTab = new System.Windows.Forms.TabPage();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.fRegisterTab = new System.Windows.Forms.TabPage();
            this.listBox7 = new System.Windows.Forms.ListBox();
            this.clearLogButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.stackTab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.memoryTab = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.logTab = new System.Windows.Forms.TabPage();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.sRegisterTab.SuspendLayout();
            this.tRegisterTab.SuspendLayout();
            this.aRegisterTab.SuspendLayout();
            this.vRegisterTab.SuspendLayout();
            this.hiloTab.SuspendLayout();
            this.fRegisterTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.stackTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.memoryTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.logTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // oneStepButton
            // 
            this.oneStepButton.Location = new System.Drawing.Point(52, 27);
            this.oneStepButton.Name = "oneStepButton";
            this.oneStepButton.Size = new System.Drawing.Size(75, 35);
            this.oneStepButton.TabIndex = 1;
            this.oneStepButton.Text = "1-Step";
            this.oneStepButton.UseVisualStyleBackColor = true;
            this.oneStepButton.Click += new System.EventHandler(this.buton1);
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(142, 27);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(75, 35);
            this.executeButton.TabIndex = 6;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // codeBox
            // 
            this.codeBox.AcceptsTab = true;
            this.codeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codeBox.Location = new System.Drawing.Point(41, 76);
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(244, 448);
            this.codeBox.TabIndex = 7;
            this.codeBox.Text = resources.GetString("codeBox.Text");
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.sRegisterTab);
            this.tabControl.Controls.Add(this.tRegisterTab);
            this.tabControl.Controls.Add(this.aRegisterTab);
            this.tabControl.Controls.Add(this.vRegisterTab);
            this.tabControl.Controls.Add(this.hiloTab);
            this.tabControl.Controls.Add(this.fRegisterTab);
            this.tabControl.Location = new System.Drawing.Point(330, 76);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(300, 448);
            this.tabControl.TabIndex = 8;
            // 
            // sRegisterTab
            // 
            this.sRegisterTab.Controls.Add(this.listBox1);
            this.sRegisterTab.Location = new System.Drawing.Point(4, 24);
            this.sRegisterTab.Name = "sRegisterTab";
            this.sRegisterTab.Padding = new System.Windows.Forms.Padding(3);
            this.sRegisterTab.Size = new System.Drawing.Size(292, 420);
            this.sRegisterTab.TabIndex = 0;
            this.sRegisterTab.Text = "S";
            this.sRegisterTab.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Margin = new System.Windows.Forms.Padding(0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(247, 420);
            this.listBox1.TabIndex = 0;
            // 
            // tRegisterTab
            // 
            this.tRegisterTab.Controls.Add(this.listBox2);
            this.tRegisterTab.Location = new System.Drawing.Point(4, 24);
            this.tRegisterTab.Name = "tRegisterTab";
            this.tRegisterTab.Padding = new System.Windows.Forms.Padding(3);
            this.tRegisterTab.Size = new System.Drawing.Size(292, 420);
            this.tRegisterTab.TabIndex = 1;
            this.tRegisterTab.Text = "T";
            this.tRegisterTab.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(0, 0);
            this.listBox2.Margin = new System.Windows.Forms.Padding(0);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(257, 420);
            this.listBox2.TabIndex = 1;
            // 
            // aRegisterTab
            // 
            this.aRegisterTab.Controls.Add(this.listBox3);
            this.aRegisterTab.Location = new System.Drawing.Point(4, 24);
            this.aRegisterTab.Name = "aRegisterTab";
            this.aRegisterTab.Padding = new System.Windows.Forms.Padding(3);
            this.aRegisterTab.Size = new System.Drawing.Size(292, 420);
            this.aRegisterTab.TabIndex = 2;
            this.aRegisterTab.Text = "A";
            this.aRegisterTab.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            this.listBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 15;
            this.listBox3.Location = new System.Drawing.Point(0, 0);
            this.listBox3.Margin = new System.Windows.Forms.Padding(0);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(257, 420);
            this.listBox3.TabIndex = 2;
            // 
            // vRegisterTab
            // 
            this.vRegisterTab.Controls.Add(this.listBox4);
            this.vRegisterTab.Location = new System.Drawing.Point(4, 24);
            this.vRegisterTab.Name = "vRegisterTab";
            this.vRegisterTab.Padding = new System.Windows.Forms.Padding(3);
            this.vRegisterTab.Size = new System.Drawing.Size(292, 420);
            this.vRegisterTab.TabIndex = 3;
            this.vRegisterTab.Text = "V";
            this.vRegisterTab.UseVisualStyleBackColor = true;
            // 
            // listBox4
            // 
            this.listBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 15;
            this.listBox4.Location = new System.Drawing.Point(0, 0);
            this.listBox4.Margin = new System.Windows.Forms.Padding(0);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(359, 420);
            this.listBox4.TabIndex = 2;
            // 
            // hiloTab
            // 
            this.hiloTab.Controls.Add(this.listBox6);
            this.hiloTab.Location = new System.Drawing.Point(4, 24);
            this.hiloTab.Name = "hiloTab";
            this.hiloTab.Padding = new System.Windows.Forms.Padding(3);
            this.hiloTab.Size = new System.Drawing.Size(292, 420);
            this.hiloTab.TabIndex = 4;
            this.hiloTab.Text = "Hi/Lo";
            this.hiloTab.UseVisualStyleBackColor = true;
            // 
            // listBox6
            // 
            this.listBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox6.FormattingEnabled = true;
            this.listBox6.ItemHeight = 15;
            this.listBox6.Location = new System.Drawing.Point(0, 0);
            this.listBox6.Margin = new System.Windows.Forms.Padding(0);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(292, 424);
            this.listBox6.TabIndex = 0;
            // 
            // fRegisterTab
            // 
            this.fRegisterTab.Controls.Add(this.listBox7);
            this.fRegisterTab.Location = new System.Drawing.Point(4, 24);
            this.fRegisterTab.Name = "fRegisterTab";
            this.fRegisterTab.Padding = new System.Windows.Forms.Padding(3);
            this.fRegisterTab.Size = new System.Drawing.Size(292, 420);
            this.fRegisterTab.TabIndex = 5;
            this.fRegisterTab.Text = "F";
            this.fRegisterTab.UseVisualStyleBackColor = true;
            // 
            // listBox7
            // 
            this.listBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox7.FormattingEnabled = true;
            this.listBox7.ItemHeight = 15;
            this.listBox7.Location = new System.Drawing.Point(3, 0);
            this.listBox7.Margin = new System.Windows.Forms.Padding(0);
            this.listBox7.Name = "listBox7";
            this.listBox7.Size = new System.Drawing.Size(286, 424);
            this.listBox7.TabIndex = 0;
            // 
            // clearLogButton
            // 
            this.clearLogButton.Location = new System.Drawing.Point(788, 33);
            this.clearLogButton.Name = "clearLogButton";
            this.clearLogButton.Size = new System.Drawing.Size(75, 23);
            this.clearLogButton.TabIndex = 9;
            this.clearLogButton.Text = "Clear Log";
            this.clearLogButton.UseVisualStyleBackColor = true;
            this.clearLogButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.stackTab);
            this.tabControl1.Controls.Add(this.memoryTab);
            this.tabControl1.Controls.Add(this.logTab);
            this.tabControl1.Location = new System.Drawing.Point(682, 76);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(263, 448);
            this.tabControl1.TabIndex = 1;
            // 
            // stackTab
            // 
            this.stackTab.Controls.Add(this.dataGridView1);
            this.stackTab.Location = new System.Drawing.Point(4, 24);
            this.stackTab.Name = "stackTab";
            this.stackTab.Padding = new System.Windows.Forms.Padding(3);
            this.stackTab.Size = new System.Drawing.Size(255, 420);
            this.stackTab.TabIndex = 0;
            this.stackTab.Text = "Stack";
            this.stackTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 3);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(251, 414);
            this.dataGridView1.TabIndex = 1;
            // 
            // memoryTab
            // 
            this.memoryTab.Controls.Add(this.dataGridView2);
            this.memoryTab.Location = new System.Drawing.Point(4, 24);
            this.memoryTab.Name = "memoryTab";
            this.memoryTab.Padding = new System.Windows.Forms.Padding(3);
            this.memoryTab.Size = new System.Drawing.Size(255, 420);
            this.memoryTab.TabIndex = 1;
            this.memoryTab.Text = "Memory";
            this.memoryTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(251, 417);
            this.dataGridView2.TabIndex = 1;
            // 
            // logTab
            // 
            this.logTab.Controls.Add(this.listBox5);
            this.logTab.Location = new System.Drawing.Point(4, 24);
            this.logTab.Name = "logTab";
            this.logTab.Padding = new System.Windows.Forms.Padding(3);
            this.logTab.Size = new System.Drawing.Size(255, 420);
            this.logTab.TabIndex = 2;
            this.logTab.Text = "Log";
            this.logTab.UseVisualStyleBackColor = true;
            // 
            // listBox5
            // 
            this.listBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 15;
            this.listBox5.Location = new System.Drawing.Point(-3, -2);
            this.listBox5.Margin = new System.Windows.Forms.Padding(0);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(261, 424);
            this.listBox5.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(937, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Supported";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1037, 595);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.clearLogButton);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.codeBox);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.oneStepButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.sRegisterTab.ResumeLayout(false);
            this.tRegisterTab.ResumeLayout(false);
            this.aRegisterTab.ResumeLayout(false);
            this.vRegisterTab.ResumeLayout(false);
            this.hiloTab.ResumeLayout(false);
            this.fRegisterTab.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.stackTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.memoryTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.logTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button oneStepButton;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.RichTextBox codeBox;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage sRegisterTab;
        private System.Windows.Forms.TabPage tRegisterTab;
        private System.Windows.Forms.TabPage aRegisterTab;
        private System.Windows.Forms.TabPage vRegisterTab;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Button clearLogButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage stackTab;
        private System.Windows.Forms.TabPage memoryTab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage logTab;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.TabPage hiloTab;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.TabPage fRegisterTab;
        private System.Windows.Forms.ListBox listBox7;
        private System.Windows.Forms.Button button1;
    }
}

