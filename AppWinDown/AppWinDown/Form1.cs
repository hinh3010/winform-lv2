using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AppWinDown
{
    public partial class FormMain : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public FormMain()
        {
            InitializeComponent();
            customsizeDesing();
            random = new Random();
        }

        // sub menu
        private void customsizeDesing()
        {
            panelCategoryItem.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hiddenAllSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void hiddenAllSubmenu()
        {
            if (panelCategoryItem.Visible == true) panelCategoryItem.Visible = false;
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCategoryItem);
            OpenChildForm(new ChildForms.Categories.Categories(), sender, panelSideBar);
            btnAllCategories_Click(this.btnAllCategories,  e);
        }

        // exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Color color = SelectThemeColor();
            //btnExit.BackColor = color;

            hiddenAllSubmenu();
            DialogResult result = MessageBox.Show("Bạn muốn thoát chương trình ? Bạn chắc chưa ?",
               "Thong bao",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
           );
            if (result == DialogResult.Yes) Close();
            else btnHome_Click(this.btnHome, e);
        }

        // childen
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];

            //string color = ThemeColor.ColorDefault();
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender , Panel panel)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton(panel);
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }
        private void DisableButtonIcon()
        {
            this.btnHome.IconColor = Color.FromArgb(64, 64, 64);
            this.btnCategories.IconColor = Color.FromArgb(64, 64, 64);
            this.btnCart.IconColor = Color.FromArgb(64, 64, 64);

            this.btnAllCategories.IconColor = Color.FromArgb(64, 64, 64);
            this.btnTablet.IconColor = Color.FromArgb(64, 64, 64);
            this.btnPhone.IconColor = Color.FromArgb(64, 64, 64);
            this.btnLaptop.IconColor = Color.FromArgb(64, 64, 64);
        }
        private void DisableButton(Panel panel)
        {
            DisableButtonIcon();
            foreach (Control prevBtn in panel.Controls)
            {
                //Debug.WriteLine(prevBtn.GetType());
                if (prevBtn.GetType() == typeof(FontAwesome.Sharp.IconButton))
                {
                    //prevBtn.BackColor = Color.Gainsboro; 
                    prevBtn.BackColor = Color.Transparent;
                    prevBtn.ForeColor = Color.FromArgb(64, 64, 64);
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender , Panel panel)
        {
            if (activeForm != null)
                activeForm.Close();

            ActivateButton(btnSender , panel);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            hiddenAllSubmenu();
            OpenChildForm(new ChildForms.FormHome(), sender , panelSideBar);
            this.btnHome.IconColor = Color.White;
        }

        private void btnLaptop_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChildForms.Categories.FormCategory(), sender , panelCategoryItem);
            this.btnCategories.IconColor = Color.White;
            this.btnLaptop.IconColor = Color.White;
        }

        private void btnPhone_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChildForms.Categories.FormCategory(), sender , panelCategoryItem);
            this.btnCategories.IconColor = Color.White;
            this.btnPhone.IconColor = Color.White;
        }

        private void btnTablet_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChildForms.Categories.FormCategory(), sender, panelCategoryItem);
            this.btnCategories.IconColor = Color.White;
            this.btnTablet.IconColor = Color.White;
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            hiddenAllSubmenu();
            OpenChildForm(new ChildForms.FormCart(), sender, panelSideBar);
            this.btnCart.IconColor = Color.White;
        }

        private void btnAllCategories_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChildForms.Categories.Categories(), sender, panelCategoryItem);
            this.btnCategories.IconColor = Color.White;
            this.btnAllCategories.IconColor = Color.White;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            btnHome_Click(this.btnHome, e);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChildForms.FormAuthen(), sender, panelHeader);
        }

    }
}
