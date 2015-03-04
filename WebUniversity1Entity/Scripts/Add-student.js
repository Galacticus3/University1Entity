$(document).ready(function () {
    $("#AjaxAddStudent").click(function () {
            $.ajax({
                type: "POST",
                url: "/Students/AjaxAddStudent",
                data: { Name: $("#studentName").val(), Age: $("#studentAge").val(), GroupId: $(".form-control").val() }
            }).done(function (data) {
                    $("#studentsList").empty();
                    $.each(data, function (i, item) {
                        var tr = $('<tr>').append(
                            $('<td>').html('<input type="hidden" value="' + item.Id + '"/>'),
                            $('<td>').text(item.Name),
                            $('<td>').text(item.Age),
                            $('<td>').text(item.GroupName),
                            $('<td>').html('<a href="/Students/EditStudent/' + item.Id + '">Edit</a> | ' +
                              '<a href="/Students/DeleteStudent/' + item.Id + '">Delete</a>')
                           );
                        $('#studentsList').append(tr);
                    });
            });
        });
    });
