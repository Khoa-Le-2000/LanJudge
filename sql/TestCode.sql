use  TestCode
go
--Check Login

if(exists(select * from sys.objects where name = 'func_CheckLogin'))
	drop function func_CheckLogin;
go
create function func_CheckLogin 
								(
									@username nvarchar(255), 
									@password nvarchar(255)
								)
returns int
as
begin
	declare @result int;

	if((@username is null) or (@username = '') or
		(@password is null) or (@password = ''))
	begin
		set @result = 0
		return @result
	end

	if(not exists (select * from Account where UserName = @username))
	begin
		set @result = -1
		return @result
	end

	if @Password != (select Password from Account where UserName = @username)
	begin
		set @result = -2; 
		return @result
	end

	select	@result = AccountID from Account where UserName = @username 
	return @result
end
go

--Account
if(exists(select * from sys.objects where name = 'proc_AddAccount'))
	drop proc proc_AddAccount;
go
create proc proc_AddAccount 
							(
								@userName nvarchar(255),
								@password nvarchar(255),
								@fullName nvarchar(255),
								@permission nvarchar(50),
								@result int OUTPUT
							)
as
begin
	set nocount on;

	if(@userName is null or @userName = '' or
		@password is null or @password = '' or
		@fullName is null or @fullName = '' or
		@permission is null)
	begin
		set @result = 0
		return
	end

	if(exists(select * from Account where UserName = @userName))	 
	begin
		set @result = -1
		return
	end

	Declare @permissionID int
	select	@permissionID = PermissionID
	from	Permission
	where	PermissionName = @permission

	insert into Account ( UserName, Password, FullName, Permisson)
	values (@userName, @password, @fullName, @permissionID)

	SET @result = SCOPE_IDENTITY();

end
go


--Update Account


if(exists(select * from sys.objects where name = 'proc_UpdateAccount'))
	drop proc proc_UpdateAccount;
go
create proc proc_UpdateAccount
			(
				@accountID int,
				@userName nvarchar(255),
				@password nvarchar(255),
				@fullName nvarchar(255),
				@permission nvarchar(50),
				@result int OUTPUT
			)
as
begin
	set nocount on;

	if(@accountID is null or 
		@userName is null or @userName = '' or
		@password is null or @password = '' or
		@fullName is null or @fullName = '' or
		@permission is null)
	begin
		set @result = 0
		return
	end

	if( not exists(select * from Account where AccountID = @accountID)) 
	begin
		set @result = -2
		return
	end

	Declare @permissionID int
	select	@permissionID = PermissionID
	from	Permission
	where	PermissionName = @permission

	update Account
	set UserName = @userName, Password = @password, FullName = @fullName, Permisson = @permissionID
	where AccountID = @accountID

	set @result = @accountID

end
go

--Change full name 
if(exists(select * from sys.objects where name = 'proc_ChangeFullName'))
	drop proc proc_ChangeFullName;
go
create proc proc_ChangeFullName
							(
								@accountID int,
								@fullName nvarchar(50),
								@result int out
							)
as
begin
	set nocount on;

	if(@fullName is null or
	   @fullName is null	)
	begin
		set @result = 0
		return
	end

	if(not exists(select * from Account where AccountID = @accountID)) 
	begin
		set @result = -1
		return
	end

	if(exists(select * from Account
			  where FullName = @fullName and AccountID = @accountID)) 
	begin
		set @result = -2
		return
	end

	update Account
	set FullName = @fullName
	where AccountID = @accountID

	set @result = 1
end
go
				
--Change password 
if(exists(select * from sys.objects where name = 'proc_ChangePassword'))
	drop proc proc_ChangePassword;
go
create proc proc_ChangePassword
							(
								@accountID int,
								@oldpass nvarchar(50),
								@newpass nvarchar(50),
								@result int OUTPUT
							)
as
begin
	set nocount on;

	if(@oldpass is null or
	   @newpass is null	)
	begin
		set @result = 0
		return
	end

	if(not exists(select * from Account where AccountID = @accountID)) 
	begin
		set @result = -1
		return
	end

	if @oldpass != (select Password from Account where AccountID = @accountID)
	begin
		set @result = -2; 
		return @result
	end

	update Account
	set Password = @newpass
	where AccountID = @accountID

	set @result = 1
end
go
--Delete Account
if(exists(select * from sys.objects where name = 'proc_DeleteAccount'))
	drop proc proc_DeleteAccount;
go
create proc proc_DeleteAccount
						(
							@accountID int,
							@result int OUTPUT
						)
as
begin
	set nocount on;

	if(@accountID is null)
	begin
		set @result = 0
		return
	end

	if(not exists(select * from Account where AccountID = @accountID)) 
	begin
		set @result = -1
		return
	end

	if(exists(select * from Submission where AccountID = @accountID))
	begin
		set @result = -2
		return
	end

	delete from Account
	where AccountID = @accountID

	set @result = 1

end
go

--getAccount

if(exists(select * from sys.objects where name = 'func_GetAccount'))
	drop function func_GetAccount;
go
create function func_GetAccount
					(
						@accountID int
					)

returns table

as
	return (select a.AccountID, a.UserName, a.Password, a.FullName, p.PermissionName
			from Account as a join Permission as p on a.Permisson = p.PermissionID
			where AccountID = @accountID 
			)
go

--getAccount

if(exists(select * from sys.objects where name = 'func_GetAccount_UserName'))
	drop function func_GetAccount_UserName;
go
create function func_GetAccount_UserName
					(
						@s nvarchar(50)
					)

returns table

as
	return (select a.AccountID, a.UserName, a.Password, a.FullName, p.PermissionName
			from Account as a join Permission as p on a.Permisson = p.PermissionID
			where UserName = @s 
			)
go
select * from dbo.func_GetAccount_UserName('loan')
--search Account

if(exists(select * from sys.objects where name = 'func_SearchAccount'))
	drop function func_SearchAccount;
go
create function func_SearchAccount
					(
						@search nvarchar(50)
					)

returns table

as
	return (select a.AccountID, a.UserName, a.Password, a.FullName, p.PermissionName as 'Permission'
			from Account as a join Permission as p on a.Permisson = p.PermissionID
			where AccountID like @search 
				or UserName like CONCAT('%',@search,'%') 
				or FullName like CONCAT('%',@search,'%') 
				or p.PermissionName like CONCAT('%',@search,'%') 
			)
go

--Submission
--Add Submission

if(exists(select * from sys.objects where name = 'proc_AddSubmission'))
	drop proc proc_AddSubmission;
go
create proc proc_AddSubmission 
				(
					@accountID int,
					@problemID int,
					@result nvarchar(255),
					@timeRun nvarchar(10),
					@timeSubmit datetime,
					@numOfTestCase int,
					@res int OUTPUT
				)
as
begin
	set nocount on;

	if(@accountID is null or
	@problemID is null or
	@result is null or @result = '' or 
	@timeRun is null or @timeRun = '' or
	@timeSubmit is null or @timeSubmit = '' or
	@numOfTestCase is null)
	begin
		set @res = 0
		return
	end

	if(not exists(select * from Account where AccountID = @accountID))	 
	begin
		set @res = -1
		return
	end
	if(not exists(select * from Problem where ProblemID = @problemID))	 
	begin
		set @res = -2
		return
	end
	
	insert into Submission ( AccountID, ProblemID, Result, TimeRun, TimeSubmit, NumOfTestCase)
	values(@accountID, @problemID, @result, @timeRun, @timeSubmit, @numOfTestCase)
	
	set @res = SCOPE_IDENTITY();

end
go

-- Add Submission (accoundID, problemID)


if(exists(select * from sys.objects where name = 'proc_AddSubmission_Acc_Pro'))
	drop proc proc_AddSubmission_Acc_Pro;
go
create proc proc_AddSubmission_Acc_Pro 
						(
							@accountID int,
							@problemID int,
							@res int OUTPUT
						)
		as
begin
	set nocount on;

	if(@accountID is null or
		@problemID is null)
	begin
		set @res = 0
		return
	end

	if(not exists(select * from Account where AccountID = @accountID))	 
	begin
		set @res = -1
		return
	end

	if(not exists(select * from Problem where ProblemID = @problemID))	 
	begin
		set @res = -2
		return
	end
	
	insert into Submission (AccountID, ProblemID, TimeSubmit)
	values(@accountID, @problemID, GETDATE())
	
	SET @res = SCOPE_IDENTITY();
end
go



-- Add Submission (accoundID, problemID)


if(exists(select * from sys.objects where name = 'proc_AddSubmission_Acc_Pro'))
	drop proc proc_AddSubmission_Acc_Pro;
go
create proc proc_AddSubmission_Acc_Pro 
						(
							@accountID int,
							@problemID int,
							@res int OUTPUT
						)
		as
begin
	set nocount on;

	if(@accountID is null  or
		@problemID is null )
	begin
		set @res = 0
		return
	end

	if(not exists(select * from Account where AccountID = @accountID))	 
	begin
		set @res = -1
		return
	end

	if(not exists(select * from Problem where ProblemID = @problemID))	 
	begin
		set @res = -2
		return
	end
	
	insert into Submission (AccountID, ProblemID)
	values(@accountID, @problemID)
	
	SET @res = SCOPE_IDENTITY();
end
go


--Update Submission

if(exists(select * from sys.objects where name = 'proc_UpdateSubmission'))
	drop proc proc_UpdateSubmission;
go
create proc proc_UpdateSubmission
			(
				@submissionID bigint,
				@accountID int,
				@problemID int,
				@result nvarchar(255),
				@timeRun nvarchar(10),
				@timeSubmit datetime,
				@numOfTestCase int,
				@res int OUTPUT
			)
as
begin
	set nocount on;

	if(@submissionID is null or
		@accountID is null  or
		@problemID is null  or
		@result is null or @result = '' or
		@timeRun is null or @timeRun = '' or
		@timeSubmit is null or @timeSubmit = '' or
		@numOfTestCase is null)
	begin
		set @res = 0
		return
	end

	if(not exists(select * from Submission where SubmissionID = @submissionID)) 
	begin
		set @res = -1
		return
	end

	if(not exists(select * from Account where AccountID = @accountID))	 
	begin
		set @res = -2
		return
	end

	if(not exists(select * from Problem where ProblemID = @problemID))	 
	begin
		set @res = -3
		return
	end
	
	update Submission
	set AccountID = @accountID, ProblemID = @problemID, Result = @result, TimeRun = @timeRun, TimeSubmit = @timeSubmit, NumOfTestCase = @numOfTestCase
	where SubmissionID = @submissionID

	set @res = @submissionID
end
go

--Delete Submission
if(exists(select * from sys.objects where name = 'proc_DeleteSubmission'))
	drop proc proc_DeleteSubmission;
go
create proc proc_DeleteSubmission
			(
				@submissionID bigint,
				@result int OUTPUT
			)
as
begin
	set nocount on;

	if(@submissionID is null) 
	begin
		set @result = 0
		return
	end

	if(not exists(select * from Submission where SubmissionID = @submissionID)) 
	begin
		set @result = -1
		return
	end

	delete from Submission
	where SubmissionID = @submissionID

	set @result = @submissionID

end
go

--GetSubmissionAccount

if(exists(select * from sys.objects where name = 'func_GetSubmissionAccount'))
	drop function func_GetSubmissionAccount;
go
create function func_GetSubmissionAccount
					(	
						@accountID int,
						@testID int
					)

returns @table table (
					SubmissionID bigint, 
					AccountID int, 
					ProblemID int, 
					ProblemName nvarchar(255), 
					Result nvarchar(255), 
					TimeRun nvarchar(255), 
					TimeSubmit datetime, 
					NumOfTestCase int, 
					TestID int
					)

as
begin
	if(@testID = 0) 
	begin
		insert into @table
		select s.SubmissionID, s.AccountID, s.ProblemID, p.ProblemName, s.Result, s.TimeRun, s.TimeSubmit, s.NumOfTestCase, t.TestID
		from Submission as s join Problem as p on s.ProblemID = p.ProblemID
										join Test as t on p.TestID = t.TestID
		where AccountID = @accountID
		return
	end

	if @accountID = 0
	begin
		insert into @table
		select s.SubmissionID, s.AccountID, s.ProblemID, p.ProblemName, s.Result, s.TimeRun, s.TimeSubmit, s.NumOfTestCase, t.TestID
		from Submission as s join Problem as p on s.ProblemID = p.ProblemID
										join Test as t on p.TestID = t.TestID
		where t.TestID = @testID
		return
	end

	insert into @table
	select s.SubmissionID, s.AccountID, s.ProblemID, p.ProblemName, s.Result, s.TimeRun, s.TimeSubmit, s.NumOfTestCase, t.TestID
	from Submission as s join Problem as p on s.ProblemID = p.ProblemID
									join Test as t on p.TestID = t.TestID
	where AccountID = @accountID and t.TestID = @testID
	return			
end
go

--GetSubmissionID

if(exists(select * from sys.objects where name = 'func_GetSubmissionID'))
	drop function func_GetSubmissionID;
go
create function func_GetSubmissionID
					(	
						@submissionID bigint
					)

returns table

as
	return (select *
			from Submission 
			where SubmissionID = @submissionID)
go

--Test
--Add Test
if(exists(select * from sys.objects where name = 'proc_AddTest'))
	drop proc proc_AddTest;
go
create proc proc_AddTest
				(
					@testName nvarchar(255),
					@timeTest int,
					@timeStart datetime,
					@result int OUTPUT
				)
as
begin
	set nocount on;

	if(@testName is null or @testName = '' or
		@timeTest is null or
		@timeStart is null or @timeStart = '')
	begin
		set @result = 0
		return
	end

	--if(ISDATE(@timeStart) = 0)
	--begin
	--	set @result = -2
	--	return
	--end

	insert into Test ( TestName, TimeTest, TimeStart)
	values (@testName, @timeTest, @timeStart)

	set @result = SCOPE_IDENTITY();

end
go
			
--Update
if(exists(select * from sys.objects where name = 'proc_UpdateTest'))
	drop proc proc_UpdateTest;
go
create proc proc_UpdateTest
				(
					@testID int,
					@testName nvarchar(255),
					@timeTest int,
					@timeStart datetime,
					@result int OUTPUT
				)
as
begin
	set nocount on;

	if(@testID is null or
		@testName is null or @testName = '' or
		@timeTest is null or 
		@timeStart is null or @timeStart = '')
	begin
		set @result = 0
		return
	end

	if( not exists(select * from Test where TestID = @testID)) 
	begin
		set @result = -1
		return
	end
	
	update Test
	set TestName = @testName, TimeTest = @timeTest, TimeStart = @timeStart
	where TestID = @testID

	set @result = @testID

end
go

--Delete Test

if(exists(select * from sys.objects where name = 'proc_DeleteTest'))
	drop proc proc_DeleteTest;
go
create proc proc_DeleteTest
				(
					@testID int,
					@result int OUTPUT
				)
as
begin
	set nocount on;

	if(@testID is null)
	begin
		set @result = 0
		return
	end

	if(not exists(select * from Test where TestID = @testID)) 
	begin
		set @result = -1
		return
	end

	declare @table table(ProblemID int)
	
	INSERT INTO @table
	SELECT	ProblemID
	FROM	Problem
	WHERE	TestID = @testID

	if(exists(
			  select * 
			  from	Submission
			  where ProblemID in (SELECT ProblemID FROM @table)
			 )				 
	)
	begin
		set @result = -2
		return
	end
	
	delete from TestCase
	where ProblemID in (SELECT ProblemID FROM @table)

	delete from Problem 
	where ProblemID in (SELECT ProblemID FROM @table)


	delete from Test 
	where TestID = @testID

	set @result = 1
end
go

declare @r int
--exec proc_AddTest '1',1,'1-1-2022',@r out
exec proc_DeleteTest 32, @r OUT
print @r
--GetTest(TestID)
if(exists(select * from sys.objects where name = 'func_GetTest'))
	drop function func_GetTest;
go
create function func_GetTest
				(
					@testID int
				)

returns table

as
	return (select t.TestID, t.TestName, t.TimeTest, t.TimeStart
			from Test as t 
			where TestID = @testID)
go

--

--Search Test
if(exists(select * from sys.objects where name = 'func_SearchTest'))
	drop function func_SearchTest;
go
create function func_SearchTest
					(
						@search nvarchar(50)
					)

returns table

as
	return (select *
			from Test
			where TestID like @search 
				or TestName like CONCAT('%',@search,'%') 
				or TimeTest like CONCAT('%',@search,'%') 
				or TimeStart like CONCAT('%',@search,'%') 
			)
go

--Problem
--AddProblem

if(exists(select * from sys.objects where name = 'proc_AddProblem'))
	drop proc proc_AddProblem;
go
create proc proc_AddProblem
				(
					@problemName nvarchar(255),
					@content nvarchar(255),
					@testID int,
					@result int OUTPUT
				)
as
begin
	set nocount on;

	if(@problemName is null or @problemName = '' or
		@content is null or @content = '' or
		@testID is null)
	begin
		set @result = 0
		return
	end

	if(not exists(select * from Test where TestID = @testID)) 
	begin
		set @result = -1
		return
	end

	insert into Problem (ProblemName, Content, TestID)
	values (@problemName, @content, @testID)

	set @result = SCOPE_IDENTITY();

end
go

--Update Problem

if(exists(select * from sys.objects where name = 'proc_UpdateProblem'))
	drop proc proc_UpdateProblem;
go
create proc proc_UpdateProblem
				(
					@problemID int,
					@problemName nvarchar(255),
					@content nvarchar(255),
					@testID int,
					@result int OUTPUT
				)
as
begin
	set nocount on;

	if(@problemID is null or 
		@problemName is null or @problemName = '' or
		@content is null or @content = '' or
		@testID is null) 
	begin
		set @result = 0
		return
	end

	if( not exists(select * from Problem where ProblemID = @problemID)) 
	begin
		set @result = -1
		return
	end

	if( not exists(select * from Test where TestID = @testID)) 
	begin
		set @result = -2
		return
	end

	update Problem
	set ProblemName = @problemName, Content = @content, TestID = @testID
	where ProblemID = @problemID

	set @result = @problemID

end
go


--delete Problem
if(exists(select * from sys.objects where name = 'proc_DeleteProblem'))
	drop proc proc_DeleteProblem;
go
create proc proc_DeleteProblem 
				(
					@problemID int,
					@result int OUTPUT
				)
as
begin
	set nocount on;

	if(@problemID is null)
	begin
		set @result = 0
		return
	end

	if( not exists(select * from Problem where ProblemID = @problemID)) 
	begin
		set @result = -1
		return
	end
	if(exists(select * from Submission where ProblemID = @problemID))
	begin
		set @result = -2
		return
	end

	delete from TestCase
	where ProblemID = @problemID

	delete from Problem 
	where ProblemID = @problemID

	set @result = 1
end
go

--GetProblem(TestID)
if(exists(select * from sys.objects where name = 'func_GetProblem'))
	drop function func_GetProblem;
go
create function func_GetProblem 
					(
						@testID int
					)

returns table

as

	return (select p.ProblemID, p.ProblemName, p.Content, p.TestID
			from Problem as p 
			where TestID = @testID)

go

--GetProblem(ProblemID)

if(exists(select * from sys.objects where name = 'func_GetProblemID'))
	drop function func_GetProblemID;
go
create function func_GetProblemID
					(
						@problemID int
					)

returns table

as

	return (select p.ProblemID, p.ProblemName, p.Content, p.TestID
			from Problem as p 
			where ProblemID = @problemID)

go

--Search Problem
if(exists(select * from sys.objects where name = 'func_SearchProblem'))
	drop function func_SearchProblem;
go
create function func_SearchProblem
					(
						@search nvarchar(50)
					)

returns table

as
	return (select *
			from Problem
			where ProblemID like @search 
				or ProblemName like CONCAT('%',@search,'%') 
				or Content like CONCAT('%',@search,'%') 
			)
go

--TestCase
--Add TestCase


if(exists(select * from sys.objects where name = 'proc_AddTestCase'))
	drop proc proc_AddTestCase;
go
create proc proc_AddTestCase
				(
					@input nvarchar(255),
					@output nvarchar(255),
					@problemID int,
					@result int OUTPUT
				)
as
begin
	set nocount on;

	if(@input is null or @input = '' or
		@output is null or @output = '' or
		@problemID is null )
	begin
		set @result = 0
		return
	end
	
	if(not exists(select * from Problem where ProblemID = @problemID)) 
	begin
		set @result = -1
		return
	end

	insert into TestCase (Input, Output, ProblemID)
	values (@input, @output, @problemID)

	set @result = SCOPE_IDENTITY();

end
go


--Update TestCase

if(exists(select * from sys.objects where name = 'proc_UpdateTestCase'))
	drop proc proc_UpdateTestCase;
go
create proc proc_UpdateTestCase
				(
					@testcaseID int,
					@input nvarchar(255),
					@output nvarchar(255),
					@problemID int,
					@result int OUTPUT
				)
as
begin
	set nocount on;

	if(@testcaseID is null or 
		@input is null or @input = '' or
		@output is null or @output = '' or
		@problemID is null )
	begin
		set @result = 0
		return
	end

	if(not exists(select * from TestCase where TestCaseID = @testcaseID)) 
	begin
		set @result = -1
		return
	end
	
	if(not exists(select * from Problem where ProblemID = @problemID)) 
	begin
		set @result = -2
		return
	end

	update TestCase
	set Input = @input, Output = @output, ProblemID = @problemID
	where TestCaseID = @testcaseID

	set @result = @testcaseID

end
go

--delete TestCase
if(exists(select * from sys.objects where name = 'proc_DeleteTestCase'))
	drop proc proc_DeleteTestCase;
go
create proc proc_DeleteTestCase 
					(
						@testcaseID int,
						@result int OUTPUT
					)
as
begin
	set nocount on;

	if(@testcaseID is null )
	begin
		set @result = 0
		return
	end

	if(not exists(select * from TestCase where TestCaseID = @testcaseID)) 
	begin
		set @result = -1
		return
	end

	delete from TestCase
	where TestCaseID = @testcaseID
	
	set @result = @testcaseID

end
go


--GetTestCase(ProblemID)

if(exists(select * from sys.objects where name = 'func_GetTestCase'))
	drop function func_GetTestCase;
go
create function func_GetTestCase
				(
					@problemID int
				)

returns table
	
as
	return (select *
			from TestCase 
			where ProblemID = @problemID)
go


--GetTestCase(TestCaseID)

if(exists(select * from sys.objects where name = 'func_GetTestCaseID'))
	drop function func_GetTestCaseID;
go
create function func_GetTestCaseID
				(
					@testcaseID int
				)

returns table
	
as
	return (select *
			from TestCase 
			where TestCaseID = @testcaseID)
go
