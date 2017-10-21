(document).ready(function () {

    var tablePais = $('#tbPais').DataTable(
        {
            "stateSave": true,
            "language": {
                "lengthMenu": "Mostrando  _MENU_  registros por página",
                "zeroRecords": "No existen registros",
                "info": "Mostrando página _PAGE_ de _PAGES_",
                "infoEmpty": "No existen registros disponibles",
                "infoFiltered": "(filtrados de _MAX_ registros totales)",
                "search": "Buscar:",
                "paginate": {
                    "first": "Primera",
                    "last": "Ultima",
                    "next": "Siguiente",
                    "previous": "Anterior"
                }
            },
            "lengthMenu": [[2, 5, 10, 25, 50, -1], [2, 5, 10, 25, 50, "Todos"]]
        }
    );

    $('#tbPais tbody').on('click', 'td', function () {
        var rowIndex = tablePais.cell(this).data();
        if ($(rowIndex).attr("class") === "btnEditPais") {
            $(" #nombrePais").empty();
            var rowIdx = tablePais
                .cell(this)
                .index().row;

            var data = tablePais.rows(this).data();
            data = data[0];
            $("#paisId").val(data[1]);
            $("#paisnombre").val(data[2]);
            $("#paisEstado").val(data[3]);

            $('#modalEditPais').modal('show');
        }
    });

    $('#btnNuevoPais').on('click', function () {
        $('#modalNewPais').modal('show');
    });

    $('.btnDeletePais').on('click', function () {
        $.confirm({
            title: 'Confirmar!',
            type: 'orange',
            typeAnimated: true,
            theme: 'modern',
            content: '¿Esta seguro de eliminar el registro?',
            buttons: {
                Cancelar: {
                    action: function () {

                    }
                }
                ,
                Confirmar:
                {
                    btnClass: 'btn-warning',
                    action: function () {
                        $.alert('Registro eliminado correctamente!');
                    }
                }
            }
        });
    });



});