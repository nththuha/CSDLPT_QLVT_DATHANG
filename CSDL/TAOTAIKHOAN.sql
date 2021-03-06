USE [QLVT_DATHANG]
GO
/****** Object:  StoredProcedure [dbo].[SP_TAOTAIKHOAN]    Script Date: 14/12/2021 9:30:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_TAOTAIKHOAN]
	@LGNAME VARCHAR(50),
	@PASS VARCHAR(50),
	@USERNAME VARCHAR(50),
	@ROLE VARCHAR(50)
AS
BEGIN
	DECLARE @RET INT
		EXEC @RET = sp_addlogin @LGNAME, @PASS, 'QLVT_DATHANG'
			IF (@RET =1) --LOGINNAME BI TRUNG
				RETURN 1
		EXEC @RET = sp_grantdbaccess @LGNAME, @USERNAME
		IF(@RET =1) --USER NAME BI TRUNG
		BEGIN
			EXEC sp_droplogin @LGNAME
			RETURN 2
		END
		EXEC sp_addrolemember @ROLE, @USERNAME
		IF @ROLE='CONGTY' OR @ROLE='CHINHANH'
			EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
			--EXEC sp_addsrvrolemember @LGNAME, 'sysadmin' -- thuc hien bat ky hoat dong nao tren server
			--EXEC sp_addsrvrolemember @LGNAME, 'processadmin' -- quyenthao tac tren db
			RETURN 0 -- THANH CONG

		IF @ROLE='USER'
			--EXEC sp_addsrvrolemember @LGNAME, 'processadmin' -- quyenthao tac tren db
		COMMIT
		RETURN 0 -- THANH CONG
END
GO
