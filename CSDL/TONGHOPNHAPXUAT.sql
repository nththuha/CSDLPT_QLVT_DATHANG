USE [QLVT_DATHANG]
GO
/****** Object:  StoredProcedure [dbo].[SP_TONGHOPNHAPXUAT]    Script Date: 14/12/2021 9:30:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_TONGHOPNHAPXUAT]
	@NGAYBD date, @NGAYKT date
AS
BEGIN
		SELECT	PN.NGAY,
				NHAP = SUM(CTPN.SOLUONG * CTPN.DONGIA), 
				TYLENHAP = (SUM(CTPN.SOLUONG * CTPN.DONGIA) / (SELECT SUM(SOLUONG*DONGIA) FROM CTPN INNER JOIN PhieuNhap ON CTPN.MAPN=PhieuNhap.MAPN WHERE NGAY BETWEEN @NGAYBD AND @NGAYKT)) INTO #PhieuNhapTemp
		FROM PhieuNhap AS PN
			INNER JOIN CTPN 
			ON PN.MAPN = CTPN.MAPN
		WHERE NGAY BETWEEN @NGAYBD AND @NGAYKT
		GROUP BY PN.NGAY

		SELECT	PX.NGAY,
				XUAT = SUM(CTPX.SOLUONG * CTPX.DONGIA),
				TYLEXUAT = (SUM(CTPX.SOLUONG * CTPX.DONGIA) / (SELECT SUM(SOLUONG*DONGIA) FROM CTPX INNER JOIN PhieuXuat ON CTPX.MAPX=PhieuXuat.MAPX WHERE NGAY BETWEEN @NGAYBD AND @NGAYKT))  INTO #PhieuXuatTemp
		FROM PhieuXuat AS PX
			INNER JOIN CTPX 
			ON PX.MAPX = CTPX.MAPX
		WHERE NGAY BETWEEN @NGAYBD AND @NGAYKT
		GROUP BY PX.NGAY				

		SELECT ISNULL(PN.NGAY, PX.NGAY) AS NGAY, --
		ISNULL(PN.NHAP, 0) AS NHAP,
		ISNULL(PN.TYLENHAP, 0) AS TYLENHAP,
		ISNULL(PX.XUAT, 0) AS XUAT,
		ISNULL(PX.TYLEXUAT, 0) AS TYLEXUAT
		FROM #PhieuNhapTemp AS PN FULL JOIN #PhieuXuatTemp AS PX
		ON PN.NGAY = PX.NGAY
END
GO
