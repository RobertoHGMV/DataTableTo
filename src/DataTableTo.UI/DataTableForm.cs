using System;
using DataTableTo.Domain.Model;
using DataTableTo.Infra.Repositories;
using System.Windows.Forms;

namespace DataTableTo.UI
{
    public partial class DataTableForm : Form
    {
        private readonly IUserDataRepository _repository;
        private UserData _userData;

        public DataTableForm()
        {
            InitializeComponent();

            _repository = new UserDataRepository();
            _userData = new UserData();
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

            _userData.TableName = txtTableName.Text;
            _userData.ColumnPrefix = txtColumnPrefix.Text;
        }

        private void FillControls()
        {
            txtServer.Text = _userData.Server;
            txtLogin.Text = _userData.Login;
            txtPassword.Text = _userData.Password;
            txtDatabase.Text = _userData.Database;
        }

        private void FillResults()
        {
            FillClass();
            _repository.FillResults(_userData);
            listResult.DataSource = _userData.Results;
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
    }
}
