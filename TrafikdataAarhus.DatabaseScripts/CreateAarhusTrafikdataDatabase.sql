CREATE DATABASE [AarhusTrafikdata]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AarhusTrafikdata_data', FILENAME = N'C:\Databases\AarhusTrafikdata_data.mdf' , SIZE = 5120KB , FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'AarhusTrafikdata_log', FILENAME = N'C:\Databases\AarhusTrafikdata_log.ldf' , SIZE = 1024KB , FILEGROWTH = 10%)
GO
