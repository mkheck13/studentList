### Day 1 We will cover Controllers and Routes (Endpoints)

We are going to create a Controller with the following routes
1. Retrives a list of students. [HttpGet]
2. Add a student to the list. [HttpPost]
3. Remove a student from our list. [HttpDelete]
4. Editting a student in our list. [HttpPut]

We gave our Endpoints (Routes) specific paths using /{parameter} for user interaction
Did Psudo CRUD Function which is Create(POST), Read(GET), Update(EDIT), Delete(DELETE)

dotnet new gitignore

### Day 2 We will cover Services and Dependancy interactions


We are going to create a services file that houses our logic and then we will inject that class into our controller

1. We created a services folder and file
2. transfered function / logic over to our services (typically we would do our services first)
3. We had to add our services into our program.cs in order to provide our services thought our API
4. We injected the data into our controller via "Dependancy injection"
5. We were able to Use and Access our methods from our object (_studentListServices).

### Day 3 today we are covering Models and Built in C# Methods (FInd & FindIndex)

-What is a Model

A Model is a Repersentation of Data that we will use throughout our app aka a blueprint for objects

Eventually when we get into databases our models will repersent the data we will be sending and retreiving from our DB.

