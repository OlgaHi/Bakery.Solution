# **Pierre's Bakery**
By _Olha Hizhytska_

## Description

Creating this application I used test-driven development technique. 

This is a console application for a bakery that will prompt a welcome message and ask the user to select which type of product they would like to purchase. The user will be able to select: bread, pastry or both. The user may specify how many loaves of bread and pastries they would like to buy. At the end the application will display the total cost of the order regarding the user's selection.


![Homepage]()

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


## Run Tests

- Navigate to Bakery.Tests folder in the command line
- Use the commands `dotnet build` and `dotnet restore` to make sure code is compiled and packages are installed
- Use the command `dotnet test` to run tests on all test methods
  - Total tests: 9

 
## Setup

- Clone this repository to your desktop, using next command:

  git clone https://github.com/OlgaHi/Pierre-s-Bakery.git

- Navigate to the top level of the directory.

  cd Pierre-s-Bakery



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
