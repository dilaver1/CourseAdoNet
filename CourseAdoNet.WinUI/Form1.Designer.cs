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
            txtUpdateEmail = new TextBox();
            lblUpdateEmail = new Label();
            txtUpdateUserName = new TextBox();
            lblUpdateUserName = new Label();
            btnUpdate = new Button();
            btnRemove = new Button();
            gbxAdd = new GroupBox();
            btnAdd = new Button();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtUserName = new TextBox();
            lblUserName = new Label();
            dgwUsers = new DataGridView();
            gbxWorlds = new GroupBox();
            gbxUpdateWorlds = new GroupBox();
            txtUpdateWorldName = new TextBox();
            lblWorldNameUpdate = new Label();
            btnUpdateWorld = new Button();
            btnRemoveWorld = new Button();
            gbxAddWorlds = new GroupBox();
            btnAddWorld = new Button();
            txtWorldName = new TextBox();
            lblWorldName = new Label();
            dgwWorlds = new DataGridView();
            gbxUsers.SuspendLayout();
            gbxUpdate.SuspendLayout();
            gbxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwUsers).BeginInit();
            gbxWorlds.SuspendLayout();
            gbxUpdateWorlds.SuspendLayout();
            gbxAddWorlds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwWorlds).BeginInit();
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
            gbxUpdate.Controls.Add(txtUpdateEmail);
            gbxUpdate.Controls.Add(lblUpdateEmail);
            gbxUpdate.Controls.Add(txtUpdateUserName);
            gbxUpdate.Controls.Add(lblUpdateUserName);
            gbxUpdate.Controls.Add(btnUpdate);
            gbxUpdate.Controls.Add(btnRemove);
            gbxUpdate.Dock = DockStyle.Fill;
            gbxUpdate.Location = new Point(402, 23);
            gbxUpdate.Name = "gbxUpdate";
            gbxUpdate.Size = new Size(405, 360);
            gbxUpdate.TabIndex = 3;
            gbxUpdate.TabStop = false;
            gbxUpdate.Text = "Update";
            // 
            // txtUpdateEmail
            // 
            txtUpdateEmail.Location = new Point(127, 141);
            txtUpdateEmail.Name = "txtUpdateEmail";
            txtUpdateEmail.Size = new Size(253, 27);
            txtUpdateEmail.TabIndex = 9;
            // 
            // lblUpdateEmail
            // 
            lblUpdateEmail.AutoSize = true;
            lblUpdateEmail.Location = new Point(26, 144);
            lblUpdateEmail.Name = "lblUpdateEmail";
            lblUpdateEmail.Size = new Size(46, 20);
            lblUpdateEmail.TabIndex = 8;
            lblUpdateEmail.Text = "Email";
            // 
            // txtUpdateUserName
            // 
            txtUpdateUserName.Location = new Point(124, 59);
            txtUpdateUserName.Name = "txtUpdateUserName";
            txtUpdateUserName.Size = new Size(253, 27);
            txtUpdateUserName.TabIndex = 7;
            // 
            // lblUpdateUserName
            // 
            lblUpdateUserName.AutoSize = true;
            lblUpdateUserName.Location = new Point(23, 62);
            lblUpdateUserName.Name = "lblUpdateUserName";
            lblUpdateUserName.Size = new Size(78, 20);
            lblUpdateUserName.TabIndex = 6;
            lblUpdateUserName.Text = "UserName";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(305, 207);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
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
            gbxWorlds.Controls.Add(gbxUpdateWorlds);
            gbxWorlds.Controls.Add(gbxAddWorlds);
            gbxWorlds.Controls.Add(dgwWorlds);
            gbxWorlds.Dock = DockStyle.Fill;
            gbxWorlds.Location = new Point(810, 0);
            gbxWorlds.Name = "gbxWorlds";
            gbxWorlds.Size = new Size(853, 668);
            gbxWorlds.TabIndex = 1;
            gbxWorlds.TabStop = false;
            gbxWorlds.Text = "Worlds";
            // 
            // gbxUpdateWorlds
            // 
            gbxUpdateWorlds.Controls.Add(txtUpdateWorldName);
            gbxUpdateWorlds.Controls.Add(lblWorldNameUpdate);
            gbxUpdateWorlds.Controls.Add(btnUpdateWorld);
            gbxUpdateWorlds.Controls.Add(btnRemoveWorld);
            gbxUpdateWorlds.Dock = DockStyle.Fill;
            gbxUpdateWorlds.Location = new Point(402, 23);
            gbxUpdateWorlds.Name = "gbxUpdateWorlds";
            gbxUpdateWorlds.Size = new Size(448, 360);
            gbxUpdateWorlds.TabIndex = 6;
            gbxUpdateWorlds.TabStop = false;
            gbxUpdateWorlds.Text = "Update";
            // 
            // txtUpdateWorldName
            // 
            txtUpdateWorldName.Location = new Point(124, 59);
            txtUpdateWorldName.Name = "txtUpdateWorldName";
            txtUpdateWorldName.Size = new Size(253, 27);
            txtUpdateWorldName.TabIndex = 7;
            // 
            // lblWorldNameUpdate
            // 
            lblWorldNameUpdate.AutoSize = true;
            lblWorldNameUpdate.Location = new Point(23, 62);
            lblWorldNameUpdate.Name = "lblWorldNameUpdate";
            lblWorldNameUpdate.Size = new Size(93, 20);
            lblWorldNameUpdate.TabIndex = 6;
            lblWorldNameUpdate.Text = "World Name";
            // 
            // btnUpdateWorld
            // 
            btnUpdateWorld.Location = new Point(305, 207);
            btnUpdateWorld.Name = "btnUpdateWorld";
            btnUpdateWorld.Size = new Size(94, 29);
            btnUpdateWorld.TabIndex = 5;
            btnUpdateWorld.Text = "Update";
            btnUpdateWorld.UseVisualStyleBackColor = true;
            btnUpdateWorld.Click += btnUpdateWorld_Click;
            // 
            // btnRemoveWorld
            // 
            btnRemoveWorld.Location = new Point(305, 325);
            btnRemoveWorld.Name = "btnRemoveWorld";
            btnRemoveWorld.Size = new Size(94, 29);
            btnRemoveWorld.TabIndex = 4;
            btnRemoveWorld.Text = "Remove";
            btnRemoveWorld.UseVisualStyleBackColor = true;
            btnRemoveWorld.Click += btnRemoveWorld_Click;
            // 
            // gbxAddWorlds
            // 
            gbxAddWorlds.Controls.Add(btnAddWorld);
            gbxAddWorlds.Controls.Add(txtWorldName);
            gbxAddWorlds.Controls.Add(lblWorldName);
            gbxAddWorlds.Dock = DockStyle.Left;
            gbxAddWorlds.Location = new Point(3, 23);
            gbxAddWorlds.Name = "gbxAddWorlds";
            gbxAddWorlds.Size = new Size(399, 360);
            gbxAddWorlds.TabIndex = 5;
            gbxAddWorlds.TabStop = false;
            gbxAddWorlds.Text = "Add";
            // 
            // btnAddWorld
            // 
            btnAddWorld.Location = new Point(266, 207);
            btnAddWorld.Name = "btnAddWorld";
            btnAddWorld.Size = new Size(94, 29);
            btnAddWorld.TabIndex = 4;
            btnAddWorld.Text = "Add";
            btnAddWorld.UseVisualStyleBackColor = true;
            btnAddWorld.Click += btnAddWorld_Click;
            // 
            // txtWorldName
            // 
            txtWorldName.Location = new Point(107, 56);
            txtWorldName.Name = "txtWorldName";
            txtWorldName.Size = new Size(253, 27);
            txtWorldName.TabIndex = 1;
            // 
            // lblWorldName
            // 
            lblWorldName.AutoSize = true;
            lblWorldName.Location = new Point(6, 59);
            lblWorldName.Name = "lblWorldName";
            lblWorldName.Size = new Size(90, 20);
            lblWorldName.TabIndex = 0;
            lblWorldName.Text = "World name";
            // 
            // dgwWorlds
            // 
            dgwWorlds.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwWorlds.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwWorlds.Dock = DockStyle.Bottom;
            dgwWorlds.Location = new Point(3, 383);
            dgwWorlds.Name = "dgwWorlds";
            dgwWorlds.RowHeadersWidth = 51;
            dgwWorlds.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwWorlds.Size = new Size(847, 282);
            dgwWorlds.TabIndex = 4;
            dgwWorlds.SelectionChanged += dgwWorlds_SelectionChanged;
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
            gbxUpdate.PerformLayout();
            gbxAdd.ResumeLayout(false);
            gbxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwUsers).EndInit();
            gbxWorlds.ResumeLayout(false);
            gbxUpdateWorlds.ResumeLayout(false);
            gbxUpdateWorlds.PerformLayout();
            gbxAddWorlds.ResumeLayout(false);
            gbxAddWorlds.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwWorlds).EndInit();
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
        private Button btnUpdate;
        private TextBox txtUpdateEmail;
        private Label lblUpdateEmail;
        private TextBox txtUpdateUserName;
        private Label lblUpdateUserName;
        private GroupBox gbxUpdateWorlds;
        private TextBox txtUpdateWorldName;
        private Label lblWorldNameUpdate;
        private Button btnUpdateWorld;
        private Button btnRemoveWorld;
        private GroupBox gbxAddWorlds;
        private Button btnAddWorld;
        private TextBox txtWorldName;
        private Label lblWorldName;
        private DataGridView dgwWorlds;
    }
}