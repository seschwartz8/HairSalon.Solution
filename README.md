# Hair Salon

#### C#/.NET MVC website that shows hair stylists and their clients. Current version: 03.20.20

#### By Sarah "Sasa" Schwartz

![LastCommit](https://img.shields.io/github/last-commit/seschwartz8/HairSalon.Solution)
![Languages](https://img.shields.io/github/languages/top/seschwartz8/HairSalon.Solution)
![MIT license](https://img.shields.io/badge/License-MIT-orange.svg)

---

## Table of Contents

1. [Description](#description)
2. [Setup/Installation Requirements](#installation-requirements)
3. [Specifications](#specs)
4. [Known Bugs](#known-bugs)
5. [Technologies Used](#technologies-used)
6. [License](#license)

---

## Description

C#/.NET MVC website that shows hair stylists and their clients. This application allows you to create stylists and clients per stylist. Then you can see all your stylists, view specifics about that stylist including their clients, and add/delete clients and stylists.

## Database Set Up

- Run MySQL in your terminal
- Enter the following commands in your terminal:
  - CREATE DATABASE sarah_schwartz;
  - USE sarah_schwartz;
  - CREATE TABLE stylists (stylistId INT NOT NULL AUTO_INCREMENT, name VARCHAR (100), specialty VARCHAR(100), rate INT, PRIMARY KEY (stylistId));
  - CREATE TABLE clients (clientId INT NOT NULL AUTO_INCREMENT, name VARCHAR (100), stylistId INT NOT NULL DEFAULT 0, PRIMARY KEY (clientId));

## Installation Requirements

- Clone the repository on Github
- Open the terminal on your desktop
- \$git clone "insert your cloned URL here"
- Change directory to the HairSalon directory, within the HairSalon.Solution directory
- \$dotnet restore
- \$dotnet run
- The app should be hosted on http://localhost:5000/
- Use the app at this URL in the browser!

## User Stories

- As the salon owner, I need to be able to see a list of all stylists.
- As the salon owner, I need to be able to select a stylist, see their details, and see a list of all clients that belong to that stylist.
- As the salon owner, I need to add new stylists to our system when they are hired.
- As the salon owner, I need to be able to add new clients to a specific stylist. I should not be able to add a client if no stylists have been added.
- (In progress) As the salon owner, I need to be able to search a specific stylist in our system and find that stylist's details page.

## Known Bugs

- No known bugs

## Technologies Used

- C#
- .NET

### License

- This software is licensed under the MIT license.
