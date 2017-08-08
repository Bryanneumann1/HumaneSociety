create table Animals
(
Id int IDENTITY(1,1) PRIMARY KEY,
Room int, 
Animal_Type varchar (50),
Gender varchar (50),
Name varchar(50),
Adoption_Status varchar(50) NOT NULL,
Age varchar(50),
Shots varchar(50) NOT NULL,
Food varchar(50)
);