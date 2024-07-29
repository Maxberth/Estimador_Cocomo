namespace Estimador
{
    partial class ProjectOptions
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
            SplitContainer = new SplitContainer();
            label1 = new Label();
            OpenFile_pctb = new PictureBox();
            newProject_lbl = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)SplitContainer).BeginInit();
            SplitContainer.Panel1.SuspendLayout();
            SplitContainer.Panel2.SuspendLayout();
            SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OpenFile_pctb).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // SplitContainer
            // 
            SplitContainer.FixedPanel = FixedPanel.Panel1;
            SplitContainer.ImeMode = ImeMode.Off;
            SplitContainer.Location = new Point(0, 14);
            SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            SplitContainer.Panel1.Controls.Add(label1);
            SplitContainer.Panel1.Controls.Add(OpenFile_pctb);
            SplitContainer.Panel1.Controls.Add(newProject_lbl);
            SplitContainer.Panel1.Controls.Add(tableLayoutPanel1);
            SplitContainer.Panel1.RightToLeft = RightToLeft.No;
            // 
            // SplitContainer.Panel2
            // 
            SplitContainer.Panel2.Controls.Add(pictureBox1);
            SplitContainer.Panel2.RightToLeft = RightToLeft.No;
            SplitContainer.RightToLeft = RightToLeft.No;
            SplitContainer.Size = new Size(1077, 618);
            SplitContainer.SplitterDistance = 357;
            SplitContainer.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 76);
            label1.Name = "label1";
            label1.Size = new Size(252, 27);
            label1.TabIndex = 0;
            label1.Text = "Software de Estimación";
            // 
            // OpenFile_pctb
            // 
            OpenFile_pctb.BackgroundImageLayout = ImageLayout.Stretch;
            OpenFile_pctb.Cursor = Cursors.Hand;
            OpenFile_pctb.Image = Properties.Resources.newdocument;
            OpenFile_pctb.Location = new Point(38, 172);
            OpenFile_pctb.Name = "OpenFile_pctb";
            OpenFile_pctb.Size = new Size(53, 54);
            OpenFile_pctb.SizeMode = PictureBoxSizeMode.Zoom;
            OpenFile_pctb.TabIndex = 8;
            OpenFile_pctb.TabStop = false;
            OpenFile_pctb.Click += NewProject;
            // 
            // newProject_lbl
            // 
            newProject_lbl.AutoSize = true;
            newProject_lbl.Cursor = Cursors.Hand;
            newProject_lbl.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            newProject_lbl.Location = new Point(97, 188);
            newProject_lbl.Name = "newProject_lbl";
            newProject_lbl.Size = new Size(219, 25);
            newProject_lbl.TabIndex = 5;
            newProject_lbl.Text = "Crear un nuevo proyecto";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 0);
            tableLayoutPanel1.Location = new Point(3, 76);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(351, 518);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Location = new Point(175, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(0, 512);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.BackgroundImage = Properties.Resources.BarryBoehm;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.InitialImage = Properties.Resources.BarryBoehm;
            pictureBox1.Location = new Point(-211, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(938, 612);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.WaitOnLoad = true;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ProjectOptions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 633);
            Controls.Add(SplitContainer);
            Name = "ProjectOptions";
            Text = "ModelSelect";
            SplitContainer.Panel1.ResumeLayout(false);
            SplitContainer.Panel1.PerformLayout();
            SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainer).EndInit();
            SplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)OpenFile_pctb).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer SplitContainer;
        private Label label1;
        private PictureBox OpenFile_pctb;
        private Label newProject_lbl;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private PictureBox pictureBox1;
    }
}