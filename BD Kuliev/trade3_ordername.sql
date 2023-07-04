-- MySQL dump 10.13  Distrib 8.0.31, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: trade3
-- ------------------------------------------------------
-- Server version	8.0.31

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `ordername`
--

DROP TABLE IF EXISTS `ordername`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ordername` (
  `OrderID` int NOT NULL AUTO_INCREMENT,
  `OrderStatus` text NOT NULL,
  `OrderDate` datetime DEFAULT NULL,
  `OrderDeliveryDate` datetime NOT NULL,
  `OrderPickupPoint` int NOT NULL,
  `FIOclient` varchar(100) DEFAULT NULL,
  `OrderReceive` int DEFAULT NULL,
  PRIMARY KEY (`OrderID`),
  KEY `FK_IdPickUpPoint_idx` (`OrderPickupPoint`),
  CONSTRAINT `FK_IdPickUpPoint` FOREIGN KEY (`OrderPickupPoint`) REFERENCES `pickuppoint` (`IdPickUpPoint`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ordername`
--

LOCK TABLES `ordername` WRITE;
/*!40000 ALTER TABLE `ordername` DISABLE KEYS */;
INSERT INTO `ordername` VALUES (1,'Новый ','2018-05-20 22:00:00','2024-05-20 22:00:00',3,'Высоцкая Майя Давидовна',311),(2,'Завершен','2019-05-20 22:00:00','2025-05-20 22:00:00',4,'Агеев Дамир Давидович',312),(3,'Новый ','2020-05-20 22:00:00','2026-05-20 22:00:00',5,'',313),(4,'Новый ','2021-05-20 22:00:00','2027-05-20 22:00:00',6,'',314),(5,'Завершен','2022-05-20 22:00:00','2028-05-20 22:00:00',7,'',315),(6,'Новый ','2023-05-20 22:00:00','2029-05-20 22:00:00',10,'',316),(7,'Новый ','2024-05-20 22:00:00','2030-05-20 22:00:00',11,'',317),(8,'Новый ','2025-05-20 22:00:00','2031-05-20 22:00:00',20,'Терентьев Филипп Богданович',318),(9,'Новый ','2026-05-20 22:00:00','2001-06-20 22:00:00',30,'Голубева Лея Петровна',319),(10,'Новый ','2027-05-20 22:00:00','2002-06-20 22:00:00',33,'',320);
/*!40000 ALTER TABLE `ordername` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-07-04 14:24:19
