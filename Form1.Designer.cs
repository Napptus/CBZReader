namespace CBZReader
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.pageInput = new System.Windows.Forms.NumericUpDown();
            this.pageEnter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PickFile = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.bBack = new System.Windows.Forms.Button();
            this.bForward = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(925, 656);
            this.splitContainer1.SplitterDistance = 172;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer4);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.PickFile);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer2.Size = new System.Drawing.Size(172, 656);
            this.splitContainer2.SplitterDistance = 590;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(5, 485);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.pageInput);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.pageEnter);
            this.splitContainer4.Size = new System.Drawing.Size(162, 31);
            this.splitContainer4.SplitterDistance = 65;
            this.splitContainer4.TabIndex = 5;
            // 
            // pageInput
            // 
            this.pageInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pageInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pageInput.Location = new System.Drawing.Point(0, 4);
            this.pageInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.pageInput.Name = "pageInput";
            this.pageInput.Size = new System.Drawing.Size(65, 27);
            this.pageInput.TabIndex = 5;
            this.pageInput.Visible = false;
            this.pageInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pageInput_KeyDown);
            // 
            // pageEnter
            // 
            this.pageEnter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageEnter.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pageEnter.Location = new System.Drawing.Point(0, 0);
            this.pageEnter.Name = "pageEnter";
            this.pageEnter.Size = new System.Drawing.Size(93, 31);
            this.pageEnter.TabIndex = 4;
            this.pageEnter.Text = "Open";
            this.pageEnter.UseVisualStyleBackColor = true;
            this.pageEnter.Visible = false;
            this.pageEnter.Click += new System.EventHandler(this.pageEnter_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(5, 516);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 69);
            this.label2.TabIndex = 2;
            this.label2.Text = "lol";
            this.label2.Visible = false;
            // 
            // PickFile
            // 
            this.PickFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.PickFile.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PickFile.Location = new System.Drawing.Point(5, 5);
            this.PickFile.Name = "PickFile";
            this.PickFile.Size = new System.Drawing.Size(162, 72);
            this.PickFile.TabIndex = 1;
            this.PickFile.Text = "Pick archive";
            this.PickFile.UseVisualStyleBackColor = true;
            this.PickFile.Click += new System.EventHandler(this.PickFile_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(5, 5);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.bBack);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.bForward);
            this.splitContainer3.Size = new System.Drawing.Size(162, 52);
            this.splitContainer3.SplitterDistance = 77;
            this.splitContainer3.TabIndex = 0;
            // 
            // bBack
            // 
            this.bBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bBack.Enabled = false;
            this.bBack.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bBack.Location = new System.Drawing.Point(0, 0);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(75, 50);
            this.bBack.TabIndex = 1;
            this.bBack.Text = "<-";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            this.bBack.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ArrowKeyScroll_PreviewKeyDown);
            // 
            // bForward
            // 
            this.bForward.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bForward.Enabled = false;
            this.bForward.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bForward.Location = new System.Drawing.Point(0, 0);
            this.bForward.Name = "bForward";
            this.bForward.Size = new System.Drawing.Size(79, 50);
            this.bForward.TabIndex = 0;
            this.bForward.Text = "->";
            this.bForward.UseVisualStyleBackColor = true;
            this.bForward.Click += new System.EventHandler(this.bForward_Click);
            this.bForward.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ArrowKeyScroll_PreviewKeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(100);
            this.pictureBox1.Size = new System.Drawing.Size(749, 656);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ArrowKeyScroll_PreviewKeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 656);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 520);
            this.Name = "Form1";
            this.Text = "Comic Book Reader";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageInput)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Button PickFile;
        private SplitContainer splitContainer3;
        private Button bBack;
        private Button bForward;
        private PictureBox pictureBox1;
        private Label label2;
        private Button pageEnter;
        private SplitContainer splitContainer4;
        private NumericUpDown pageInput;
    }
}