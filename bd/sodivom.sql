-- phpMyAdmin SQL Dump
-- version 4.8.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 05, 2018 at 01:55 AM
-- Server version: 10.1.34-MariaDB
-- PHP Version: 7.2.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sodivom`
--

-- --------------------------------------------------------

--
-- Table structure for table `cliente`
--

CREATE TABLE `cliente` (
  `ci` int(9) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `cliente`
--

INSERT INTO `cliente` (`ci`) VALUES
(53392894),
(99999999);

-- --------------------------------------------------------

--
-- Table structure for table `distribuidor`
--

CREATE TABLE `distribuidor` (
  `telefono` varchar(16) NOT NULL,
  `id` int(11) NOT NULL,
  `email` varchar(65) NOT NULL,
  `descripcion` text NOT NULL,
  `nombre` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `empleado`
--

CREATE TABLE `empleado` (
  `contrasenia` varchar(60) NOT NULL,
  `sueldo` varchar(9) NOT NULL,
  `idtipoempleado` int(11) NOT NULL,
  `ci` int(9) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `empleado`
--

INSERT INTO `empleado` (`contrasenia`, `sueldo`, `idtipoempleado`, `ci`) VALUES
('1234', '123123', 3, 26819239),
('1234', '111111', 3, 46259495),
('diego555', '0', 1, 47877195),
('1234', '0', 1, 50357429),
('1234', '0', 1, 50622846),
('1234', '0', 1, 50642701);

-- --------------------------------------------------------

--
-- Table structure for table `empleadoofertaweb`
--

CREATE TABLE `empleadoofertaweb` (
  `idoferta` int(11) NOT NULL,
  `ciempleado` int(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `entrega`
--

CREATE TABLE `entrega` (
  `importefinal` varchar(11) NOT NULL,
  `fechaentrega` date NOT NULL,
  `iddistribuidor` int(11) NOT NULL,
  `idpedidodistribuidor` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `ofertaweb`
--

CREATE TABLE `ofertaweb` (
  `id` int(11) NOT NULL,
  `preciooferta` int(9) NOT NULL,
  `producto` int(35) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `ofertaweb`
--

INSERT INTO `ofertaweb` (`id`, `preciooferta`, `producto`) VALUES
(1, 12, 123123),
(2, 23, 321321),
(3, 34, 55555555),
(4, 45, 59656123),
(5, 56, 123123413);

-- --------------------------------------------------------

--
-- Table structure for table `pedidodistribuidor`
--

CREATE TABLE `pedidodistribuidor` (
  `importeTotal` varchar(10) NOT NULL,
  `descripcion` text NOT NULL,
  `fecha` date NOT NULL,
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `pedidodistribuidor`
--

INSERT INTO `pedidodistribuidor` (`importeTotal`, `descripcion`, `fecha`, `id`) VALUES
('12', 'dadad', '2018-11-04', 1234);

-- --------------------------------------------------------

--
-- Table structure for table `persona`
--

CREATE TABLE `persona` (
  `ci` int(9) NOT NULL,
  `telefono` varchar(15) NOT NULL,
  `nombre` text NOT NULL,
  `apellido` text NOT NULL,
  `direccion` text NOT NULL,
  `email` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `persona`
--

INSERT INTO `persona` (`ci`, `telefono`, `nombre`, `apellido`, `direccion`, `email`) VALUES
(26819239, '121', 'Nancy', 'Gonzalez', 'Mi Casa', 'nan'),
(46259495, '00000', 'Evelyn', 'Benitez', 'kkkkk', 'mmmmm'),
(47877195, '098980074', 'Diego', 'Varela', 'Mi Casa', 'diego@hippieboton.xyz'),
(50357429, '00', 'Paola', 'Romay', '---', '---'),
(50622846, '00', 'Juan', 'Gutierrez', '---', '---'),
(50642701, '00', 'Mateo', 'Rodriguez', '---', '---'),
(53392894, '000', 'Guavi', 'Xd', 'Montes', 'elguavi@pumcoso.tush'),
(99999999, '0', 'Anónimo', '-', '-', '-');

-- --------------------------------------------------------

--
-- Table structure for table `producto`
--

CREATE TABLE `producto` (
  `codigo` int(13) NOT NULL,
  `descripcion` text NOT NULL,
  `precio` varchar(11) NOT NULL,
  `nombre` text NOT NULL,
  `minstock` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `producto`
--

INSERT INTO `producto` (`codigo`, `descripcion`, `precio`, `nombre`, `minstock`) VALUES
(123123, 'PumCoso', '500', 'Cigarros', 25),
(321321, '-', '30', 'Pañuelos', 25),
(55223399, 'Deliciosos', '50', 'Waffles', 20),
(55555555, 'dsada', '40', 'Galletitas', 50),
(59656123, 'Grandes', '1200', 'Camperas', 90),
(123123413, 'Rik', '123', 'Coca_Cola', 30);

-- --------------------------------------------------------

--
-- Table structure for table `productodistribuidor`
--

CREATE TABLE `productodistribuidor` (
  `codigo` int(11) NOT NULL,
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `reparto`
--

CREATE TABLE `reparto` (
  `id` int(11) NOT NULL,
  `descripcion` text NOT NULL,
  `idventa` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `reparto`
--

INSERT INTO `reparto` (`id`, `descripcion`, `idventa`) VALUES
(1, '0', 11),
(2, '0', 13),
(3, 'Mi CAA', 14);

-- --------------------------------------------------------

--
-- Table structure for table `stock`
--

CREATE TABLE `stock` (
  `idproducto` int(13) NOT NULL,
  `fechaven` date NOT NULL,
  `stock` int(10) NOT NULL,
  `fechaing` date NOT NULL,
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `stock`
--

INSERT INTO `stock` (`idproducto`, `fechaven`, `stock`, `fechaing`, `id`) VALUES
(123123, '2018-10-19', 13, '2018-10-14', 3),
(55555555, '2018-10-20', 1, '2018-10-18', 4),
(321321, '2018-11-29', 30, '2018-10-29', 5),
(59656123, '2018-10-31', 300, '2018-10-31', 6),
(123123, '2018-12-01', 25, '2018-11-03', 7),
(123123413, '1920-01-01', 23, '2018-11-03', 8),
(55223399, '1920-01-01', 5, '2018-11-03', 9);

-- --------------------------------------------------------

--
-- Table structure for table `tipoempleado`
--

CREATE TABLE `tipoempleado` (
  `id` int(11) NOT NULL,
  `tipoempleado` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tipoempleado`
--

INSERT INTO `tipoempleado` (`id`, `tipoempleado`) VALUES
(1, 'Administrador'),
(2, 'Cajero'),
(3, 'Reponedor'),
(4, 'Vendedor'),
(5, 'Administrativo');

-- --------------------------------------------------------

--
-- Table structure for table `venta`
--

CREATE TABLE `venta` (
  `importeTotal` varchar(9) NOT NULL,
  `fecha` datetime NOT NULL,
  `id` int(11) NOT NULL,
  `descripcion` text NOT NULL,
  `civendedor` int(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `venta`
--

INSERT INTO `venta` (`importeTotal`, `fecha`, `id`, `descripcion`, `civendedor`) VALUES
('2500', '2018-10-14 03:22:38', 1, '', 47877195),
('1500', '2018-10-14 03:43:27', 2, '', 47877195),
('1000', '2018-10-14 03:45:19', 3, '', 47877195),
('1000', '2018-10-14 03:47:28', 4, '', 47877195),
('1000', '2018-10-14 03:48:13', 5, '', 47877195),
('1560', '2018-10-14 03:49:13', 6, '', 47877195),
('540', '2018-10-14 03:50:17', 7, '', 47877195),
('2900', '2018-10-28 03:12:47', 8, '', 47877195),
('5800', '2018-10-29 01:37:55', 9, '', 47877195),
('123', '2018-11-03 11:43:27', 10, '', 47877195),
('500', '2018-11-04 03:40:52', 11, '', 47877195),
('500', '2018-11-04 03:43:07', 12, '', 47877195),
('603', '2018-11-04 05:44:34', 13, '', 47877195),
('480', '2018-11-04 05:55:59', 14, '', 47877195);

-- --------------------------------------------------------

--
-- Table structure for table `ventadeproducto`
--

CREATE TABLE `ventadeproducto` (
  `id` int(11) NOT NULL,
  `idventa` int(11) NOT NULL,
  `cicliente` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `ventadeproducto`
--

INSERT INTO `ventadeproducto` (`id`, `idventa`, `cicliente`) VALUES
(1, 2, 99999999),
(2, 4, 99999999),
(3, 5, 99999999),
(4, 6, 99999999),
(5, 7, 99999999),
(6, 8, 99999999),
(7, 9, 99999999),
(8, 10, 99999999),
(9, 11, 99999999),
(10, 12, 99999999),
(11, 13, 53392894),
(12, 14, 99999999);

-- --------------------------------------------------------

--
-- Table structure for table `ventaproducto`
--

CREATE TABLE `ventaproducto` (
  `idventa` int(11) NOT NULL,
  `codigoproducto` int(13) NOT NULL,
  `cantidadproducto` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `ventaproducto`
--

INSERT INTO `ventaproducto` (`idventa`, `codigoproducto`, `cantidadproducto`) VALUES
(2, 123123, 3),
(4, 123123, 2),
(5, 123123, 2),
(6, 321321, 52),
(7, 321321, 18),
(8, 123123, 5),
(8, 55555555, 10),
(9, 123123, 10),
(9, 321321, 20),
(9, 55555555, 5),
(10, 123123413, 1),
(11, 123123, 1),
(12, 123123, 1),
(13, 55555555, 12),
(13, 123123413, 1),
(14, 55555555, 12);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`ci`);

--
-- Indexes for table `distribuidor`
--
ALTER TABLE `distribuidor`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `empleado`
--
ALTER TABLE `empleado`
  ADD PRIMARY KEY (`ci`);

--
-- Indexes for table `empleadoofertaweb`
--
ALTER TABLE `empleadoofertaweb`
  ADD PRIMARY KEY (`idoferta`,`ciempleado`),
  ADD KEY `ciempl` (`ciempleado`);

--
-- Indexes for table `entrega`
--
ALTER TABLE `entrega`
  ADD PRIMARY KEY (`iddistribuidor`,`idpedidodistribuidor`),
  ADD KEY `idpedidodistri` (`idpedidodistribuidor`);

--
-- Indexes for table `ofertaweb`
--
ALTER TABLE `ofertaweb`
  ADD PRIMARY KEY (`id`),
  ADD KEY `prod` (`producto`);

--
-- Indexes for table `pedidodistribuidor`
--
ALTER TABLE `pedidodistribuidor`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `persona`
--
ALTER TABLE `persona`
  ADD PRIMARY KEY (`ci`);

--
-- Indexes for table `producto`
--
ALTER TABLE `producto`
  ADD PRIMARY KEY (`codigo`);

--
-- Indexes for table `productodistribuidor`
--
ALTER TABLE `productodistribuidor`
  ADD PRIMARY KEY (`codigo`,`id`),
  ADD KEY `dist` (`id`);

--
-- Indexes for table `reparto`
--
ALTER TABLE `reparto`
  ADD PRIMARY KEY (`id`),
  ADD KEY `idventa` (`idventa`);

--
-- Indexes for table `stock`
--
ALTER TABLE `stock`
  ADD PRIMARY KEY (`id`),
  ADD KEY `idproduc` (`idproducto`);

--
-- Indexes for table `tipoempleado`
--
ALTER TABLE `tipoempleado`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `venta`
--
ALTER TABLE `venta`
  ADD PRIMARY KEY (`id`),
  ADD KEY `civen` (`civendedor`);

--
-- Indexes for table `ventadeproducto`
--
ALTER TABLE `ventadeproducto`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `ventaproducto`
--
ALTER TABLE `ventaproducto`
  ADD PRIMARY KEY (`idventa`,`codigoproducto`),
  ADD KEY `codprod` (`codigoproducto`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `reparto`
--
ALTER TABLE `reparto`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `stock`
--
ALTER TABLE `stock`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `tipoempleado`
--
ALTER TABLE `tipoempleado`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `venta`
--
ALTER TABLE `venta`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `ventadeproducto`
--
ALTER TABLE `ventadeproducto`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `cliente`
--
ALTER TABLE `cliente`
  ADD CONSTRAINT `cicliente` FOREIGN KEY (`ci`) REFERENCES `persona` (`ci`);

--
-- Constraints for table `empleado`
--
ALTER TABLE `empleado`
  ADD CONSTRAINT `ciempleado` FOREIGN KEY (`ci`) REFERENCES `persona` (`ci`);

--
-- Constraints for table `empleadoofertaweb`
--
ALTER TABLE `empleadoofertaweb`
  ADD CONSTRAINT `ciempl` FOREIGN KEY (`ciempleado`) REFERENCES `empleado` (`ci`),
  ADD CONSTRAINT `idof` FOREIGN KEY (`idoferta`) REFERENCES `ofertaweb` (`id`);

--
-- Constraints for table `entrega`
--
ALTER TABLE `entrega`
  ADD CONSTRAINT `iddistri` FOREIGN KEY (`iddistribuidor`) REFERENCES `distribuidor` (`id`),
  ADD CONSTRAINT `idpedidodistri` FOREIGN KEY (`idpedidodistribuidor`) REFERENCES `pedidodistribuidor` (`id`);

--
-- Constraints for table `ofertaweb`
--
ALTER TABLE `ofertaweb`
  ADD CONSTRAINT `prod` FOREIGN KEY (`producto`) REFERENCES `producto` (`codigo`);

--
-- Constraints for table `productodistribuidor`
--
ALTER TABLE `productodistribuidor`
  ADD CONSTRAINT `cod` FOREIGN KEY (`codigo`) REFERENCES `producto` (`codigo`),
  ADD CONSTRAINT `dist` FOREIGN KEY (`id`) REFERENCES `distribuidor` (`id`);

--
-- Constraints for table `reparto`
--
ALTER TABLE `reparto`
  ADD CONSTRAINT `idventa` FOREIGN KEY (`idventa`) REFERENCES `venta` (`id`);

--
-- Constraints for table `stock`
--
ALTER TABLE `stock`
  ADD CONSTRAINT `idproduc` FOREIGN KEY (`idproducto`) REFERENCES `producto` (`codigo`);

--
-- Constraints for table `venta`
--
ALTER TABLE `venta`
  ADD CONSTRAINT `civen` FOREIGN KEY (`civendedor`) REFERENCES `empleado` (`ci`);

--
-- Constraints for table `ventaproducto`
--
ALTER TABLE `ventaproducto`
  ADD CONSTRAINT `codprod` FOREIGN KEY (`codigoproducto`) REFERENCES `producto` (`codigo`),
  ADD CONSTRAINT `idven` FOREIGN KEY (`idventa`) REFERENCES `venta` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;