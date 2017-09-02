


/*$(document).ready(function () {
    $(function () {
        $("#datetimepicker1").datepicker();
    });
}); */


$(function () {
    $("#datepicker1").datepicker({
        numberOfMonths: 1,
        onSelect: function (selected) {
            $("#datepicker2").datepicker("option", "minDate", selected)
        }
    });
    $("#datepicker2").datepicker({
        numberOfMonths: 1,
        onSelect: function (selected) {
            $("#datepicker1").datepicker("option", "maxDate", selected)
        }
    });
});