@ModelType Activity
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Activity</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.ActivitySubCategory.name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ActivitySubCategory.name)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.act_id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
