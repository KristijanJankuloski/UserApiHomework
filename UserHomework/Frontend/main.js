let userList = document.getElementById("all-users-list");

fetch("http://localhost:5025/api/User").then(respose => respose.json()).then(data => {
    userList.innerHTML = "";
    for (let user of data) {
        newItem = document.createElement("li");
        newItem.innerHTML = user;
        userList.appendChild(newItem);
    }
});

document.getElementById("search-btn").addEventListener("click", () => {
    let value = document.getElementById("search-input").value;
    fetch(`http://localhost:5025/api/User/${value}`).then(response => response.text()).then(data => {
        document.getElementById("search-result").innerText = data;
    });
});