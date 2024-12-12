create database schoolPortal;
use schoolPortal;

create table address(
 Id int auto_increment primary key,
 HouseName varchar(30),
 City varchar(20) not null,
 Pincode varchar(20) not null,
 StudentId int not null,
 CONSTRAINT fk_studentId_Student FOREIGN KEY(StudentId) REFERENCES Student(Id) ON UPDATE CASCADE ON DELETE CASCADE
);

create table student(
 Id int auto_increment primary key,
 StudentName varchar(30),
 Age int not null
);

-- Quries
select * from address;
select * from student;
Insert into student(Id,StudentName,Age) Values (1,"Aarush",12);
Insert into student(Id,StudentName,Age) Values (2,"Ojas",12);

Insert into address(Id,HouseName,City,Pincode,StudentId) Values (101,"Haapy","Pune","411009",1);
Insert into address(Id,HouseName,City,Pincode,StudentId) Values (102,"Joy","Pune","411009",2);
Insert into address(HouseName,City,Pincode,StudentId) Values ("Fantacy","Pune","411049",2);