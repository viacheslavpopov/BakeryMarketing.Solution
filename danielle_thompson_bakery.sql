-- MySQL dump 10.13  Distrib 8.0.15, for macos10.14 (x86_64)
--
-- Host: localhost    Database: bakery
-- ------------------------------------------------------
-- Server version	8.0.15

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Dumping data for table `__EFMigrationsHistory`
--

LOCK TABLES `__EFMigrationsHistory` WRITE;
/*!40000 ALTER TABLE `__EFMigrationsHistory` DISABLE KEYS */;
INSERT INTO `__EFMigrationsHistory` VALUES ('20210115214449_Initial','2.2.6-servicing-10079'),('20210116001040_Models','2.2.6-servicing-10079'),('20210116042343_AddNullableIdsAndVirtual','2.2.6-servicing-10079'),('20210117210458_UpdateTableNamesToSingular','2.2.6-servicing-10079'),('20210117211440_CapitalizeJoinNames','2.2.6-servicing-10079'),('20210119032145_AddDeleteCascadeSettingInMySQL','2.2.6-servicing-10079');
/*!40000 ALTER TABLE `__EFMigrationsHistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `AspNetRoleClaims`
--

LOCK TABLES `AspNetRoleClaims` WRITE;
/*!40000 ALTER TABLE `AspNetRoleClaims` DISABLE KEYS */;
/*!40000 ALTER TABLE `AspNetRoleClaims` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `AspNetRoles`
--

LOCK TABLES `AspNetRoles` WRITE;
/*!40000 ALTER TABLE `AspNetRoles` DISABLE KEYS */;
/*!40000 ALTER TABLE `AspNetRoles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `AspNetUserClaims`
--

LOCK TABLES `AspNetUserClaims` WRITE;
/*!40000 ALTER TABLE `AspNetUserClaims` DISABLE KEYS */;
/*!40000 ALTER TABLE `AspNetUserClaims` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `AspNetUserLogins`
--

LOCK TABLES `AspNetUserLogins` WRITE;
/*!40000 ALTER TABLE `AspNetUserLogins` DISABLE KEYS */;
/*!40000 ALTER TABLE `AspNetUserLogins` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `AspNetUserRoles`
--

LOCK TABLES `AspNetUserRoles` WRITE;
/*!40000 ALTER TABLE `AspNetUserRoles` DISABLE KEYS */;
/*!40000 ALTER TABLE `AspNetUserRoles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `AspNetUsers`
--

LOCK TABLES `AspNetUsers` WRITE;
/*!40000 ALTER TABLE `AspNetUsers` DISABLE KEYS */;
INSERT INTO `AspNetUsers` VALUES ('f8eaa9bd-27af-4f43-9208-6b9ec11949aa','pierre@pierresbakery.com','PIERRE@PIERRESBAKERY.COM',NULL,NULL,_binary '\0','AQAAAAEAACcQAAAAEB+zHXYUb6wn9MBspb7dc4fD/fsxA7YDHrZLVdaxRdNVhFXLPFDbDBHuHJGJSxoV+A==','7OIDFXAB6QOCPV666WXSWG3KUII3B2JW','e29cb802-ed17-45fe-a265-9de7e228bc16',NULL,_binary '\0',_binary '\0',NULL,_binary '',0);
/*!40000 ALTER TABLE `AspNetUsers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `AspNetUserTokens`
--

LOCK TABLES `AspNetUserTokens` WRITE;
/*!40000 ALTER TABLE `AspNetUserTokens` DISABLE KEYS */;
/*!40000 ALTER TABLE `AspNetUserTokens` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `Flavors`
--

LOCK TABLES `Flavors` WRITE;
/*!40000 ALTER TABLE `Flavors` DISABLE KEYS */;
INSERT INTO `Flavors` VALUES (8,'Savory','f8eaa9bd-27af-4f43-9208-6b9ec11949aa'),(9,'Sweet','f8eaa9bd-27af-4f43-9208-6b9ec11949aa'),(10,'Chocolate','f8eaa9bd-27af-4f43-9208-6b9ec11949aa'),(11,'Almond','f8eaa9bd-27af-4f43-9208-6b9ec11949aa'),(12,'test','f8eaa9bd-27af-4f43-9208-6b9ec11949aa');
/*!40000 ALTER TABLE `Flavors` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `FlavorSweet`
--

LOCK TABLES `FlavorSweet` WRITE;
/*!40000 ALTER TABLE `FlavorSweet` DISABLE KEYS */;
INSERT INTO `FlavorSweet` VALUES (12,11,9),(13,10,6),(14,10,7),(15,10,8);
/*!40000 ALTER TABLE `FlavorSweet` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `Sweets`
--

LOCK TABLES `Sweets` WRITE;
/*!40000 ALTER TABLE `Sweets` DISABLE KEYS */;
INSERT INTO `Sweets` VALUES (6,'Chocolate Bread','f8eaa9bd-27af-4f43-9208-6b9ec11949aa'),(7,'Chocolate Cheesecake','f8eaa9bd-27af-4f43-9208-6b9ec11949aa'),(8,'Chocolate croissant','f8eaa9bd-27af-4f43-9208-6b9ec11949aa'),(9,'Almond croissant','f8eaa9bd-27af-4f43-9208-6b9ec11949aa');
/*!40000 ALTER TABLE `Sweets` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-01-18 19:54:22
