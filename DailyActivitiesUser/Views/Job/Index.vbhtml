@ModelType IEnumerable(Of Job)
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
            @Html.DisplayNameFor(Function(model) model.jon_name)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.jon_name)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.job_id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.job_id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.job_id })
        </td>
    </tr>
Next

</table>
