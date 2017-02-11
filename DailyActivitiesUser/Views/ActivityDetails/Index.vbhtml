@ModelType IEnumerable(Of DailyActivitiesUser.ActivityDetail)
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
            @Html.DisplayNameFor(Function(model) model.date)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.start_time)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.end_time)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.location)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.execute_status)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.description)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.cost)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Activity.act_id)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.UserAccount.first_name)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.date)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.start_time)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.end_time)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.location)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.execute_status)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.description)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.cost)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Activity.act_id)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.UserAccount.first_name)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.act_det_id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.act_det_id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.act_det_id })
        </td>
    </tr>
Next

</table>
