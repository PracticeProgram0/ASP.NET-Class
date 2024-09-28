

function AjaxByGet() {
    $.ajax({
        type: "GET",
        url: "/Home/AjaxCallGET",
        success: function (responce) {
            alert(responce);
        },
        error: function (error) {
            alert(error);
        }
    });
}

function AjaxByPost() {

    let objectdata = GetValue();
    $.ajax({
        type: "Post",
        url: "/Home/AjaxCallPost",
        data: objectdata,
        success: function (responce) {
            alert(responce);
        },
        error: function (error) {
            alert(error);
        }
    });
}

function GetValue() {

    let name = $('#Name').val();
    let age = $('#Age').val();
    let city = $('#City').val();

    let obj = {
        Name: name,
        Age: age,
        City:city

    }
    return obj;
}