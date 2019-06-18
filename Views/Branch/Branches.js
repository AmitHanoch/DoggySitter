﻿(function(){

    // Make the request to get thte branches from the server
    $.ajax({
            url: "/Branch/GetBranches",
            cache: false,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            type: "GET",
            data: {},
            success: function (result) {
                $('#branchesList').html(renderBranchesList(result));
            },
            error: function (xhr, ajaxOptions, thrownError) {
                alert("Error: " + thrownError);
            }
            });


    function renderBranchesList(branches) {
        var branchesHTML = "";

        $.each(branches, function (index, value) {
            branchesHTML += getBranchAsHtmlElement(value) + " ";
        });

        return branchesHTML;
    }

    function getBranchAsHtmlElement(branchJsonObj) {
        return  '<div class="card" style="width: 18rem;">' +
                    '<div class="card-body">' +
                        '<h5 class="card-title">' + branchJsonObj.name + '</h5>' +
                        '<h6 class="card-subtitle mb-2 text-muted">' + branchJsonObj.address + '</h6>' +
                        '<p class="card-text">' + branchJsonObj.openingHours + '</p>'
                    ' </div> ' +
                '</div>';
    }


})();
    