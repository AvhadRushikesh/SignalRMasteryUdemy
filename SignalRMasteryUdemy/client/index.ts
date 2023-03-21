import * as signalR from "@microsoft/signalr"

let btn = document.getElementById("btnGetFullName");

//  Create Connection
let connection = new signalR.HubConnectionBuilder()
    .withUrl("/hub/stringtools")
    .build();

btn.addEventListener("click", function (evt) {
    var firstName = (document.getElementById("inputFirstName") as HTMLInputElement).value;
    var lastName = (document.getElementById("inputLastName") as HTMLInputElement).value;

    //  send to hub

    connection.invoke("getFullName", firstName, lastName)
        .then((name: string) => { alert(name); });
});


//  Start Connection
function startSuccess() {
    console.log("Connected.");
}
function startFail() {
    console.log("Connection failed.");
}
connection.start().then(startSuccess, startFail);