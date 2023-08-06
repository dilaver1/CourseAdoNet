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
            this.gbxUsers = new System.Windows.Forms.GroupBox();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.txtUpdateEmail = new System.Windows.Forms.TextBox();
            this.lblUpdateEmail = new System.Windows.Forms.Label();
            this.txtUpdateUserName = new System.Windows.Forms.TextBox();
            this.lblUpdateUserName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.dgwUsers = new System.Windows.Forms.DataGridView();
            this.gbxWorlds = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnUpdateWorld = new System.Windows.Forms.Button();
            this.gbxUpdateWorlds = new System.Windows.Forms.GroupBox();
            this.lblWorldNameUpdate = new System.Windows.Forms.Label();
            this.btnRemoveWorld = new System.Windows.Forms.Button();
            this.gbxAddWorlds = new System.Windows.Forms.GroupBox();
            this.btnAddWorld = new System.Windows.Forms.Button();
            this.txtWorldName = new System.Windows.Forms.TextBox();
            this.lblWorldName = new System.Windows.Forms.Label();
            this.dgwWorlds = new System.Windows.Forms.DataGridView();
            this.gbxUsers.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.gbxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsers)).BeginInit();
            this.gbxWorlds.SuspendLayout();
            this.gbxUpdateWorlds.SuspendLayout();
            this.gbxAddWorlds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwWorlds)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxUsers
            // 
            this.gbxUsers.Controls.Add(this.gbxUpdate);
            this.gbxUsers.Controls.Add(this.gbxAdd);
            this.gbxUsers.Controls.Add(this.dgwUsers);
            this.gbxUsers.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbxUsers.Location = new System.Drawing.Point(0, 0);
            this.gbxUsers.Name = "gbxUsers";
            this.gbxUsers.Size = new System.Drawing.Size(810, 668);
            this.gbxUsers.TabIndex = 0;
            this.gbxUsers.TabStop = false;
            this.gbxUsers.Text = "Users";
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.txtUpdateEmail);
            this.gbxUpdate.Controls.Add(this.lblUpdateEmail);
            this.gbxUpdate.Controls.Add(this.txtUpdateUserName);
            this.gbxUpdate.Controls.Add(this.lblUpdateUserName);
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.btnRemove);
            this.gbxUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxUpdate.Location = new System.Drawing.Point(402, 23);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(405, 360);
            this.gbxUpdate.TabIndex = 3;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update";
            // 
            // txtUpdateEmail
            // 
            this.txtUpdateEmail.Location = new System.Drawing.Point(127, 141);
            this.txtUpdateEmail.Name = "txtUpdateEmail";
            this.txtUpdateEmail.Size = new System.Drawing.Size(253, 27);
            this.txtUpdateEmail.TabIndex = 9;
            // 
            // lblUpdateEmail
            // 
            this.lblUpdateEmail.AutoSize = true;
            this.lblUpdateEmail.Location = new System.Drawing.Point(26, 144);
            this.lblUpdateEmail.Name = "lblUpdateEmail";
            this.lblUpdateEmail.Size = new System.Drawing.Size(46, 20);
            this.lblUpdateEmail.TabIndex = 8;
            this.lblUpdateEmail.Text = "Email";
            // 
            // txtUpdateUserName
            // 
            this.txtUpdateUserName.Location = new System.Drawing.Point(124, 59);
            this.txtUpdateUserName.Name = "txtUpdateUserName";
            this.txtUpdateUserName.Size = new System.Drawing.Size(253, 27);
            this.txtUpdateUserName.TabIndex = 7;
            // 
            // lblUpdateUserName
            // 
            this.lblUpdateUserName.AutoSize = true;
            this.lblUpdateUserName.Location = new System.Drawing.Point(23, 62);
            this.lblUpdateUserName.Name = "lblUpdateUserName";
            this.lblUpdateUserName.Size = new System.Drawing.Size(78, 20);
            this.lblUpdateUserName.TabIndex = 6;
            this.lblUpdateUserName.Text = "UserName";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(305, 207);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(305, 325);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(94, 29);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.txtEmail);
            this.gbxAdd.Controls.Add(this.lblEmail);
            this.gbxAdd.Controls.Add(this.txtUserName);
            this.gbxAdd.Controls.Add(this.lblUserName);
            this.gbxAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbxAdd.Location = new System.Drawing.Point(3, 23);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(399, 360);
            this.gbxAdd.TabIndex = 2;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(266, 207);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(110, 138);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(253, 27);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(9, 141);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(107, 56);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(253, 27);
            this.txtUserName.TabIndex = 1;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(6, 59);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(78, 20);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "UserName";
            // 
            // dgwUsers
            // 
            this.dgwUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwUsers.Location = new System.Drawing.Point(3, 383);
            this.dgwUsers.Name = "dgwUsers";
            this.dgwUsers.RowHeadersWidth = 51;
            this.dgwUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwUsers.Size = new System.Drawing.Size(804, 282);
            this.dgwUsers.TabIndex = 1;
            this.dgwUsers.SelectionChanged += new System.EventHandler(this.dgwUsers_SelectionChanged);
            // 
            // gbxWorlds
            // 
            this.gbxWorlds.Controls.Add(this.gbxUpdateWorlds);
            this.gbxWorlds.Controls.Add(this.gbxAddWorlds);
            this.gbxWorlds.Controls.Add(this.dgwWorlds);
            this.gbxWorlds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxWorlds.Location = new System.Drawing.Point(810, 0);
            this.gbxWorlds.Name = "gbxWorlds";
            this.gbxWorlds.Size = new System.Drawing.Size(853, 668);
            this.gbxWorlds.TabIndex = 1;
            this.gbxWorlds.TabStop = false;
            this.gbxWorlds.Text = "Worlds";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(124, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(253, 27);
            this.textBox2.TabIndex = 7;
            // 
            // btnUpdateWorld
            // 
            this.btnUpdateWorld.Location = new System.Drawing.Point(305, 207);
            this.btnUpdateWorld.Name = "btnUpdateWorld";
            this.btnUpdateWorld.Size = new System.Drawing.Size(94, 29);
            this.btnUpdateWorld.TabIndex = 5;
            this.btnUpdateWorld.Text = "Update";
            this.btnUpdateWorld.UseVisualStyleBackColor = true;
            // 
            // gbxUpdateWorlds
            // 
            this.gbxUpdateWorlds.Controls.Add(this.textBox2);
            this.gbxUpdateWorlds.Controls.Add(this.lblWorldNameUpdate);
            this.gbxUpdateWorlds.Controls.Add(this.btnUpdateWorld);
            this.gbxUpdateWorlds.Controls.Add(this.btnRemoveWorld);
            this.gbxUpdateWorlds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxUpdateWorlds.Location = new System.Drawing.Point(402, 23);
            this.gbxUpdateWorlds.Name = "gbxUpdateWorlds";
            this.gbxUpdateWorlds.Size = new System.Drawing.Size(448, 360);
            this.gbxUpdateWorlds.TabIndex = 6;
            this.gbxUpdateWorlds.TabStop = false;
            this.gbxUpdateWorlds.Text = "Update";
            
            // 
            // lblWorldNameUpdate
            // 
            this.lblWorldNameUpdate.AutoSize = true;
            this.lblWorldNameUpdate.Location = new System.Drawing.Point(23, 62);
            this.lblWorldNameUpdate.Name = "lblWorldNameUpdate";
            this.lblWorldNameUpdate.Size = new System.Drawing.Size(93, 20);
            this.lblWorldNameUpdate.TabIndex = 6;
            this.lblWorldNameUpdate.Text = "World Name";
            // 
            // btnRemoveWorld
            // 
            this.btnRemoveWorld.Location = new System.Drawing.Point(305, 325);
            this.btnRemoveWorld.Name = "btnRemoveWorld";
            this.btnRemoveWorld.Size = new System.Drawing.Size(94, 29);
            this.btnRemoveWorld.TabIndex = 4;
            this.btnRemoveWorld.Text = "Remove";
            this.btnRemoveWorld.UseVisualStyleBackColor = true;
            // 
            // gbxAddWorlds
            // 
            this.gbxAddWorlds.Controls.Add(this.btnAddWorld);
            this.gbxAddWorlds.Controls.Add(this.txtWorldName);
            this.gbxAddWorlds.Controls.Add(this.lblWorldName);
            this.gbxAddWorlds.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbxAddWorlds.Location = new System.Drawing.Point(3, 23);
            this.gbxAddWorlds.Name = "gbxAddWorlds";
            this.gbxAddWorlds.Size = new System.Drawing.Size(399, 360);
            this.gbxAddWorlds.TabIndex = 5;
            this.gbxAddWorlds.TabStop = false;
            this.gbxAddWorlds.Text = "Add";
            // 
            // btnAddWorld
            // 
            this.btnAddWorld.Location = new System.Drawing.Point(266, 207);
            this.btnAddWorld.Name = "btnAddWorld";
            this.btnAddWorld.Size = new System.Drawing.Size(94, 29);
            this.btnAddWorld.TabIndex = 4;
            this.btnAddWorld.Text = "Add";
            this.btnAddWorld.UseVisualStyleBackColor = true;
            // 
            // txtWorldName
            // 
            this.txtWorldName.Location = new System.Drawing.Point(107, 56);
            this.txtWorldName.Name = "txtWorldName";
            this.txtWorldName.Size = new System.Drawing.Size(253, 27);
            this.txtWorldName.TabIndex = 1;
            // 
            // lblWorldName
            // 
            this.lblWorldName.AutoSize = true;
            this.lblWorldName.Location = new System.Drawing.Point(6, 59);
            this.lblWorldName.Name = "lblWorldName";
            this.lblWorldName.Size = new System.Drawing.Size(90, 20);
            this.lblWorldName.TabIndex = 0;
            this.lblWorldName.Text = "World name";
            // 
            // dgwWorlds
            // 
            this.dgwWorlds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwWorlds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwWorlds.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwWorlds.Location = new System.Drawing.Point(3, 383);
            this.dgwWorlds.Name = "dgwWorlds";
            this.dgwWorlds.RowHeadersWidth = 51;
            this.dgwWorlds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwWorlds.Size = new System.Drawing.Size(847, 282);
            this.dgwWorlds.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1663, 668);
            this.Controls.Add(this.gbxWorlds);
            this.Controls.Add(this.gbxUsers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxUsers.ResumeLayout(false);
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsers)).EndInit();
            this.gbxWorlds.ResumeLayout(false);
            this.gbxUpdateWorlds.ResumeLayout(false);
            this.gbxUpdateWorlds.PerformLayout();
            this.gbxAddWorlds.ResumeLayout(false);
            this.gbxAddWorlds.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwWorlds)).EndInit();
            this.ResumeLayout(false);

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
        private TextBox textBox2;
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