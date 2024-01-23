//checking all inputs one by one for the validation
$(document).ready(function(){
    $(".popupData").css('display','none');
    const collectionOfRequiredData={};
    const collectionOfAdditionalData=[];
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
    $('#Country').on('change',updateAndShowStates);//chnage event for changing of state data
    $("form").submit(
        function(){
            event.preventDefault();
        }
    )
    $("#submit").click(

        function(){
            validationForFirstName();
            validationForLastName();
            validationForFathersName();
            validationForMothersName();
            // validationForPhoneNo();
            validationForDate();
            // validationForEmail();     
            validationForCountry();
            validationForState();
            validationForMarks();
            validationForPresentAddress();
            validationForPermanentAddress();
            validationForFiles();
            fetchingAdditionalfields();
        }
    )
    function validationForFirstName(){
        const firstName=$('input').val().trim();
        if(firstName.length>0)
        {
            //changing the text back to the original
            $("#Firstname").html(function(i,originalText)
            {
                return originalText.split("Required")[0]
            }).css("color","black")
            collectionOfRequiredData.FirstName=firstName;
        }
        else
        {
            if(!$('#Firstname').text().endsWith("Required"))
            $("#Firstname").html(function(i,orignalText){return orignalText+" Required"}).css("color","red")
        }
    }
    function validationForLastName(){
        const lastName=$('#lname').val().trim();
        if(lastName.length>0)
        {
            //changing the text back to the original
            $("#llname").html(function(i,originalText)
            {
                return originalText.split("Required")[0]
            }).css("color","black")
            collectionOfRequiredData.LastName=lastName;
        }
        else
        {
            if(!$("#llname").text().endsWith("Required"))
            $("#llname").html(function(i,orignalText){return orignalText+" Required"}).css("color","red")
        }
    }
    function validationForFathersName(){
        const fathersName=$('#Father').val().trim();
        if(fathersName.length>0)
        {
            //changing the text back to the original
            $("#lfname").html(function(i,originalText)
            {
                return originalText.split("Required")[0]
            }).css("color","black")
            collectionOfRequiredData.FathersName=fathersName;
        }
        else
        {
            if(!$("#lfname").text().endsWith("Required"))
            $("#lfname").html(function(i,orignalText){return orignalText+" Required"}).css("color","red")
        }
    }
    function validationForMothersName(){
        const mothersName=$('#Mother').val().trim();
        if(mothersName.length>0)
        {
            //changing the text back to the original
            $("#lmother").html(function(i,originalText)
            {
                return originalText.split("Required")[0]
            }).css("color","black")
            collectionOfRequiredData.MothersName=mothersName;
        }
        else
        {
            if(!$("#lmother").text().endsWith("Required"))
            $("#lmother").html(function(i,orignalText){return orignalText+" Required"}).css("color","red")
        }
    }
    /* function validationForPhoneNo(){
        let phoneNumberRegExp =/^\(?([0-9]{2})\)?[ ]?([0-9]{5})[ ]?([0-9]{5})$/;
        
        const phoneNumber=$('#Phone').val().trim();
        if(phoneNumber.length>0)
        {
            //changing the text back to the original
            $("#LabelPhone").html(function(i,originalText)
            {
                return originalText.split("Required")[0]
            }).css("color","black")
            if(phoneNumber.match(phoneNumberRegExp))
            {
                $('#LabelPhone').html(function(i,originalText){
                    return originalText.split("Invalid")[1]
                }).css("color","black");
                collectionOfRequiredData.PhoneNumber=phoneNumber;
                console.log(collectionOfRequiredData[phoneNumber]);
            }
            else
            {
                if(!$('#LabelPhone').text().startsWith("Invalid"))
                $('#LabelPhone').html(function(i,originalText){
            return "Invalid"+originalText;
        }).css("color","red");
    }
}
else
{
    if(!$("#LabelPhone").text().endsWith("Required"))
    $("#LabelPhone").html(function(i,orignalText){return orignalText+" Required"}).css("color","red")
}
}*/
function validationForDate(){
    const dateOfBirth=$('#Date').val();
    if(new Date(dateOfBirth)<new Date('2004-12-31'))
    {
        //changing the text back to the original
        $("#DOB").html(function(i,originalText)
        {
            return originalText.split("Required")[0]
        }).css("color","black")
        collectionOfRequiredData.DateOfBirth=dateOfBirth;
    }
    else
    {
        if(!$("#DOB").text().endsWith("Required"))
        $("#DOB").html(function(i,orignalText){return orignalText+" Required"}).css("color","red")
    }
}
/* function validationForEmail(){
        const mothersName=$('#Mother').val().trim();
        if(mothersName.length>0)
        {
            //changing the text back to the original
            $("#lmother").html(function(i,originalText)
            {
                return originalText.split("Required")[0]
            }).css("color","black")
            collectionOfRequiredData.MothersName=mothersName;
        }
        else
        {
            if(!$("#lmother").text().endsWith("Required"))
            $("#lmother").html(function(i,orignalText){return orignalText+" Required"}).css("color","red")
        }
    }*/
    function validationForCountry(){
        const countryName=$('#Country').val();
        if(countryName!==undefined)
        {
            collectionOfRequiredData.Country=countryName;
        }
    }
    function validationForState(){
        const stateName=$('#state').val();
        if(stateName!==undefined)
        {
            collectionOfRequiredData.State=stateName;
        }
    }
    function validationForPresentAddress(){
        const presentAddress=$('#Address').val().trim();
        if(presentAddress!=="")
        {
            //changing the text back to the original
            $("#presentAddressLabel").html(function(i,originalText)
            {
                return originalText.split("Required")[0]
            }).css("color","black")
            collectionOfRequiredData.PresentAddress=presentAddress;
        }
        else
        {
            if(!$('#presentAddressLabel').text().endsWith("Required"))
            $("#presentAddressLabel").html(function(i,orignalText){return orignalText+" Required"}).css("color","red")
        }
    }
    function validationForPermanentAddress(){
        const PAddress=$('#PAddress').val().trim();
        if(PAddress!=="")
        {
            //changing the text back to the original
            $(".PermanentAddress").html(function(i,originalText)
            {
                return originalText.split("Required")[0]
            }).css("color","black")
            collectionOfRequiredData.PermanentAddress=PAddress;
        }
        else
        {
            if(!$('.PermanentAddress').text().endsWith("Required"))
            $(".PermanentAddress").html(function(i,orignalText){return orignalText+" Required"}).css("color","red")
        }
    }
    function validationForMarks(){
        const marksOfTenthBoard=$('#B10Marks').val().trim();
        const marksOfTwelethBoard=$('#B12Marks').val().trim();
        if(marksOfTenthBoard!=="" || marksOfTwelethBoard!=="")
        {
            //changing the text back to the original
            $('.result').text('')
            collectionOfRequiredData.TenthMarks=marksOfTenthBoard;
            collectionOfRequiredData.TenthBoard=$('#Board').val();
            collectionOfRequiredData.TwelethMarks=marksOfTwelethBoard;
            collectionOfRequiredData.TwelethBoard=$('#Board12').val();
        }
        else
        {
           $('.result').text('Marks Required').css('color','red');
        }
    }
    function fetchingAdditionalfields(){
        if($('#mname').val().trim()!=="")
        collectionOfAdditionalData.MiddleName=$('#mname').val().trim();
        if($('#Hobbies').val().trim()!=="")
        collectionOfAdditionalData.Hobbies=$('#Hobbies').val().trim();
        if($('#altemail').val().trim()!=="")
        collectionOfAdditionalData.AlternateEmail=$('#altemail').val().trim();
        // if($('#AdditionalDocumentsupload').val().trim()!=="")
    }
    function validationForFiles(){
        let files;
        $('#requiredDocuments').change(function(e){files=e.target.files[0].name;})
        if(files.length>0)
        {
            $("#requiredDocumentsLabel").html(function(i,originalText)
            {
                return originalText.split("Required")[0]
            }).css("color","black")
            collectionOfRequiredData.Documents=files;
        }
        else{
            if(!$('#requiredDocumentsLabel').text().endsWith("Required"))
            $("#requiredDocumentsLabel").html(function(i,orignalText){return orignalText+" Required"}).css("color","red")
        }
    }
});