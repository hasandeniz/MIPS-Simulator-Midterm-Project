
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
            this.oneStepButton = new System.Windows.Forms.Button();
            this.executeButton = new System.Windows.Forms.Button();
            this.codeBox = new System.Windows.Forms.RichTextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.sRegisterTab = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            this.codeBox.Text = "";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.sRegisterTab);
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
            this.sRegisterTab.Text = "Registers";
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button clearLogButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage stackTab;
        private System.Windows.Forms.TabPage memoryTab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage logTab;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.Button button1;
    }
}

