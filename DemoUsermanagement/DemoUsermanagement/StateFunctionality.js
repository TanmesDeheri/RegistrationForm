$(document).ready(function () {
    $("#<%= Country.ClientID %>").change(function () {
        var countryId = $(this).val();
        $.ajax({
            type: "POST",
            url: "RegistrationForm.aspx/GetStatesForCountry",
            data: JSON.stringify({ countryId: countryId }),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (response) {
                var states = response;
                if (response && response.length() > 0) {
                    var stateDropdown = $("#<%= state.ClientID %>");
                    stateDropdown.empty();
                    $.each(states, function (index, state) {
                        stateDropdown.append($("<option></option>").val(state.StateID).text(state.StateName));
                    });
                }
                else {
                    alert("NO states Found for selected Country");
                }
                // Populate the State DropDownList with the retrieved states
            },
            failure: function (response) {
                alert("Failed to load states.");
            }
        })
    })
})