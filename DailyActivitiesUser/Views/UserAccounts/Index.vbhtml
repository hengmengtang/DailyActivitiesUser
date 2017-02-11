@ModelType IEnumerable(Of DailyActivitiesUser.UserAccount)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.first_name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.last_name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.username)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.gender)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.email)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.password)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.confirmpassword)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.first_name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.last_name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.username)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.gender)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.email)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.password)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.confirmpassword)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.user_id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.user_id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.user_id })
        </td>
    </tr>
Next

</table>
