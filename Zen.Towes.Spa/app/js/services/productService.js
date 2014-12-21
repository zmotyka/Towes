app.service('ProductService', ['$rootScope', '$resource', 'ApiBasePath', function ($rootScope, $resource, ApiBasePath) {
    'use strict';

    this.get = function (productId) {
        // todo: use productId to query the data
        return $resource('/data/singleProductData.json').get();
    }

    this.getAll = function () {
        return $resource(ApiBasePath + 'product').query();
        //return $resource('/data/productData.json').query();
    }

    this.save = function (product) {
        return $resource(ApiBasePath + 'product').save(product);
    }
}]); 