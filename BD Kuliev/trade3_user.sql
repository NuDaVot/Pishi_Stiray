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
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `UserID` int NOT NULL AUTO_INCREMENT,
  `UserSurname` varchar(100) NOT NULL,
  `UserName` varchar(100) NOT NULL,
  `UserPatronymic` varchar(100) NOT NULL,
  `UserLogin` text NOT NULL,
  `UserPassword` text NOT NULL,
  `UserIDRole` int NOT NULL,
  PRIMARY KEY (`UserID`),
  KEY `user_ibfk_1` (`UserIDRole`),
  CONSTRAINT `user_ibfk_1` FOREIGN KEY (`UserIDRole`) REFERENCES `role` (`RoleID`)
) ENGINE=InnoDB AUTO_INCREMENT=101 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (51,'Никифоров ','Всеволод','Иванович','loginDEjrm2018','Cpb+Im',2),(52,'Воронов ','Донат','Никитевич','loginDEpxl2018','P6h4Jq',1),(53,'Игнатьева ','Евгения','Валентиновна','loginDEwgk2018','&mfI9l',2),(54,'Буров ','Федот','Егорович','loginDEpou2018','gX3f5Z',1),(55,'Иванов ','Иван ','Семёнович','loginDEjwl2018','D4ZYHt',3),(56,'Денисов ','Дамир','Филатович','loginDEabf2018','*Tasm+',2),(57,'Ершов ','Максим','Геласьевич','loginDEwjm2018','k}DJKo',2),(58,'Копылов ','Куприян','Пётрович','loginDEjvz2018','&|bGTy',3),(59,'Носов ','Валерьян','Дмитрьевич','loginDEuyv2018','8hhrZ}',3),(60,'Силин ','Игорь','Авдеевич','loginDExdm2018','DH68L9',1),(61,'Дроздова ','Александра','Мартыновна','loginDEeiv2018','H*BxlS',3),(62,'Дроздов ','Аркадий','Геласьевич','loginDEfuc2018','VuM+QT',2),(63,'Боброва ','Варвара','Евсеевна','loginDEoot2018','usi{aT',3),(64,'Чернова ','Агата','Данииловна','loginDElhk2018','Okk0jY',3),(65,'Лыткина ','Ульяна','Станиславовна','loginDEazg2018','s3bb|V',2),(66,'Лаврентьев ','Леонид','Игнатьевич','loginDEaba2018','#ИМЯ?',1),(67,'Кулаков ','Юрий','Владленович','loginDEtco2018','tTKDJB',2),(68,'Соловьёв ','Андрей','Александрович','loginDEsyq2018','2QbpBN',3),(69,'Корнилова ','Марфа','Макаровна','loginDEpxi2018','+5X&hy',2),(70,'Белоусова ','Любовь','Георгьевна','loginDEicr2018','3+|Sn{',2),(71,'Анисимов ','Никита','Гордеевич','loginDEcui2018','Zi1Tth',3),(72,'Стрелкова ','Фаина','Федосеевна','loginDEpxc2018','G+nFsv',2),(73,'Осипов ','Евгений','Иванович','loginDEqrd2018','sApUbt',1),(74,'Владимирова ','Иванна','Павловна','loginDEsso2018','#ИМЯ?',3),(75,'Кудрявцева ','Жанна','Демьяновна','loginDErsy2018','{Aa6nS',3),(76,'Матвиенко ','Яков','Брониславович','loginDEvpz2018','mS0UxK',3),(77,'Селезнёв ','Егор','Артёмович','loginDEfog2018','glICay',2),(78,'Брагин ','Куприян','Митрофанович','loginDEpii2018','Ob}RZB',2),(79,'Гордеев ','Виктор','Эдуардович','loginDEhyk2018','*gN}Tc',1),(80,'Мартынов ','Онисим','Брониславович','loginDEdxi2018','ywLUbA',3),(81,'Никонова ','Евгения','Павловна','loginDEzro2018','B24s6o',3),(82,'Полякова ','Анна','Денисовна','loginDEuxg2018','K8jui7',2),(83,'Макарова ','Пелагея','Антониновна','loginDEllw2018','jNtNUr',2),(84,'Андреева ','Анна','Вячеславовна','loginDEddg2018','gGGhvD',1),(85,'Кудрявцева ','Кира','Ефимовна','loginDEpdz2018','#ИМЯ?',2),(86,'Шилова ','Кира','Егоровна','loginDEyiw2018','cnj3QR',3),(87,'Ситников ','Игорь','Борисович','loginDEqup2018','95AU|R',1),(88,'Русаков ','Борис','Христофорович','loginDExil2018','w+++Ht',1),(89,'Капустина ','Ульяна','Игоревна','loginDEkuv2018','Ade++|',3),(90,'Беляков ','Семён','Германнович','loginDEmox2018','Je}9e7',3),(91,'Гурьев ','Ириней','Игнатьевич','loginDEvug2018','lEa{Cn',2),(92,'Мишин ','Христофор','Леонидович','loginDEzre2018','N*VX+G',2),(93,'Лазарева ','Антонина','Христофоровна','loginDEbes2018','NaVtyH',3),(94,'Маркова ','Ираида','Сергеевна','loginDEkfg2018','r1060q',2),(95,'Носкова ','Пелагея','Валерьевна','loginDEyek2018','KY2BL4',2),(96,'Баранов ','Станислав','Дмитрьевич','loginDEloq2018','NZV5WR',1),(97,'Ефремов ','Демьян','Артёмович','loginDEjfb2018','TNT+}h',3),(98,'Константинов ','Всеволод','Мэлсович','loginDEueq2018','GqAUZ6',3),(99,'Ситникова ','Ираида','Андреевна','loginDEpqz2018','F0Bp7F',3),(100,'Матвеев ','Кондрат','Иванович','loginDEovk2018','JyJM{A',1);
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-07-04 14:24:18
