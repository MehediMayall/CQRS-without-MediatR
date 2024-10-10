# CQRS-without-MediatR

A straightforward Asp.Net Minimal API that demonstrates the implementation of **CQRS** (Command Query Responsibility Segregation) without requiring any library.

![CQRS Architecture](https://github.com/user-attachments/assets/8e889640-63b5-4873-a91e-737aa115a5a3)


### Folder Structure
```md


```

***ReadRepository*** has only one responsibility that is all of its methods are used to read data from the database.
It is used to transfer data from database to the application as efficient as possible without changing its state

***WriteRepository*** has only one responsibility that is all of its methods are used to write data to the database.
It is used to transfer data from application to the database in more generic ways. 


### Dependency Flow
![Dependency Flow](https://github.com/user-attachments/assets/8c1ca414-d653-4500-8c23-047a80972ce9)
