//Gets user's choice. User can input bomb as a cheat code. Bomb always wins.
const getUserChoice = userInput => {
    userInput = userInput.toLowerCase();
    if(userInput === 'rock' || userInput === 'paper' || userInput === 'scissors' || userInput === 'bomb') {
      return userInput;
    }
    else {
      console.log('Invalid input');
    }
  }
  //Gets computer's choice.
  function getComputerChoice() {
    let x = Math.floor(Math.random()*3);
    if(x === 0) {
      return 'rock'
    }
    else if(x === 1) {
      return 'paper'
    } else {
      return 'scissors'
    }
  }
  //Function to determine the winner
  function determineWinner(userChoice, computerChoice) {
    if(userChoice === 'bomb') {
      return 'User won'
    }
    else if(userChoice === computerChoice) {
      return 'Game tied'
    }
    else if(userChoice === 'rock'){
      if(computerChoice === 'paper') {
        return 'Computer won'
      }
      else {
        return 'User won'
      }
  
    }
    else if(userChoice === 'paper') {
      if(computerChoice === 'scissors') {
        return 'Computer won'
      }
      else {
        return 'User won'
      }
    } else if(userChoice === 'scissors') {
      if(computerChoice === 'rock')
      {
        return 'Computer won'
      }
      else {
        return 'User won'
      }
    }
  }
  //Function to initialize the game. Users can pass their input by changing the parameter for getUserChoice() function
  function playGame() {
    let userChoice = getUserChoice('bomb');
    let computerChoice = getComputerChoice();
    console.log(userChoice);
    console.log(computerChoice);
    console.log(determineWinner(userChoice, computerChoice));
  }
  //Calling the function to start the game.
  playGame();