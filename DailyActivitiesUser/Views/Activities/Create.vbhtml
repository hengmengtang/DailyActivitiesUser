@ModelType DailyActivitiesUser.Activity
@Code
    ViewData("Title") = "Create"
End Code

<h2>Create</h2>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>Activity</h4>
        <hr />
        @Html.ValidationSummary(True)
        <div class="form-group">
            @Html.LabelFor(Function(model) model.act_id, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.act_id)
                @Html.ValidationMessageFor(Function(model) model.act_id)
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.act_sub_cat_id, "act_sub_cat_id", htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.DropDownList("act_sub_cat_id", String.Empty)
                @Html.ValidationMessageFor(Function(model) model.act_sub_cat_id)
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
