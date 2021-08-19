 


create table Book(
id bigint identity (100,1) primary key,
BookId varchar(20) unique not null,
BookName varchar(100),
Author varchar(100)
)

create table Student(
id bigint identity (100,1) primary key,
StudentId varchar(50) unique not null,
[Email] varchar(100) unique not null,
[Name] varchar(100),
[Phone] varchar(15),
ClassName varchar(4),
HomeAddress varchar(400),
Age int,
IsActive bit
)

create table LibraryAssets(
id bigint identity (100,1) primary key,
BookId varchar(20) FOREIGN KEY REFERENCES Book(BookId), 
Quantity int,
IsActive bit
)

create table BookAssignments(
id bigint identity (10,1) primary key,
AssignmentId  varchar(50) unique not null,
StudentId varchar(50) FOREIGN KEY REFERENCES Student(StudentId), 
BookId varchar(20) FOREIGN KEY REFERENCES Book(BookId), 
AllotStartDate datetime,
AllotEndDate datetime,
IsBookGiven bit,
IsReturned bit
)