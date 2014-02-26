var App = angular.module('pacientesRelatorio', []);
App.controller('IndexModel', function ($scope) {
    $scope.Data = dadosUsuarios;   

    $("#grid").kendoGrid({
        dataSource: {
            data: $scope.Data,
            pagesize: 30
        },
        filterable: {
            extra: false,
            messages: {
                filter: "Filtrar",
                clear: "Limpar"                
            },
            operators: {
                string: {                   
                    contains: "Contém a palavra",                    
                }
            }
        },
        pageable: {
            pageSize: 30            
        }
    });


});