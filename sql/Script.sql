USE [TestCode]
GO
/****** Object:  UserDefinedFunction [dbo].[func_CheckLogin]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[func_CheckLogin] 
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
GO
/****** Object:  UserDefinedFunction [dbo].[func_CountSearchAccountPage]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[func_CountSearchAccountPage]
(
	@Search nvarchar(50)
)
RETURNS INT
AS
BEGIN
	DECLARE	@Cnt INT

	SELECT	@Cnt = COUNT(AccountID)
	FROM	Account
	WHERE	UserName LIKE CONCAT('%',@Search,'%')
		OR FullName LIKE CONCAT('%',@Search,'%')

	RETURN	@Cnt
END
GO
/****** Object:  UserDefinedFunction [dbo].[func_GetSubmissionAccount]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[func_GetSubmissionAccount]
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
GO
/****** Object:  Table [dbo].[Account]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[AccountID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](255) NOT NULL,
	[Password] [nvarchar](255) NULL,
	[FullName] [nvarchar](255) NULL,
	[PermissionId] [int] NULL,
 CONSTRAINT [pk_Account] PRIMARY KEY CLUSTERED 
(
	[AccountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [fk_Account] UNIQUE NONCLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permission]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permission](
	[PermissionId] [int] NOT NULL,
	[PermissionName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Permission] PRIMARY KEY CLUSTERED 
(
	[PermissionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[func_GetAccount]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[func_GetAccount]
					(
						@accountID int
					)

returns table

as
	return (select a.AccountID, a.UserName, a.Password, a.FullName, p.PermissionName
			from Account as a join Permission as p on a.Permisson = p.PermissionID
			where AccountID = @accountID 
			)
GO
/****** Object:  Table [dbo].[Submission]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Submission](
	[SubmissionID] [int] IDENTITY(1,1) NOT NULL,
	[AccountID] [int] NOT NULL,
	[ProblemID] [int] NOT NULL,
	[Result] [nvarchar](255) NULL,
	[TimeRun] [nvarchar](10) NULL,
	[TimeSubmit] [datetime] NULL,
	[NumOfTestCase] [int] NULL,
 CONSTRAINT [pk_Submission] PRIMARY KEY CLUSTERED 
(
	[SubmissionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[GetSubmissionID]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[GetSubmissionID]
					(	
						@submissionID bigint
					)

returns table

as
	return (select*
			from Submission 
			where SubmissionID = @submissionID)

GO
/****** Object:  UserDefinedFunction [dbo].[func_GetAccount_UserName]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[func_GetAccount_UserName]
					(
						@s nvarchar(50)
					)

returns table

as
	return (select a.AccountID, a.UserName, a.Password, a.FullName, p.PermissionName
			from Account as a join Permission as p on a.Permisson = p.PermissionID
			where UserName = @s 
			)
GO
/****** Object:  UserDefinedFunction [dbo].[func_SearchAccount]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[func_SearchAccount]
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
GO
/****** Object:  UserDefinedFunction [dbo].[func_GetSubmissionID]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[func_GetSubmissionID]
					(	
						@submissionID bigint
					)

returns table

as
	return (select *
			from Submission 
			where SubmissionID = @submissionID)
GO
/****** Object:  Table [dbo].[Test]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Test](
	[TestID] [int] IDENTITY(1,1) NOT NULL,
	[TestName] [nvarchar](255) NULL,
	[TimeTest] [int] NULL,
	[TimeStart] [datetime] NULL,
 CONSTRAINT [pk_Test] PRIMARY KEY CLUSTERED 
(
	[TestID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[func_GetTest]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[func_GetTest]
				(
					@testID int
				)

returns table

as
	return (select t.TestID, t.TestName, t.TimeTest, t.TimeStart
			from Test as t 
			where TestID = @testID)
GO
/****** Object:  UserDefinedFunction [dbo].[func_SearchTest]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[func_SearchTest]
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
GO
/****** Object:  Table [dbo].[Problem]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Problem](
	[ProblemID] [int] IDENTITY(1,1) NOT NULL,
	[ProblemName] [nvarchar](255) NULL,
	[Content] [nvarchar](255) NULL,
	[TestID] [int] NULL,
 CONSTRAINT [pk_Problem] PRIMARY KEY CLUSTERED 
(
	[ProblemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[func_GetProblem]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[func_GetProblem] 
					(
						@testID int
					)

returns table

as

	return (select p.ProblemID, p.ProblemName, p.Content, p.TestID
			from Problem as p 
			where TestID = @testID)

GO
/****** Object:  UserDefinedFunction [dbo].[func_GetProblemID]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[func_GetProblemID]
					(
						@problemID int
					)

returns table

as

	return (select p.ProblemID, p.ProblemName, p.Content, p.TestID
			from Problem as p 
			where ProblemID = @problemID)

GO
/****** Object:  UserDefinedFunction [dbo].[func_SearchProblem]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[func_SearchProblem]
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
GO
/****** Object:  Table [dbo].[TestCase]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TestCase](
	[TestCaseID] [int] IDENTITY(1,1) NOT NULL,
	[Input] [nvarchar](255) NULL,
	[Output] [nvarchar](255) NULL,
	[ProblemID] [int] NOT NULL,
 CONSTRAINT [pk_TestCase] PRIMARY KEY CLUSTERED 
(
	[TestCaseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[func_GetTestCase]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[func_GetTestCase]
				(
					@problemID int
				)

returns table
	
as
	return (select *
			from TestCase 
			where ProblemID = @problemID)
GO
/****** Object:  UserDefinedFunction [dbo].[func_GetTestCaseID]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[func_GetTestCaseID]
				(
					@testcaseID int
				)

returns table
	
as
	return (select *
			from TestCase 
			where TestCaseID = @testcaseID)
GO
/****** Object:  UserDefinedFunction [dbo].[func_GetAccountPage]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[func_GetAccountPage]
(
	@PageSize int
	,@Page int
)
RETURNS TABLE
AS
RETURN
	SELECT	*
	FROM	Account
	ORDER BY AccountID
	OFFSET	(@Page - 1)*@PageSize ROWS
	FETCH NEXT @PageSize ROWS ONLY
GO
/****** Object:  UserDefinedFunction [dbo].[func_SearchAccountPage]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[func_SearchAccountPage]
(
	@Search nvarchar(50)
	,@Page	int
	,@PageSize	int
)
RETURNS TABLE
AS
RETURN
(
	SELECT	*
	FROM	Account
	WHERE	UserName LIKE CONCAT('%',@Search,'%')
		OR FullName LIKE CONCAT('%',@Search,'%')
	ORDER BY AccountID
	OFFSET	(@Page-1)*@PageSize ROWS
	FETCH NEXT @PageSize ROWS ONLY
)
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_Permission] FOREIGN KEY([PermissionId])
REFERENCES [dbo].[Permission] ([PermissionId])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_Permission]
GO
ALTER TABLE [dbo].[Problem]  WITH CHECK ADD  CONSTRAINT [fk_Problem_Test_TestID] FOREIGN KEY([TestID])
REFERENCES [dbo].[Test] ([TestID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Problem] CHECK CONSTRAINT [fk_Problem_Test_TestID]
GO
ALTER TABLE [dbo].[Submission]  WITH CHECK ADD  CONSTRAINT [fk_Submisson_Account_AccountID] FOREIGN KEY([AccountID])
REFERENCES [dbo].[Account] ([AccountID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Submission] CHECK CONSTRAINT [fk_Submisson_Account_AccountID]
GO
ALTER TABLE [dbo].[Submission]  WITH CHECK ADD  CONSTRAINT [fk_Submisson_Problem_ProblemID] FOREIGN KEY([ProblemID])
REFERENCES [dbo].[Problem] ([ProblemID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Submission] CHECK CONSTRAINT [fk_Submisson_Problem_ProblemID]
GO
ALTER TABLE [dbo].[TestCase]  WITH CHECK ADD  CONSTRAINT [fk_TestCase_Problem_TestID] FOREIGN KEY([ProblemID])
REFERENCES [dbo].[Problem] ([ProblemID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[TestCase] CHECK CONSTRAINT [fk_TestCase_Problem_TestID]
GO
/****** Object:  StoredProcedure [dbo].[proc_AddAccount]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_AddAccount] 
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
GO
/****** Object:  StoredProcedure [dbo].[proc_AddProblem]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_AddProblem]
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
GO
/****** Object:  StoredProcedure [dbo].[proc_AddSubmission]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_AddSubmission] 
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
GO
/****** Object:  StoredProcedure [dbo].[proc_AddSubmission_Acc_Pro]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_AddSubmission_Acc_Pro] 
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
GO
/****** Object:  StoredProcedure [dbo].[proc_AddTest]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_AddTest]
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
GO
/****** Object:  StoredProcedure [dbo].[proc_AddTestCase]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_AddTestCase]
				(
					@input nvarchar(255),
					@output nvarchar(255),
					@problemID int,
					@result int OUTPUT
				)
as
begin
	set nocount on;

	if(
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
GO
/****** Object:  StoredProcedure [dbo].[proc_ChangeFullName]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_ChangeFullName]
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
GO
/****** Object:  StoredProcedure [dbo].[proc_ChangePassword]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_ChangePassword]
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
GO
/****** Object:  StoredProcedure [dbo].[proc_DeleteAccount]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_DeleteAccount]
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
GO
/****** Object:  StoredProcedure [dbo].[proc_DeleteProblem]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_DeleteProblem] 
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
GO
/****** Object:  StoredProcedure [dbo].[proc_DeleteSubmission]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_DeleteSubmission]
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
GO
/****** Object:  StoredProcedure [dbo].[proc_DeleteTest]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_DeleteTest]
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
GO
/****** Object:  StoredProcedure [dbo].[proc_DeleteTestCase]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_DeleteTestCase] 
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
GO
/****** Object:  StoredProcedure [dbo].[proc_UpdateAccount]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_UpdateAccount]
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
GO
/****** Object:  StoredProcedure [dbo].[proc_UpdateProblem]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_UpdateProblem]
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
GO
/****** Object:  StoredProcedure [dbo].[proc_UpdateSubmission]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_UpdateSubmission]
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
GO
/****** Object:  StoredProcedure [dbo].[proc_UpdateTest]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_UpdateTest]
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
GO
/****** Object:  StoredProcedure [dbo].[proc_UpdateTestCase]    Script Date: 8/27/2021 4:51:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_UpdateTestCase]
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
GO
