USE [QLVT_DATHANG]
GO
/****** Object:  StoredProcedure [dbo].[SP_XOATAIKHOAN]    Script Date: 14/12/2021 9:31:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_XOATAIKHOAN]
@MANV INT
AS
BEGIN 
	DECLARE @USERNAME VARCHAR(10)
	DECLARE @LOGINNAME VARCHAR(30)
	DECLARE @RET INT

	IF EXISTS(
	SELECT users.name, logins.name 
	FROM sys.database_principals AS users
	INNER JOIN sys.server_principals AS logins
	ON logins.sid = users.sid
	WHERE users.name = CONVERT(NVARCHAR(10), @MANV))
	BEGIN
		SELECT @USERNAME = users.name, @LOGINNAME = logins.name 
		FROM sys.database_principals AS users
		INNER JOIN sys.server_principals AS logins
		ON logins.sid = users.sid
		WHERE users.name = CONVERT(NVARCHAR(10), @MANV)
		IF(@@ROWCOUNT <> 0)
		
				EXEC @RET = SP_DROPLOGIN @LOGINNAME	
				IF(@RET = 1) RETURN 1

				EXEC @RET = SP_DROPUSER  @USERNAME
				IF(@RET = 1) RETURN 2
			
			RETURN 0 --Thành công
	END
END
GO
