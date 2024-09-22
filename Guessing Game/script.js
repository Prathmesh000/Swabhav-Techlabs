const totalCircles = 40;
const maxAttempts = 6;
let attemptsLeft = maxAttempts;
let attemptsTaken = 0;
let randomNumber = Math.floor(Math.random() * totalCircles) + 1;
const circlesContainer = document.querySelector('.container-circles');
const attemptsText = document.getElementById('attempts-left');
const gameOverText = document.getElementById('game-over');
const gameWonText = document.getElementById('game-won');
const attemptsTakenText = document.getElementById('attempts-taken');
const attemptsTakenTextWon = document.getElementById('attempts-taken-won');

console.log("Random generated number: " + randomNumber);


for (let i = 1; i <= totalCircles; i++) {
    const circle = document.createElement('div');
    circle.classList.add('circle');
    circle.innerText = i;
    circlesContainer.appendChild(circle);
    circle.addEventListener('click', () => CircleClicked(i, circle));  //fn k body m h circleclicked, fn nhi h 
}

function CircleClicked(number, circle) {
    if (attemptsLeft <= 0 || gameWonText.style.display === 'block' || gameOverText.style.display === 'block') return;

    attemptsTaken++;
    if (number === randomNumber) {
        circle.style.backgroundColor = "green";
        freezeCircles();
        attemptsTakenTextWon.innerText = `Attempts Taken: ${attemptsTaken}`;
        gameWonText.style.display = 'block';
    } else if (number < randomNumber) {
        circle.style.backgroundColor = 'yellow';
        circle.classList.add('shake');

    } else {
        circle.style.backgroundColor = 'red';
        circle.classList.add('shake');

    }

    attemptsLeft--;
    attemptsText.innerHTML = `Attempts Left: ${attemptsLeft}`;

    if (attemptsLeft === 0 && gameWonText.style.display !== 'block') {
        gameOverText.style.display = 'block'; 
        freezeCircles();
        attemptsTakenText.innerHTML = `Attempts Taken: ${attemptsTaken}`;
    }
    
}

function freezeCircles() {
    const circles = document.querySelectorAll('.circle');
    circles.forEach(circle => {
        circle.style.cursor = 'not-allowed';
    });

}
