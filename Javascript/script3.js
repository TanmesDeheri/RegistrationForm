//implemented one function taking all input and checking for validation
$(document).ready(function(){
   $(".popupData").css('display','none');
   const collectionOfRequiredData={};
    const collectionOfAdditionalData={};
    $("form").submit(
        function(){
            event.preventDefault();
        }
    )
    $("#submit").click(
        function(){
            if(valueOperation())
            {
                showPopup()
            }
        }
    )
    function valueOperation()
    {
        let flag=true
        const allLabelNames=$('label').text().split(":");
        const allInputValues=$('input')
        return flag;
    }
    function showPopup(){
        console.log("popupfunction works!")
    }
})