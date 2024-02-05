using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticeWebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            userInput.Text = "";
            genderId.Text = "";
            ShowDate.Text = "";
            ShowCourses.Text = "None";
        }
        protected void SubmitButtonClick(object sender, EventArgs e)
        {
            userInput.Text = UserName.Text;// Value i sfetched from the input and Stored in the label
            if (RadioButton1.Checked)//checking Gender
            {
                genderId.Text = "Your gender is " + RadioButton1.Text;
            }
            else genderId.Text = "Your gender is " + RadioButton2.Text;
            ShowDate.Text = "You Selected: " + Calendar1.SelectedDate.ToString("D");
            var message = "";
            if (CheckBox1.Checked)
            {
                message = CheckBox1.Text + " ";
            }
            if (CheckBox2.Checked)
            {
                message += CheckBox2.Text + " ";
            }
            if (CheckBox3.Checked)
            {
                message += CheckBox3.Text;
            }
            ShowCourses.Text = message;
        }
    }
}