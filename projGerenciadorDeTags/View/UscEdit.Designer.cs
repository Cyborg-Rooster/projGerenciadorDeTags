namespace projGerenciadorDeTags.View
{
    partial class UscEdit
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.lblTagToEdit = new System.Windows.Forms.Label();
            this.cbxTagToEdit = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 105);
            this.panel1.TabIndex = 5;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblDescription.Location = new System.Drawing.Point(71, 81);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(340, 20);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Cadastre tags para um ramo ou cidade específica.";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblTitle.Location = new System.Drawing.Point(63, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(270, 54);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "EDITAR TAGS";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblType.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblType.Location = new System.Drawing.Point(71, 112);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(143, 32);
            this.lblType.TabIndex = 19;
            this.lblType.Text = "Tipo de Tag:";
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "Ramo",
            "Cidade"});
            this.cbxType.Location = new System.Drawing.Point(71, 147);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(312, 28);
            this.cbxType.TabIndex = 0;
            this.cbxType.Text = "--Selecionar--";
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.OnCbxTypeSelectedChanged);
            // 
            // lblTagToEdit
            // 
            this.lblTagToEdit.AutoSize = true;
            this.lblTagToEdit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTagToEdit.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblTagToEdit.Location = new System.Drawing.Point(409, 112);
            this.lblTagToEdit.Name = "lblTagToEdit";
            this.lblTagToEdit.Size = new System.Drawing.Size(200, 32);
            this.lblTagToEdit.TabIndex = 21;
            this.lblTagToEdit.Text = "Tag à Ser Editada:";
            // 
            // cbxTagToEdit
            // 
            this.cbxTagToEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxTagToEdit.Enabled = false;
            this.cbxTagToEdit.FormattingEnabled = true;
            this.cbxTagToEdit.Location = new System.Drawing.Point(409, 147);
            this.cbxTagToEdit.Name = "cbxTagToEdit";
            this.cbxTagToEdit.Size = new System.Drawing.Size(318, 28);
            this.cbxTagToEdit.TabIndex = 1;
            this.cbxTagToEdit.Text = "--Selecionar--";
            this.cbxTagToEdit.SelectedIndexChanged += new System.EventHandler(this.OnCbxTagToEditSelectedValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(633, 478);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.OnButtonSaveClick);
            // 
            // txtContent
            // 
            this.txtContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContent.Location = new System.Drawing.Point(71, 290);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(656, 173);
            this.txtContent.TabIndex = 3;
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContent.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblContent.Location = new System.Drawing.Point(71, 255);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(125, 32);
            this.lblContent.TabIndex = 23;
            this.lblContent.Text = "Conteúdo:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(71, 223);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(312, 27);
            this.txtTitle.TabIndex = 2;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLocation.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblLocation.Location = new System.Drawing.Point(71, 188);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(80, 32);
            this.lblLocation.TabIndex = 26;
            this.lblLocation.Text = "Título:";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(496, 478);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.OnButtonDeleteClick);
            // 
            // UscEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.lblTagToEdit);
            this.Controls.Add(this.cbxTagToEdit);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.panel1);
            this.Name = "UscEdit";
            this.Size = new System.Drawing.Size(800, 516);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label lblDescription;
        private Label lblTitle;
        private Label lblType;
        private ComboBox cbxType;
        private Label lblTagToEdit;
        private ComboBox cbxTagToEdit;
        private Button btnSave;
        private TextBox txtContent;
        private Label lblContent;
        private TextBox txtTitle;
        private Label lblLocation;
        private Button btnDelete;
    }
}
