# Eau Claude's Hair Salon

#### _Admin tool to add stylists, and clients for the hair salon - August 11, 2019_

#### _By **Erik Irgens**_

## Description

This app is intended to serve as a utlity for Eau Claude's Hair Salon to manage a list of stylists - through the addition of a stylist on a form page - and clients for each perspective stylist through a page dedicated to add clients for easy viewing and correlation of information.

### Specs

### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **App takes Stylist creation input and displays a link to Stylist's page** | NAME | NAME(link) |
| **Stylist page allows for navigation to its own Clients page** | NAME | NAME(link) - > LIST OF CLIENTS |
| **Stylist page allows for order creation and input** | ORDER INFORMATION | NAME(link) -> LIST OF CLIENTS - > CLIENT PAGE|


## Setup/Installation Requirements

1. Clone this repository:
    ```
    $ git clone https://github.com/erik-t-irgens/Hair_Salon_EntityFramework
    ```
2. Restore the application (in the HairSalon directory within the root folder)
    ```
    $ dotnet restore
    ```
3. Create a database using SQL via MySQL:
    ```
    > CREATE DATABASE erik_irgens;
    > USE erik_irgens;
    > CREATE TABLE stylists (StylistId serial PRIMARY KEY, Name VARCHAR(255));
    > CREATE TABLE clients (ClientId serial PRIMARY KEY, Name VARCHAR(255), StylistId PRIMARY KEY);
    ```
4. Run the application using:
    ```
    $ dotnet run

    ```
4. Visit the application via web browser:
    ```
    localhost:5000/
    ```
## Known Bugs
* No known bugs at this time.

## Technologies Used
* C# / .NET

## Support and contact details

_Please contact Erik Irgens with questions and comments._

### License

*GNU GPLv3*

Copyright (c) 2019 **_Erik Irgens_**
