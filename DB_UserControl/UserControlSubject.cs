using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_UserControl
{
    public partial class UserControlSubject : UserControl
    {
        private Subject mySubject;

        public event Action MySubjectChanged;
        public Subject MySubject
        {
            get
            {
                //insert
                if (mySubject == null)
                {
                    mySubject = new Subject();
                }
                mySubject.Name = textBoxName.Text;
                mySubject.Hours = (int)numericUpDownHours.Value;
                mySubject.Teacher = listBoxTeachers.SelectedItem as Teacher;

                return mySubject;
            }
            set
            {
                mySubject = value;
                if (mySubject != null)
                {
                    textBoxName.Text = mySubject.Name;
                    numericUpDownHours.Value = mySubject.Hours;
                    listBoxTeachers.SelectedItem = mySubject.Teacher;
                }
                else
                {
                    textBoxName.Text = "";
                    numericUpDownHours.Value = 0;
                    listBoxTeachers.SelectedItem = null;
                }
            }
        }
        public Teacher [] Teachers
        {
            set
            {
                listBoxTeachers.Items.Clear();
                listBoxTeachers.Items.AddRange(value);
            }
        }
        public UserControlSubject()
        {
            InitializeComponent();
        }
    }
}
