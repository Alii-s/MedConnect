
CREATE PROCEDURE UpdatePatient
    @UserID int,
	@Fname nchar(20),
	@Lname nchar(20),
	@PhoneNumber nchar(20),
	@occupation nchar(20),
	@Building_num int,
	@Street_Name nchar(20),
	@City nchar(20),
	@Marital_State nchar(20)
AS
BEGIN
UPDATE Users
SET Fname=@Fname,Lname=@Lname,PhoneNumber=@PhoneNumber
WHERE UserID=@UserID
UPDATE Patients
SET occupation=@Occupation,Building_num=@Building_num,Street_Name=@Street_Name,City=@City,Marital_State= @Marital_State
WHERE PatientID = @UserID
END
