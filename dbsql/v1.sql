CREATE DATABASE  IF NOT EXISTS `4915mdb` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `4915mdb`;
-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: 4915mdb
-- ------------------------------------------------------
-- Server version	8.0.37

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
-- Table structure for table `delivery_request`
--

DROP TABLE IF EXISTS `delivery_request`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `delivery_request` (
  `delivery_request_id` varchar(10) NOT NULL,
  `delivery_address` varchar(50) NOT NULL,
  `receive_address` varchar(50) NOT NULL,
  `item_id` varchar(10) NOT NULL,
  `quantity` int NOT NULL,
  `status` varchar(20) NOT NULL,
  `despatch_item` date NOT NULL,
  `receive_time` date NOT NULL,
  PRIMARY KEY (`delivery_request_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `delivery_request`
--

LOCK TABLES `delivery_request` WRITE;
/*!40000 ALTER TABLE `delivery_request` DISABLE KEYS */;
/*!40000 ALTER TABLE `delivery_request` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `despatch_instruction`
--

DROP TABLE IF EXISTS `despatch_instruction`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `despatch_instruction` (
  `instruction_id` varchar(20) NOT NULL,
  `warehouse_id` varchar(10) NOT NULL,
  `item_id` varchar(10) NOT NULL,
  `handler` varchar(10) NOT NULL,
  `status` varchar(20) NOT NULL,
  `purchasers_request_id` varchar(10) NOT NULL,
  `remarks` varchar(200) NOT NULL,
  PRIMARY KEY (`instruction_id`),
  KEY `warehouse_id` (`warehouse_id`),
  KEY `item_id` (`item_id`),
  KEY `handler` (`handler`),
  KEY `purchasers_request_id` (`purchasers_request_id`),
  CONSTRAINT `despatch_instruction_ibfk_1` FOREIGN KEY (`warehouse_id`) REFERENCES `warehouse` (`warehouse_id`),
  CONSTRAINT `despatch_instruction_ibfk_2` FOREIGN KEY (`item_id`) REFERENCES `item` (`item_ID`),
  CONSTRAINT `despatch_instruction_ibfk_3` FOREIGN KEY (`handler`) REFERENCES `user` (`user_ID`),
  CONSTRAINT `despatch_instruction_ibfk_4` FOREIGN KEY (`purchasers_request_id`) REFERENCES `purchase_request` (`purchasers_request_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `despatch_instruction`
--

LOCK TABLES `despatch_instruction` WRITE;
/*!40000 ALTER TABLE `despatch_instruction` DISABLE KEYS */;
/*!40000 ALTER TABLE `despatch_instruction` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `invoice`
--

DROP TABLE IF EXISTS `invoice`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `invoice` (
  `invoice_id` varchar(10) NOT NULL,
  `purchase_order_id` varchar(10) NOT NULL,
  `date` date NOT NULL,
  PRIMARY KEY (`invoice_id`),
  KEY `purchase_order_id` (`purchase_order_id`),
  CONSTRAINT `invoice_ibfk_1` FOREIGN KEY (`purchase_order_id`) REFERENCES `purchase_order_all` (`purchase_order_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `invoice`
--

LOCK TABLES `invoice` WRITE;
/*!40000 ALTER TABLE `invoice` DISABLE KEYS */;
/*!40000 ALTER TABLE `invoice` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `item`
--

DROP TABLE IF EXISTS `item`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `item` (
  `item_ID` varchar(10) NOT NULL,
  `item_name` varchar(20) NOT NULL,
  `price` decimal(10,2) NOT NULL,
  `brand` varchar(20) NOT NULL,
  `category_ID` varchar(10) NOT NULL,
  `supplier_ID` varchar(10) NOT NULL,
  PRIMARY KEY (`item_ID`),
  KEY `category_ID` (`category_ID`),
  KEY `supplier_ID` (`supplier_ID`),
  CONSTRAINT `item_ibfk_1` FOREIGN KEY (`category_ID`) REFERENCES `item_category` (`category_ID`),
  CONSTRAINT `item_ibfk_2` FOREIGN KEY (`supplier_ID`) REFERENCES `supplier` (`supplier_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `item`
--

LOCK TABLES `item` WRITE;
/*!40000 ALTER TABLE `item` DISABLE KEYS */;
/*!40000 ALTER TABLE `item` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `item_category`
--

DROP TABLE IF EXISTS `item_category`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `item_category` (
  `category_ID` varchar(10) NOT NULL,
  `category_name` varchar(50) NOT NULL,
  `description` varchar(200) NOT NULL,
  PRIMARY KEY (`category_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `item_category`
--

LOCK TABLES `item_category` WRITE;
/*!40000 ALTER TABLE `item_category` DISABLE KEYS */;
/*!40000 ALTER TABLE `item_category` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `notification_rule`
--

DROP TABLE IF EXISTS `notification_rule`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `notification_rule` (
  `notify_rule_id` varchar(10) NOT NULL,
  `user_id` varchar(10) NOT NULL,
  `condition_rule` varchar(50) NOT NULL,
  PRIMARY KEY (`notify_rule_id`),
  KEY `user_id` (`user_id`),
  CONSTRAINT `notification_rule_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `user` (`user_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `notification_rule`
--

LOCK TABLES `notification_rule` WRITE;
/*!40000 ALTER TABLE `notification_rule` DISABLE KEYS */;
/*!40000 ALTER TABLE `notification_rule` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `purchase_order_all`
--

DROP TABLE IF EXISTS `purchase_order_all`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `purchase_order_all` (
  `purchase_order_id` varchar(10) NOT NULL,
  `purchasers_request_id` varchar(10) NOT NULL,
  `delivery_request_id` varchar(10) NOT NULL,
  `description` varchar(200) NOT NULL,
  `purchase_order_detail_id` varchar(10) NOT NULL,
  PRIMARY KEY (`purchase_order_id`),
  KEY `purchasers_request_id` (`purchasers_request_id`),
  KEY `delivery_request_id` (`delivery_request_id`),
  KEY `purchase_order_detail_id` (`purchase_order_detail_id`),
  CONSTRAINT `purchase_order_all_ibfk_1` FOREIGN KEY (`purchasers_request_id`) REFERENCES `purchase_request` (`purchasers_request_ID`),
  CONSTRAINT `purchase_order_all_ibfk_2` FOREIGN KEY (`delivery_request_id`) REFERENCES `delivery_request` (`delivery_request_id`),
  CONSTRAINT `purchase_order_all_ibfk_3` FOREIGN KEY (`purchase_order_detail_id`) REFERENCES `purchase_order_detail` (`purchase_order_detail_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `purchase_order_all`
--

LOCK TABLES `purchase_order_all` WRITE;
/*!40000 ALTER TABLE `purchase_order_all` DISABLE KEYS */;
/*!40000 ALTER TABLE `purchase_order_all` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `purchase_order_detail`
--

DROP TABLE IF EXISTS `purchase_order_detail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `purchase_order_detail` (
  `purchase_order_detail_id` varchar(10) NOT NULL,
  `create_date` date NOT NULL,
  `supplier_id` varchar(10) NOT NULL,
  `buyer_id` varchar(10) NOT NULL,
  `schedules` date NOT NULL,
  `amount` int NOT NULL,
  `currency` int NOT NULL,
  `purchase_order_detail_condition` varchar(50) DEFAULT NULL,
  `handler` varchar(10) NOT NULL,
  `remarks` varchar(200) NOT NULL,
  PRIMARY KEY (`purchase_order_detail_id`),
  KEY `supplier_id` (`supplier_id`),
  KEY `buyer_id` (`buyer_id`),
  KEY `handler` (`handler`),
  CONSTRAINT `purchase_order_detail_ibfk_1` FOREIGN KEY (`supplier_id`) REFERENCES `supplier` (`supplier_ID`),
  CONSTRAINT `purchase_order_detail_ibfk_2` FOREIGN KEY (`buyer_id`) REFERENCES `user` (`user_ID`),
  CONSTRAINT `purchase_order_detail_ibfk_3` FOREIGN KEY (`handler`) REFERENCES `user` (`user_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `purchase_order_detail`
--

LOCK TABLES `purchase_order_detail` WRITE;
/*!40000 ALTER TABLE `purchase_order_detail` DISABLE KEYS */;
/*!40000 ALTER TABLE `purchase_order_detail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `purchase_request`
--

DROP TABLE IF EXISTS `purchase_request`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `purchase_request` (
  `purchasers_request_ID` varchar(10) NOT NULL,
  `shop_ID` varchar(10) NOT NULL,
  `requestor_ID` varchar(10) NOT NULL,
  `date` date NOT NULL,
  `expected_delivery_date` date NOT NULL,
  PRIMARY KEY (`purchasers_request_ID`),
  KEY `shop_ID` (`shop_ID`),
  KEY `requestor_ID` (`requestor_ID`),
  CONSTRAINT `purchase_request_ibfk_1` FOREIGN KEY (`shop_ID`) REFERENCES `shop` (`Shop_ID`),
  CONSTRAINT `purchase_request_ibfk_2` FOREIGN KEY (`requestor_ID`) REFERENCES `user` (`user_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `purchase_request`
--

LOCK TABLES `purchase_request` WRITE;
/*!40000 ALTER TABLE `purchase_request` DISABLE KEYS */;
/*!40000 ALTER TABLE `purchase_request` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `shop`
--

DROP TABLE IF EXISTS `shop`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `shop` (
  `Shop_ID` varchar(10) NOT NULL,
  `name` varchar(20) NOT NULL,
  `address` varchar(50) NOT NULL,
  `phone` int NOT NULL,
  `manager_ID` varchar(10) NOT NULL,
  PRIMARY KEY (`Shop_ID`),
  KEY `manager_ID` (`manager_ID`),
  CONSTRAINT `shop_ibfk_1` FOREIGN KEY (`manager_ID`) REFERENCES `user` (`user_ID`),
  CONSTRAINT `shopphone_check` CHECK (((`phone` >= 100000000000) and (`phone` <= 19999999999999)))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `shop`
--

LOCK TABLES `shop` WRITE;
/*!40000 ALTER TABLE `shop` DISABLE KEYS */;
/*!40000 ALTER TABLE `shop` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `supplier`
--

DROP TABLE IF EXISTS `supplier`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `supplier` (
  `supplier_ID` varchar(10) NOT NULL,
  `name` varchar(20) NOT NULL,
  `contact_number` int NOT NULL,
  `address` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `remarks` varchar(200) NOT NULL,
  PRIMARY KEY (`supplier_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `supplier`
--

LOCK TABLES `supplier` WRITE;
/*!40000 ALTER TABLE `supplier` DISABLE KEYS */;
/*!40000 ALTER TABLE `supplier` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `user_ID` varchar(10) NOT NULL,
  `first_name` varchar(50) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `password` varchar(100) NOT NULL,
  `phone` int NOT NULL,
  `email` varchar(50) NOT NULL,
  `address` varchar(50) NOT NULL,
  `acconut_name` varchar(20) NOT NULL,
  `role` varchar(20) NOT NULL,
  PRIMARY KEY (`user_ID`),
  CONSTRAINT `Phone_Check` CHECK (((`phone` >= 100000000000) and (`phone` <= 19999999999999)))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `warehouse`
--

DROP TABLE IF EXISTS `warehouse`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `warehouse` (
  `warehouse_id` varchar(10) NOT NULL,
  `name` varchar(20) NOT NULL,
  `address` varchar(50) NOT NULL,
  PRIMARY KEY (`warehouse_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `warehouse`
--

LOCK TABLES `warehouse` WRITE;
/*!40000 ALTER TABLE `warehouse` DISABLE KEYS */;
/*!40000 ALTER TABLE `warehouse` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `warehouse_item`
--

DROP TABLE IF EXISTS `warehouse_item`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `warehouse_item` (
  `warehouse_ID` varchar(10) NOT NULL,
  `item_ID` varchar(10) NOT NULL,
  `expected_inventory` int NOT NULL,
  PRIMARY KEY (`warehouse_ID`,`item_ID`),
  KEY `item_ID` (`item_ID`),
  CONSTRAINT `warehouse_item_ibfk_1` FOREIGN KEY (`warehouse_ID`) REFERENCES `warehouse` (`warehouse_id`),
  CONSTRAINT `warehouse_item_ibfk_2` FOREIGN KEY (`item_ID`) REFERENCES `item` (`item_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `warehouse_item`
--

LOCK TABLES `warehouse_item` WRITE;
/*!40000 ALTER TABLE `warehouse_item` DISABLE KEYS */;
/*!40000 ALTER TABLE `warehouse_item` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database '4915mdb'
--

--
-- Dumping routines for database '4915mdb'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-05-14 19:26:56
