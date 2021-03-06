USE [QLVT_DATHANG]
GO
/****** Object:  View [dbo].[DSPHANMANH]    Script Date: 14/12/2021 9:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[DSPHANMANH]
AS
SELECT PUBS.description AS TENCN, SUBS.subscriber_server AS TENSERVER
FROM dbo.sysmergepublications AS PUBS, dbo.sysmergesubscriptions AS SUBS
WHERE PUBS.pubid = SUBS.pubid AND PUBS.publisher <> SUBS.subscriber_server AND PUBS.description <> 'SEARCH'
GO
