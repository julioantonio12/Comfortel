angular.module("app", [])
    .controller("LogInController", ["$scope", function ($scope) {
        $scope.save = function(){
            $.ajax({
                url: "/LogIn/GetUser",
                type: "POST",
                contentType: "application/json",

                success: function (response) {
                    console.log(response);
                    alert("Se obtuvo algo");
                }
            });
        }

    }]);