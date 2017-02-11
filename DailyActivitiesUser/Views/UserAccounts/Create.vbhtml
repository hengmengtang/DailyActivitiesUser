@ModelType DailyActivitiesUser.UserAccount
@Code
    ViewData("Title") = "Create"
End Code

<head>
    <title>Welcome To Register Account</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>
<center><h2>Create</h2></center>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-group panel panel-default">
    
        <div class="panel-body">
            <h4 style="display: inline-block;">User Account</h4>
            <input type="submit" value="Create" class="btn btn-default pull-right btn btn-success" />
        </div>
    
    <hr />
    @Html.ValidationSummary(True)
    <div class="container">
        <div class="form-horizontal">
            <div class="form-group">
                <label class="control-label col-sm-2">User ID : </label>            
                @Html.TextBoxFor(Function(model) model.user_id, New With {.class = "form-control", .placeholder = "User ID"})
                @Html.ValidationMessageFor(Function(model) model.user_id)   
            </div>

            <div class="form-group">
                <label class="control-label col-sm-2">Fist Name : </label>
                <div>
                    @Html.TextBoxFor(Function(model) model.first_name, New With {.Class = "form-control", .placeholder = "First Name"})
                    @Html.ValidationMessageFor(Function(model) model.first_name)
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-sm-2">Last Name : </label>
                <div>
                    @Html.TextBoxFor(Function(model) model.last_name, New With {.class = "form-control", .placeholder = "Last Name"})
                    @Html.ValidationMessageFor(Function(model) model.last_name)
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-sm-2">User Name : </label>
                <div>
                    @Html.TextBoxFor(Function(model) model.username, New With {.class = "form-control", .placeholder = "User Name"})
                    @Html.ValidationMessageFor(Function(model) model.username)
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-sm-2">Gender : </label>
                <div>
                    @Html.TextBoxFor(Function(model) model.gender, New With {.class = "form-control", .placeholder = "Gender"})
                    @Html.ValidationMessageFor(Function(model) model.gender)
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-sm-2">Email Address : </label>
                <div>
                    @Html.TextBoxFor(Function(model) model.email, New With {.class = "form-control", .placeholder = "Email Address"})
                    @Html.ValidationMessageFor(Function(model) model.email)
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-sm-2">Password : </label>
                <div>
                    @Html.TextBoxFor(Function(model) model.password, New With {.class = "form-control", .placeholder = "Password"})
                    @Html.ValidationMessageFor(Function(model) model.password)
                </div>
            </div>

            <div class="form-group">
                <label class="control-label col-sm-2">Confirm Password : </label>
                <div>
                    @Html.TextBoxFor(Function(model) model.confirmpassword, New With {.class = "form-control", .placeholder = "Confirm Password"})
                    @Html.ValidationMessageFor(Function(model) model.confirmpassword)
                </div>
            </div>

            <div class="form-group">
                <div class="col-md-offset-2 col-md-6">

                </div>
            </div>
        </div>
        </div>
    </div>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>

@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
