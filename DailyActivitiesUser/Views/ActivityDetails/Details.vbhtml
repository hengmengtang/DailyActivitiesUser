@ModelType DailyActivitiesUser.ActivityDetail
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>ActivityDetail</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.date)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.date)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.start_time)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.start_time)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.end_time)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.end_time)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.location)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.location)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.execute_status)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.execute_status)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.description)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.description)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.cost)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.cost)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Activity.act_id)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Activity.act_id)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.UserAccount.first_name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.UserAccount.first_name)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.act_det_id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
