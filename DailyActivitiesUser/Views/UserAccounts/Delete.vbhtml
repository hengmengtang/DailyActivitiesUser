@ModelType DailyActivitiesUser.UserAccount
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>UserAccount</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.first_name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.first_name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.last_name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.last_name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.username)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.username)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.gender)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.gender)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.email)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.email)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.password)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.password)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.confirmpassword)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.confirmpassword)
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
