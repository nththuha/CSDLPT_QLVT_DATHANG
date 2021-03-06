USE [QLVT_DATHANG]
GO
/****** Object:  StoredProcedure [dbo].[SP_CHITIETTRIGIANHAPXUAT]    Script Date: 14/12/2021 9:26:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CHITIETTRIGIANHAPXUAT]
@NGAYBD DATE,	--Lọc Chi tiết từ ngày
@NGAYKT DATE,	--Lọc Chi tiết đến ngày
@QUYEN NVARCHAR(10),  --Quyền (CONGTY: lọc của cả 2 chi nhánh.  CHINHANH,USER: Lọc trên phân mảnh hiện hành)
@LENH NCHAR(4)				--Lọc chi tiết theo Phiếu Nhập or Phiếu Xuất (NHAP-XUAT)
AS 
BEGIN
	IF(@QUYEN = 'CONGTY')
	BEGIN
		IF(@LENH = 'NHAP')
		BEGIN
			
			SELECT 
			NHAPALL.THANGNAM,
			NHAPALL.TENVT,
			NHAPALL.TONGSOLUONG,
			NHAPALL.TONGDONGIA
			FROM
			(
			(
				SELECT 
				THANGNAM = FORMAT(PN.NGAY, 'MM/yyyy'), --Dùng Format vì MONTH,YEAR không có prefix 0 nên khi ORDER BY phát sinh sort sai tháng 10 11 12
				TENVT = (SELECT VT.TENVT FROM dbo.Vattu AS VT WHERE VT.MAVT = CTPN.MAVT),
				TONGSOLUONG = SUM(CTPN.SOLUONG),
				TONGDONGIA = SUM(CTPN.DONGIA * CTPN.SOLUONG) -- Bẳng tổng của SLuong*DGia trên mỗi record
				FROM 
				(SELECT MAPN, NGAY FROM dbo.PhieuNhap WHERE NGAY BETWEEN @NGAYBD AND @NGAYKT ) AS PN
				INNER JOIN dbo.CTPN AS CTPN
				ON CTPN.MAPN = PN.MAPN
				GROUP BY FORMAT(PN.NGAY, 'MM/yyyy'), CTPN.MAVT 
			) 
			UNION ALL
			(
				SELECT 
				THANGNAM = FORMAT(PN.NGAY, 'MM/yyyy'), --Dùng Format vì MONTH,YEAR không có prefix 0 nên khi ORDER BY phát sinh sort sai tháng 10 11 12
				TENVT = (SELECT VT.TENVT FROM LINK1.QLVT_DATHANG.dbo.Vattu AS VT WHERE VT.MAVT = CTPN.MAVT),
				TONGSOLUONG = SUM(CTPN.SOLUONG),
				TONGDONGIA = SUM(CTPN.DONGIA * CTPN.SOLUONG) -- Bẳng tổng của SLuong*DGia trên mỗi record
				FROM 
				(SELECT MAPN, NGAY FROM LINK1.QLVT_DATHANG.dbo.PhieuNhap WHERE NGAY BETWEEN @NGAYBD AND @NGAYKT ) AS PN
				INNER JOIN LINK1.QLVT_DATHANG.dbo.CTPN AS CTPN
				ON CTPN.MAPN = PN.MAPN
				GROUP BY FORMAT(PN.NGAY, 'MM/yyyy'), CTPN.MAVT 
			)
			) AS NHAPALL
			ORDER BY 1
			RETURN;
		END
		ELSE IF(@LENH = 'XUAT')
		BEGIN
			
			SELECT 
			XUATALL.THANGNAM,
			XUATALL.TENVT,
			XUATALL.TONGSOLUONG,
			XUATALL.TONGDONGIA
			FROM
			(
			(
				SELECT 
				THANGNAM = FORMAT(PX.NGAY, 'MM/yyyy'), --Dùng Format vì MONTH,YEAR không có prefix 0 nên khi ORDER BY phát sinh sort sai tháng 10 11 12
				TENVT = (SELECT VT.TENVT FROM dbo.Vattu AS VT WHERE VT.MAVT = CTPX.MAVT),
				TONGSOLUONG = SUM(CTPX.SOLUONG),
				TONGDONGIA = SUM(CTPX.DONGIA * CTPX.SOLUONG) -- Bẳng tổng của SLuong*DGia trên mỗi record
				FROM 
				(SELECT MAPX, NGAY FROM dbo.PhieuXuat WHERE NGAY BETWEEN @NGAYBD AND @NGAYKT ) AS PX
				INNER JOIN dbo.CTPX AS CTPX
				ON CTPX.MAPX= PX.MAPX
				GROUP BY FORMAT(PX.NGAY, 'MM/yyyy'), CTPX.MAVT 
			) 
			UNION ALL
			(
				SELECT 
				THANGNAM = FORMAT(PX.NGAY, 'MM/yyyy'), --Dùng Format vì MONTH,YEAR không có prefix 0 nên khi ORDER BY phát sinh sort sai tháng 10 11 12
				TENVT = (SELECT VT.TENVT FROM LINK1.QLVT_DATHANG.dbo.Vattu AS VT WHERE VT.MAVT = CTPX.MAVT),
				TONGSOLUONG = SUM(CTPX.SOLUONG),
				TONGDONGIA = SUM(CTPX.DONGIA * CTPX.SOLUONG) -- Bẳng tổng của SLuong*DGia trên mỗi record
				FROM 
				(SELECT MAPX, NGAY FROM LINK1.QLVT_DATHANG.dbo.PhieuXuat WHERE NGAY BETWEEN @NGAYBD AND @NGAYKT ) AS PX
				INNER JOIN 
				LINK1.QLVT_DATHANG.dbo.CTPX AS CTPX
				ON CTPX.MAPX = PX.MAPX
				GROUP BY FORMAT(PX.NGAY, 'MM/yyyy'), CTPX.MAVT 
			)
			) AS XUATALL
			ORDER BY 1
			RETURN;
		END
		
	END
	ELSE --In case: permissions is CHINHANH or USER
	BEGIN
		IF(@LENH = 'NHAP')
		BEGIN
			SELECT 
			THANGNAM = FORMAT(PN.NGAY, 'MM/yyyy'), --Dùng Format vì MONTH,YEAR không có prefix 0 nên khi ORDER BY phát sinh sort sai tháng 10 11 12
			TENVT = (SELECT VT.TENVT FROM dbo.Vattu AS VT WHERE VT.MAVT = CTPN.MAVT),
			TONGSOLUONG = SUM(CTPN.SOLUONG),
			TONGDONGIA = SUM(CTPN.DONGIA * CTPN.SOLUONG) -- Bẳng tổng của SLuong*DGia trên mỗi record
			FROM (SELECT MAPN, NGAY FROM dbo.PhieuNhap
			WHERE NGAY BETWEEN @NGAYBD AND @NGAYKT ) AS PN
			INNER JOIN dbo.CTPN AS CTPN
			ON CTPN.MAPN = PN.MAPN
			GROUP BY FORMAT(PN.NGAY, 'MM/yyyy'), CTPN.MAVT	
			ORDER BY 1  --Sau khi dùng hàm FORMAT bây giờ chỉ có thể Sort theo cột và type là Stringg
			RETURN;
		END
		ELSE IF(@LENH = 'XUAT')
		BEGIN
			SELECT 
			THANGNAM = FORMAT(PX.NGAY, 'MM/yyyy'), --Dùng Format vì MONTH,YEAR không có prefix 0 nên khi ORDER BY phát sinh sort sai tháng 10 11 12
			TENVT = (SELECT VT.TENVT FROM dbo.Vattu AS VT WHERE VT.MAVT = CTPX.MAVT),
			TONGSOLUONG = SUM(CTPX.SOLUONG),
			TONGDONGIA = SUM(CTPX.DONGIA * CTPX.SOLUONG) -- Bẳng tổng của SLuong*DGia trên mỗi record
			FROM (SELECT MAPX, NGAY FROM dbo.PhieuXuat
			WHERE NGAY BETWEEN @NGAYBD AND @NGAYKT) AS PX
			INNER JOIN dbo.CTPX AS CTPX
			ON CTPX.MAPX = PX.MAPX
			GROUP BY FORMAT(PX.NGAY, 'MM/yyyy'), CTPX.MAVT	
			ORDER BY 1  --Sau khi dùng hàm FORMAT bây giờ chỉ có thể Sort theo cột và type là Stringg
			RETURN
		END
	END
END
GO
