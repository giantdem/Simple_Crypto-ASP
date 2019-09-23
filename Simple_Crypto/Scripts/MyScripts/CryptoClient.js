var SimpleCrypto = angular.module('SimpleCrypto', []);

SimpleCrypto.controller('CryptoController', function CryptoController($scope, CryptoService, $timeout) {
    //массив значений лога зашифрованных сообщений
    $scope.outputLog = [];

    $scope.Encrypt = function (input) {
        //координатор работы шифрования

        //функция вывода сообщения об ошибке
        var errorAlert = function (msg) {
            //показываем сообщение
            $scope.alert = true;
            //указываем ошибку
            $scope.alertMsg = msg;
            //спустя время закрываем сообщение
            $timeout(function () { $scope.alert = false; }, 3000);
        }

        if (!input | input === "") {
            errorAlert('пустой ввод');
            return;
        }

        //работа с сервисом шифрования
        $scope.wait = true;
        CryptoService.Encrypt(input)
            .then(function (response) {
                //успех

                //добавляем запись в лог
                $scope.outputLog.push({ input: input, output: response.data });

                console.log(response.data);
            }, function (response) {
                //ошибка

                console.log(response.status);
                errorAlert('не удалось получить ответ');
            }).then(function () {
                $scope.wait = false;
            });
    }
});

SimpleCrypto.factory('CryptoService', ['$http', function ($http) {
    //сервис шифрования
    var CryptoService = {};

    CryptoService.Encrypt = function (input) {
        return $http.post('/Home/EncryptMsg', { input: input });
    };

    return CryptoService;
}]);