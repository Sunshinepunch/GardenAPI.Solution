# 🌿 Garden API 🌿

### By Anna Clarke and Connor Hansen

This API stores information for everyday gardening.

## Technologies Used
* C#
* ASP.NET Core MVC
* Entity Framework Core
* Swagger
* MySql

## Description

An API that allows developers to look up their plant hardiness zone by their zipcode. Also provides a table of seed information, including reccomended number of seedlings per square foot, estimated days till harvest, reccomended days between watering, estimated days till germination, beneficial/harmful plant neighbors, notes, and hardiness zones. Developers can search plants by their name, companions, enemies, notes and hardiness zones. Developers can update, delete, and create new seeds.

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
    "DefaultConnection": "Server=localhost;Port=3306;database=garden_api;uid=root;pwd=YOUR_PASSWORD;"
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

###  🌐 ZipZones 🌐

#### HTTP Request

GET /api/ZipZones

### Path Parameters

| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| zipcode | int | none | true | Returns hardiness zone for search zipcode |

### Example Query
`
http://localhost:5004/api/ZipZones/?zipcode=97035
`

### Example JSON Response
`
[{"zipZoneId":12985,"zipCode":97035,"zone":8}]
`
### 🌱 Seeds 🌱

#### HTTP Request

GET /api/Seeds
POST /api/Seeds
GET /api/Seeds/{id}
PUT /api/Seeds/{id}
DELETE /api/Seeds/{id}

### Path Parameters

| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| seedname | string | none | false | Returns exact match of name the of the plant.
| companions | string | none| false | Returns plants that are good matches with this plant.
| enemies | string | none | false | Returns plants that are bad matches with this plant.
| zones | string | none | false | Returns plants that will grow in that hardiness zone.
| notes | string | none | false | Returns plants whos notes contain search query.

### Example Query
`
http://localhost:5004/api/Seeds/?seedname=tomato
`

### Example JSON Response
```
[
  {
    "seedId": 2,
    "seedName": "tomato",
    "sqFootPlant": 1,
    "daysTillHarvest": 85,
    "waterInterval": 1,
    "daysTillSprout": 10,
    "companions": "basil, garlic, parsley, amaranth, carrot, borage, marigold, onion, sage, cucumber",
    "enemies": "cabbage, broccoli, fennel, corn, kale, dill, pepper, eggplant, potato, brussel sprouts, cauliflower, collards, kholrabi,",
    "notes": "full sun, start indoors and transplant",
    "zone": "5, 6, 7, 8, 9, 10, 11"
  }
]
```


## Known Bugs

* _NA_

## License

_[MIT](https://opensource.org/licenses/MIT)_  

Copyright (c) 2021 Anna Clarke, Connor Hansen

## Contact Information

Anna Clarke: <anclarkie@gmail.com>
Connor Hansen: <chansen13@georgefox.edu>