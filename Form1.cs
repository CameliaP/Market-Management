using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Market_Management
{
	public partial class AuthForm : Form
	{
		SqlConnectionStringBuilder ConnString;
		// for saving settings

		public AuthForm()
		{
			InitializeComponent();
			// initialize connection string
			ConnString = new SqlConnectionStringBuilder();
			ConnString.ApplicationName = "Market Management";
			ConnString.DataSource = "KINDER\\SQLSTYDER";
			// load pass if it was saved last time
			if (Properties.Settings.Default.PassSaved) 
			{
				PassTextBox.Text = Properties.Settings.Default.Password;
				MemPassCheckBox.Checked = true;
			}
			// try to load logins if trey were saved 
			try
			{
				if (Properties.Settings.Default.Logins.Count!=0)
					foreach(string login in Properties.Settings.Default.Logins)
						LoginComboBox.Items.Add(login);
				LoginComboBox.SelectedIndex=LoginComboBox.Items.Count-1;
			}
			// if logins were not saved, create new empty collection of them <-- this should work only ONE TIME (!) after installation
			catch(NullReferenceException) 
			{
				Properties.Settings.Default.Logins = new StringCollection();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void LogInButton_Click(object sender, EventArgs e)
		{
			// check if login is empty
			if (LoginComboBox.Text.Equals(String.Empty)) 
			{
				MessageBox.Show("Введите логин!", "Вход в систему", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			// checking if login/pass valid by opening connection
			try 
			{
				ConnString.UserID = LoginComboBox.Text;
				ConnString.Password = PassTextBox.Text;
				SqlConnection conn = new SqlConnection(ConnString.ConnectionString);
				conn.Open();
				conn.Close();
			}
			// if login/pass invalid or connection lost
			catch (SqlException exc)
			{
			    MessageBox.Show(exc.Message, "Вход в систему", MessageBoxButtons.OK, MessageBoxIcon.Error);
			    return;
			}
			MessageBox.Show("Успешно!", "Вход в систему", MessageBoxButtons.OK, MessageBoxIcon.Information);
			// remember pass if needed
			if (MemPassCheckBox.Checked) 
			{
				Properties.Settings.Default.Password = PassTextBox.Text; 
				Properties.Settings.Default.PassSaved = true;
				if (Properties.Settings.Default.Logins.Contains(LoginComboBox.Text))
					Properties.Settings.Default.Logins.Remove(LoginComboBox.Text);
				Properties.Settings.Default.Logins.Add(LoginComboBox.Text);
			}
			// delete saved pass otherwise
			else
			{
				Properties.Settings.Default.Password = string.Empty;
				Properties.Settings.Default.PassSaved = false;
			}
			// save all the logins that successfully logined
			if (!Properties.Settings.Default.Logins.Contains(LoginComboBox.Text))
				Properties.Settings.Default.Logins.Add(LoginComboBox.Text);
			Properties.Settings.Default.Save();
		}
	}
}
