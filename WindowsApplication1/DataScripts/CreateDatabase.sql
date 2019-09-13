USE [master]
GO

/****** Object:  Database [ForumExamples]    Script Date: 9/12/2019 5:42:22 PM ******/
CREATE DATABASE [ForumExamples]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ForumExamples', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\ForumExamples.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ForumExamples_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\ForumExamples_log.ldf' , SIZE = 1108800KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [ForumExamples] SET COMPATIBILITY_LEVEL = 110
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ForumExamples].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [ForumExamples] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [ForumExamples] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [ForumExamples] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [ForumExamples] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [ForumExamples] SET ARITHABORT OFF 
GO

ALTER DATABASE [ForumExamples] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [ForumExamples] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [ForumExamples] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [ForumExamples] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [ForumExamples] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [ForumExamples] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [ForumExamples] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [ForumExamples] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [ForumExamples] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [ForumExamples] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [ForumExamples] SET  DISABLE_BROKER 
GO

ALTER DATABASE [ForumExamples] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [ForumExamples] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [ForumExamples] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [ForumExamples] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [ForumExamples] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [ForumExamples] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [ForumExamples] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [ForumExamples] SET RECOVERY FULL 
GO

ALTER DATABASE [ForumExamples] SET  MULTI_USER 
GO

ALTER DATABASE [ForumExamples] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [ForumExamples] SET DB_CHAINING OFF 
GO

ALTER DATABASE [ForumExamples] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [ForumExamples] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [ForumExamples] SET  READ_WRITE 
GO

