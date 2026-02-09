##Adatbázis script
CREATE DATABASE schooldb;
USE schooldb;
 
CREATE TABLE Students (
    Id INT PRIMARY KEY,
    Name VARCHAR(100),
    Email VARCHAR(100),
    Age INT
);
