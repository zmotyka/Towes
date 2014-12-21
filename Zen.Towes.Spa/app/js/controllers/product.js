
app.controller('ProductCtrl', ['$scope', '$location', '$routeParams', 'ProductService', function ($scope, $location, $routeParams, ProductService) {
    'use strict';

    $scope.init = function () {
        ProductService.getAll().$promise
            .then(function (products) {
                $scope.products = products;
            });
    }

    $scope.init()
}]);



