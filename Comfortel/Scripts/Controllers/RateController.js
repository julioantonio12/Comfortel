﻿angular.module("app", [])
    .factory("CatalogFactory", [function () {
        var self = this;
        self.save = function (type, data) {
            data = angular.copy(data);
            console.log(data);
            console.log(type);
            switch (type) {
                case "Add":
                    $.ajax({
                        url: "/Rate/InsertRate",
                        type: "POST",
                        data: JSON.stringify({ rate: data }),
                        contentType: "application/json",

                        success: function (response) {
                            response ? alert("Guardado") : alert("Error al Guardar");
                        }
                    });
                    break;
                case "Edit":
                    //Ajax para editar
                    $.ajax({
                        url: "/Rate/EditRate",
                        type: "POST",
                        data: JSON.stringify({ rate: data }),
                        contentType: "application/json",

                        success: function (response) {
                            response ? alert("Modificado") : alert("Error al Modificar");
                        }
                    });
                    break;
            }
        }
        self.delete = function (idu) {
            console.log(idu);
            $.ajax({
                url: "/Rate/DeleteRate",
                type: "POST",
                data: JSON.stringify({ id: idu }),
                contentType: "application/json",

                success: function (response) {
                    response ? alert("Eliminado") : alert("Error al Eliminar");
                    $rootScope.Section = "";
                }
            });
        }
        return self;
    }])

    .controller("ListController", ["$scope", "$rootScope", "CatalogFactory", function ($scope, $rootScope, CatalogFactory) {
        //Llamadas asincronas
        $.ajax({
            url: "/Rate/GetRates",
            type: "POST",
            contentType: "application/json",

            success: function (response) {
                console.log(response);
                $rootScope.items = response;
            }
        });

        //Sirve para cuando la seccion esta vacia te muestra otras cosas
        $rootScope.Section = "";

        $scope.Add = function () {
            $rootScope.Section = "AddSection";
        };

        $scope.Edit = function (rate) {
            $rootScope.Section = "EditSection";
            $rootScope.$emit("Edit", angular.copy(rate));
        };

        $scope.Delete = function (rate) {
            if (confirm("Desea eliminar la tarifa?")) {
                CatalogFactory.delete(rate.Id).then(function () {
                    alert("Eliminado Correctamente");
                    $scope.Section = "";
                })
                    .catch(function () {
                        alert("Error al eliminar");
                    });
            }
        };
    }])

    .controller("AddController", ["$scope", "$rootScope", "CatalogFactory", function ($scope, $rootScope, CatalogFactory) {
        $scope.factory = CatalogFactory;
        $scope.save = function () {
            console.log($scope.item);
            $scope.cancel();
            CatalogFactory.save("Add", $scope.item).then(function () {
            })
                .catch(function () {
                    alert("Mal");
                });
        };

        $scope.cancel = function () {
            $rootScope.Section = "";
        };

    }])

    .controller("EditController", ["$scope", "$rootScope", "CatalogFactory", function ($scope, $rootScope, CatalogFactory) {

        $scope.factory = CatalogFactory;
        $scope.save = function () {
            console.log($scope.item);
            CatalogFactory.save("Edit", $scope.item).then(function () {
            })
                .catch(function () {
                    alert("Error");
                });
        }

        $rootScope.$on("Edit", function (event, data) {
            $scope.item = data;
        })

        $scope.cancel = function () {
            $rootScope.Section = "";
        };

    }]);

window.onload = function () {
    document.getElementById("input1").focus();
    document.getElementById("input1").blur();
}