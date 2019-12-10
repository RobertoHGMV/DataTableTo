using DataTableTo.Domain.Model;
using DataTableTo.Domain.Model.FromToCreation.DotNetPatern;
using DataTableTo.Domain.Model.FromToCreation.GenericPatern;
using DataTableTo.Domain.Model.FromToCreation.MethodPatern;
using DataTableTo.Domain.Services;
using DataTableTo.Infra.Repositories;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTableTo.MetroUI
{
    public partial class DataTableForm : MetroFramework.Forms.MetroForm
    {
        private readonly IUserDataRepository _repository;
        private readonly IFromToService _service;
        private UserData _userData;

        public DataTableForm()
        {
            InitializeComponent();

            _repository = new UserDataRepository();
            _service = new FromToService();
            _userData = new UserData();
            chkDotNet.Enabled = false;
            FillControls();
            SignEvents();
        }

        private void SignEvents()
        {
            chkCustomMethodExt.CheckedChanged += chkCustomMethodExt_CheckedChanged;
            chkCustomMethod.CheckedChanged += chkCustomMethod_CheckedChanged;
        }

        private void MessageSuccessfull(string message)
        {
            MetroMessageBox.Show(this, message, "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MessageError(Exception ex)
        {
            MetroMessageBox.Show(this, ex.Message, "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FillClass()
        {
            _userData.Server = txtServer.Text.Trim();
            _userData.Login = txtLogin.Text.Trim();
            _userData.Password = txtPassword.Text.Trim();
            _userData.Database = txtDatabase.Text.Trim();
            _userData.CustomMehtodExtension = chkCustomMethodExt.Checked;
            _userData.MethodExtension = txtMethodExtension.Text.Trim();
            _userData.CustomMethod = chkCustomMethod.Checked;
            _userData.Method = txtMethod.Text.Trim();
            _userData.WithoutValidation = chkValidation.Checked;
            _userData.UseQuery = chkUseQuery.Checked;
            _userData.UserQuery = txtUserQuery.Text;

            _userData.TableName = txtTableName.Text.Trim();
            _userData.ObjectName = !string.IsNullOrEmpty(txtObjectName.Text) ? txtObjectName.Text.Trim() + "." : string.Empty;
            _userData.RowName = txtRowName.Text.Trim();
            _userData.ColumnPrefix = txtColumnPrefix.Text.Trim();
            _userData.ColumnSufix = txtColumnSufix.Text.Trim();
        }

        private void FillControls()
        {
            listResult.DataSource = _userData.Results;
            txtServer.Text = _userData.Server;
            txtLogin.Text = _userData.Login;
            txtPassword.Text = _userData.Password;
            txtDatabase.Text = _userData.Database;
            txtMethodExtension.Text = _userData.MethodExtension;
            chkCustomMethodExt.Checked = _userData.CustomMehtodExtension;
            txtMethod.Text = _userData.Method;
            chkCustomMethod.Checked = _userData.CustomMethod;
            chkUseQuery.Checked = _userData.UseQuery;
            txtUserQuery.Text = _userData.UserQuery;
            SetContolsCustomExtension();
            SetControlsMethod();
        }

        private void FillResults()
        {
            FillClassAndValid();

            if (_userData.UseQuery)
                _repository.FillTableDataByDataTable(_userData);
            else
                _repository.FillTableData(_userData);

            CreateFromTo();
            listResult.DataSource = _userData.Results;
        }

        private void FillClassAndValid()
        {
            FillClass();
            _userData.ValidateConfiguration();
            _userData.ValidateParamsToFillResults();
        }

        private void CreateFromTo()
        {
            _service.CreateFromTo(new CreatorFromToCustom(), _userData);
            _service.CreateFromTo(new CreatorFromToDotNet(), _userData);
            _service.CreateFromTo(new CreatorFromTo(), _userData);
            _service.CreateFromTo(new CreatorFromToMethod(), _userData);
        }

        #region ResultsReplace

        private void ResultsReplace()
        {

        }

        #endregion

        private void SetContolsCustomExtension()
        {
            chkDotNet.Checked = !chkCustomMethodExt.Checked;
            lbExtensionMethod.Enabled = chkCustomMethodExt.Checked;
            txtMethodExtension.Enabled = chkCustomMethodExt.Checked;
        }

        private void SetControlsMethod()
        {
            lbCustomMethod.Enabled = txtMethod.Enabled = chkCustomMethod.Checked;
        }

        private void Copy()
        {
            Clipboard.SetText(listResult.Text);
        }

        private void CopyAll()
        {
            var sb = new StringBuilder();

            foreach (string item in listResult.Items)
                sb.AppendLine(item);

            Clipboard.SetText(sb.ToString());
        }

        private void chkCustomMethodExt_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SetContolsCustomExtension();
            }
            catch (Exception ex)
            {
                MessageError(ex);
            }
        }

        private void chkCustomMethod_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SetControlsMethod();
            }
            catch (Exception ex)
            {
                MessageError(ex);
            }
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            try
            {
                FillResults();
            }
            catch (Exception ex)
            {
                MessageError(ex);
            }
        }

        private void btnResultReplace_Click(object sender, EventArgs e)
        {
            try
            {
                ResultsReplace();
            }
            catch (Exception ex)
            {
                MessageError(ex);
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Copy();
            }
            catch (Exception ex)
            {
                MessageError(ex);
            }
        }

        private void btnCopyAll_Click(object sender, EventArgs e)
        {
            try
            {
                CopyAll();
            }
            catch (Exception ex)
            {
                MessageError(ex);
            }
        }

        private void BtnConTest_Click(object sender, EventArgs e)
        {
            try
            {
                FillClass();
                _userData.ValidateConfiguration();
                if (_repository.IsConnectedSqlServer(_userData))
                    MessageSuccessfull("Conexão realizada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageError(ex);
            }
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageError(ex);
            }
        }
    }
}
