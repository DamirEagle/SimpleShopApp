using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net.Config;
using TestTaskFromNikita.Forms;
using TestTaskFromNikita.Repositories.MoneyRepository;
using TestTaskFromNikita.Repositories.OrdersRepository;
using TestTaskFromNikita.Repositories.PaymentsRepository;


namespace TestTaskFromNikita
{
    public partial class Main : Form
    {
        private Button currentButton;
        private Color activationColor = Color.FromArgb(13, 93, 142);
        private Form activeForm;
        private Form shopForm;
        private Form profileForm;

        public Main(ShopForm shopForm, ProfileForm profileForm)
        {
            InitializeComponent();
            this.profileForm = profileForm;
            this.shopForm = shopForm;

        }
        private void Activate_Button(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = activationColor;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(4, 41, 68);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Hide();
            }
            Activate_Button(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(childForm);
            this.panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelMode.Text = childForm.Text;
        }

        private void buttonShopping_Click(object sender, EventArgs e)
        {
            OpenChildForm(shopForm, sender);
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(profileForm, sender);
        }
        private void labelMode_Click(object sender, EventArgs e)
        {
            foreach (Control form in panelContainer.Controls)
            {
                form.Hide();
            }
            labelMode.Text = "Home";
            DisableButton();
        }
        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
