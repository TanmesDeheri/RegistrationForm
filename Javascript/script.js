//Form related script
document.querySelector('.popupData').style.display = 'none'
const form = document.querySelector('form')
form.addEventListener('submit', e => {
    e.preventDefault();
    console.log('prevent default is working');
    formValidation();
})
const formValidation = () => {
    const firstName = document.getElementsByName('fname')[0].value;
    const middleName = document.getElementsByName('mname')[0].value
    const lastName = document.getElementsByName('lname')[0].value;
    const fathersName = document.getElementsByName('Father')[0].value;
    const mothersName = document.getElementsByName('Mother')[0].value;
    const phoneNo = document.getElementsByName('Phone')[0].value;
    const email = document.getElementsByName('email')[0].value;
    const altEmail = document.getElementsByName('altemail')[0].value;
    const tenthMarks = document.getElementsByName('10Marks')[0].value;
    const tenthBoard=document.getElementsByName('boardTen')[0].value;
    const twelethMarks = document.getElementsByName('12Marks')[0].value;
    const twelethBoard=document.getElementsByName('boardTwelve')[0].value;
    const presentAddress = document.getElementsByName('Address')[0].value;
    const permanentAddress = document.getElementsByName('PAddress')[0].value;
    const hobbies = document.getElementsByName('Hobbies')[0].value;
    const result = document.getElementsByClassName('result')[0];
    const dateOfBirth = document.getElementsByName('Date')[0].value;
    const country = document.getElementsByName('Country')[0].value
    const state = document.getElementsByName('state')[0].value
    const gender = document.getElementsByName('gender')
    let genderSelected
    for (let i = 0; i < gender.clientHeight; i++) {
        if (gender[i].checked) {
            genderSelected = gender[i].value
            break
        }
    }
    for (const input in gender) {
        if (input.checked) {
            genderSelected = input.value
            break
        }
    }
    console.log(genderSelected)
    // const optionalSubjects=document.getElementsByName('subjects')
    // let optionalSubjectsSelected
    // for (const input of optionalSubjects)
    // {
    //     if(input.checked)
    //     {
    //         optionalSubjectsSelected=input.value;
    //         break;
    //     }
    // }
    const fieldArray = {
        'firstName': firstName,
        'lastName': lastName,
        'dateOfBirth': dateOfBirth,
        // 'gender':genderSelected,
        'fathersName': fathersName,
        'mothersName': mothersName,
        'phoneNo': phoneNo,
        'email': email,
        'country':country,
        'state':state,
        'tenthMarks': tenthMarks,
        'Board':tenthBoard,
        'twelethMarks': twelethMarks,
        'Board':twelethBoard,
        // 'optionalSubject':optionalSubjectsSelected,
        'presentAddress': presentAddress,
        'permanentAddress': presentAddress
    };
    const additionalData = {
        'middleName': middleName,
        'altemail': altEmail,
        'hobbies': hobbies
    }
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
    let flag = 0;
    if (firstName.trim() == "") {
        result.innerHTML = 'first name required';
    }
    else if (lastName.trim() == "") {
        result.innerHTML = 'last name required';
    }
    else if (fathersName.trim() == "") {
        result.innerHTML = 'father name required';
    }
    else if (mothersName.trim() == "") {
        result.innerHTML = 'mothers name required';
    }
    else if (phoneNo == "") {
        result.innerHTML = 'phone number required';
    }
    else if (dateOfBirth === "") {
        result.innerHTML = 'Date of Birth required'
    }
    else if (email.trim() == "") {
        result.innerHTML = 'email required';
    }
    else if (tenthMarks == "" || twelethMarks == "") {
        result.innerHTML = 'marks required';
    }
    else if (presentAddress.trim() == "" || permanentAddress.trim() == "") {
        result.innerHTML = 'Address required';
    }
    // else if (genderSelected == "") {
    //     result.innerHTML = 'Gender required';
    // }
    // else if (optionalSubjectsSelected=="") {
    //     result.innerHTML = 'Optional subjects required';
    // }
    else {
        const yearOfbirth = parseInt(dateOfBirth.substring(0, 4), 10)
        if (yearOfbirth > 2004) {
            result.innerHTML = 'Date of Birth should not be more than 2004'
        }
        else{
            flag = 1;
            result.innerHTML = ""
        }
    }
    if (flag == 1)
        openPopup(fieldArray, additionalData);
}
function openPopup(fieldArray, additionalData) {
    //code for popup open and close 
    const popupToggle = document.querySelector('#popupContainer');
    popupToggle.classList.add('popupShow')
    console.log('popupData works')
    console.log(fieldArray)
    //creating ul to store the fetched data in the list and show it to the popup div
    // const popup = document.querySelector('.popup')
    const popupData = document.querySelector('.popupData')
    popupData.style.display = 'block'
    console.log(popupData)
    popupData.innerHTML = "";
    const ul = document.createElement('ul');
    //loop for required fields
    for (let i in fieldArray) {
        console.log(fieldArray[i]);
        const li = document.createElement('li');
        li.textContent = i + " : " + fieldArray[i];
        ul.appendChild(li)
    }
    //loop for additional fields
    for (let i in additionalData) {
        if (additionalData[i].trim() !== "") {
            const li = document.createElement('li');
            li.textContent = i + " : " + additionalData[i]
            ul.appendChild(li)
        }
    }
    popupData.appendChild(ul)
    ul.classList.add('popupDataList')//added style to the list data
    const closeButton = document.createElement('button')
    closeButton.textContent = 'close';
    closeButton.classList.add('popupCloseButton')
    popupData.appendChild(closeButton)
    closeButton.addEventListener('click', () => {
        popupToggle.classList.remove('popupShow')
        popupToggle.classList.add('popupClose')
    })
}