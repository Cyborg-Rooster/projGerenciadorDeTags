namespace projGerenciadorDeTags.View
{
    partial class UscCreate
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
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
            this.panel1.TabIndex = 4;
            // 
            // lblDescription
            // 
            this.lblDescription.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblDescription.Location = new System.Drawing.Point(71, 81);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(739, 20);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Cadastre tags para um ramo ou cidade específica. Escreva [cidade] para o preenchi" +
    "mento automatico.";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblTitle.Location = new System.Drawing.Point(63, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 54);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "CRIAR TAGS";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Location = new System.Drawing.Point(633, 476);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(94, 29);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Salvar";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.OnButtonSaveClick);
            // 
            // txtContent
            // 
            this.txtContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContent.Location = new System.Drawing.Point(71, 298);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(656, 163);
            this.txtContent.TabIndex = 3;
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContent.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblContent.Location = new System.Drawing.Point(71, 263);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(125, 32);
            this.lblContent.TabIndex = 20;
            this.lblContent.Text = "Conteúdo:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLocation.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblLocation.Location = new System.Drawing.Point(71, 185);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(80, 32);
            this.lblLocation.TabIndex = 19;
            this.lblLocation.Text = "Título:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblType.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblType.Location = new System.Drawing.Point(71, 109);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(143, 32);
            this.lblType.TabIndex = 17;
            this.lblType.Text = "Tipo de Tag:";
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "Ramo",
            "Cidade"});
            this.cbxType.Location = new System.Drawing.Point(71, 144);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(332, 28);
            this.cbxType.TabIndex = 0;
            this.cbxType.Text = "-- Selecionar --";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(71, 220);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(332, 27);
            this.txtTitle.TabIndex = 1;
            // 
            // UscCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.panel1);
            this.Name = "UscCreate";
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
        private Button btnCreate;
        private TextBox txtContent;
        private Label lblContent;
        private Label lblLocation;
        private Label lblType;
        private ComboBox cbxType;
        private TextBox txtTitle;
    }
}
