namespace DataTableTo.UI
{
    partial class DataTableForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageProcess = new System.Windows.Forms.TabPage();
            this.tabPageConfiuration = new System.Windows.Forms.TabPage();
            this.cmdOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtColumnPrefix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listResult = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPageProcess.SuspendLayout();
            this.tabPageConfiuration.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageProcess);
            this.tabControl1.Controls.Add(this.tabPageConfiuration);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(623, 394);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageProcess
            // 
            this.tabPageProcess.Controls.Add(this.groupBox1);
            this.tabPageProcess.Controls.Add(this.listResult);
            this.tabPageProcess.Location = new System.Drawing.Point(4, 22);
            this.tabPageProcess.Name = "tabPageProcess";
            this.tabPageProcess.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProcess.Size = new System.Drawing.Size(615, 368);
            this.tabPageProcess.TabIndex = 0;
            this.tabPageProcess.Text = "De Para";
            this.tabPageProcess.UseVisualStyleBackColor = true;
            // 
            // tabPageConfiuration
            // 
            this.tabPageConfiuration.Controls.Add(this.txtDatabase);
            this.tabPageConfiuration.Controls.Add(this.txtPassword);
            this.tabPageConfiuration.Controls.Add(this.txtLogin);
            this.tabPageConfiuration.Controls.Add(this.txtServer);
            this.tabPageConfiuration.Controls.Add(this.label6);
            this.tabPageConfiuration.Controls.Add(this.label5);
            this.tabPageConfiuration.Controls.Add(this.label4);
            this.tabPageConfiuration.Controls.Add(this.label3);
            this.tabPageConfiuration.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfiuration.Name = "tabPageConfiuration";
            this.tabPageConfiuration.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfiuration.Size = new System.Drawing.Size(615, 368);
            this.tabPageConfiuration.TabIndex = 1;
            this.tabPageConfiuration.Text = "Configuração";
            this.tabPageConfiuration.UseVisualStyleBackColor = true;
            // 
            // cmdOk
            // 
            this.cmdOk.Location = new System.Drawing.Point(14, 402);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(75, 23);
            this.cmdOk.TabIndex = 4;
            this.cmdOk.Text = "OK";
            this.cmdOk.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnExecute);
            this.groupBox1.Controls.Add(this.txtTableName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtColumnPrefix);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(8, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 78);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecute.Location = new System.Drawing.Point(507, 19);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 3;
            this.btnExecute.Text = "Executar";
            this.btnExecute.UseVisualStyleBackColor = true;
            // 
            // txtTableName
            // 
            this.txtTableName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTableName.Location = new System.Drawing.Point(117, 19);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(374, 20);
            this.txtTableName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome da Tabela";
            // 
            // txtColumnPrefix
            // 
            this.txtColumnPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtColumnPrefix.Location = new System.Drawing.Point(117, 42);
            this.txtColumnPrefix.Name = "txtColumnPrefix";
            this.txtColumnPrefix.Size = new System.Drawing.Size(374, 20);
            this.txtColumnPrefix.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prefixo da Coluna";
            // 
            // listResult
            // 
            this.listResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listResult.FormattingEnabled = true;
            this.listResult.Location = new System.Drawing.Point(7, 95);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(600, 264);
            this.listResult.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Servidor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Login";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Senha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Banco";
            // 
            // txtServer
            // 
            this.txtServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServer.Location = new System.Drawing.Point(83, 16);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(494, 20);
            this.txtServer.TabIndex = 5;
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogin.Location = new System.Drawing.Point(83, 42);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(494, 20);
            this.txtLogin.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(83, 68);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(494, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDatabase.Location = new System.Drawing.Point(83, 96);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(494, 20);
            this.txtDatabase.TabIndex = 8;
            // 
            // DataTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 439);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.tabControl1);
            this.Name = "DataTableForm";
            this.Text = "DataTableForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPageProcess.ResumeLayout(false);
            this.tabPageConfiuration.ResumeLayout(false);
            this.tabPageConfiuration.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageProcess;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtColumnPrefix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listResult;
        private System.Windows.Forms.TabPage tabPageConfiuration;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdOk;
    }
}