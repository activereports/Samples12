var testapp = angular.module("testapp", []);
testapp.controller("CustomerController", function ($scope, $http) {
    $scope.loading = true;   
    //Used to display the data
    $http.get('/api/Customers/').then(function (data) {
        $scope.customers = data.data;
        $scope.loading = false;
    }, function () {
        $scope.error = "An Error has occured while loading data!";
        $scope.loading = false;
    });
    // used to display details 
    $scope.CustomerDetail = function () {       
        var customerdid = this.customer.CustomerId;
        $http.get('/api/Customers/' + customerdid).then(function (data) {           
            $scope.customerDetail = data.data;
        }, function (data) {
            $scope.error = "An Error has occured while reading the Customer Details! " + data;
            $scope.loading = false;
        });
    };
});
