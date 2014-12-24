SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;

if not exists (SELECT [name]FROM master.dbo.sysdatabases where name = 'zadania')
create database [zadania];

use [zadania];

if not exists (select * from sysobjects where name='users' and xtype='U')
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[login] [nvarchar](255) NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[surname] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

if not exists (select * from sysobjects where name='checks' and xtype='U')
CREATE TABLE [dbo].[checks](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[task_id] [int] NOT NULL,	
	[name] [nvarchar](255) NOT NULL,
	[is_checked] [bit] NOT NULL
 CONSTRAINT [PK_checks] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

if not exists (select * from sysobjects where name='files' and xtype='U')
CREATE TABLE [dbo].[files](
	[id] [int] IDENTITY(1,1) NOT NULL,	
	[name] [nvarchar](255) NOT NULL,
	[ext] [nvarchar](5) NOT NULL,
	[file] [varbinary](max) NOT NULL,
	[task_id] [int] NOT NULL
 CONSTRAINT [PK_files] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];


if not exists (select * from sysobjects where name='tasks' and xtype='U')
CREATE TABLE [dbo].[tasks](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[category_id] [int] NOT NULL,
	[task_name] [nvarchar](max) NOT NULL,
	[task_description] [nvarchar](max) NOT NULL,
	[creator_id] [int] NOT NULL,
	[creation_date] [datetime] NOT NULL,
	[assigned_to_user_id] [int] NOT NULL,
	[assign_date] [datetime] NOT NULL,
	[start_date] [datetime] NOT NULL,
	[stop_date] [datetime] NOT NULL,
	[time_spent] [float] NOT NULL,
	[status] [int] NOT NULL,
	[expected_end_date] [datetime] NOT NULL,
 CONSTRAINT [PK_tasks] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

if not exists (select * from sysobjects where name='status_list' and xtype='U')
CREATE TABLE [dbo].[status_list](
	[status] [nvarchar](max) NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_status_list] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];

if not exists (select * from sysobjects where name='categories' and xtype='U')
CREATE TABLE [dbo].[categories](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_categories] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY];
