Create database SampleDatabase;

use SampleDataBase;

Create table Users(
	Id int auto_increment primary key,
    Email Varchar(30),
    Password Varchar(30)
);
select * from Users;
-- RENAME TABLE User TO Users;
-- That statement is equivalent to the following ALTER TABLE statement:
-- ALTER TABLE old_table RENAME new_table;
Insert into Users(Id,Email,Password)Values(1,"shubhangi.tambade@gmail.com","tfl@123");

-- Employees
Create table Employees(
	Id int auto_increment primary key,
    FirstName Varchar(30),
    LastName Varchar(30),
    Email Varchar(30),
    Contact Varchar(30)
);

select * from Employees;
 Insert into Employees(Id,FirstName,LastName,Email,Contact)Values(1,"Shubhangi","Tambade","shubhangi.tambade@gmail.com",9881735802);
