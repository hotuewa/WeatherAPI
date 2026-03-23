# 🌤️ Weather Dashboard (Full-Stack .NET & React)

Prosta, ale zbudowana zgodnie z dobrymi praktykami aplikacja Full-Stack do sprawdzania aktualnej pogody w dowolnym mieście. Projekt demonstruje integrację nowoczesnego frontendu z backendem opartym na czystej architekturze (Clean Architecture) oraz komunikację z zewnętrznym API.

## 🚀 Technologie

**Backend:**
* .NET 10.0 (C#)
* ASP.NET Core Web API
* Architektura wielowarstwowa (Core & API)
* Wstrzykiwanie zależności (Dependency Injection)

**Frontend:**
* React
* Vite
* Czysty CSS (zmienne CSS, Flexbox)

**Integracje:**
* OpenWeatherMap API

## ✨ Główne cechy projektu

* **Clean Architecture:** Logika biznesowa i interfejsy (Core) są całkowicie odseparowane od punktów wejścia HTTP (API).
* **SOLID:** Wykorzystanie m.in. zasady odwrócenia zależności (Dependency Inversion) poprzez interfejs `IWeatherService`.
* **Asynchroniczność:** Prawidłowe wykorzystanie `Task` i `async/await` w operacjach I/O.
* **CORS:** Skonfigurowane zasady Cross-Origin Resource Sharing dla bezpiecznej komunikacji między różnymi portami lokalnymi.
* **Nowoczesny UI:** Responsywny i minimalistyczny interfejs stworzony od zera bez użycia ciężkich bibliotek komponentów.

## 🛠️ Jak uruchomić projekt lokalnie?

### Wymagania wstępne
* Zainstalowane środowisko **Node.js**
* **Visual Studio** (lub inne IDE obsługujące platformę .NET)
* Darmowy klucz API ze strony [OpenWeatherMap](https://openweathermap.org/)

### Krok 1: Klonowanie repozytorium
Otwórz terminal i pobierz projekt na swój komputer:
```bash
git clone [https://github.com/hotuewa/WeatherAPI.git](https://github.com/hotuewa/WeatherAPI.git)
```

### Krok 2: Uruchomienie Backendu (.NET)
1. Otwórz plik rozwiązania `WeatherDashboard.sln` w programie **Visual Studio**.
2. W oknie *Eksplorator rozwiązań* upewnij się, że projekt **`WeatherDashboard.Api`** jest ustawiony jako **Projekt startowy** (jego nazwa powinna być pogrubiona).
3. Przejdź do pliku `WeatherDashboard.Api/Services/WeatherService.cs` i podmień wartość zmiennej `_apiKey` na swój własny wygenerowany klucz z OpenWeatherMap.
4. Uruchom aplikację klikając zielony przycisk **"Start"** na górnym pasku (lub wciskając klawisz **F5**). 
5. Serwer uruchomi się w tle (upewnij się, że port w konsoli zgadza się z tym w pliku `App.jsx` na frontendzie).

### Krok 3: Uruchomienie Frontendu (React + Vite)
1. Otwórz nowy terminal (np. Wiersz polecenia) i wejdź do folderu z frontendem:
```bash
cd weather-frontend
```
2. Zainstaluj wszystkie wymagane pakiety Node.js:
```bash
npm install
```
3. Uruchom serwer deweloperski Reacta:
```bash
npm run dev
```
4. Aplikacja frontendowa uruchomi się w przeglądarce pod adresem **`http://localhost:5173`**. Wpisz nazwę miasta i sprawdź pogodę!
