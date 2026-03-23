import { useState } from 'react';
import './App.css';

function App() {
  const [city, setCity] = useState('');
  const [weather, setWeather] = useState(null);
  const [error, setError] = useState('');

  const fetchWeather = async () => {
    if (!city) return;
    setError('');
    setWeather(null);

    try {
      const response = await fetch(`https://localhost:7121/api/weather/${city}`);
      
      if (!response.ok) {
        throw new Error('Nie znaleziono miasta lub błąd serwera');
      }
      
      const data = await response.json();
      setWeather(data);
    } catch (err) {
      setError(err.message);
    }
  };

  return (
    <div className="container">
      <h1>Dashboard Pogodowy</h1>
      
      <div className="search-box">
        <input 
          type="text" 
          value={city}
          onChange={(e) => setCity(e.target.value)}
          placeholder="Wpisz miasto..."
        />
        <button onClick={fetchWeather}>Szukaj</button>
      </div>

      {error && <p className="error">{error}</p>}

      {weather && (
        <div className="weather-card">
          <h2>{weather.cityName}</h2>
          <p>Temperatura: {weather.temperature}°C</p>
          <p>Wilgotność: {weather.humidity}%</p>
          <p>Opis: {weather.description}</p>
        </div>
      )}
    </div>
  );
}

export default App;