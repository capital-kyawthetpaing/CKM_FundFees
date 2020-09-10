function CalltoApiController(url, model)
{
    var result;
    $.ajax({
        url: url.replace("%2F", "/"),
        method: 'POST',
        dataType: 'json',
        contentType: 'application/json; charset=utf-8',
        data: JSON.stringify(model),
        async: false,
        headers:
        {
            Authorization: 'Basic ' + btoa('Capital_MM' + ':' + 'CKM12345!')
        },
        success: function (data) {
            //alert("cc");
            result = data;
        },
    });
    return result;
}

function ShowConfirmMessage(msgid, functionname) {
    var Mmodel = {
        MessageID: msgid,
    };

    var data = CalltoApiController($("#MessageURL").val(), Mmodel);
    var msgdata = JSON.parse(data);

    Swal.fire({
        title: msgdata[0].MessageID,
        text: msgdata[0].MessageText1,
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#d33',
        cancelButtonColor: '#3085d6',
        confirmButtonText: 'YES',
        cancelButtonText: 'NO'
    }).then((result) => {
        if (result.value) {
            var fn = window[functionname];
            fn();
        }
    })
}

function ShowErrorMessage(msgid, functionname) {
    var Mmodel = {
        MessageID: msgid,
    };
    var data = CalltoApiController($("#MessageURL").val(), Mmodel)

    var msgdata = JSON.parse(data);

    Swal.fire({
        icon: 'error',
        title: msgdata[0].MessageID,
        text: msgdata[0].MessageText1,
    }).then(function () {
        if (functionname) {
            var fn = window[functionname];
            fn('NG');
        }
    })
}

function ShowSuccessMessage(msgdata, url) {
    var message = JSON.parse(msgdata);
    Swal.fire({
        icon: message[0].status,
        title: message[0].MessageID,
        text: message[0].MessageText1,
    }).then(function () {
        if (message[0].status != "error")
            location.href = url;
    });
}
function ErrorCheckOnSave() {
    var r1 = "0";
    $('#divMain').filter(':input').each(function () {
        var result = ErrChk(this);
        if (result != "0") {
            $(this).focus();
            r1 = result;
            return result;
        }
    });
    return r1;
}

function ErrChk(ctrl) {
    var req = $(ctrl).attr("data-Required");
    if (req == "1") {
        if (!$(ctrl).val()) {
            return "M106";
        }
    }

    if ($(ctrl).val()) {
        var dataExistsCheck = $(ctrl).attr("data-ExistsCheck");
        if (dataExistsCheck) {
            var ApiURL = $(ctrl).attr("data-ExistsApiUrl");
            var param1 = $(ctrl).attr("data-Param1");
            switch (dataExistsCheck) {
                case "Transaction":
                    var model = {
                        TransactionID: $(ctrl).val()
                    }
                    var data = CalltoApiController(ApiURL, model);
                    var TransactionData = JSON.parse(data);
                    if (TransactionData[0].MessageID != "M105") {
                        if ($(ctrl).attr("data-NameCtrl")) {
                            var ctrlName = $(ctrl).attr("data-NameCtrl");
                            $('#' + ctrlName).val(TransactionData[0].TransactionID);
                            return "0";
                        }
                    }
                    else {
                        if ($(ctrl).attr("data-NameCtrl")) {
                            var ctrlName = $(ctrl).attr("data-NameCtrl");
                            $('#' + ctrlName).val("");
                            return TransactionData[0].MessageID;

                        }
                    }
                    break;
            }
        }
    }
}