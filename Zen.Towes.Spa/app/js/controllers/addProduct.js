
app.controller('AddProductCtrl', ['$scope', '$location', '$routeParams', 'ProductService', 'ProductListRoute', function ($scope, $location, $routeParams, ProductService, ProductListRoute) {
    'use strict';

    var baseProduct = {
        name: '',
    };

    $scope.product = baseProduct;

    $scope.save = function (product) {
        ProductService.save(product).$promise
            .then(function () {
                $location.path(ProductListRoute);
            });
    }

    $scope.cancel = function () {
        $location.path(ProductListRoute);
    }
}]);



