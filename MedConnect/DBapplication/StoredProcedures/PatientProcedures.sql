
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
GO

CREATE PROCEDURE GetSessionInfo
    @UserID int,
	@StartDate Date,
	@EndDate Date
AS
BEGIN
SELECT Session_ID,Diagnosis_Sessions.Type,Date,CONCAT(Fname,' ', Lname) AS 'Doctor Name',CONCAT(Clinics.City, ', ', Clinics.Street_Name, ', ', Clinics.Building_num) AS 'Clinic Location',Vital_Signs as 'Vital Signs',Ex_Notes as 'Notes'
FROM Diagnosis_Sessions,Users,Clinics
WHERE @UserID = PatientID AND Date>=@StartDate AND Date<=@EndDate AND Diagnosis_Sessions.ClinicID = Clinics.ClinicID AND Diagnosis_Sessions.IsActive = 1 AND DoctorID = UserID
END




GO
CREATE PROCEDURE [dbo].[InsertRating]
 @D_SessionID int,
 @Comments text,
 @Rating int,
 @DoctorID int,
 @PatientID int
AS
BEGIN
INSERT INTO Rates(DSessionID,Comments,Rating,DoctorID,PatientID,IsActive)
VALUES(@D_SessionID,@Comments,@Rating,@DoctorID,@PatientID,1);
UPDATE Diagnosis_Sessions
SET IsRated = 1
WHERE @D_SessionID=Session_ID;
UPDATE Doctors
SET Avg_Rating = (
    SELECT AVG(Rating) 
    FROM Rates 
    WHERE DoctorID = @DoctorID)
WHERE DoctorID = @DoctorID
END
GO



CREATE PROCEDURE GetDeliveryBills
 @UserID int
AS
BEGIN
SELECT 
    D.Delivery_ID,
    CONCAT(U.Fname,' ', U.Lname) AS 'Pharmacist',
    M.Medicine_Name,
    M.Price AS 'Price per Medicine',
    D.Delivered_Quantity AS 'Quantity',
    D.Delivered_Quantity * M.Price AS 'Total Price',
    D.Date
FROM 
    Delivered D
JOIN 
    Users U ON D.PharmacistID = U.UserID
JOIN 
    Prescribed P ON D.PrescriptionID = P.SessionID
JOIN 
    Medicines M ON P.MedicineID = M.MedicineID
WHERE 
    PatientID = @UserID;
END
GO

