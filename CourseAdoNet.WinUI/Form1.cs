using CourseAdoNet.Business.Abstract;
using CourseAdoNet.Business.Concrete;
using CourseAdoNet.DataAccess.Concrete;
using CourseAdoNet.Entities.Concrete;

namespace CourseAdoNet.WinUI
{
    public partial class Form1 : Form
    {
        private readonly IUserManager _userManager;
        public Form1()
        {
            InitializeComponent();
            _userManager = new UserManager(new UserDal());
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
            catch (Exception ex)
            {
                MessageBox.Show("Please select row");
            }
        }

        private void dgwUsers_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}