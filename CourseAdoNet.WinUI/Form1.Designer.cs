namespace CourseAdoNet.WinUI
{
    partial class Form1
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
            gbxUsers = new GroupBox();
            gbxUpdate = new GroupBox();
            btnRemove = new Button();
            gbxAdd = new GroupBox();
            btnAdd = new Button();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtUserName = new TextBox();
            lblUserName = new Label();
            dgwUsers = new DataGridView();
            gbxWorlds = new GroupBox();
            gbxUsers.SuspendLayout();
            gbxUpdate.SuspendLayout();
            gbxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwUsers).BeginInit();
            SuspendLayout();
            // 
            // gbxUsers
            // 
            gbxUsers.Controls.Add(gbxUpdate);
            gbxUsers.Controls.Add(gbxAdd);
            gbxUsers.Controls.Add(dgwUsers);
            gbxUsers.Dock = DockStyle.Left;
            gbxUsers.Location = new Point(0, 0);
            gbxUsers.Name = "gbxUsers";
            gbxUsers.Size = new Size(810, 668);
            gbxUsers.TabIndex = 0;
            gbxUsers.TabStop = false;
            gbxUsers.Text = "Users";
            // 
            // gbxUpdate
            // 
            gbxUpdate.Controls.Add(btnRemove);
            gbxUpdate.Dock = DockStyle.Fill;
            gbxUpdate.Location = new Point(402, 23);
            gbxUpdate.Name = "gbxUpdate";
            gbxUpdate.Size = new Size(405, 360);
            gbxUpdate.TabIndex = 3;
            gbxUpdate.TabStop = false;
            gbxUpdate.Text = "Update";
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(305, 325);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // gbxAdd
            // 
            gbxAdd.Controls.Add(btnAdd);
            gbxAdd.Controls.Add(txtEmail);
            gbxAdd.Controls.Add(lblEmail);
            gbxAdd.Controls.Add(txtUserName);
            gbxAdd.Controls.Add(lblUserName);
            gbxAdd.Dock = DockStyle.Left;
            gbxAdd.Location = new Point(3, 23);
            gbxAdd.Name = "gbxAdd";
            gbxAdd.Size = new Size(399, 360);
            gbxAdd.TabIndex = 2;
            gbxAdd.TabStop = false;
            gbxAdd.Text = "Add";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(266, 207);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(110, 138);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(253, 27);
            txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(9, 141);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(107, 56);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(253, 27);
            txtUserName.TabIndex = 1;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(6, 59);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(78, 20);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "UserName";
            // 
            // dgwUsers
            // 
            dgwUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwUsers.Dock = DockStyle.Bottom;
            dgwUsers.Location = new Point(3, 383);
            dgwUsers.Name = "dgwUsers";
            dgwUsers.RowHeadersWidth = 51;
            dgwUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwUsers.Size = new Size(804, 282);
            dgwUsers.TabIndex = 1;
            dgwUsers.SelectionChanged += dgwUsers_SelectionChanged;
            // 
            // gbxWorlds
            // 
            gbxWorlds.Dock = DockStyle.Fill;
            gbxWorlds.Location = new Point(810, 0);
            gbxWorlds.Name = "gbxWorlds";
            gbxWorlds.Size = new Size(853, 668);
            gbxWorlds.TabIndex = 1;
            gbxWorlds.TabStop = false;
            gbxWorlds.Text = "Worlds";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1663, 668);
            Controls.Add(gbxWorlds);
            Controls.Add(gbxUsers);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbxUsers.ResumeLayout(false);
            gbxUpdate.ResumeLayout(false);
            gbxAdd.ResumeLayout(false);
            gbxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxUsers;
        private DataGridView dgwUsers;
        private GroupBox gbxWorlds;
        private GroupBox gbxUpdate;
        private GroupBox gbxAdd;
        private Label lblUserName;
        private Button btnAdd;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtUserName;
        private Button btnRemove;
    }
}