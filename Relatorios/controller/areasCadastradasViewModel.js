var App = angular.module('areasCadastradas', []);
App.controller('IndexModel', function ($scope) {
    $scope.NumCadastrados = numerosCadastrados;   

    $("#grid").kendoGrid({
        dataSource: {
            data: $scope.NumCadastrados,
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