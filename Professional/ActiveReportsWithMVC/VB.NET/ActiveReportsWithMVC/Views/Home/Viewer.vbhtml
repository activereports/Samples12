@ModelType GrapeCity.ActiveReports.Samples.ActiveReportsWithMVC.Models.ReportDescriptor 

@Code
    ViewData("Title") = "Viewer"
    Layout = "~/Views/Home/_Layout.vbhtml"
End Code


<link href="@Url.Content("~/Content/bootstrap.css")" rel="stylesheet" />
<link href="@Url.Content("~/Content/GrapeCity.ActiveReports.Viewer.Html.css")" rel="stylesheet" />

<script src="@Url.Content("~/Scripts/jquery-1.10.2.js")"></script>
<script src="@Url.Content("~/Scripts/bootstrap-3.0.0.js")"></script>
<script src="@Url.Content("~/Scripts/knockout-2.3.0.js")"></script>
<script src="@Url.Content("~/Scripts/GrapeCity.ActiveReports.Viewer.Html.js")"></script>


<div id="body">
<div style=" margin-left:50px">
@Html.ActionLink("Index","Index")
@Html.ActionLink("Customer Details", "Details/" + Model.Id)
</div>


<hr />
	<div style="margin-left: 50px">
		<b>CustomerID: @Model.Id</b>
	</div>
	<div>
		<div id="viewerContainer" style="margin-left:50px; margin-top: 50px; width: 900px; height: 700px; background: lightgray"></div>
	</div>
	<script type="text/javascript">
        $(function () {
            var viewer = GrapeCity.ActiveReports.Viewer(
            {
                element: '#viewerContainer',
                report: {
                	id: "@Model.Type" + ";" + "@Model.Id"
                },
                reportService: {
                    url: '../../ActiveReportsService.asmx'
                },
                uiType: 'desktop'
            });
            $(window).bind('beforeunload', function () {
            	viewer.destroy();
            });
        });
	</script>
</div>
