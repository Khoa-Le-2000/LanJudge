
--Account
insert into Account ( UserName, Password, FullName, Permisson) values ( 'Vanny', 'prdZXN', 'Dag', 0);
insert into Account ( UserName, Password, FullName, Permisson) values ( 'Freemon', 'yCf8LlCRM', 'Ephraim', 0);
insert into Account ( UserName, Password, FullName, Permisson) values ( 'Ysabel', 'ul00RaxTNK17', 'Derrek', 1);
insert into Account ( UserName, Password, FullName, Permisson) values ( 'Batholomew', 'anIm4JP', 'Irwin', 1);
insert into Account ( UserName, Password, FullName, Permisson) values ( 'Gerri', 'djGn6lkg71', 'Lenee', 1);
insert into Account ( UserName, Password, FullName, Permisson) values ( 'Dorolisa', 'Af2PbUD7c', 'Fran', 1);
insert into Account ( UserName, Password, FullName, Permisson) values ( 'Rodrick', '2VLhRPZe9Vk', 'Roderic', 1);
insert into Account ( UserName, Password, FullName, Permisson) values ( 'Rosanne', '5AWEuFMAS', 'Erma', 1);
insert into Account ( UserName, Password, FullName, Permisson) values ( 'Marguerite', 'LMy9kIry', 'Kendal', 1);
insert into Account ( UserName, Password, FullName, Permisson) values ( 'Svend', '4oiYynE69lh', 'Noel', 1);

--Test
insert into Test ( TestName, TimeTest, TimeStart) values ( 'Dianne', 1, '2020-12-17');
insert into Test ( TestName, TimeTest, TimeStart) values ( 'Dianne', 2, '2021-01-10');
insert into Test ( TestName, TimeTest, TimeStart) values ( 'Reginald', 3, '2021-05-01');
insert into Test ( TestName, TimeTest, TimeStart) values ( 'Dimitri', 4, '2021-05-09');
insert into Test ( TestName, TimeTest, TimeStart) values ( 'Tabor', 5, '2021-05-23');
insert into Test ( TestName, TimeTest, TimeStart) values ( 'Ossie', 6, '2021-02-11');
insert into Test ( TestName, TimeTest, TimeStart) values ( 'Kiley', 7, '2020-12-07');
insert into Test ( TestName, TimeTest, TimeStart) values ( 'Shaun', 8, '2020-09-09');
insert into Test ( TestName, TimeTest, TimeStart) values ( 'Lian', 9, '2021-04-30');
insert into Test ( TestName, TimeTest, TimeStart) values ( 'Grier', 10, '2020-08-26');
insert into Test ( TestName, TimeTest, TimeStart) values ( 'Grier', 10, '2020-08-26');

--Problem
insert into Problem ( ProblemName, Content, TestID) values ( 'Ransell', 'Plambee', 4);
insert into Problem ( ProblemName, Content, TestID) values ( 'Natasha', 'Kayveo', 6);
insert into Problem ( ProblemName, Content, TestID) values ( 'Jaquelyn', 'Zoonoodle', 3);
insert into Problem ( ProblemName, Content, TestID) values ( 'Lelia', 'Jaloo', 6);
insert into Problem ( ProblemName, Content, TestID) values ( 'Jeane', 'Thoughtsphere', 3);
insert into Problem ( ProblemName, Content, TestID) values ( 'Roarke', 'Skibox', 10);
insert into Problem ( ProblemName, Content, TestID) values ( 'Kipp', 'Avavee', 7);
insert into Problem ( ProblemName, Content, TestID) values ( 'Concordia', 'Oyoba', 6);
insert into Problem ( ProblemName, Content, TestID) values ( 'Guthrie', 'Twitterbridge', 2);
insert into Problem ( ProblemName, Content, TestID) values ( 'Fraze', 'Demizz', 4);

--Submission
insert into Submission ( AccountID, ProblemID, Result, TimeRun, TimeSubmit, NumOfTestCase) values ( 4, 4, 'Quality Petroleum Aloe Vera', '100 ms', '2020-11-25', 2);
insert into Submission ( AccountID, ProblemID, Result, TimeRun, TimeSubmit, NumOfTestCase) values ( 4, 5, 'oxaprozin', '100 ms', '2021-06-30', 8);
insert into Submission ( AccountID, ProblemID, Result, TimeRun, TimeSubmit, NumOfTestCase) values ( 8, 9, 'ONDANSETRON', '100 ms', '2020-10-08', 9);
insert into Submission ( AccountID, ProblemID, Result, TimeRun, TimeSubmit, NumOfTestCase) values ( 10, 7, 'Rice', '2100 ms', '2021-04-11', 3);
insert into Submission ( AccountID, ProblemID, Result, TimeRun, TimeSubmit, NumOfTestCase) values ( 2, 3, 'Levetiracetam', '100 ms', '2021-04-02', 8);
insert into Submission ( AccountID, ProblemID, Result, TimeRun, TimeSubmit, NumOfTestCase) values ( 10, 1, 'RealHeal', '100 ms', '2021-04-22', 1);
insert into Submission ( AccountID, ProblemID, Result, TimeRun, TimeSubmit, NumOfTestCase) values ( 8, 5, 'Nitrous Oxide', '100 ms', '2021-04-22', 7);
insert into Submission ( AccountID, ProblemID, Result, TimeRun, TimeSubmit, NumOfTestCase) values ( 3, 9, 'Sanitizing Alcohol Rub', '100 ms', '2020-09-04', 10);
insert into Submission ( AccountID, ProblemID, Result, TimeRun, TimeSubmit, NumOfTestCase) values ( 5, 8, 'Zicam Allergy Relief', '100 ms', '2021-01-14', 10);
insert into Submission ( AccountID, ProblemID, Result, TimeRun, TimeSubmit, NumOfTestCase) values ( 6, 8, 'Ammonia Inhalants', '100 ms', '2021-06-07', 6);

--TestCase
insert into TestCase ( Input, Output, ProblemID) values ( 'Cassy', 'Baron', 5);
insert into TestCase ( Input, Output, ProblemID) values ( 'Matthiew', 'Kareem', 9);
insert into TestCase ( Input, Output, ProblemID) values ( 'Alberta', 'Rosalia', 6);
insert into TestCase ( Input, Output, ProblemID) values ( 'Lyndsay', 'Leola', 8);
insert into TestCase ( Input, Output, ProblemID) values ( 'Crysta', 'Mic', 3);
insert into TestCase ( Input, Output, ProblemID) values ( 'Raleigh', 'Fanechka', 8);
insert into TestCase ( Input, Output, ProblemID) values ( 'Beck', 'Randal', 3);
insert into TestCase ( Input, Output, ProblemID) values ( 'Dew', 'Madonna', 2);
insert into TestCase ( Input, Output, ProblemID) values ( 'Andrei', 'Babita', 10);
insert into TestCase ( Input, Output, ProblemID) values ( 'Krysta', 'Ketty', 2);
