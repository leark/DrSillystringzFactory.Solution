# Dr. Sillystringz's Factory

#### By _Seung Lee_

#### _A simple website that lets a user to add engineeres that can repair added machines._

## Technologies Used

* _C#_
* _MSTest_
* _Razor_
* _HTML_
* _CSS_
* _Bootstrap_
* _Entity Framework_

## Description

A simple website where a user can manage a factory with machines and engineers. Machines that are added can have engineers with repair license. User can view all engineers or machines and go to detail page to see which engineer can repair which machine. User can also add such relationship in the details page of each. Engineers and machines can be edited and deleted also.

## Setup/Installation Requirements
_Requires console application such as Git Bash, Terminal, or PowerShell_

1. Open Git Bash or PowerShell if on Windows and Terminal if on Mac
2. Run the command

    ``git clone https://github.com/leark/DrSillystringzFactory.Solution.git``

3. Run the command

    ``cd DrSillystringzFactory.Solution``

* You should now have a folder `VendorOrderTracker.Solution` with the following structure.
    <pre>DrSillystringzFactory.Solution
    ├── .gitignore 
    ├── ... 
    └── Factory
        ├── Controllers
        ├── Models
        ├── ...
        ├── README.md
        └── Startup.cs</pre>

4. Add a file named appsettings.json in the following location 

    <pre>DrSillystringzFactory.Solution
    ├── .gitignore 
    ├── ... 
    └── Factory
        ├── Controllers
        ├── Models
        ├── ...
        ├── Startup.cs
        └── <strong>appsettings.json</strong></pre>
      
5. Copy and paste below JSON text in appsettings.json.

```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=seung_lee;uid=root;pwd=[YOUR-PASSWORD-HERE]"
  }
}
```

7. Replace [YOUR-PASSWORD-HERE] with your MySQL password.

8. Run the command

    ```dotnet ef database update```


<strong>To Run</strong>

Navigate to the following directory in the console
    <pre>DrSillystringzFactory.Solution
    └── <strong>Factory</strong></pre>

Run the following command in the console

  ``dotnet build``

Then run the following command in the console

  ``dotnet run``

This program was built using _`Microsoft .NET SDK 5.0.401`_, and may not be compatible with other versions. Your milage may vary.

## Known Bugs

* _No known issues_

## License

[GNU](/LICENSE)

Copyright (c) 2022 Seung Lee