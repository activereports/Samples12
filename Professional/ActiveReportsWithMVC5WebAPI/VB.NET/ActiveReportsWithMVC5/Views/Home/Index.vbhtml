@Code
    ViewBag.Title = "ActiveReports and MVC5"
End Code

@section scripts
    <!-- Add a reference to the ActiveReports HTML5 Viewer -->
    <script src="@Url.Content("~/Scripts/GrapeCity.ActiveReports.Viewer.Html.js")"></script>
    <script type="text/javascript">
        var viewer;
        $(function () {
        	// Initialize the viewer
            viewer = GrapeCity.ActiveReports.Viewer({
            	// Specify the div that hosts the viewer  
                element: '#viewer',
            	// Set the path to the ReportService
                reportService: {
                    url: '/ActiveReports.ReportService.asmx'
                },
            	// Set the default UI type
                uiType: 'desktop',
            	// Enable report buttons
                reportLoaded: function () {
                    reportsButtons.prop('disabled', false);
                },
            	// Set the path to the file with localized strings
            	// TIP: Edit this text file to localize the viewer
                localeUri: 'Scripts/i18n/Localeuri.txt'
            });
        	// Set up buttons to change the viewer to mobile or desktop
            var uiTypeButtons = $('#btnUIType button');
            uiTypeButtons.bind('click', function (ev) {
                ev.stopImmediatePropagation();
                uiTypeButtons.removeClass('active');
                var target = $(ev.target);
                target.addClass('active');
                viewer.option('uiType', target.attr('data-bind'));
            });
        	// Set up buttons to change reports
            var reportsButtons = $('#btnReport button');
            reportsButtons.bind('click', function (ev) {
                ev.stopImmediatePropagation();
                reportsButtons.removeClass('active');
                var target = $(ev.target);
                target.addClass('active');
            	// Pass Customer ID parameter to report
                var reportOption = {
                    id: target.attr('data-bind'),
                    parameters: [{ name: "CustomerID" }]
                };
                var custid = $('#CID').html();
                reportOption.parameters[0].value = parseInt(custid.toString());
                reportsButtons.prop('disabled', true);
            	// Pass report and parameter to viewer options
                viewer.option('report', reportOption);
            });
            $('#btnReport button').first().addClass('active');
            viewer.option('uiType', 'desktop');
            setTimeout(function(){
                loadreport();
            }, 8000);
        });


        function checkActive() {
            $('#firstr').css('color', '#4c348d')
            refreshviewer();
        }
        function checkActivefirst() {
            $('#firstr').css('color', '#97310e')
            refreshviewer();
        }
        function refreshviewer()
        {
            $('#btnReport button').removeClass('active');
            $('#btnReport button').first().addClass('active');
            setTimeout(function(){
                loadreport();
            }, 800);
        }
    	// Load the initial report into the viewer and pass in the
    	// Customer ID based on the selected customer.
        function loadreport(){
            var reportOption = {
                id: 'Reports/OrderDetailsReport.rdlx',
                parameters: [{ name: "CustomerID" }]
            };
            var custid = $('#CID').html();
            reportOption.parameters[0].value =parseInt(custid.toString());

            viewer.option('report', reportOption);
        }
    </script>
End Section

<body id="mainbody" data-ng-app="testapp" data-ng-controller="CustomerController">
    <!-- Navigation -->
    <div class="headerdiv">
        <img src="~/Content/Images/reels_logo.gif" />  ActiveReports and MVC5

    </div>
        

    <!-- Page Content -->
    <div id="MainDiv">
        <div class="mainleft">
            <form class="navbar-form" role="search">
                <div class="input-group">
                    <input type="text" class="form-control" placeholder="Search" ng-model="searchText.ContactName" id="text">
                </div>
            </form>
            <form class="navbar-form" role="search">
                <div ng-if="$first" ng-show="false" data-ng-repeat="customer in customers">
                    <p data-ng-init="CustomerDetail(customer)">{{ customer.ContactName }}</p>
                </div>
                <table id="tabmenu">
                    <tr>
                        <th><h3>Customer List</h3></th>
                    </tr>
                    <tr ng-if="$first" data-ng-repeat="customer in customers | filter:searchText ">
                        <td><a id="firstr" data-ng-click="CustomerDetail(customer)" onclick="checkActivefirst()" href="javascript:;">{{ customer.ContactName }}</a></td>
                    </tr>
                    <tr ng-show="$index > 0" data-ng-repeat="customer in customers |filter:searchText">
                        <td>
                            <a onclick="checkActive()" data-ng-click="CustomerDetail(customer)" href="javascript:;" id="firstleave">{{ customer.ContactName }}</a>
                        </td>
                    </tr>

                </table>
            </form>

        </div>
        <div class="mainRight">

            <div class="tabbable" style="min-width:450px">
                <ul class=" nav nav-tabs">
                    <li class="active"><a href="#pane1" data-toggle="tab">Customer Info</a></li>
                    <li><a href="#pane2" data-toggle="tab">Reports</a></li>
                </ul>
                <div class="tab-content">
                    <div id="pane1" class="tab-pane active">
                        <p><h3>Customer Details:</h3></p>
                        <table class="table">

                            <tr>
                                <td><b>ID:</b></td>
                                <td><span id="CID">{{customerDetail.CustomerId }}</span></td>
                            </tr>
                            <tr>
                                <td><b>Name:</b></td>
                                <td><span>{{customerDetail.ContactName}}</span></td>
                            </tr>
                            <tr>
                                <td><b>Address:</b></td>
                                <td><span>{{customerDetail.Address}}</span></td>
                            </tr>
                            <tr>
                                <td><b>City:</b></td>
                                <td><span>{{customerDetail.City}}</span></td>
                            </tr>
                            <tr>
                                <td><b>Country:</b></td>
                                <td><span>{{customerDetail.Country}}</span></td>
                            </tr>
                            <tr>
                                <td><b>Region:</b></td>
                                <td><span>{{customerDetail.Region}}</span></td>
                            </tr>
                            <tr>
                                <td><b>Postal Code:</b></td>
                                <td><span>{{customerDetail.PostalCode}}</span></td>
                            </tr>

                        </table>
                    </div>
                    <div id="pane2" class="tab-pane">
                        <div>
                            <div class="settings-row">
                                <label>Choose report:</label>
                                <!-- Bind reports to viewer when the buttons are clicked -->
                                <div id="btnReport" class="btn-group">
                                    <button type="button" class="btn btn-default" data-bind="Reports/OrderDetailsReport.rdlx">Orders (Page Report)</button>
                                    <button type="button" class="btn btn-default" data-bind="Reports/ProductsDetail.rpx">Product Details (Section Report)</button>
                                </div>
                            </div>
                            <br />
                            <div class="settings-row">
                                <label>Choose UI type:</label>
                                <!-- Change UI type of viewer when the buttons are clicked -->
                                <div id="btnUIType" class="btn-group" data-toggle="buttons-checkbox">
                                    <button class="btn btn-default active" data-bind="desktop">Desktop</button>
                                    <button class="btn btn-default" data-bind="mobile">Mobile</button>
                                </div>
                            </div>
                        </div>
                        <br />
                        <!-- The container element for the viewer -->
                        <div id="viewer">
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="footerdiv">
            <p>
				Contact <a href="mailto:activereports.sales@grapecity.com">activereports.sales@grapecity.com</a> | 1.800.858.2739
                | Raleigh: 1.984.242.0696 |    
                ©2019 GrapeCity, inc. All rights reserved.
            </p>
        </div>
</body>

