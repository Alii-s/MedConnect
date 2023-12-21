Drop procedure GetUserEmailPassword
CREATE PROCEDURE GetUserEmailPassword
    @Email nchar(50),
    @Password nchar(30)
AS
BEGIN
    SELECT 
	u.Email,
	u.Password,
	u.Type,
	u.UserID
	FROM Users u
	WHERE u.Email=@Email AND u.Password=@Password AND u.IsActive=1
END
GO
CREATE PROCEDURE RegisterPatient
    @Fname nchar(20),
	@Lname nchar(20),
	@Email nchar(50),
	@PhoneNumber nchar(20),
	@Gender nchar(10),
    @Password nchar(30),
	@DateOfBirth date,
	@occupation nchar(20),
	@City nchar(20),
	@Building_num int,
	@Street_Name nchar(20),
	@Marital_State nchar(20)
AS
BEGIN
	INSERT INTO Users(Fname,Lname,Email,PhoneNumber,Gender,Password,DateOfBirth,Type,IsActive)
	VALUES(@Fname,@Lname,@Email,@PhoneNumber,@Gender,@Password,@DateOfBirth,'P',1);
	DECLARE @NewUserID INT;
	SET @NewUserID = SCOPE_IDENTITY();
	INSERT INTO Patients(PatientID,occupation,City,Building_num,Street_Name,Marital_State)
	VALUES(@NewUserID,@occupation,@City,@Building_num,@Street_Name,@Marital_State)
END
GO
CREATE PROCEDURE RetrieveID
 @Email nchar(50)
AS
BEGIN
SELECT UserID FROM Users WHERE Email=@Email
END