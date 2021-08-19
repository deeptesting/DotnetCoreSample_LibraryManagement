 
//$(function () {
    function ShowMessage(result,targetDiv) {
        var cssClass = "";
        if (result.status < 0) {
            cssClass = "msg-red";
        } else {
            cssClass = "msg-green";
        }
        var html = ' <div class="update col-md-10 ml-auto mr-auto msg-info ' + cssClass + '">' + result.message+'<i class="fa fa-times" id="closeMsg" aria-hidden="true" style="font-size: 1.2rem;font-weight: 400;float: right;"></i></div>';
        if ($('#' + targetDiv).length > 0) {
            $('#' + targetDiv).html('');
            $('#' + targetDiv).html(html);
            $('#' + targetDiv).show();

            setTimeout(function () { $('#' + targetDiv).hide(); },10000);
        }
    }
        //$("#AddEditBook").submit(function (e) {
        //    e.preventDefault();
        //    if (!$(this).valid()) { return false; }
        //    var formAction = $(this).attr("action");
        //    var fdata = new FormData(document.querySelector('#' + $(this).attr("id")));
        //    //var fileInput = $('#uploadfile')[0];
        //    //var file = fileInput.files[0];
        //    //fdata.append("file", file);
        //    $.ajax({
        //        type: 'post',
        //        url: formAction,
        //        headers: { "RequestVerificationToken": $('input[name="__RequestVerificationToken"]').val() },
        //        data: fdata,
        //        processData: false,
        //        contentType: false
        //    }).done(function (result) {
        //        console.log(result);
        //        if (result.status === "success") {
        //            alert(result.url);
        //        } else {
        //            alert(result.message);
        //        }
        //    });
        //});
   // })
 