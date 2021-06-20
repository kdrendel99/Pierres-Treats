# _Dr SillyStringz's Factory_

#### _ASP.NET core MVC application using Entity Framework Core and MySQL to support a website, utilizing Many to Many database relationships and authentication with Identity.

#### _By **Karlson Drendel**_

#### _Table of Contents_

1. [Preview](#preview)
2. [Technologies Used](#technologies)
3. [Description](#description)
4. [Setup/Installation Requirements](#setup)
5. [Additional Setup/Installation Note for Windows Users](#windows)
6. [Specifications](#specs)
7. [Known Bugs](#bugs)
8. [License](#license)
9. [Contact Information](#contact)


## Technologies Used <a id="technologies"></a>

* _C# 8.0_
* _.NET 5 Framework_
* _ASP.NET Core_
* _MVC 2.2_
* _MySQL + MySQL Workbench -v 8.0.15_
* _RESTful Routing_
* _CRUD Functionality_
* _Git_
* _Microsoft Visual Studio Code_

## Description <a id="description"></a>

_Collect user input in a web-based application. This application was build to practice using C# ASP.NET Core using Identity, MVC design pattern, and Entity Framework Core._


## Setup/Installation Requirements <a id="setup"></a>

* _Open terminal._

* _Install Microsoft .NET Version 5._

* _Clone this project with the following git command `$ git clone https://github.com/kdrendel99/Pierres-Treats.git`_

* _Open project using your preferred code editor._

* _Create appsettings.json in PierresTreats.Solution/PierresTreats, and add this code into it:_

    ```
    {
        "ConnectionStrings": {
            "DefaultConnection": "Server=localhost;Port=3306;database=Firstname_Lastname;uid=root;pwd=[YOUR-PASSWORD-HERE];"
        }
    }
    ```

* _Navigate to PierresTreats.Solution/PierresTreats_

* _Enter 'dotnet restore' into terminal and press enter to restore dependencies._

* _Enter 'dotnet ef database update' into the terminal to update database._

* _Enter 'dotnet run' into terminal, and run the project._



## Known Bugs <a id="bugs"></a>
* _No input sanitization yet._


## License <a id="license"></a>

*_Copyright <2021> Karlson Drendel_

*_Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE._


*[MIT](https://choosealicense.com/licenses/mit/)*

Copyright (c) **_2021 Karlson Drendel_**

## Contact Information <a id="contact"></a>
**_Karlson Drendel kdrendel99@gmail.com_**
