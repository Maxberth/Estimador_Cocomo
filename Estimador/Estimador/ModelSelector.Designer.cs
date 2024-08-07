namespace Estimador
{
    partial class ModelSelect
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
            UseCase_btn = new Button();
            COCOMOII_btn = new Button();
            label1 = new Label();
            COCOMO81_btn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)SplitContainer).BeginInit();
            SplitContainer.Panel1.SuspendLayout();
            SplitContainer.Panel2.SuspendLayout();
            SplitContainer.SuspendLayout();
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
            SplitContainer.Panel1.Controls.Add(UseCase_btn);
            SplitContainer.Panel1.Controls.Add(COCOMOII_btn);
            SplitContainer.Panel1.Controls.Add(label1);
            SplitContainer.Panel1.Controls.Add(COCOMO81_btn);
            SplitContainer.Panel1.Controls.Add(tableLayoutPanel1);
            SplitContainer.Panel1.RightToLeft = RightToLeft.No;
            // 
            // SplitContainer.Panel2
            // 
            SplitContainer.Panel2.Controls.Add(pictureBox1);
            SplitContainer.Panel2.RightToLeft = RightToLeft.No;
            SplitContainer.RightToLeft = RightToLeft.No;
            SplitContainer.Size = new Size(1074, 620);
            SplitContainer.SplitterDistance = 357;
            SplitContainer.TabIndex = 3;
            // 
            // UseCase_btn
            // 
            UseCase_btn.Location = new Point(105, 323);
            UseCase_btn.Name = "UseCase_btn";
            UseCase_btn.Size = new Size(155, 62);
            UseCase_btn.TabIndex = 12;
            UseCase_btn.Text = "Puntos de Casos de Uso";
            UseCase_btn.UseVisualStyleBackColor = true;
            UseCase_btn.Click += UseCase_btn_Click;
            // 
            // COCOMOII_btn
            // 
            COCOMOII_btn.Location = new Point(191, 238);
            COCOMOII_btn.Name = "COCOMOII_btn";
            COCOMOII_btn.Size = new Size(110, 29);
            COCOMOII_btn.TabIndex = 11;
            COCOMOII_btn.Text = "COCOMO II";
            COCOMOII_btn.UseVisualStyleBackColor = true;
            COCOMOII_btn.Click += COCOMOII_btn_Click;
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
            // COCOMO81_btn
            // 
            COCOMO81_btn.Location = new Point(37, 238);
            COCOMO81_btn.Name = "COCOMO81_btn";
            COCOMO81_btn.Size = new Size(110, 29);
            COCOMO81_btn.TabIndex = 10;
            COCOMO81_btn.Text = "COCOMO 81";
            COCOMO81_btn.UseVisualStyleBackColor = true;
            COCOMO81_btn.Click += COCOMO81_btn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 1);
            tableLayoutPanel1.Location = new Point(3, 76);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(351, 224);
            tableLayoutPanel1.TabIndex = 4;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Location = new Point(175, 207);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(0, 14);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.BackgroundImage = Properties.Resources.BarryBoehm;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.InitialImage = Properties.Resources.BarryBoehm;
            pictureBox1.Location = new Point(-208, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(921, 614);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.WaitOnLoad = true;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ModelSelect
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 633);
            Controls.Add(SplitContainer);
            Name = "ModelSelect";
            Text = "ModelSelect";
            SplitContainer.Panel1.ResumeLayout(false);
            SplitContainer.Panel1.PerformLayout();
            SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainer).EndInit();
            SplitContainer.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer SplitContainer;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private PictureBox pictureBox1;
        private Button COCOMOII_btn;
        private Button COCOMO81_btn;
        private Button UseCase_btn;
    }
}