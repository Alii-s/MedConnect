
CREATE PROCEDURE GetDoctorPatients
AS
BEGIN
    SELECT 
           u.Fname,
           u.Lname,
           u.Email,
           u.PhoneNumber,
           u.Gender,
           p.occupation,
           p.Building_num,
           p.Street_Name,
           p.City,
           p.Marital_State
    FROM Users u
    INNER JOIN Patients p ON u.UserID = p.PatientID
END

exec GetDoctorPatients
go

CREATE PROCEDURE GetDoctorPatientsWithFilter
    @Fname nvarchar(50),
    @Lname nvarchar(50),
    @PhoneNumber nvarchar(50)
AS
BEGIN
    SELECT 
           u.Fname,
           u.Lname,
           u.Email,
           u.PhoneNumber,
           u.Gender,
           p.occupation,
           p.Building_num,
           p.Street_Name,
           p.City,
           p.Marital_State
    FROM Users u
    INNER JOIN Patients p ON u.UserID = p.PatientID
    WHERE u.Fname = @Fname AND u.Lname = @Lname AND u.PhoneNumber = @PhoneNumber
END