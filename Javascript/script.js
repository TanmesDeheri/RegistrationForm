//Form related script
const form=document.querySelector('form')
form.addEventListener('submit',e=>{
    e.preventDefault();
    console.log('prevent default is working');
    formValidation();})
const formValidation=()=>{
    const firstName=document.getElementsByName('fname')[0].value;
    const middleName=document.getElementsByName('mname')[0].value
    const lastName=document.getElementsByName('lname')[0].value;
    const fathersName=document.getElementsByName('Father')[0].value;
    const mothersName=document.getElementsByName('Mother')[0].value;
    const phoneNo=document.getElementsByName('Phone')[0].value;
    const email=document.getElementsByName('email')[0].value;
    const altEmail=document.getElementsByName('altemail')[0].value;
    const tenthMarks=document.getElementsByName('10Marks')[0].value;
    const twelethMarks=document.getElementsByName('12Marks')[0].value;
    const presentAddress=document.getElementsByName('Address')[0].value;
    const permanentAddress=document.getElementsByName('PAddress')[0].value;
    const hobbies=document.getElementsByName('Hobbies')[0].value;
    const result=document.getElementsByClassName('result')[0];
    const fieldArray=[firstName,lastName,fathersName,mothersName,phoneNo,email,tenthMarks,twelethMarks,presentAddress,permanentAddress];
    // fieldArray.forEach(validateRequiredFields);
    // function validateRequiredFields(input,index)
    // {
    //     console.log(input)
    //     if(input.trim()=="")
    //     {
    //         console.log(input,index)
    //         // console.log('Field name required');
    //         document.getElementsByClassName('result')[0].innerHTML=`${fieldArray[index]} required`;
    //     }
    // }
    let flag=0;
    if(firstName.trim()=="")
    {
        result.innerHTML='first name required';
        
    }
    else if(lastName.trim()=="")
    {
        result.innerHTML='last name required';
    }
    else if(fathersName.trim()=="")
    {
        result.innerHTML='father name required';
    }
    else if(mothersName.trim()=="")
    {
        result.innerHTML='mothers name required';
    }
    else if(phoneNo=="")
    {
        result.innerHTML='phone number required';
    }
    else if(email.trim()=="")
    {
        result.innerHTML='email required';
    }
    else if(tenthMarks=="" || twelethMarks=="")
    {
        result.innerHTML='marks required';
    }
    else{
        flag=1;
    }
    // if(flag==1)
    openPopup(fieldArray);
}
function openPopup(fieldArray){
    console.log('popup works')
    console.log(fieldArray)
    const popup=document.querySelector('.popupData')
    console.log(popup)
    popup.innerHTML="";
    const ul=document.createElement('ul');
    for(i=0;i<fieldArray.length;i++)
    {
        console.log(fieldArray[i]);
        const li=document.createElement('li');
        li.textContent=fieldArray[i];
        ul.appendChild(li)
    }
    popup.appendChild(ul)
}