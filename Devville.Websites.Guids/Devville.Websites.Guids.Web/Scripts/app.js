'use strict';
var devville = devville || {};
devville.guids = devville.guids || {};

window.app = window.app || {
    name: "guids.azurewebsites.net",
    author: "Ahmed Magdy (ahmed.magdy@devville.net)",
    source: "https://github.com/Devville/guids.azurewebsites.net"
};


$(function () {
    devville.guids.get();
    $("#btn-new-guid").click(devville.guids.get);

});

devville.guids.get = function () {
    $(".new-guid-loading").show();
    var loadingDiv = '<div title="Loading..." class="loading new-guid-loading"></div>';

    $("#guid-raw").html('<span title="Loading..." class="loading new-guid-loading"></span>');
    $("#braces-lower").html(loadingDiv);
    $("#braces-upper").html(loadingDiv);
    $("#digital-lower").html(loadingDiv);
    $("#digital-upper").html(loadingDiv);
    $("#hexadecimal-lower").html(loadingDiv);
    $("#hexadecimal-upper").html(loadingDiv);
    $("#hyphens-lower").html(loadingDiv);
    $("#hyphens-upper").html(loadingDiv);
    $("#parentheses-lower").html(loadingDiv);
    $("#parentheses-upper").html(loadingDiv);
    $.getJSON("/api/new", function (guid) {
        if (!guid) {
            return;
        }

        
        document.title = "Guids: " + guid.raw.toString();
        
        $("#guid-raw").html(guid.raw);
        $("#braces-lower").html(guid.bracesLowerCaseFormat);
        $("#braces-upper").html(guid.bracesUpperCaseFormat);
        $("#digital-lower").html(guid.digitalLowerCaseFormat);
        $("#digital-upper").html(guid.digitalUpperCaseFormat);
        $("#hexadecimal-lower").html(guid.hexadecimalLowerCaseFormat);
        $("#hexadecimal-upper").html(guid.hexadecimalUpperCaseFormat);
        $("#hyphens-lower").html(guid.hyphensLowerCaseFormat);
        $("#hyphens-upper").html(guid.hyphensUpperCaseFormat);
        $("#parentheses-lower").html(guid.parenthesesLowerCaseFormat);
        $("#parentheses-upper").html(guid.parenthesesUpperCaseFormat);
        $(".new-guid-loading").hide();
    });
};