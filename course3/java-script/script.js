// Select elements
const button = document.getElementById('newQuoteButton');
const quoteDisplay = document.getElementById('quoteDisplay');

// Array of quotes
const quotes = [
   "The best way to predict the future is to invent it.",
   "Life is 10% what happens to us and 90% how we react to it.",
   "Success is not the key to happiness. Happiness is the key to success."
];

// Add event listener to the button
button.addEventListener('click', function() {
   const randomIndex = Math.floor(Math.random() * quotes.length);
   quoteDisplay.textContent = quotes[randomIndex];
});

// part 3
// Using async/await to fetch data
async function fetchDataAsync() {
  try {
    const response = await fetch('https://jsonplaceholder.typicode.com/users'); // API call
    const data = await response.json(); // Parse the response
    if (!response.ok) {
      throw new Error(`Status: ${response.status}`); // Handle non-OK responses
    }
    const container = document.getElementById('data-container'); // Select the container
    container.innerHTML = data
      .map(user => `<p>${user.name} - ${user.email}</p>`) // Display user data
      .join('');
  } catch (error) {
    console.error('Error fetching data:', error); // Log errors
  }
}
// Add event listener to button
document.getElementById('fetch-data').addEventListener('click', fetchDataAsync); // Fetch data on click

//part 5: json
// Fetch data from an API and display it
fetch('https://jsonplaceholder.typicode.com/users')
  .then(response => response.json())
  .then(data => {
    const container = document.getElementById('users-container');
    data.forEach(user => {
     const userElement = document.createElement('p');
     userElement.textContent = `${user.name} - ${user.email}`;
      container.appendChild(userElement);
    });
  })
  .catch(error => console.error('Error fetching data:', error));
// Parse a JSON string
const jsonString = '[{"name": "Alice", "age": 25}, {"name": "Bob", "age": 30}]';
const users = JSON.parse(jsonString);
console.log(users[0].name);  // Output: Alice
console.log(users[1].age);   // Output: 30
// Convert a JavaScript object to JSON
const user = {
  name: "Charlie",
  age: 28,
  isActive: true
};
const jsonUserString = JSON.stringify(user);
console.log(jsonUserString);  // Output: {"name":"Charlie","age":28,"isActive":true}
// Store and retrieve data using localStorage
const settings = {
  theme: "dark",
  language: "en"
};
localStorage.setItem('userSettings', JSON.stringify(settings));
const storedSettings = JSON.parse(localStorage.getItem('userSettings'));
console.log(storedSettings.theme);  // Output: dark
console.log(storedSettings.language);  // Output: en