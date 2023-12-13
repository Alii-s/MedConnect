
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
	WHERE u.Email=@Email AND u.Password=@Password
END
