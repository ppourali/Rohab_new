/*
   Wednesday, May 27, 20156:43:03 PM
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
COMMIT
BEGIN TRANSACTION
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
COMMIT
