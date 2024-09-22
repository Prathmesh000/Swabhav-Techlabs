const form = document.getElementById("form");
const dateInput = document.getElementById("date");
const activityContainer = document.getElementById("activity-container");
const addActivityButton = document.getElementById("add-activity");
const previewButton = document.getElementById("preview-btn");
const view = document.getElementById("view-button")


let activityIndex = 0;

view.addEventListener('click',()=>{
    window.location.href = 'view-sheet.html'
})


function createActivityForm(index) {
  const activityDiv = document.createElement("div");
  activityDiv.classList.add("activity-entry");
  activityDiv.innerHTML = `
        <h4>Activity ${index + 1}</h4>
        <button type="button" class="btn-close button-close" id="cancel-${index}" aria-label="Close"></button>
        <br>
        <label>Project:</label>
        <select id="project-${index}" class="form-select">
            <option value="Lending">Lending</option>
            <option value="Banking">Banking</option>
        </select>
        <br>
        <label>Sub-project:</label>
        <select id="sub-project-${index}" class="form-select">
            <option value="lending-sub">Lending Sub</option>
            <option value="banking-sub">Banking Sub</option>
        </select>
        <br>
        <label>Batch:</label>
        <select id="batch-${index}" class="form-select">
            <option value="Apro Captive">Apro Captive</option>
            <option value="Apro Payments">Apro Payments</option>
        </select>
        <br>
        <label>Hours Worked:</label>
        <input type="number" id="hours-${index}" />
        <label>Details:</label>
        <textarea id="details-${index}"></textarea>
    `;

  activityContainer.appendChild(activityDiv);

  // Cancel activity form
  document
    .getElementById(`cancel-${index}`)
    .addEventListener("click", function () {
      activityDiv.remove();
    });
}

createActivityForm(activityIndex); 
activityIndex++;

addActivityButton.addEventListener("click", function () {
  createActivityForm(activityIndex);
  activityIndex++;


});



form.addEventListener("submit", function (event) {
    event.preventDefault();
 
    const date = dateInput.value;
    const onLeave = document.getElementById("on-leave").value === "true";
    
    const activities = [];
    for (let i = 0; i < activityIndex; i++) {
        activities.push({
            project: document.getElementById(`project-${i}`).value,
            subProject: document.getElementById(`sub-project-${i}`).value,
            batch: document.getElementById(`batch-${i}`).value,
            hours: parseInt(document.getElementById(`hours-${i}`).value, 10),
            details: document.getElementById(`details-${i}`).value,
        });
    }

    const data = {
        TodaysDate: date,
        OnLeave: onLeave,
        TimesheetList: activities.map(activity => ({
            Project: activity.project,
            SubProject: activity.subProject,
            Batch: activity.batch,
            HoursNeeded: activity.hours,
            Activity: activity.details
        }))
    };

    console.log(data);
    
    fetch("http://localhost:5023/api/Timesheet", {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(data)
    })
    .then(response => response.json())
    .then(data => {
        console.log("Submission successful", data);
        alert("Timesheet submitted!");
        form.reset();
        activityContainer.innerHTML = "";
        activityIndex = 0;
    })
    .catch(error => {
        console.error("Error:", error);
    });
});




previewButton.addEventListener("click", function () {
  const date = dateInput.value;
  const onLeave =
    document.getElementById("on-leave").value === "true" ? "Yes" : "No";

  let previewContent = `
        <table class="table table-bordered">
            <thead>
                <tr>
                    <th>Date</th>
                    <th>On Leave</th>
                    <th>No.</th>
                    <th>Project</th>
                    <th>Sub-Project</th>
                    <th>Batch</th>
                    <th>Activity</th>
                    <th>Hours Worked</th>
                </tr>
            </thead>
            <tbody>`;

  for (let i = 0; i < activityIndex; i++) {
    const project = document.getElementById(`project-${i}`)?.value || "";
    const subProject = document.getElementById(`sub-project-${i}`)?.value || "";
    const batch = document.getElementById(`batch-${i}`)?.value || "";
    const hours = document.getElementById(`hours-${i}`)?.value || "";
    const details = document.getElementById(`details-${i}`)?.value || "";

    if (i === 0) {
      previewContent += `
        <tr>
            <td rowspan="${activityIndex}">${date}</td>
            <td rowspan="${activityIndex}">${onLeave}</td>
            <td>${i + 1}</td>
            <td>${project}</td>
            <td>${subProject}</td>
            <td>${batch}</td>
            <td>${details}</td>
            <td>${hours}</td>
        </tr>`;
    } else {
      previewContent += `
        <tr>
            <td>${i + 1}</td>
            <td>${project}</td>
            <td>${subProject}</td>
            <td>${batch}</td>
            <td>${details}</td>
            <td>${hours}</td>
        </tr>`;
    }
  }

  previewContent += `</tbody></table>`;
  document.getElementById("previewContent").innerHTML = previewContent;


  const previewModal = new bootstrap.Modal(
    document.getElementById("previewModal")
  );
  previewModal.show();
});
