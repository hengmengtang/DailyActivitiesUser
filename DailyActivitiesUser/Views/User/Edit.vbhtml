@ModelType User
@Code
    ViewData("Title") = "Edit"
End Code

<h2>Edit</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>User</h4>
        <hr />
        @Html.ValidationSummary(true)
        @Html.HiddenFor(Function(model) model.user_id)

        <div class="form-group">
            @Html.LabelFor(Function(model) model.user_name, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.user_name)
                @Html.ValidationMessageFor(Function(model) model.user_name)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.gender, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.gender)
                @Html.ValidationMessageFor(Function(model) model.gender)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.dob, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.dob)
                @Html.ValidationMessageFor(Function(model) model.dob)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.pob, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.pob)
                @Html.ValidationMessageFor(Function(model) model.pob)
            </div>
        </div>

        @Html.HiddenFor(Function(model) model.job_id)

        <div class="form-group">
            @Html.LabelFor(Function(model) model.job_place, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.job_place)
                @Html.ValidationMessageFor(Function(model) model.job_place)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.civil_status, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.civil_status)
                @Html.ValidationMessageFor(Function(model) model.civil_status)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.tel, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.tel)
                @Html.ValidationMessageFor(Function(model) model.tel)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.email, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.email)
                @Html.ValidationMessageFor(Function(model) model.email)
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
