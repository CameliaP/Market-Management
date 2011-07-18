namespace Market_Management
{
	partial class AuthForm
	{
		/// <summary>
		/// Требуется переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Обязательный метод для поддержки конструктора - не изменяйте
		/// содержимое данного метода при помощи редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.LoginComboBox = new System.Windows.Forms.ComboBox();
			this.PassTextBox = new System.Windows.Forms.TextBox();
			this.MemPassCheckBox = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.CancelButton = new System.Windows.Forms.Button();
			this.LogInButton = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.RoleComboBox = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 127);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Логин: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 177);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Пароль: ";
			// 
			// LoginComboBox
			// 
			this.LoginComboBox.FormattingEnabled = true;
			this.LoginComboBox.Location = new System.Drawing.Point(129, 124);
			this.LoginComboBox.Name = "LoginComboBox";
			this.LoginComboBox.Size = new System.Drawing.Size(166, 21);
			this.LoginComboBox.TabIndex = 3;
			// 
			// PassTextBox
			// 
			this.PassTextBox.Location = new System.Drawing.Point(129, 174);
			this.PassTextBox.Name = "PassTextBox";
			this.PassTextBox.PasswordChar = '*';
			this.PassTextBox.Size = new System.Drawing.Size(166, 20);
			this.PassTextBox.TabIndex = 4;
			// 
			// MemPassCheckBox
			// 
			this.MemPassCheckBox.AutoSize = true;
			this.MemPassCheckBox.Location = new System.Drawing.Point(129, 211);
			this.MemPassCheckBox.Name = "MemPassCheckBox";
			this.MemPassCheckBox.Size = new System.Drawing.Size(121, 17);
			this.MemPassCheckBox.TabIndex = 5;
			this.MemPassCheckBox.Text = "Запомнить пароль";
			this.MemPassCheckBox.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label3.Location = new System.Drawing.Point(12, 231);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(319, 2);
			this.label3.TabIndex = 6;
			// 
			// CancelButton
			// 
			this.CancelButton.Location = new System.Drawing.Point(239, 249);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(92, 23);
			this.CancelButton.TabIndex = 7;
			this.CancelButton.Text = "Отмена";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// LogInButton
			// 
			this.LogInButton.Location = new System.Drawing.Point(141, 249);
			this.LogInButton.Name = "LogInButton";
			this.LogInButton.Size = new System.Drawing.Size(92, 23);
			this.LogInButton.TabIndex = 8;
			this.LogInButton.Text = "Войти";
			this.LogInButton.UseVisualStyleBackColor = true;
			this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Market_Management.Properties.Resources.LogoBig;
			this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(345, 112);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(29, 152);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Роль:";
			// 
			// RoleComboBox
			// 
			this.RoleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.RoleComboBox.FormattingEnabled = true;
			this.RoleComboBox.Items.AddRange(new object[] {
            "HR"});
			this.RoleComboBox.Location = new System.Drawing.Point(129, 149);
			this.RoleComboBox.Name = "RoleComboBox";
			this.RoleComboBox.Size = new System.Drawing.Size(166, 21);
			this.RoleComboBox.TabIndex = 10;
			// 
			// AuthForm
			// 
			this.AcceptButton = this.LogInButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(343, 284);
			this.Controls.Add(this.RoleComboBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.LogInButton);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.MemPassCheckBox);
			this.Controls.Add(this.PassTextBox);
			this.Controls.Add(this.LoginComboBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AuthForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Авторизация - Marketing Management";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox LoginComboBox;
		private System.Windows.Forms.TextBox PassTextBox;
		private System.Windows.Forms.CheckBox MemPassCheckBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.Button LogInButton;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox RoleComboBox;
	}
}

