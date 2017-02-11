@ModelType IEnumerable(Of DailyActivitiesUser.ActivityCategory)
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
            @Html.DisplayNameFor(Function(model) model.name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.description)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.description)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.act_cat_id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.act_cat_id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.act_cat_id })
        </td>
    </tr>
Next

</table>
