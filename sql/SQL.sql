use master
go
create database TestCode
go
use TestCode
go



if(not exists(select * from sys.objects where name = 'Account'))
begin
	create table Account
	(	
		AccountID int not null IDENTITY(1,1),
		UserName nvarchar(255) not null,
		Password nvarchar(255)  null,
		FullName nvarchar(255)  null,
		Permisson int  null,

		constraint pk_Account primary key(AccountID),
		constraint fk_Account unique(UserName)
	)
end 
go


if(not exists(select * from sys.objects where name = 'Permssion'))
begin
	create table Permssion
	(	
		PermissionID int not null primary key,
		PermissionName nvarchar(50) null,

	)
end 
go

if(not exists(select * from sys.objects where name = 'Problem'))
begin
	create table Problem
	(
		ProblemID int not null IDENTITY(1,1),
		ProblemName nvarchar(255)  null,
		Content nvarchar(255)  null,
		TestID int  null,

		constraint pk_Problem primary key(ProblemID)
	)
end
go


if(not exists(select * from sys.objects where name = 'Submission'))
begin
	create table Submission
	(
		SubmissionID bigint not null IDENTITY(1,1),
		AccountID int not null,
		ProblemID int not null,
		Result nvarchar(255)  null,
		TimeRun nvarchar(10)  null,
		TimeSubmit DateTime null,
		NumOfTestCase int  null,

		constraint pk_Submission primary key(SubmissionID)
	)
end
go


if(not exists(select * from sys.objects where name = 'Test'))
begin
	create table Test
	(
		TestID int not null IDENTITY(1,1),
		TestName nvarchar(255)  null,
		TimeTest int  null,
		TimeStart DateTime  null,

		constraint pk_Test primary key(TestID)
	)
end
go


if(not exists(select * from sys.objects where name = 'TestCase'))
begin
	create table TestCase
	(
		TestCaseID int not null IDENTITY(1,1),
		Input nvarchar(255)  null,
		Output nvarchar(255)  null,
		ProblemID int not null,

		constraint pk_TestCase primary key(TestCaseID)
	)
end
go


--Tao mqh

alter table Submission
		add constraint fk_Submisson_Account_AccountID
		foreign key (AccountID)
		references Account(AccountID)
		on update cascade
		on delete no action
go

alter table Submission
		add constraint fk_Submisson_Problem_ProblemID
		foreign key (ProblemID)
		references Problem(ProblemID)
		on update cascade
		on delete no action
go



alter table Problem
		add constraint fk_Problem_Test_TestID
		foreign key (TestID)
		references Test(TestID)
		on update cascade
		on delete no action
go


alter table TestCase
		add constraint fk_TestCase_Problem_TestID
		foreign key (ProblemID)
		references Problem(ProblemID)
		on update cascade
		on delete no action
go


alter table Permission
		add constraint fk_Permission_Account
		foreign key (PermisisonID)
		references Permission(PermisisonID)
		on update cascade
		on delete no action
go