-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 07, 2020 at 06:53 PM
-- Server version: 10.1.38-MariaDB
-- PHP Version: 7.3.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `fp_db_nrhr`
--

-- --------------------------------------------------------

--
-- Table structure for table `bank`
--

CREATE TABLE `bank` (
  `ID` int(50) NOT NULL,
  `Name` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bank`
--

INSERT INTO `bank` (`ID`, `Name`) VALUES
(1, 'tes'),
(2, 'BNI'),
(3, 'BCA');

-- --------------------------------------------------------

--
-- Table structure for table `branch`
--

CREATE TABLE `branch` (
  `ID` int(50) NOT NULL,
  `Name` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `branch`
--

INSERT INTO `branch` (`ID`, `Name`) VALUES
(1, 'Pusat'),
(2, 'STAR'),
(3, 'Sempurna'),
(4, 'Star');

-- --------------------------------------------------------

--
-- Table structure for table `contracttype`
--

CREATE TABLE `contracttype` (
  `ID` int(50) NOT NULL,
  `Name` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `contracttype`
--

INSERT INTO `contracttype` (`ID`, `Name`) VALUES
(1, 'Kontrak I'),
(2, 'Permanent'),
(3, 'Probation'),
(4, 'Kontrak II'),
(5, 'Magang'),
(6, 'PKL');

-- --------------------------------------------------------

--
-- Table structure for table `department`
--

CREATE TABLE `department` (
  `ID` int(50) NOT NULL,
  `Name` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `department`
--

INSERT INTO `department` (`ID`, `Name`) VALUES
(1, 'Sempurna Store'),
(2, 'Offset'),
(3, 'Star Store'),
(4, 'Store'),
(5, 'Finance & Accounting'),
(6, 'Sales'),
(7, 'IT'),
(8, 'HRD'),
(9, 'Marketing');

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `NIK` int(40) NOT NULL,
  `Fullname` varchar(255) DEFAULT NULL,
  `Nickname` varchar(255) DEFAULT NULL,
  `KTP` varchar(50) DEFAULT NULL,
  `Jamsostek` varchar(255) DEFAULT NULL,
  `BankID` int(10) DEFAULT NULL,
  `Rekening` varchar(50) DEFAULT NULL,
  `NPWP` varchar(50) DEFAULT NULL,
  `StatusPajak` varchar(15) DEFAULT NULL,
  `DOB` date DEFAULT NULL,
  `Gender` varchar(1) DEFAULT NULL,
  `Religion` varchar(50) DEFAULT NULL,
  `MaritalStatus` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`NIK`, `Fullname`, `Nickname`, `KTP`, `Jamsostek`, `BankID`, `Rekening`, `NPWP`, `StatusPajak`, `DOB`, `Gender`, `Religion`, `MaritalStatus`) VALUES
(123123, 'test', 'test', '12312', 'test', 1, '123123', '12312', 'test', '2020-01-06', 'M', 'test', 'test'),
(19940601, 'Suratman', 'Suratman', '33.2612.071172.0006', '09020655859', 3, '3010040956', '-', 'K3', '0000-00-00', 'L', 'Islam', 'Menikah'),
(19950801, 'Sholihudin Rianto', 'Rianto', '31.7305.150672.0014', '09020655396', 2, '252919899', '-', 'K3', '0000-00-00', 'L', 'Islam', 'Menikah'),
(19970101, 'Mansur Hadi', 'Mansur', '32.7606.060376.0008', '09020655842', 3, '3010039672', '-', 'K2', '0000-00-00', 'L', 'Islam', 'Menikah'),
(19990301, 'Maryanto', 'Yanto', '36.7113.080970.0009', '09020655826', 3, '4768094703', '-', 'K1', '0000-00-00', 'L', 'Islam', 'Menikah'),
(19990601, 'Yana Wijaya', 'Yana', '31.7107.240974.0002', '09020655412', 2, '252917950', '66.959.200.8-077.000', 'K2', '0000-00-00', 'L', 'Islam', 'Menikah'),
(19990801, 'Casminto B. Daud', 'Minto', '31.7107.040179.0012', '09020655420', 2, '252904713', '80.473.001.8-077.000', 'K2', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20000801, 'Steven Hovianto', 'Steven', '31.7305.040463.0010', '09020655446', 2, '252936870', '68.434.773.5-039.000', 'K1', '0000-00-00', 'L', 'Katholik', 'Menikah'),
(20010701, 'Sujianto', 'Suji', '33.1316.010776.0041', '09020655453', 2, '252921161', '-', 'K1', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20020501, 'Tugimin', 'Parmin', '33.1316.060482.0004', '09020655461', 2, '253016580', '76.874.892.3-528.000', 'K1', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20020901, 'Hendy Triyanto', 'Hendy', '33.1809.260679.0002', '09020655800', 3, '3010040948', '-', 'K3', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20021201, 'Suhanda', 'Ganda', '31.7107.120963.0004', '09020655487', 2, '252889830', '76.547.547.0-077.000', 'K4', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20021202, 'Rasam', 'Rasam', '33.0213.080473.0002', '09020655784', 3, '3010042380', '-', 'K3', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20030401, 'Sukidi', 'Sukidi', '36.7103.030275.0002', '09020655495', 2, '252919130', '80.152.496.8-443.000', 'K3', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20030601, 'Iwan Darmawan', 'Iwan', '32.0509.280278.0001', '09020655511', 2, '252920644', '80.548.939.0-443.000', 'K3', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20040501, 'Abdul Mukmin Susminto', 'Mukminto', '33.2702.211177.0004', '09020655529', 2, '252983004', '83.497.842.1-502.000', 'K2', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20050101, 'Sawin Endin Suhartono', 'Sawin', '31.7404.180667.0003', '09020655750', 3, '3010040352', '-', 'K3', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20050102, 'Anang Sumarna', 'Anang', '31.7102.160572.0006', '09020655537', 2, '252921092', '80.291.654.4-075.000', 'K2', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20050103, 'Bambang Rahino', 'Bambang', '33.2705.021187.0004', '09020655891', 2, '252911459', '83.483.188.5-502.000', 'K1', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20050301, 'Chaerul Bari Yawan', 'Chaerul', '31.7305.200375.0012', '09020655545', 2, '252891544', '80.038.396.0-035.000', 'K0', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20051101, 'Heriyanto', 'Yanto', '31.7302.200379.0010', '09020655552', 2, '252921762', '80.429.891.7-077.000', 'K2', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20060103, 'Simun', 'Simun', '33.0119.190672.0001', '09020655578', 2, '252890459', '76.834.584.5-522.000', 'K2', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20060801, 'Alimin', 'Alimin', '33.27082.50773.0001', '09020655586', 2, '252896053', '73.876.784.7-502.000', 'K2', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20061101, 'Ahmad Yani', 'Yani', '31.7107.020381.0005', '09020655594', 2, '252934421', '70.069.592.7-077.000', 'K4', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20070201, 'Sun Oh', 'Asun', '32.7610.080870.0001', '09020655610', 2, '252945321', '70.235.796.3-412.000', 'K3', '0000-00-00', 'L', 'Konghucu', 'Menikah'),
(20070202, 'Sukma Aditia', 'Adit', '32.7610.151079.0002', '09020655628', 2, '252936315', '66.985.881.3-412.000', 'K2', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20070203, 'Tono Saputro', 'Tono', '31.7410.040477.0016', '09020655636', 2, '252901531', '44.846.331.5-013.000', 'K2', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20070503, 'Agus Perdana', 'Agus', '31.7409.010877.0003', '09020655651', 2, '252918669', '76.881.294.3-017.000', 'K2', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20070601, 'Rahadian Yamin', 'Rahadian', '32.0125.151085.0002', '09020655958', 2, '252919968', '81.479.576.1-434.000', 'K1', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20070603, 'Widi Harindra Wisnu Bratadi', 'Widi', '32.7602.180378.0007', '09020656279', 3, '3010039664', '-', 'TK', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20070701, 'Ajat Sudrajat', 'Ajat', '32.0415.071287.0011', '09020655669', 2, '252918783', '80.325.671.8-077.000', 'K2', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20070702, 'Rohum Ramdan', 'Rohum', '32.7602.110189.0002', '09020655982', 2, '252889013', '76.651.816.1-412.000', 'K1', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20071202, 'Suryadi', 'Suryadi', '31.7401.100470.0008', '09020655685', 2, '252892399', '-', 'K0', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20080502, 'Rismanto', 'Risman', '33.0204.170885.0002', '09020656048', 2, '1505666662', '80.161.972.7-501.000', 'K1', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20080605, 'Suningsih', 'Ningsih', '31.7107.520788.0001', '09020656113', 2, '252940366', '80.182.025.9-072.000', 'TK', '0000-00-00', 'P', 'Islam', 'Single'),
(20080701, 'Deasy Natalia', 'Deasy', '31.7302.641284.0005', '07004253220', 2, '252882110', '58.083.263.2-036.000', 'K2', '0000-00-00', 'P', 'Katholik', 'Menikah'),
(20080702, 'Margi Widodo', 'Margi', '31.7305.090485.0009', '09020656154', 2, '252944644', '70.103.023.1-039.000', 'K2', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20080703, 'Misbah Hudin', 'Misbah', '32.0126.200690.0008', '09020656162', 2, '252919334', '80.050.196.7-434.000', 'K1', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20080802, 'Okti Triani', 'Okti', '33.0312.521087.0001', '09020656196', 2, '252894851', '47.206.901.2-529.000', 'K2', '0000-00-00', 'P', 'Islam', 'Menikah'),
(20081003, 'Dariyah', 'Ida', '31.7107.550587.0006', '09020656220', 2, '252937579', '-', 'K1', '0000-00-00', 'P', 'Islam', 'Menikah'),
(20090301, 'Komarudin', 'Komar', '32.7610.070873.0004', '11015839803', 2, '252917836', '-', 'K2', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20090310, 'Mohamad Iqbal', 'Iqbal', '31.7408.200681.0004', '10001058048', 2, '252906630', '-', 'K1', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20090502, 'Aenurofik', 'Ofik', '33.2708.031286.0063', '11015839829', 2, '252979406', '81.865.091.3-039.000', 'K1', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20090601, 'Fauzi', 'Fauzi', '31.7202.160484.0005', '11030137449', 2, '252992687', '80.534.072.6.-042.000', 'TK', '0000-00-00', 'L', 'Islam', 'Single'),
(20091004, 'Sorani Zalukhu', 'Rani', '31.7404.550577.0008', '08018810476', 2, '1505197790', '54.736.905.8-017.000', 'K4', '0000-00-00', 'P', 'Kristen', 'Menikah'),
(20091101, 'Jeffri', 'Jeffri', '31.7302.031182.0006', '10010274180', 2, '400011393', '67.823.367.7-213.000', 'K1', '0000-00-00', 'L', 'Budha', 'Menikah'),
(20100401, 'Pangestu Budiarto', 'Budi', '31.7510.171282.0010', '13001096901', 3, '3010039605', '76.819.612.3-009.000', 'K1', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20100406, 'Hadi Fahlevy', 'Hadi', '31.7503.141290.0005', '11015839845', 3, '3010040395', '74.932.456.2-002.000', 'K1', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20101101, 'Aris Febriyanto', 'Aris', '33.2612.180289.0001', '13001096893', 3, '3010040409', '-', 'TK', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20110302, 'Iin Solihin', 'Iin', '32.1404.150481.0004', '13016058102', 2, '400900018', '72.988.524.4-036.000', 'K1', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20110403, 'Pardi', 'Pardi', '33.1502.030490.0002', '13016058110', 2, '252908934', '80-426.871.2-514.000', 'TK', '0000-00-00', 'L', 'Islam', 'Single'),
(20110404, 'Gito Purnomo Warto', 'Purnomo', '31.7107.050776.0012', '15059294031', 3, '3010040417', '-', 'K2', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20110603, 'Iis Solihat', 'Iis', '32.0812.560690.0004', '13023981379', 3, '3010039524', '-', 'K0', '0000-00-00', 'P', 'Islam', 'Menikah'),
(20110702, 'Glenda Oding Saputra', 'Glenda', '31.7308.540187.0007', '13023981361', 2, '900400121', '73.240.569.1-035.000', 'K3', '0000-00-00', 'P', 'Islam', 'Menikah'),
(20110901, 'Ruswandi', 'Ruswan', '31.7305.200284.0005', '13034120405', 2, '252920372', '73.930.756.9-039.000', 'TK0', '0000-00-00', 'L', 'Islam', 'Cerai'),
(20111006, 'Sumarno', 'Marno', '33.0220.311265.0056', '13034120447', 2, '252916865', '80.389.824.6-521.000', 'K2', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20120103, 'Abas Basuni', 'Abas', '31.7107.171081.0006', '14000717240', 2, '427782288', '70.850.116.8-072.000', 'K2', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20120104, 'Apri Santoso', 'Apri', '31.7501.180489.0004', '14000717257', 2, '252991718', '-', 'K1', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20120106, 'Hasanudin', 'Hasan', '32.0126.030587.0005', '14000717273', 2, '252918375', '80.369.244.1-434.000', 'K1', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20120107, 'Agus Firmansyah', 'Agus F.', '31.7102.080882.0009', '14000717281', 2, '252920543', '80.321.397.4-075.000', 'K2', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20120109, 'Ferry Misbachulmunir', 'Ferry', '32.0302.240169.0001', '14000717299', 2, '252920087', '76.331.679.1-406.000', 'K4', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20120201, 'Adi Bastiyan', 'Bastian', '33.0821.200993.0001', '14006801782', 3, '3010038421', '76.924.810.5-077.000', 'TK', '0000-00-00', 'L', 'Islam', 'Single'),
(20120304, 'Eki Suhaeri', 'Eki', '31.7101.300190.0002', '14015843379', 2, '252993227', '-', 'K1', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20120305, 'Sintiya Almiati', 'Sintiya', '32.7508.520893.0010', '14015843387', 2, '252992280', '80.637.764.4-447.000', 'TK', '0000-00-00', 'P', 'Islam', 'Single'),
(20120306, 'Nurmaesaroh Hidayatulloh', 'Ayoh', '31.7508.450893.0006', '14011030492', 2, '395770808', '80.157.282.7-005.000', 'K0', '0000-00-00', 'P', 'Islam', 'Menikah'),
(20120702, 'Hasan Basri', 'Hasan', '31.7107.270377.0001', '14036565191', 3, '3010039591', '-', 'K1', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20120704, 'Sunano', 'Nano', '31.7406.161187.0007', '14036565225', 3, '3010040085', '-', 'TK', '0000-00-00', 'L', 'Islam', 'Single'),
(20120802, 'Giovanni Ferdinand T', 'Ferdinand', '09.5308.020580.7033', '14042087578', 2, '252880768', '70.018.049.0-061.000', 'K1', '0000-00-00', 'L', 'Kristen', 'Menikah'),
(20120804, 'Muchamad Jamhari', 'Ari', '31.7504.190588.0008', '14042088576', 3, '3010039630', '-', 'K2', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20120901, 'Edi Santoso', 'Edi', '31.7306.130580.0013', '09020655644', 2, '273204093', '-', 'K2', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20120902, 'Marzuki', 'Zuki', '31.7408.270971.0004', '14042087545', 2, '273365095', '76.626.977.3-061.000', 'K2', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20121002, 'Nisam Afianto', 'Nisam', '31.7410.100881.0011', '11007568220', 2, '261898754', '79.071.175.8-013.000', 'K2', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20121101, 'Miskun Prayoga', 'Paul', '33.0102.070175.0005', '14042088584', 2, '277453807', '76.834.587.8-522.000', 'K2', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20121102, 'Eri Setiawan', 'Eri', '31.7101.310792.0003', '15016837054', 2, '277452430', '-', 'TK', '0000-00-00', 'L', 'Islam', 'Single'),
(20121103, 'Dwi Rizky Julianto', 'Alwi', '35.7805.230790.0001', '14042088592', 2, '277455260', '-', 'K2', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20121201, 'Romli Adnan', 'Romli', '31.7409.170480.0006', '15004808620', 2, '280259780', '80.016.377.6-017.000', 'K1', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20121202, 'Zulfikri', 'Fikri', '31.7408.220685.0003', '15004808638', 2, '280260911', '79.482.756.8-061.000', 'K2', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20130102, 'Riky Anggoro', 'Riky', '33.0917.160494.9004', '15007354853', 2, '284933689', '-', 'TK', '0000-00-00', 'L', 'Islam', 'Single'),
(20130105, 'Ahmad Maulana', 'Maulana', '31.7305.151190.0001', '15007354861', 2, '284932325', '85.191.974.6-035.000', 'TK', '0000-00-00', 'L', 'Islam', 'Single'),
(20130110, 'Mohamad Iskak', 'Iskak', '31.7302.061177.0001', '15016837062', 2, '287726591', '67.735.007.6-036.000', 'K3', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20130202, 'Hafidz Satriawicaksana', 'Hafidz', '32.0302.010691.0003', '15016837047', 2, '287727175', '-', 'K0', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20130205, 'Marsaly Nurul Fazry', 'Sally', '31.7410.080593.0004', '15016837070', 3, '3010039656', '82.352.303.0-066.000', 'K0', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20130401, 'Dhefi Wulandari', 'Dhevi', '31.7307.570193.0002', '1503636084', 2, '294714962', '76.362.942.5-031.000', 'K1', '0000-00-00', 'P', 'Islam', 'Menikah'),
(20130402, 'Setiyo Budi Santoso', 'Santoso', '33.2705.070590.0006', '15024863928', 2, '294715047', '80.387.289.4-502.000', 'K0', '0000-00-00', 'L', 'Islam', 'Single'),
(20130403, 'Tarmanto', 'Masto', '33.0521.291287.0001', '15027923943', 2, '297101055', '-', 'K2', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20130702, 'Wahyu Satria Wibowo', 'Wahyu', '32.7501.181288.0008', '15046165377', 2, '303226163', '76.976.529.8-407.000', 'K1', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20130803, 'Vivi Handayani', 'Vivi', '32.7606.550695.0001', '15051768768', 2, '308843851', '81.591.472.6-448.000', 'TK', '0000-00-00', 'P', 'Islam', 'Single'),
(20130902, 'Patwa Anugrah Yadistira Prastiwi', 'Patwa ', '32.7609.150995.0001', '15051768800', 3, '5865150803', '80.624.334.1-448.000', 'TK', '0000-00-00', 'L', 'Islam', 'Single'),
(20130903, 'Riana Salim', 'Riana', '31.7409.510595.0008', '15051768750', 2, '308841796', '-', 'TK', '0000-00-00', 'P', 'Islam', 'Single'),
(20131001, 'Ales', 'Ales', '36.7403.171091.0010', '15051768784', 2, '313909602', '82.451.270.1-453.000', 'K0', '0000-00-00', 'L', 'Islam', 'Single'),
(20131202, 'Nofi Ali Saputra', 'Nofi', '33.0122.261286.0002', '06KH0117109', 2, '323463203', '80.321.854.4-522.000', 'K1', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20131204, 'Indra Amboro Wati', 'Indra', '33.7406.681083.0002', '10007210882', 2, '261904452', '66.557.599.9-518.000', 'K0', '0000-00-00', 'P', 'Katholik', 'Menikah'),
(20140105, 'Yuni Yulianti', 'Yanti', '31.7107.510696.0001', '16009185840', 2, '327478012', '80.631.678.2-077.000', 'TK', '0000-00-00', 'P', 'Islam', 'Single'),
(20140106, 'Fery Ervianto', 'Feri', '33.1204.290595.0001', '16009185865', 2, '0784327842', '-', 'K0', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20140201, 'Muhamad Faisal Alwi', 'Ichal', '31.7506.190993.0015', '16013220328', 3, '6330863267', '-', 'TK', '0000-00-00', 'L', 'Islam', 'Single'),
(20140308, 'Untung Riatno', 'Untung', '33.0312.160194.0003', '18104097391', 2, '327483431', '80.266.187.6-529.000', 'K1', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20140702, 'Sukhran Masthur', 'Athur', '32.7509.301084.0006', '16035209309', 2, '331286562', '80.118.282.5-447.000', 'K1', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20140803, 'Hardi Cayadi', 'Acwan', '31.7102.201274.0004', '16035209317', 2, '340687618', '08.314.931.0-075.000', 'K2', '0000-00-00', 'L', 'Budha', 'Menikah'),
(20140903, 'Rizky Silviana', 'Kiki', '31.7409.430596.0006', '16046663072', 2, '342568350', '-', 'TK', '0000-00-00', 'P', 'Islam', 'Single'),
(20140904, 'Kania Nurhapsari', 'Kania', '31.7409.621196.0005', '16046663064', 2, '342566680', '80.572.157.8-017.000', 'TK', '0000-00-00', 'P', 'Islam', 'Single'),
(20140905, 'Hariyansyah', 'Ryan', '31.7304.220588.0016', '13021621720', 2, '343130086', '-', 'K2', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20141002, 'Mustika Risalyna Mutmainah', 'Mustika', '32.0915.201195.0003', '16046663106', 2, '415213634', '66.871.657.4-426.000', 'TK', '0000-00-00', 'P', 'Islam', 'Single'),
(20141003, 'Balqis Untari', 'Balqis', '31.7107.411096.0003', '16046663080', 2, '343132823', '80.549.727.8-072.000', 'K0', '0000-00-00', 'P', 'Islam', 'Single'),
(20141102, 'Adi Ningghar Satriya Putra', 'Adi', '31.7302.260188.0009', '16053718892', 2, '349053229', '-', 'K0', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20141104, 'Virginia', 'Nia', '31.7102.471181.0001', '16053718900', 2, '349252340', '81.529.669.4-075.000', 'TK', '0000-00-00', 'P', 'Katholik', 'Single'),
(20141105, 'Erwin Musofa', 'Erwin', '33.0522.290495.0001', '16058623642', 2, '351454193', '-', 'TK', '0000-00-00', 'L', 'Islam', 'Single'),
(20141201, 'Wahid Teguh Gumilar', 'Wahid', '32.0509.170496.0001', '16053718918', 2, '349383509', '-', 'TK', '0000-00-00', 'L', 'Islam', 'Single'),
(20150103, 'Fajar Pamungkas', 'Fajar', '33.0522.300496.0003', '17009440490', 3, '3010039834', '-', 'TK', '0000-00-00', 'L', 'Islam', 'Single'),
(20150105, 'Kidung Arzhaning Jagad', 'Arzha', '33.2708.070194.0004', '17009440565', 3, '3010039800', '-', 'TK', '0000-00-00', 'L', 'Islam', 'Single'),
(20150106, 'Rinto', 'Rinto', '32.0934.300490.0014', '17009440524', 2, '358603263', '-', 'K0', '0000-00-00', 'L', 'Islam', 'Single'),
(20150201, 'Wewen Saputra', 'Wewen', '32.0113.230686.0006', '17009440557', 2, '359536792', '-', 'K1', '0000-00-00', 'P', 'Islam', 'Menikah'),
(20150204, 'Guntoro', 'Toro', '31.7508.270693.0006', '17009440532', 2, '362206294', '-', 'TK', '0000-00-00', 'L', 'Islam', 'Single'),
(20150205, 'Tio Meirizicha', 'Tio', '31.7305.190593.0004', '17009440540', 2, '362206840', '-', 'K1', '0000-00-00', 'L', 'Islam', 'Single'),
(20150303, 'Yogi Nugraha', 'Yogi', '31.7107.080886.0013', '17015348869', 2, '365390903', '97.325.726.4-077.000', 'TK', '0000-00-00', 'L', 'Islam', 'Single'),
(20150304, 'Aris Setiyo', 'Aris', '33.0701.210896.0004', '17015348851', 3, '3010039575', '-', 'TK', '0000-00-00', 'L', 'Islam', 'Single'),
(20150401, 'Shinta Syahri Kartika', 'Shinta', '31.7103.450993.0006', '17019447998', 2, '365387265', '54.720.045.1-027.000', 'TK', '0000-00-00', 'P', 'Islam', 'Single'),
(20150402, 'Andi Hermawan', 'Andi', '36.7403.130590.1001', '17019447980', 2, '369279798', '81.329.334.7-453.000', 'K0', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20150603, 'Priyanto', 'Pri', '33.0204.191291.0001', '14000717232', 2, '252991219', '71.584.763.8-521.000', 'K0', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20150701, 'Teguh Riyansah', 'Teguh', '31.7304.250693.0007', '17028533754', 3, '3010124882', '-', 'TK', '0000-00-00', 'L', 'Islam', 'Single'),
(20150801, 'Khotibul Ali Sholekan', 'Ali ', '32.7606.150484.0006', '09020656188', 2, '774031', '-', 'K2', '0000-00-00', 'L', 'Islam', 'Menikah'),
(20150802, 'Muhamad Subur', 'Subur', '32.1221.120795.0003', '17040972220', 2, '381394374', '-', 'TK', '0000-00-00', 'L', 'Islam', 'Single'),
(20150901, 'Marezka Khadarul', 'Reza', '32.7502.150393.0009', '17054458777', 2, '385400512', '-', 'TK', '0000-00-00', 'L', 'Islam', 'Single'),
(20151203, 'Ade Juli Ridwantoro', 'Ade', '33.0502.100795.0003', '17074122908', 2, '400861056', '-', 'TK', '0000-00-00', 'L', 'Islam', 'Single'),
(20160703, 'Nur Rohmatilah', 'Tia', '31.7404.500693.0004', '14036565209', 2, '268141980', '80.666.618.6-017.000', 'TK', '0000-00-00', 'P', 'Islam', 'Single');

-- --------------------------------------------------------

--
-- Table structure for table `employeeaddress`
--

CREATE TABLE `employeeaddress` (
  `ID` int(11) NOT NULL,
  `AddressDetail` text,
  `EmployeeNIK` int(11) DEFAULT NULL,
  `type` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `employeeeducation`
--

CREATE TABLE `employeeeducation` (
  `ID` int(50) NOT NULL,
  `NIK` int(40) DEFAULT NULL,
  `EducationLevel` varchar(255) DEFAULT NULL,
  `Institution` varchar(255) DEFAULT NULL,
  `Najor` varchar(255) DEFAULT NULL,
  `GraduationYear` date DEFAULT NULL,
  `Score` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `employeefamily`
--

CREATE TABLE `employeefamily` (
  `ID` int(50) NOT NULL,
  `NAME` varchar(255) DEFAULT NULL,
  `Gender` varchar(1) DEFAULT NULL,
  `DOB` date DEFAULT NULL,
  `EmployeeRelationshipID` int(50) DEFAULT NULL,
  `NIK` int(40) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employeefamily`
--

INSERT INTO `employeefamily` (`ID`, `NAME`, `Gender`, `DOB`, `EmployeeRelationshipID`, `NIK`) VALUES
(5, 'abc', 'M', '2020-01-06', 1, 123123),
(6, 'abc', 'M', '2020-01-06', 1, 123123),
(17, 'haha', 'M', '2020-01-06', 1, 123123);

-- --------------------------------------------------------

--
-- Table structure for table `employeejobhistory`
--

CREATE TABLE `employeejobhistory` (
  `ID` int(50) NOT NULL,
  `NIK` int(40) DEFAULT NULL,
  `Company` varchar(255) DEFAULT NULL,
  `Pos` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `employeerelationship`
--

CREATE TABLE `employeerelationship` (
  `ID` int(50) NOT NULL,
  `Relationship` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employeerelationship`
--

INSERT INTO `employeerelationship` (`ID`, `Relationship`) VALUES
(1, 'Sibling');

-- --------------------------------------------------------

--
-- Table structure for table `employee_email`
--

CREATE TABLE `employee_email` (
  `ID` int(50) NOT NULL,
  `NIK` int(40) DEFAULT NULL,
  `EmailAddress` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `employee_phones`
--

CREATE TABLE `employee_phones` (
  `ID` int(50) NOT NULL,
  `NIK` int(40) NOT NULL,
  `PhoneNumber` varchar(20) DEFAULT NULL,
  `PhoneType` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `level`
--

CREATE TABLE `level` (
  `ID` int(50) NOT NULL,
  `Name` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `level`
--

INSERT INTO `level` (`ID`, `Name`) VALUES
(1, 'Staff'),
(2, 'Supervisor'),
(3, 'Officer'),
(4, 'Manager'),
(5, 'Magang'),
(6, 'PKL');

-- --------------------------------------------------------

--
-- Table structure for table `notes`
--

CREATE TABLE `notes` (
  `note` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `notes`
--

INSERT INTO `notes` (`note`) VALUES
('ALL EMPLOYEE ID CHANGES TO NIK'),
('Position i changed to Pos because (position does not work');

-- --------------------------------------------------------

--
-- Table structure for table `pos`
--

CREATE TABLE `pos` (
  `ID` int(50) NOT NULL,
  `Name` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pos`
--

INSERT INTO `pos` (`ID`, `Name`) VALUES
(1, 'Fotocopy Jilid'),
(2, 'Operator Potong'),
(3, 'Supervisor Cetak'),
(4, 'Teknisi Fotocopy Jilid'),
(5, 'Ass Manager Keuangan'),
(6, 'CGO /Fotocopy Jilid'),
(7, 'Hard Cover'),
(8, 'Offset'),
(9, ' Store Supervisor'),
(10, 'Sablon'),
(11, 'Leader Fotocopy Jilid'),
(12, 'Messanger'),
(13, 'Finishing/ Driver'),
(14, 'Staff Gudang'),
(15, 'Store Manager'),
(16, 'Purchasing Head'),
(17, 'Prepress & Platemaker'),
(18, 'Leader CGO'),
(19, 'CGO'),
(20, 'Store Supervisor '),
(21, 'Finishing'),
(22, 'Messanger / Driver'),
(23, 'Admin Finance Store'),
(24, 'Finance Supervisor'),
(25, 'Finishing - Opr. Laminating'),
(26, 'Sales Support'),
(27, 'Admin Piutang'),
(28, 'Accounting Supervisor'),
(29, 'IT'),
(30, 'Leader Operator Indoor'),
(31, 'Operator Indoor'),
(32, 'Spv Store'),
(33, 'Admin Star'),
(34, 'HR Officer'),
(35, 'Finishing Supervisor '),
(36, 'Messenger'),
(37, 'Ass Opr Offset'),
(38, 'Leader Tim Kreatif'),
(39, 'CGO Corporate'),
(40, 'Operator Potong Store'),
(41, ' Ass Opr. Offset'),
(42, 'Production Head'),
(43, 'Sales'),
(44, 'Fotocopy Jilid '),
(45, 'Operator Indoor Indigo'),
(46, 'Traffic '),
(47, 'Runner'),
(48, 'Staff Cleaning'),
(49, 'Operator Outdoor'),
(50, 'Op Indigo'),
(51, 'Admin Accounting'),
(52, 'Admin Gudang'),
(53, 'Design Product'),
(54, 'R & D Junior Officer'),
(55, 'HR Supervisor'),
(56, 'Admin Store'),
(57, 'Operator Indigo'),
(58, 'CGO Setting'),
(59, 'Finance & Accounting manager'),
(60, 'CRM'),
(61, 'Sales Counter'),
(62, 'HR Officer '),
(63, 'Web Design'),
(64, 'Internal Audit'),
(65, 'Maintenance AC'),
(66, 'Opr. Indoor'),
(67, 'CSO'),
(68, ' Leader Sales Counter'),
(69, 'Ass. Opr Offset'),
(70, 'Opr Indoor Flatbed'),
(71, 'Opr Indoor Indigo'),
(72, 'Leader Sales Counter'),
(73, 'Operator Indoor SEM'),
(74, 'Tim Kreatif'),
(75, 'Sales Counter Email'),
(76, 'Opr. Indoor Indigo'),
(77, 'GA'),
(78, 'Teknisi Indoor'),
(79, 'Manager Store'),
(80, 'Admin Purchasing'),
(81, 'Supervisor Sales'),
(82, 'Cashier'),
(83, 'Ass. Sales Support'),
(84, 'Account Receivebale Sales'),
(85, 'Sales Counter STR'),
(86, 'Admin Customer Store'),
(87, 'Creative Design'),
(88, 'Operator indoor mimaki'),
(89, 'HR Manager'),
(90, 'CGO '),
(91, 'Tellestore'),
(92, 'Web Administrator'),
(93, 'PKL'),
(94, 'Freelace Admin HRD'),
(95, 'Marketing Store'),
(96, 'Admin Store SEM'),
(97, 'Finishing '),
(98, 'Fotocopy Jilid STR'),
(99, 'CGO SEM'),
(100, 'Operator Indoor Esco'),
(101, 'Estimator'),
(102, 'Sales Online Print'),
(103, 'Marketing Manager '),
(104, 'Runner Indoor'),
(105, 'Sales Counter SEM'),
(106, 'Magang'),
(107, 'CGO STR'),
(108, 'Manager Operasional');

-- --------------------------------------------------------

--
-- Table structure for table `transaction`
--

CREATE TABLE `transaction` (
  `ID` int(50) NOT NULL,
  `NIK` int(40) NOT NULL,
  `TransactionTypeID` int(50) DEFAULT NULL,
  `NoSurat` varchar(255) DEFAULT NULL,
  `EffectiveDate` date DEFAULT NULL,
  `EndDate` date DEFAULT NULL,
  `ContractTypeID` int(50) DEFAULT NULL,
  `BranchID` int(50) DEFAULT NULL,
  `DepartmentID` int(50) DEFAULT NULL,
  `PositionID` int(50) NOT NULL,
  `LevelID` int(50) NOT NULL,
  `Reasons` varchar(255) DEFAULT NULL,
  `Notes` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `transactiontype`
--

CREATE TABLE `transactiontype` (
  `ID` int(50) NOT NULL,
  `Name` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `transactiontype`
--

INSERT INTO `transactiontype` (`ID`, `Name`) VALUES
(1, 'Terminasi'),
(2, 'Karyawan baru'),
(3, 'Evaluasi'),
(4, 'Rotasi'),
(5, 'Promosi'),
(6, 'Magang'),
(7, 'Perpanjang Kontrak'),
(8, 'Perubahan Status'),
(9, 'Mutasi Antar Cabang'),
(10, 'Migration'),
(11, 'Mutasi'),
(12, 'Demosi'),
(13, 'Evaluasi Rotasi'),
(14, 'Sempurna Store'),
(15, 'Offset'),
(16, 'Star Store'),
(17, 'Store'),
(18, 'Finance & Accounting'),
(19, 'Sales'),
(20, 'IT'),
(21, 'HRD'),
(22, 'Marketing');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `username` varchar(50) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL,
  `role` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `username`, `password`, `role`) VALUES
(1, 'admin', 'admin', 'admin'),
(2, 'user', 'user', 'user');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bank`
--
ALTER TABLE `bank`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `branch`
--
ALTER TABLE `branch`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `contracttype`
--
ALTER TABLE `contracttype`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `department`
--
ALTER TABLE `department`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`NIK`),
  ADD KEY `BankID` (`BankID`);

--
-- Indexes for table `employeeaddress`
--
ALTER TABLE `employeeaddress`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `EmployeeNIK` (`EmployeeNIK`);

--
-- Indexes for table `employeeeducation`
--
ALTER TABLE `employeeeducation`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `NIK` (`NIK`);

--
-- Indexes for table `employeefamily`
--
ALTER TABLE `employeefamily`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `NIK` (`NIK`),
  ADD KEY `EmployeeRelationshipID` (`EmployeeRelationshipID`);

--
-- Indexes for table `employeejobhistory`
--
ALTER TABLE `employeejobhistory`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `NIK` (`NIK`);

--
-- Indexes for table `employeerelationship`
--
ALTER TABLE `employeerelationship`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `employee_email`
--
ALTER TABLE `employee_email`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `NIK` (`NIK`);

--
-- Indexes for table `employee_phones`
--
ALTER TABLE `employee_phones`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `NIK` (`NIK`);

--
-- Indexes for table `level`
--
ALTER TABLE `level`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `pos`
--
ALTER TABLE `pos`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `transaction`
--
ALTER TABLE `transaction`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `NIK` (`NIK`),
  ADD KEY `LevelID` (`LevelID`),
  ADD KEY `PositionID` (`PositionID`),
  ADD KEY `DepartmentID` (`DepartmentID`),
  ADD KEY `BranchID` (`BranchID`),
  ADD KEY `ContractTypeID` (`ContractTypeID`),
  ADD KEY `TransactionTypeID` (`TransactionTypeID`);

--
-- Indexes for table `transactiontype`
--
ALTER TABLE `transactiontype`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bank`
--
ALTER TABLE `bank`
  MODIFY `ID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `branch`
--
ALTER TABLE `branch`
  MODIFY `ID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `contracttype`
--
ALTER TABLE `contracttype`
  MODIFY `ID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `department`
--
ALTER TABLE `department`
  MODIFY `ID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `employeeaddress`
--
ALTER TABLE `employeeaddress`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `employeeeducation`
--
ALTER TABLE `employeeeducation`
  MODIFY `ID` int(50) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `employeefamily`
--
ALTER TABLE `employeefamily`
  MODIFY `ID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `employeejobhistory`
--
ALTER TABLE `employeejobhistory`
  MODIFY `ID` int(50) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `employeerelationship`
--
ALTER TABLE `employeerelationship`
  MODIFY `ID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `employee_email`
--
ALTER TABLE `employee_email`
  MODIFY `ID` int(50) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `employee_phones`
--
ALTER TABLE `employee_phones`
  MODIFY `ID` int(50) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `level`
--
ALTER TABLE `level`
  MODIFY `ID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `pos`
--
ALTER TABLE `pos`
  MODIFY `ID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=109;

--
-- AUTO_INCREMENT for table `transaction`
--
ALTER TABLE `transaction`
  MODIFY `ID` int(50) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `transactiontype`
--
ALTER TABLE `transactiontype`
  MODIFY `ID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `employee`
--
ALTER TABLE `employee`
  ADD CONSTRAINT `Employee_ibfk_1` FOREIGN KEY (`BankID`) REFERENCES `bank` (`ID`);

--
-- Constraints for table `employeeaddress`
--
ALTER TABLE `employeeaddress`
  ADD CONSTRAINT `employeeaddress_ibfk_1` FOREIGN KEY (`EmployeeNIK`) REFERENCES `employee` (`NIK`);

--
-- Constraints for table `employeeeducation`
--
ALTER TABLE `employeeeducation`
  ADD CONSTRAINT `EmployeeEducation_ibfk_1` FOREIGN KEY (`NIK`) REFERENCES `employee` (`NIK`),
  ADD CONSTRAINT `EmployeeEducation_ibfk_2` FOREIGN KEY (`NIK`) REFERENCES `employee` (`NIK`);

--
-- Constraints for table `employeefamily`
--
ALTER TABLE `employeefamily`
  ADD CONSTRAINT `EmployeeFamily_ibfk_1` FOREIGN KEY (`NIK`) REFERENCES `employee` (`NIK`),
  ADD CONSTRAINT `EmployeeFamily_ibfk_2` FOREIGN KEY (`EmployeeRelationshipID`) REFERENCES `employeerelationship` (`ID`);

--
-- Constraints for table `employeejobhistory`
--
ALTER TABLE `employeejobhistory`
  ADD CONSTRAINT `EmployeeJobHistory_ibfk_1` FOREIGN KEY (`NIK`) REFERENCES `employee` (`NIK`);

--
-- Constraints for table `employee_email`
--
ALTER TABLE `employee_email`
  ADD CONSTRAINT `Employee_Email_ibfk_1` FOREIGN KEY (`NIK`) REFERENCES `employee` (`NIK`);

--
-- Constraints for table `employee_phones`
--
ALTER TABLE `employee_phones`
  ADD CONSTRAINT `Employee_Phones_ibfk_1` FOREIGN KEY (`NIK`) REFERENCES `employee` (`NIK`);

--
-- Constraints for table `transaction`
--
ALTER TABLE `transaction`
  ADD CONSTRAINT `Transaction_ibfk_1` FOREIGN KEY (`NIK`) REFERENCES `employee` (`NIK`),
  ADD CONSTRAINT `Transaction_ibfk_2` FOREIGN KEY (`LevelID`) REFERENCES `level` (`ID`),
  ADD CONSTRAINT `Transaction_ibfk_3` FOREIGN KEY (`PositionID`) REFERENCES `pos` (`ID`),
  ADD CONSTRAINT `Transaction_ibfk_4` FOREIGN KEY (`DepartmentID`) REFERENCES `department` (`ID`),
  ADD CONSTRAINT `Transaction_ibfk_5` FOREIGN KEY (`BranchID`) REFERENCES `branch` (`ID`),
  ADD CONSTRAINT `Transaction_ibfk_6` FOREIGN KEY (`ContractTypeID`) REFERENCES `contracttype` (`ID`),
  ADD CONSTRAINT `Transaction_ibfk_7` FOREIGN KEY (`TransactionTypeID`) REFERENCES `transactiontype` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
