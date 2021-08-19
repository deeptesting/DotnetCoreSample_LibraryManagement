DECLARE @BookId varchar(50)

SET @BookId =
(select 'BK'+CONVERT(varchar(10),ROUND(RAND()*10000,0))+ CONVERT(varchar(10),DAY(getdate()))+CONVERT(varchar(10),MONTH(getdate())))

insert into Book(BookId,BookName,Author) values
(@BookId,'The C++ Programming Language','Bjarne Stroustrup')

----------------------------------------------------------------------------------------------------------------
SET @BookId =
(select 'BK'+CONVERT(varchar(10),ROUND(RAND()*10000,0))+ CONVERT(varchar(10),DAY(getdate()))+CONVERT(varchar(10),MONTH(getdate())))

insert into Book(BookId,BookName,Author) values
(@BookId,'The Practice of Programming','Brian W. Kernighan, Rob Pike')

----------------------------------------------------------------------------------------------------------------
SET @BookId =
(select 'BK'+CONVERT(varchar(10),ROUND(RAND()*10000,0))+ CONVERT(varchar(10),DAY(getdate()))+CONVERT(varchar(10),MONTH(getdate())))

insert into Book(BookId,BookName,Author) values
(@BookId,'Fundamentals of Computer Algorithms','Ellis Horowitz')

----------------------------------------------------------------------------------------------------------------
SET @BookId =
(select 'BK'+CONVERT(varchar(10),ROUND(RAND()*10000,0))+ CONVERT(varchar(10),DAY(getdate()))+CONVERT(varchar(10),MONTH(getdate())))

insert into Book(BookId,BookName,Author) values
(@BookId,'The Art of Unix Programming','Eric Raymond')

----------------------------------------------------------------------------------------------------------------
 SET @BookId =
(select 'BK'+CONVERT(varchar(10),ROUND(RAND()*10000,0))+ CONVERT(varchar(10),DAY(getdate()))+CONVERT(varchar(10),MONTH(getdate())))

insert into Book(BookId,BookName,Author) values
(@BookId,'The Java Programming Language','James Gosling')

----------------------------------------------------------------------------------------------------------------
 SET @BookId =
(select 'BK'+CONVERT(varchar(10),ROUND(RAND()*10000,0))+ CONVERT(varchar(10),DAY(getdate()))+CONVERT(varchar(10),MONTH(getdate())))

insert into Book(BookId,BookName,Author) values
(@BookId,'Patterns of Software','Richard P. Gabriel')


----------------------------------------------------------------------------------------------------------------
          
 select * from Book

 select * from LibraryAssets
 select * from  [dbo].[BookAssignments]
 select * from [dbo].[Student]


