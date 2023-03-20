import * as signalR from "@microsoft/signalr"

//  Create Connection
let connection = new signalR.HubConnectionBuilder()
    .withUrl("/hubs/view")
    .build();

//  On View Update Message from Client
connection.on("viewCountUpdate", (value: number) => {
    var counter = document.getElementById("viewCounter");
    counter.innerText = value.toString();
});

//  Notify server we're watching
function notify() {
    connection.send("notifyWatching");
}

//  Start Connection
function startSuccess() {
    console.log("Connected.");
    notify();
}
function startFail() {
    console.log("Connection failed.");
}
connection.start().then(startSuccess, startFail);