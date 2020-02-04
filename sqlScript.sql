create database PerWebDB
go

using PerWebDB
go

drop table Projects
Create Table Projects(
	ProjectId int primary key identity(1, 1),
	ProjectName varchar(50) not null,
	ProjectDescription text not null,
	[Languages] varchar(100),
	Tools nvarchar(100) not null,
	DateCreated	datetime,
)
go

insert into Projects values('test p name','test p description', 'test languages', 'test tools', GETDATE())


create table Courses(
	CourseId int primary key identity(1,1),
	CourseName varchar(100) not null,
	CourseDescription text,
	CourseLink varchar(50),
	Semester varchar(50)
)
go

insert into Courses values ('test course', 'test description', 'testlink', 'test semester')

create table ContactInfo(
	ContactId int primary key identity(1,1),
	Email varchar(50) not null,
	PhoneNumber varchar(10) not null,
	LinkedIn varchar(50),
	Instagram  varchar(50),
	Facebook varchar(50),
	TicTok varchar(50),
	Website varchar(100)
)
go

insert into ContactInfo values('test email', '1234567890', null,null, null, null, null )



Create Table About(
	AboutId int identity(1,1) primary key,
	Description text,
)
go

insert into About values('test description')


Create Table [Resumes]( 
	ResumeId int identity(1,1) primary key,
	ResumeType varchar(50) null, 
	ResumePDF image,
)
go


insert into Resumes values('Software Engineer',null)

select * from Resumes

Create Table Accounts( 
	AccountId identity(1,1) primary key,
	Email varchar(50) null, 
	Password varchar(50) null
)
go

insert into Accountsvalues('testemail','test password')
