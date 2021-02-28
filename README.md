# **Pierre's Bakery**
By _Olha Hizhytska_

## Description

Creating this application I used test-driven development technique. 

This is a console application for a bakery that will prompt a welcome message and ask the user to select which type of product they would like to purchase. The user will be able to select: bread, pastry or both. The user may specify how many loaves of bread and pastries they would like to buy. At the end the application will display the total cost of the order regarding the user's selection.

## Specifications

<details>
  <summary>Expand Specs</summary>

### Describe: Bread Model

| Test                                                          | Expect                                       |
| ---------------------------------------------------------     | ---------------------------------            |
| It will instantiate a Bread object with Bread constructor     | newBread                                     |
| It will create property for the Bread instance                | newBread.Quantity.IsEqualTo(breadQuantity);  |
| It will calculate a price of 1 loaf                           | newBread.CalculatePrice().IsEqualTo(5);      |
| It will calculate the offer price. Buy 2 get 1 free           | newBread.CalculateOfferPrice().IsEqualTo(10);|

### Describe: Pastry Model

| Test                                                          | Expect                                       |
| ------------------------------------------------------------- | -----------------------------------          |
| It will instantiate a Pastry object with Pastry constructor   | newPastry                                    |
| It will create property for the Pastry instance               | newPastry.Quantity.IsEqualTo(pastryQuantity);|
| It will calculate a price of 1 pastry                         | newBread.CalculatePrice().IsEqualTo(2);      |
| It will calculate the offer price. 3 for $5                   | newBread.CalculateOfferPrice().IsEqualTo(5); |
| It will calculate the offer price in case if user input is not divisible by 3| newBread.CalculateOfferPrice().IsEqualTo(7); |

</details>

## Setup

#### To open this application:

- Clone this repository to your desktop, using next command:

  git clone https://github.com/OlgaHi/Pierre-s-Bakery.git

- Navigate to the top level of the directory.

  cd Pierre-s-Bakery

#### To run this application:

To run this application you need to install .NET Core. Please follow this steps:
 - Download [.NET Core SDK (Software Development Kit)](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer). Clicking this link will prompt a file download for your particular OS from Microsoft.
 - Open the file. Follow the installation steps.
 - Confirm the installation is successful by opening your terminal and running the command $ dotnet --version. You should see something like this in response: 5.0.100. This means .NET was successfully installed.
 - Navigate to the /Bakery folder 
 - Run the following command: dotnet build
 - Run the following command to execute this compiled code: dotnet run

## Run Tests

- Navigate to Bakery.Tests folder 
- To retrieve and install the packages run the command: dotnet restore
- Run the following command to run tests on all test methods: dotnet test 
  - Total tests: 9

![Homepage](images/screenshot_tdd.png)

## Technologies Used:

* C#
* .NET Core
* MSTest

## Known Bugs

- No known issues

## License

[MIT](https://en.wikipedia.org/wiki/MIT_License)
Copyright (c) 2021 _Olha Hizhytska_

## Contact Information

- Olha Hizhytska olgainfotech@gmail.com
