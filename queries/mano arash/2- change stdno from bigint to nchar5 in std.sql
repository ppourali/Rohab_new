/*
   Sunday, May 24, 20156:20:28 PM
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
	stdno nchar(5) NOT NULL,
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
	 EXEC('INSERT INTO dbo.Tmp_std (stdno, reg_date, name, father, idno, job, degree, course, tel, mob, address, resume, birthdate, std_img)
		SELECT CONVERT(nchar(5), stdno), reg_date, name, father, idno, job, degree, course, tel, mob, address, resume, birthdate, std_img FROM dbo.std WITH (HOLDLOCK TABLOCKX)')
GO
ALTER TABLE dbo.classes
	DROP CONSTRAINT FK_classes_std
GO
ALTER TABLE dbo.hozoor
	DROP CONSTRAINT FK_hozoor_hozoor
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
CREATE TABLE dbo.Tmp_classes
	(
	classno bigint NOT NULL,
	artcourse nvarchar(30) NOT NULL,
	teacher nvarchar(50) NOT NULL,
	stdno nchar(5) NULL,
	stdname nvarchar(50) NOT NULL,
	clday nvarchar(10) NOT NULL,
	clFromTime nchar(5) NOT NULL,
	clToTime nchar(5) NOT NULL,
	method nvarchar(MAX) NULL,
	open_date nchar(10) NOT NULL,
	payan_date nchar(10) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
IF EXISTS(SELECT * FROM dbo.classes)
	 EXEC('INSERT INTO dbo.Tmp_classes (classno, artcourse, teacher, stdno, stdname, clday, clFromTime, clToTime, method, open_date, payan_date)
		SELECT classno, artcourse, teacher, CONVERT(nchar(5), stdno), stdname, clday, clFromTime, clToTime, method, open_date, payan_date FROM dbo.classes WITH (HOLDLOCK TABLOCKX)')
GO
ALTER TABLE dbo.hozoor
	DROP CONSTRAINT FK_hozoor_classes
GO
DROP TABLE dbo.classes
GO
EXECUTE sp_rename N'dbo.Tmp_classes', N'classes', 'OBJECT' 
GO
ALTER TABLE dbo.classes ADD CONSTRAINT
	PK_classes PRIMARY KEY CLUSTERED 
	(
	classno
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

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
CREATE TABLE dbo.Tmp_hozoor
	(
	stdno nchar(5) NOT NULL,
	stdname nvarchar(50) NULL,
	classno bigint NOT NULL,
	artcourse nvarchar(30) NULL,
	date nchar(10) NOT NULL,
	day nvarchar(10) NULL,
	status nchar(4) NULL
	)  ON [PRIMARY]
GO
IF EXISTS(SELECT * FROM dbo.hozoor)
	 EXEC('INSERT INTO dbo.Tmp_hozoor (stdno, stdname, classno, artcourse, date, day, status)
		SELECT CONVERT(nchar(5), stdno), stdname, classno, artcourse, date, day, status FROM dbo.hozoor WITH (HOLDLOCK TABLOCKX)')
GO
DROP TABLE dbo.hozoor
GO
EXECUTE sp_rename N'dbo.Tmp_hozoor', N'hozoor', 'OBJECT' 
GO
ALTER TABLE dbo.hozoor ADD CONSTRAINT
	PK_hozoor_1 PRIMARY KEY CLUSTERED 
	(
	stdno,
	classno,
	date
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.hozoor ADD CONSTRAINT
	FK_hozoor_classes FOREIGN KEY
	(
	classno
	) REFERENCES dbo.classes
	(
	classno
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
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
