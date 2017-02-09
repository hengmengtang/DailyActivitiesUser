@ModelType Activity
@Code
    ViewData("Title") = "Edit"
End Code

<h2>Edit</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>Activity</h4>
        <hr />
        @Html.ValidationSummary(true)
        @Html.HiddenFor(Function(model) model.act_id)

        <div class="form-group">
            @Html.LabelFor(Function(model) model.act_sub_cat_id, "act_sub_cat_id", New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.DropDownList("act_sub_cat_id", String.Empty)
                @Html.ValidationMessageFor(Function(model) model.act_sub_cat_id)
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
