var SimpleCrypto = angular.module('SimpleCrypto', []);

SimpleCrypto.controller('CryptoController', function CryptoController($scope, CryptoService, $timeout) {
    $scope.outputLog = [];

    $scope.Encrypt = function (input) {
        var errorAlert = function(msg) {
            $scope.alert = true;
            $scope.alertMsg = msg;
            $timeout(function () { $scope.alert = false; }, 3000);
        }

        if (!input | input === "") {
            errorAlert('пустой ввод');
            return;
        }

        CryptoService.Encrypt(input)
            .then(function (response) {
                $scope.outputLog.push({ input: input, output: response.data });
                console.log(response.data);
            }, function (response) {
                console.log(response.status);

                errorAlert('не удалось получить ответ');
            });
    }
});

SimpleCrypto.factory('CryptoService', ['$http', function ($http) {
    var CryptoService = {};

    CryptoService.Encrypt = function (input) {
        return $http.post('/Home/EncryptMsg', { input: input });
    };

    return CryptoService;
}]);