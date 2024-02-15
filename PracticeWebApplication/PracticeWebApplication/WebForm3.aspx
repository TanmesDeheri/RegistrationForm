<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="PracticeWebApplication.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <webopt:BundleReference runat="server" Path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.2/css/bootstrap.min.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class=" container-fluid row mt-3">
            <div class="col-sm-3">
                <input type="file" name="postedFile" class="form-control" />
            </div>
            <div class="col-sm-3">
                <input type="button" id="btnUpload" value="Upload" class="btn btn-outline-success" />
            </div>
            <div class="progress col-sm-3" style="display: none">
                <div class="progress-bar progress-bar-animated" role="progressbar"></div>
            </div>
            <div id="lblMessage" style="color: Green" class="col-sm-3"></div>
        </div>
        <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
        <script type="text/javascript">
            $("body").on("click", "#btnUpload", function () {
                $.ajax({
                    url: 'FileUploadHandler.ashx',
                    type: 'POST',
                    data: new FormData($('form')[0]),
                    cache: false,
                    contentType: false,
                    processData: false,
                    success: function (file) {
                        setTimeout(function () {
                            $(".progress").hide();
                            $("#lblMessage").html("<b>" + file.name + "</b> has been uploaded.");
                        }, 1000);
                    },
                    error: function (a) {
                        $("#lblMessage").html(a.responseText);
                    },
                    failure: function (a) {
                        $("#lblMessage").html(a.responseText);
                    },
                    xhr: function () {
                        var fileXhr = $.ajaxSettings.xhr();
                        if (fileXhr.upload) {
                            $(".progress").show();
                            fileXhr.upload.addEventListener("progress", function (e) {
                                if (e.lengthComputable) {
                                    var percentage = Math.ceil(((e.loaded / e.total) * 100));
                                    $('.progress-bar').text(percentage + '%');
                                    $('.progress-bar').width(percentage + '%');
                                    if (percentage == 100) {
                                        $('.progress-bar').text('100%');
                                    }
                                }
                            }, false);
                        }
                        return fileXhr;
                    }
                });
            });
        </script>
    </form>
</body>
</html>
