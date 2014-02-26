var App = angular.module('Login', []);
App.controller('IndexModel', function ($scope) {
    $(document).ready(function () {
        $("#UsuarioNome").focus();
    });

    $scope.Usuario = {
        Nome: '',
        Data: '',
        Mae: '',
        Idade: '',
        Telefone: '',
        Logradouro: ''
    };
    //    $("#btnMostrar").click(function () {
    //        User = $scope.Usuario;
    //        $("#Entrada").removeClass("show", 1000);
    //        $("#Entrada").addClass("hide", 1000);
    //        $("#_fichaAvulsa").removeClass("show", 1000);
    //        $("#_fichaAvulsa").addClass("show", 1000);
    //        window.print();
    //        window.location.reload(false);
    //    });

    $("#UsuarioNome").keydown(function (event) {
        if (event.which == 13) {
            $("#UsuarioData").focus();
        }
    });
    $("#UsuarioData").keydown(function (event) {
        if (event.which == 13) {
            $("#UsuarioNomeMae").focus();
        }
    });
    $("#UsuarioNomeMae").keydown(function (event) {
        if (event.which == 13) {
            $("#UsuarioTelefone").focus();
        }
    });
    $("#UsuarioTelefone").keydown(function (event) {
        if (event.which == 13) {
            $("#UsuarioLogradouro").focus();
        }
    });
    $("#UsuarioLogradouro").keydown(function (event) {
        if (event.which == 13) {
            $("#btnMostrar").focus();
        }
    });

    $("#form").submit(function (event) {
        User = $scope.Usuario;
    });
});
