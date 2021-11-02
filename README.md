# Garden API

### By Anna Clarke and Connor Hansen

An API that allows developers to look up their plant hardiness zone by their zipcode, and information on a variety of seeds.

## Technologies Used
* C#
* ASP.NET Core MVC
* Entity Framework Core
* Swagger
* MySql

## Setup and Usage

### Installation Requirements
* text editor, such as VS Code
* .NET 5

### Setup
* Clone this repository to your desktop
* Open top directory in your text editor
* Create appsettings.json file in GardenAPI.Solution/GardenAPI/
* Copy this code into appsettings.json file, replacing YOUR_PASSWORD with your MySql password:  
```{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=parks_and_api;uid=root;pwd=YOUR_PASSWORD;"
  }
}
```
* In your terminal, navigate into GardenAPI.Solution/GardenAPI/ and enter the command `$ dotnet restore` to install necessary packages
* Enter `$ dotnet build` in terminal, to build the program
* Enter `$ dotnet ef database update` in terminal, to build your database
* Enter `$ dotnet run` in terminal, to access API in browser, Postman, or through Swagger

## API Documentation

### Using Swagger Documentation

After completing all setup instructions, use Swagger in your browser to easily view endpoints and manipulate the database. Go to the following URL `http://localhost:5004/index.html` to explore the api with Swagger.

### Endpoints

Base URL: http://localhost:5004

### HTTP Request

GET /api/seeds
POST /api/seeds
GET /api/seeds/{id}
PUT /api/seeds/{id}
DELETE /api/seeds/{id}

### Path Parameters

| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| name | string | none | true | Returns exact match of name the of the park.
|statePark | string | none| true | Returns parks that are either state parks or not, accepts "true", "yes", "false", or "no".
| nationalPark | string | none | true | Returns parks that are either state parks or not, accepts "true", "yes", "false", or "no".
| activities | string | none | false | Returns parks that contain that activity in activities.
| acreage | int | 0 | false | Returns parks with that exact number of acres.
| location | string | none | false | Returns parks that contain the entered string in their address (ex. city name, zip code, or state code) |

### Example Query
`
http://localhost:5000/api/Parks/?location=Seattle&activities=hiking
`

### Example JSON Response
```
[
  {
    "parkId": 2,
    "name": "Discovery Park",
    "statePark": false,
    "nationalPark": false,
    "activities": "hiking, beach access, historic lighthouse",
    "acreage": 534,
    "address": "3801 Discovery Park Blvd, Seattle, WA 98199"
  }
]
```

## Known Bugs

* _NA_

## License

_[MIT](https://opensource.org/licenses/MIT)_  

Copyright (c) 2021 Anna Clarke

## Contact Information

Anna Clarke: <anclarkie@gmail.com>