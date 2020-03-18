CREATE TABLE Highscore(
ID INT PRIMARY KEY IDENTITY(1,1),
Name VARCHAR(30),
Score INT
);

USE [Higscore]  
GO  
CREATE PROCEDURE dbo.NewScore
    @Name VARCHAR(30),
	@Score INT  
AS   

    SET NOCOUNT ON;  
		INSERT INTO Highscore VALUES(@Name, @Score);
GO  

USE [Higscore]  
GO  
CREATE PROCEDURE dbo.ViewAll
AS   

    SET NOCOUNT ON;  
		SELECT * FROM Highscore ORDER BY Score DESC
GO  


drop procedure dbo.ViewAll
drop procedure dbo.NewScore
