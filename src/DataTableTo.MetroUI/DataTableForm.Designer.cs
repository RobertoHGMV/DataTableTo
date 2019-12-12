namespace DataTableTo.MetroUI
{
    partial class DataTableForm
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataTableForm));
            this.cmdOk = new MetroFramework.Controls.MetroButton();
            this.btnCopy = new MetroFramework.Controls.MetroButton();
            this.btnCopyAll = new MetroFramework.Controls.MetroButton();
            this.fromToTabControl = new MetroFramework.Controls.MetroTabControl();
            this.tabPageFromTo = new MetroFramework.Controls.MetroTabPage();
            this.listResult = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkUseQuery = new MetroFramework.Controls.MetroCheckBox();
            this.chkValidation = new MetroFramework.Controls.MetroCheckBox();
            this.btnResults = new MetroFramework.Controls.MetroButton();
            this.txtColumnSufix = new MetroFramework.Controls.MetroTextBox();
            this.txtColumnPrefix = new MetroFramework.Controls.MetroTextBox();
            this.txtRowName = new MetroFramework.Controls.MetroTextBox();
            this.txtObjectName = new MetroFramework.Controls.MetroTextBox();
            this.txtTableName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tabPageSettings = new MetroFramework.Controls.MetroTabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtMethod = new MetroFramework.Controls.MetroTextBox();
            this.lbCustomMethod = new MetroFramework.Controls.MetroLabel();
            this.chkCustomMethod = new MetroFramework.Controls.MetroCheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMethodExtension = new MetroFramework.Controls.MetroTextBox();
            this.lbExtensionMethod = new MetroFramework.Controls.MetroLabel();
            this.chkCustomMethodExt = new MetroFramework.Controls.MetroCheckBox();
            this.chkDotNet = new MetroFramework.Controls.MetroCheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConTest = new MetroFramework.Controls.MetroButton();
            this.txtDatabase = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtLogin = new MetroFramework.Controls.MetroTextBox();
            this.txtServer = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.tabPageQuery = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txtUserQuery = new MetroFramework.Controls.MetroTextBox();
            this.tabPageReplace = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.listReplace = new System.Windows.Forms.ListBox();
            this.btnResultReplace = new MetroFramework.Controls.MetroButton();
            this.txtMethodToReplace = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtReplace = new MetroFramework.Controls.MetroTextBox();
            this.fromToTabControl.SuspendLayout();
            this.tabPageFromTo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPageQuery.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.tabPageReplace.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdOk
            // 
            this.cmdOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdOk.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.cmdOk.Location = new System.Drawing.Point(23, 584);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(100, 23);
            this.cmdOk.TabIndex = 10;
            this.cmdOk.Text = "OK";
            this.cmdOk.UseSelectable = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCopy.Location = new System.Drawing.Point(522, 584);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(157, 23);
            this.btnCopy.TabIndex = 8;
            this.btnCopy.Text = "Copiar Selecionado";
            this.btnCopy.UseSelectable = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnCopyAll
            // 
            this.btnCopyAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyAll.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCopyAll.Location = new System.Drawing.Point(685, 584);
            this.btnCopyAll.Name = "btnCopyAll";
            this.btnCopyAll.Size = new System.Drawing.Size(105, 23);
            this.btnCopyAll.TabIndex = 9;
            this.btnCopyAll.Text = "Copiar Tudo";
            this.btnCopyAll.UseSelectable = true;
            this.btnCopyAll.Click += new System.EventHandler(this.btnCopyAll_Click);
            // 
            // fromToTabControl
            // 
            this.fromToTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fromToTabControl.Controls.Add(this.tabPageFromTo);
            this.fromToTabControl.Controls.Add(this.tabPageSettings);
            this.fromToTabControl.Controls.Add(this.tabPageQuery);
            this.fromToTabControl.Controls.Add(this.tabPageReplace);
            this.fromToTabControl.Location = new System.Drawing.Point(23, 63);
            this.fromToTabControl.Name = "fromToTabControl";
            this.fromToTabControl.SelectedIndex = 0;
            this.fromToTabControl.Size = new System.Drawing.Size(767, 515);
            this.fromToTabControl.TabIndex = 2;
            this.fromToTabControl.UseSelectable = true;
            // 
            // tabPageFromTo
            // 
            this.tabPageFromTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageFromTo.Controls.Add(this.listResult);
            this.tabPageFromTo.Controls.Add(this.groupBox1);
            this.tabPageFromTo.HorizontalScrollbarBarColor = true;
            this.tabPageFromTo.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPageFromTo.HorizontalScrollbarSize = 10;
            this.tabPageFromTo.Location = new System.Drawing.Point(4, 38);
            this.tabPageFromTo.Name = "tabPageFromTo";
            this.tabPageFromTo.Size = new System.Drawing.Size(759, 473);
            this.tabPageFromTo.TabIndex = 0;
            this.tabPageFromTo.Text = "De Para";
            this.tabPageFromTo.VerticalScrollbarBarColor = true;
            this.tabPageFromTo.VerticalScrollbarHighlightOnWheel = false;
            this.tabPageFromTo.VerticalScrollbarSize = 10;
            // 
            // listResult
            // 
            this.listResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listResult.FormattingEnabled = true;
            this.listResult.Location = new System.Drawing.Point(3, 163);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(752, 303);
            this.listResult.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.chkUseQuery);
            this.groupBox1.Controls.Add(this.chkValidation);
            this.groupBox1.Controls.Add(this.btnResults);
            this.groupBox1.Controls.Add(this.txtColumnSufix);
            this.groupBox1.Controls.Add(this.txtColumnPrefix);
            this.groupBox1.Controls.Add(this.txtRowName);
            this.groupBox1.Controls.Add(this.txtObjectName);
            this.groupBox1.Controls.Add(this.txtTableName);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 155);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // chkUseQuery
            // 
            this.chkUseQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkUseQuery.AutoSize = true;
            this.chkUseQuery.Location = new System.Drawing.Point(638, 65);
            this.chkUseQuery.Name = "chkUseQuery";
            this.chkUseQuery.Size = new System.Drawing.Size(70, 15);
            this.chkUseQuery.TabIndex = 8;
            this.chkUseQuery.Text = "Consulta";
            this.chkUseQuery.UseSelectable = true;
            // 
            // chkValidation
            // 
            this.chkValidation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkValidation.AutoSize = true;
            this.chkValidation.Location = new System.Drawing.Point(638, 44);
            this.chkValidation.Name = "chkValidation";
            this.chkValidation.Size = new System.Drawing.Size(99, 15);
            this.chkValidation.TabIndex = 6;
            this.chkValidation.Text = "Sem validação";
            this.chkValidation.UseSelectable = true;
            // 
            // btnResults
            // 
            this.btnResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResults.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnResults.Location = new System.Drawing.Point(638, 14);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(107, 23);
            this.btnResults.TabIndex = 7;
            this.btnResults.Text = "Executar";
            this.btnResults.UseSelectable = true;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // txtColumnSufix
            // 
            this.txtColumnSufix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtColumnSufix.CustomButton.Image = null;
            this.txtColumnSufix.CustomButton.Location = new System.Drawing.Point(476, 1);
            this.txtColumnSufix.CustomButton.Name = "";
            this.txtColumnSufix.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtColumnSufix.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtColumnSufix.CustomButton.TabIndex = 1;
            this.txtColumnSufix.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtColumnSufix.CustomButton.UseSelectable = true;
            this.txtColumnSufix.CustomButton.Visible = false;
            this.txtColumnSufix.Lines = new string[0];
            this.txtColumnSufix.Location = new System.Drawing.Point(128, 118);
            this.txtColumnSufix.MaxLength = 32767;
            this.txtColumnSufix.Name = "txtColumnSufix";
            this.txtColumnSufix.PasswordChar = '\0';
            this.txtColumnSufix.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtColumnSufix.SelectedText = "";
            this.txtColumnSufix.SelectionLength = 0;
            this.txtColumnSufix.SelectionStart = 0;
            this.txtColumnSufix.ShortcutsEnabled = true;
            this.txtColumnSufix.Size = new System.Drawing.Size(498, 23);
            this.txtColumnSufix.TabIndex = 5;
            this.txtColumnSufix.UseSelectable = true;
            this.txtColumnSufix.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtColumnSufix.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtColumnPrefix
            // 
            this.txtColumnPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtColumnPrefix.CustomButton.Image = null;
            this.txtColumnPrefix.CustomButton.Location = new System.Drawing.Point(476, 1);
            this.txtColumnPrefix.CustomButton.Name = "";
            this.txtColumnPrefix.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtColumnPrefix.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtColumnPrefix.CustomButton.TabIndex = 1;
            this.txtColumnPrefix.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtColumnPrefix.CustomButton.UseSelectable = true;
            this.txtColumnPrefix.CustomButton.Visible = false;
            this.txtColumnPrefix.Lines = new string[0];
            this.txtColumnPrefix.Location = new System.Drawing.Point(128, 92);
            this.txtColumnPrefix.MaxLength = 32767;
            this.txtColumnPrefix.Name = "txtColumnPrefix";
            this.txtColumnPrefix.PasswordChar = '\0';
            this.txtColumnPrefix.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtColumnPrefix.SelectedText = "";
            this.txtColumnPrefix.SelectionLength = 0;
            this.txtColumnPrefix.SelectionStart = 0;
            this.txtColumnPrefix.ShortcutsEnabled = true;
            this.txtColumnPrefix.Size = new System.Drawing.Size(498, 23);
            this.txtColumnPrefix.TabIndex = 4;
            this.txtColumnPrefix.UseSelectable = true;
            this.txtColumnPrefix.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtColumnPrefix.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtRowName
            // 
            this.txtRowName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtRowName.CustomButton.Image = null;
            this.txtRowName.CustomButton.Location = new System.Drawing.Point(476, 1);
            this.txtRowName.CustomButton.Name = "";
            this.txtRowName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRowName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRowName.CustomButton.TabIndex = 1;
            this.txtRowName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRowName.CustomButton.UseSelectable = true;
            this.txtRowName.CustomButton.Visible = false;
            this.txtRowName.Lines = new string[0];
            this.txtRowName.Location = new System.Drawing.Point(128, 66);
            this.txtRowName.MaxLength = 32767;
            this.txtRowName.Name = "txtRowName";
            this.txtRowName.PasswordChar = '\0';
            this.txtRowName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRowName.SelectedText = "";
            this.txtRowName.SelectionLength = 0;
            this.txtRowName.SelectionStart = 0;
            this.txtRowName.ShortcutsEnabled = true;
            this.txtRowName.Size = new System.Drawing.Size(498, 23);
            this.txtRowName.TabIndex = 3;
            this.txtRowName.UseSelectable = true;
            this.txtRowName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRowName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtObjectName
            // 
            this.txtObjectName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtObjectName.CustomButton.Image = null;
            this.txtObjectName.CustomButton.Location = new System.Drawing.Point(476, 1);
            this.txtObjectName.CustomButton.Name = "";
            this.txtObjectName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtObjectName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtObjectName.CustomButton.TabIndex = 1;
            this.txtObjectName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtObjectName.CustomButton.UseSelectable = true;
            this.txtObjectName.CustomButton.Visible = false;
            this.txtObjectName.Lines = new string[0];
            this.txtObjectName.Location = new System.Drawing.Point(128, 40);
            this.txtObjectName.MaxLength = 32767;
            this.txtObjectName.Name = "txtObjectName";
            this.txtObjectName.PasswordChar = '\0';
            this.txtObjectName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtObjectName.SelectedText = "";
            this.txtObjectName.SelectionLength = 0;
            this.txtObjectName.SelectionStart = 0;
            this.txtObjectName.ShortcutsEnabled = true;
            this.txtObjectName.Size = new System.Drawing.Size(498, 23);
            this.txtObjectName.TabIndex = 2;
            this.txtObjectName.UseSelectable = true;
            this.txtObjectName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtObjectName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTableName
            // 
            this.txtTableName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtTableName.CustomButton.Image = null;
            this.txtTableName.CustomButton.Location = new System.Drawing.Point(476, 1);
            this.txtTableName.CustomButton.Name = "";
            this.txtTableName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTableName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTableName.CustomButton.TabIndex = 1;
            this.txtTableName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTableName.CustomButton.UseSelectable = true;
            this.txtTableName.CustomButton.Visible = false;
            this.txtTableName.Lines = new string[0];
            this.txtTableName.Location = new System.Drawing.Point(128, 14);
            this.txtTableName.MaxLength = 32767;
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.PasswordChar = '\0';
            this.txtTableName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTableName.SelectedText = "";
            this.txtTableName.SelectionLength = 0;
            this.txtTableName.SelectionStart = 0;
            this.txtTableName.ShortcutsEnabled = true;
            this.txtTableName.Size = new System.Drawing.Size(498, 23);
            this.txtTableName.TabIndex = 1;
            this.txtTableName.UseSelectable = true;
            this.txtTableName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTableName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(11, 120);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(105, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Sufixo da coluna";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(11, 94);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(111, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Prefixo da coluna";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(11, 68);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(96, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Nome da linha";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(11, 42);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(108, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Nome do objeto";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(11, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(111, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nome da tabela*";
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageSettings.Controls.Add(this.groupBox4);
            this.tabPageSettings.Controls.Add(this.groupBox3);
            this.tabPageSettings.Controls.Add(this.groupBox2);
            this.tabPageSettings.HorizontalScrollbarBarColor = true;
            this.tabPageSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPageSettings.HorizontalScrollbarSize = 10;
            this.tabPageSettings.Location = new System.Drawing.Point(4, 38);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Size = new System.Drawing.Size(759, 473);
            this.tabPageSettings.TabIndex = 1;
            this.tabPageSettings.Text = "Configurações";
            this.tabPageSettings.VerticalScrollbarBarColor = true;
            this.tabPageSettings.VerticalScrollbarHighlightOnWheel = false;
            this.tabPageSettings.VerticalScrollbarSize = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.txtMethod);
            this.groupBox4.Controls.Add(this.lbCustomMethod);
            this.groupBox4.Controls.Add(this.chkCustomMethod);
            this.groupBox4.Location = new System.Drawing.Point(3, 312);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(750, 107);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Méodo Personalizado";
            // 
            // txtMethod
            // 
            this.txtMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtMethod.CustomButton.Image = null;
            this.txtMethod.CustomButton.Location = new System.Drawing.Point(671, 1);
            this.txtMethod.CustomButton.Name = "";
            this.txtMethod.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMethod.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMethod.CustomButton.TabIndex = 1;
            this.txtMethod.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMethod.CustomButton.UseSelectable = true;
            this.txtMethod.CustomButton.Visible = false;
            this.txtMethod.Lines = new string[0];
            this.txtMethod.Location = new System.Drawing.Point(39, 61);
            this.txtMethod.MaxLength = 32767;
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.PasswordChar = '\0';
            this.txtMethod.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMethod.SelectedText = "";
            this.txtMethod.SelectionLength = 0;
            this.txtMethod.SelectionStart = 0;
            this.txtMethod.ShortcutsEnabled = true;
            this.txtMethod.Size = new System.Drawing.Size(693, 23);
            this.txtMethod.TabIndex = 19;
            this.txtMethod.UseSelectable = true;
            this.txtMethod.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMethod.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbCustomMethod
            // 
            this.lbCustomMethod.AutoSize = true;
            this.lbCustomMethod.Location = new System.Drawing.Point(37, 40);
            this.lbCustomMethod.Name = "lbCustomMethod";
            this.lbCustomMethod.Size = new System.Drawing.Size(380, 19);
            this.lbCustomMethod.TabIndex = 3;
            this.lbCustomMethod.Text = "Método - Ex: myObject.@field = helper.Get<@type>(\"@field\");";
            // 
            // chkCustomMethod
            // 
            this.chkCustomMethod.AutoSize = true;
            this.chkCustomMethod.Location = new System.Drawing.Point(16, 23);
            this.chkCustomMethod.Name = "chkCustomMethod";
            this.chkCustomMethod.Size = new System.Drawing.Size(180, 15);
            this.chkCustomMethod.TabIndex = 18;
            this.chkCustomMethod.Text = "Utilizar método personalizado";
            this.chkCustomMethod.UseSelectable = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txtMethodExtension);
            this.groupBox3.Controls.Add(this.lbExtensionMethod);
            this.groupBox3.Controls.Add(this.chkCustomMethodExt);
            this.groupBox3.Controls.Add(this.chkDotNet);
            this.groupBox3.Location = new System.Drawing.Point(3, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(750, 127);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo de Conversão";
            // 
            // txtMethodExtension
            // 
            this.txtMethodExtension.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtMethodExtension.CustomButton.Image = null;
            this.txtMethodExtension.CustomButton.Location = new System.Drawing.Point(671, 1);
            this.txtMethodExtension.CustomButton.Name = "";
            this.txtMethodExtension.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMethodExtension.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMethodExtension.CustomButton.TabIndex = 1;
            this.txtMethodExtension.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMethodExtension.CustomButton.UseSelectable = true;
            this.txtMethodExtension.CustomButton.Visible = false;
            this.txtMethodExtension.Lines = new string[0];
            this.txtMethodExtension.Location = new System.Drawing.Point(39, 85);
            this.txtMethodExtension.MaxLength = 32767;
            this.txtMethodExtension.Name = "txtMethodExtension";
            this.txtMethodExtension.PasswordChar = '\0';
            this.txtMethodExtension.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMethodExtension.SelectedText = "";
            this.txtMethodExtension.SelectionLength = 0;
            this.txtMethodExtension.SelectionStart = 0;
            this.txtMethodExtension.ShortcutsEnabled = true;
            this.txtMethodExtension.Size = new System.Drawing.Size(693, 23);
            this.txtMethodExtension.TabIndex = 17;
            this.txtMethodExtension.UseSelectable = true;
            this.txtMethodExtension.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMethodExtension.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbExtensionMethod
            // 
            this.lbExtensionMethod.AutoSize = true;
            this.lbExtensionMethod.Location = new System.Drawing.Point(37, 64);
            this.lbExtensionMethod.Name = "lbExtensionMethod";
            this.lbExtensionMethod.Size = new System.Drawing.Size(179, 19);
            this.lbExtensionMethod.TabIndex = 2;
            this.lbExtensionMethod.Text = "Método de extensão - Ex: To";
            // 
            // chkCustomMethodExt
            // 
            this.chkCustomMethodExt.AutoSize = true;
            this.chkCustomMethodExt.Location = new System.Drawing.Point(16, 48);
            this.chkCustomMethodExt.Name = "chkCustomMethodExt";
            this.chkCustomMethodExt.Size = new System.Drawing.Size(149, 15);
            this.chkCustomMethodExt.TabIndex = 16;
            this.chkCustomMethodExt.Text = "Conversão customizada";
            this.chkCustomMethodExt.UseSelectable = true;
            // 
            // chkDotNet
            // 
            this.chkDotNet.AutoSize = true;
            this.chkDotNet.Location = new System.Drawing.Point(16, 26);
            this.chkDotNet.Name = "chkDotNet";
            this.chkDotNet.Size = new System.Drawing.Size(97, 15);
            this.chkDotNet.TabIndex = 0;
            this.chkDotNet.Text = "Conversão C#";
            this.chkDotNet.UseSelectable = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnConTest);
            this.groupBox2.Controls.Add(this.txtDatabase);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.txtLogin);
            this.groupBox2.Controls.Add(this.txtServer);
            this.groupBox2.Controls.Add(this.metroLabel9);
            this.groupBox2.Controls.Add(this.metroLabel8);
            this.groupBox2.Controls.Add(this.metroLabel7);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(752, 170);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configurações de conexão";
            // 
            // btnConTest
            // 
            this.btnConTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConTest.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnConTest.Location = new System.Drawing.Point(575, 131);
            this.btnConTest.Name = "btnConTest";
            this.btnConTest.Size = new System.Drawing.Size(157, 23);
            this.btnConTest.TabIndex = 15;
            this.btnConTest.Text = "Testar Conexão";
            this.btnConTest.UseSelectable = true;
            this.btnConTest.Click += new System.EventHandler(this.BtnConTest_Click);
            // 
            // txtDatabase
            // 
            this.txtDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtDatabase.CustomButton.Image = null;
            this.txtDatabase.CustomButton.Location = new System.Drawing.Point(622, 1);
            this.txtDatabase.CustomButton.Name = "";
            this.txtDatabase.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDatabase.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDatabase.CustomButton.TabIndex = 1;
            this.txtDatabase.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDatabase.CustomButton.UseSelectable = true;
            this.txtDatabase.CustomButton.Visible = false;
            this.txtDatabase.Lines = new string[0];
            this.txtDatabase.Location = new System.Drawing.Point(88, 102);
            this.txtDatabase.MaxLength = 32767;
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.PasswordChar = '\0';
            this.txtDatabase.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDatabase.SelectedText = "";
            this.txtDatabase.SelectionLength = 0;
            this.txtDatabase.SelectionStart = 0;
            this.txtDatabase.ShortcutsEnabled = true;
            this.txtDatabase.Size = new System.Drawing.Size(644, 23);
            this.txtDatabase.TabIndex = 14;
            this.txtDatabase.UseSelectable = true;
            this.txtDatabase.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDatabase.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(622, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(88, 76);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(644, 23);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtLogin.CustomButton.Image = null;
            this.txtLogin.CustomButton.Location = new System.Drawing.Point(622, 1);
            this.txtLogin.CustomButton.Name = "";
            this.txtLogin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLogin.CustomButton.TabIndex = 1;
            this.txtLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLogin.CustomButton.UseSelectable = true;
            this.txtLogin.CustomButton.Visible = false;
            this.txtLogin.Lines = new string[0];
            this.txtLogin.Location = new System.Drawing.Point(88, 50);
            this.txtLogin.MaxLength = 32767;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PasswordChar = '\0';
            this.txtLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLogin.SelectedText = "";
            this.txtLogin.SelectionLength = 0;
            this.txtLogin.SelectionStart = 0;
            this.txtLogin.ShortcutsEnabled = true;
            this.txtLogin.Size = new System.Drawing.Size(644, 23);
            this.txtLogin.TabIndex = 12;
            this.txtLogin.UseSelectable = true;
            this.txtLogin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLogin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtServer
            // 
            this.txtServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtServer.CustomButton.Image = null;
            this.txtServer.CustomButton.Location = new System.Drawing.Point(622, 1);
            this.txtServer.CustomButton.Name = "";
            this.txtServer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtServer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtServer.CustomButton.TabIndex = 1;
            this.txtServer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtServer.CustomButton.UseSelectable = true;
            this.txtServer.CustomButton.Visible = false;
            this.txtServer.Lines = new string[0];
            this.txtServer.Location = new System.Drawing.Point(88, 25);
            this.txtServer.MaxLength = 32767;
            this.txtServer.Name = "txtServer";
            this.txtServer.PasswordChar = '\0';
            this.txtServer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtServer.SelectedText = "";
            this.txtServer.SelectionLength = 0;
            this.txtServer.SelectionStart = 0;
            this.txtServer.ShortcutsEnabled = true;
            this.txtServer.Size = new System.Drawing.Size(644, 23);
            this.txtServer.TabIndex = 11;
            this.txtServer.UseSelectable = true;
            this.txtServer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtServer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(16, 105);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(51, 19);
            this.metroLabel9.TabIndex = 3;
            this.metroLabel9.Text = "Banco*";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(16, 79);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(50, 19);
            this.metroLabel8.TabIndex = 2;
            this.metroLabel8.Text = "Senha*";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(16, 53);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(47, 19);
            this.metroLabel7.TabIndex = 1;
            this.metroLabel7.Text = "Login*";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(16, 27);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(64, 19);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Servidor*";
            // 
            // tabPageQuery
            // 
            this.tabPageQuery.Controls.Add(this.metroPanel1);
            this.tabPageQuery.HorizontalScrollbarBarColor = true;
            this.tabPageQuery.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPageQuery.HorizontalScrollbarSize = 10;
            this.tabPageQuery.Location = new System.Drawing.Point(4, 38);
            this.tabPageQuery.Name = "tabPageQuery";
            this.tabPageQuery.Size = new System.Drawing.Size(759, 473);
            this.tabPageQuery.TabIndex = 2;
            this.tabPageQuery.Text = "Consulta";
            this.tabPageQuery.VerticalScrollbarBarColor = true;
            this.tabPageQuery.VerticalScrollbarHighlightOnWheel = false;
            this.tabPageQuery.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.txtUserQuery);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(759, 473);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // txtUserQuery
            // 
            this.txtUserQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtUserQuery.CustomButton.Image = null;
            this.txtUserQuery.CustomButton.Location = new System.Drawing.Point(285, 1);
            this.txtUserQuery.CustomButton.Name = "";
            this.txtUserQuery.CustomButton.Size = new System.Drawing.Size(453, 453);
            this.txtUserQuery.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserQuery.CustomButton.TabIndex = 1;
            this.txtUserQuery.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserQuery.CustomButton.UseSelectable = true;
            this.txtUserQuery.CustomButton.Visible = false;
            this.txtUserQuery.Lines = new string[0];
            this.txtUserQuery.Location = new System.Drawing.Point(17, 15);
            this.txtUserQuery.MaxLength = 32767;
            this.txtUserQuery.Multiline = true;
            this.txtUserQuery.Name = "txtUserQuery";
            this.txtUserQuery.PasswordChar = '\0';
            this.txtUserQuery.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserQuery.SelectedText = "";
            this.txtUserQuery.SelectionLength = 0;
            this.txtUserQuery.SelectionStart = 0;
            this.txtUserQuery.ShortcutsEnabled = true;
            this.txtUserQuery.Size = new System.Drawing.Size(739, 455);
            this.txtUserQuery.TabIndex = 2;
            this.txtUserQuery.UseSelectable = true;
            this.txtUserQuery.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserQuery.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tabPageReplace
            // 
            this.tabPageReplace.Controls.Add(this.metroPanel2);
            this.tabPageReplace.HorizontalScrollbarBarColor = true;
            this.tabPageReplace.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPageReplace.HorizontalScrollbarSize = 10;
            this.tabPageReplace.Location = new System.Drawing.Point(4, 38);
            this.tabPageReplace.Name = "tabPageReplace";
            this.tabPageReplace.Size = new System.Drawing.Size(759, 473);
            this.tabPageReplace.TabIndex = 3;
            this.tabPageReplace.Text = "Substiuição";
            this.tabPageReplace.VerticalScrollbarBarColor = true;
            this.tabPageReplace.VerticalScrollbarHighlightOnWheel = false;
            this.tabPageReplace.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.listReplace);
            this.metroPanel2.Controls.Add(this.btnResultReplace);
            this.metroPanel2.Controls.Add(this.txtMethodToReplace);
            this.metroPanel2.Controls.Add(this.metroLabel11);
            this.metroPanel2.Controls.Add(this.metroLabel10);
            this.metroPanel2.Controls.Add(this.txtReplace);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(759, 473);
            this.metroPanel2.TabIndex = 4;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // listReplace
            // 
            this.listReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listReplace.FormattingEnabled = true;
            this.listReplace.Location = new System.Drawing.Point(18, 176);
            this.listReplace.Name = "listReplace";
            this.listReplace.Size = new System.Drawing.Size(730, 290);
            this.listReplace.TabIndex = 23;
            // 
            // btnResultReplace
            // 
            this.btnResultReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResultReplace.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnResultReplace.Location = new System.Drawing.Point(641, 141);
            this.btnResultReplace.Name = "btnResultReplace";
            this.btnResultReplace.Size = new System.Drawing.Size(107, 23);
            this.btnResultReplace.TabIndex = 22;
            this.btnResultReplace.Text = "Executar";
            this.btnResultReplace.UseSelectable = true;
            this.btnResultReplace.Click += new System.EventHandler(this.btnResultReplace_Click);
            // 
            // txtMethodToReplace
            // 
            this.txtMethodToReplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtMethodToReplace.CustomButton.Image = null;
            this.txtMethodToReplace.CustomButton.Location = new System.Drawing.Point(595, 1);
            this.txtMethodToReplace.CustomButton.Name = "";
            this.txtMethodToReplace.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMethodToReplace.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMethodToReplace.CustomButton.TabIndex = 1;
            this.txtMethodToReplace.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMethodToReplace.CustomButton.UseSelectable = true;
            this.txtMethodToReplace.CustomButton.Visible = false;
            this.txtMethodToReplace.Lines = new string[0];
            this.txtMethodToReplace.Location = new System.Drawing.Point(18, 141);
            this.txtMethodToReplace.MaxLength = 32767;
            this.txtMethodToReplace.Name = "txtMethodToReplace";
            this.txtMethodToReplace.PasswordChar = '\0';
            this.txtMethodToReplace.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMethodToReplace.SelectedText = "";
            this.txtMethodToReplace.SelectionLength = 0;
            this.txtMethodToReplace.SelectionStart = 0;
            this.txtMethodToReplace.ShortcutsEnabled = true;
            this.txtMethodToReplace.Size = new System.Drawing.Size(617, 23);
            this.txtMethodToReplace.TabIndex = 21;
            this.txtMethodToReplace.UseSelectable = true;
            this.txtMethodToReplace.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMethodToReplace.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(18, 120);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(230, 19);
            this.metroLabel11.TabIndex = 20;
            this.metroLabel11.Text = "Ex: public readonly static string @field";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(18, 14);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(202, 19);
            this.metroLabel10.TabIndex = 3;
            this.metroLabel10.Text = "Ex: Column1, Column2, Column3";
            // 
            // txtReplace
            // 
            this.txtReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtReplace.CustomButton.Image = null;
            this.txtReplace.CustomButton.Location = new System.Drawing.Point(656, 1);
            this.txtReplace.CustomButton.Name = "";
            this.txtReplace.CustomButton.Size = new System.Drawing.Size(73, 73);
            this.txtReplace.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtReplace.CustomButton.TabIndex = 1;
            this.txtReplace.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtReplace.CustomButton.UseSelectable = true;
            this.txtReplace.CustomButton.Visible = false;
            this.txtReplace.Lines = new string[0];
            this.txtReplace.Location = new System.Drawing.Point(18, 36);
            this.txtReplace.MaxLength = 32767;
            this.txtReplace.Multiline = true;
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.PasswordChar = '\0';
            this.txtReplace.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReplace.SelectedText = "";
            this.txtReplace.SelectionLength = 0;
            this.txtReplace.SelectionStart = 0;
            this.txtReplace.ShortcutsEnabled = true;
            this.txtReplace.Size = new System.Drawing.Size(730, 75);
            this.txtReplace.TabIndex = 2;
            this.txtReplace.UseSelectable = true;
            this.txtReplace.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtReplace.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DataTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 630);
            this.Controls.Add(this.fromToTabControl);
            this.Controls.Add(this.btnCopyAll);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.cmdOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataTableForm";
            this.Text = "DataTable To";
            this.fromToTabControl.ResumeLayout(false);
            this.tabPageFromTo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageSettings.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPageQuery.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.tabPageReplace.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton cmdOk;
        private MetroFramework.Controls.MetroButton btnCopy;
        private MetroFramework.Controls.MetroButton btnCopyAll;
        private MetroFramework.Controls.MetroTabControl fromToTabControl;
        private MetroFramework.Controls.MetroTabPage tabPageFromTo;
        private MetroFramework.Controls.MetroTabPage tabPageSettings;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtColumnSufix;
        private MetroFramework.Controls.MetroTextBox txtColumnPrefix;
        private MetroFramework.Controls.MetroTextBox txtRowName;
        private MetroFramework.Controls.MetroTextBox txtObjectName;
        private MetroFramework.Controls.MetroTextBox txtTableName;
        private MetroFramework.Controls.MetroButton btnResults;
        private MetroFramework.Controls.MetroCheckBox chkValidation;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox txtDatabase;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtLogin;
        private MetroFramework.Controls.MetroTextBox txtServer;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroCheckBox chkCustomMethodExt;
        private MetroFramework.Controls.MetroCheckBox chkDotNet;
        private MetroFramework.Controls.MetroButton btnConTest;
        private MetroFramework.Controls.MetroLabel lbExtensionMethod;
        private MetroFramework.Controls.MetroTextBox txtMethodExtension;
        private MetroFramework.Controls.MetroCheckBox chkCustomMethod;
        private MetroFramework.Controls.MetroTextBox txtMethod;
        private MetroFramework.Controls.MetroLabel lbCustomMethod;
        private System.Windows.Forms.ListBox listResult;
        private MetroFramework.Controls.MetroTabPage tabPageQuery;
        private MetroFramework.Controls.MetroCheckBox chkUseQuery;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtUserQuery;
        private MetroFramework.Controls.MetroTabPage tabPageReplace;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTextBox txtReplace;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.ListBox listReplace;
        private MetroFramework.Controls.MetroButton btnResultReplace;
        private MetroFramework.Controls.MetroTextBox txtMethodToReplace;
        private MetroFramework.Controls.MetroLabel metroLabel11;
    }
}

