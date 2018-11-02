using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1.Presenters
{
    class StudentPresenter
    {
        IAddStudent addStudentView;

        public StudentPresenter(IAddStudent addStudentView)
        {
            this.addStudentView = addStudentView;
        }

        public bool AddStudent()
        {
            Student stu = new Student();
            stu.FirstName = addStudentView.FirstName;
            stu.LastName = addStudentView.LastName;
            stu.IDCard = addStudentView.IDCard;

            addStudentView.Message = string.Format("Them moi thanh cong {0} {1} / Id: {2}", stu.FirstName, stu.LastName, stu.IDCard);

            return true;
        }
    }
}
