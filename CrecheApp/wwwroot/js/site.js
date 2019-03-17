// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
    //function validate() {
    //if (document.SelectListItem("DaySelectList").value == "") {
    //    alert("Please select a day"); // prompt user
    //    document.getElementById("DaySelectList").focus(); //set focus back to control
    //    return false;
    //}

    // The validation check for the attribute days
    jQuery.validator.addMethod("Days",
        function (value, element, param) {

            return (value == "Monday" || value == "Tuesday" || value=="Wednesday" || value=="Thursday" || value=="Friday");
        });

    // Registering the validation check.
    jQuery.validator.unobtrusive.adapters.addBool("Days");
