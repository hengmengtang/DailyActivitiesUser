@ModelType Job
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Job</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.jon_name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.jon_name)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.job_id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
