@ModelType User
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>User</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.user_name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.user_name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.gender)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.gender)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.dob)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.dob)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.pob)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.pob)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.job_place)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.job_place)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.civil_status)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.civil_status)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.tel)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.tel)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.email)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.email)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ActivityDetail.location)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ActivityDetail.location)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Job.jon_name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Job.jon_name)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
