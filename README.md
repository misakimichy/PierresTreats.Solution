# Pierre's Treats

#### _C#, .NET: Pierre's Treats, 01/24/2019_

## Description
Create the Pierre's Treats application which allows user to create an account and login. Once the user logged in the user can create sweets and treats with many-to-many relationship.

## Application specifications:
- Authentication
    - The user can create an account with username, email and password.
    - Once the user log in, the username will be displayed on the top right of the application.
    - Once the user log out, the top right display will be switched to links to `Login` and `Register a New User`.
    - The user cannot see flavors nor treats without logging in to this application.

- Many-to-Many relationship
    - The user can create a flavor or a treat and it saves to database.
    - The user can view details of flavor or treat.
    - The user can edit details of flavor or treat.
    - The user can delete a treat or flavor.


## Setup/Installation Requirements

1. Clone this repo:
```
$ git clone https://github.com/misakimichy/PierresTreats.Solution.git
```

2. Setup MySQL database:
```
$ dotnet ef database update
```

3. Run application
```
$ dotnet run
```

## Known Bugs
* No known bugs at this time.

## Support and contact details
Email me misaki.koonce@gmail.com with any comments or feedbacks.

## Technologies Used
C# and ASP.NET Core MVC, MySQL, Entity Framework, CSS and Bootstrap 

## License
Copyright © 2020 under the MIT License