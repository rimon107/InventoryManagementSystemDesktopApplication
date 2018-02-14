using Common.Library;
using IMS.Data.DAL.Context;
using IMS.Data.DAL.IContext;
using IMS.Data.Model;
using IMS.Service.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Unity.Injection;

namespace IMS.Desktop.Views.Security
{
    public partial class Login : Form
    {
        private readonly IMS.Service.BLL.UserContext UserContext;

        public Login()
        {
            InitializeComponent();
            
            var container = new UnityContainer();

            container.RegisterType<IUserContext, IMS.Data.DAL.Context.UserContext>();
            
            UserContext = container.Resolve<IMS.Service.BLL.UserContext>();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool res;
            string UserName = txtUsername.Text;
            string Password = txtPassword.Text;
            
            res = UserContext.ValidateUser(UserName, Password);
            
            if (res)
            {
                this.Close();
            }
            else
            {
                if(ModelState.ErrorMessages.Count != 0)
                {
                    foreach (string err in ModelState.ErrorMessages)
                    {
                        MessageBox.Show(err);
                    }
                    ModelState.ErrorMessages.Clear();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password ");
                }
                
            }
        }

        private void Initialize()
        {
            txtPassword.PasswordChar ='*';
        }
    }
}
