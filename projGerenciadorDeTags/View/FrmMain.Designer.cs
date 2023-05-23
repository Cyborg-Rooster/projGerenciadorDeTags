namespace projGerenciadorDeTags
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            pnlHeader = new Panel();
            lblNVersion = new Label();
            lblBuilder = new Label();
            lblCreate = new Label();
            lblEdit = new Label();
            ptbLogo = new PictureBox();
            pnlContent = new Panel();
            lblLink = new LinkLabel();
            uscBuilder1 = new View.UscBuilder();
            uscCreate1 = new View.UscCreate();
            uscEdit1 = new View.UscEdit();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).BeginInit();
            pnlContent.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(251, 235, 93);
            pnlHeader.Controls.Add(lblNVersion);
            pnlHeader.Controls.Add(lblBuilder);
            pnlHeader.Controls.Add(lblCreate);
            pnlHeader.Controls.Add(lblEdit);
            pnlHeader.Controls.Add(ptbLogo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(782, 76);
            pnlHeader.TabIndex = 1;
            // 
            // lblNVersion
            // 
            lblNVersion.AutoSize = true;
            lblNVersion.ForeColor = SystemColors.ControlDarkDark;
            lblNVersion.Location = new Point(163, 44);
            lblNVersion.Name = "lblNVersion";
            lblNVersion.Size = new Size(46, 15);
            lblNVersion.TabIndex = 7;
            lblNVersion.Text = "v0.0.0.0";
            // 
            // lblBuilder
            // 
            lblBuilder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblBuilder.AutoSize = true;
            lblBuilder.Cursor = Cursors.Hand;
            lblBuilder.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblBuilder.Location = new Point(389, 31);
            lblBuilder.Margin = new Padding(4, 0, 4, 0);
            lblBuilder.Name = "lblBuilder";
            lblBuilder.Size = new Size(56, 15);
            lblBuilder.TabIndex = 4;
            lblBuilder.Text = "Gerar Tag";
            lblBuilder.Click += OnLblBuildClick;
            lblBuilder.MouseLeave += OnLabelLeave;
            lblBuilder.MouseHover += OnLabelOver;
            // 
            // lblCreate
            // 
            lblCreate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCreate.AutoSize = true;
            lblCreate.Cursor = Cursors.Hand;
            lblCreate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCreate.Location = new Point(505, 31);
            lblCreate.Margin = new Padding(4, 0, 4, 0);
            lblCreate.Name = "lblCreate";
            lblCreate.Size = new Size(78, 15);
            lblCreate.TabIndex = 5;
            lblCreate.Text = "Cadastrar Tag";
            lblCreate.Click += OnLblCreateClick;
            lblCreate.MouseLeave += OnLabelLeave;
            lblCreate.MouseHover += OnLabelOver;
            // 
            // lblEdit
            // 
            lblEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEdit.AutoSize = true;
            lblEdit.Cursor = Cursors.Hand;
            lblEdit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblEdit.ForeColor = SystemColors.ControlText;
            lblEdit.Location = new Point(649, 30);
            lblEdit.Margin = new Padding(4, 0, 4, 0);
            lblEdit.Name = "lblEdit";
            lblEdit.Size = new Size(57, 15);
            lblEdit.TabIndex = 6;
            lblEdit.Text = "Editar tag";
            lblEdit.Click += OnLblEditClick;
            lblEdit.MouseLeave += OnLabelLeave;
            lblEdit.MouseHover += OnLabelOver;
            // 
            // ptbLogo
            // 
            ptbLogo.Image = (Image)resources.GetObject("ptbLogo.Image");
            ptbLogo.Location = new Point(31, 21);
            ptbLogo.Margin = new Padding(4);
            ptbLogo.Name = "ptbLogo";
            ptbLogo.Size = new Size(125, 38);
            ptbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbLogo.TabIndex = 0;
            ptbLogo.TabStop = false;
            // 
            // pnlContent
            // 
            pnlContent.Controls.Add(lblLink);
            this.pnlContent.Controls.Add(this.uscBuilder1);
            pnlContent.Controls.Add(uscCreate1);
            pnlContent.Controls.Add(uscEdit1);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 76);
            pnlContent.Margin = new Padding(2);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(782, 469);
            pnlContent.TabIndex = 2;
            // 
            // lblLink
            // 
            lblLink.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblLink.AutoSize = true;
            lblLink.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblLink.Location = new Point(4, 445);
            lblLink.Margin = new Padding(4, 0, 4, 0);
            lblLink.Name = "lblLink";
            lblLink.Size = new Size(105, 15);
            lblLink.TabIndex = 10;
            lblLink.TabStop = true;
            lblLink.Text = "Criado por Enrique";
            lblLink.LinkClicked += lblLink_LinkClicked;
            // 
            // uscBuilder1
            // 
            this.uscBuilder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscBuilder1.Location = new System.Drawing.Point(0, 0);
            this.uscBuilder1.Name = "uscBuilder1";
            this.uscBuilder1.Size = new System.Drawing.Size(782, 469);
            this.uscBuilder1.TabIndex = 1;
            this.uscBuilder1.Visible = true;
            // 
            // uscCreate1
            // 
            uscCreate1.Dock = DockStyle.Fill;
            uscCreate1.Location = new Point(0, 0);
            uscCreate1.Margin = new Padding(2, 2, 2, 2);
            uscCreate1.Name = "uscCreate1";
            uscCreate1.Size = new Size(782, 469);
            uscCreate1.TabIndex = 1;
            uscCreate1.Visible = false;
            // 
            // uscEdit1
            // 
            uscEdit1.Dock = DockStyle.Fill;
            uscEdit1.Location = new Point(0, 0);
            uscEdit1.Margin = new Padding(3, 2, 3, 2);
            uscEdit1.Name = "uscEdit1";
            uscEdit1.Size = new Size(782, 469);
            uscEdit1.TabIndex = 0;
            uscEdit1.Visible = false;
            // 
            // FrmMain
            // 
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(782, 545);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(45, 18, 45, 18);
            Name = "FrmMain";
            Text = "LTB Marketing Digital | Gerenciador de Tags";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).EndInit();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlHeader;
        private Label lblBuilder;
        private Label lblCreate;
        private Label lblEdit;
        private PictureBox ptbLogo;
        private Panel pnlContent;
        private View.UscBuilder uscBuilder1;
        private LinkLabel lblLink;
        private View.UscCreate uscCreate1;
        private View.UscEdit uscEdit1;
        private Label lblNVersion;
    }
}