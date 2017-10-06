To install this template, clone the repo and then from a command prompt type
```
dotnet new -i <parentDirectoryProjectWasClonedTo>\AngularAspNetCoreTemplate
```

To generate a new project based on the template, from a command prompt type
```
dotnet new breamanAngular -n <projectName>
```

To uninstall this template, open a command prompt and type
```
dotnet new -u <parentDirectoryProjectWasClonedTo>\AngularAspNetCoreTemplate
```

Need to have angular-cli globally installed to use the CLI features
```
npm install -g angular-cli
```

Optionally have yarn installed
```
npm install -g yarn
```

After creating project, make sure to navigate into the src\\&lt;projectName&gt;.Web project and run
```
dotnet restore - to get the nuget packages pulled in correctly
yarn (or npm install) - to get the node_modules installed
```

After doing the above, you should be able to run the application and get a basic Angular SPA Application that uses WebPack, Hot Module Reloading, and Server Side rendering

Project is setup to use Sqlite out of the box, to generate your database scripts, use standard migration commands
```
dotnet ef migrations add InitialDb -p ..\<projectName>.domain\<projectName>.domain.csproj
dotnet ef migrations script
dotnet ef database update
```
