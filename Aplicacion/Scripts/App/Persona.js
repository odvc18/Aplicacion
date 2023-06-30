function CargarPersonas(datos) {
    var table = $('#GrillaPersonas').DataTable();
    table.destroy();
    var data = [];
    $('#GrillaPersonas').DataTable({
        data: datos,
        "filter": true,
        "pageLength": 5,
        columns: [
            { "data": "Nombre" },
            { "data": "Apellido" },
            { "data": "FechaNacimientoStr" },
            { "data": "CorreoStr" },
            { "data": "DireccionStr" },
            { "data": "TelefonoStr" }
        ],
        "columnDefs":
            [
                {
                    "targets": 0,
                    "data": datos,
                    render: function (data, type, row, meta) {
                        return '<p>' + row.Nombre + '</p>';
                    }
                },
                {
                    "targets": 1,
                    "data": datos,
                    render: function (data, type, row, meta) {
                        return '<p>' + row.Apellido + '</p>';
                    }
                },
                {
                    "targets": 2,
                    "data": datos,
                    render: function (data, type, row, meta) {
                        return '<p>' + row.FechaNacimientoStr + '</p>';
                    }
                },
                {
                    "targets": 3,
                    "data": datos,
                    render: function (data, type, row, meta) {
                        return '<p>' + row.CorreoStr + '</p>';
                    }
                },
                {
                    "targets": 4,
                    "data": datos,
                    render: function (data, type, row, meta) {
                        return '<p>' + row.DireccionStr + '</p>';
                    }
                },
                {
                    "targets": 5,
                    "data": datos,
                    render: function (data, type, row, meta) {
                        return '<p>' + row.TelefonoStr + '</p>';
                    }
                }
            ],

        "language": {
            "lengthMenu": "Mostrando _MENU_ registros por pagina",
            "zeroRecords": "Sin resultados",
            "info": "Registro: _START_ a _END_ de _TOTAL_ en total",
            "infoEmpty": "No se cargaron registros",
            "infoFiltered": "(Filtrados de _MAX_ en total)",
            "search": "Buscar",
            "paginate": {
                "first": "Primero",
                "last": "Ultimo",
                "next": "Siguiente",
                "previous": "Anterior"
            },

        },
        "lengthMenu": [5, 10, 15],
    });
}