CREATE table Disciplines (
DisciplineId int IDENTITY(1,1) NOT NULL,
Name nvarchar(50) ,
Term int,
Course int ,
Specialization nvarchar(50),
LecturesCount int ,
LabsCount int,
ControlType nvarchar(50))

CREATE table Lectors (
LectorId int IDENTITY(1,1) NOT NULL,
SNP nvarchar(50) ,
Auditory int,
Pulpit nvarchar(50),
ImageData varbinary(MAX))

go
CREATE PROCEDURE insert_Disciplines(
    @name nvarchar(50),
    @term int,
	@course int,
	@specialization nvarchar(50),
	@lecturesCount int ,
	@labsCount int,
	@controlType  nvarchar(50)
	)
AS
    INSERT INTO Disciplines (Name, Term,Course,Specialization,LecturesCount,LabsCount,ControlType)
    VALUES (@name, @term,@course,@specialization,@lecturesCount,@labsCount,@controlType)
  
    SELECT SCOPE_IDENTITY()
GO

exec insert_Disciplines @name = 'smth',@term = 3,@course = 2,@specialization = 'pout',@lecturesCount=2,@labsCount =2,@controlType='sdk';