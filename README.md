<div align="center">

  # Pierre's Bakery, For Customers

  #### Independent Project for Epicodus Coding School on Identity in ASP.NET Core MVC, Entity Framework, & Many-to-Many Relationships

  #### Project Began on 1.15.2021.

  #### By Danielle Thompson

</div>

#### Preview
![Splash Page](LINKTODO "Screenshot of website splash page")

---

## Description

After building a [console app](https://github.com/dani-t-codes/PierresBakery.Solution) for orders at Pierre's Bakery, and a [follow-up](https://github.com/dani-t-codes/BakeryMVC.Solution) project to track his orders & vendors, Pierre is back for more. This round, Pierre would like an application with user authentication and a many-to-many relationship between his sweet and savory treats. This application will have the follow MVP features for the client:

- User authentication with log in/log out functionality.
- All users will have read functionality, but only logged in customers can create, update, and delete items.
- `Treat`s and `Flavor`s will have a many-to-many relationship. A treat can have many flavors (e.g. sweet, savory, spicy, creamy), and a flavor can have many treats (e.g. sweet --> chocolate croissants, cheesecake, etc).
- The user will be initially navigated to a splash page listing all treats and flavors that can be individually clicked on to see further details.

![SQL Design Plan](LINKTODO "Many-to-many Relationship Schema for Flavors & Sweets")

---

## User Stories

Incoming...

## Stretch Goals

Incoming...

## Technologies Used/Required

- C# v 7.3
- .NET Core v 2.2
- Identity, ASP.NET MVC Core
- MySQL, MySQL Workbench
- Entity Framework Core, CRUD, RESTful routing
- dotnet script, REPL
- Razor
- [SQL Design Planner](https://ondras.zarovi.cz/sql/demo/)
- [Pixabay](https://www.pixabay.com/)
- [Unsplash](https://unsplash.com/)
- [Visual Code Studio](https://code.visualstudio.com/)

---

## Installation Requirements

#### Installing Git

###### For Mac Users

- Access Terminal in your Finder, and open a new window. Install the package manager, (Homebrew) [https://brew.sh/], on your device by entering this line of code in Terminal: `$ /usr/bin/ruby -e "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/master/install)"`.
- Ensure Homebrew packages are run with this line of code: `echo 'export PATH=/usr/local/bin:$PATH' >> ~/.bash_profile`.
- Once homebrew is installed, install Git, a version control system for code writers, with this line of code `brew install git`.

###### For Windows Users

- Open a new Command Prompt window by typing "Cmd" in your computer's search bar.
- Determine whether you have 32-bit or 64-bit Windows by following these (instructions)[https://support.microsoft.com/en-us/help/13443/windows-which-version-am-i-running].
- Go to (Git Bash)[https://gitforwindows.org/], click on the "Download" button, and download the corresponding exe file from the Git for Windows site.
- Follow the instructions in the set up menu.

#### Installing C#, .NET, dotnet script, & MySQL

- Install C# and .Net according to your operating system below.

###### For Mac

- Download this .NET Core SDK (Software Development Kit)[https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer]. Clicking this link will prompt a .pkg file download from Microsoft.
- Open the .pkg file. This will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.
- Confirm the installation is successful by opening your terminal and running the command $ dotnet --version, which should return something like: `2.2.105`.

###### For Windows (10+)

- Download either the 64-bit .NET Core SDK (Software Development Kit)[https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer]. Clicking these links will prompt an .exe file download from Microsoft.
- Open the file and follow the steps provided by the installer for your OS.
- Confirm the installation is successful by opening a new Windows PowerShell window and running the command dotnet --version. You should see something a response like this: `2.2.105`.

#### For Mac & Windows Operating Systems

- Install dotnet script with the following terminal command `dotnet tool install -g dotnet-script`.

#### Clone or Download the Project

##### To Clone
1. Once you have Git installed on your computer, go to this (GitHub repository)[https://github.com/dani-t-codes/BakeryMarketing.Solution].
2. Click the Green 'Code' button.
3. Copy the HTTPS link, and open a Terminal or CMD on your local system.
4. In the Terminal/CMD, navigate to your Desktop with the command `cd Desktop`.
4. Clone this application onto your local Terminal or CMD with the following command:`git clone https://github.com/dani-t-codes/BakeryMarketing.Solution.git`.
5. Navigate to the project from your Terminal/Cmd with the command `cd BakeryMarketing.Solution`.

##### To Download
1. Alternatively, click the Green 'Code' button from the GitHub repository listed above.
2. Select the "Download Zip" from the dropdown options.
3. Open/unzip the file that has been downloaded to your local system.
4. Open VSCode, or another code editor of your choice, and navigate to the unzipped file folder from File>Open...>BakeryMarketing.Solution to view the project.

##### .NET Core Commands

When the project is opened on your local machine...
- `dotnet restore` to install packages listed in project's boilerplate.
- `dotnet build` will get bin/ and obj/ folders downloaded.
- `dotnet run` will run the application.

(Ensure you are in the project's root directory, Bakery, in your Terminal/CMD before running these commands.)

#### Setting up a Local Database

- Download [MySQL Server](https://dev.mysql.com/downloads/file/?id=484914).
- (Note: If you need additional assistance setting up MySQL, visit their [site](https://dev.mysql.com/doc/mysql-installation-excerpt/5.7/en/) for further instructions.
- Download [MySQL Workbench](https://dev.mysql.com/downloads/file/?id=484391).
- Run `dotnet ef migrations add Initial`
  --> If there is an error stating "Unable to resolve project", this means the command wasn't run in the correct directory.
- Entity creates three files in the Migrations directory.
- Run the following command: `dotnet ef database update`.

#### MySQL Password Protection & .gitignore

1. Create a file in the root directory of the project called "appsettings.json". Add the following snippet of code to the appsettings.json file:

```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=bakery;uid=root;pwd=YOUR-PASSWORD-HERE;"
    }
}
```

2. Where you see "YOUR-PASSWORD-HERE" is where you put the password you created for your MySQL server. Your server name and port might vary depending on your local system. Check MySQL Workbench Connections to determine if the local host and port number match and adjust as needed.

3. Create a .gitignore file and add the following files & folders to it:

- obj/
- bin/
- .vscode/
- .DS_Store
- appsettings.json

#### Import Database with Entity Framework Core

1. From your Terminal/CMD, navigate to the root directory of the project: `cd Desktop/BakeryMarketing.Solution/Factory`.
2. Run the command `dotnet ef database update` to create the database on your local system.
3. If any updates to the database are needed with code changes, run `dotnet ef migrations add <NewMigrationNameHere>`, then `dotnet ef database update` to complete the update.

---

## Known bugs

No known bugs yet. But just you wait ...

[Please report any bugs found here.](https://github.com/dani-t-codes/BakeryMarketing.Solution/issues)

### Contact

Find me on [GitHub](https://github.com/dani-t-codes/)
Email: danithompson74 [at] gmail.com

### License

_MIT_ Copyright (c) 2021 _*Danielle Thompson*_