-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 05, 2022 at 03:10 PM
-- Server version: 10.4.25-MariaDB
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `rosehill`
--
CREATE DATABASE IF NOT EXISTS `rosehill` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `rosehill`;

-- --------------------------------------------------------

--
-- Table structure for table `labeltech`
--

DROP TABLE IF EXISTS `labeltech`;
CREATE TABLE `labeltech` (
  `lbl_ID` int(11) NOT NULL,
  `name` varchar(50) NOT NULL DEFAULT '''Label Technician''',
  `userID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `order`
--

DROP TABLE IF EXISTS `order`;
CREATE TABLE `order` (
  `order_ID` int(11) NOT NULL,
  `orderNum` varchar(20) NOT NULL,
  `orderDate` date NOT NULL,
  `lbl_ID` int(11) NOT NULL,
  `orderTech_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `orderdetails`
--

DROP TABLE IF EXISTS `orderdetails`;
CREATE TABLE `orderdetails` (
  `product_ID` int(11) NOT NULL,
  `order_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `ordertech`
--

DROP TABLE IF EXISTS `ordertech`;
CREATE TABLE `ordertech` (
  `orderTech_ID` int(11) NOT NULL,
  `name` varchar(50) NOT NULL DEFAULT '''Order Technician''',
  `userID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `packaging`
--

DROP TABLE IF EXISTS `packaging`;
CREATE TABLE `packaging` (
  `packaging_ID` int(11) NOT NULL,
  `name` varchar(50) NOT NULL DEFAULT '''Packaging''',
  `userID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

DROP TABLE IF EXISTS `product`;
CREATE TABLE `product` (
  `product_ID` int(11) NOT NULL,
  `productLotNum` varchar(20) NOT NULL,
  `productCode` varchar(20) NOT NULL,
  `productName` varchar(150) NOT NULL,
  `productQTY` int(100) NOT NULL,
  `size` varchar(100) NOT NULL,
  `category` enum('SAUCE','GRAVY','SOUP','MARINADES','SEASONING','BOUILLON','PLAIN','COLORED','OTHER') NOT NULL,
  `minToReorder` int(50) NOT NULL,
  `prodLocation` varchar(50) DEFAULT NULL,
  `productType` enum('PRIVATE','RH','OTHER') NOT NULL,
  `productStatus` enum('ACTIVE','DISCONTINUED') NOT NULL,
  `dateAdded` date NOT NULL,
  `lastUpdated` date DEFAULT NULL,
  `inventoryStatus` enum('In Stock','Out of Stock') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`product_ID`, `productLotNum`, `productCode`, `productName`, `productQTY`, `size`, `category`, `minToReorder`, `prodLocation`, `productType`, `productStatus`, `dateAdded`, `lastUpdated`, `inventoryStatus`) VALUES
(1, 'A1', '1', 'GENERIC WHITE LABEL FOR DRUM TEAR PROF', 10, '4\" x 6\"', 'PLAIN', 5, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(2, 'A1', '2', 'GENERIC WHITE', 10, '2 1/8\" x 5 3/16\"', 'PLAIN', 50, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(3, 'A1', '3', 'GENERIC WHITE SMALL ROLL EXP DATE', 10, '1 1/2\" x 1/2\"', 'PLAIN', 5, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(4, 'A1', '4', 'GENERIC WHITE (ONE SMALL/ROLL)', 10, '0.75\" x 1.5\"', 'PLAIN', 10, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(5, 'A1', '5', 'GENERIC WHITE', 10, '6 3/8\" x 91/2\"', 'PLAIN', 5, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(6, 'A1', '6', 'GENERIC WHITE (5 \" HIGH)', 10, '5\" x 4\"', 'PLAIN', 50, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(7, 'A1', '7', 'GENERIC WHITE (JV ,JTT CASE)', 10, '1 5\'/8\' x 4\"', 'PLAIN', 5, NULL, 'PRIVATE', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(8, 'A1', '8', 'GENERIC WHITE (ADONIS FALAFEL CASE)', 10, '1\"7/8 x 3\"', 'PLAIN', 2, NULL, 'PRIVATE', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(9, 'A1', '9', 'GENERIC WHITE', 10, '3\" x 3\"', 'PLAIN', 3, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(10, 'A1', '10', 'GENERIC WHITE', 10, '4\" x 4\"', 'PLAIN', 3, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(11, 'A1', '11', 'GENERIC WHITE (4 \" HIGH)', 10, '4\" x 3\" ', 'PLAIN', 50, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(12, 'A1', '12', 'GENERIC WHITE', 10, '3 1/8\" x 6\"', 'PLAIN', 50, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(13, 'A1', '13', 'GENERIC WHITE', 10, '4\" x 8\"', 'PLAIN', 5, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(14, 'A1', '14', 'GENERIC WHITE TEAR PROOF FOR MARINADE', 10, '5\" x 4\"', 'PLAIN', 2, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(15, 'A1', '15', 'BLUE', 10, '3 1/8\" x 6\"', 'COLORED', 1, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(16, 'A1', '16', 'GREEN', 10, '3 1/8\" x 6\"', 'COLORED', 1, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(17, 'A1', '17', 'ORANGE LIGHT', 10, '3 1/8\" x 6\"', 'COLORED', 1, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(18, 'A1', '18', 'RED', 10, '3 1/8\" x 6\"', 'COLORED', 1, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(19, 'A1', '19', 'YELLOW', 10, '3 1/8\" x 6\"', 'COLORED', 1, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(20, 'A1', '20', 'GREY', 10, '3 1/8\" x 6\"', 'COLORED', 1, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(21, 'A1', '21', 'BLUE /GREY', 10, '3 1/8\" x 6\"', 'COLORED', 1, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(22, 'A1', '22', 'PURPLE', 10, '3 1/8\" x 6\"', 'COLORED', 1, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(23, 'A1', '23', 'LIGHT PURPLE', 10, '3 1/8\" x 6\"', 'COLORED', 1, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(24, 'A1', '24', 'LIGHT PINK ', 10, '3 1/8\" x 6\"', 'COLORED', 1, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(25, 'A1', '25', 'BEIGE', 10, '3 1/8\" x 6\"', 'COLORED', 1, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(26, 'A1', '26', 'LIGHT GRAY', 10, '3 1/8\" x 6\"', 'COLORED', 1, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(27, 'A1', '27', 'LIGHT  LIME', 10, '3 1/8\" x 6\"', 'COLORED', 1, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(28, 'A1', '28', 'LIGHT BLUE ', 10, '3 1/8\" x 6\"', 'COLORED', 1, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(29, 'A1', '29', 'DARK PINK', 10, '3 1/8\" x 6\"', 'COLORED', 1, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(30, 'A1', '30', 'DARK YELLOW', 10, '3 1/8\" x 6\"', 'COLORED', 1, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(31, 'A1', '31', 'DARK ORANGE', 10, '3 1/8\" x 6\"', 'COLORED', 1, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(32, 'A1', '32', 'YELLOW (MUSTARD)', 10, '3 1/8\" x 6\"', 'COLORED', 1, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(33, 'A1', '33', 'PEACH DARK', 10, '3 1/8\" x 6\"', 'COLORED', 1, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(34, 'A1', '34', 'GREEN (blue tint)', 10, '3 1/8\" x 6\"', 'COLORED', 1, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(35, 'A1', '35', 'PEACH LIGHT', 10, '3 1/8\" x 6\"', 'COLORED', 1, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(36, 'A1', '36', 'LAVANDER LIGHT', 10, '3 1/8\" x 6\"', 'COLORED', 1, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(37, 'A1', '37', 'LEMON LIGHT', 10, '3 1/8\" x 6\"', 'COLORED', 1, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(38, 'A1', '38', 'NUTR.VALUE BASILE tear proof', 10, '2 1/4\" x 51/4\"', 'COLORED', 1, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(39, 'A1', '39', 'ROSEHILL -001 GREEN BANER', 10, '2 1/8\" x 5 3/16\"', 'PLAIN', 40, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(40, 'A1', '40', 'ROSEHILL -001 ORANGE  BANER', 10, '2 1/8\" x 5 3/16\"', 'PLAIN', 5, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(41, 'A1', '41', 'ROSEHILL- 002 GREEN BANER', 10, '3 7/8\" x 3 7/8\"', 'PLAIN', 20, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(42, 'A1', '42', 'ROSEHILL-SAMPLE 3/4 green SPICE', 10, '3\" x 4\"', 'PLAIN', 2, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(43, 'A1', '43', 'ROSEHILL- SAMPLE 3/4 pink SOUP', 10, '3\" x 4\"', 'PLAIN', 2, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(44, 'A1', '44', 'ROSEHILL-SAMPLE 3/4 orange SAUCE', 10, '3\" x 4\"', 'PLAIN', 2, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(45, 'A1', '45', 'ROSEHILL-RH 54 GREEN SPICE', 10, '3\" x 4\"', 'PLAIN', 2, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(46, 'A1', '46', 'ROSEHILL- RH54 PINK SOUP', 10, '3\" x 4\"', 'PLAIN', 2, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(47, 'A1', '47', 'ROSEHILL-RH54 ORANGE SAUCE', 10, '3\" x 4\"', 'PLAIN', 2, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(48, 'A1', '48', 'ROSEHILL-048 GREEN', 10, '2 1/8\" x 7\"', 'PLAIN', 2, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(49, 'A1', '49', 'ROSEHILL-008 GREEN SPICE', 10, '5 \" x 9 1/2 \"', 'PLAIN', 10, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(50, 'A1', '50', 'ROSEHILL-008 PINK SOUP', 10, '5 \" x 9 1/2 \"', 'PLAIN', 10, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(51, 'A1', '51', 'ROSEHILL-008 ORANGE SAUCE', 10, '5 \" x 9 1/2 \"', 'PLAIN', 10, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(52, 'A1', '52', 'RED  YELLOW GENERIC ', 10, '4 3/4\" x 8 1/8 \"', 'PLAIN', 40, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(53, 'A1', '53', 'RED  YELLOW GENERIC', 10, '2 1/8\" x 5 3/16\"', 'PLAIN', 10, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(54, 'A1', '54', 'RED  YELLOW GENERIC', 10, '4\" x 4\"', 'PLAIN', 5, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(55, 'A1', '55', 'ROSE HILL FISH BOUILLON MIX 1 kg', 10, '5 1/8\" x 14 3/4\"', 'BOUILLON', 1, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(56, 'A1', '56', 'ROSE HILL VEGETABLE BOUILLON MIX 1 KG', 10, '5 1/8\" x 14 3/4\"', 'BOUILLON', 1, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(57, 'A1', '57', 'ROSE HILL CHICKEN BOUILLON MIX 1 KG', 10, '5 1/8\" x 14 3/4\"', 'BOUILLON', 1, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(58, 'A1', '58', 'ROSE HILL BEEF BOUILLON MIX 1 kg', 10, '5 1/8\" x 14 3/4\"', 'BOUILLON', 1, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(59, 'A1', '59', 'ROSEHILL PLAIN CULINARY DELIGHT', 10, '9\" x 5\"', 'PLAIN', 2, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(60, 'A1', '60', 'ALFREDO', 10, '15\'\' x 5\'', 'SAUCE', 2, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(61, 'A1', '61', '3 POIVRES', 10, '15\'\' x 5\'', 'SAUCE', 2, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(62, 'A1', '62', 'DEMI-GLACE', 10, '15\'\' x 5\"', 'SAUCE', 2, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(63, 'A1', '63', 'HOLLANDAISE', 10, '15\'\' x 5 \"', 'SAUCE', 10, NULL, 'RH', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(64, 'A1', '64', 'RH CHOIX SANTE -HEALTHY CHOICE - BEEF SOUP BASE 20 KG', 10, '9\" x 5\"', 'SOUP', 1, NULL, 'PRIVATE', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(65, 'A1', '65', 'RH CHOIX SANTE -HEALTHY CHOICE - BEEF SOUP BASE 18 KG', 10, '9\" x 5\"', 'SOUP', 1, NULL, 'PRIVATE', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(66, 'A1', '66', 'RH CHOIX SANTE -HEALTHY CHOICE - CHICKEN SOUP BASE 20 KG', 10, '9\" x 5\"', 'SOUP', 1, NULL, 'PRIVATE', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(67, 'A1', '67', 'RH CHOIX SANTE -HEALTHY CHOICE - BBQ SAUCE 18 KG', 10, '9\" x 5\"', 'SAUCE', 1, NULL, 'PRIVATE', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(68, 'A1', '68', 'RH CHOIX SANTE -HEALTHY CHOICE - HOT CHICKEN SAUCE 18 KG', 10, '9\" x 5\"', 'SAUCE', 1, NULL, 'PRIVATE', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(69, 'A1', '69', 'RH CHOIX SANTE -HEALTHY CHOICE - BEEF SOUP BASE 5 kg', 10, '9\" x 5\"', 'SOUP', 1, NULL, 'PRIVATE', 'ACTIVE', '2022-12-03', NULL, 'In Stock'),
(70, 'A1', '70', 'RH CHOIX SANTE -HEALTHY CHOICE - CHICKEN SOUP BASE 5 kg', 10, '9\" x 5\"', 'SOUP', 1, NULL, 'PRIVATE', 'ACTIVE', '2022-12-03', NULL, 'In Stock');

-- --------------------------------------------------------

--
-- Table structure for table `report`
--

DROP TABLE IF EXISTS `report`;
CREATE TABLE `report` (
  `report_ID` int(11) NOT NULL,
  `description` varchar(200) DEFAULT NULL,
  `dateCreated` date NOT NULL,
  `orderTech` int(11) NOT NULL,
  `lbl_ID` int(11) NOT NULL,
  `order_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `shipping`
--

DROP TABLE IF EXISTS `shipping`;
CREATE TABLE `shipping` (
  `shipping_ID` int(11) NOT NULL,
  `name` varchar(50) NOT NULL DEFAULT '''Shipping''',
  `userID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
CREATE TABLE `user` (
  `userID` int(11) NOT NULL,
  `userName` varchar(50) NOT NULL,
  `password` varchar(20) NOT NULL,
  `role` enum('Label Technician','Order Technician','Shipping','Packaging') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `labeltech`
--
ALTER TABLE `labeltech`
  ADD PRIMARY KEY (`lbl_ID`),
  ADD KEY `labelTech_to_user` (`userID`);

--
-- Indexes for table `order`
--
ALTER TABLE `order`
  ADD PRIMARY KEY (`order_ID`),
  ADD KEY `order_to_labeltech` (`lbl_ID`),
  ADD KEY `order_to_ordertech` (`orderTech_ID`);

--
-- Indexes for table `orderdetails`
--
ALTER TABLE `orderdetails`
  ADD KEY `orderDetails_to_order` (`order_ID`),
  ADD KEY `orderDetails_to_product` (`product_ID`);

--
-- Indexes for table `ordertech`
--
ALTER TABLE `ordertech`
  ADD PRIMARY KEY (`orderTech_ID`),
  ADD KEY `orderTech_to_user` (`userID`);

--
-- Indexes for table `packaging`
--
ALTER TABLE `packaging`
  ADD PRIMARY KEY (`packaging_ID`),
  ADD KEY `packaging_to_user` (`userID`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`product_ID`),
  ADD UNIQUE KEY `productCode` (`productCode`);

--
-- Indexes for table `report`
--
ALTER TABLE `report`
  ADD PRIMARY KEY (`report_ID`),
  ADD KEY `report_to_labeltech` (`lbl_ID`),
  ADD KEY `report_to_order` (`order_ID`),
  ADD KEY `report_to_ordertech` (`orderTech`);

--
-- Indexes for table `shipping`
--
ALTER TABLE `shipping`
  ADD PRIMARY KEY (`shipping_ID`),
  ADD KEY `shipping_to_user` (`userID`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`userID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `labeltech`
--
ALTER TABLE `labeltech`
  MODIFY `lbl_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `order`
--
ALTER TABLE `order`
  MODIFY `order_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `ordertech`
--
ALTER TABLE `ordertech`
  MODIFY `orderTech_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `packaging`
--
ALTER TABLE `packaging`
  MODIFY `packaging_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `product`
--
ALTER TABLE `product`
  MODIFY `product_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=71;

--
-- AUTO_INCREMENT for table `report`
--
ALTER TABLE `report`
  MODIFY `report_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `shipping`
--
ALTER TABLE `shipping`
  MODIFY `shipping_ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `userID` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `labeltech`
--
ALTER TABLE `labeltech`
  ADD CONSTRAINT `labelTech_to_user` FOREIGN KEY (`userID`) REFERENCES `user` (`userID`);

--
-- Constraints for table `order`
--
ALTER TABLE `order`
  ADD CONSTRAINT `order_to_labeltech` FOREIGN KEY (`lbl_ID`) REFERENCES `labeltech` (`lbl_ID`),
  ADD CONSTRAINT `order_to_ordertech` FOREIGN KEY (`orderTech_ID`) REFERENCES `ordertech` (`orderTech_ID`);

--
-- Constraints for table `orderdetails`
--
ALTER TABLE `orderdetails`
  ADD CONSTRAINT `orderDetails_to_order` FOREIGN KEY (`order_ID`) REFERENCES `order` (`order_ID`),
  ADD CONSTRAINT `orderDetails_to_product` FOREIGN KEY (`product_ID`) REFERENCES `product` (`product_ID`);

--
-- Constraints for table `ordertech`
--
ALTER TABLE `ordertech`
  ADD CONSTRAINT `orderTech_to_user` FOREIGN KEY (`userID`) REFERENCES `user` (`userID`);

--
-- Constraints for table `packaging`
--
ALTER TABLE `packaging`
  ADD CONSTRAINT `packaging_to_user` FOREIGN KEY (`userID`) REFERENCES `user` (`userID`);

--
-- Constraints for table `report`
--
ALTER TABLE `report`
  ADD CONSTRAINT `report_to_labeltech` FOREIGN KEY (`lbl_ID`) REFERENCES `labeltech` (`lbl_ID`),
  ADD CONSTRAINT `report_to_order` FOREIGN KEY (`order_ID`) REFERENCES `order` (`order_ID`),
  ADD CONSTRAINT `report_to_ordertech` FOREIGN KEY (`orderTech`) REFERENCES `ordertech` (`orderTech_ID`);

--
-- Constraints for table `shipping`
--
ALTER TABLE `shipping`
  ADD CONSTRAINT `shipping_to_user` FOREIGN KEY (`userID`) REFERENCES `user` (`userID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
