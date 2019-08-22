# Edmx .NET Core Sample
This sample shows a way to work with edmx (EF6 metadata) in a .NET Core project in Visual Studio without designer support.

It uses a .NET Framework project to host the edmx file, which is supported by the designer, and then imports the edmx file and the relevant generated entity and DbContext classes as linked files in the .NET Core project.

That way you can use the designer to visualize and modify the model using the designer, getting any changes automatically impact the generated code using the regular T4 templates, and then use the results from a .NET Core application. 

You will need to add new linked files for any new entity classes you add or rename in the designer.
