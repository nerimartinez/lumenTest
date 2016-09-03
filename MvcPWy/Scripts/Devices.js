$(document).ready(function () {
    var table;
    var recordToDelete;

    //submit devices list
    $("#submitToLumen").click(function (event) {
        event.preventDefault();
        if (table.data().count() == 0) {
            $('#noDeviceModal').modal('show')
        }
        else {
            $.ajax({
                url: '/home/done',
                success: function () {
                    window.location.replace("/home/InfoSubmission");
                }
            });
        }
    });

    //form validator for ip's
    $.validator.addMethod('IP4Checker', function (value) {
        var split = value.split('.');
        if (split.length != 4)
            return false;

        for (var i = 0; i < split.length; i++) {
            var s = split[i];
            if (s.length == 0 || isNaN(s) || s < 0 || s > 255)
                return false;
        }
        return true;
    }, ' Invalid IP Address');

    //form validator
    var validator = $('#deviceForm').validate({
        ignore: "",
        rules: {
            NickName: {
                required: true
            },
            ZipCode: {
                required: true
            },
            IpAddress: {
                required: true,
                IP4Checker: true
            },
            NIC1IpAddress: {
                required: true,
                IP4Checker: true
            },
            NIC1SubNetMask: {
                required: true,
                IP4Checker: true
            },
            NIC1DefaultGateway: {
                required: true,
                IP4Checker: true
            },
            NIC1NATIpAddress: {
                required: true,
                IP4Checker: true
            },
            NIC2IpAddress: {
                required: true,
                IP4Checker: true
            },
            NIC2SubNetMask: {
                required: true,
                IP4Checker: true
            },
            NIC2DefaultGateway: {
                required: true,
                IP4Checker: true
            }
        }
    });

    //add or edit a device
    $("#submitDevice").click(function (event) {
        var isValid = $('#deviceForm').valid();
        var serialForm;
        event.preventDefault();
        if (isValid) {
            $("#completeRequired").hide();
            serialForm = $('#deviceForm').serializeArray();
            var Man = { name: "ManufacturerId", value: $("#manufacturersSelect option:selected").val() };
            serialForm.push(Man);

            var Mod = { name: "ModelId", value: $("#modelsSelect option:selected").val() };
            serialForm.push(Mod);

            var Pol = { name: "PolicyId", value: $("#policiesSelect option:selected").val() };
            serialForm.push(Pol);

            var Loc = { name: "LocationId", value: $("#locationsSelect option:selected").val() };
            serialForm.push(Loc);

            if ($('#staticRadio').is(':checked'))
            {
                serialForm[2].value = 1;
            }

            if (serialForm[0].value == "") {
                $.post("/api/device", serialForm, function (data) {
                    table.row.add({
                        "Id": data.Id,
                        "NickName": data.NickName,
                        "Manufacturer": data.Manufacturer,
                        "Model": data.Model,
                        "IpAddress": data.IpAddress,
                        "Policy": data.Policy
                    }).draw();
                    $('#deviceForm')[0].reset();
                    $('#deviceInformationModal').modal('hide')
                });
            }
            else {
                var t = serialForm;
                $.ajax({
                    url: '/api/device',
                    type: 'PUT',
                    data: serialForm,
                    success: function (data) {
                        $('#deviceForm')[0].reset();
                        table
                         .row($(recordToDelete))
                         .remove()
                         .draw();
                        table.row.add({
                            "Id": data.Id,
                            "NickName": data.NickName,
                            "Manufacturer": data.Manufacturer,
                            "Model": data.Model,
                            "IpAddress": data.IpAddress,
                            "Policy": data.Policy
                        }).draw();
                        $("#Id").val("")
                        $('#deviceInformationModal').modal('hide')
                    }
                });
            }
        }
        else {
            $("#completeRequired").show();
        }
    });

    //new device screen
    $('#new').on('click', function () {
        $('#deviceForm')[0].reset();
        $("#Id").val("")
        validator.resetForm();
        $("#completeRequired").hide();
        $('#deviceInformationModal').modal('show');
    });

    //remove device screen
    $('#devicesTable').on('click', '.editor_remove', function () {
        recordToDelete = $(this).parents("tr");
        $('#deleteModal').modal('show');
    });

    //delete a device
    $('#confirmDelete').on('click', function () {
        $.ajax({
            url: "/api/device/" + $($(recordToDelete).children()[0]).text(),
            type: 'DELETE',
            success: function () {
                table
                .row($(recordToDelete))
                .remove()
                .draw();
            }
        });
    });

    //populate the form
    function populate(frm, data) {
        $.each(data, function (key, value) {
            $('[name=' + key + ']', frm).val(value);
        });
    }

    //edit device screen
    $('#devicesTable').on('click', '.editor_edit', function () {
        validator.resetForm();
        $("#completeRequired").hide();
        $('#deviceInformationModal').modal('show');
        var id = $($(this).parents("tr").children()[0]).text();
        recordToDelete = $(this).parents("tr");
        $.get("/api/device/" + id, function (data, status) {
            populate('#deviceForm', data);
            $("#locationsSelect").val(data.Location.Id);
            var options = $("#modelsSelect");
            options.find('option').remove().end();
            $("#manufacturersSelect").val(data.Manufacturer.Id);

            var manId = $("#manufacturersSelect option:selected").val();
            $.get("/api/model?manufacturerId=" + manId, function (dataMan, status) {

                $.each(dataMan, function () {
                    options.append($("<option />").val(this.Id).text(this.Name));
                });
                $("#modelsSelect").val(data.Model.Id);
            });
            if (data.IpType == 1) {
                $("#staticRadio").prop('checked', true);
            }
            $("#policiesSelect").val(data.Policy.Id);
        });
    });

    //get devices and setup the table
    $.get("/api/device", function (data, status) {
        table = $('#devicesTable').DataTable({
            data: data,
            columns: [
            { data: 'Id' },
            { data: 'NickName' },
            { data: 'Manufacturer' },
            { data: 'Model' },
            { data: 'IpAddress' },
            { data: 'Policy' },
            {
                data: null,
                className: "center",
                defaultContent: '<span class="editor_edit glyphicon glyphicon-edit" ></span> / <span class="editor_remove glyphicon glyphicon-remove-sign" ></span>'
            }
            ],
            "columnDefs": [
            {
                "targets": [6],
                "searchable": false,
                "sortable": false
            }
            ]
        });
    });

    //get locations
    $.get("/api/location", function (data, status) {
        var options = $("#locationsSelect");
        $.each(data, function () {
            options.append($("<option />").val(this.Id).text(this.Name));
        });
    });

    //get policies
    $.get("/api/policy", function (data, status) {
        var options = $("#policiesSelect");
        $.each(data, function () {
            options.append($("<option />").val(this.Id).text(this.Value));
        });
    });

    //get manufacturers and models
    $.get("/api/manufacturer", function (data, status) {
        var options = $("#manufacturersSelect");
        $.each(data, function () {
            options.append($("<option />").val(this.Id).text(this.Name));
        });

        $.get("/api/model?manufacturerId=" + data[0].Id, function (data, status) {
            var options = $("#modelsSelect");
            $.each(data, function () {
                options.append($("<option />").val(this.Id).text(this.Name));
            });
        });
    });

    //change on manufacturers select box
    $('#manufacturersSelect').on('change', function () {
        var options = $("#modelsSelect");
        options.find('option').remove().end();

        $.get("/api/model?manufacturerId=" + this.value, function (data, status) {

            $.each(data, function () {
                options.append($("<option />").val(this.Id).text(this.Name));
            });
        });
    });
});