DROP TABLE IF EXISTS `motif`;
DROP TABLE IF EXISTS `absence`;
DROP TABLE IF EXISTS `personnel`;
DROP TABLE IF EXISTS `service`;
DROP TABLE IF EXISTS `responsable`;

--
-- Privilèges pour `appmediatek_PC1`@`%`
--
CREATE USER 'appmediatek_PC1'@'%' IDENTIFIED BY '7P!qGm#d#8T9#nrb';
GRANT SELECT, INSERT, UPDATE, DELETE, FILE, CREATE TEMPORARY TABLES ON *.* TO `appmediatek_PC1`@`%`;
FLUSH PRIVILEGES;

--
-- Création de la table responsable
--

CREATE TABLE responsable (
    login VARCHAR(64) NOT NULL,
    pwd VARCHAR(64) NOT NULL
);

INSERT INTO responsable (login, pwd) VALUES 
('admin', SHA2('admin', 256));

--
-- Création de la table service
--

CREATE TABLE `service` (
    `idservice` INT NOT NULL,
    `nom` VARCHAR(255) DEFAULT NULL,
    PRIMARY KEY (`idservice`)
);

INSERT INTO service (`idservice`, `nom`) VALUES
(1, 'Administratif'),
(2, 'Médiation culturelle'),
(3, 'Prêt');

--
-- Création de la table personnel
--

CREATE TABLE `personnel` (
  `idpersonnel` INT NOT NULL AUTO_INCREMENT,
  `nom` VARCHAR(255) DEFAULT NULL,
  `prenom` VARCHAR(255) DEFAULT NULL,
  `tel` VARCHAR(100) DEFAULT NULL,
  `mail` VARCHAR(255) DEFAULT NULL,
  `idservice` INT DEFAULT NULL,
  PRIMARY KEY (`idpersonnel`),
  FOREIGN KEY (`idservice`) REFERENCES `service`(`idservice`)
);

INSERT INTO `personnel` (`nom`,`prenom`,`tel`,`mail`,`idservice`)
VALUES
  ("Ligonne","Dimitri","03 78 67 64 33","romeijndersdimitri5360@mediatek86.fr",1),
  ("Berger","Anissa","04 27 13 56 45","banissa@mediatek86.fr",3),
  ("Dumont","Laetitia","08 41 12 45 38","l.dumont9723@mediatek86.fr",3),
  ("Plamondon","Aline","04 21 98 87 33","plamondonaline1493@mediatek86.fr",3),
  ("Gagneux","Jessica","03 65 18 55 24","gagneuxjessica8256@mediatek86.fr",3),
  ("Ter Avest","Louis","01 50 86 12 73","teravest.louis@mediatek86.fr",2),
  ("Janvier","Hugo","09 84 32 85 13","janvier.hugo5542@mediatek86.fr",2),
  ("Dupont","Yannick","07 68 45 75 44","peerenboomyannick9800@mediatek86.fr",3),
  ("Jonker","Louise","03 87 23 41 56","louisejonker4867@mediatek86.fr",2),
  ("Haak","Louis","04 62 94 26 16","h.louis@mediatek86.fr",2);

--
-- Création de la table motif
--

CREATE TABLE `motif` (
    `idmotif` int NOT NULL,
    `libelle` varchar(255) DEFAULT NULL,
    PRIMARY KEY (`idmotif`)
    );

INSERT INTO motif (`idmotif`, `libelle`) VALUES
(1, 'Vacances'),
(2, 'Maladie'),
(3, 'Motif familial'),
(4, 'Congé parental');

--
-- Création de la table absence
--

CREATE TABLE `absence` (
    `idabsence` INT NOT NULL AUTO_INCREMENT,
    `datedebut` date DEFAULT NULL,
    `datefin` date DEFAULT NULL,
    `idmotif` int DEFAULT NULL,
    `idpersonnel` int DEFAULT NULL,
    PRIMARY KEY (`idabsence`),
    FOREIGN KEY (`idmotif`) REFERENCES `motif`(`idmotif`),
    FOREIGN KEY (`idpersonnel`) REFERENCES `personnel`(`idpersonnel`)
    );

--
-- Déchargement de la table absence. /!\ ATTENTION /!\ Les dates ici affichées sont possiblement, probablement, en conflit. L'application ne vérifie PAS si les absences existantes sont en conflit, mais le fait uniquement pour les ajouts ou les modifications. 
--

INSERT INTO `absence` (`datedebut`,`datefin`,`idmotif`,`idpersonnel`)
VALUES
  ("2024-10-23","2025-05-15",2,8),
  ("2024-11-01","2025-03-03",2,4),
  ("2024-12-29","2025-07-11",1,3),
  ("2024-06-05","2026-06-30",4,6),
  ("2024-07-30","2026-04-14",1,4),
  ("2024-08-25","2026-05-10",1,5),
  ("2024-09-28","2025-06-04",2,7),
  ("2024-07-03","2025-07-17",2,3),
  ("2024-09-12","2026-02-19",4,3),
  ("2024-09-05","2025-03-28",1,7),
  ("2024-08-08","2026-01-08",2,10),
  ("2024-10-01","2025-10-28",2,6),
  ("2024-07-15","2025-12-13",3,9),
  ("2024-07-10","2026-03-15",2,2),
  ("2024-06-21","2026-04-06",1,2),
  ("2024-08-22","2026-06-09",3,6),
  ("2024-06-28","2025-01-12",3,2),
  ("2024-11-02","2025-10-22",3,5),
  ("2024-08-15","2025-11-26",4,10),
  ("2024-11-22","2025-02-12",2,2),
 ("2024-10-20","2025-03-24",1,7),
  ("2024-09-22","2025-12-08",2,7),
  ("2024-12-08","2025-07-04",3,9),
  ("2024-12-05","2025-10-17",2,5),
  ("2024-08-21","2025-03-23",2,9),
  ("2024-09-12","2025-08-16",3,1),
  ("2024-06-10","2025-07-19",2,5),
  ("2024-12-16","2026-06-11",2,6),
  ("2024-06-17","2026-03-25",2,3),
  ("2024-12-26","2025-04-23",3,3);