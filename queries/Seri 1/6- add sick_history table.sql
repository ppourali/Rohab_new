/*
   Monday, May 25, 20158:43:44 PM
   User: 
   Server: PARSA-PC\SQLEXPRESS
   Database: M_A_DB
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
use M_A_DB
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
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.std_history
	(
	radif bigint NOT NULL,
	ghabz_id nchar(6) NULL,
	stdno nchar(5) NOT NULL,
	sharh nvarchar(200) NULL,
	date nchar(10) NULL,
	bedehkari bigint NULL,
	bestankari bigint NULL,
	tashkhis nvarchar(8) NULL,
	mandeh bigint NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.std_history ADD CONSTRAINT
	DF_std_history_radif DEFAULT ((0)) FOR radif
GO
ALTER TABLE dbo.std_history ADD CONSTRAINT
	DF_std_history_bedehkari DEFAULT ((0)) FOR bedehkari
GO
ALTER TABLE dbo.std_history ADD CONSTRAINT
	DF_std_history_bestankari DEFAULT ((0)) FOR bestankari
GO
ALTER TABLE dbo.std_history ADD CONSTRAINT
	DF_std_history_mandeh DEFAULT ((0)) FOR mandeh
GO
ALTER TABLE dbo.std_history ADD CONSTRAINT
	PK_std_history PRIMARY KEY CLUSTERED 
	(
	radif,
	stdno
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.std_history ADD CONSTRAINT
	FK_std_history_std FOREIGN KEY
	(
	stdno
	) REFERENCES dbo.std
	(
	stdno
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
