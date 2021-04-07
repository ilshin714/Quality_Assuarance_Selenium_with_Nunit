window.onload = (event) => {
    init();
};

function init(){
    var datas =[];
    if(JSON.parse(localStorage.getItem("datas")) !=null){
        datas = JSON.parse(localStorage.getItem("datas"));
    }


    var sellerName = document.getElementById("txtSellerName");
    var address = document.getElementById("txtAddress");
    var city = document.getElementById("txtCity");
    var province = document.getElementById("txtProvince");
    var postalCode = document.getElementById("txtPostalCode");
    var phoneNumber = document.getElementById("txtPhoneNumber");
    var email = document.getElementById("txtEmail");
    var make = document.getElementById("txtMake");
    var model = document.getElementById("txtModel");
    var year = document.getElementById("txtYear");

    sellerName.addEventListener('input', content => {
        sellerName.value = content.target.value;
        var txtSellerNameValidation = document.getElementById("txtSellerNameValidation");
        var message = "";
        if(sellerName.value.length < 2){
            message = "Seller Name should be greater than 2 letters";
        }else{

        }
        txtSellerNameValidation.innerHTML = message;
    });

    address.addEventListener('input', content =>{
        address.value = content.target.value;
        var txtAddressValidation = document.getElementById("txtAddressValidation");
        var message = "";
        if(address.value.length < 2){
            message = "Address Should be greater than 2 letters";
        }
        txtAddressValidation.innerHTML = message;
    });

    city.addEventListener('input', content =>{
        city.value = content.target.value;
        var txtCityValidation = document.getElementById("txtCityValidation");
        var message = "";
        if(city.value.length < 2){
            message = "City is required";
        }
        txtCityValidation.innerHTML = message;
    });

    province.addEventListener('input', content =>{
        province.value = content.target.value;
        var txtProvinceValidation = document.getElementById("txtProvinceValidation");
        var message = "";
        if(province.value.length < 2){
            message = "Province is required";
        }
        txtProvinceValidation.innerHTML = message;
    });

    postalCode.addEventListener('input', content =>{
        var regex = /^[A-Za-z]\d[A-Za-z][ -]?\d[A-Za-z]\d$/;
        postalCode.value = content.target.value;

        var txtPostalCodeValidation = document.getElementById("txtPostalCodeValidation");
        var message = "";
        if(!regex.test(postalCode.value)){
            message = "Please Type ANA NAN ex) N2J 4Y3";
        }
        txtPostalCodeValidation.innerHTML = message;
    });

    phoneNumber.addEventListener('input', content =>{
        var phoneRegex = /^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$/;
        phoneNumber.value = content.target.value;

        var txtPhoneNumberValidation = document.getElementById("txtPhoneNumberValidation");
        var message = "";
        if(!phoneRegex.test(phoneNumber.value)){
            message = "Please Type Phone number";
        }
        txtPhoneNumberValidation.innerHTML = message;
    });

    email.addEventListener('input', content =>{
        var emailRegex = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
        email.value = content.target.value;

        var txtEmailValidation = document.getElementById("txtEmailValidation");
        var message = "";
        if(!emailRegex.test(email.value)){
            message = "Please Type email";
        }
        txtEmailValidation.innerHTML = message;
    });


    make.addEventListener('input', content =>{
        make.value = content.target.value;
        var txtMakeValidation = document.getElementById("txtMakeValidation");
        var message = "";
        if(make.value.length < 2){
            message = "Make is required";
        }
        txtMakeValidation.innerHTML = message;
    });

    model.addEventListener('input', content =>{
        model.value = content.target.value;
        var txtModelValidation = document.getElementById("txtModelValidation");
        var message = "";
        if(model.value.length < 2){
            message = "Model is required";
        }
        txtModelValidation.innerHTML = message;
    });

    year.addEventListener('input', content =>{
        year.value = content.target.value;
        var yearRegex = /^[0-9]{4}$/;
        var txtYearValidation = document.getElementById("txtYearValidation");
        var message = "";
        if(year.value.length < 4) {
            message = "Year is required";
        }else if(!yearRegex.test(year.value)){
            message = "Please Type year";
        }else if(parseInt(year.value) < 2012 ){
            message = "Year should be greater than 2011";
        }


        txtYearValidation.innerHTML = message;
    });

    //var frm = document.getElementById("indexForm");
    var saveBtn = document.getElementById("btnSave");

    saveBtn.onclick = function(){
        var sellerName = document.getElementById("txtSellerName").value;
        var address = document.getElementById("txtAddress").value;
        var city = document.getElementById("txtCity").value;
        var province = document.getElementById("txtProvince").value;
        var postalCode = document.getElementById("txtPostalCode").value;
        var phoneNumber = document.getElementById("txtPhoneNumber").value;
        var email = document.getElementById("txtEmail").value;
        var make = document.getElementById("txtMake").value;
        var model = document.getElementById("txtModel").value;
        var year = document.getElementById("txtYear").value;

        var message = "";
        if(sellerName.length < 2){
            //var txtSellerNameValidation = document.getElementById("txtSellerNameValidation");
            message = "Seller Name should be greater than 2 letters";
            //txtSellerNameValidation.innerHTML = message;
        }
        if(address.length <2){
            message = "Address Should be greater than 2 letters";
        }
        if(city.length <2){
            message = "City is required";
        }
        if(province.length <2){
            message = "Province is required";
        }

        var values = {
            sellerName: sellerName,
            address: address,
            city: city,
            province: province,
            postalCode: postalCode,
            phoneNumber: phoneNumber,
            email: email,
            make: make,
            model: model,
            year: year
        }
        //location.reload();

        var result = document.getElementById("result");
        var html = "";
        var url =  `http://www.jdpower.com/cars/${make}/${model}/${year}`

        var txtSellerNameValidation = document.getElementById("txtSellerNameValidation");
        var txtAddressValidation = document.getElementById("txtAddressValidation");
        var txtCityValidation = document.getElementById("txtCityValidation");
        var txtProvinceValidation = document.getElementById("txtProvinceValidation");
        var txtPostalCodeValidation = document.getElementById("txtPostalCodeValidation");
        var txtPhoneNumberValidation = document.getElementById("txtPhoneNumberValidation");
        var txtEmailValidation = document.getElementById("txtEmailValidation");
        var txtMakeValidation = document.getElementById("txtMakeValidation");
        var txtModelValidation = document.getElementById("txtModelValidation");
        var txtYearValidation = document.getElementById("txtYearValidation");

        if(txtSellerNameValidation.innerHTML!= "" || txtAddressValidation.innerHTML != "" || txtCityValidation.innerHTML != "" || txtEmailValidation.innerHTML != "" || txtMakeValidation.innerHTML != ""
            || txtModelValidation.innerHTML!= "" || txtProvinceValidation.innerHTML != "" || txtPostalCodeValidation.innerHTML != "" || txtPhoneNumberValidation.innerHTML != "" ||txtYearValidation.innerHTML != "" || message !="" ){

            alert("data cannot be saved");
        }else{
            html += `Seller Name: ${sellerName} <br>
                       Address: ${address} <br>
                       City: ${city} <br>
                       Province: ${province} <br>
                       Postal Code: ${postalCode} <br>
                       Phone Number: ${phoneNumber} <br>
                       Email Address: ${email} <br>
                       Make: ${make} <br>
                       Model: ${model} <br>
                       year: ${year} <br>
                       <a href="${url}">${url}</a>
                       <br>
                        `;


            datas.push(values);

            localStorage.setItem("sellerName", sellerName);
            localStorage.setItem("address", address);
            localStorage.setItem("city", city);
            localStorage.setItem("province", province);
            localStorage.setItem("postalCode", postalCode);
            localStorage.setItem("phoneNumber", phoneNumber);
            localStorage.setItem("email", email);
            localStorage.setItem("make", make);
            localStorage.setItem("model", model);
            localStorage.setItem("year", year);
            localStorage.setItem("datas", JSON.stringify(datas));
        }

        result.innerHTML= html;


    }

    var btnSearch = document.getElementById("btnSearch");

    btnSearch.onclick = function(){
        var result = document.getElementById("result");
        var html = "";
        var key = "";
        var value = "";
        var values = JSON.parse(localStorage.getItem("datas"));
        var output = "";

        for(var i = 0 ; i < values.length ; i++){
            html += `Seller Name: ${values[i].sellerName} <br>
                       Address: ${values[i].address} <br>
                       City: ${values[i].city} <br>
                       Province: ${values[i].province} <br>
                       Postal Code: ${values[i].postalCode} <br>
                       Phone Number: ${values[i].phoneNumber} <br>
                       Email Address: ${values[i].email} <br>
                       Make: ${values[i].make} <br>
                       Model: ${values[i].model} <br>
                       year: ${values[i].year} <br>
                       <a href="http://www.jdpower.com/cars/${values[i].make}/${values[i].model}/${values[i].year}">Click To See the Car</a>
                       <br>
                        `;
        }
        result.innerHTML= html;
    }
}

function saveData(){

}
