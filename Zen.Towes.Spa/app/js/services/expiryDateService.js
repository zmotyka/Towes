app.service('ExpiryDateService', ['$rootScope', '$resource', 'ApiBasePath', function ($rootScope, $resource, ApiBasePath) {
    'use strict';

    this.getAll = function () {
        return $resource(ApiBasePath + 'expiryDate').get();
    }

    this.save = function (expiryDate) {
        return $resource(ApiBasePath + 'expiryDate').save(expiryDate);
    }
}]); 