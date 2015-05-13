var app = angular.module('MeetNeighbours', []);



app.controller('MeetNeighboursController', function ($scope, $http, $filter, $location) {
    $scope.add = function () {
       
        $http.post('api/Category', this.Category).success(function (data) {
            alert("Added Successfully!!");

        }).error(function (data) {
            $scope.error = "An Error has occured while Adding Friend! " + data;
            $scope.loading = false;

        });
    };

});