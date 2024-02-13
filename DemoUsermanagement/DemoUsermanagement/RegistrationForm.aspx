<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationForm.aspx.cs" Inherits="DemoUsermanagement.RegistrationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <webopt:BundleReference runat="server" Path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
    <title>Registration form</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class=" container-fluid">
            <div class="container-fluid">
                <div class="row mb-3">
                    <label for="fname" class="col-sm-3 col-form-label">First Name:</label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="fname" runat="server" CssClass="form-control" MaxLength="30" placeholder="Example.John"></asp:TextBox>
                    </div>
                </div>
                <div class="row mb-3">
                    <label for="mname" class="col-sm-3 col-form-label">Middle Name:</label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="mname" runat="server" CssClass="form-control" MaxLength="15" placeholder="Example.Miller"></asp:TextBox>
                    </div>
                </div>
                <div class="row mb-3">
                    <label for="lname" class="col-sm-3 col-form-label">Last Name:</label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="lname" runat="server" CssClass="form-control" MaxLength="20" placeholder="Example.Joe"></asp:TextBox>
                    </div>
                </div>
            </div>

            <div class=" container-fluid">
                <div class="row mb-3">
                    <label for="Father" class="col-sm-3 col-form-label">Father's Name:</label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="Father" runat="server" CssClass="form-control" MaxLength="20" placeholder="Example.Samuel"></asp:TextBox>
                    </div>
                </div>
                <div class="row mb-3">
                    <label for="Mother" class="col-sm-3 col-form-label">Mother's Name:</label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="Mother" runat="server" CssClass="form-control" MaxLength="20" placeholder="Example.Alex"></asp:TextBox>
                    </div>
                </div>
                <div class="row mb-3">
                    <label for="Phone" class="col-sm-3 col-form-label">Phone No:</label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="Phone" runat="server" CssClass="form-control" placeholder="XX-XXXXX-XXXXX"></asp:TextBox>
                    </div>
                </div>
            </div>

            <div class=" container-fluid">
                <div class="row mb-3">
                    <label for="Date" class="col-sm-3 col-form-label">Date of Birth:</label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="Date" runat="server" CssClass="form-control" Type="Date" Min="1960-01-01" Max="2099-12-31"></asp:TextBox>
                    </div>
                </div>
                <div class="row mb-3">
                    <label for="email" class="col-sm-3 col-form-label">Email:</label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="email" runat="server" CssClass="form-control" Type="email" Placeholder="someone@email.com"></asp:TextBox>
                    </div>
                </div>
                <div class="row mb-3">
                    <label for="altemail" class="col-sm-3 col-form-label">Alt. Email:</label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="altemail" runat="server" CssClass="form-control" Type="email" Placeholder="someone@email.com"></asp:TextBox>
                    </div>
                </div>
            </div>

            <div class=" container-fluid">
                <div class="row mb-3">
                    <label for="Country" class="col-sm-3 col-form-label">Country:</label>
                    <div class="col-sm-9">
                        <asp:DropDownList ID="Country" runat="server" CssClass="form-select"></asp:DropDownList>
                    </div>
                </div>
                <div class="row mb-3">
                    <label for="state" class="col-sm-3 col-form-label">State:</label>
                    <div class="col-sm-9">
                        <asp:DropDownList ID="state" runat="server" CssClass="form-select"></asp:DropDownList>
                    </div>
                </div>
            </div>

            <div class=" container-fluid">
                <div class="row mb-3">
                    <label for="B10Marks" class=" col-sm-3 form-label">10th Marks (%):</label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="B10Marks" runat="server" CssClass="form-control" type="number" min="35" max="100"></asp:TextBox>
                    </div>
                </div>
                <div class=" row mb-3">
                    <label for="Board" id="B10Board" class="form-label col-sm-3">Board:</label>
                    <div class="col-sm-9">
                        <asp:DropDownList ID="Board" runat="server" CssClass="form-select">
                            <asp:ListItem Text="ICSE" Value="ICSE"></asp:ListItem>
                            <asp:ListItem Text="CBSE" Value="CBSE"></asp:ListItem>
                            <asp:ListItem Text="CHSE" Value="CHSE"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <div class=" row mb-3">
                    <label for="B12Marks" class="form-label col-sm-3">12th Marks (%):</label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="B12Marks" runat="server" CssClass="form-control" type="number" min="35" max="100"></asp:TextBox>
                    </div>
                </div>
                <div class=" row mb-3">
                    <label for="Board12" id="B12Board" class="form-label col-sm-3">Board:</label>
                    <div class="col-sm-9">
                        <asp:DropDownList ID="Board12" runat="server" CssClass="form-select">
                            <asp:ListItem Text="ICSE" Value="ICSE"></asp:ListItem>
                            <asp:ListItem Text="CBSE" Value="CBSE"></asp:ListItem>
                            <asp:ListItem Text="CHSE" Value="CHSE"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
            </div>

            <div class=" container-fluid">
                <p>Optional subjects taken in 12th:</p>
                <div class="mb-3">
                    <asp:RadioButton ID="ComputerScience" runat="server" CssClass="form-check-input " Text="Computer Science" GroupName="subjects"></asp:RadioButton>
                </div>
                <div class="mb-3">
                    <asp:RadioButton ID="Biology" runat="server" CssClass="form-check-input" Text="Biology" GroupName="subjects"></asp:RadioButton>
                </div>
                <div class="mb-3">
                    <asp:RadioButton ID="Math" runat="server" CssClass="form-check-input" Text="Math" GroupName="subjects"></asp:RadioButton>
                </div>

                <div class="mb-3">
                    <span>Gender: </span>
                </div>
                <div class="mb-3">
                    <asp:RadioButton ID="male" runat="server" CssClass="form-check-input" Text="Male" GroupName="gender" />
                </div>
                <div class="mb-3">
                    <asp:RadioButton ID="female" runat="server" CssClass="form-check-input" Text="Female" GroupName="gender" />
                </div>
                <div class="mb-3">
                    <asp:RadioButton ID="prefrnts" runat="server" CssClass="form-check-input" Text="Prefer not to Say" GroupName="gender" />
                </div>

                <div class="mb-3">
                    <label class="LABEL1 LanguagesKnown">Languages Known</label>
                </div>
                <div class="mb-3">

                    <asp:CheckBox ID="Hindi" runat="server" CssClass="form-check-input" Text="Hindi" />
                </div>
                <div class="mb-3">
                    <asp:CheckBox ID="English" runat="server" CssClass="form-check-input" Text="English" />
                </div>
                <div class="mb-3">
                    <asp:CheckBox ID="Odia" runat="server" CssClass="form-check-input" Text="Odia" />
                </div>
                <div class="mb-3">
                    <asp:CheckBox ID="Tamil" runat="server" CssClass="form-check-input" Text="Tamil" />
                </div>
                <div class="mb-3">
                    <asp:CheckBox ID="Telgu" runat="server" CssClass="form-check-input" Text="Telgu" />
                </div>
                <div class="mb-3">
                    <asp:CheckBox ID="Malyalam" runat="server" CssClass="form-check-input" Text="Malyalam" />
                </div>
                <div class="mb-3">
                    <asp:CheckBox ID="Marathi" runat="server" CssClass="form-check-input" Text="Marathi" />
                </div>
            </div>

            <div class="container-fluid">
                <div class="row mb-3">
                    <asp:Label CssClass="col-sm-3 LABEL1 PresentAddress" AssociatedControlID="Address" Text="Present Address:" runat="server" />
                    <div class="col-sm-9">
                        <asp:TextBox ID="Address" runat="server" TextMode="MultiLine" Rows="5" CssClass="form-control" placeholder="Enter your address"></asp:TextBox>
                    </div>
                </div>
            </div>

            <div class="container-fluid">
                <div class="row mb-3">
                    <asp:Label CssClass="col-sm-3 LABEL1 PermanentAddress" AssociatedControlID="PAddress" Text="Permanent Address:" runat="server" />
                    <div class="col-sm-9">
                        <asp:TextBox ID="PAddress" runat="server" TextMode="MultiLine" Rows="5" CssClass="form-control" placeholder="Enter your address"></asp:TextBox>
                    </div>
                </div>
            </div>

            <div class="container-fluid">
                <div class="row mb-3">
                    <asp:Label CssClass="col-sm-3 LABEL1 Hobby" AssociatedControlID="Hobbies" Text="Hobbies:" runat="server" />
                    <div class="col-sm-9">
                        <asp:TextBox ID="Hobbies" runat="server" TextMode="MultiLine" Rows="5" CssClass="form-control" placeholder="What do you like to do?"></asp:TextBox>
                    </div>
                </div>
            </div>

            <div class="container-fluid">
                <div class="row mb-3">
                    <asp:Label CssClass="col-sm-3 LABEL1 Documents1" AssociatedControlID="requiredDocuments" Text="Upload Documents" runat="server" />
                    <div class="col-sm-9">
                        <div class="docsUpload">
                            <asp:FileUpload ID="requiredDocuments" runat="server" CssClass="form-control" />
                        </div>
                    </div>
                </div>
            </div>

            <div class="container-fluid">
                <div class="row mb-3">
                    <asp:Label CssClass="col-sm-3 LABEL1 Additional" AssociatedControlID="AdditionalDocumentsupload" Text="Upload Additional Documents" runat="server" />
                    <div class="col-sm-9">
                        <div class="docsUpload">
                            <asp:FileUpload ID="AdditionalDocumentsupload" runat="server" CssClass="form-control" />
                        </div>
                    </div>
                </div>
            </div>

            <div class="container-fluid">
                <div class="row mb-3">
                    <div class="col-sm-3"></div>
                    <div class="col-sm-9">
                        <div class="Buttons">
                            <asp:Button ID="resetButton" runat="server" Text="Reset" CssClass=" btn btn-outline-danger" />
                            <asp:Button ID="submitButton" runat="server" Text="Submit" CssClass="btn btn-outline-success" />
                        </div>
                    </div>
                </div>
            </div>
            <asp:Label runat="server" ID="Result"></asp:Label>
        </div>
    </form>
</body>
</html>
