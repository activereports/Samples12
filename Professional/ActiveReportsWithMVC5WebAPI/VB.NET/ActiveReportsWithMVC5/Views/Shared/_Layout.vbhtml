<!DOCTYPE html>
<html>
<head>
   
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - ActiveReports With MVC5 Sample</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
    <link href="@Url.Content("~/Content/theme-cosmo.css")" rel="stylesheet">
    <link href="@Url.Content("~/css/GrapeCity.ActiveReports.Viewer.Html.css")" rel="stylesheet">
    <link href="@Url.Content("~/Content/SideBar.css")" rel="stylesheet" />
</head>
<body>
   
    <div>
        @RenderBody()
    </div>    
    <script type="text/javascript" src="https://code.angularjs.org/1.6.6/angular.min.js"></script>
    <script src="@Url.Content("~/Scripts/CustomerController.js")"></script>  
	<script src="@Url.Content("~/Scripts/knockout-2.3.0.js")"></script>  
	@Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")     
	@RenderSection("scripts", False)
</body>
</html>