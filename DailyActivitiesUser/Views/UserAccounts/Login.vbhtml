@ModelType DailyActivitiesUser.UserAccount
@Code
    ViewData("Title") = "Login"
End Code

<h2>Login</h2>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>UserAccount</h4>
        <hr />
        @Html.ValidationSummary(True)
        
        <div class="form-group">
            @Html.LabelFor(Function(model) model.username, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.username)
                @Html.ValidationMessageFor(Function(model) model.username)
            </div>
        </div>


        <div class="form-group">
            @Html.LabelFor(Function(model) model.password, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.password)
                @Html.ValidationMessageFor(Function(model) model.password)
            </div>
        </div>

       
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Create" class="btn btn-default" />
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
