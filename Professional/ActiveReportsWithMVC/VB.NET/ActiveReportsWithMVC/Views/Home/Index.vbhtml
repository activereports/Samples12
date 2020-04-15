@ModelType IEnumerable(Of GrapeCity.ActiveReports.Samples.ActiveReportsWithMVC.Models.Customer)
@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Home/_Layout.vbhtml"
    Dim list As New List(Of GrapeCity.ActiveReports.Samples.ActiveReportsWithMVC.Models.Customer)
    list = Model
    
    
End Code

<div id="body">
    <div class="centerheader">
     <span class="HeaderTxt">Customer Index:</span>
    </div>
    <div class="center">
      <table>
@For Each item In Model
    @<tr>
      <td>
      @Html.ActionLink(item.ContactName, "Details", New With {.id = item.CustomerID})
      </td>
    </tr>
Next
</table>
   
    </div>
    
</div>
