use TestCode
go
--check login : ok

select dbo.func_CheckLogin('3','3')
select * from Account

--add Account: ok

declare @result int
exec proc_AddAccount 'wa','asdsad','sadsadsa',0 , @result out
print @result
select * from Account
--upadte account: ok

declare @result int
exec proc_UpdateAccount 3,'a','asdsad','sadsadsa',2 , @result out
print @result

--delete Account : ok

declare @res int
exec proc_DeleteAccount 9, @res out
print @res

--get Account : ok

select * from func_GetAccount(3)

--proc_AddSubmission : ok

declare @res int
exec proc_AddSubmission 1,null,'loan', 'ni', '2020-2-1 00:03:00', 3, @res out
print @res

--proc_AddSubmission_Acc_Pro : ok

declare @res int
exec proc_AddSubmission_Acc_Pro 7,'', @res out
print @res

select * from Submission

--update proc_UpdateSubmission : ok

declare @res int
exec proc_UpdateSubmission 11,3,4,'AC', '2020-11-11 00:00:00', '2021-11-11 00:00:00', 2, @res out
print @res

--Delete submission : ok

declare @res int
exec proc_DeleteSubmission 15, @res out
print @res

--get func_GetSubmissionAccount : ok

select * from func_GetSubmissionAccount (5,7)

--get func_GetSubmissionID : ok

select * from func_GetSubmissionID (4)

--proc_AddTest : ok

declare @res int
exec proc_AddTest 1,23,'2001-12-2 00:00:00', @res out
print @res
select * from Test

--update test : ok

declare @res int
exec proc_UpdateTest 22, 'as', 21, '2021-11-11 00:00:00', @res output
print @res		

--delete test : ok

declare @res int
exec proc_DeleteTest 21, @res out
print @res

--getTest : ok

select * from dbo.func_GetTest(4)


--add proc_AddProblem : ok

declare @res int
exec proc_AddProblem 'w', 'ac', 1, @res out
print @res

select * from Problem

--update proc_UpdateProblem : ok

declare @res int 
exec proc_UpdateProblem 21, 'loan', 'ac', 1, @res out
print @res
	
select * from Problem

--delete proc_DeleteProblem : ok 

declare @res int
exec proc_DeleteProblem 8, @res out
print @res

--getProblem(TestID) : ok

select * from func_GetProblem(3)

--getProblem(ProblemID) : ok

select * from func_GetProblemID (3)


--add proc_AddTestCase : ok

declare @res int
exec proc_AddTestCase 'a', 'b', 35, @res out
print @res

select * from TestCase

--update proc_UpdateTestCase : ok

declare @res int
exec proc_UpdateTestCase 5, 'a', 'b', 3, @res out
print @res

--delete proc_DeleteTestCase : ok

declare @res int
exec proc_DeleteTestCase 12, @res out
print @res

--getTestCasse : ok
select * from func_GetTestCase(5)

--getTestCasseID : ok
select * from func_GetTestCaseID(5)


select * from Problem
select * from TestCase

declare @r int
exec proc_DeleteProblem 10, @r out
print @r