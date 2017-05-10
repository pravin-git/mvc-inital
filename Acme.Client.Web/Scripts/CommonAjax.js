var acme = acme || {};

acme.ajax = (function ($) {

    var sayHello = function (name) {
        console.log("Hi " + name);
    };

    var postJson = function (url, data, successCallback, errorCallback) {
        $.ajax({
            url: url,
            data: data,
            cache: false,
            type: 'POST',
            datatype: 'json',
            success: successCallback,
            error: errorCallback
        });
    };

    var postJsonSynchronous = function (url, data, successCallback, errorCallback) {
        $.ajax({
            url: url,
            data: data,
            async: false,
            cache: false,
            type: 'POST',
            datatype: 'json',
            success: successCallback,
            error: errorCallback
        });
    };
    var postJsonSyncWithFile = function (url, data, successCallback, errorCallback) {
        $.ajax({
            url: url,
            data: data,
            processData: false,
            async: false,
            cache: false,
            type: 'POST',
            datatype: 'json',
            contentType: false,
            success: successCallback,
            error: errorCallback
        });
    };
    var getJson = function (url, data, successCallback, errorCallback) {
        $.ajax({
            url: url,
            data: data,
            cache: false,
            type: 'GET',
            datatype: 'json',
            success: successCallback,
            error: errorCallback
        });
    };

    bindDropdown = function (dropdownId, data, selected) {
        $.each(data, function (val, text) {
            $(dropdownId).append($('<option></option>').val(val).html(text))
        });
        $(dropdownId).val(selected);

    }

    var getHtml = function (url, data, successCallback, errorCallback) {
        $.ajax({
            url: url,
            data: data,
            async: true,
            cache: false,
            type: 'GET',
            datatype: 'Html',
            success: successCallback,
            error: errorCallback
        });
    };

    var getJsonSynchronous = function (url, data, successCallback, errorCallback) {
        $.ajax({
            url: url,
            data: data,
            async: false,
            cache: false,
            type: 'GET',
            datatype: 'json',
            success: successCallback,
            error: errorCallback
        });
    };

    var postJsonWithFile = function (url, data, successCallback, completeCallback, errorCallback) {
        $.ajax({
            url: url,
            data: data,
            processData: false,
            cache: false,
            type: 'POST',
            datatype: 'json',
            contentType: false,
            success: successCallback,
            complete: completeCallback,
            error: errorCallback
        });
    };

    var postJsonlong = function (url, data, successCallback, errorCallback) {
        $.ajax({
            url: url,
            data: data,
            timeout: (600 * 1000),
            cache: false,
            type: 'POST',
            datatype: 'json',
            success: successCallback,
            error: errorCallback
        });
    };

    return {
        postJson: postJson,
        postJsonlong: postJsonlong,
        getJson: getJson,
        postJsonSynchronous: postJsonSynchronous,
        getJsonSynchronous: getJsonSynchronous,
        postJsonSyncWithFile: postJsonSyncWithFile,
        postJsonWithFile: postJsonWithFile,
        getHtml: getHtml,
        sayHello: sayHello,
        bindDropdown: bindDropdown
    };
})($);