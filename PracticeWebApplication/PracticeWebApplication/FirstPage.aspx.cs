using System;
using System.Collections.Generic;
using System.IO;
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
            //Result.Style["Display"] = "none";
            userInput.Text = "";
            genderId.Text = "";
            ShowDate.Text = "";
            ShowCourses.Text = "None";
            Response.Cookies["computer"].Expires = DateTime.Now.AddDays(-1);   
        }
        protected void SubmitButtonClick(object sender, EventArgs e)
        {
            userInput.Text = UserName.Text;// Value i sfetched from the input and Stored in the label
            if (RadioButton1.Checked)//checking Gender
            {
                genderId.Text = "Your gender is " + RadioButton1.Text;
            }
            else if(RadioButton2.Checked)
                genderId.Text = "Your gender is " + RadioButton2.Text;
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
            //Checking And Storing A Single File
            if ((FileUpload1.PostedFile != null) && (FileUpload1.PostedFile.ContentLength > 0))
            {
                string fn = System.IO.Path.GetFileName(FileUpload1.PostedFile.FileName);
                string SaveLocation = Server.MapPath("UploadedFiles") + "\\" + fn;
                try
                {
                    FileUpload1.PostedFile.SaveAs(SaveLocation);
                    FileUploadStatus.Text = "The file has been uploaded.";
                }
                catch (Exception ex)
                {
                    FileUploadStatus.Text = "Error: " + ex.Message;
                }
            }
            else
            {
                FileUploadStatus.Text = "Please select a file to upload.";
            }
            //Checking And Storing Multiple Files
            if ((FileUpload2.PostedFile != null) && (FileUpload2.PostedFile.ContentLength > 0))
            {
                var count = 0;
                foreach (HttpPostedFile uploadedFile in FileUpload2.PostedFiles)
                {
                    string fn = System.IO.Path.GetFileName(uploadedFile.FileName);
                    string SaveLocation = Server.MapPath("UploadedFiles") + "\\" + fn;
                    try
                    {
                        uploadedFile.SaveAs(SaveLocation);
                        count++;
                    }
                    catch (Exception ex)
                    {
                        MultipleFileUploadStatus.Text = "Error: " + ex.Message;
                    }
                }
                if (count > 0)
                {
                    MultipleFileUploadStatus.Text = count + " files has been uploaded.";
                }
            }
            else
            {
                MultipleFileUploadStatus.Text = "Please select a file to upload.";
            }
            ShowChoicesThroughCookies(sender, e);
            ShowDropdownValue(sender, e);
        }
        protected void DownloadOnClick(object sender, EventArgs e)
        {
            string filePath = "D:\\AdventureWorks2022.bak";
            FileInfo file = new FileInfo(filePath);
            if (file.Exists)
            {
                Response.Clear();
                Response.AddHeader("Content-Disposition", "attachment; filename=" + file.Name);
                Response.AddHeader("Content-Length", file.Length.ToString());
                Response.ContentType = "text/plain";
                Response.Flush();
                Response.TransmitFile(file.FullName);
                Response.End();
            }
            else DownloadResult.Text = "Requested file is not available to download";
        }
        protected void ShowChoicesThroughCookies(object sender, EventArgs e)
        {
            Choices.Text = "";
            //Adding Cookies
            if (apple.Checked)
                Response.Cookies["computer"]["apple"] = "apple";
            if (dell.Checked)
                Response.Cookies["computer"]["dell"] = "dell";
            if (lenevo.Checked)
                Response.Cookies["computer"]["lenevo"] = "lenevo";
            if (acer.Checked)
                Response.Cookies["computer"]["acer"] = "acer";
            if (sony.Checked)
                Response.Cookies["computer"]["sony"] = "sony";
            if (wipro.Checked)
                Response.Cookies["computer"]["wipro"] = "wipro";
            //Fetching The Cookies
            if (Request.Cookies["computer"].Values.ToString() != null)
            {
                if (Request.Cookies["computer"]["apple"] != null)
                    Choices.Text += Request.Cookies["computer"]["apple"] + " ";
                if (Request.Cookies["computer"]["dell"] != null)
                    Choices.Text += Request.Cookies["computer"]["dell"] + " ";
                if (Request.Cookies["computer"]["lenevo"] != null)
                    Choices.Text += Request.Cookies["computer"]["lenevo"] + " ";
                if (Request.Cookies["computer"]["acer"] != null)
                    Choices.Text += Request.Cookies["computer"]["acer"] + " ";
                if (Request.Cookies["computer"]["sony"] != null)
                    Choices.Text += Request.Cookies["computer"]["sony"] + " ";
                if (Request.Cookies["computer"]["wipro"] != null)
                    Choices.Text += Request.Cookies["computer"]["wipro"] + " ";
            }
            else Choices.Text = "Please select your choice";
            Response.Cookies["computer"].Expires = DateTime.Now.AddDays(-1);
        }
        protected void ShowDropdownValue(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "")
            {
                LabelForDropdown.Text = "Please Select a City";
            }
            else
                LabelForDropdown.Text = "Your Choice is: " + DropDownList1.SelectedValue;

        }
    }
}