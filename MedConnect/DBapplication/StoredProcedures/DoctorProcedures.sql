
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
    @Fname nchar(20),
    @Lname nchar(20),
    @PhoneNumber nchar(30)
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