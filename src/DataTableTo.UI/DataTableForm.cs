using System;
using DataTableTo.Domain.Model;
using DataTableTo.Infra.Repositories;
using System.Windows.Forms;
using DataTableTo.Domain.Services;
using DataTableTo.Domain.Model.FromToCreation.DotNetPatern;
using System.Text;
using DataTableTo.Domain.Model.FromToCreation.GenericPatern;

namespace DataTableTo.UI
{
    public partial class DataTableForm : Form
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
            FillControls();
        }

        private void MessageError(Exception ex)
        {
            MessageBox.Show(ex.Message, "Mensagem do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FillClass()
        {
            _userData.Server = txtServer.Text;
            _userData.Login = txtLogin.Text;
            _userData.Password = txtPassword.Text;
            _userData.Database = txtDatabase.Text;
            _userData.CustomMehtodExtension = chkCustomMethodExt.Checked;
            _userData.MethodExtension = txtMethodExtension.Text;
            _userData.WithoutValidation = chkValidation.Checked;

            _userData.TableName = txtTableName.Text;
            _userData.ObjectName = txtObjectName.Text;
            _userData.RowName = txtRowName.Text;
            _userData.ColumnPrefix = txtColumnPrefix.Text;
            _userData.ColumnSufix = txtColumnSufix.Text;
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
            SetContols();
        }

        private void FillResults()
        {
            FillClass();
            _repository.FillTableData(_userData);
            _service.CreateFromTo(new CreatorFromToCustom(), _userData);
            _service.CreateFromTo(new CreatorFromToDotNet(), _userData);
            _service.CreateFromTo(new CreatorFromTo(), _userData);
            listResult.DataSource = _userData.Results;
        }

        private void SetContols()
        {
            chkDotNet.Checked = !chkCustomMethodExt.Checked;
            lbExtensionMethod.Visible = chkCustomMethodExt.Checked;
            txtMethodExtension.Visible = chkCustomMethodExt.Checked;
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

        private void chkCustomMethodExt_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SetContols();
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
    }
}
