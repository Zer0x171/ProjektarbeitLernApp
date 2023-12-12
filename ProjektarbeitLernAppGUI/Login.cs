﻿using ProjektarbeitLernApp.Model.Auth;
using ProjektarbeitLernApp.PLAContext;
using ProjektarbeitLernApp.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektarbeitLernAppGUI
{
    public partial class Login : Form
    {
        private UserService userService;
        private DatabasePLAContext dbContext;

        public Login(DatabasePLAContext dbContext)
        {
            this.dbContext = dbContext;

            userService = new UserService(dbContext);
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnShowRegister_Click(object sender, EventArgs e)
        {
            var registerForm = new Register(dbContext);
            registerForm.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = new User();
            user.Email = txtEmail.Text;
            user.Password = txtPassword.Text;

            var isValigLogin = userService.Login(user);
            if (isValigLogin)
            {
                user.Id = userService.GetUserId(user);
                if (userService.IsStudent(user))
                {
                    var mainForm = new StudentForm(dbContext, user);
                    mainForm.Show();
                    this.Hide();
                } else if(userService.IsTeacher(user)) 
                {
                    var mainForm = new TeacherForm(dbContext, user);
                    mainForm.Show();
                    this.Hide();
                }
            }
        }

    }
}
