﻿

$(document).ready(function () {

    // Set the checkbox is checked when user select a row.
    $('#content_table tbody tr').click(function () {

        $(this).toggleClass('active');

        var numberOfRowSelected = $('#content_table tr.active').length;

        if (numberOfRowSelected > 0) {
            $('#btn_delete').removeClass('disabled');
            $('#btn_uncheck').show();
        }
        else {
            $('#btn_delete').addClass('disabled');
            $('#btn_uncheck').hide();
        }
    });

    // Unselect all selected rows
    $('#btn_uncheck').click(function () {
        $('#content_table tbody tr.active').each(function () {
            $(this).removeClass('active');
        });
        $('#btn_delete').addClass('disabled');
        $(this).hide();
    });
});
