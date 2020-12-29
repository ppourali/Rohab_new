/*
   Monday, May 25, 201511:34:39 PM
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
ALTER TABLE dbo.ghabz
	DROP CONSTRAINT FK_ghabz_std
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_ghabz
	(
	id nchar(5) NOT NULL,
	stdno nchar(5) NULL,
	name nvarchar(50) NOT NULL,
	artcourse nvarchar(30) NOT NULL,
	date nchar(10) NOT NULL,
	lastdate nchar(10) NOT NULL,
	lastcheck nvarchar(8) NULL,
	mablagh bigint NOT NULL,
	paid bigint NOT NULL,
	sharh nvarchar(100) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_ghabz ADD CONSTRAINT
	DF_ghabz_paid_1 DEFAULT ((0)) FOR paid
GO
IF EXISTS(SELECT * FROM dbo.ghabz)
	 EXEC('INSERT INTO dbo.Tmp_ghabz (id, stdno, name, artcourse, date, lastdate, lastcheck, mablagh, sharh)
		SELECT id, stdno, name, artcourse, date, lastdate, lastcheck, mablagh, sharh FROM dbo.ghabz WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.ghabz
GO
EXECUTE sp_rename N'dbo.Tmp_ghabz', N'ghabz', 'OBJECT' 
GO
ALTER TABLE dbo.ghabz ADD CONSTRAINT
	PK_mali PRIMARY KEY CLUSTERED 
	(
	id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.ghabz WITH NOCHECK ADD CONSTRAINT
	FK_ghabz_std FOREIGN KEY
	(
	stdno
	) REFERENCES dbo.std
	(
	stdno
	) ON UPDATE  CASCADE 
	 ON DELETE  NO ACTION 
	 NOT FOR REPLICATION

GO
ALTER TABLE dbo.ghabz
	NOCHECK CONSTRAINT FK_ghabz_std
GO
COMMIT
