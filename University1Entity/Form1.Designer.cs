namespace University1Entity
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAllGroups = new System.Windows.Forms.Button();
            this.grdGroups = new System.Windows.Forms.DataGridView();
            this.grdSubjects = new System.Windows.Forms.DataGridView();
            this.grdGroupSubj = new System.Windows.Forms.DataGridView();
            this.btnSubj = new System.Windows.Forms.Button();
            this.btnGrSubj = new System.Windows.Forms.Button();
            this.lblGroup = new System.Windows.Forms.Label();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.grdStudents = new System.Windows.Forms.DataGridView();
            this.btnStud = new System.Windows.Forms.Button();
            this.btnAddSubj = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAddStud = new System.Windows.Forms.Button();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtStudFName = new System.Windows.Forms.TextBox();
            this.txtStudAge = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblStudFName = new System.Windows.Forms.Label();
            this.lblStudAge = new System.Windows.Forms.Label();
            this.lblStudGroup = new System.Windows.Forms.Label();
            this.cmbStudGroup = new System.Windows.Forms.ComboBox();
            this.cmbGrSbjGroup = new System.Windows.Forms.ComboBox();
            this.cmbGrSbjSubject = new System.Windows.Forms.ComboBox();
            this.btnGrUpdate = new System.Windows.Forms.Button();
            this.btnGrDel = new System.Windows.Forms.Button();
            this.btnSubjUpdate = new System.Windows.Forms.Button();
            this.btnSubjDelete = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnStudUpdate = new System.Windows.Forms.Button();
            this.btnStudDelete = new System.Windows.Forms.Button();
            this.lblGrSbjGroup = new System.Windows.Forms.Label();
            this.lblGrSbjSubject = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGroupSubj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAllGroups
            // 
            this.btnAllGroups.Location = new System.Drawing.Point(115, 12);
            this.btnAllGroups.Name = "btnAllGroups";
            this.btnAllGroups.Size = new System.Drawing.Size(75, 23);
            this.btnAllGroups.TabIndex = 0;
            this.btnAllGroups.Text = "All groups";
            this.btnAllGroups.UseVisualStyleBackColor = true;
            this.btnAllGroups.Click += new System.EventHandler(this.btnAllGroups_Click);
            // 
            // grdGroups
            // 
            this.grdGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGroups.Location = new System.Drawing.Point(12, 41);
            this.grdGroups.Name = "grdGroups";
            this.grdGroups.Size = new System.Drawing.Size(293, 150);
            this.grdGroups.TabIndex = 1;
            this.grdGroups.SelectionChanged += new System.EventHandler(this.grdGroups_SelectionChanged);
            // 
            // grdSubjects
            // 
            this.grdSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSubjects.Location = new System.Drawing.Point(311, 41);
            this.grdSubjects.Name = "grdSubjects";
            this.grdSubjects.Size = new System.Drawing.Size(291, 150);
            this.grdSubjects.TabIndex = 2;
            this.grdSubjects.SelectionChanged += new System.EventHandler(this.grdSubjects_SelectionChanged);
            // 
            // grdGroupSubj
            // 
            this.grdGroupSubj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGroupSubj.Location = new System.Drawing.Point(608, 41);
            this.grdGroupSubj.Name = "grdGroupSubj";
            this.grdGroupSubj.Size = new System.Drawing.Size(300, 150);
            this.grdGroupSubj.TabIndex = 3;
            this.grdGroupSubj.SelectionChanged += new System.EventHandler(this.grdGroupSubj_SelectionChanged);
            // 
            // btnSubj
            // 
            this.btnSubj.Location = new System.Drawing.Point(420, 12);
            this.btnSubj.Name = "btnSubj";
            this.btnSubj.Size = new System.Drawing.Size(75, 23);
            this.btnSubj.TabIndex = 4;
            this.btnSubj.Text = "All subjects";
            this.btnSubj.UseVisualStyleBackColor = true;
            this.btnSubj.Click += new System.EventHandler(this.btnSubj_Click);
            // 
            // btnGrSubj
            // 
            this.btnGrSubj.Location = new System.Drawing.Point(705, 12);
            this.btnGrSubj.Name = "btnGrSubj";
            this.btnGrSubj.Size = new System.Drawing.Size(113, 23);
            this.btnGrSubj.TabIndex = 5;
            this.btnGrSubj.Text = "All Group - Subject";
            this.btnGrSubj.UseVisualStyleBackColor = true;
            this.btnGrSubj.Click += new System.EventHandler(this.btnGrSubj_Click);
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(12, 204);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(39, 13);
            this.lblGroup.TabIndex = 6;
            this.lblGroup.Text = "Group:";
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(57, 201);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(113, 20);
            this.txtGroup.TabIndex = 7;
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Location = new System.Drawing.Point(15, 227);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(75, 23);
            this.btnAddGroup.TabIndex = 8;
            this.btnAddGroup.Text = "Add group";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // grdStudents
            // 
            this.grdStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStudents.Location = new System.Drawing.Point(914, 41);
            this.grdStudents.Name = "grdStudents";
            this.grdStudents.Size = new System.Drawing.Size(443, 150);
            this.grdStudents.TabIndex = 9;
            this.grdStudents.SelectionChanged += new System.EventHandler(this.grdStudents_SelectionChanged);
            // 
            // btnStud
            // 
            this.btnStud.Location = new System.Drawing.Point(1083, 12);
            this.btnStud.Name = "btnStud";
            this.btnStud.Size = new System.Drawing.Size(113, 23);
            this.btnStud.TabIndex = 10;
            this.btnStud.Text = "All students";
            this.btnStud.UseVisualStyleBackColor = true;
            this.btnStud.Click += new System.EventHandler(this.btnStud_Click);
            // 
            // btnAddSubj
            // 
            this.btnAddSubj.Location = new System.Drawing.Point(311, 227);
            this.btnAddSubj.Name = "btnAddSubj";
            this.btnAddSubj.Size = new System.Drawing.Size(87, 23);
            this.btnAddSubj.TabIndex = 11;
            this.btnAddSubj.Text = "Add subject";
            this.btnAddSubj.UseVisualStyleBackColor = true;
            this.btnAddSubj.Click += new System.EventHandler(this.btnAddSubj_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(608, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Add group - subject";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddStud
            // 
            this.btnAddStud.Location = new System.Drawing.Point(914, 237);
            this.btnAddStud.Name = "btnAddStud";
            this.btnAddStud.Size = new System.Drawing.Size(75, 23);
            this.btnAddStud.TabIndex = 13;
            this.btnAddStud.Text = "Add student";
            this.btnAddStud.UseVisualStyleBackColor = true;
            this.btnAddStud.Click += new System.EventHandler(this.btnAddStud_Click);
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(382, 201);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(113, 20);
            this.txtSubject.TabIndex = 14;
            // 
            // txtStudFName
            // 
            this.txtStudFName.Location = new System.Drawing.Point(966, 204);
            this.txtStudFName.Name = "txtStudFName";
            this.txtStudFName.Size = new System.Drawing.Size(101, 20);
            this.txtStudFName.TabIndex = 15;
            // 
            // txtStudAge
            // 
            this.txtStudAge.Location = new System.Drawing.Point(1118, 204);
            this.txtStudAge.Name = "txtStudAge";
            this.txtStudAge.Size = new System.Drawing.Size(38, 20);
            this.txtStudAge.TabIndex = 16;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(319, 206);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(46, 13);
            this.lblSubject.TabIndex = 17;
            this.lblSubject.Text = "Subject:";
            // 
            // lblStudFName
            // 
            this.lblStudFName.AutoSize = true;
            this.lblStudFName.Location = new System.Drawing.Point(921, 206);
            this.lblStudFName.Name = "lblStudFName";
            this.lblStudFName.Size = new System.Drawing.Size(35, 13);
            this.lblStudFName.TabIndex = 18;
            this.lblStudFName.Text = "Name";
            // 
            // lblStudAge
            // 
            this.lblStudAge.AutoSize = true;
            this.lblStudAge.Location = new System.Drawing.Point(1073, 209);
            this.lblStudAge.Name = "lblStudAge";
            this.lblStudAge.Size = new System.Drawing.Size(26, 13);
            this.lblStudAge.TabIndex = 19;
            this.lblStudAge.Text = "Age";
            // 
            // lblStudGroup
            // 
            this.lblStudGroup.AutoSize = true;
            this.lblStudGroup.Location = new System.Drawing.Point(1162, 208);
            this.lblStudGroup.Name = "lblStudGroup";
            this.lblStudGroup.Size = new System.Drawing.Size(39, 13);
            this.lblStudGroup.TabIndex = 20;
            this.lblStudGroup.Text = "Group:";
            // 
            // cmbStudGroup
            // 
            this.cmbStudGroup.FormattingEnabled = true;
            this.cmbStudGroup.Location = new System.Drawing.Point(1232, 204);
            this.cmbStudGroup.Name = "cmbStudGroup";
            this.cmbStudGroup.Size = new System.Drawing.Size(121, 21);
            this.cmbStudGroup.TabIndex = 21;
            // 
            // cmbGrSbjGroup
            // 
            this.cmbGrSbjGroup.FormattingEnabled = true;
            this.cmbGrSbjGroup.Location = new System.Drawing.Point(650, 205);
            this.cmbGrSbjGroup.Name = "cmbGrSbjGroup";
            this.cmbGrSbjGroup.Size = new System.Drawing.Size(95, 21);
            this.cmbGrSbjGroup.TabIndex = 22;
            // 
            // cmbGrSbjSubject
            // 
            this.cmbGrSbjSubject.FormattingEnabled = true;
            this.cmbGrSbjSubject.Location = new System.Drawing.Point(811, 203);
            this.cmbGrSbjSubject.Name = "cmbGrSbjSubject";
            this.cmbGrSbjSubject.Size = new System.Drawing.Size(97, 21);
            this.cmbGrSbjSubject.TabIndex = 23;
            // 
            // btnGrUpdate
            // 
            this.btnGrUpdate.Location = new System.Drawing.Point(96, 227);
            this.btnGrUpdate.Name = "btnGrUpdate";
            this.btnGrUpdate.Size = new System.Drawing.Size(94, 23);
            this.btnGrUpdate.TabIndex = 24;
            this.btnGrUpdate.Text = "Update group";
            this.btnGrUpdate.UseVisualStyleBackColor = true;
            this.btnGrUpdate.Click += new System.EventHandler(this.btnGrUpdate_Click);
            // 
            // btnGrDel
            // 
            this.btnGrDel.Location = new System.Drawing.Point(196, 227);
            this.btnGrDel.Name = "btnGrDel";
            this.btnGrDel.Size = new System.Drawing.Size(109, 23);
            this.btnGrDel.TabIndex = 25;
            this.btnGrDel.Text = "Delete group";
            this.btnGrDel.UseVisualStyleBackColor = true;
            this.btnGrDel.Click += new System.EventHandler(this.btnGrDel_Click);
            // 
            // btnSubjUpdate
            // 
            this.btnSubjUpdate.Location = new System.Drawing.Point(404, 227);
            this.btnSubjUpdate.Name = "btnSubjUpdate";
            this.btnSubjUpdate.Size = new System.Drawing.Size(101, 23);
            this.btnSubjUpdate.TabIndex = 26;
            this.btnSubjUpdate.Text = "Update subject";
            this.btnSubjUpdate.UseVisualStyleBackColor = true;
            this.btnSubjUpdate.Click += new System.EventHandler(this.btnSubjUpdate_Click);
            // 
            // btnSubjDelete
            // 
            this.btnSubjDelete.Location = new System.Drawing.Point(511, 227);
            this.btnSubjDelete.Name = "btnSubjDelete";
            this.btnSubjDelete.Size = new System.Drawing.Size(91, 23);
            this.btnSubjDelete.TabIndex = 27;
            this.btnSubjDelete.Text = "Delete subject";
            this.btnSubjDelete.UseVisualStyleBackColor = true;
            this.btnSubjDelete.Click += new System.EventHandler(this.btnSubjDelete_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(608, 266);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(185, 23);
            this.button6.TabIndex = 28;
            this.button6.Text = "Delete group - subject";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnStudUpdate
            // 
            this.btnStudUpdate.Location = new System.Drawing.Point(995, 237);
            this.btnStudUpdate.Name = "btnStudUpdate";
            this.btnStudUpdate.Size = new System.Drawing.Size(104, 23);
            this.btnStudUpdate.TabIndex = 29;
            this.btnStudUpdate.Text = "Update student";
            this.btnStudUpdate.UseVisualStyleBackColor = true;
            this.btnStudUpdate.Click += new System.EventHandler(this.btnStudUpdate_Click);
            // 
            // btnStudDelete
            // 
            this.btnStudDelete.Location = new System.Drawing.Point(1105, 237);
            this.btnStudDelete.Name = "btnStudDelete";
            this.btnStudDelete.Size = new System.Drawing.Size(107, 23);
            this.btnStudDelete.TabIndex = 30;
            this.btnStudDelete.Text = "Delete student";
            this.btnStudDelete.UseVisualStyleBackColor = true;
            this.btnStudDelete.Click += new System.EventHandler(this.btnStudDelete_Click);
            // 
            // lblGrSbjGroup
            // 
            this.lblGrSbjGroup.AutoSize = true;
            this.lblGrSbjGroup.Location = new System.Drawing.Point(605, 209);
            this.lblGrSbjGroup.Name = "lblGrSbjGroup";
            this.lblGrSbjGroup.Size = new System.Drawing.Size(39, 13);
            this.lblGrSbjGroup.TabIndex = 31;
            this.lblGrSbjGroup.Text = "Group:";
            // 
            // lblGrSbjSubject
            // 
            this.lblGrSbjSubject.AutoSize = true;
            this.lblGrSbjSubject.Location = new System.Drawing.Point(759, 209);
            this.lblGrSbjSubject.Name = "lblGrSbjSubject";
            this.lblGrSbjSubject.Size = new System.Drawing.Size(46, 13);
            this.lblGrSbjSubject.TabIndex = 32;
            this.lblGrSbjSubject.Text = "Subject:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1365, 494);
            this.Controls.Add(this.lblGrSbjSubject);
            this.Controls.Add(this.lblGrSbjGroup);
            this.Controls.Add(this.btnStudDelete);
            this.Controls.Add(this.btnStudUpdate);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnSubjDelete);
            this.Controls.Add(this.btnSubjUpdate);
            this.Controls.Add(this.btnGrDel);
            this.Controls.Add(this.btnGrUpdate);
            this.Controls.Add(this.cmbGrSbjSubject);
            this.Controls.Add(this.cmbGrSbjGroup);
            this.Controls.Add(this.cmbStudGroup);
            this.Controls.Add(this.lblStudGroup);
            this.Controls.Add(this.lblStudAge);
            this.Controls.Add(this.lblStudFName);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.txtStudAge);
            this.Controls.Add(this.txtStudFName);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.btnAddStud);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddSubj);
            this.Controls.Add(this.btnStud);
            this.Controls.Add(this.grdStudents);
            this.Controls.Add(this.btnAddGroup);
            this.Controls.Add(this.txtGroup);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.btnGrSubj);
            this.Controls.Add(this.btnSubj);
            this.Controls.Add(this.grdGroupSubj);
            this.Controls.Add(this.grdSubjects);
            this.Controls.Add(this.grdGroups);
            this.Controls.Add(this.btnAllGroups);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grdGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGroupSubj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAllGroups;
        private System.Windows.Forms.DataGridView grdGroups;
        private System.Windows.Forms.DataGridView grdSubjects;
        private System.Windows.Forms.DataGridView grdGroupSubj;
        private System.Windows.Forms.Button btnSubj;
        private System.Windows.Forms.Button btnGrSubj;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.DataGridView grdStudents;
        private System.Windows.Forms.Button btnStud;
        private System.Windows.Forms.Button btnAddSubj;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAddStud;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtStudFName;
        private System.Windows.Forms.TextBox txtStudAge;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblStudFName;
        private System.Windows.Forms.Label lblStudAge;
        private System.Windows.Forms.Label lblStudGroup;
        private System.Windows.Forms.ComboBox cmbStudGroup;
        private System.Windows.Forms.ComboBox cmbGrSbjGroup;
        private System.Windows.Forms.ComboBox cmbGrSbjSubject;
        private System.Windows.Forms.Button btnGrUpdate;
        private System.Windows.Forms.Button btnGrDel;
        private System.Windows.Forms.Button btnSubjUpdate;
        private System.Windows.Forms.Button btnSubjDelete;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnStudUpdate;
        private System.Windows.Forms.Button btnStudDelete;
        private System.Windows.Forms.Label lblGrSbjGroup;
        private System.Windows.Forms.Label lblGrSbjSubject;
    }
}

