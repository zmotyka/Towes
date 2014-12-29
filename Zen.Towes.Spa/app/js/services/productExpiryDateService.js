app.service('ProductExpiryDateService', ['$rootScope', '$resource', 'ApiBasePath', function ($rootScope, $resource, ApiBasePath) {
    'use strict';

    this.getAll = function () {
        return $resource(ApiBasePath + 'productExpiryDate').query();
    }

    this.getForProduct = function (productId) {
        return $resource(ApiBasePath + 'productExpiryDate/' + productId).query();
    }
}]); 