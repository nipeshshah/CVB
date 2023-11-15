USE [dbresumebuilder]
GO
ALTER TABLE [dbo].[TemplateSections] DROP CONSTRAINT [FK_TemplateSections_Templates]
GO
ALTER TABLE [dbo].[Skills] DROP CONSTRAINT [FK_Skills_Member]
GO
ALTER TABLE [dbo].[Sharing] DROP CONSTRAINT [FK_Sharing_Member1]
GO
ALTER TABLE [dbo].[Sharing] DROP CONSTRAINT [FK_Sharing_Member]
GO
ALTER TABLE [dbo].[ResumeSections] DROP CONSTRAINT [FK_ResumeSections_TemplateSections]
GO
ALTER TABLE [dbo].[ResumeSections] DROP CONSTRAINT [FK_ResumeSections_Resumes]
GO
ALTER TABLE [dbo].[Resumes] DROP CONSTRAINT [FK_Resumes_Templates]
GO
ALTER TABLE [dbo].[Resumes] DROP CONSTRAINT [FK_Resumes_Member]
GO
ALTER TABLE [dbo].[Referrals] DROP CONSTRAINT [FK_Referrals_Member1]
GO
ALTER TABLE [dbo].[Referrals] DROP CONSTRAINT [FK_Referrals_Member]
GO
ALTER TABLE [dbo].[PublicProfile] DROP CONSTRAINT [FK_PublicProfile_Member]
GO
ALTER TABLE [dbo].[Projects] DROP CONSTRAINT [FK_Projects_Member]
GO
ALTER TABLE [dbo].[Preference] DROP CONSTRAINT [FK_Preference_Member]
GO
ALTER TABLE [dbo].[Plan] DROP CONSTRAINT [FK_Plan_Member]
GO
ALTER TABLE [dbo].[PersonalInformation] DROP CONSTRAINT [FK_PersonalInformation_Member]
GO
ALTER TABLE [dbo].[Patents] DROP CONSTRAINT [FK_Patents_Member]
GO
ALTER TABLE [dbo].[NonCompanySharing] DROP CONSTRAINT [FK_NonCompanySharing_Resumes]
GO
ALTER TABLE [dbo].[NonCompanySharing] DROP CONSTRAINT [FK_NonCompanySharing_Member]
GO
ALTER TABLE [dbo].[Member] DROP CONSTRAINT [FK_Member_AspNetUsers]
GO
ALTER TABLE [dbo].[Languages] DROP CONSTRAINT [FK_Languages_Member1]
GO
ALTER TABLE [dbo].[Languages] DROP CONSTRAINT [FK_Languages_Member]
GO
ALTER TABLE [dbo].[Hobby] DROP CONSTRAINT [FK_Hobby_Member]
GO
ALTER TABLE [dbo].[Experience] DROP CONSTRAINT [FK_Experience_Member]
GO
ALTER TABLE [dbo].[Education] DROP CONSTRAINT [FK_Education_Member]
GO
ALTER TABLE [dbo].[Courses] DROP CONSTRAINT [FK_Courses_Member]
GO
ALTER TABLE [dbo].[Copyrights] DROP CONSTRAINT [FK_Copyrights_Member]
GO
ALTER TABLE [dbo].[CompanyDetails] DROP CONSTRAINT [FK_CompanyDetails_Member]
GO
ALTER TABLE [dbo].[Chat] DROP CONSTRAINT [FK_Chat_Member1]
GO
ALTER TABLE [dbo].[Chat] DROP CONSTRAINT [FK_Chat_Member]
GO
ALTER TABLE [dbo].[Certifications] DROP CONSTRAINT [FK_Certifications_Member]
GO
ALTER TABLE [dbo].[Awards] DROP CONSTRAINT [FK_Awards_Member]
GO
ALTER TABLE [dbo].[AspNetUserRoles] DROP CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles] DROP CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserLogins] DROP CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserClaims] DROP CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId]
GO
/****** Object:  Table [dbo].[TemplateSections]    Script Date: 15-11-2023 22:56:27 ******/
DROP TABLE [dbo].[TemplateSections]
GO
/****** Object:  Table [dbo].[Templates]    Script Date: 15-11-2023 22:56:27 ******/
DROP TABLE [dbo].[Templates]
GO
/****** Object:  Table [dbo].[Skills]    Script Date: 15-11-2023 22:56:27 ******/
DROP TABLE [dbo].[Skills]
GO
/****** Object:  Table [dbo].[Sharing]    Script Date: 15-11-2023 22:56:27 ******/
DROP TABLE [dbo].[Sharing]
GO
/****** Object:  Table [dbo].[ResumeSections]    Script Date: 15-11-2023 22:56:27 ******/
DROP TABLE [dbo].[ResumeSections]
GO
/****** Object:  Table [dbo].[Resumes]    Script Date: 15-11-2023 22:56:27 ******/
DROP TABLE [dbo].[Resumes]
GO
/****** Object:  Table [dbo].[Referrals]    Script Date: 15-11-2023 22:56:27 ******/
DROP TABLE [dbo].[Referrals]
GO
/****** Object:  Table [dbo].[PublicProfile]    Script Date: 15-11-2023 22:56:27 ******/
DROP TABLE [dbo].[PublicProfile]
GO
/****** Object:  Table [dbo].[Projects]    Script Date: 15-11-2023 22:56:27 ******/
DROP TABLE [dbo].[Projects]
GO
/****** Object:  Table [dbo].[Preference]    Script Date: 15-11-2023 22:56:27 ******/
DROP TABLE [dbo].[Preference]
GO
/****** Object:  Table [dbo].[Plan]    Script Date: 15-11-2023 22:56:27 ******/
DROP TABLE [dbo].[Plan]
GO
/****** Object:  Table [dbo].[PersonalInformation]    Script Date: 15-11-2023 22:56:27 ******/
DROP TABLE [dbo].[PersonalInformation]
GO
/****** Object:  Table [dbo].[Patents]    Script Date: 15-11-2023 22:56:27 ******/
DROP TABLE [dbo].[Patents]
GO
/****** Object:  Table [dbo].[NonCompanySharing]    Script Date: 15-11-2023 22:56:27 ******/
DROP TABLE [dbo].[NonCompanySharing]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 15-11-2023 22:56:27 ******/
DROP TABLE [dbo].[Member]
GO
/****** Object:  Table [dbo].[Languages]    Script Date: 15-11-2023 22:56:27 ******/
DROP TABLE [dbo].[Languages]
GO
/****** Object:  Table [dbo].[Hobby]    Script Date: 15-11-2023 22:56:27 ******/
DROP TABLE [dbo].[Hobby]
GO
/****** Object:  Table [dbo].[Experience]    Script Date: 15-11-2023 22:56:27 ******/
DROP TABLE [dbo].[Experience]
GO
/****** Object:  Table [dbo].[Education]    Script Date: 15-11-2023 22:56:27 ******/
DROP TABLE [dbo].[Education]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 15-11-2023 22:56:27 ******/
DROP TABLE [dbo].[Courses]
GO
/****** Object:  Table [dbo].[Copyrights]    Script Date: 15-11-2023 22:56:27 ******/
DROP TABLE [dbo].[Copyrights]
GO
/****** Object:  Table [dbo].[ContactUs]    Script Date: 15-11-2023 22:56:27 ******/
DROP TABLE [dbo].[ContactUs]
GO
/****** Object:  Table [dbo].[CompanyDetails]    Script Date: 15-11-2023 22:56:27 ******/
DROP TABLE [dbo].[CompanyDetails]
GO
/****** Object:  Table [dbo].[Chat]    Script Date: 15-11-2023 22:56:27 ******/
DROP TABLE [dbo].[Chat]
GO
/****** Object:  Table [dbo].[Certifications]    Script Date: 15-11-2023 22:56:27 ******/
DROP TABLE [dbo].[Certifications]
GO
/****** Object:  Table [dbo].[Awards]    Script Date: 15-11-2023 22:56:27 ******/
DROP TABLE [dbo].[Awards]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 15-11-2023 22:56:27 ******/
DROP TABLE [dbo].[AspNetUsers]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 15-11-2023 22:56:27 ******/
DROP TABLE [dbo].[AspNetUserRoles]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 15-11-2023 22:56:27 ******/
DROP TABLE [dbo].[AspNetUserLogins]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 15-11-2023 22:56:27 ******/
DROP TABLE [dbo].[AspNetUserClaims]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 15-11-2023 22:56:27 ******/
DROP TABLE [dbo].[AspNetRoles]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 15-11-2023 22:56:27 ******/
DROP TABLE [dbo].[__MigrationHistory]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 15-11-2023 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 15-11-2023 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 15-11-2023 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 15-11-2023 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 15-11-2023 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](128) NOT NULL,
	[RoleId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 15-11-2023 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](128) NOT NULL,
	[Email] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEndDateUtc] [datetime] NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[UserName] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Awards]    Script Date: 15-11-2023 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Awards](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [nvarchar](128) NULL,
	[AwardTitle] [nvarchar](50) NULL,
	[AwardedBy] [nvarchar](50) NULL,
	[ReceivedOn] [date] NULL,
	[AreaCompititionTitle] [nvarchar](255) NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Awards] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Certifications]    Script Date: 15-11-2023 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Certifications](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [nvarchar](128) NULL,
	[CertificateTitle] [nvarchar](100) NULL,
	[Organization] [nvarchar](100) NULL,
	[GradeRank] [nvarchar](50) NULL,
	[AreaOfExpertise] [nvarchar](100) NULL,
	[DateOfCertification] [date] NULL,
	[ValidTill] [date] NULL,
 CONSTRAINT [PK_Certifications] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Chat]    Script Date: 15-11-2023 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chat](
	[ChatId] [int] IDENTITY(1,1) NOT NULL,
	[FromUser] [nvarchar](128) NULL,
	[ToUser] [nvarchar](128) NULL,
	[MessageDateTime] [datetime] NULL,
	[Message] [nvarchar](max) NULL,
 CONSTRAINT [PK_Chat] PRIMARY KEY CLUSTERED 
(
	[ChatId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CompanyDetails]    Script Date: 15-11-2023 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompanyDetails](
	[MemberId] [nvarchar](128) NOT NULL,
	[CompanyName] [nvarchar](50) NULL,
	[CompanyAddress] [nvarchar](max) NULL,
	[CompanyWebsite] [nvarchar](150) NULL,
	[Location] [nvarchar](50) NULL,
	[ContactPerson] [nvarchar](50) NULL,
 CONSTRAINT [PK_CompanyDetails] PRIMARY KEY CLUSTERED 
(
	[MemberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ContactUs]    Script Date: 15-11-2023 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContactUs](
	[ContactUsId] [int] IDENTITY(1,1) NOT NULL,
	[RequestDate] [datetime] NULL,
	[SenderEmailId] [nvarchar](50) NULL,
	[Title] [nvarchar](255) NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_ContactUs] PRIMARY KEY CLUSTERED 
(
	[ContactUsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Copyrights]    Script Date: 15-11-2023 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Copyrights](
	[Id] [int] NOT NULL,
	[MemberId] [nvarchar](128) NULL,
	[CRTitle] [nvarchar](255) NULL,
	[CRDate] [date] NULL,
	[CRDescription] [nvarchar](max) NULL,
 CONSTRAINT [PK_Copyrights] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Courses]    Script Date: 15-11-2023 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [nvarchar](128) NULL,
	[CourseTitle] [nvarchar](100) NULL,
	[Institute] [nvarchar](100) NULL,
	[Address] [nvarchar](50) NULL,
	[Tenure] [nvarchar](100) NULL,
	[PersuedIn] [nchar](10) NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Education]    Script Date: 15-11-2023 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Education](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [nvarchar](128) NULL,
	[NameOfSchoolCollege] [nvarchar](250) NULL,
	[Qualification] [nvarchar](100) NULL,
	[Location] [nvarchar](50) NULL,
	[EducationBoard] [nvarchar](100) NULL,
	[StartDate] [date] NULL,
	[EndTime] [date] NULL,
 CONSTRAINT [PK_Education] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Experience]    Script Date: 15-11-2023 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Experience](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [nvarchar](128) NULL,
	[JobTItle] [nvarchar](50) NULL,
	[Employer] [nvarchar](max) NULL,
	[CIty] [nvarchar](50) NULL,
	[State] [nvarchar](50) NULL,
	[Country] [nvarchar](50) NULL,
	[StartDate] [date] NULL,
	[EndTime] [date] NULL,
	[IsCurrent] [int] NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Experience] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hobby]    Script Date: 15-11-2023 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hobby](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [nvarchar](128) NULL,
	[Hobby] [nvarchar](50) NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Hobby] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Languages]    Script Date: 15-11-2023 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Languages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [nvarchar](128) NULL,
	[Language] [nvarchar](50) NULL,
	[ReadProficiency] [int] NULL,
	[WriteProficiency] [int] NULL,
	[SpeakProficiency] [int] NULL,
	[IsNative] [int] NULL,
 CONSTRAINT [PK_Languages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Member]    Script Date: 15-11-2023 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[GoogleId] [nvarchar](128) NULL,
	[MemberId] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[ReferralCode] [nvarchar](10) NULL,
	[RegistrationDate] [datetime] NULL,
	[RegistrationType] [int] NULL,
	[PublicUrl] [nvarchar](50) NULL,
 CONSTRAINT [PK_Member] PRIMARY KEY CLUSTERED 
(
	[MemberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NonCompanySharing]    Script Date: 15-11-2023 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NonCompanySharing](
	[ShareindId] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [nvarchar](128) NULL,
	[SharedEmail] [nvarchar](50) NULL,
	[ResumeId] [int] NULL,
	[SharedOn] [datetime] NULL,
 CONSTRAINT [PK_NonCompanySharing] PRIMARY KEY CLUSTERED 
(
	[ShareindId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Patents]    Script Date: 15-11-2023 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patents](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [nvarchar](128) NULL,
	[PatentTitle] [nvarchar](255) NULL,
	[PatentDate] [date] NULL,
	[PatentDescription] [nvarchar](max) NULL,
 CONSTRAINT [PK_Patents] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PersonalInformation]    Script Date: 15-11-2023 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonalInformation](
	[PersonalInfoId] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [nvarchar](128) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[MiddleName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[PreferredName] [nvarchar](50) NULL,
	[City] [nvarchar](50) NULL,
	[Country] [nvarchar](50) NULL,
	[Pincode] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[State] [nvarchar](50) NULL,
 CONSTRAINT [PK_PersonalInformation] PRIMARY KEY CLUSTERED 
(
	[PersonalInfoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Plan]    Script Date: 15-11-2023 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Plan](
	[PlanId] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [nvarchar](128) NULL,
	[GoogleId] [nvarchar](128) NULL,
	[RegisteredEmail] [nvarchar](50) NULL,
	[SubscribedPlan] [int] NULL,
	[FromDate] [datetime] NULL,
	[ToDate] [datetime] NULL,
	[PaymentDate] [datetime] NULL,
	[PaymentMode] [nvarchar](50) NULL,
	[PaymentAmount] [decimal](18, 2) NULL,
	[Comments] [nvarchar](50) NULL,
 CONSTRAINT [PK_Plan] PRIMARY KEY CLUSTERED 
(
	[PlanId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Preference]    Script Date: 15-11-2023 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Preference](
	[MemberId] [nvarchar](128) NOT NULL,
	[IsLookingForJob] [int] NULL,
	[PreferredSkills] [nvarchar](max) NULL,
	[PreferredLocation] [nvarchar](max) NULL,
	[PreferredDesignation] [nvarchar](max) NULL,
	[CurrentLocation] [nvarchar](50) NULL,
	[IsReadyToReallocate] [int] NULL,
 CONSTRAINT [PK_Preference] PRIMARY KEY CLUSTERED 
(
	[MemberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Projects]    Script Date: 15-11-2023 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Projects](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [nvarchar](128) NULL,
	[ProjectTitle] [nvarchar](100) NULL,
	[Technologies] [nvarchar](255) NULL,
	[Tools] [nvarchar](255) NULL,
	[Ownerr] [nvarchar](255) NULL,
	[Role] [nvarchar](100) NULL,
	[TeamSIze] [nvarchar](100) NULL,
	[ShortDescription] [nvarchar](255) NULL,
	[LongDescription] [nvarchar](max) NULL,
 CONSTRAINT [PK_Projects] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PublicProfile]    Script Date: 15-11-2023 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PublicProfile](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [nvarchar](128) NULL,
	[Title] [nvarchar](100) NULL,
	[Link] [nvarchar](max) NULL,
 CONSTRAINT [PK_PublicProfile] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Referrals]    Script Date: 15-11-2023 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Referrals](
	[ReferralId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](128) NULL,
	[ReferredByUserId] [nvarchar](128) NULL,
 CONSTRAINT [PK_Referrals] PRIMARY KEY CLUSTERED 
(
	[ReferralId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Resumes]    Script Date: 15-11-2023 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Resumes](
	[ResumeId] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [nvarchar](128) NULL,
	[Title] [nvarchar](255) NULL,
	[CreatedOn] [datetime] NULL,
	[DownloadCount] [int] NULL,
	[ViewCount] [int] NULL,
	[PublicUrl] [nvarchar](50) NULL,
	[SecurityCode] [nvarchar](25) NULL,
	[PublicSharingType] [int] NULL,
	[IsDeleted] [bit] NULL,
	[TemplateId] [int] NULL,
 CONSTRAINT [PK_Resumes] PRIMARY KEY CLUSTERED 
(
	[ResumeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ResumeSections]    Script Date: 15-11-2023 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ResumeSections](
	[ResumeSectionId] [int] IDENTITY(1,1) NOT NULL,
	[ResumeId] [int] NULL,
	[SectionId] [int] NULL,
	[IsSelected] [bit] NULL,
	[SectionOrder] [int] NULL,
 CONSTRAINT [PK_ResumeSections] PRIMARY KEY CLUSTERED 
(
	[ResumeSectionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sharing]    Script Date: 15-11-2023 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sharing](
	[SharingId] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [nvarchar](128) NULL,
	[CompanyMemberId] [nvarchar](128) NULL,
	[ResumeId] [int] NULL,
	[SharedOn] [datetime] NULL,
	[Status] [nvarchar](50) NULL,
	[RevokedOn] [datetime] NULL,
 CONSTRAINT [PK_Sharing] PRIMARY KEY CLUSTERED 
(
	[SharingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Skills]    Script Date: 15-11-2023 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Skills](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [nvarchar](128) NULL,
	[Skill] [nvarchar](50) NULL,
	[Proficiency] [int] NULL,
	[Certifications] [nvarchar](255) NULL,
 CONSTRAINT [PK_Skills] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Templates]    Script Date: 15-11-2023 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Templates](
	[TemplateId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NULL,
	[TemplateHtmlUrl] [nvarchar](max) NULL,
	[PreviewImageUrl] [nvarchar](max) NULL,
 CONSTRAINT [PK_Templates] PRIMARY KEY CLUSTERED 
(
	[TemplateId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TemplateSections]    Script Date: 15-11-2023 22:56:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TemplateSections](
	[SectionId] [int] IDENTITY(1,1) NOT NULL,
	[AllowReorder] [bit] NULL,
	[AllowSelection] [bit] NULL,
	[TemplateId] [int] NULL,
	[SectionName] [nvarchar](50) NULL,
 CONSTRAINT [PK_TemplateSections] PRIMARY KEY CLUSTERED 
(
	[SectionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Awards]  WITH CHECK ADD  CONSTRAINT [FK_Awards_Member] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([MemberId])
GO
ALTER TABLE [dbo].[Awards] CHECK CONSTRAINT [FK_Awards_Member]
GO
ALTER TABLE [dbo].[Certifications]  WITH CHECK ADD  CONSTRAINT [FK_Certifications_Member] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([MemberId])
GO
ALTER TABLE [dbo].[Certifications] CHECK CONSTRAINT [FK_Certifications_Member]
GO
ALTER TABLE [dbo].[Chat]  WITH CHECK ADD  CONSTRAINT [FK_Chat_Member] FOREIGN KEY([FromUser])
REFERENCES [dbo].[Member] ([MemberId])
GO
ALTER TABLE [dbo].[Chat] CHECK CONSTRAINT [FK_Chat_Member]
GO
ALTER TABLE [dbo].[Chat]  WITH CHECK ADD  CONSTRAINT [FK_Chat_Member1] FOREIGN KEY([ToUser])
REFERENCES [dbo].[Member] ([MemberId])
GO
ALTER TABLE [dbo].[Chat] CHECK CONSTRAINT [FK_Chat_Member1]
GO
ALTER TABLE [dbo].[CompanyDetails]  WITH CHECK ADD  CONSTRAINT [FK_CompanyDetails_Member] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([MemberId])
GO
ALTER TABLE [dbo].[CompanyDetails] CHECK CONSTRAINT [FK_CompanyDetails_Member]
GO
ALTER TABLE [dbo].[Copyrights]  WITH CHECK ADD  CONSTRAINT [FK_Copyrights_Member] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([MemberId])
GO
ALTER TABLE [dbo].[Copyrights] CHECK CONSTRAINT [FK_Copyrights_Member]
GO
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Member] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([MemberId])
GO
ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_Member]
GO
ALTER TABLE [dbo].[Education]  WITH CHECK ADD  CONSTRAINT [FK_Education_Member] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([MemberId])
GO
ALTER TABLE [dbo].[Education] CHECK CONSTRAINT [FK_Education_Member]
GO
ALTER TABLE [dbo].[Experience]  WITH CHECK ADD  CONSTRAINT [FK_Experience_Member] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([MemberId])
GO
ALTER TABLE [dbo].[Experience] CHECK CONSTRAINT [FK_Experience_Member]
GO
ALTER TABLE [dbo].[Hobby]  WITH CHECK ADD  CONSTRAINT [FK_Hobby_Member] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([MemberId])
GO
ALTER TABLE [dbo].[Hobby] CHECK CONSTRAINT [FK_Hobby_Member]
GO
ALTER TABLE [dbo].[Languages]  WITH CHECK ADD  CONSTRAINT [FK_Languages_Member] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([MemberId])
GO
ALTER TABLE [dbo].[Languages] CHECK CONSTRAINT [FK_Languages_Member]
GO
ALTER TABLE [dbo].[Languages]  WITH CHECK ADD  CONSTRAINT [FK_Languages_Member1] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([MemberId])
GO
ALTER TABLE [dbo].[Languages] CHECK CONSTRAINT [FK_Languages_Member1]
GO
ALTER TABLE [dbo].[Member]  WITH CHECK ADD  CONSTRAINT [FK_Member_AspNetUsers] FOREIGN KEY([GoogleId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Member] CHECK CONSTRAINT [FK_Member_AspNetUsers]
GO
ALTER TABLE [dbo].[NonCompanySharing]  WITH CHECK ADD  CONSTRAINT [FK_NonCompanySharing_Member] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([MemberId])
GO
ALTER TABLE [dbo].[NonCompanySharing] CHECK CONSTRAINT [FK_NonCompanySharing_Member]
GO
ALTER TABLE [dbo].[NonCompanySharing]  WITH CHECK ADD  CONSTRAINT [FK_NonCompanySharing_Resumes] FOREIGN KEY([ResumeId])
REFERENCES [dbo].[Resumes] ([ResumeId])
GO
ALTER TABLE [dbo].[NonCompanySharing] CHECK CONSTRAINT [FK_NonCompanySharing_Resumes]
GO
ALTER TABLE [dbo].[Patents]  WITH CHECK ADD  CONSTRAINT [FK_Patents_Member] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([MemberId])
GO
ALTER TABLE [dbo].[Patents] CHECK CONSTRAINT [FK_Patents_Member]
GO
ALTER TABLE [dbo].[PersonalInformation]  WITH CHECK ADD  CONSTRAINT [FK_PersonalInformation_Member] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([MemberId])
GO
ALTER TABLE [dbo].[PersonalInformation] CHECK CONSTRAINT [FK_PersonalInformation_Member]
GO
ALTER TABLE [dbo].[Plan]  WITH CHECK ADD  CONSTRAINT [FK_Plan_Member] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([MemberId])
GO
ALTER TABLE [dbo].[Plan] CHECK CONSTRAINT [FK_Plan_Member]
GO
ALTER TABLE [dbo].[Preference]  WITH CHECK ADD  CONSTRAINT [FK_Preference_Member] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([MemberId])
GO
ALTER TABLE [dbo].[Preference] CHECK CONSTRAINT [FK_Preference_Member]
GO
ALTER TABLE [dbo].[Projects]  WITH CHECK ADD  CONSTRAINT [FK_Projects_Member] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([MemberId])
GO
ALTER TABLE [dbo].[Projects] CHECK CONSTRAINT [FK_Projects_Member]
GO
ALTER TABLE [dbo].[PublicProfile]  WITH CHECK ADD  CONSTRAINT [FK_PublicProfile_Member] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([MemberId])
GO
ALTER TABLE [dbo].[PublicProfile] CHECK CONSTRAINT [FK_PublicProfile_Member]
GO
ALTER TABLE [dbo].[Referrals]  WITH CHECK ADD  CONSTRAINT [FK_Referrals_Member] FOREIGN KEY([UserId])
REFERENCES [dbo].[Member] ([MemberId])
GO
ALTER TABLE [dbo].[Referrals] CHECK CONSTRAINT [FK_Referrals_Member]
GO
ALTER TABLE [dbo].[Referrals]  WITH CHECK ADD  CONSTRAINT [FK_Referrals_Member1] FOREIGN KEY([ReferredByUserId])
REFERENCES [dbo].[Member] ([MemberId])
GO
ALTER TABLE [dbo].[Referrals] CHECK CONSTRAINT [FK_Referrals_Member1]
GO
ALTER TABLE [dbo].[Resumes]  WITH CHECK ADD  CONSTRAINT [FK_Resumes_Member] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([MemberId])
GO
ALTER TABLE [dbo].[Resumes] CHECK CONSTRAINT [FK_Resumes_Member]
GO
ALTER TABLE [dbo].[Resumes]  WITH CHECK ADD  CONSTRAINT [FK_Resumes_Templates] FOREIGN KEY([TemplateId])
REFERENCES [dbo].[Templates] ([TemplateId])
GO
ALTER TABLE [dbo].[Resumes] CHECK CONSTRAINT [FK_Resumes_Templates]
GO
ALTER TABLE [dbo].[ResumeSections]  WITH CHECK ADD  CONSTRAINT [FK_ResumeSections_Resumes] FOREIGN KEY([ResumeId])
REFERENCES [dbo].[Resumes] ([ResumeId])
GO
ALTER TABLE [dbo].[ResumeSections] CHECK CONSTRAINT [FK_ResumeSections_Resumes]
GO
ALTER TABLE [dbo].[ResumeSections]  WITH CHECK ADD  CONSTRAINT [FK_ResumeSections_TemplateSections] FOREIGN KEY([SectionId])
REFERENCES [dbo].[TemplateSections] ([SectionId])
GO
ALTER TABLE [dbo].[ResumeSections] CHECK CONSTRAINT [FK_ResumeSections_TemplateSections]
GO
ALTER TABLE [dbo].[Sharing]  WITH CHECK ADD  CONSTRAINT [FK_Sharing_Member] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([MemberId])
GO
ALTER TABLE [dbo].[Sharing] CHECK CONSTRAINT [FK_Sharing_Member]
GO
ALTER TABLE [dbo].[Sharing]  WITH CHECK ADD  CONSTRAINT [FK_Sharing_Member1] FOREIGN KEY([CompanyMemberId])
REFERENCES [dbo].[Member] ([MemberId])
GO
ALTER TABLE [dbo].[Sharing] CHECK CONSTRAINT [FK_Sharing_Member1]
GO
ALTER TABLE [dbo].[Skills]  WITH CHECK ADD  CONSTRAINT [FK_Skills_Member] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([MemberId])
GO
ALTER TABLE [dbo].[Skills] CHECK CONSTRAINT [FK_Skills_Member]
GO
ALTER TABLE [dbo].[TemplateSections]  WITH CHECK ADD  CONSTRAINT [FK_TemplateSections_Templates] FOREIGN KEY([TemplateId])
REFERENCES [dbo].[Templates] ([TemplateId])
GO
ALTER TABLE [dbo].[TemplateSections] CHECK CONSTRAINT [FK_TemplateSections_Templates]
GO
