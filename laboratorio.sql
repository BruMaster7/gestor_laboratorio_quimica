-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 28-10-2025 a las 12:58:21
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `laboratorio`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `accesorio`
--

CREATE TABLE `accesorio` (
  `idAccesorio` int(11) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `descripcion` text DEFAULT NULL,
  `stockActual` int(11) DEFAULT NULL,
  `ubicacion` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `accesorio`
--

INSERT INTO `accesorio` (`idAccesorio`, `nombre`, `descripcion`, `stockActual`, `ubicacion`) VALUES
(1, 'Probeta', 'La probeta que hace cosas de probeta', 0, 'Estante de Probetas'),
(2, 'Matraz Erlenmeyer', 'Un recipiente de vidrio con forma de cono truncado, un cuello estrecho y una base plana. Se usa para calentar líquidos, mezclar reactivos o realizar titulaciones. Su forma permite agitar sin riesgo de salpicaduras.', 2, 'Estante A1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `alerta`
--

CREATE TABLE `alerta` (
  `idAlerta` int(11) NOT NULL,
  `tipo` varchar(100) DEFAULT NULL,
  `descripcion` text DEFAULT NULL,
  `fechaHora` datetime DEFAULT NULL,
  `activo` tinyint(1) DEFAULT 1,
  `idSustancia` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `alerta`
--

INSERT INTO `alerta` (`idAlerta`, `tipo`, `descripcion`, `fechaHora`, `activo`, `idSustancia`) VALUES
(1, 'Sustancia con stock crítico', 'La sustancia \'Cloruro de Sodio (NaCl)\' tiene un stock actual de 50, igual o menor al mínimo permitido (100).', '2025-10-02 01:07:38', 1, NULL),
(2, 'Sustancia vencida', 'La sustancia \'Cloruro de Sodio (NaCl)\' ha vencido el 02/10/2025.', '2025-10-02 01:07:38', 1, NULL),
(3, 'Accesorio sin stock', 'El accesorio \'Probeta\' se ha quedado sin stock en la ubicación \'Estante de Probetas\'.', '2025-10-02 08:33:41', 1, NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `arduino_prueba`
--

CREATE TABLE `arduino_prueba` (
  `ID` int(11) NOT NULL,
  `mensaje` varchar(120) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `eventostock`
--

CREATE TABLE `eventostock` (
  `idEventoStock` int(11) NOT NULL,
  `tipo` varchar(50) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `descripcion` text DEFAULT NULL,
  `fechaHora` datetime DEFAULT NULL,
  `idUsuario` int(11) NOT NULL,
  `idSustancia` int(11) DEFAULT NULL,
  `idAccesorio` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `historial`
--

CREATE TABLE `historial` (
  `id` int(11) NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `movimiento` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `incompatibilidad`
--

CREATE TABLE `incompatibilidad` (
  `idIncompatibilidad` int(11) NOT NULL,
  `descripcion` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `practica`
--

CREATE TABLE `practica` (
  `idPractica` int(11) NOT NULL,
  `fecha` date NOT NULL,
  `idUsuario` int(11) NOT NULL,
  `objetivo` text DEFAULT NULL,
  `cantidadEstudiantes` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `practica_accesorio`
--

CREATE TABLE `practica_accesorio` (
  `idPractica` int(11) NOT NULL,
  `idAccesorio` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `practica_sustancia`
--

CREATE TABLE `practica_sustancia` (
  `idPractica` int(11) NOT NULL,
  `idSustancia` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `registroambiental`
--

CREATE TABLE `registroambiental` (
  `idRegistro` int(11) NOT NULL,
  `tipoGasDetectado` varchar(100) DEFAULT NULL,
  `fechaHora` datetime DEFAULT NULL,
  `nivel` float DEFAULT NULL,
  `idAlerta` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `rol`
--

CREATE TABLE `rol` (
  `idRol` int(11) NOT NULL,
  `nombre` enum('LABORATORISTA','DOCENTE','ESTUDIANTE') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `rol`
--

INSERT INTO `rol` (`idRol`, `nombre`) VALUES
(1, 'LABORATORISTA'),
(2, 'DOCENTE'),
(3, 'ESTUDIANTE');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `solicitudpractica`
--

CREATE TABLE `solicitudpractica` (
  `idSolicitud` int(11) NOT NULL,
  `fechaEnvio` date NOT NULL,
  `estado` enum('PENDIENTE','APROBADA','RECHAZADA') DEFAULT 'PENDIENTE',
  `idUsuario` int(11) NOT NULL,
  `idPractica` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sustancia`
--

CREATE TABLE `sustancia` (
  `idSustancia` int(11) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `categoria` varchar(100) DEFAULT NULL,
  `unidadMedida` varchar(50) DEFAULT NULL,
  `descripcionManipulacion` text DEFAULT NULL,
  `ubicacion` varchar(100) DEFAULT NULL,
  `fechaIngreso` date DEFAULT NULL,
  `fechaVencimiento` date DEFAULT NULL,
  `stockActual` int(11) DEFAULT NULL,
  `stockMinimo` int(11) DEFAULT NULL,
  `peligrosidad` varchar(100) DEFAULT NULL,
  `envaseRecomendado` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `sustancia`
--

INSERT INTO `sustancia` (`idSustancia`, `nombre`, `categoria`, `unidadMedida`, `descripcionManipulacion`, `ubicacion`, `fechaIngreso`, `fechaVencimiento`, `stockActual`, `stockMinimo`, `peligrosidad`, `envaseRecomendado`) VALUES
(1, 'Alcohol Etilico', 'Ácido', 'Ml', 'Alejar de chispas', 'Estante A1', '2025-09-17', '2027-01-23', 200, 100, 'Inflamable', 'Plastico'),
(3, 'Aceite Oliva', 'Orgánico', 'Ml', 'No mezclar con agua en temperaturas elevadas', 'Estante A1', '2025-09-17', '2026-03-14', 955, 500, 'Inflamable', 'Botella de Vidrio'),
(4, 'Cloruro de Sodio (NaCl)', 'Sal Inorgánica', 'Gr', 'Usar guantes y gafas de seguridad. Evitar inhalar el polvo. Almacenar seco y sellado.', 'Estante 3A', '2025-09-29', '2025-10-02', 50, 100, 'Baja', 'Vidrio con tapa sellada');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sustancia_incompatibilidad`
--

CREATE TABLE `sustancia_incompatibilidad` (
  `idSustancia` int(11) NOT NULL,
  `idIncompatibilidad` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `idUsuario` int(11) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `contrasena` varchar(255) NOT NULL,
  `idRol` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`idUsuario`, `nombre`, `contrasena`, `idRol`) VALUES
(2, 'Admin', 'a123', 1),
(4, 'Pepe', '1234', 2);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `accesorio`
--
ALTER TABLE `accesorio`
  ADD PRIMARY KEY (`idAccesorio`);

--
-- Indices de la tabla `alerta`
--
ALTER TABLE `alerta`
  ADD PRIMARY KEY (`idAlerta`),
  ADD KEY `idSustancia` (`idSustancia`);

--
-- Indices de la tabla `eventostock`
--
ALTER TABLE `eventostock`
  ADD PRIMARY KEY (`idEventoStock`),
  ADD KEY `idUsuario` (`idUsuario`),
  ADD KEY `idSustancia` (`idSustancia`),
  ADD KEY `idAccesorio` (`idAccesorio`);

--
-- Indices de la tabla `historial`
--
ALTER TABLE `historial`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `incompatibilidad`
--
ALTER TABLE `incompatibilidad`
  ADD PRIMARY KEY (`idIncompatibilidad`);

--
-- Indices de la tabla `practica`
--
ALTER TABLE `practica`
  ADD PRIMARY KEY (`idPractica`),
  ADD KEY `idUsuario` (`idUsuario`);

--
-- Indices de la tabla `practica_accesorio`
--
ALTER TABLE `practica_accesorio`
  ADD PRIMARY KEY (`idPractica`,`idAccesorio`),
  ADD KEY `idAccesorio` (`idAccesorio`);

--
-- Indices de la tabla `practica_sustancia`
--
ALTER TABLE `practica_sustancia`
  ADD PRIMARY KEY (`idPractica`,`idSustancia`),
  ADD KEY `idSustancia` (`idSustancia`);

--
-- Indices de la tabla `registroambiental`
--
ALTER TABLE `registroambiental`
  ADD PRIMARY KEY (`idRegistro`),
  ADD KEY `idAlerta` (`idAlerta`);

--
-- Indices de la tabla `rol`
--
ALTER TABLE `rol`
  ADD PRIMARY KEY (`idRol`);

--
-- Indices de la tabla `solicitudpractica`
--
ALTER TABLE `solicitudpractica`
  ADD PRIMARY KEY (`idSolicitud`),
  ADD KEY `idUsuario` (`idUsuario`),
  ADD KEY `idPractica` (`idPractica`);

--
-- Indices de la tabla `sustancia`
--
ALTER TABLE `sustancia`
  ADD PRIMARY KEY (`idSustancia`);

--
-- Indices de la tabla `sustancia_incompatibilidad`
--
ALTER TABLE `sustancia_incompatibilidad`
  ADD PRIMARY KEY (`idSustancia`,`idIncompatibilidad`),
  ADD KEY `idIncompatibilidad` (`idIncompatibilidad`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`idUsuario`),
  ADD KEY `idRol` (`idRol`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `accesorio`
--
ALTER TABLE `accesorio`
  MODIFY `idAccesorio` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `alerta`
--
ALTER TABLE `alerta`
  MODIFY `idAlerta` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `eventostock`
--
ALTER TABLE `eventostock`
  MODIFY `idEventoStock` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `incompatibilidad`
--
ALTER TABLE `incompatibilidad`
  MODIFY `idIncompatibilidad` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `practica`
--
ALTER TABLE `practica`
  MODIFY `idPractica` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `registroambiental`
--
ALTER TABLE `registroambiental`
  MODIFY `idRegistro` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `rol`
--
ALTER TABLE `rol`
  MODIFY `idRol` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `solicitudpractica`
--
ALTER TABLE `solicitudpractica`
  MODIFY `idSolicitud` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `sustancia`
--
ALTER TABLE `sustancia`
  MODIFY `idSustancia` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `usuario`
--
ALTER TABLE `usuario`
  MODIFY `idUsuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `alerta`
--
ALTER TABLE `alerta`
  ADD CONSTRAINT `alerta_ibfk_1` FOREIGN KEY (`idSustancia`) REFERENCES `sustancia` (`idSustancia`);

--
-- Filtros para la tabla `eventostock`
--
ALTER TABLE `eventostock`
  ADD CONSTRAINT `eventostock_ibfk_1` FOREIGN KEY (`idUsuario`) REFERENCES `usuario` (`idUsuario`),
  ADD CONSTRAINT `eventostock_ibfk_2` FOREIGN KEY (`idSustancia`) REFERENCES `sustancia` (`idSustancia`),
  ADD CONSTRAINT `eventostock_ibfk_3` FOREIGN KEY (`idAccesorio`) REFERENCES `accesorio` (`idAccesorio`);

--
-- Filtros para la tabla `practica`
--
ALTER TABLE `practica`
  ADD CONSTRAINT `practica_ibfk_1` FOREIGN KEY (`idUsuario`) REFERENCES `usuario` (`idUsuario`);

--
-- Filtros para la tabla `practica_accesorio`
--
ALTER TABLE `practica_accesorio`
  ADD CONSTRAINT `practica_accesorio_ibfk_1` FOREIGN KEY (`idPractica`) REFERENCES `practica` (`idPractica`),
  ADD CONSTRAINT `practica_accesorio_ibfk_2` FOREIGN KEY (`idAccesorio`) REFERENCES `accesorio` (`idAccesorio`);

--
-- Filtros para la tabla `practica_sustancia`
--
ALTER TABLE `practica_sustancia`
  ADD CONSTRAINT `practica_sustancia_ibfk_1` FOREIGN KEY (`idPractica`) REFERENCES `practica` (`idPractica`),
  ADD CONSTRAINT `practica_sustancia_ibfk_2` FOREIGN KEY (`idSustancia`) REFERENCES `sustancia` (`idSustancia`);

--
-- Filtros para la tabla `registroambiental`
--
ALTER TABLE `registroambiental`
  ADD CONSTRAINT `registroambiental_ibfk_1` FOREIGN KEY (`idAlerta`) REFERENCES `alerta` (`idAlerta`);

--
-- Filtros para la tabla `solicitudpractica`
--
ALTER TABLE `solicitudpractica`
  ADD CONSTRAINT `solicitudpractica_ibfk_1` FOREIGN KEY (`idUsuario`) REFERENCES `usuario` (`idUsuario`),
  ADD CONSTRAINT `solicitudpractica_ibfk_2` FOREIGN KEY (`idPractica`) REFERENCES `practica` (`idPractica`);

--
-- Filtros para la tabla `sustancia_incompatibilidad`
--
ALTER TABLE `sustancia_incompatibilidad`
  ADD CONSTRAINT `sustancia_incompatibilidad_ibfk_1` FOREIGN KEY (`idSustancia`) REFERENCES `sustancia` (`idSustancia`),
  ADD CONSTRAINT `sustancia_incompatibilidad_ibfk_2` FOREIGN KEY (`idIncompatibilidad`) REFERENCES `incompatibilidad` (`idIncompatibilidad`);

--
-- Filtros para la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD CONSTRAINT `usuario_ibfk_1` FOREIGN KEY (`idRol`) REFERENCES `rol` (`idRol`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
