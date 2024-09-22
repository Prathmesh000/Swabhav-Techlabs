const tableBody = document.getElementById("table-data");
const totalRecords = document.getElementById("total-records");
const postForm = document.getElementById("postForm");

const url = "https://jsonplaceholder.typicode.com/posts";

let isEditing = false; 
let currentEditingPost = null; 

async function getData() {
    let response = await fetch(url);
    let data = await response.json();
    console.log(data);

    totalRecords.innerText = `Total Records: ${data.length}`;
  
    data.forEach(item => addRowToTable(item));
}

getData();

function addRowToTable(item) {
    const row = document.createElement("tr");

    const userIdCell = document.createElement("td");
    userIdCell.innerText = item.userId;
    row.appendChild(userIdCell);

    const idCell = document.createElement("td");
    idCell.innerText = item.id;
    row.appendChild(idCell);

    const titleCell = document.createElement("td");
    titleCell.textContent = item.title;
    row.appendChild(titleCell);

    const bodyCell = document.createElement("td");
    bodyCell.textContent = item.body;
    row.appendChild(bodyCell);

    const actionCell = document.createElement("td");
    actionCell.style.display = "flex";  

    
    const deleteButton = document.createElement("button");
    deleteButton.textContent = "Delete";
    deleteButton.classList.add("btn", "btn-danger", "me-2");
    deleteButton.onclick = () => deletePost(item.id, row);
    actionCell.appendChild(deleteButton);

    const editButton = document.createElement("button");
    editButton.textContent = "Edit";
    editButton.classList.add("btn", "btn-warning");
    editButton.onclick = () => loadPostForEdit(item, titleCell, bodyCell);
    actionCell.appendChild(editButton);

    row.appendChild(actionCell);
    tableBody.appendChild(row);
}


async function postData(userId, title, body) {
    const response = await fetch(url, {
        method: "POST",
        headers: {
            "Content-type": "application/json"
        },
        body: JSON.stringify({
            userId: userId,
            title: title,
            body: body
        })
    });

    const newPost = await response.json();
    console.log("Posted data:", newPost);

    addRowToTable(newPost);
    updateTotalRecords();
}

function updateTotalRecords() {
    const rowCount = tableBody.rows.length;  
    totalRecords.innerText = `Total Records: ${rowCount}`;
}


postForm.addEventListener("submit", function (e) {
    e.preventDefault();

    const userId = document.getElementById("userId").value;
    const title = document.getElementById("title").value;
    const body = document.getElementById("body").value;

    if (isEditing && currentEditingPost) {
      
        updatePost(currentEditingPost.id, title, body, currentEditingPost.titleCell, currentEditingPost.bodyCell);
    } else {
   
        postData(userId, title, body);
    }

    postForm.reset();
    isEditing = false;
    currentEditingPost = null;
});

async function deletePost(id, row) {
    const response = await fetch(`${url}/${id}`, {
        method: "DELETE"
    });

    if (response.ok) {
        row.remove();
        updateTotalRecords();
    } else {
        console.error("Failed to delete the post");
    }
}


async function updatePost(id, title, body, titleCell, bodyCell) {
    const response = await fetch(`${url}/${id}`, {
        method: "PUT",
        headers: {
            "Content-type": "application/json"
        },
        body: JSON.stringify({
            title: title,
            body: body
        })
    });

    if (response.ok) {
        const updatedPost = await response.json();
        console.log("Updated data:", updatedPost);

        titleCell.textContent = updatedPost.title;
        bodyCell.textContent = updatedPost.body;

        postForm.reset();
    } else {
        console.error("Failed to update the post");
    }
}

function loadPostForEdit(item, titleCell, bodyCell) {

    document.getElementById("userId").value = item.userId;
    document.getElementById("title").value = item.title;
    document.getElementById("body").value = item.body;

 
    isEditing = true;
    currentEditingPost = {
        id: item.id,
        titleCell: titleCell,
        bodyCell: bodyCell
    };
}
