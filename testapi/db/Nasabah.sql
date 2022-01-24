/*
 Navicat Premium Data Transfer

 Source Server         : test
 Source Server Type    : SQL Server
 Source Server Version : 15002000
 Source Host           : HP-ADI-012:1433
 Source Catalog        : TestApi
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 15002000
 File Encoding         : 65001

 Date: 24/01/2022 13:52:02
*/


-- ----------------------------
-- Table structure for __EFMigrationsHistory
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[__EFMigrationsHistory]') AND type IN ('U'))
	DROP TABLE [dbo].[__EFMigrationsHistory]
GO

CREATE TABLE [dbo].[__EFMigrationsHistory] (
  [MigrationId] nvarchar(150) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [ProductVersion] nvarchar(32) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[__EFMigrationsHistory] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of __EFMigrationsHistory
-- ----------------------------
INSERT INTO [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220124040420_test', N'6.0.1')
GO


-- ----------------------------
-- Table structure for Nasabahs
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Nasabahs]') AND type IN ('U'))
	DROP TABLE [dbo].[Nasabahs]
GO

CREATE TABLE [dbo].[Nasabahs] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [Nama] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Alamat] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [TTL] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [Tgl_Lahir] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [NoKTP] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [NoHP] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[Nasabahs] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Nasabahs
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Nasabahs] ON
GO

INSERT INTO [dbo].[Nasabahs] ([Id], [Nama], [Alamat], [TTL], [Tgl_Lahir], [NoKTP], [NoHP]) VALUES (N'1', N'budi', N'kampung duri', N'jakarta', N'01-08-1980', N'09896767867887', N'09878978768')
GO

INSERT INTO [dbo].[Nasabahs] ([Id], [Nama], [Alamat], [TTL], [Tgl_Lahir], [NoKTP], [NoHP]) VALUES (N'2', N'string', N'string', N'string', N'string', N'string', N'string')
GO

SET IDENTITY_INSERT [dbo].[Nasabahs] OFF
GO


-- ----------------------------
-- Primary Key structure for table __EFMigrationsHistory
-- ----------------------------
ALTER TABLE [dbo].[__EFMigrationsHistory] ADD CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED ([MigrationId])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for Nasabahs
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Nasabahs]', RESEED, 3)
GO


-- ----------------------------
-- Primary Key structure for table Nasabahs
-- ----------------------------
ALTER TABLE [dbo].[Nasabahs] ADD CONSTRAINT [PK_Nasabahs] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

