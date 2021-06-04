-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : jeu. 03 juin 2021 à 09:46
-- Version du serveur :  8.0.21
-- Version de PHP : 7.3.21


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `projetcned`
--
CREATE DATABASE IF NOT EXISTS `projetcned` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
CREATE USER 'habilitations'@'%' IDENTIFIED BY 'pwd';
GRANT USAGE ON *.* TO 'projetcned'@'%';
GRANT ALL PRIVILEGES ON `projetcned`.* TO 'projetcned'@'%';
USE `projetcned`;

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE `absence` (
  `IDPERSONNEL` int NOT NULL,
  `DATEDEBUT` datetime NOT NULL,
  `IDMOTIF` int NOT NULL,
  `DATEFIN` datetime DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`IDPERSONNEL`, `DATEDEBUT`, `IDMOTIF`, `DATEFIN`) VALUES
(13, '2021-06-13 00:00:00', 2, '2021-07-13 00:00:00'),
(9, '2021-06-30 12:29:37', 4, '2021-07-11 12:29:37'),
(5, '2021-06-30 12:56:32', 2, '2021-10-08 12:56:32'),
(12, '2019-04-16 06:50:01', 3, '2020-05-05 07:32:45'),
(2, '2019-04-03 14:32:04', 3, '2020-12-05 10:58:46'),
(9, '2019-01-10 18:56:23', 2, '2020-03-31 01:43:25'),
(14, '2019-05-28 21:42:36', 4, '2020-02-24 11:40:04'),
(13, '2021-06-04 00:00:00', 4, '2021-07-04 00:00:00'),
(15, '2019-09-09 11:56:11', 3, '2020-01-26 23:44:37'),
(6, '2019-01-31 18:44:05', 3, '2020-09-26 02:06:19'),
(10, '2019-11-17 12:57:57', 4, '2020-06-16 16:17:52'),
(6, '2019-10-10 11:48:52', 2, '2020-01-07 19:51:39'),
(1, '2019-10-05 18:21:04', 4, '2020-06-11 02:00:32'),
(4, '2021-06-03 18:00:50', 1, '2022-04-02 18:00:49'),
(8, '2019-03-16 13:40:48', 3, '2020-08-13 22:17:14'),
(13, '2021-06-01 00:00:00', 3, '2021-06-26 00:00:00'),
(11, '2019-06-20 10:08:32', 1, '2020-10-08 18:50:32'),
(5, '2021-06-02 12:56:32', 2, '2021-10-08 12:56:32'),
(10, '2019-11-27 16:11:30', 4, '2020-06-21 07:53:51'),
(6, '2019-01-01 05:36:35', 4, '2020-09-04 15:20:28'),
(8, '2019-09-02 22:39:48', 2, '2020-07-02 09:14:19'),
(14, '2019-07-26 16:29:49', 3, '2020-03-17 18:03:53'),
(10, '2019-12-20 17:31:11', 1, '2020-07-22 09:12:43'),
(4, '2021-08-07 18:00:50', 1, '2022-04-07 18:00:49'),
(9, '2019-05-09 19:17:40', 1, '2020-11-08 06:44:31'),
(3, '2019-07-09 14:41:14', 4, '2021-01-01 10:53:40'),
(10, '2019-09-01 05:31:08', 4, '2020-10-15 12:01:00'),
(11, '2019-02-03 08:51:18', 3, '2020-06-18 02:16:44'),
(8, '2021-06-02 15:37:16', 4, '2021-08-13 15:37:16'),
(7, '2019-06-27 06:59:18', 3, '2020-11-30 21:34:36'),
(12, '2019-09-16 17:26:11', 3, '2020-11-29 09:15:21'),
(3, '2019-03-13 15:35:15', 3, '2020-02-14 05:09:23'),
(14, '2019-03-08 06:56:07', 4, '2020-06-07 11:19:06'),
(6, '2019-01-19 05:36:35', 4, '2020-08-18 15:20:28'),
(8, '2021-06-01 15:37:16', 2, '2020-05-06 19:08:21'),
(6, '2019-06-21 04:41:00', 3, '2020-02-23 18:00:28'),
(9, '2019-08-24 03:34:50', 2, '2020-03-21 15:40:53'),
(9, '2019-01-27 05:28:27', 1, '2020-02-02 23:01:16'),
(12, '2019-12-21 09:29:54', 2, '2020-10-18 00:54:42'),
(4, '2021-02-02 18:00:50', 4, '2022-04-02 18:00:49'),
(11, '2019-06-03 10:18:17', 2, '2020-06-01 01:43:54'),
(2, '2019-03-28 21:50:34', 3, '2020-08-24 08:31:52'),
(1, '2019-07-25 15:32:28', 4, '2020-09-15 02:19:23'),
(11, '2019-08-07 02:13:59', 1, '2020-06-04 12:59:49'),
(14, '2019-10-17 14:34:31', 3, '2020-05-14 22:23:42'),
(7, '2019-05-08 15:01:43', 1, '2020-08-18 19:36:09'),
(10, '2019-12-10 11:37:08', 2, '2020-03-12 20:54:19'),
(12, '2019-03-11 11:19:31', 1, '2020-01-28 09:02:06'),
(7, '2019-04-27 23:33:33', 2, '2020-11-08 16:36:36'),
(4, '2021-06-09 18:00:50', 2, '2022-04-09 18:00:49'),
(11, '2019-01-16 06:15:39', 4, '2020-01-26 23:57:02'),
(14, '2019-01-12 20:41:47', 1, '2020-02-16 23:28:39');

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE `motif` (
  `IDMOTIF` int NOT NULL,
  `LIBELLE` varchar(128) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`IDMOTIF`, `LIBELLE`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE `personnel` (
  `IDPERSONNEL` int NOT NULL,
  `IDSERVICE` int NOT NULL,
  `NOM` varchar(50) DEFAULT NULL,
  `PRENOM` varchar(50) DEFAULT NULL,
  `TEL` varchar(15) DEFAULT NULL,
  `MAIL` varchar(128) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`IDPERSONNEL`, `IDSERVICE`, `NOM`, `PRENOM`, `TEL`, `MAIL`) VALUES
(1, 2, 'Yates', 'Emi', '06 83 17 19 52', 'ut.mi@malesuadafames.ca'),
(2, 1, 'Leon', 'Warren', '05 75 23 46 99', 'bibendum@euismodetcommodo.org'),
(3, 3, 'Hood', 'Caryn', '04 38 86 59 99', 'tincidunt.congue@lacusEtiam.com'),
(4, 1, 'Barker', 'Eaton', '04 69 43 20 74', 'Etiam@sociisnatoquepenatibus.co.uk'),
(5, 3, 'Brock', 'Uriah', '06 18 27 13 90', 'sem.Pellentesque@nonjustoProin.org'),
(6, 2, 'Downs', 'David', '01 99 35 51 17', 'enim.Suspendisse.aliquet@aaliquetvel.com'),
(7, 2, 'Flynn', 'Honorato', '08 36 97 48 92', 'Ut.sagittis@mi.ca'),
(8, 3, 'Branch', 'Rahim', '05 63 65 33 33', 'In@necorci.net'),
(9, 3, 'Cameron', 'Adrian', '04 12 77 74 64', 'dictum.magna@sapiengravidanon.com'),
(10, 2, 'Leonard', 'Joseph', '03 69 50 06 86', 'eu.enim@seddolor.com'),
(11, 3, 'Matthews', 'Gage', '01 21 01 28 94', 'gravida.sagittis@nisiAenean.edu'),
(12, 1, 'Hewitt', 'Hedwig', '07 55 52 10 47', 'vitae.velit.egestas@elitsedconsequat.edu'),
(13, 2, 'Yang', 'Fallon', '03 41 17 46 97', 'lacus@acfermentum.ca'),
(44, 3, 'lavalle', 'zoe', '0954433457', 'mail.maom.fr'),
(15, 1, 'Frank', 'Liberty', '01 30 96 16 32', 'enim.Mauris.quis@lectus.org'),
(41, 3, 'Jean', 'Michel', '098754443', 'mail@mail'),
(43, 1, 'jean-pierre', 'michelin', '090554543', 'mail@mail.fr');

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE `responsable` (
  `login` varchar(256) NOT NULL,
  `pwd` varchar(256) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('logresponsable', 'a1159e9df3670d549d04524532629f5477ceb7deec9b45e47e8c009506ecb2c8');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE `service` (
  `IDSERVICE` int NOT NULL,
  `NOM` varchar(50) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`IDSERVICE`, `NOM`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `absence`
--
ALTER TABLE `absence`
  ADD PRIMARY KEY (`IDPERSONNEL`,`DATEDEBUT`),
  ADD KEY `I_FK_ABSENCE_MOTIF` (`IDMOTIF`),
  ADD KEY `I_FK_ABSENCE_PERSONNEL` (`IDPERSONNEL`);

--
-- Index pour la table `motif`
--
ALTER TABLE `motif`
  ADD PRIMARY KEY (`IDMOTIF`);

--
-- Index pour la table `personnel`
--
ALTER TABLE `personnel`
  ADD PRIMARY KEY (`IDPERSONNEL`),
  ADD KEY `I_FK_PERSONNEL_SERVICE` (`IDSERVICE`);

--
-- Index pour la table `service`
--
ALTER TABLE `service`
  ADD PRIMARY KEY (`IDSERVICE`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `motif`
--
ALTER TABLE `motif`
  MODIFY `IDMOTIF` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT pour la table `personnel`
--
ALTER TABLE `personnel`
  MODIFY `IDPERSONNEL` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=45;

--
-- AUTO_INCREMENT pour la table `service`
--
ALTER TABLE `service`
  MODIFY `IDSERVICE` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
