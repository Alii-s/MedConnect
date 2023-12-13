
--CREATE PROCEDURE GetDoctorPatients
--AS
--BEGIN
--    SELECT 
--           u.Fname,
--           u.Lname,
--           u.Email,
--           u.PhoneNumber,
--           u.Gender,
--           p.occupation,
--           p.Building_num,
--           p.Street_Name,
--           p.City,
--           p.Marital_State
--    FROM Users u
--    INNER JOIN Patients p ON u.UserID = p.PatientID
--END

--exec GetDoctorPatients
--go

--CREATE PROCEDURE GetDoctorPatientsWithFilter
--    @Fname nchar(20),
--    @Lname nchar(20),
--    @PhoneNumber nchar(30)
--AS
--BEGIN
--    SELECT 
--           u.Fname,
--           u.Lname,
--           u.Email,
--           u.PhoneNumber,
--           u.Gender,
--           p.occupation,
--           p.Building_num,
--           p.Street_Name,
--           p.City,
--           p.Marital_State
--    FROM Users u
--    INNER JOIN Patients p ON u.UserID = p.PatientID
--    WHERE u.Fname = @Fname AND u.Lname = @Lname AND u.PhoneNumber = @PhoneNumber
--END


--CREATE PROCEDURE GetAllClinicData
--AS
--BEGIN
--    SELECT * FROM Clinics;
--END
--exec GetAllClinicData
--go

--CREATE PROCEDURE AddDoctorSchedule
--    @DoctorID INT,
--    @ClinicID INT,
--    @Day NVARCHAR(20),
--    @StartT TIME(0),
--    @EndT TIME(0)
--AS
--BEGIN
--    INSERT INTO Schedules (DoctorID, ClinicID, Day, StartT, EndT)
--    VALUES (@DoctorID, @ClinicID, @Day, @StartT, @EndT);
--END

--drop procedure GetDoctorScheuale
CREATE PROCEDURE GetDoctorScheuale
 @DoctorID INT
AS
BEGIN
    SELECT City,Schedules.ClinicID,Day,StartT,EndT FROM Schedules,Clinics where  @DoctorID=DoctorID and Clinics.ClinicID=Schedules.ClinicID;
END
--exec GetDoctorScheuale
--go

CREATE PROCEDURE DeleteDoctorSchedule
    @DoctorID INT,
    @ClinicID INT,
	@Day nchar(20)
AS
BEGIN
    DELETE FROM Schedules
    WHERE DoctorID = @DoctorID AND ClinicID = @ClinicID AND @Day = day;
END

