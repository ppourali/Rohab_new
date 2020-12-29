/*
   Sunday, May 24, 20155:40:57 PM
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
CREATE TABLE dbo.Tmp_std
	(
	stdno bigint NOT NULL,
	reg_date nchar(10) NULL,
	name nvarchar(50) NOT NULL,
	father nvarchar(50) NULL,
	idno nvarchar(11) NULL,
	job nvarchar(30) NULL,
	degree nvarchar(50) NULL,
	course nvarchar(50) NULL,
	tel nvarchar(35) NULL,
	mob nvarchar(35) NULL,
	address nvarchar(250) NULL,
	resume nvarchar(100) NULL,
	birthdate nvarchar(50) NULL,
	std_img image NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
IF EXISTS(SELECT * FROM dbo.std)
	 EXEC('INSERT INTO dbo.Tmp_std (stdno, reg_date, name, father, idno, job, degree, course, tel, mob, address, resume, std_img)
		SELECT stdno, reg_date, name, father, idno, job, degree, course, tel, mob, address, resume, std_img FROM dbo.std WITH (HOLDLOCK TABLOCKX)')
GO
ALTER TABLE dbo.hozoor
	DROP CONSTRAINT FK_hozoor_hozoor
GO
ALTER TABLE dbo.classes
	DROP CONSTRAINT FK_classes_std
GO
DROP TABLE dbo.std
GO
EXECUTE sp_rename N'dbo.Tmp_std', N'std', 'OBJECT' 
GO
ALTER TABLE dbo.std ADD CONSTRAINT
	PK_std PRIMARY KEY CLUSTERED 
	(
	stdno
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.classes ADD CONSTRAINT
	FK_classes_std FOREIGN KEY
	(
	stdno
	) REFERENCES dbo.std
	(
	stdno
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.hozoor ADD CONSTRAINT
	FK_hozoor_hozoor FOREIGN KEY
	(
	stdno
	) REFERENCES dbo.std
	(
	stdno
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT
