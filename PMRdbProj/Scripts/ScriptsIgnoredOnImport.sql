
USE [dbPMR]
GO

ALTER TABLE [dbo].[tblTests] DROP CONSTRAINT [FK_tblTests_tblUsers]
GO

ALTER TABLE [dbo].[tblTests] DROP CONSTRAINT [FK_tblTests_tblSelectTestTypes]
GO

ALTER TABLE [dbo].[tblTests] DROP CONSTRAINT [FK_tblTests_tblSelectMedicalConditions]
GO

ALTER TABLE [dbo].[tblTests] DROP CONSTRAINT [FK_tblTests_tblSelectFacilities]
GO

ALTER TABLE [dbo].[tblTests] DROP CONSTRAINT [FK_tblTests_tblSelectDoctors]
GO

ALTER TABLE [dbo].[tblSurgeries] DROP CONSTRAINT [FK_tblSurgeries_tblUsers]
GO

ALTER TABLE [dbo].[tblSurgeries] DROP CONSTRAINT [FK_tblSurgeries_tblSelectMedicalConditions]
GO

ALTER TABLE [dbo].[tblSurgeries] DROP CONSTRAINT [FK_tblSurgeries_tblSelectFacilities]
GO

ALTER TABLE [dbo].[tblSurgeries] DROP CONSTRAINT [FK_tblSurgeries_tblSelectDoctors]
GO

ALTER TABLE [dbo].[tblSelectVaccineNames] DROP CONSTRAINT [FK_tblSelectVaccineNames_tblSelectVaccineGroupNames]
GO

ALTER TABLE [dbo].[tblSelectMedications] DROP CONSTRAINT [FK_tblSelectMedications_tblSelectManufacturers]
GO

ALTER TABLE [dbo].[tblSelectBloodworkIndiNames] DROP CONSTRAINT [FK_tblSelectBloodworkIndiNames_tblSelectBloodworkGroupNames]
GO

ALTER TABLE [dbo].[tblMedicationLists] DROP CONSTRAINT [FK_tblMedicationLists_tblUsers]
GO

ALTER TABLE [dbo].[tblMedicationLists] DROP CONSTRAINT [FK_tblMedicationLists_tblSelectMedications]
GO

ALTER TABLE [dbo].[tblMedicationLists] DROP CONSTRAINT [FK_tblMedicationLists_tblSelectMedicalConditions]
GO

ALTER TABLE [dbo].[tblMedicationLists] DROP CONSTRAINT [FK_tblMedicationLists_tblSelectFacilities]
GO

ALTER TABLE [dbo].[tblMedicationLists] DROP CONSTRAINT [FK_tblMedicationLists_tblSelectDoctors]
GO

ALTER TABLE [dbo].[tblImmunizationDetails] DROP CONSTRAINT [FK_tblImmunizationDetails_tblUsers]
GO

ALTER TABLE [dbo].[tblImmunizationDetails] DROP CONSTRAINT [FK_tblImmunizationDetails_tblSelectVaccineNames]
GO

ALTER TABLE [dbo].[tblImmunizationDetails] DROP CONSTRAINT [FK_tblImmunizationDetails_tblSelectManufacturers]
GO

ALTER TABLE [dbo].[tblImmunizationDetails] DROP CONSTRAINT [FK_tblImmunizationDetails_tblSelectFacilities]
GO

ALTER TABLE [dbo].[tblHospitalizations] DROP CONSTRAINT [FK_tblHospitalizations_tblUsers]
GO

ALTER TABLE [dbo].[tblHospitalizations] DROP CONSTRAINT [FK_tblHospitalizations_tblSelectMedicalConditions]
GO

ALTER TABLE [dbo].[tblHospitalizations] DROP CONSTRAINT [FK_tblHospitalizations_tblSelectFacilities]
GO

ALTER TABLE [dbo].[tblHospitalizations] DROP CONSTRAINT [FK_tblHospitalizations_tblSelectDoctors]
GO

ALTER TABLE [dbo].[tblFamilyMemberMedicalConditions] DROP CONSTRAINT [FK_tblFamilyMemberMedicalConditions_tblSelectMedicalConditions]
GO

ALTER TABLE [dbo].[tblFamilyMemberMedicalConditions] DROP CONSTRAINT [FK_tblFamilyMemberMedicalConditions_tblFamilyMembers]
GO

ALTER TABLE [dbo].[tblFamilyHistories] DROP CONSTRAINT [FK_tblFamilyHistories_tblUsers]
GO

ALTER TABLE [dbo].[tblFamilyHistories] DROP CONSTRAINT [FK_tblFamilyHistories_tblFamilyMembers]
GO

ALTER TABLE [dbo].[tblDoctorVisits] DROP CONSTRAINT [FK_tblDoctorVisits_tblUsers]
GO

ALTER TABLE [dbo].[tblDoctorVisits] DROP CONSTRAINT [FK_tblDoctorVisits_tblSelectMedicalConditions]
GO

ALTER TABLE [dbo].[tblDoctorVisits] DROP CONSTRAINT [FK_tblDoctorVisits_tblSelectDoctors]
GO

ALTER TABLE [dbo].[tblBloodwork] DROP CONSTRAINT [FK_tblBloodwork_tblUsers]
GO

ALTER TABLE [dbo].[tblBloodwork] DROP CONSTRAINT [FK_tblBloodwork_tblSelectFacilities]
GO

ALTER TABLE [dbo].[tblBloodwork] DROP CONSTRAINT [FK_tblBloodwork_tblSelectDoctors]
GO

ALTER TABLE [dbo].[tblBloodwork] DROP CONSTRAINT [FK_tblBloodwork_tblSelectBloodworkIndiNames]
GO

/****** Object:  Table [dbo].[tblUsers]    Script Date: 4/3/2025 9:26:26 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblUsers]') AND type in (N'U'))
DROP TABLE [dbo].[tblUsers]
GO

/****** Object:  Table [dbo].[tblTests]    Script Date: 4/3/2025 9:26:26 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblTests]') AND type in (N'U'))
DROP TABLE [dbo].[tblTests]
GO

/****** Object:  Table [dbo].[tblSurgeries]    Script Date: 4/3/2025 9:26:26 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblSurgeries]') AND type in (N'U'))
DROP TABLE [dbo].[tblSurgeries]
GO

/****** Object:  Table [dbo].[tblSelectVaccineNames]    Script Date: 4/3/2025 9:26:26 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblSelectVaccineNames]') AND type in (N'U'))
DROP TABLE [dbo].[tblSelectVaccineNames]
GO

/****** Object:  Table [dbo].[tblSelectVaccineGroupNames]    Script Date: 4/3/2025 9:26:26 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblSelectVaccineGroupNames]') AND type in (N'U'))
DROP TABLE [dbo].[tblSelectVaccineGroupNames]
GO

/****** Object:  Table [dbo].[tblSelectTestTypes]    Script Date: 4/3/2025 9:26:26 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblSelectTestTypes]') AND type in (N'U'))
DROP TABLE [dbo].[tblSelectTestTypes]
GO

/****** Object:  Table [dbo].[tblSelectMedications]    Script Date: 4/3/2025 9:26:26 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblSelectMedications]') AND type in (N'U'))
DROP TABLE [dbo].[tblSelectMedications]
GO

/****** Object:  Table [dbo].[tblSelectMedicalConditions]    Script Date: 4/3/2025 9:26:26 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblSelectMedicalConditions]') AND type in (N'U'))
DROP TABLE [dbo].[tblSelectMedicalConditions]
GO

/****** Object:  Table [dbo].[tblSelectManufacturers]    Script Date: 4/3/2025 9:26:26 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblSelectManufacturers]') AND type in (N'U'))
DROP TABLE [dbo].[tblSelectManufacturers]
GO

/****** Object:  Table [dbo].[tblSelectFacilities]    Script Date: 4/3/2025 9:26:26 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblSelectFacilities]') AND type in (N'U'))
DROP TABLE [dbo].[tblSelectFacilities]
GO

/****** Object:  Table [dbo].[tblSelectDoctors]    Script Date: 4/3/2025 9:26:26 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblSelectDoctors]') AND type in (N'U'))
DROP TABLE [dbo].[tblSelectDoctors]
GO

/****** Object:  Table [dbo].[tblSelectBloodworkIndiNames]    Script Date: 4/3/2025 9:26:26 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblSelectBloodworkIndiNames]') AND type in (N'U'))
DROP TABLE [dbo].[tblSelectBloodworkIndiNames]
GO

/****** Object:  Table [dbo].[tblSelectBloodworkGroupNames]    Script Date: 4/3/2025 9:26:26 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblSelectBloodworkGroupNames]') AND type in (N'U'))
DROP TABLE [dbo].[tblSelectBloodworkGroupNames]
GO

/****** Object:  Table [dbo].[tblMedicationLists]    Script Date: 4/3/2025 9:26:26 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblMedicationLists]') AND type in (N'U'))
DROP TABLE [dbo].[tblMedicationLists]
GO

/****** Object:  Table [dbo].[tblImmunizationDetails]    Script Date: 4/3/2025 9:26:26 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblImmunizationDetails]') AND type in (N'U'))
DROP TABLE [dbo].[tblImmunizationDetails]
GO

/****** Object:  Table [dbo].[tblHospitalizations]    Script Date: 4/3/2025 9:26:26 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblHospitalizations]') AND type in (N'U'))
DROP TABLE [dbo].[tblHospitalizations]
GO

/****** Object:  Table [dbo].[tblFamilyMembers]    Script Date: 4/3/2025 9:26:26 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblFamilyMembers]') AND type in (N'U'))
DROP TABLE [dbo].[tblFamilyMembers]
GO

/****** Object:  Table [dbo].[tblFamilyMemberMedicalConditions]    Script Date: 4/3/2025 9:26:26 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblFamilyMemberMedicalConditions]') AND type in (N'U'))
DROP TABLE [dbo].[tblFamilyMemberMedicalConditions]
GO

/****** Object:  Table [dbo].[tblFamilyHistories]    Script Date: 4/3/2025 9:26:26 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblFamilyHistories]') AND type in (N'U'))
DROP TABLE [dbo].[tblFamilyHistories]
GO

/****** Object:  Table [dbo].[tblDoctorVisits]    Script Date: 4/3/2025 9:26:26 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblDoctorVisits]') AND type in (N'U'))
DROP TABLE [dbo].[tblDoctorVisits]
GO

/****** Object:  Table [dbo].[tblBloodwork]    Script Date: 4/3/2025 9:26:26 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblBloodwork]') AND type in (N'U'))
DROP TABLE [dbo].[tblBloodwork]
GO

USE [master]
GO

/****** Object:  Database [dbPMR]    Script Date: 4/3/2025 9:26:26 AM ******/
DROP DATABASE [dbPMR]
GO

/****** Object:  Database [dbPMR]    Script Date: 4/3/2025 9:26:26 AM ******/
CREATE DATABASE [dbPMR]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbPMR', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\dbPMR.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dbPMR_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\dbPMR.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbPMR].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [dbPMR] SET ANSI_NULL_DEFAULT ON
GO

ALTER DATABASE [dbPMR] SET ANSI_NULLS ON
GO

ALTER DATABASE [dbPMR] SET ANSI_PADDING ON
GO

ALTER DATABASE [dbPMR] SET ANSI_WARNINGS ON
GO

ALTER DATABASE [dbPMR] SET ARITHABORT ON
GO

ALTER DATABASE [dbPMR] SET AUTO_CLOSE OFF
GO

ALTER DATABASE [dbPMR] SET AUTO_SHRINK OFF
GO

ALTER DATABASE [dbPMR] SET AUTO_UPDATE_STATISTICS ON
GO

ALTER DATABASE [dbPMR] SET CURSOR_CLOSE_ON_COMMIT OFF
GO

ALTER DATABASE [dbPMR] SET CURSOR_DEFAULT  LOCAL
GO

ALTER DATABASE [dbPMR] SET CONCAT_NULL_YIELDS_NULL ON
GO

ALTER DATABASE [dbPMR] SET NUMERIC_ROUNDABORT OFF
GO

ALTER DATABASE [dbPMR] SET QUOTED_IDENTIFIER ON
GO

ALTER DATABASE [dbPMR] SET RECURSIVE_TRIGGERS OFF
GO

ALTER DATABASE [dbPMR] SET  DISABLE_BROKER
GO

ALTER DATABASE [dbPMR] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO

ALTER DATABASE [dbPMR] SET DATE_CORRELATION_OPTIMIZATION OFF
GO

ALTER DATABASE [dbPMR] SET TRUSTWORTHY OFF
GO

ALTER DATABASE [dbPMR] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO

ALTER DATABASE [dbPMR] SET PARAMETERIZATION SIMPLE
GO

ALTER DATABASE [dbPMR] SET READ_COMMITTED_SNAPSHOT OFF
GO

ALTER DATABASE [dbPMR] SET HONOR_BROKER_PRIORITY OFF
GO

ALTER DATABASE [dbPMR] SET RECOVERY FULL
GO

ALTER DATABASE [dbPMR] SET  MULTI_USER
GO

ALTER DATABASE [dbPMR] SET PAGE_VERIFY NONE
GO

ALTER DATABASE [dbPMR] SET DB_CHAINING OFF
GO

ALTER DATABASE [dbPMR] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF )
GO

ALTER DATABASE [dbPMR] SET TARGET_RECOVERY_TIME = 0 SECONDS
GO

ALTER DATABASE [dbPMR] SET DELAYED_DURABILITY = DISABLED
GO

ALTER DATABASE [dbPMR] SET ACCELERATED_DATABASE_RECOVERY = OFF
GO

ALTER DATABASE [dbPMR] SET QUERY_STORE = OFF
GO

USE [dbPMR]
GO

/****** Object:  Table [dbo].[tblBloodwork]    Script Date: 4/3/2025 9:26:26 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tblDoctorVisits]    Script Date: 4/3/2025 9:26:26 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tblFamilyHistories]    Script Date: 4/3/2025 9:26:26 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tblFamilyMemberMedicalConditions]    Script Date: 4/3/2025 9:26:26 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tblFamilyMembers]    Script Date: 4/3/2025 9:26:26 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tblHospitalizations]    Script Date: 4/3/2025 9:26:26 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tblImmunizationDetails]    Script Date: 4/3/2025 9:26:26 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tblMedicationLists]    Script Date: 4/3/2025 9:26:26 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tblSelectBloodworkGroupNames]    Script Date: 4/3/2025 9:26:26 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tblSelectBloodworkIndiNames]    Script Date: 4/3/2025 9:26:26 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tblSelectDoctors]    Script Date: 4/3/2025 9:26:26 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tblSelectFacilities]    Script Date: 4/3/2025 9:26:26 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tblSelectManufacturers]    Script Date: 4/3/2025 9:26:26 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tblSelectMedicalConditions]    Script Date: 4/3/2025 9:26:26 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tblSelectMedications]    Script Date: 4/3/2025 9:26:26 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tblSelectTestTypes]    Script Date: 4/3/2025 9:26:26 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tblSelectVaccineGroupNames]    Script Date: 4/3/2025 9:26:26 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tblSelectVaccineNames]    Script Date: 4/3/2025 9:26:26 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tblSurgeries]    Script Date: 4/3/2025 9:26:26 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tblTests]    Script Date: 4/3/2025 9:26:26 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tblUsers]    Script Date: 4/3/2025 9:26:26 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

USE [master]
GO

ALTER DATABASE [dbPMR] SET  READ_WRITE
GO

USE [master]
GO

/****** Object:  Database [dbPMR]    Script Date: 4/3/2025 1:48:59 PM ******/
DROP DATABASE [dbPMR]
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbPMR].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [dbPMR] SET ANSI_NULL_DEFAULT ON
GO

ALTER DATABASE [dbPMR] SET ANSI_NULLS ON
GO

ALTER DATABASE [dbPMR] SET ANSI_PADDING ON
GO

ALTER DATABASE [dbPMR] SET ANSI_WARNINGS ON
GO

ALTER DATABASE [dbPMR] SET ARITHABORT ON
GO

ALTER DATABASE [dbPMR] SET AUTO_CLOSE OFF
GO

ALTER DATABASE [dbPMR] SET AUTO_SHRINK OFF
GO

ALTER DATABASE [dbPMR] SET AUTO_UPDATE_STATISTICS ON
GO

ALTER DATABASE [dbPMR] SET CURSOR_CLOSE_ON_COMMIT OFF
GO

ALTER DATABASE [dbPMR] SET CURSOR_DEFAULT  LOCAL
GO

ALTER DATABASE [dbPMR] SET CONCAT_NULL_YIELDS_NULL ON
GO

ALTER DATABASE [dbPMR] SET NUMERIC_ROUNDABORT OFF
GO

ALTER DATABASE [dbPMR] SET QUOTED_IDENTIFIER ON
GO

ALTER DATABASE [dbPMR] SET RECURSIVE_TRIGGERS OFF
GO

ALTER DATABASE [dbPMR] SET  DISABLE_BROKER
GO

ALTER DATABASE [dbPMR] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO

ALTER DATABASE [dbPMR] SET DATE_CORRELATION_OPTIMIZATION OFF
GO

ALTER DATABASE [dbPMR] SET TRUSTWORTHY OFF
GO

ALTER DATABASE [dbPMR] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO

ALTER DATABASE [dbPMR] SET PARAMETERIZATION SIMPLE
GO

ALTER DATABASE [dbPMR] SET READ_COMMITTED_SNAPSHOT OFF
GO

ALTER DATABASE [dbPMR] SET HONOR_BROKER_PRIORITY OFF
GO

ALTER DATABASE [dbPMR] SET RECOVERY FULL
GO

ALTER DATABASE [dbPMR] SET  MULTI_USER
GO

ALTER DATABASE [dbPMR] SET PAGE_VERIFY NONE
GO

ALTER DATABASE [dbPMR] SET DB_CHAINING OFF
GO

ALTER DATABASE [dbPMR] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF )
GO

ALTER DATABASE [dbPMR] SET TARGET_RECOVERY_TIME = 0 SECONDS
GO

ALTER DATABASE [dbPMR] SET DELAYED_DURABILITY = DISABLED
GO

ALTER DATABASE [dbPMR] SET ACCELERATED_DATABASE_RECOVERY = OFF
GO

ALTER DATABASE [dbPMR] SET QUERY_STORE = OFF
GO

ALTER DATABASE [dbPMR] SET  READ_WRITE
GO


/****** Object:  Database [dbPMR]    Script Date: 4/3/2025 1:48:59 PM ******/
CREATE DATABASE [dbPMR]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbPMR', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\dbPMR.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dbPMR_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\dbPMR.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF

GO

--Syntax Error: Expected TRANSFORM_NOISE_WORDS but encountered LEDGER instead.
--
--/****** Object:  Database [dbPMR]    Script Date: 4/3/2025 1:48:59 PM ******/
--CREATE DATABASE [dbPMR]
-- CONTAINMENT = NONE
-- ON  PRIMARY 
--( NAME = N'dbPMR', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\dbPMR.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
-- LOG ON 
--( NAME = N'dbPMR_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\dbPMR.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
-- WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF



GO

USE [dbPMR]
GO

ALTER TABLE [dbo].[tblTests] DROP CONSTRAINT [FK_tblTests_tblUsers]
GO

ALTER TABLE [dbo].[tblTests] DROP CONSTRAINT [FK_tblTests_tblSelectTestTypes]
GO

ALTER TABLE [dbo].[tblTests] DROP CONSTRAINT [FK_tblTests_tblSelectMedicalConditions]
GO

ALTER TABLE [dbo].[tblTests] DROP CONSTRAINT [FK_tblTests_tblSelectFacilities]
GO

ALTER TABLE [dbo].[tblTests] DROP CONSTRAINT [FK_tblTests_tblSelectDoctors]
GO

ALTER TABLE [dbo].[tblSurgeries] DROP CONSTRAINT [FK_tblSurgeries_tblUsers]
GO

ALTER TABLE [dbo].[tblSurgeries] DROP CONSTRAINT [FK_tblSurgeries_tblSelectMedicalConditions]
GO

ALTER TABLE [dbo].[tblSurgeries] DROP CONSTRAINT [FK_tblSurgeries_tblSelectFacilities]
GO

ALTER TABLE [dbo].[tblSurgeries] DROP CONSTRAINT [FK_tblSurgeries_tblSelectDoctors]
GO

ALTER TABLE [dbo].[tblSelectVaccineNames] DROP CONSTRAINT [FK_tblSelectVaccineNames_tblSelectVaccineGroupNames]
GO

ALTER TABLE [dbo].[tblSelectMedications] DROP CONSTRAINT [FK_tblSelectMedications_tblSelectManufacturers]
GO

ALTER TABLE [dbo].[tblSelectBloodworkIndiNames] DROP CONSTRAINT [FK_tblSelectBloodworkIndiNames_tblSelectBloodworkGroupNames]
GO

ALTER TABLE [dbo].[tblMedicationLists] DROP CONSTRAINT [FK_tblMedicationLists_tblUsers]
GO

ALTER TABLE [dbo].[tblMedicationLists] DROP CONSTRAINT [FK_tblMedicationLists_tblSelectMedications]
GO

ALTER TABLE [dbo].[tblMedicationLists] DROP CONSTRAINT [FK_tblMedicationLists_tblSelectMedicalConditions]
GO

ALTER TABLE [dbo].[tblMedicationLists] DROP CONSTRAINT [FK_tblMedicationLists_tblSelectFacilities]
GO

ALTER TABLE [dbo].[tblMedicationLists] DROP CONSTRAINT [FK_tblMedicationLists_tblSelectDoctors]
GO

ALTER TABLE [dbo].[tblImmunizationDetails] DROP CONSTRAINT [FK_tblImmunizationDetails_tblUsers]
GO

ALTER TABLE [dbo].[tblImmunizationDetails] DROP CONSTRAINT [FK_tblImmunizationDetails_tblSelectVaccineNames]
GO

ALTER TABLE [dbo].[tblImmunizationDetails] DROP CONSTRAINT [FK_tblImmunizationDetails_tblSelectManufacturers]
GO

ALTER TABLE [dbo].[tblImmunizationDetails] DROP CONSTRAINT [FK_tblImmunizationDetails_tblSelectFacilities]
GO

ALTER TABLE [dbo].[tblHospitalizations] DROP CONSTRAINT [FK_tblHospitalizations_tblUsers]
GO

ALTER TABLE [dbo].[tblHospitalizations] DROP CONSTRAINT [FK_tblHospitalizations_tblSelectMedicalConditions]
GO

ALTER TABLE [dbo].[tblHospitalizations] DROP CONSTRAINT [FK_tblHospitalizations_tblSelectFacilities]
GO

ALTER TABLE [dbo].[tblHospitalizations] DROP CONSTRAINT [FK_tblHospitalizations_tblSelectDoctors]
GO

ALTER TABLE [dbo].[tblFamilyMemberMedicalConditions] DROP CONSTRAINT [FK_tblFamilyMemberMedicalConditions_tblSelectMedicalConditions]
GO

ALTER TABLE [dbo].[tblFamilyMemberMedicalConditions] DROP CONSTRAINT [FK_tblFamilyMemberMedicalConditions_tblFamilyMembers]
GO

ALTER TABLE [dbo].[tblFamilyHistories] DROP CONSTRAINT [FK_tblFamilyHistories_tblUsers]
GO

ALTER TABLE [dbo].[tblFamilyHistories] DROP CONSTRAINT [FK_tblFamilyHistories_tblFamilyMembers]
GO

ALTER TABLE [dbo].[tblDoctorVisits] DROP CONSTRAINT [FK_tblDoctorVisits_tblUsers]
GO

ALTER TABLE [dbo].[tblDoctorVisits] DROP CONSTRAINT [FK_tblDoctorVisits_tblSelectMedicalConditions]
GO

ALTER TABLE [dbo].[tblDoctorVisits] DROP CONSTRAINT [FK_tblDoctorVisits_tblSelectDoctors]
GO

ALTER TABLE [dbo].[tblBloodwork] DROP CONSTRAINT [FK_tblBloodwork_tblUsers]
GO

ALTER TABLE [dbo].[tblBloodwork] DROP CONSTRAINT [FK_tblBloodwork_tblSelectFacilities1]
GO

ALTER TABLE [dbo].[tblBloodwork] DROP CONSTRAINT [FK_tblBloodwork_tblSelectDoctors]
GO

ALTER TABLE [dbo].[tblBloodwork] DROP CONSTRAINT [FK_tblBloodwork_tblSelectBloodworkIndiNames]
GO

/****** Object:  Table [dbo].[tblUsers]    Script Date: 4/3/2025 2:19:31 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblUsers]') AND type in (N'U'))
DROP TABLE [dbo].[tblUsers]
GO

/****** Object:  Table [dbo].[tblTests]    Script Date: 4/3/2025 2:19:31 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblTests]') AND type in (N'U'))
DROP TABLE [dbo].[tblTests]
GO

/****** Object:  Table [dbo].[tblSurgeries]    Script Date: 4/3/2025 2:19:31 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblSurgeries]') AND type in (N'U'))
DROP TABLE [dbo].[tblSurgeries]
GO

/****** Object:  Table [dbo].[tblSelectVaccineNames]    Script Date: 4/3/2025 2:19:31 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblSelectVaccineNames]') AND type in (N'U'))
DROP TABLE [dbo].[tblSelectVaccineNames]
GO

/****** Object:  Table [dbo].[tblSelectVaccineGroupNames]    Script Date: 4/3/2025 2:19:31 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblSelectVaccineGroupNames]') AND type in (N'U'))
DROP TABLE [dbo].[tblSelectVaccineGroupNames]
GO

/****** Object:  Table [dbo].[tblSelectTestTypes]    Script Date: 4/3/2025 2:19:31 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblSelectTestTypes]') AND type in (N'U'))
DROP TABLE [dbo].[tblSelectTestTypes]
GO

/****** Object:  Table [dbo].[tblSelectMedications]    Script Date: 4/3/2025 2:19:31 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblSelectMedications]') AND type in (N'U'))
DROP TABLE [dbo].[tblSelectMedications]
GO

/****** Object:  Table [dbo].[tblSelectMedicalConditions]    Script Date: 4/3/2025 2:19:31 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblSelectMedicalConditions]') AND type in (N'U'))
DROP TABLE [dbo].[tblSelectMedicalConditions]
GO

/****** Object:  Table [dbo].[tblSelectManufacturers]    Script Date: 4/3/2025 2:19:31 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblSelectManufacturers]') AND type in (N'U'))
DROP TABLE [dbo].[tblSelectManufacturers]
GO

/****** Object:  Table [dbo].[tblSelectFamilyMembers]    Script Date: 4/3/2025 2:19:31 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblSelectFamilyMembers]') AND type in (N'U'))
DROP TABLE [dbo].[tblSelectFamilyMembers]
GO

/****** Object:  Table [dbo].[tblSelectFacilities]    Script Date: 4/3/2025 2:19:31 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblSelectFacilities]') AND type in (N'U'))
DROP TABLE [dbo].[tblSelectFacilities]
GO

/****** Object:  Table [dbo].[tblSelectDoctors]    Script Date: 4/3/2025 2:19:31 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblSelectDoctors]') AND type in (N'U'))
DROP TABLE [dbo].[tblSelectDoctors]
GO

/****** Object:  Table [dbo].[tblSelectBloodworkIndiNames]    Script Date: 4/3/2025 2:19:31 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblSelectBloodworkIndiNames]') AND type in (N'U'))
DROP TABLE [dbo].[tblSelectBloodworkIndiNames]
GO

/****** Object:  Table [dbo].[tblSelectBloodworkGroupNames]    Script Date: 4/3/2025 2:19:31 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblSelectBloodworkGroupNames]') AND type in (N'U'))
DROP TABLE [dbo].[tblSelectBloodworkGroupNames]
GO

/****** Object:  Table [dbo].[tblMedicationLists]    Script Date: 4/3/2025 2:19:31 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblMedicationLists]') AND type in (N'U'))
DROP TABLE [dbo].[tblMedicationLists]
GO

/****** Object:  Table [dbo].[tblImmunizationDetails]    Script Date: 4/3/2025 2:19:31 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblImmunizationDetails]') AND type in (N'U'))
DROP TABLE [dbo].[tblImmunizationDetails]
GO

/****** Object:  Table [dbo].[tblHospitalizations]    Script Date: 4/3/2025 2:19:31 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblHospitalizations]') AND type in (N'U'))
DROP TABLE [dbo].[tblHospitalizations]
GO

/****** Object:  Table [dbo].[tblFamilyMemberMedicalConditions]    Script Date: 4/3/2025 2:19:31 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblFamilyMemberMedicalConditions]') AND type in (N'U'))
DROP TABLE [dbo].[tblFamilyMemberMedicalConditions]
GO

/****** Object:  Table [dbo].[tblFamilyHistories]    Script Date: 4/3/2025 2:19:31 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblFamilyHistories]') AND type in (N'U'))
DROP TABLE [dbo].[tblFamilyHistories]
GO

/****** Object:  Table [dbo].[tblDoctorVisits]    Script Date: 4/3/2025 2:19:31 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblDoctorVisits]') AND type in (N'U'))
DROP TABLE [dbo].[tblDoctorVisits]
GO

/****** Object:  Table [dbo].[tblBloodwork]    Script Date: 4/3/2025 2:19:31 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblBloodwork]') AND type in (N'U'))
DROP TABLE [dbo].[tblBloodwork]
GO

USE [master]
GO

/****** Object:  Database [dbPMR]    Script Date: 4/3/2025 2:19:31 PM ******/
DROP DATABASE [dbPMR]
GO

/****** Object:  Database [dbPMR]    Script Date: 4/3/2025 2:19:31 PM ******/
CREATE DATABASE [dbPMR]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbPMR', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\dbPMR.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dbPMR_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\dbPMR.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbPMR].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [dbPMR] SET ANSI_NULL_DEFAULT ON
GO

ALTER DATABASE [dbPMR] SET ANSI_NULLS ON
GO

ALTER DATABASE [dbPMR] SET ANSI_PADDING ON
GO

ALTER DATABASE [dbPMR] SET ANSI_WARNINGS ON
GO

ALTER DATABASE [dbPMR] SET ARITHABORT ON
GO

ALTER DATABASE [dbPMR] SET AUTO_CLOSE OFF
GO

ALTER DATABASE [dbPMR] SET AUTO_SHRINK OFF
GO

ALTER DATABASE [dbPMR] SET AUTO_UPDATE_STATISTICS ON
GO

ALTER DATABASE [dbPMR] SET CURSOR_CLOSE_ON_COMMIT OFF
GO

ALTER DATABASE [dbPMR] SET CURSOR_DEFAULT  LOCAL
GO

ALTER DATABASE [dbPMR] SET CONCAT_NULL_YIELDS_NULL ON
GO

ALTER DATABASE [dbPMR] SET NUMERIC_ROUNDABORT OFF
GO

ALTER DATABASE [dbPMR] SET QUOTED_IDENTIFIER ON
GO

ALTER DATABASE [dbPMR] SET RECURSIVE_TRIGGERS OFF
GO

ALTER DATABASE [dbPMR] SET  DISABLE_BROKER
GO

ALTER DATABASE [dbPMR] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO

ALTER DATABASE [dbPMR] SET DATE_CORRELATION_OPTIMIZATION OFF
GO

ALTER DATABASE [dbPMR] SET TRUSTWORTHY OFF
GO

ALTER DATABASE [dbPMR] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO

ALTER DATABASE [dbPMR] SET PARAMETERIZATION SIMPLE
GO

ALTER DATABASE [dbPMR] SET READ_COMMITTED_SNAPSHOT OFF
GO

ALTER DATABASE [dbPMR] SET HONOR_BROKER_PRIORITY OFF
GO

ALTER DATABASE [dbPMR] SET RECOVERY FULL
GO

ALTER DATABASE [dbPMR] SET  MULTI_USER
GO

ALTER DATABASE [dbPMR] SET PAGE_VERIFY NONE
GO

ALTER DATABASE [dbPMR] SET DB_CHAINING OFF
GO

ALTER DATABASE [dbPMR] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF )
GO

ALTER DATABASE [dbPMR] SET TARGET_RECOVERY_TIME = 0 SECONDS
GO

ALTER DATABASE [dbPMR] SET DELAYED_DURABILITY = DISABLED
GO

ALTER DATABASE [dbPMR] SET ACCELERATED_DATABASE_RECOVERY = OFF
GO

ALTER DATABASE [dbPMR] SET QUERY_STORE = OFF
GO

USE [dbPMR]
GO

/****** Object:  Table [dbo].[tblBloodwork]    Script Date: 4/3/2025 2:19:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tblDoctorVisits]    Script Date: 4/3/2025 2:19:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tblFamilyHistories]    Script Date: 4/3/2025 2:19:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tblFamilyMemberMedicalConditions]    Script Date: 4/3/2025 2:19:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tblHospitalizations]    Script Date: 4/3/2025 2:19:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tblImmunizationDetails]    Script Date: 4/3/2025 2:19:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tblMedicationLists]    Script Date: 4/3/2025 2:19:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tblSelectBloodworkGroupNames]    Script Date: 4/3/2025 2:19:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tblSelectBloodworkIndiNames]    Script Date: 4/3/2025 2:19:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tblSelectDoctors]    Script Date: 4/3/2025 2:19:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tblSelectFacilities]    Script Date: 4/3/2025 2:19:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tblSelectFamilyMembers]    Script Date: 4/3/2025 2:19:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tblSelectManufacturers]    Script Date: 4/3/2025 2:19:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tblSelectMedicalConditions]    Script Date: 4/3/2025 2:19:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tblSelectMedications]    Script Date: 4/3/2025 2:19:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tblSelectTestTypes]    Script Date: 4/3/2025 2:19:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tblSelectVaccineGroupNames]    Script Date: 4/3/2025 2:19:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tblSelectVaccineNames]    Script Date: 4/3/2025 2:19:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tblSurgeries]    Script Date: 4/3/2025 2:19:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tblTests]    Script Date: 4/3/2025 2:19:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[tblUsers]    Script Date: 4/3/2025 2:19:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

USE [master]
GO

ALTER DATABASE [dbPMR] SET  READ_WRITE
GO
