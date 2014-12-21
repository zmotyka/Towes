
app.controller('AddProductCtrl', ['$scope', '$location', '$routeParams', 'ProductService', function ($scope, $location, $routeParams, ProductService) {
    'use strict';

    var redirectRoute = '/products';

    var baseProduct = {
        name: '',
        imgSrc: ''
    };

    $scope.product = baseProduct;

    $scope.save = function (product) {
        ProductService.save(product).$promise
            .then(function () {
                $location.path(redirectRoute);
            });
    }

    $scope.cancel = function () {
        $location.path(redirectRoute);
    }
}]);



