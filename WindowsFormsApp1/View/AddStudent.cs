using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Presenters;

namespace WindowsFormsApp1.View
{
    public partial class AddStudent : Form,IAddStudent
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        public string FirstName
        {
            get { return txtFirstName.Text; }
            set { txtFirstName.Text = value; }
        }

        public string LastName
        {
            get { return txtLastName.Text; }
            set { txtLastName.Text = value; }
        }

        public string IDCard
        {
            get { return txtIDCard.Text; }
            set { txtIDCard.Text = value; }
        }

        public string _message;
        public string Message
        {
            get { return _message; }
            set { _message = value; MessageBox.Show(_message); }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StudentPresenter stupre = new StudentPresenter(this);
            stupre.AddStudent();
        }
    }
}
