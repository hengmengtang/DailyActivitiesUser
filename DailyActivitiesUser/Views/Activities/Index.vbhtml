@ModelType IEnumerable(Of DailyActivitiesUser.Activity)
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
            @Html.DisplayNameFor(Function(model) model.ActivitySubCategory.name)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ActivitySubCategory.name)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.act_id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.act_id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.act_id })
        </td>
    </tr>
Next

</table>
