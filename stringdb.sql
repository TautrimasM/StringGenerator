-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 04, 2023 at 08:53 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `stringdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `stringtable`
--

CREATE TABLE `stringtable` (
  `ID` int(11) NOT NULL,
  `ThreadID` int(11) DEFAULT NULL,
  `Time` datetime DEFAULT NULL,
  `Data` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `stringtable`
--

INSERT INTO `stringtable` (`ID`, `ThreadID`, `Time`, `Data`) VALUES
(1, 1, '2023-10-04 21:19:13', 'uVJr12'),
(2, 2, '2023-10-04 21:19:13', 'xx8tOPpPp'),
(3, 1, '2023-10-04 21:19:14', 'sn+BlY++v'),
(4, 2, '2023-10-04 21:19:14', 'cWI0fW'),
(5, 1, '2023-10-04 21:19:14', 'wYcke0'),
(6, 1, '2023-10-04 21:19:15', '8dWZ'),
(7, 2, '2023-10-04 21:34:02', 'xWCOKB'),
(8, 2, '2023-10-04 21:34:02', 'XBxpvYdK'),
(9, 2, '2023-10-04 21:34:03', 'YT+yyOh9'),
(10, 1, '2023-10-04 21:38:00', 'ny2nG'),
(11, 2, '2023-10-04 21:38:00', 'NA/7Za5fv'),
(12, 2, '2023-10-04 21:38:02', 'V7DI'),
(13, 1, '2023-10-04 21:38:02', 'TbNWBA'),
(14, 2, '2023-10-04 21:38:03', 'ozfkiQ'),
(15, 1, '2023-10-04 21:38:03', '/LPtX'),
(16, 2, '2023-10-04 21:38:04', '7HZs'),
(17, 1, '2023-10-04 21:38:04', 'zyezgLE4B'),
(18, 1, '2023-10-04 21:38:05', 'lN6oPJ'),
(19, 1, '2023-10-04 21:38:06', 'V3C2EB'),
(20, 2, '2023-10-04 21:38:06', '3sjdpdQ2'),
(21, 3, '2023-10-04 21:38:06', '50sdMND'),
(22, 4, '2023-10-04 21:38:06', 'HUPZMo8'),
(23, 1, '2023-10-04 21:38:06', 'y9tYO1'),
(24, 1, '2023-10-04 21:38:07', 'iiuZl9s5r'),
(25, 1, '2023-10-04 21:38:07', '8XF8bEN'),
(26, 2, '2023-10-04 21:38:08', 'EEd1'),
(27, 1, '2023-10-04 21:38:08', 'px8cPEqWz'),
(28, 4, '2023-10-04 21:38:08', 'ckKz'),
(29, 3, '2023-10-04 21:38:08', '2ZLM'),
(30, 2, '2023-10-04 21:38:08', 'GHdeg85xo'),
(31, 3, '2023-10-04 21:38:55', 'Wyi2miT'),
(32, 5, '2023-10-04 21:38:55', '1ILTcD'),
(33, 4, '2023-10-04 21:38:55', 'AfrfW5+'),
(34, 2, '2023-10-04 21:38:55', '/LBIY23'),
(35, 1, '2023-10-04 21:38:55', 't4Vau4VZ'),
(36, 2, '2023-10-04 21:38:56', 'Rken'),
(37, 3, '2023-10-04 21:38:56', 'eM2UL'),
(38, 4, '2023-10-04 21:38:57', 'r9NoFBUo'),
(39, 2, '2023-10-04 21:38:57', 'Ycdir'),
(40, 5, '2023-10-04 21:38:57', 'A89FNJZ++'),
(41, 1, '2023-10-04 21:38:57', 'CAudEY'),
(42, 3, '2023-10-04 21:38:58', 'gUfMOXFv'),
(43, 1, '2023-10-04 21:38:58', 'F7uj'),
(44, 5, '2023-10-04 21:38:58', '5RYKb'),
(45, 4, '2023-10-04 21:38:58', '3LxZ'),
(46, 2, '2023-10-04 21:38:58', 'SO6z9/'),
(47, 5, '2023-10-04 21:38:59', 'cgwNhOL'),
(48, 1, '2023-10-04 21:38:59', 'Rqcs'),
(49, 2, '2023-10-04 21:38:59', 'LYd3'),
(50, 4, '2023-10-04 21:38:59', 'dZYgUgAl/'),
(51, 3, '2023-10-04 21:39:00', 'AZ62t'),
(52, 2, '2023-10-04 21:39:00', 'XczI+ucI'),
(53, 5, '2023-10-04 21:39:00', 'BavL'),
(54, 1, '2023-10-04 21:39:00', 'cP0U/tcV'),
(55, 3, '2023-10-04 21:39:00', '2DudmUQZ'),
(56, 4, '2023-10-04 21:39:01', 'r02fvXa'),
(57, 2, '2023-10-04 21:39:01', 'ww2A'),
(58, 1, '2023-10-04 21:39:02', 'e+7uoi0nZ'),
(59, 5, '2023-10-04 21:39:02', 'OO+T'),
(60, 3, '2023-10-04 21:39:02', '10TZ'),
(61, 4, '2023-10-04 21:39:02', 'xsvQ0j'),
(62, 2, '2023-10-04 21:39:03', 'bqGmW'),
(63, 5, '2023-10-04 21:39:03', 'i1vpi1JuO'),
(64, 4, '2023-10-04 21:39:03', 'kxqCA'),
(65, 3, '2023-10-04 21:39:03', 'gYCzkJ1'),
(66, 5, '2023-10-04 21:39:03', 'F8Gpp1'),
(67, 1, '2023-10-04 21:39:04', '+YZWN'),
(68, 3, '2023-10-04 21:39:04', 'RANZTNAAy'),
(69, 4, '2023-10-04 21:39:04', 'wJCtVaK'),
(70, 2, '2023-10-04 21:39:04', 'xxigrBs'),
(71, 5, '2023-10-04 21:39:04', 'RHdX'),
(72, 1, '2023-10-04 21:39:05', '05Gk'),
(73, 3, '2023-10-04 21:39:05', 'lvjZ'),
(74, 5, '2023-10-04 21:39:05', 'vQW85ud'),
(75, 2, '2023-10-04 21:39:06', 'hMYbuH'),
(76, 1, '2023-10-04 21:39:06', '7Iy4'),
(77, 4, '2023-10-04 21:39:06', 'F4lnv'),
(78, 2, '2023-10-04 21:43:27', 'nDDw'),
(79, 1, '2023-10-04 21:43:27', 'NWFnst'),
(80, 2, '2023-10-04 21:43:28', 'qCotkj6M'),
(81, 2, '2023-10-04 21:43:28', 'b7T1'),
(82, 1, '2023-10-04 21:43:28', 'EBF/VUB'),
(83, 2, '2023-10-04 21:43:29', 'k81fKa');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `stringtable`
--
ALTER TABLE `stringtable`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `stringtable`
--
ALTER TABLE `stringtable`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=84;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
