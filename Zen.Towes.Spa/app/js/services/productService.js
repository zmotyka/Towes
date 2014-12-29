app.service('ProductService', ['$rootScope', '$resource', 'ApiBasePath', function ($rootScope, $resource, ApiBasePath) {
    'use strict';

    this.get = function (productId) {
        return $resource(ApiBasePath + 'product/' + productId).get();
    }

    this.getAll = function () {
        return $resource(ApiBasePath + 'product').query();
    }

    this.save = function (product) {
        return $resource(ApiBasePath + 'product').save(product);
    }
}]); 