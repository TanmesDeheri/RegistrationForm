//implemented one function taking all input and checking for validation
$(document).ready(function(){
    const countryAndStateData={
        "CHINA":['Beijing', 'Tianjin', 'Shanghai','Chongqing'],
        "RUSSIA":["Primorsky Krai","Khabarovsk krai","Buryatia","Krasnodar Krai"],
        "INDIA":["New Delhi","Mumbai","Odisha","Uttar Pradesh"],
        "USA":["Alaska","Arizona","California","Rhode Island","Ohio"]
    }
    function UpdateCountry()
    {
      for(const input in countryAndStateData)
      {
          const option=document.createElement('option');
          option.value=input;//storing the keys to the options
          option.textContent=input;
          $('#Country').append(option);
      }
    }
    function updateAndShowStates(){
        const selectedCountry=$('#Country').val();
        const groupOfStates=countryAndStateData[selectedCountry] || [];
        $('#state').html('');
        for(const input in groupOfStates)
        {
            const option=document.createElement('option');
            option.value=groupOfStates[input];
            option.textContent=groupOfStates[input];
            $('#state').append(option);
        }
    }
    UpdateCountry();
    updateAndShowStates();
    $('#Country').on('change',updateAndShowStates);
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