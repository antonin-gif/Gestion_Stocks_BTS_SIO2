-- MySQL dump 10.13  Distrib 8.0.22, for Win64 (x86_64)
--
-- Host: localhost    Database: appgestiondestocks
-- ------------------------------------------------------
-- Server version	8.0.22

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
-- Table structure for table `client`
--

DROP TABLE IF EXISTS `client`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `client` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `NOM` varchar(128) NOT NULL,
  `PRENOM` varchar(128) NOT NULL,
  `TELEPHONE` varchar(128) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `client`
--

LOCK TABLES `client` WRITE;
/*!40000 ALTER TABLE `client` DISABLE KEYS */;
INSERT INTO `client` VALUES (1,'Pierre','Dupont','0235251525'),(2,'Martin','Toto','0215151221');
/*!40000 ALTER TABLE `client` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `commande`
--

DROP TABLE IF EXISTS `commande`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `commande` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `ID_FOURNISSEUR` int NOT NULL,
  `DATELIVRAISONCOMMANDE` date NOT NULL,
  `DATECOMMANDE` date NOT NULL,
  `PRIXCOMMANDE` int NOT NULL,
  `LIVRAISONCOMMANDEEFFECTUEE` tinyint(1) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_COMMANDE_FOURNISSEUR` (`ID_FOURNISSEUR`),
  CONSTRAINT `commande_ibfk_1` FOREIGN KEY (`ID_FOURNISSEUR`) REFERENCES `fournisseur` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `commande`
--

LOCK TABLES `commande` WRITE;
/*!40000 ALTER TABLE `commande` DISABLE KEYS */;
/*!40000 ALTER TABLE `commande` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `commandesdetails`
--

DROP TABLE IF EXISTS `commandesdetails`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `commandesdetails` (
  `ID_COMMANDE` int NOT NULL,
  `ID_PRODUIT` int NOT NULL,
  `QUANTITEPRODUITSACHETES` int NOT NULL,
  `PRIX` int NOT NULL,
  PRIMARY KEY (`ID_COMMANDE`,`ID_PRODUIT`),
  KEY `FK_COMMANDESDETAILS_PRODUIT` (`ID_PRODUIT`),
  CONSTRAINT `commandesdetails_ibfk_1` FOREIGN KEY (`ID_COMMANDE`) REFERENCES `commande` (`ID`),
  CONSTRAINT `commandesdetails_ibfk_2` FOREIGN KEY (`ID_PRODUIT`) REFERENCES `produit` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `commandesdetails`
--

LOCK TABLES `commandesdetails` WRITE;
/*!40000 ALTER TABLE `commandesdetails` DISABLE KEYS */;
/*!40000 ALTER TABLE `commandesdetails` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `emplacement_stock`
--

DROP TABLE IF EXISTS `emplacement_stock`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `emplacement_stock` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `ALLEE` char(32) NOT NULL,
  `PLACE` int NOT NULL,
  `ETAGE` int NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `emplacement_stock`
--

LOCK TABLES `emplacement_stock` WRITE;
/*!40000 ALTER TABLE `emplacement_stock` DISABLE KEYS */;
/*!40000 ALTER TABLE `emplacement_stock` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `facturation`
--

DROP TABLE IF EXISTS `facturation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `facturation` (
  `ID_PRODUIT` int NOT NULL,
  `ID_FACTURE` int NOT NULL,
  `QUANTITEPRODUITSVENDUS` int NOT NULL,
  `PRIX` int NOT NULL,
  PRIMARY KEY (`ID_PRODUIT`,`ID_FACTURE`),
  KEY `FK_FACTURATION_FACTURE` (`ID_FACTURE`),
  CONSTRAINT `facturation_ibfk_1` FOREIGN KEY (`ID_PRODUIT`) REFERENCES `produit` (`ID`),
  CONSTRAINT `facturation_ibfk_2` FOREIGN KEY (`ID_FACTURE`) REFERENCES `facture` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `facturation`
--

LOCK TABLES `facturation` WRITE;
/*!40000 ALTER TABLE `facturation` DISABLE KEYS */;
/*!40000 ALTER TABLE `facturation` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `facture`
--

DROP TABLE IF EXISTS `facture`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `facture` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `ID_CLIENT` int NOT NULL,
  `ADRESSE` varchar(128) NOT NULL,
  `DATELIVRAISONFACTURE` date NOT NULL,
  `DATEFACTURE` date NOT NULL,
  `LIVRAISONEFFECTUEE` tinyint(1) NOT NULL,
  `PRIXFACTURE` int NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_FACTURE_CLIENT` (`ID_CLIENT`),
  CONSTRAINT `facture_ibfk_1` FOREIGN KEY (`ID_CLIENT`) REFERENCES `client` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `facture`
--

LOCK TABLES `facture` WRITE;
/*!40000 ALTER TABLE `facture` DISABLE KEYS */;
/*!40000 ALTER TABLE `facture` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fournisseur`
--

DROP TABLE IF EXISTS `fournisseur`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fournisseur` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `NOM` varchar(128) NOT NULL,
  `ADRESSE` varchar(128) NOT NULL,
  `MAIL` varchar(128) NOT NULL,
  `TELEPHONE` varchar(128) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fournisseur`
--

LOCK TABLES `fournisseur` WRITE;
/*!40000 ALTER TABLE `fournisseur` DISABLE KEYS */;
/*!40000 ALTER TABLE `fournisseur` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `produit`
--

DROP TABLE IF EXISTS `produit`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `produit` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `ID_EMPLACEMENT` int NOT NULL,
  `NOM` varchar(128) NOT NULL,
  `POIDS` int NOT NULL,
  `PRIXVENTE` int NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_PRODUIT_EMPLACEMENT_STOCK` (`ID_EMPLACEMENT`),
  CONSTRAINT `produit_ibfk_1` FOREIGN KEY (`ID_EMPLACEMENT`) REFERENCES `emplacement_stock` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produit`
--

LOCK TABLES `produit` WRITE;
/*!40000 ALTER TABLE `produit` DISABLE KEYS */;
/*!40000 ALTER TABLE `produit` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `PRENOM` varchar(128) NOT NULL,
  `NOM` varchar(128) NOT NULL,
  `MAIL` varchar(128) NOT NULL,
  `MDP` varchar(128) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'Clara','Pierre','clara@gmail.com','V02zy9YLAaJxk3au/LqxGw=='),(2,'Julie','Foucault','julie@gmail.com','V02zy9YLAaJxk3au/LqxGw==');
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

-- Dump completed on 2022-05-14 15:33:03
