USE [master]
GO
/****** Object:  Database [TestCode]    Script Date: 7/20/2021 5:03:03 PM ******/
CREATE DATABASE [TestCode]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TestCode', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\TestCode.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TestCode_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\TestCode_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TestCode] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TestCode].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TestCode] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TestCode] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TestCode] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TestCode] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TestCode] SET ARITHABORT OFF 
GO
ALTER DATABASE [TestCode] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [TestCode] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TestCode] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TestCode] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TestCode] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TestCode] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TestCode] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TestCode] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TestCode] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TestCode] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TestCode] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TestCode] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TestCode] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TestCode] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TestCode] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TestCode] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TestCode] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TestCode] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TestCode] SET  MULTI_USER 
GO
ALTER DATABASE [TestCode] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TestCode] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TestCode] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TestCode] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [TestCode] SET DELAYED_DURABILITY = DISABLED 
GO
USE [TestCode]
GO
/****** Object:  UserDefinedFunction [dbo].[func_CheckLogin]    Script Date: 7/20/2021 5:03:03 PM ******/
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
/****** Object:  Table [dbo].[Account]    Script Date: 7/20/2021 5:03:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[AccountID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](255) NOT NULL,
	[Password] [nvarchar](255) NULL,
	[FullName] [nvarchar](255) NULL,
	[Permisson] [int] NULL,
 CONSTRAINT [pk_Account] PRIMARY KEY CLUSTERED 
(
	[AccountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [fk_Account] UNIQUE NONCLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Permission]    Script Date: 7/20/2021 5:03:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permission](
	[PermissionID] [int] NOT NULL,
	[PermissionName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Permission] PRIMARY KEY CLUSTERED 
(
	[PermissionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Problem]    Script Date: 7/20/2021 5:03:03 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Submission]    Script Date: 7/20/2021 5:03:03 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Test]    Script Date: 7/20/2021 5:03:03 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TestCase]    Script Date: 7/20/2021 5:03:03 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  UserDefinedFunction [dbo].[func_GetAccount]    Script Date: 7/20/2021 5:03:03 PM ******/
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
/****** Object:  UserDefinedFunction [dbo].[func_GetAccount_UserName]    Script Date: 7/20/2021 5:03:03 PM ******/
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
/****** Object:  UserDefinedFunction [dbo].[func_GetProblem]    Script Date: 7/20/2021 5:03:03 PM ******/
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
/****** Object:  UserDefinedFunction [dbo].[func_GetProblemID]    Script Date: 7/20/2021 5:03:03 PM ******/
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
/****** Object:  UserDefinedFunction [dbo].[func_GetSubmissionAccount]    Script Date: 7/20/2021 5:03:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[func_GetSubmissionAccount]
					(	
						@accountID nvarchar (255), 
						@testID nvarchar(255)
					)

returns table

as
	return (select s.SubmissionID, s.AccountID, s.ProblemID, s.Result, s.TimeRun, s.TimeSubmit, s.NumOfTestCase, t.TestID
			from Submission as s join Problem as p on s.ProblemID = p.ProblemID
									join Test as t on p.TestID = t.TestID
			where AccountID = @accountID and t.TestID = @testID)

GO
/****** Object:  UserDefinedFunction [dbo].[func_GetSubmissionID]    Script Date: 7/20/2021 5:03:03 PM ******/
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
/****** Object:  UserDefinedFunction [dbo].[func_GetTest]    Script Date: 7/20/2021 5:03:03 PM ******/
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
/****** Object:  UserDefinedFunction [dbo].[func_GetTestCase]    Script Date: 7/20/2021 5:03:03 PM ******/
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
/****** Object:  UserDefinedFunction [dbo].[func_GetTestCaseID]    Script Date: 7/20/2021 5:03:03 PM ******/
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
/****** Object:  UserDefinedFunction [dbo].[func_SearchAccount]    Script Date: 7/20/2021 5:03:03 PM ******/
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
/****** Object:  UserDefinedFunction [dbo].[func_SearchProblem]    Script Date: 7/20/2021 5:03:03 PM ******/
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
/****** Object:  UserDefinedFunction [dbo].[func_SearchTest]    Script Date: 7/20/2021 5:03:03 PM ******/
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
/****** Object:  UserDefinedFunction [dbo].[GetSubmissionID]    Script Date: 7/20/2021 5:03:03 PM ******/
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
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_Permission] FOREIGN KEY([Permisson])
REFERENCES [dbo].[Permission] ([PermissionID])
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
/****** Object:  StoredProcedure [dbo].[proc_AddAccount]    Script Date: 7/20/2021 5:03:03 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_AddProblem]    Script Date: 7/20/2021 5:03:03 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_AddSubmission]    Script Date: 7/20/2021 5:03:03 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_AddSubmission_Acc_Pro]    Script Date: 7/20/2021 5:03:03 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_AddTest]    Script Date: 7/20/2021 5:03:03 PM ******/
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
	
	if(@timeStart < GETDATE())
	begin
		set @result = -1
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
/****** Object:  StoredProcedure [dbo].[proc_AddTestCase]    Script Date: 7/20/2021 5:03:03 PM ******/
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

GO
/****** Object:  StoredProcedure [dbo].[proc_ChangeFullName]    Script Date: 7/20/2021 5:03:03 PM ******/
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

	update Account
	set FullName = @fullName
	where AccountID = @accountID

	set @result = 1
end

GO
/****** Object:  StoredProcedure [dbo].[proc_ChangePassword]    Script Date: 7/20/2021 5:03:03 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_DeleteAccount]    Script Date: 7/20/2021 5:03:03 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_DeleteProblem]    Script Date: 7/20/2021 5:03:03 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_DeleteSubmission]    Script Date: 7/20/2021 5:03:03 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_DeleteTest]    Script Date: 7/20/2021 5:03:03 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_DeleteTestCase]    Script Date: 7/20/2021 5:03:03 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_UpdateAccount]    Script Date: 7/20/2021 5:03:03 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_UpdateProblem]    Script Date: 7/20/2021 5:03:03 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_UpdateSubmission]    Script Date: 7/20/2021 5:03:03 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_UpdateTest]    Script Date: 7/20/2021 5:03:03 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_UpdateTestCase]    Script Date: 7/20/2021 5:03:03 PM ******/
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
USE [master]
GO
ALTER DATABASE [TestCode] SET  READ_WRITE 
GO
