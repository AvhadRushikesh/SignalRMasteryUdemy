import * as signalR from "@microsoft/signalr"

let btn = document.getElementById("incrementView");
let viewCountSpan = document.getElementById("viewCount");

//  Create Connection
let connection = new signalR.HubConnectionBuilder()
    .withUrl("/hub/view")
    .build();

btn.addEventListener("click", function (evt) {
    //  send to hub
    connection.invoke("IncrementServerView");
});

// client events
connection.on("incrementView", (val) => {
    viewCountSpan.innerText = val;

    //  If value divisible 10 disconnect connection
    if (val % 10 === 0) connection.off("incrementView");
});

//  Start Connection
function startSuccess() {
    console.log("Connected.");
}
function startFail() {
    console.log("Connection failed.");
}
connection.start().then(startSuccess, startFail);