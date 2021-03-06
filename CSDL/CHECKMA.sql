USE [QLVT_DATHANG]
GO
/****** Object:  StoredProcedure [dbo].[SP_CHECKMA]    Script Date: 14/12/2021 9:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHECKMA]
@MA NVARCHAR(10),
@KT NVARCHAR(15)
AS
BEGIN
--Kiểm tra Table NhanVien
	IF(@KT = 'MANV')
		BEGIN
			IF EXISTS(SELECT *FROM dbo.NhanVien WHERE dbo.NhanVien.MANV = CONVERT(INT,@MA ))
				SELECT 1;	--Mã NV tồn tại ở chi nhánh hiện tại
			ELSE IF EXISTS(SELECT * FROM LINK2.QLVT_DATHANG.dbo.NhanVien AS NV WHERE NV.MANV = CONVERT(INT, @MA))
				SELECT 2;	--Mã NV tồn tại 
			ELSE
				SELECT 0	--Không bị trùng được thêm
			RETURN;
		END 
--Kiểm tra Table Vattu
	ELSE IF(@KT = 'MAVT')
		BEGIN
			IF EXISTS(SELECT *FROM dbo.Vattu WHERE dbo.Vattu.MAVT =@MA)
				SELECT 1;    --Mã VT tồn tại ở chi nhánh hiện tại
			ELSE
				SELECT 0	--Không bị trùng được thêm
			RETURN;
		END

--Kiểm tra Table Kho
	ELSE IF(@KT = 'MAKHO')
		BEGIN
			IF EXISTS(SELECT *FROM dbo.Kho WHERE dbo.Kho.MAKHO = @MA)
				SELECT 1	--Mã KHO tồn tại ở chi nhánh hiện tại
			ELSE IF EXISTS(SELECT * FROM LINK2.QLVT_DATHANG.dbo.Kho AS KHO WHERE KHO.MAKHO = @MA)
				SELECT 2	--Mã KHO tồn tại
			ELSE
				SELECT 0	--Không bị trùng được thêm
			RETURN;
		END

	ELSE IF(@KT = 'TENKHO')
		BEGIN
			IF EXISTS(SELECT *FROM dbo.Kho WHERE dbo.Kho.TENKHO = @MA)
				SELECT 1	--Tên KHO tồn tại ở chi nhánh hiện tại
			ELSE IF EXISTS(SELECT * FROM LINK2.QLVT_DATHANG.dbo.Kho AS KHO WHERE KHO.TENKHO = @MA)
				SELECT 2	--Tên KHO tồn tại
			ELSE
				SELECT 0	--Không bị trùng được thêm
			RETURN;
		END

--Kiểm tra Table DatHang
	ELSE IF(@KT = 'MADDH')
		BEGIN
			IF EXISTS(SELECT *FROM dbo.DatHang WHERE dbo.DatHang.MasoDDH = @MA)
				SELECT 1	--Tên Mã DDH đã tồn tại ở chi nhánh hiện tại
			ELSE IF EXISTS(SELECT * FROM LINK1.QLVT_DATHANG.dbo.DatHang AS DDH WHERE DDH.MasoDDH = @MA)
				SELECT 2	--Tên Mã DDH tồn tại ở chi nhánh khác
			ELSE
				SELECT 0	--Không bị trùng được thêm
			RETURN;
		END

--Kiểm tra Table PhieuNhap
	ELSE IF(@KT= 'MAPN')
		BEGIN
			IF EXISTS(SELECT *FROM dbo.PhieuNhap WHERE dbo.PhieuNhap.MAPN = @MA)
				SELECT 1	--Tên Mã Phiếu Nhập đã tồn tại ở chi nhánh hiện tại
			ELSE IF EXISTS(SELECT * FROM LINK1.QLVT_DATHANG.dbo.PhieuNhap AS PN WHERE PN.MAPN = @MA)
				SELECT 2	--Tên Mã Phiếu Nhập tồn tại ở chi nhánh khác
			ELSE
				SELECT 0	--Không bị trùng được thêm
			RETURN;
		END

	ELSE IF(@KT = 'PN_DDH')
		BEGIN
			IF EXISTS(SELECT *FROM dbo.PhieuNhap WHERE dbo.PhieuNhap.MasoDDH = @MA)
				SELECT 1	--Tên Mã DDH đã tồn tại ở chi nhánh hiện tại
			ELSE IF EXISTS(SELECT * FROM LINK1.QLVT_DATHANG.dbo.PhieuNhap AS DDH WHERE DDH.MasoDDH = @MA)
				SELECT 2	--Tên Mã DDH tồn tại ở chi nhánh khác
			ELSE
				SELECT 0	--Không bị trùng được thêm
			RETURN;
	END
--Kiểm tra Table PhieuXuat
	ELSE IF(@KT= 'MAPX')
		BEGIN
			IF EXISTS(SELECT *FROM dbo.PhieuXuat WHERE dbo.PhieuXuat.MAPX = @MA)
				SELECT 1	--Tên Mã Phiếu Xuất đã tồn tại ở chi nhánh hiện tại
			ELSE IF EXISTS(SELECT * FROM LINK1.QLVT_DATHANG.dbo.PhieuXuat AS PX WHERE PX.MAPX = @MA)
				SELECT 2	--Tên Mã Phiếu Xuất tồn tại ở chi nhánh khác
			ELSE
				SELECT 0	--Không bị trùng được thêm
			RETURN;
		END
END
GO
