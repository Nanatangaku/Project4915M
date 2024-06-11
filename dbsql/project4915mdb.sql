-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- 主機： 127.0.0.1:3306
-- 產生時間： 2024-06-11 00:28:01
-- 伺服器版本： 8.0.37
-- PHP 版本： 8.2.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- 資料庫： `project4915mdb`
--
CREATE DATABASE IF NOT EXISTS `project4915mdb` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci;
USE `project4915mdb`;

-- --------------------------------------------------------

--
-- 資料表結構 `cancel_order`
--

DROP TABLE IF EXISTS `cancel_order`;
CREATE TABLE IF NOT EXISTS `cancel_order` (
  `cancel_order_id` int NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL,
  `order_id` int NOT NULL,
  `payment` int NOT NULL,
  PRIMARY KEY (`cancel_order_id`),
  KEY `user_id` (`user_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- 資料表新增資料前，先清除舊資料 `cancel_order`
--

TRUNCATE TABLE `cancel_order`;
-- --------------------------------------------------------

--
-- 資料表結構 `cart`
--

DROP TABLE IF EXISTS `cart`;
CREATE TABLE IF NOT EXISTS `cart` (
  `cart_id` int NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL,
  `item_id` int NOT NULL,
  `quantity` int NOT NULL,
  PRIMARY KEY (`cart_id`),
  KEY `item_id` (`item_id`),
  KEY `user_id` (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- 資料表新增資料前，先清除舊資料 `cart`
--

TRUNCATE TABLE `cart`;
-- --------------------------------------------------------

--
-- 資料表結構 `delivery`
--

DROP TABLE IF EXISTS `delivery`;
CREATE TABLE IF NOT EXISTS `delivery` (
  `delivery_id` int NOT NULL AUTO_INCREMENT,
  `order_id` int NOT NULL,
  `user_id` int NOT NULL,
  `create_date` date NOT NULL,
  `expected_delivery_date` date NOT NULL,
  `despatch_date` date DEFAULT NULL,
  `recive_date` date DEFAULT NULL,
  PRIMARY KEY (`delivery_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- 資料表新增資料前，先清除舊資料 `delivery`
--

TRUNCATE TABLE `delivery`;
--
-- 傾印資料表的資料 `delivery`
--

INSERT INTO `delivery` (`delivery_id`, `order_id`, `user_id`, `create_date`, `expected_delivery_date`, `despatch_date`, `recive_date`) VALUES
(3, 26, 5, '2024-06-05', '2024-06-12', NULL, NULL),
(4, 27, 5, '2024-06-09', '2024-06-16', NULL, NULL),
(5, 28, 5, '2024-06-10', '2024-06-17', '2024-06-10', NULL);

-- --------------------------------------------------------

--
-- 資料表結構 `department`
--

DROP TABLE IF EXISTS `department`;
CREATE TABLE IF NOT EXISTS `department` (
  `dept_id` int NOT NULL AUTO_INCREMENT,
  `dept_name` varchar(255) NOT NULL,
  `description` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`dept_id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- 資料表新增資料前，先清除舊資料 `department`
--

TRUNCATE TABLE `department`;
--
-- 傾印資料表的資料 `department`
--

INSERT INTO `department` (`dept_id`, `dept_name`, `description`) VALUES
(1, 'Human Resources', NULL),
(2, 'Category Manager', NULL),
(3, 'Warehouse Manager', NULL),
(4, 'Purchase Manager', NULL),
(5, 'Shop Manager', NULL),
(6, 'Delivery Manager', NULL),
(7, 'Account Manager', NULL);

-- --------------------------------------------------------

--
-- 資料表結構 `item`
--

DROP TABLE IF EXISTS `item`;
CREATE TABLE IF NOT EXISTS `item` (
  `item_id` int NOT NULL AUTO_INCREMENT,
  `item_Name` varchar(255) NOT NULL,
  `item_Category` varchar(255) NOT NULL,
  `price` int NOT NULL,
  `supplier_id` int NOT NULL,
  PRIMARY KEY (`item_id`),
  KEY `supplier_id` (`supplier_id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- 資料表新增資料前，先清除舊資料 `item`
--

TRUNCATE TABLE `item`;
--
-- 傾印資料表的資料 `item`
--

INSERT INTO `item` (`item_id`, `item_Name`, `item_Category`, `price`, `supplier_id`) VALUES
(1, 'Sheet Metal', 'Sheet Metal', 99, 1),
(2, 'Sheet Metal 2', 'Sheet Metal', 88, 1),
(3, 'Major Assemblies 1', 'Major Assemblies', 77, 1),
(4, 'Major Assemblies 2', 'Major Assemblies', 66, 1),
(5, 'Light Component 1', 'Light Component', 55, 1),
(6, 'Light Component 2', 'Light Component', 44, 1),
(7, 'Accessories 1', 'Accessories', 33, 1),
(8, 'Accessories 2', 'Accessories', 22, 1);

-- --------------------------------------------------------

--
-- 資料表結構 `order_item`
--

DROP TABLE IF EXISTS `order_item`;
CREATE TABLE IF NOT EXISTS `order_item` (
  `order_id` int NOT NULL,
  `item_id` int NOT NULL,
  `quantity` int NOT NULL,
  PRIMARY KEY (`order_id`,`item_id`),
  KEY `item_id` (`item_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- 資料表新增資料前，先清除舊資料 `order_item`
--

TRUNCATE TABLE `order_item`;
--
-- 傾印資料表的資料 `order_item`
--

INSERT INTO `order_item` (`order_id`, `item_id`, `quantity`) VALUES
(26, 1, 1500),
(27, 1, 1500),
(28, 1, 1500);

-- --------------------------------------------------------

--
-- 資料表結構 `order_request`
--

DROP TABLE IF EXISTS `order_request`;
CREATE TABLE IF NOT EXISTS `order_request` (
  `order_id` int NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL,
  `payment` decimal(20,2) NOT NULL,
  `order_status_id` int NOT NULL,
  `address` varchar(255) NOT NULL,
  `delivery_id` int DEFAULT NULL,
  PRIMARY KEY (`order_id`),
  KEY `order_status_id` (`order_status_id`),
  KEY `user_id` (`user_id`),
  KEY `delivery_id` (`delivery_id`)
) ENGINE=MyISAM AUTO_INCREMENT=29 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- 資料表新增資料前，先清除舊資料 `order_request`
--

TRUNCATE TABLE `order_request`;
--
-- 傾印資料表的資料 `order_request`
--

INSERT INTO `order_request` (`order_id`, `user_id`, `payment`, `order_status_id`, `address`, `delivery_id`) VALUES
(26, 5, 148500.00, 1, '1', 3),
(27, 5, 148500.00, 9, '2', 4),
(28, 5, 148500.00, 7, 'chaiwan', 5);

-- --------------------------------------------------------

--
-- 資料表結構 `order_status`
--

DROP TABLE IF EXISTS `order_status`;
CREATE TABLE IF NOT EXISTS `order_status` (
  `order_status_id` int NOT NULL AUTO_INCREMENT,
  `status` varchar(255) NOT NULL,
  `description` varchar(255) NOT NULL,
  PRIMARY KEY (`order_status_id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- 資料表新增資料前，先清除舊資料 `order_status`
--

TRUNCATE TABLE `order_status`;
--
-- 傾印資料表的資料 `order_status`
--

INSERT INTO `order_status` (`order_status_id`, `status`, `description`) VALUES
(1, 'waiting to process', 'request'),
(2, 'error process', 'request'),
(3, 'complete process', 'request'),
(4, 'wait to delivery', 'delivery reuqest'),
(5, 'delivering', 'delivering request'),
(6, 'waiting to despatch', 'warehouse'),
(7, 'despatched', 'warehouse'),
(8, 'Cancel Order', 'Order is canceled'),
(9, 'Received', 'Goods is Received');

-- --------------------------------------------------------

--
-- 資料表結構 `role`
--

DROP TABLE IF EXISTS `role`;
CREATE TABLE IF NOT EXISTS `role` (
  `role_id` int NOT NULL AUTO_INCREMENT,
  `role_name` varchar(255) NOT NULL,
  `role_description` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`role_id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- 資料表新增資料前，先清除舊資料 `role`
--

TRUNCATE TABLE `role`;
--
-- 傾印資料表的資料 `role`
--

INSERT INTO `role` (`role_id`, `role_name`, `role_description`) VALUES
(1, 'HR', NULL),
(2, 'Category Manager', NULL),
(3, 'Warehouse Manager', NULL),
(4, 'Purchase Manager', NULL),
(5, 'Shop Manager', NULL),
(6, 'Delivery Manager', NULL),
(7, 'Account Manager', NULL),
(8, 'Dealer', NULL);

-- --------------------------------------------------------

--
-- 資料表結構 `shop`
--

DROP TABLE IF EXISTS `shop`;
CREATE TABLE IF NOT EXISTS `shop` (
  `shop_id` int NOT NULL AUTO_INCREMENT,
  `warehouse_id` int NOT NULL,
  `user_id` int NOT NULL,
  `remarks` varchar(255) NOT NULL,
  `shopname` varchar(255) NOT NULL,
  PRIMARY KEY (`shop_id`),
  KEY `warehouse_id` (`warehouse_id`),
  KEY `user_id` (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- 資料表新增資料前，先清除舊資料 `shop`
--

TRUNCATE TABLE `shop`;
--
-- 傾印資料表的資料 `shop`
--

INSERT INTO `shop` (`shop_id`, `warehouse_id`, `user_id`, `remarks`, `shopname`) VALUES
(1, 1, 5, '', 'Shen Zhen Shop');

-- --------------------------------------------------------

--
-- 資料表結構 `shop_user`
--

DROP TABLE IF EXISTS `shop_user`;
CREATE TABLE IF NOT EXISTS `shop_user` (
  `shop_id` int NOT NULL,
  `user_id` int NOT NULL,
  PRIMARY KEY (`shop_id`,`user_id`),
  KEY `user_id` (`user_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- 資料表新增資料前，先清除舊資料 `shop_user`
--

TRUNCATE TABLE `shop_user`;
-- --------------------------------------------------------

--
-- 資料表結構 `supplier`
--

DROP TABLE IF EXISTS `supplier`;
CREATE TABLE IF NOT EXISTS `supplier` (
  `supplier_id` int NOT NULL AUTO_INCREMENT,
  `supplier_name` varchar(255) NOT NULL,
  `supplier_remark` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`supplier_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- 資料表新增資料前，先清除舊資料 `supplier`
--

TRUNCATE TABLE `supplier`;
--
-- 傾印資料表的資料 `supplier`
--

INSERT INTO `supplier` (`supplier_id`, `supplier_name`, `supplier_remark`) VALUES
(1, 'KenLau_supplier', NULL);

-- --------------------------------------------------------

--
-- 資料表結構 `user`
--

DROP TABLE IF EXISTS `user`;
CREATE TABLE IF NOT EXISTS `user` (
  `user_id` int NOT NULL AUTO_INCREMENT,
  `first_name` varchar(255) NOT NULL,
  `last_name` varchar(255) NOT NULL,
  `role_id` int NOT NULL,
  `user_name` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `phone` int NOT NULL,
  `email` varchar(255) NOT NULL,
  `shop_id` int NOT NULL,
  PRIMARY KEY (`user_id`),
  KEY `role_id` (`role_id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- 資料表新增資料前，先清除舊資料 `user`
--

TRUNCATE TABLE `user`;
--
-- 傾印資料表的資料 `user`
--

INSERT INTO `user` (`user_id`, `first_name`, `last_name`, `role_id`, `user_name`, `password`, `phone`, `email`, `shop_id`) VALUES
(1, 'HR', 'Ken', 1, 'ken_hr', '123', 54946051, 'ken_hr@gmail.com', 1),
(2, 'CM', 'Ken', 2, 'ken_cm', '123', 54946051, 'ken_CM@gmail.com', 1),
(3, 'WM', 'Ken', 3, 'ken_wm', '123', 54946051, 'ken_wm@gmail.com', 1),
(4, 'PM', 'Ken', 4, 'ken_pm', '123', 54946051, 'ken_pm@gmail.com', 1),
(5, 'SM', 'Ken', 5, 'ken_sm', '123', 54946051, 'ken_sm@gmail.com', 1),
(6, 'DM', 'Ken', 6, 'ken_dm', '123', 54946051, 'ken_dm@gmail.com', 1),
(7, 'AM', 'Ken', 7, 'ken_am', '123', 54946051, 'ken_am@gmail.com', 1),
(8, 'Dealer', 'ken', 8, 'ken_dealer', '123', 47939237, 'ken_dealer@gmail.com', 1),
(9, 'SM2', 'Ken', 5, 'ken_sm2', '123', 54946052, 'ken_sm2@gmail.com', 1);

-- --------------------------------------------------------

--
-- 資料表結構 `vehicle`
--

DROP TABLE IF EXISTS `vehicle`;
CREATE TABLE IF NOT EXISTS `vehicle` (
  `vehicle_id` int NOT NULL AUTO_INCREMENT,
  `type` varchar(255) NOT NULL,
  PRIMARY KEY (`vehicle_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- 資料表新增資料前，先清除舊資料 `vehicle`
--

TRUNCATE TABLE `vehicle`;
--
-- 傾印資料表的資料 `vehicle`
--

INSERT INTO `vehicle` (`vehicle_id`, `type`) VALUES
(1, 'Car'),
(2, 'Truck'),
(3, 'Ship');

-- --------------------------------------------------------

--
-- 資料表結構 `warehouse`
--

DROP TABLE IF EXISTS `warehouse`;
CREATE TABLE IF NOT EXISTS `warehouse` (
  `warehouse_id` int NOT NULL AUTO_INCREMENT,
  `warehouse_name` varchar(255) NOT NULL,
  `phone` int NOT NULL,
  PRIMARY KEY (`warehouse_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- 資料表新增資料前，先清除舊資料 `warehouse`
--

TRUNCATE TABLE `warehouse`;
--
-- 傾印資料表的資料 `warehouse`
--

INSERT INTO `warehouse` (`warehouse_id`, `warehouse_name`, `phone`) VALUES
(1, 'shen zhen', 12313212);

-- --------------------------------------------------------

--
-- 資料表結構 `warehouse_item`
--

DROP TABLE IF EXISTS `warehouse_item`;
CREATE TABLE IF NOT EXISTS `warehouse_item` (
  `item_id` int NOT NULL,
  `warehouse_id` int NOT NULL,
  `quantity` int NOT NULL,
  PRIMARY KEY (`item_id`,`warehouse_id`),
  KEY `warehouse_id` (`warehouse_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- 資料表新增資料前，先清除舊資料 `warehouse_item`
--

TRUNCATE TABLE `warehouse_item`;
--
-- 傾印資料表的資料 `warehouse_item`
--

INSERT INTO `warehouse_item` (`item_id`, `warehouse_id`, `quantity`) VALUES
(1, 1, 6000),
(2, 1, 2500),
(3, 1, 1500),
(4, 1, 600),
(5, 1, 2000),
(7, 1, 2500),
(8, 1, 3000);

--
-- 已傾印資料表的限制式
--

--
-- 資料表的限制式 `cancel_order`
--
ALTER TABLE `cancel_order`
  ADD CONSTRAINT `cancel_order_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `user` (`user_id`);

--
-- 資料表的限制式 `item`
--
ALTER TABLE `item`
  ADD CONSTRAINT `item_ibfk_1` FOREIGN KEY (`supplier_id`) REFERENCES `supplier` (`supplier_id`);

--
-- 資料表的限制式 `user`
--
ALTER TABLE `user`
  ADD CONSTRAINT `user_ibfk_1` FOREIGN KEY (`role_id`) REFERENCES `role` (`role_id`);

--
-- 資料表的限制式 `warehouse_item`
--
ALTER TABLE `warehouse_item`
  ADD CONSTRAINT `warehouse_item_ibfk_1` FOREIGN KEY (`item_id`) REFERENCES `item` (`item_id`),
  ADD CONSTRAINT `warehouse_item_ibfk_2` FOREIGN KEY (`warehouse_id`) REFERENCES `warehouse` (`warehouse_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
