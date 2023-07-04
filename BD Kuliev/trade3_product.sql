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
-- Table structure for table `product`
--

DROP TABLE IF EXISTS `product`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `product` (
  `ProductArticleNumber` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `ProductIDName` int NOT NULL,
  `ProductDescription` text NOT NULL,
  `ProductIDCategory` int NOT NULL,
  `ProductPhoto` varchar(100) NOT NULL,
  `ProductIDManufacturer` int NOT NULL,
  `ProductCost` decimal(19,4) NOT NULL,
  `ProductDiscountAmount` tinyint DEFAULT NULL,
  `ProductQuantityInStock` int NOT NULL,
  `ProductStatus` text NOT NULL,
  `ProductIDUnit` int DEFAULT NULL,
  `ProductIDProvider` int DEFAULT NULL,
  PRIMARY KEY (`ProductArticleNumber`),
  KEY `FK_ProductIDCategory_idx` (`ProductIDCategory`),
  KEY `FK_ProductIDManufacturer_idx` (`ProductIDManufacturer`),
  KEY `FK_ProductIDUnit_idx` (`ProductIDUnit`),
  KEY `FK_ProductIDProvider_idx` (`ProductIDProvider`),
  KEY `FK_ProductName_idx` (`ProductIDName`),
  CONSTRAINT `FK_ProductIDCategory` FOREIGN KEY (`ProductIDCategory`) REFERENCES `productcategory` (`ProductIDCategory`),
  CONSTRAINT `FK_ProductIDManufacturer` FOREIGN KEY (`ProductIDManufacturer`) REFERENCES `productmanufacturer` (`ProductIDManufacturer`),
  CONSTRAINT `FK_ProductIDProvider` FOREIGN KEY (`ProductIDProvider`) REFERENCES `productprovider` (`ProductIDProvider`),
  CONSTRAINT `FK_ProductIDUnit` FOREIGN KEY (`ProductIDUnit`) REFERENCES `productunit` (`ProductIDUnit`),
  CONSTRAINT `FK_ProductName` FOREIGN KEY (`ProductIDName`) REFERENCES `productname` (`ProductIDName`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product`
--

LOCK TABLES `product` WRITE;
/*!40000 ALTER TABLE `product` DISABLE KEYS */;
INSERT INTO `product` VALUES ('A297U6',13,'Ручка гелевая ErichKrause® G-Cube®, цвет чернил черный',4,'',2,52.0000,20,18,'2',1,NULL),('A340R5',9,'Маркер перманентный GoodMark 2-х сторонний.для СD/DVD черный',2,'',4,66.0000,15,27,'2',1,NULL),('A346R4',15,'Ручка шариковая автоматическая с синими чернилами, диаметр шарика 0,9 мм',4,'A346R4.jpg',1,35.0000,20,23,'2',2,NULL),('A384T5',20,'Тетрадь, 18 листов, А5 линейка Hatber/Хатбер Серия Зеленая 10шт в блистере',4,'',5,87.0000,20,23,'1',1,NULL),('A543T6',14,'Ручка шариковая Erich Krause, R-301 ORANGE 0.7 Stick, синий',2,'A543T6.jpg',2,13.0000,30,12,'2',1,NULL),('A567R4',14,'Шариковая ручка PILOT SuperGrip 0,7 мм синяя BPGP-10R-F-L',4,'',6,64.0000,30,32,'2',1,NULL),('B730E2',14,'Ручка шариковая одноразовая автоматическая Unimax Fab GP синяя (толщина линии 0.5 мм)',4,'B730E2.jpg',8,41.0000,10,45,'2',2,NULL),('D367R4',3,'Клей ПВА 85г Hatber/Хатбер',4,'',5,26.0000,20,16,'2',1,NULL),('D419T7',4,'Клей-карандаш Erich Krause 15 гр.',2,'D419T7.png',2,61.0000,18,26,'2',1,NULL),('F719R5',12,'Папка-скоросшиватель, А4 Hatber/Хатбер 140/180мкм АССОРТИ, пластиковая с перфорацией прозрачный верх',2,'F719R5.jpg',5,18.0000,20,8,'2',1,NULL),('G278R6',14,'Ручка шариковая FLEXOFFICE CANDEE 0,6 мм, синяя',2,'G278R6.png',3,15.0000,30,23,'2',1,NULL),('H452A3',20,'Тетрадь, 24 листа, Зелёная обложка Hatber/Хатбер, офсет, клетка с полями',3,'H452A3.png',5,10.0000,8,25,'2',1,NULL),('J539R3',5,'Кнопки канцелярские Комус металлические цветные (50 штук в упаковке)',2,'',9,96.0000,20,24,'1',2,NULL),('K345R5',7,'Корректирующая лента Attache Economy 5 мм x 5 м',2,'',1,87.0000,20,12,'2',2,NULL),('K502T9',2,'Карандаш-корректор GoodMark, морозостойкий, 8мл, металлический наконечник',2,'',4,70.0000,25,7,'2',1,NULL),('K753R3',6,'Корректирующая жидкость (штрих) Attache быстросохнущая 20 мл',4,'',1,50.0000,30,5,'2',2,NULL),('K932R4',7,'Корректор лента 5мм*4м, блистер, GoodMark',2,'',4,70.0000,25,16,'2',1,NULL),('M892R4',11,'Ножницы 195 мм Attache с пластиковыми прорезиненными анатомическими ручками бирюзового/черного цвета',4,'',1,209.0000,15,13,'2',2,NULL),('N459R6',19,'Стикеры Attache Selection 51х51 мм неоновые 5 цветов (1 блок, 250 листов)',2,'',1,194.0000,25,9,'1',2,NULL),('N592T4',19,'Стикеры Attache 76x76 мм пастельные желтые (1 блок, 100 листов)',2,'',1,34.0000,15,17,'1',2,NULL),('R259E6',1,'Бумага офисная Svetocopy NEW A4 80г 500л',1,'R259E6.jpg',7,299.0000,25,32,'1',1,NULL),('S276E6',17,'Скрепки Комус металлические никелированные 33 мм (100 штук в упаковке)',2,'',9,46.0000,30,14,'1',2,NULL),('S425T6',16,'Скобы для степлера №24/6 Attache оцинкованные (1000 штук в упаковке)',2,'',1,25.0000,20,16,'1',2,NULL),('S453G7',17,'Скрепки 28 мм Attache металлические (100 штук в упаковке)',2,'',1,21.0000,15,20,'1',2,NULL),('S512T7',16,'Скобы №10 1000шт, к/к, GoodMark',2,'',4,25.0000,15,32,'1',1,NULL),('S563T6',18,'Степлер Attache 8215 до 25 листов черный',2,'',1,231.0000,25,17,'2',2,NULL),('T564P5',10,'Набор шариковых ручек одноразовых Attache Economy Spinner 10 цветов (толщина линии 0.5 мм)',4,'T564P5.jpg',1,50.0000,15,5,'1',2,NULL),('Z390R4',8,'Клейкая лента упаковочная Комус 50 мм x 100 м 50 мкм прозрачная',2,'',9,195.0000,20,9,'2',2,NULL),('Z539E3',8,'Лента клейкая 12мм*33м прозрачная, Hatber/Хатбер',2,'',5,16.0000,15,14,'2',1,NULL),('А112Т4',14,'Ручка шариковая с синими чернилами,толщина стержня 7 мм',3,'',6,12.0000,30,6,'2',2,NULL);
/*!40000 ALTER TABLE `product` ENABLE KEYS */;
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
