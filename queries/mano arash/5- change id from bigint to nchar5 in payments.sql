/*
   Sunday, May 24, 20158:01:23 PM
   User: 
   Server: PARSA-PC\SQLEXPRESS
   Database: M_A_DB
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Payments
	DROP CONSTRAINT DF_Payments_mablagh
GO
CREATE TABLE dbo.Tmp_Payments
	(
	id nchar(5) NOT NULL,
	name nvarchar(50) NOT NULL,
	date nchar(10) NULL,
	paidformonth nvarchar(10) NULL,
	mablagh bigint NOT NULL,
	sharh nvarchar(MAX) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Payments ADD CONSTRAINT
	DF_Payments_mablagh DEFAULT ((0)) FOR mablagh
GO
IF EXISTS(SELECT * FROM dbo.Payments)
	 EXEC('INSERT INTO dbo.Tmp_Payments (id, name, date, paidformonth, mablagh, sharh)
		SELECT CONVERT(nchar(5), id), name, date, paidformonth, mablagh, sharh FROM dbo.Payments WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.Payments
GO
EXECUTE sp_rename N'dbo.Tmp_Payments', N'Payments', 'OBJECT' 
GO
ALTER TABLE dbo.Payments ADD CONSTRAINT
	PK_Payments PRIMARY KEY CLUSTERED 
	(
	id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
