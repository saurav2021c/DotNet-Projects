document
  .getElementById("weatherForm")
  .addEventListener("submit", async function (event) {
    event.preventDefault();

    const location = document.getElementById("location").value;
    const date = document.getElementById("date").value;

    const response = await fetch(
      `https://localhost:7088/WeatherForecast/${location}/${date}`
    );
    const data = await response.json();

    displayWeather(data);
  });

function displayWeather(data) {
  const resultDiv = document.getElementById("weatherResult");
  resultDiv.innerHTML = `
        <h2>Weather Forecast for ${data.date}</h2>
        <p><strong>Temperature:</strong> ${data.temperatureC} °C</p>
        <p><strong>Conditions:</strong> ${data.weatherConditions}</p>
        <p><strong>Humidity:</strong> ${data.humidity}%</p>
    `;
}
