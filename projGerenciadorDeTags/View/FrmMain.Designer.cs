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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblBuilder = new System.Windows.Forms.Label();
            this.lblCreate = new System.Windows.Forms.Label();
            this.lblEdit = new System.Windows.Forms.Label();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblLink = new System.Windows.Forms.LinkLabel();
            this.uscEdit1 = new projGerenciadorDeTags.View.UscEdit();
            this.uscCreate1 = new projGerenciadorDeTags.View.UscCreate();
            this.uscBuilder1 = new View.UscBuilder();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(235)))), ((int)(((byte)(93)))));
            this.pnlHeader.Controls.Add(this.lblBuilder);
            this.pnlHeader.Controls.Add(this.lblCreate);
            this.pnlHeader.Controls.Add(this.lblEdit);
            this.pnlHeader.Controls.Add(this.ptbLogo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(782, 76);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblBuilder
            // 
            this.lblBuilder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBuilder.AutoSize = true;
            this.lblBuilder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBuilder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBuilder.Location = new System.Drawing.Point(389, 31);
            this.lblBuilder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuilder.Name = "lblBuilder";
            this.lblBuilder.Size = new System.Drawing.Size(72, 20);
            this.lblBuilder.TabIndex = 4;
            this.lblBuilder.Text = "Gerar Tag";
            this.lblBuilder.Click += new System.EventHandler(this.OnLblBuildClick);
            this.lblBuilder.MouseLeave += new System.EventHandler(this.OnLabelLeave);
            this.lblBuilder.MouseHover += new System.EventHandler(this.OnLabelOver);
            // 
            // lblCreate
            // 
            this.lblCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreate.AutoSize = true;
            this.lblCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCreate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreate.Location = new System.Drawing.Point(505, 31);
            this.lblCreate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(99, 20);
            this.lblCreate.TabIndex = 5;
            this.lblCreate.Text = "Cadastrar Tag";
            this.lblCreate.Click += new System.EventHandler(this.OnLblCreateClick);
            this.lblCreate.MouseLeave += new System.EventHandler(this.OnLabelLeave);
            this.lblCreate.MouseHover += new System.EventHandler(this.OnLabelOver);
            // 
            // lblEdit
            // 
            this.lblEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEdit.AutoSize = true;
            this.lblEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEdit.Location = new System.Drawing.Point(649, 30);
            this.lblEdit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(74, 20);
            this.lblEdit.TabIndex = 6;
            this.lblEdit.Text = "Editar tag";
            this.lblEdit.Click += new System.EventHandler(this.OnLblEditClick);
            this.lblEdit.MouseLeave += new System.EventHandler(this.OnLabelLeave);
            this.lblEdit.MouseHover += new System.EventHandler(this.OnLabelOver);
            // 
            // ptbLogo
            // 
            this.ptbLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptbLogo.Image")));
            this.ptbLogo.Location = new System.Drawing.Point(31, 21);
            this.ptbLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(125, 38);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogo.TabIndex = 0;
            this.ptbLogo.TabStop = false;
            // 
            // pnlContent
            // 
            this.pnlContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContent.Dock = DockStyle.Fill;
            this.pnlContent.Controls.Add(this.lblLink);
            this.pnlContent.Controls.Add(this.label1);
            this.pnlContent.Controls.Add(this.uscCreate1);
            this.pnlContent.Controls.Add(this.uscEdit1);
            this.pnlContent.Controls.Add(this.uscBuilder1);
            this.pnlContent.Location = new System.Drawing.Point(0, 76);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(782, 469);
            this.pnlContent.TabIndex = 2;
            // 
            // lblLink
            // 
            this.lblLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLink.AutoSize = true;
            this.lblLink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblLink.Location = new System.Drawing.Point(86, 440);
            this.lblLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(56, 20);
            this.lblLink.TabIndex = 10;
            this.lblLink.TabStop = true;
            this.lblLink.Text = "Enrique";
            this.lblLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLink_LinkClicked);
            // 
            // uscEdit1
            // 
            this.uscEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscEdit1.Location = new System.Drawing.Point(0, 0);
            this.uscEdit1.Name = "uscEdit1";
            this.uscEdit1.Size = new System.Drawing.Size(782, 469);
            this.uscEdit1.TabIndex = 0;
            this.uscEdit1.Visible = false;
            // 
            // uscCreate1
            // 
            this.uscCreate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscCreate1.Location = new System.Drawing.Point(0, 0);
            this.uscCreate1.Name = "uscCreate1";
            this.uscCreate1.Size = new System.Drawing.Size(782, 469);
            this.uscCreate1.TabIndex = 1;
            this.uscCreate1.Visible = false;
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(13, 440);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Criado por";
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(782, 545);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(45, 18, 45, 18);
            this.Name = "FrmMain";
            this.Text = "LTB Marketing Digital | Gerenciador de Tags";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

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
        private Label label1;
        private View.UscCreate uscCreate1;
        private View.UscEdit uscEdit1;
    }
}