
var myapp = angular.module("myapp", ["ngRoute"]);


myapp.config(function($routeProvider) {
    $routeProvider
    .when("/", {
        templateUrl : "index.html",
        controller : "viewcontroller"
    })
    .when("/case", {
        templateUrl : "views/Case/CASE1.html",
        controller : "casecontroller"
    })
    .when("/employee", {
        templateUrl : "employee.html",
        controller : "views/Employee/employeecontroller"
    })
});
myapp.controller("viewcontroller", function ($scope) {
  $scope.employeelist=[{name:"nisha", id:755383, employer:"infosys"},
                       {name:"rose", id:755383, employer:"infosys"},
                     {name:"nivi", id:755383, employer:"infosys"},
                     {name:"nisha", id:755383, employer:"infosys"},
                    {name:"rose", id:755383, employer:"infosys"},
                      {name:"nivi", id:755383, employer:"infosys"}];
});


myapp.controller("employeecontroller", function ($scope) {

});


myapp.controller("casecontroller", function ($scope) {

});
