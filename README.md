# Edmx .NET Core Sample
This sample shows a way to work with edmx (EF6 metadata) in a .NET Core project in Visual Studio without designer support.
It uses a .NET Framework project to host the edmx file, which is supported by the designer, and then imports the edmx file and the relevant generated entity and DbContext classes as links in the .NET Core project.
