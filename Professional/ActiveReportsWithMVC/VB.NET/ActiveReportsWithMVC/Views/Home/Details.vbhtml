@ModelType GrapeCity.ActiveReports.Samples.ActiveReportsWithMVC.Models.Customer
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Home/_Layout.vbhtml"
End Code

<div id="body">
<div class="centerheader">
     <div class="display-field" style=" color:Blue">
        @Html.ActionLink("Index","Index")
    </div>
    </div>
<div class="centerheader">
     <span class="HeaderTxt">Customer Details:</span>
    </div>
<div class="center">
 <fieldset style="border:none">
 <div class="display-label" style="float:left;font-weight:bold">CompanyName:</div>
 <div class="display-field">
        @Model.CompanyName
    </div>
 <div class="display-label" style="float:left;font-weight:bold">ContactName:</div>
    <div class="display-field">
        @Model.ContactName 
        
    </div>

    <div class="display-label" style="float:left;font-weight:bold">ContactTitle:</div>
    <div class="display-field">
        @Model.ContactTitle 
        
    </div>

    <div class="display-label" style="float:left;font-weight:bold">Address:</div>
    <div class="display-field">
        @Model.Address 
    </div>

    <div class="display-label" style="float:left;font-weight:bold">City:</div>
    <div class="display-field">
       @Model.City 
    </div>

    <div class="display-label" style="float:left;font-weight:bold">Region:</div>
    <div class="display-field">
        @Model.Region 
    </div>

    <div class="display-label" style="float:left;font-weight:bold">PostalCode:</div>
    <div class="display-field">
        @Model.PostalCode 
        
    </div>

    <div class="display-label" style="float:left;font-weight:bold">Country:</div>
    <div class="display-field">
        @Model.Country 
        
    </div>

    <div class="display-label" style="float:left;font-weight:bold" >Phone:</div>
    <div class="display-field">
        @Model.Phone 
        
    </div>

    <div class="display-label" style="float:left;font-weight:bold">Fax:</div>
    <div class="display-field">
        @Model.Fax 
        
    </div>
 </fieldset>
 <p id="reports" style=" font-size:small">

    @Html.ActionLink("Freight Summary(Section Report)", "ViewReport", New With {.id = Model.CustomerId, .reporttype = "Section"}) |
    @Html.ActionLink("Order Summary(Page Report)", "ViewReport", New With {.id = Model.CustomerID, .reporttype = "Page"})
</p>
</div>
</div>

