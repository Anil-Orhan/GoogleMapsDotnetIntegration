## Geocoding API Usage - .NET Core Console Application
This .NET Core console application demonstrates how to use the Geocoding API to get the address from given latitude and longitude coordinates. The application uses the **System.Net.Http** namespace for making HTTP requests and System.Text.Json for JSON parsing. Before running the application, make sure you have obtained a valid API key for the Geocoding API.

### Prerequisites
- .NET Core SDK installed on your machine.
- A valid API key for the Geocoding API from Google Maps.
### How to Run
1. Clone or download this repository to your local machine.
2. Open the Program.cs file in your preferred code editor.
3. Replace "YOUR_API_KEY" with your actual Geocoding API key obtained from Google Maps.
4. Save the changes.
5. Open a terminal or command prompt in the project's root directory.
6. Run the following command to build and execute the application:


```bash
dotnet run
```
### Code Explanation

The application performs the following steps:

1. Initializes the API key and the latitude and longitude coordinates.
2. Calls the GetAddressFromCoordinates method, passing the API key, latitude, and longitude.
3. The GetAddressFromCoordinates method sends an HTTP GET request to the Geocoding API using the provided coordinates and API key.
4. It then parses the API response using System.Text.Json.
5. If the status in the API response is "OK," it extracts the formatted address from the results.
6. If the status is not "OK" or if no results are found, appropriate error messages are returned.
### Important Note
Remember to handle the API key securely, preferably using environment variables or other secure methods, when deploying your application to production environments.

For more information about the Geocoding API and other Google Maps APIs, refer to the official [Google Maps Platform documentation](https://developers.google.com/maps/documentation "Google Maps Platform documentation").

Feel free to use and modify this code according to your needs. If you encounter any issues or have suggestions for improvements, please open an issue or submit a pull request. Happy coding!
