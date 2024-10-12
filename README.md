# CQRS-without-MediatR

A straightforward Asp.Net Minimal API that demonstrates the implementation of **CQRS** (Command Query Responsibility Segregation) without requiring any library.
The aim of this project is to learn how to physically divide classes into two distinct responsibilities, in order to achieve scalability, maintainability, performance and adapt two mind set .
It is highly adaptable in navigating complex domains, allowing for independent customization of the data structure for read and write operations.

![CQRS Architecture](https://github.com/user-attachments/assets/8e889640-63b5-4873-a91e-737aa115a5a3)


### Folder Structure
```md
.
├── MinimalApiCqrs
│   ├── Database
│   │   └── InMemoryDatabase.cs
│   ├── EndPoints
│   │   └── Movies.cs
│   ├── Entities
│   │   ├── EntityBase.cs
│   │   └── Movie.cs
│   ├── MinimalApiCqrs.csproj
│   ├── MinimalApiCqrs.http
│   ├── Program.cs
│   ├── Properties
│   │   └── launchSettings.json
│   ├── Repositoris
│   │   ├── Abstractions
│   │   │   ├── IMovieReadRepository.cs
│   │   │   ├── IMovieWriteRepository.cs
│   │   │   ├── IReadRepository.cs
│   │   │   └── IWriteRepository.cs
│   │   ├── MovieReadRepository.cs
│   │   └── MovieWriteRepository.cs
│   ├── appsettings.Development.json
│   ├── appsettings.json
│   ├── handlers
│   │   ├── command
│   │   │   ├── AddBookCommand.cs
│   │   │   ├── DeleteBookCommand.cs
│   │   │   └── UpdateBookCommand.cs
│   │   └── queries
│   │       ├── GetBookByIdQuery.cs
│   │       └── GetBookQuery.cs
└── MinimalApiCqrs.sln

```

***ReadRepository*** has only one responsibility that is all of its methods are used to read data from the database.
It is used to transfer data from database to the application as efficient as possible without changing its state

***WriteRepository*** has only one responsibility that is all of its methods are used to write data to the database.
It is used to transfer data from application to the database in more generic ways. 


### Dependency Flow
![Dependency Flow](https://github.com/user-attachments/assets/8c1ca414-d653-4500-8c23-047a80972ce9)


### Loose Coupling Through Mediator Pattern
Here is an example of how an update operation functions in a loosely coupled manner. 
In the *UpdateMovieCommandHandler*  class, we have two interactions with the database using two different objects.
First, we have to retrieve the last state of that movie from the database.
Second, we have to replace the old state with the new one and save the latest state (Movie) in the database.
This has to be done in a loosely coupled way.
![Loose Coupling](https://github.com/user-attachments/assets/76e6093c-42d1-4361-8633-8e98f072961c)
