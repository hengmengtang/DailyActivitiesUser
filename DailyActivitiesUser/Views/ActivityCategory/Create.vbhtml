@ModelType ActivityCategory
@Code
    ViewData("Title") = "Create"
End Code

<h2>Create</h2>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>ActivityCategory</h4>
        <hr />
        @Html.ValidationSummary(true)
        <div class="form-group">
            @Html.LabelFor(Function(model) model.act_cat_id, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.act_cat_id)
                @Html.ValidationMessageFor(Function(model) model.act_cat_id)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.name, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.name)
                @Html.ValidationMessageFor(Function(model) model.name)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.description, New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.description)
                @Html.ValidationMessageFor(Function(model) model.description)
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
