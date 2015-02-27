using BLL;
using BLL.Implementations;
using DBModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University1Entity
{
    public partial class Form1 : Form
    {
        UnitOfWork uOW = new UnitOfWork();
        GroupManager gr;
        SubjectManager sbj;
        StudentManager stud;
        GroupSubjectManager grsbj;

        
        public Form1()
        {
            InitializeComponent();
            gr = new GroupManager(uOW);
            sbj = new SubjectManager(uOW);
            stud = new StudentManager(uOW);
            //grsbj = new GroupSubjectManager(uOW);
        }

        public DataTable toDataTable<T>(List<T> data)
        {
            PropertyDescriptorCollection properties =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }

        public bool txtFieldNotEmpty(TextBox field, Label label)
        {
            if (field.Text.Trim() == "") { label.ForeColor = Color.Red; return false; }
            label.ForeColor = Color.Black; return true;
        }
        public bool cmbFieldNotEmpty(ComboBox field, Label label)
        {
            if (field.Text.Trim() == "") { label.ForeColor = Color.Red; return false; }
            label.ForeColor = Color.Black; return true;
        }
        public bool txtFieldIsInt32(TextBox field, Label label)
        {
            int number;
            if ((Int32.TryParse(field.Text.Trim(), out number)) == false) { label.ForeColor = Color.Red; return false; }
            label.ForeColor = Color.Black; return true;
        }
        public bool cmbValueMemeberIsInt32(string cmbValueMemeber, Label label)
        {
            int number;
            if ((Int32.TryParse(cmbValueMemeber.Trim(), out number)) == false) { label.ForeColor = Color.Red; return false; }
            label.ForeColor = Color.Black; return true;
        }

        void setcmbStudGroup()
        {
            cmbStudGroup.ValueMember = "Id";
            cmbStudGroup.DisplayMember = "Name";
            cmbStudGroup.DataSource = toDataTable(gr.GetGroups().ToList());

        }
        void setcmbGrSbjGroup()
        {
            cmbGrSbjGroup.ValueMember = "Id";
            cmbGrSbjGroup.DisplayMember = "Name";
            cmbGrSbjGroup.DataSource = toDataTable(gr.GetGroups().ToList());
        }
        void setcmbGrSbjSubject()
        {
            cmbGrSbjSubject.ValueMember = "Id";
            cmbGrSbjSubject.DisplayMember = "Name";
            cmbGrSbjSubject.DataSource = toDataTable(sbj.GetSubjects().ToList());
        }

        private void btnAllGroups_Click(object sender, EventArgs e)
        {
          //  grdGroups.DataSource = toDataTable(uOW.GroupManager.GetGroups().ToList());
            grdGroups.DataSource = gr.GetGroups().ToList();
        }
        private void btnSubj_Click(object sender, EventArgs e)
        {
           grdSubjects.DataSource = sbj.GetSubjects().ToList();

        }
        private void btnGrSubj_Click(object sender, EventArgs e)
        {
       //     grdGroupSubj.DataSource = toDataTable(uOW.GroupSubjectManager.GetGroupSubject().ToList());
            grdGroupSubj.Columns[0].Visible = false;
            grdGroupSubj.Columns[1].Visible = false;
            setcmbGrSbjGroup();
            setcmbGrSbjSubject();
        }
        private void btnStud_Click(object sender, EventArgs e)
        {
            grdStudents.DataSource = stud.GetStudents().ToList(); 
            setcmbStudGroup();
        }
        
        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            bool isValid = txtFieldNotEmpty(txtGroup, lblGroup);
            if (!isValid)
            {
                return;
            }
            gr.InsertGroup(new Group() { Name = txtGroup.Text.Trim() });
            grdGroups.DataSource = gr.GetGroups().ToList();
            setcmbStudGroup();
            setcmbGrSbjGroup();
        }
        private void btnAddSubj_Click(object sender, EventArgs e)
        {
            bool isValid = txtFieldNotEmpty(txtSubject, lblSubject);
            if (!isValid)
            {
                return;
            }
            sbj.InsertSubject(new Subject { Name = txtSubject.Text.Trim() });
            grdSubjects.DataSource = sbj.GetSubjects().ToList();
            setcmbGrSbjSubject();
        }
        private void btnAddStud_Click(object sender, EventArgs e)
        {
            bool isValid = txtFieldNotEmpty(txtStudFName, lblStudFName)  && txtFieldNotEmpty(txtStudAge, lblStudAge) && 
                           txtFieldIsInt32(txtStudAge, lblStudAge) && cmbFieldNotEmpty(cmbStudGroup, lblStudGroup) &&
                           cmbValueMemeberIsInt32(cmbStudGroup.SelectedValue.ToString(), lblStudGroup);
            if (!isValid)
            {
                return;
            }
            stud.InsertStudent(new Student {
                Name = txtStudFName.Text.Trim(),
                Age =  Convert.ToInt32(txtStudAge.Text.Trim()),
                GroupId = Convert.ToInt32(cmbStudGroup.SelectedValue)

            });
            grdStudents.DataSource = stud.GetStudents().ToList();
        }
        private void button2_Click(object sender, EventArgs e)
        {
           /* bool isValid = cmbFieldNotEmpty(cmbGrSbjGroup, lblGrSbjGroup) && cmbFieldNotEmpty(cmbGrSbjSubject, lblGrSbjSubject) &&
                 cmbValueMemeberIsInt32(cmbGrSbjGroup.SelectedValue.ToString(), lblGrSbjGroup) && 
                 cmbValueMemeberIsInt32(cmbGrSbjSubject.SelectedValue.ToString(), lblGrSbjSubject);
            if (!isValid)
            {
                return;
            }
           uOW.GroupSubjectManager.InsertGroupSubject(new GroupSubject
            {
                GroupId = Convert.ToInt32(cmbGrSbjGroup.SelectedValue),
                SubjectId = Convert.ToInt32(cmbGrSbjSubject.SelectedValue)
            });
            grdGroupSubj.DataSource = toDataTable(uOW.GroupSubjectManager.GetGroupSubject().ToList());
            grdGroupSubj.Columns[0].Visible = false;
            grdGroupSubj.Columns[1].Visible = false;*/
        }

        private void btnGrUpdate_Click(object sender, EventArgs e)
        {
            bool isValid = txtFieldNotEmpty(txtGroup, lblGroup);
            if ((grdGroups.DataSource == null) || !isValid)
            {
                return;
            }
            gr.UpdateGroup(new Group()
            {
                Id = Convert.ToInt32(grdGroups.CurrentRow.Cells[0].Value),
                Name = txtGroup.Text.Trim()
            });
            grdGroups.DataSource = toDataTable(gr.GetGroups().ToList());
            setcmbStudGroup();
            setcmbGrSbjGroup();
        }
        private void btnSubjUpdate_Click(object sender, EventArgs e)
        {
            bool isValid = txtFieldNotEmpty(txtSubject, lblSubject);
            if ((grdSubjects.DataSource == null) || !isValid)
            {
                return;
            }
            sbj.UpdateSubject(new Subject()
            {
                Id = Convert.ToInt32(grdSubjects.CurrentRow.Cells[0].Value),
                Name = txtSubject.Text.Trim()
            });
            grdSubjects.DataSource = sbj.GetSubjects().ToList();
            setcmbGrSbjSubject();
        }
        private void btnStudUpdate_Click(object sender, EventArgs e)
        {
            bool isValid = txtFieldNotEmpty(txtStudFName, lblStudFName) && txtFieldNotEmpty(txtStudAge, lblStudAge) &&
                           txtFieldIsInt32(txtStudAge, lblStudAge) && cmbFieldNotEmpty(cmbStudGroup, lblStudGroup) &&
                           cmbValueMemeberIsInt32(cmbStudGroup.SelectedValue.ToString(), lblStudGroup);
            if ((grdStudents.DataSource == null) || !isValid)
            {
                return;
            }
            stud.UpdateStudent(new Student()
            {
                Id = Convert.ToInt32(grdStudents.CurrentRow.Cells[0].Value),
                Name = txtStudFName.Text.Trim(),
                Age = Convert.ToInt32(txtStudAge.Text.Trim()),
                GroupId = Convert.ToInt32(cmbStudGroup.SelectedValue)
            });
            grdStudents.DataSource = stud.GetStudents().ToList();
        }

        private void btnGrDel_Click(object sender, EventArgs e)
        {
            int curRowId = Convert.ToInt32(grdGroups.CurrentRow.Cells[0].Value);
            if (grdGroups.DataSource == null)
            {
                return;
            }
            gr.DeleteGroup(curRowId);
            grdGroups.DataSource = gr.GetGroups().ToList();
            setcmbStudGroup();
            setcmbGrSbjGroup();
        }
        private void btnSubjDelete_Click(object sender, EventArgs e)
        {
            int curRowId = Convert.ToInt32(grdSubjects.CurrentRow.Cells[0].Value);
            if (grdSubjects.DataSource == null)
            {
                return; 
            }
            sbj.DeleteSubject(curRowId);
            grdSubjects.DataSource = sbj.GetSubjects().ToList();
            setcmbGrSbjSubject();
        }
        private void btnStudDelete_Click(object sender, EventArgs e)
        {
            int curRowId = Convert.ToInt32(grdStudents.CurrentRow.Cells[0].Value);
            if (grdStudents.DataSource == null)
            {
                return; 
            }
            stud.DeleteStudent(curRowId);
            grdStudents.DataSource = stud.GetStudents().ToList();
        }
        private void button6_Click(object sender, EventArgs e)
        {
        /*    int curGrId = Convert.ToInt32(grdGroupSubj.CurrentRow.Cells[0].Value);
            int curSubId = Convert.ToInt32(grdGroupSubj.CurrentRow.Cells[1].Value);
            if (grdGroupSubj.DataSource == null)
            {
                return;
            }
            uOW.GroupSubjectManager.DeleteGroupSubject(curGrId, curSubId);
            grdGroupSubj.DataSource = toDataTable(uOW.GroupSubjectManager.GetGroupSubject().ToList());
            grdGroupSubj.Columns[0].Visible = false;
            grdGroupSubj.Columns[1].Visible = false;*/
        }


        private void grdGroups_SelectionChanged(object sender, EventArgs e)
        {
            if (grdGroups.CurrentRow != null)
            {
                int RowIndex = grdGroups.CurrentRow.Index;
                txtGroup.Text = grdGroups.Rows[RowIndex].Cells[1].Value.ToString();
            }
        }
        private void grdSubjects_SelectionChanged(object sender, EventArgs e)
        {
            if (grdSubjects.CurrentRow != null)
            {
                int RowIndex = grdSubjects.CurrentRow.Index;
                txtSubject.Text = grdSubjects.Rows[RowIndex].Cells[1].Value.ToString();
            }
        }
        private void grdStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (grdStudents.CurrentRow != null)
            {
                int RowIndex = Convert.ToInt32(grdStudents.CurrentRow.Index);

                txtStudFName.Text = grdStudents.Rows[RowIndex].Cells[1].Value.ToString();
                txtStudAge.Text = grdStudents.Rows[RowIndex].Cells[2].Value.ToString();
                cmbStudGroup.Text = grdStudents.Rows[RowIndex].Cells[3].Value.ToString();
            }
        }
        private void grdGroupSubj_SelectionChanged(object sender, EventArgs e)
        {
            if (grdGroupSubj.CurrentRow != null)
            {
                int RowIndex = Convert.ToInt32(grdGroupSubj.CurrentRow.Index);

                cmbGrSbjGroup.Text = grdGroupSubj.Rows[RowIndex].Cells[2].Value.ToString();
                cmbGrSbjSubject.Text = grdGroupSubj.Rows[RowIndex].Cells[3].Value.ToString();
            }
        }





    }
}
