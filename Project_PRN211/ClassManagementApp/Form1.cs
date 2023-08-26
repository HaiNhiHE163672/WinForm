using ClassManagementApp.Model;
using System.Windows.Forms;

namespace ClassManagementApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Group> Groups = new();

        private void Form1_Load(object sender, EventArgs e)
        {
            using var context = new PrnProjectContext();
            List<Group> groups = context.Groups.ToList();
            foreach(var group in groups)
            {
                if(cbStatus.Items.Contains(group.Status)== false)
                {
                    cbStatus.Text= group.Status;
                    cbStatus.Items.Add(group.Status);
                }
              
            }


            List<Lecturer> lecturers = context.Lecturers.ToList();
            cbLecturer.DataSource = lecturers;
            cbLecturer.DisplayMember = "LecturerName";
            cbLecturer.ValueMember = "LecturerId";
            List<Subject> subjects = context.Subjects.ToList();
            cbSubject.DataSource = subjects;
            cbSubject.DisplayMember = "SubjectName";
            cbSubject.ValueMember = "SubjectId";
            txtGID.Enabled = false;
            load();
            txtLID.Enabled = false;
            load1();
            txtID.Enabled = false;
            load2();
            errorProvider2.ContainerControl = this;
        }
        private void load()
        {
            using (var _context = new PrnProjectContext())
            {
                dgvClass.DataSource = _context.Groups.Select(x => new
                {
                    x.GroupId,
                    x.GroupName,
                    x.SubjectId,
                    x.LecturerId,
                    x.Status,
                }).ToList();
            }
        }
        private void load1()
        {
            using (var _context = new PrnProjectContext())
            {
                dgvLecturer.DataSource = _context.Lecturers.Select(x => new
                {
                    x.LecturerId,
                    x.LecturerName,
                    x.Gender,
                    x.Address,
                    x.Dob,
                    x.Email,
                }).ToList();
            }
        }
        private void load2()
        {
            using (var _context = new PrnProjectContext())
            {
                dgvStudent.DataSource = _context.Students.Select(x => new
                {
                    x.StudentId,
                    x.StudentName,
                    x.Gender,
                    x.Address, 
                    x.Dob,
                    x.Email,
                  
                }).ToList();
            }
        }

        private void txtGName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool status = true;
            DataGridViewRow row = new DataGridViewRow();
            row = dgvClass.Rows[dgvClass.CurrentCell.RowIndex];
            if (txtGName.Text.Equals(row.Cells[1].Value))
            {
                errorProvider2.SetError(txtGName, "Class is exist");
                status = false;
                e.Cancel = true;
            }
            else
            {
                errorProvider2.SetError(txtGName, "");
            }
            
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                var name = txtGName.Text;
            var subject = cbSubject.SelectedValue;
            var lecturer = cbLecturer.SelectedValue;
            var status = cbStatus.Text;
            using var context = new PrnProjectContext();
            context.Groups.Add(new Group
            {
                GroupName = name,
                SubjectId = int.Parse(subject.ToString()),
                LecturerId = int.Parse(lecturer.ToString()),
                Status = status,
                
            });
            
                MessageBox.Show(txtGName.Text, "You added a class successfull" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                context.SaveChanges();
                Form1_Load(sender, e);
            }

        }

        private void btnEditClass_Click(object sender, EventArgs e)
        {
            using var context = new PrnProjectContext();
            var id = txtGID.Text;
            var name = txtGName.Text;
            var subject = cbSubject.SelectedValue;
            var lecturer = cbLecturer.SelectedValue;
            var status = cbStatus.Text;
            Group g = new Group
            {
                GroupId = int.Parse(id),
                GroupName = name,
                SubjectId = int.Parse(subject.ToString()),
                LecturerId = int.Parse(lecturer.ToString()),
                Status = status,
            };
            MessageBox.Show( "You updated a Class successfull");
            context.Groups.Update(g);
            context.SaveChanges();
            Form1_Load(sender, e);
        }

        private void dgvClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvClass.Rows[e.RowIndex].Cells[0].Value;
            var name = dgvClass.Rows[e.RowIndex].Cells[1].Value;
            var subid = dgvClass.Rows[e.RowIndex].Cells[2].Value;
            var lecid = dgvClass.Rows[e.RowIndex].Cells[3].Value;
            var status = dgvClass.Rows[e.RowIndex].Cells[4].Value;

            txtGID.Text = id.ToString();
            txtGName.Text = name.ToString();
            cbSubject.SelectedValue = int.Parse(subid.ToString());
            cbLecturer.SelectedValue = int.Parse(lecid.ToString());
            
            cbStatus.Text = status.ToString();
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want delete this group?  \n Deleting group may break group lists", "Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using var context = new PrnProjectContext();
                var id = txtGID.Text;
                var name = txtGName.Text;
                var subject = cbSubject.SelectedValue;
                var lecturer = cbLecturer.SelectedValue;
                var status = cbStatus.Text;
                Group g = new Group
                {
                    GroupId = int.Parse(id),
                    GroupName = name,
                    SubjectId = int.Parse(subject.ToString()),
                    LecturerId = int.Parse(lecturer.ToString()),
                    Status = status,
                };
                context.Groups.Remove(g);
                context.SaveChanges();
                Form1_Load(sender, e);
            }
        }

        private void txtLEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool status = true;
            DataGridViewRow row = new DataGridViewRow();
            row = dgvLecturer.Rows[dgvLecturer.CurrentCell.RowIndex];
            if (txtLEmail.Text.Equals(row.Cells[5].Value))
            {
                errorProvider1.SetError(txtLEmail, "Email is exist");
                status = false;
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtLEmail, "");
            }
        }

        private void btnLAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                var name = txtLName.Text;
                var gender = rbLMale.Checked ? "Male" : "Female";
                var address = txtLAddress.Text;
                var dob = dateLDOB.Value;
                var email = txtLEmail.Text;
                using var context = new PrnProjectContext();
                context.Lecturers.Add(new Lecturer
                {
                    LecturerName = name,
                    Gender = gender,
                    Address = address,
                    Dob = dob,
                    Email = email,

                });
                MessageBox.Show(txtLName.Text, "You added a Lecturer successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                context.SaveChanges();
                Form1_Load(sender, e);
            }
        }


        private void btnLEdit_Click(object sender, EventArgs e)
        {
            using var context = new PrnProjectContext();
            var id = txtLID.Text;
            var name = txtLName.Text;
            var gender = rbLMale.Checked ? "Male" : "Female";
            var address = txtLAddress.Text;
            var dob = dateLDOB.Value;
            var email = txtLEmail.Text;
            Lecturer lecturer = new Lecturer
            {
                LecturerId = int.Parse(id),
                LecturerName = name,
                Gender = gender,
                Address = address,
                Dob = dob,
                Email = email,
            };
            MessageBox.Show("You updated a Lecturer successfull");
            context.Lecturers.Update(lecturer);
            context.SaveChanges();
            Form1_Load(sender, e);

        }

        private void dgvLecturer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvLecturer.Rows[e.RowIndex].Cells[0].Value;
            var name = dgvLecturer.Rows[e.RowIndex].Cells[1].Value;
            var gender = dgvLecturer.Rows[e.RowIndex].Cells[2].Value;
            var address = dgvLecturer.Rows[e.RowIndex].Cells[3].Value;
            var dob = dgvLecturer.Rows[e.RowIndex].Cells[4].Value;
            var email = dgvLecturer.Rows[e.RowIndex].Cells[5].Value;

            txtLID.Text = id.ToString();
            txtLName.Text = name.ToString();
            
            if(gender.ToString() == "Male")
            {
                rbLMale.Checked = true;
            }
            else
            {
                rbLFemale.Checked = true;
            }
            txtLAddress.Text = address.ToString();
            dateLDOB.Value = DateTime.Parse(dob.ToString());
            txtLEmail.Text = email.ToString();
        }

        private void btnLDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want delete this lecturer?  \n Deleting lecturer may break list", "Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using var context = new PrnProjectContext();
                var id = txtLID.Text;
                var name = txtLName.Text;
                var gender = rbLMale.Checked ? "Male" : "Female";
                var address = txtLAddress.Text;
                var dob = dateLDOB.Value;
                var email = txtLEmail.Text;
                Lecturer lecturer = new Lecturer
                {
                    LecturerId = int.Parse(id),
                    LecturerName = name,
                    Gender = gender,
                    Address = address,
                    Dob = dob,
                    Email = email,
                };
                
                context.Lecturers.Remove(lecturer);
                context.SaveChanges();
                Form1_Load(sender, e);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {

                var name = txtName.Text;
                var gender = rbMale.Checked ? "Male" : "Female";
                var address = txtAddress.Text;
                var dob = dateDob.Value;
                var email = txtEmail.Text;
                using var context = new PrnProjectContext();
                context.Students.Add(new Student
                {
                    StudentName = name,
                    Gender = gender,
                    Address = address,
                    Dob = dob,
                    Email = email,

                });
                MessageBox.Show(txtLName.Text, "You added a Student successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                context.SaveChanges();
                Form1_Load(sender, e);
            }
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvStudent.Rows[e.RowIndex].Cells[0].Value;
            var name = dgvStudent.Rows[e.RowIndex].Cells[1].Value;
            var gender = dgvStudent.Rows[e.RowIndex].Cells[2].Value;
            var address = dgvStudent.Rows[e.RowIndex].Cells[3].Value;
            var dob = dgvStudent.Rows[e.RowIndex].Cells[4].Value;
            var email = dgvStudent.Rows[e.RowIndex].Cells[5].Value;

            txtID.Text = id.ToString();
            txtName.Text = name.ToString();

            if (gender.ToString() == "Male")
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }
            txtAddress.Text = address.ToString();
            dateDob.Value = DateTime.Parse(dob.ToString());
            txtEmail.Text = email.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using var context = new PrnProjectContext();
            var id = txtID.Text;
            var name = txtName.Text;
            var gender = rbMale.Checked ? "Male" : "Female";
            var address = txtAddress.Text;
            var dob = dateDob.Value;
            var email = txtEmail.Text;
            Student student = new Student
            {
                StudentId = int.Parse(id),
                StudentName = name,
                Gender = gender,
                Address = address,
                Dob = dob,
                Email = email,
            };
            MessageBox.Show("You updated a Student successfull");
            context.Students.Update(student);
            context.SaveChanges();
            Form1_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want delete this student ?  \n Deleting student may break list", "Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using var context = new PrnProjectContext();
                var id = txtID.Text;
                var name = txtName.Text;
                var gender = rbMale.Checked ? "Male" : "Female";
                var address = txtAddress.Text;
                var dob = dateDob.Value;
                var email = txtEmail.Text;
                Student student = new Student
                {
                    StudentId = int.Parse(id),
                    StudentName = name,
                    Gender = gender,
                    Address = address,
                    Dob = dob,
                    Email = email,
                };
                context.Students.Remove(student);
                context.SaveChanges();
                Form1_Load(sender, e);
            }
        }

        
    }
}