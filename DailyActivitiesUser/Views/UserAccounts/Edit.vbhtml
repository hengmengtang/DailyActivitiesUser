@ModelType DailyActivitiesUser.UserAccount
@Code
    ViewData("Title") = "Edit"
End Code

<h2>Edit</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>UserAccount</h4>
        <hr />
        @Html.ValidationSummary(True)
        @Html.HiddenFor(Function(model) model.user_id)

        <div class="form-group">
            @Html.LabelFor(Function(model) model.first_name, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.first_name)
                @Html.ValidationMessageFor(Function(model) model.first_name)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.last_name, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.last_name)
                @Html.ValidationMessageFor(Function(model) model.last_name)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.username, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.username)
                @Html.ValidationMessageFor(Function(model) model.username)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.gender, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.gender)
                @Html.ValidationMessageFor(Function(model) model.gender)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.email, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.email)
                @Html.ValidationMessageFor(Function(model) model.email)
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
            @Html.LabelFor(Function(model) model.confirmpassword, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.confirmpassword)
                @Html.ValidationMessageFor(Function(model) model.confirmpassword)
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Save" class="btn btn-default" />
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
