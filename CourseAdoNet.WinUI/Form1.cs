using CourseAdoNet.Business.Abstract;
using CourseAdoNet.Business.Concrete;
using CourseAdoNet.DataAccess.Concrete;
using CourseAdoNet.Entities.Concrete;

namespace CourseAdoNet.WinUI
{
    public partial class Form1 : Form
    {
        private readonly IUserManager _userManager;
        private readonly IWorldManager _worldManager;
        public Form1()
        {
            InitializeComponent();
            _userManager = new UserManager(new UserDal());
            _worldManager = new WorldManager(new WorldDal());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            var users = _userManager.GetAll();
            dgwUsers.DataSource = users;

        }

        private void LoadWorlds()
        {
            var worlds = _worldManager.GetByUserId(Convert.ToInt32(dgwUsers.SelectedRows[0].Cells[0].Value));
            dgwWorlds.DataSource = worlds;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var newUser = new User(0, txtUserName.Text, txtEmail.Text);
            _userManager.Add(newUser);

            LoadUsers();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedUserId = Convert.ToInt32(dgwUsers.SelectedRows[0].Cells[0].Value);
                _userManager.Delete(selectedUserId);

                LoadUsers();
            }
            catch
            {
                MessageBox.Show("Please select row");
            }
        }

        private void dgwUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwUsers.SelectedRows.Count != 0)
            {
                var selectedUserName = dgwUsers.SelectedRows[0].Cells[1].Value.ToString();
                txtUpdateUserName.Text = selectedUserName;
                var selectedEmail = dgwUsers.SelectedRows[0].Cells[2].Value.ToString();
                txtUpdateEmail.Text = selectedEmail;

                LoadWorlds();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var updateUser = new User(Convert.ToInt32(dgwUsers.SelectedRows[0].Cells[0].Value), txtUpdateUserName.Text, txtUpdateEmail.Text);
            _userManager.Update(updateUser);

            LoadUsers();
        }

        private void btnRemoveWorld_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedUserId = Convert.ToInt32(dgwWorlds.SelectedRows[0].Cells[0].Value);
                _worldManager.Delete(selectedUserId);

                LoadWorlds();
            }
            catch
            {
                MessageBox.Show("Please select row");
            }
        }

        private void btnUpdateWorld_Click(object sender, EventArgs e)
        {
            var updatedWorld = new World(Convert.ToInt32(dgwWorlds.SelectedRows[0].Cells[0].Value), txtUpdateWorldName.Text, Convert.ToInt32(dgwUsers.SelectedRows[0].Cells[0].Value));

            _worldManager.Update(updatedWorld);

            LoadWorlds();
        }

        private void btnAddWorld_Click(object sender, EventArgs e)
        {
            var newWorld = new World(0, txtWorldName.Text, Convert.ToInt32(dgwUsers.SelectedRows[0].Cells[0].Value));
            _worldManager.Add(newWorld);

            LoadWorlds();
        }

        private void dgwWorlds_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwWorlds.SelectedRows.Count != 0)
            {
                var selectedWorldName = dgwWorlds.SelectedRows[0].Cells[1].Value.ToString();
                txtUpdateWorldName.Text = selectedWorldName;
            }
        }
    }
}