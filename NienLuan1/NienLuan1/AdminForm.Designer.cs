namespace NienLuan1
{
    partial class AdminForm
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
            DataGridView gridView;
            mondayColumn = new DataGridViewTextBoxColumn();
            tuesdayColumn = new DataGridViewTextBoxColumn();
            wednesdayColumn = new DataGridViewTextBoxColumn();
            thursdayColumn = new DataGridViewTextBoxColumn();
            fridayColumn = new DataGridViewTextBoxColumn();
            saturdayColumn = new DataGridViewTextBoxColumn();
            sundayColumn = new DataGridViewTextBoxColumn();
            metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            newPassword = new MetroSet_UI.Controls.MetroSetLabel();
            newUsername = new MetroSet_UI.Controls.MetroSetLabel();
            txtNewPassword = new TextBox();
            txtNewUsername = new TextBox();
            plusAccountBtn = new MetroSet_UI.Controls.MetroSetButton();
            logoutBtn = new MetroSet_UI.Controls.MetroSetButton();
            gridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            SuspendLayout();
            // 
            // gridView
            // 
            gridView.AllowUserToAddRows = false;
            gridView.AllowUserToDeleteRows = false;
            gridView.AllowUserToResizeColumns = false;
            gridView.AllowUserToResizeRows = false;
            gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridView.Columns.AddRange(new DataGridViewColumn[] { mondayColumn, tuesdayColumn, wednesdayColumn, thursdayColumn, fridayColumn, saturdayColumn, sundayColumn });
            gridView.Location = new Point(374, 48);
            gridView.Name = "gridView";
            gridView.RowHeadersWidth = 51;
            gridView.RowTemplate.Height = 29;
            gridView.Size = new Size(926, 37);
            gridView.TabIndex = 14;
            // 
            // mondayColumn
            // 
            mondayColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            mondayColumn.HeaderText = "Monday";
            mondayColumn.MinimumWidth = 6;
            mondayColumn.Name = "mondayColumn";
            mondayColumn.Width = 118;
            // 
            // tuesdayColumn
            // 
            tuesdayColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tuesdayColumn.HeaderText = "Tuesday";
            tuesdayColumn.MinimumWidth = 6;
            tuesdayColumn.Name = "tuesdayColumn";
            tuesdayColumn.Width = 123;
            // 
            // wednesdayColumn
            // 
            wednesdayColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            wednesdayColumn.HeaderText = "Wednesday";
            wednesdayColumn.MinimumWidth = 6;
            wednesdayColumn.Name = "wednesdayColumn";
            wednesdayColumn.Width = 156;
            // 
            // thursdayColumn
            // 
            thursdayColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            thursdayColumn.HeaderText = "Thursday";
            thursdayColumn.MinimumWidth = 6;
            thursdayColumn.Name = "thursdayColumn";
            thursdayColumn.Width = 130;
            // 
            // fridayColumn
            // 
            fridayColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            fridayColumn.HeaderText = "Friday";
            fridayColumn.MinimumWidth = 6;
            fridayColumn.Name = "fridayColumn";
            fridayColumn.Width = 101;
            // 
            // saturdayColumn
            // 
            saturdayColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            saturdayColumn.HeaderText = "Saturday";
            saturdayColumn.MinimumWidth = 6;
            saturdayColumn.Name = "saturdayColumn";
            saturdayColumn.Width = 128;
            // 
            // sundayColumn
            // 
            sundayColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            sundayColumn.HeaderText = "Sunday";
            sundayColumn.MinimumWidth = 6;
            sundayColumn.Name = "sundayColumn";
            sundayColumn.Width = 115;
            // 
            // metroSetControlBox1
            // 
            metroSetControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            metroSetControlBox1.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            metroSetControlBox1.CloseHoverForeColor = Color.White;
            metroSetControlBox1.CloseNormalForeColor = Color.Gray;
            metroSetControlBox1.DisabledForeColor = Color.DimGray;
            metroSetControlBox1.IsDerivedStyle = true;
            metroSetControlBox1.Location = new Point(1204, -1);
            metroSetControlBox1.MaximizeBox = true;
            metroSetControlBox1.MaximizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroSetControlBox1.MaximizeHoverForeColor = Color.Gray;
            metroSetControlBox1.MaximizeNormalForeColor = Color.Gray;
            metroSetControlBox1.MinimizeBox = true;
            metroSetControlBox1.MinimizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroSetControlBox1.MinimizeHoverForeColor = Color.Gray;
            metroSetControlBox1.MinimizeNormalForeColor = Color.Gray;
            metroSetControlBox1.Name = "metroSetControlBox1";
            metroSetControlBox1.Size = new Size(100, 25);
            metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Light;
            metroSetControlBox1.StyleManager = null;
            metroSetControlBox1.TabIndex = 0;
            metroSetControlBox1.Text = "metroSetControlBox1";
            metroSetControlBox1.ThemeAuthor = "Narwin";
            metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // metroSetLabel1
            // 
            metroSetLabel1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            metroSetLabel1.IsDerivedStyle = true;
            metroSetLabel1.Location = new Point(15, 105);
            metroSetLabel1.Name = "metroSetLabel1";
            metroSetLabel1.Size = new Size(85, 26);
            metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel1.StyleManager = null;
            metroSetLabel1.TabIndex = 1;
            metroSetLabel1.Text = "Accounts";
            metroSetLabel1.ThemeAuthor = "Narwin";
            metroSetLabel1.ThemeName = "MetroLite";
            // 
            // newPassword
            // 
            newPassword.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            newPassword.IsDerivedStyle = true;
            newPassword.Location = new Point(14, 184);
            newPassword.Name = "newPassword";
            newPassword.Size = new Size(94, 32);
            newPassword.Style = MetroSet_UI.Enums.Style.Light;
            newPassword.StyleManager = null;
            newPassword.TabIndex = 11;
            newPassword.Text = "Password";
            newPassword.ThemeAuthor = "Narwin";
            newPassword.ThemeName = "MetroLite";
            // 
            // newUsername
            // 
            newUsername.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            newUsername.IsDerivedStyle = true;
            newUsername.Location = new Point(14, 140);
            newUsername.Name = "newUsername";
            newUsername.Size = new Size(94, 32);
            newUsername.Style = MetroSet_UI.Enums.Style.Light;
            newUsername.StyleManager = null;
            newUsername.TabIndex = 10;
            newUsername.Text = "Username";
            newUsername.ThemeAuthor = "Narwin";
            newUsername.ThemeName = "MetroLite";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(114, 184);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(230, 32);
            txtNewPassword.TabIndex = 9;
            txtNewPassword.KeyDown += txtNewPassword_KeyDown;
            // 
            // txtNewUsername
            // 
            txtNewUsername.Location = new Point(114, 140);
            txtNewUsername.Name = "txtNewUsername";
            txtNewUsername.Size = new Size(230, 32);
            txtNewUsername.TabIndex = 8;
            txtNewUsername.KeyDown += txtNewUsername_KeyDown;
            // 
            // plusAccountBtn
            // 
            plusAccountBtn.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            plusAccountBtn.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            plusAccountBtn.DisabledForeColor = Color.Gray;
            plusAccountBtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            plusAccountBtn.HoverBorderColor = Color.FromArgb(95, 207, 255);
            plusAccountBtn.HoverColor = Color.FromArgb(95, 207, 255);
            plusAccountBtn.HoverTextColor = Color.White;
            plusAccountBtn.IsDerivedStyle = true;
            plusAccountBtn.Location = new Point(293, 235);
            plusAccountBtn.Name = "plusAccountBtn";
            plusAccountBtn.NormalBorderColor = Color.FromArgb(65, 177, 225);
            plusAccountBtn.NormalColor = Color.FromArgb(65, 177, 225);
            plusAccountBtn.NormalTextColor = Color.White;
            plusAccountBtn.PressBorderColor = Color.FromArgb(35, 147, 195);
            plusAccountBtn.PressColor = Color.FromArgb(35, 147, 195);
            plusAccountBtn.PressTextColor = Color.White;
            plusAccountBtn.Size = new Size(51, 30);
            plusAccountBtn.Style = MetroSet_UI.Enums.Style.Light;
            plusAccountBtn.StyleManager = null;
            plusAccountBtn.TabIndex = 12;
            plusAccountBtn.Text = "+";
            plusAccountBtn.ThemeAuthor = "Narwin";
            plusAccountBtn.ThemeName = "MetroLite";
            plusAccountBtn.Click += plusAccountBtn_Click;
            // 
            // logoutBtn
            // 
            logoutBtn.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            logoutBtn.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            logoutBtn.DisabledForeColor = Color.Gray;
            logoutBtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            logoutBtn.HoverBorderColor = Color.FromArgb(95, 207, 255);
            logoutBtn.HoverColor = Color.FromArgb(95, 207, 255);
            logoutBtn.HoverTextColor = Color.White;
            logoutBtn.IsDerivedStyle = true;
            logoutBtn.Location = new Point(114, 105);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.NormalBorderColor = Color.FromArgb(65, 177, 225);
            logoutBtn.NormalColor = Color.FromArgb(65, 177, 225);
            logoutBtn.NormalTextColor = Color.White;
            logoutBtn.PressBorderColor = Color.FromArgb(35, 147, 195);
            logoutBtn.PressColor = Color.FromArgb(35, 147, 195);
            logoutBtn.PressTextColor = Color.White;
            logoutBtn.Size = new Size(94, 29);
            logoutBtn.Style = MetroSet_UI.Enums.Style.Light;
            logoutBtn.StyleManager = null;
            logoutBtn.TabIndex = 13;
            logoutBtn.Text = "Logout";
            logoutBtn.ThemeAuthor = "Narwin";
            logoutBtn.ThemeName = "MetroLite";
            logoutBtn.Click += logoutBtn_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1319, 315);
            Controls.Add(gridView);
            Controls.Add(logoutBtn);
            Controls.Add(plusAccountBtn);
            Controls.Add(newPassword);
            Controls.Add(newUsername);
            Controls.Add(txtNewPassword);
            Controls.Add(txtNewUsername);
            Controls.Add(metroSetLabel1);
            Controls.Add(metroSetControlBox1);
            Name = "AdminForm";
            Text = "System Scheduling Management";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetLabel newPassword;
        private MetroSet_UI.Controls.MetroSetLabel newUsername;
        private TextBox txtNewPassword;
        private TextBox txtNewUsername;
        private MetroSet_UI.Controls.MetroSetButton plusAccountBtn;
        private MetroSet_UI.Controls.MetroSetButton logoutBtn;
        private DataGridView gridView;
        private DataGridViewTextBoxColumn mondayColumn;
        private DataGridViewTextBoxColumn tuesdayColumn;
        private DataGridViewTextBoxColumn wednesdayColumn;
        private DataGridViewTextBoxColumn thursdayColumn;
        private DataGridViewTextBoxColumn fridayColumn;
        private DataGridViewTextBoxColumn saturdayColumn;
        private DataGridViewTextBoxColumn sundayColumn;
    }
}