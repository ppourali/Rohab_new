/*
   Monday, May 25, 20159:48:25 PM
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
ALTER TABLE dbo.std_history
	DROP CONSTRAINT FK_std_history_std
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.std_history ADD CONSTRAINT
	FK_std_history_std FOREIGN KEY
	(
	stdno
	) REFERENCES dbo.std
	(
	stdno
	) ON UPDATE  CASCADE 
	 ON DELETE  CASCADE 
	
GO
COMMIT
