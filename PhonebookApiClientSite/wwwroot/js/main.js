function addNew() {
    var nameInput = "<li  class='col-md-4 col-xs-4 col-lg-4 col-sm-4'> <span> <b> Enter Your Name: </b> </span> <br> <br> <input id='contactName'></li> <li class='col-md-4 col-xs-4 col-lg-4 col-sm-4'> <span> <b> Enter your PhoneNumber: </b> </span> <br> <br> <input id='phoneNumber' placeholder='98--- --- ----'> </li> <li class='col-md-4 col-xs-4 col-lg-4 col-sm-4'> <br> <button onclick='addToContacts();'> <b> Add To Contacts </b> </button> <br> <br> </div> </li>";
    document.getElementById("show").style.display = 'block';
    document.getElementById("show").innerHTML = nameInput;
}
i = 0;
function addToContacts() {
    letters = /^[A-Za-z]+$/; 
    numbers = /^([0-9])+$/;
    i++;
    if ((document.getElementById("contactName").value.match(letters) &&
    document.getElementById("contactName") !== "") && (document.getElementById("phoneNumber").value.match(numbers) &&
    document.getElementById("phoneNumber")!== "")) { 

        ulTag = document.createElement ("ul")
        ulID = document.createAttribute("id");
        ulID.value = "id" + i;
        ulTag.setAttributeNode(ulID);
        ulTag.setAttribute("class", "row container");

    
        contactName = document.createTextNode(document.getElementById("contactName").value);    
        liNames = document.createElement("li");
        liNames.appendChild(contactName);

        phoneNumber = document.createTextNode(document.getElementById("phoneNumber").value);    
        liPhones = document.createElement("li");
        liPhones.appendChild(phoneNumber);

        liClass = document.createAttribute("class");
        liClass.value = "col-md-4 col-xs-4 col-lg-4 col-sm-4"; 
        liNames.setAttributeNode(liClass);

        liClass1 = document.createAttribute("class");
        liClass1.value = "col-md-4 col-xs-4 col-lg-4 col-sm-4"; 
        liPhones.setAttributeNode(liClass1);

        liED = document.createElement("li");
        liClass2 = document.createAttribute("class");
        liClass2.value = "col-md-4 col-xs-4 col-lg-4 col-sm-4"; 
        liED.setAttributeNode(liClass2);

        buttonTag = document.createElement("BUTTON");
        buttonText = document.createTextNode("delete");      
        buttonTag.appendChild(buttonText); 
        buttonAtt = document.createAttribute("class");
        buttonAtt.value = "col-md-2 col-xs-2 col-lg-2 col-sm-2"; 
        buttonTag.setAttributeNode(buttonAtt);
        buttonTag.setAttribute("style", "min-height: 29.26px;");

        remove = document.createAttribute("onclick");
        remove.value = "this.parentNode.remove();";
        buttonTag.setAttributeNode(remove);

        space = document.createTextNode(" ");

        buttonTag2 = document.createElement("BUTTON");
        buttonText2 = document.createTextNode("edit");      
        buttonTag2.appendChild(buttonText2); 
        buttonAtt2 = document.createAttribute("class");
        buttonAtt2.value = "col-md-2 col-xs-2 col-lg-2 col-sm-2"; 
        buttonTag2.setAttributeNode(buttonAtt2);
        buttonTag2.setAttribute("style", "min-height: 29.26px;");
        edit = document.createAttribute("onclick");
        edit.value = "editContact(this.parentNode);";
        buttonTag2.setAttributeNode(edit);

        brTag = document.createElement("BR");

        ulTag.appendChild(liNames).style.backgroundColor= '#4CAF50';
        ulTag.appendChild(liPhones).style.backgroundColor= '#4CAF50';
        ulTag.appendChild(buttonTag2);
        ulTag.appendChild(space);
        ulTag.appendChild(buttonTag);
        ulTag.appendChild(brTag);
        document.body.appendChild(ulTag);
    
        document.getElementById("contactName").value="";
        document.getElementById("phoneNumber").value="";
        document.getElementById("show").style.display = 'none';
    }
    else {                   
        window.alert ("your input is wrong, try again");
        document.getElementById("contactName").value="";
        document.getElementById("phoneNumber").value="";
    }
}

function editContact(node) {
    
    id = node.id;
    var inputEdit = "<input id='editedName'  class='col-md-4 col-xs-4 col-lg-4 col-sm-4' value ='"+ node.childNodes[0].innerHTML+"'><input id='editedPhone' class='col-md-4 col-xs-4 col-lg-4 col-sm-4' value ='"+ node.childNodes[1].innerHTML +"'><button class='col-md-4 col-xs-4 col-lg-4 col-sm-4' style='min-height: 29.26px;' onclick='save(this.parentNode);'> save </button><br>";
    document.getElementById(id).innerHTML = inputEdit;

}
function save(node) {
    name = document.getElementById("editedName").value;
    phone = document.getElementById("editedPhone").value;

    if ((document.getElementById("editedName").value.match(letters) &&
    document.getElementById("editedName") !== "") && (document.getElementById("editedPhone").value.match(numbers) &&
    document.getElementById("editedPhone")!== "")) { 
        
    var edited = "<li class='col-md-4 col-xs-4 col-lg-4 col-sm-4'>" + name + "</li> <li class='col-md-4 col-xs-4 col-lg-4 col-sm-4'>"+ phone + "</li> <button class='col-md-2 col-xs-2 col-lg-2 col-sm-2' style='min-height: 29.26px;' onclick='editContact(this.parentNode);'>edit</button><button class='col-md-2 col-xs-2 col-lg-2 col-sm-2' style='min-height: 29.26px;' onclick='this.parentNode.remove();'>delete</button><br>";
    id = node.id;
    document.getElementById(id).innerHTML = edited;
    }
    else {                   
        window.alert ("your input is wrong, try again");
    }
}
function myFunction() {
    var input, filter, ul, li,  i;
    input = document.getElementById('myInput');
    filter = input.value.toUpperCase();
    ul = document.getElementsByTagName("ul");
    // Loop through all list items, and hide those who don't match the search query
    for (i = 2; i < ul.length; i++) {
        li = ul[i].getElementsByTagName("li")[0];
        if (li.innerHTML.toUpperCase().indexOf(filter) > -1) {
            ul[i].style.display = "";
        } else {
            ul[i].style.display = "none";
        }
    }
}

$(window).ready(function () {
    $('#pb-add').on('click', function () {
        $(this).hide();
        $('#pb-cancel').fadeIn(2);
        $('.phone--book-middle').fadeIn(1000);
    });
    $('#pb-cancel').on('click', function () {
        $(this).hide();
        $('#pb-add').fadeIn(2);
        $('.phone--book-middle').fadeOut(1000);
    });


})