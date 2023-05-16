-- --------------------------------------------------------
-- Sunucu:                       127.0.0.1
-- Sunucu sürümü:                8.0.21 - MySQL Community Server - GPL
-- Sunucu İşletim Sistemi:       Win64
-- HeidiSQL Sürüm:               11.0.0.5919
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- kutuphane için veritabanı yapısı dökülüyor
DROP DATABASE IF EXISTS `kutuphane`;
CREATE DATABASE IF NOT EXISTS `kutuphane` /*!40100 DEFAULT CHARACTER SET latin5 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `kutuphane`;

-- tablo yapısı dökülüyor kutuphane.kitaplar
DROP TABLE IF EXISTS `kitaplar`;
CREATE TABLE IF NOT EXISTS `kitaplar` (
  `kitap_id` int NOT NULL AUTO_INCREMENT,
  `tur_id` tinyint DEFAULT NULL,
  `kitapadi` varchar(40) DEFAULT '0',
  `yazar` varchar(40) DEFAULT NULL,
  `yayınevi` varchar(40) DEFAULT NULL,
  `sayfasayisi` smallint DEFAULT NULL,
  PRIMARY KEY (`kitap_id`),
  KEY `FK_kitaplar_kitapturleri` (`tur_id`),
  CONSTRAINT `FK_kitaplar_kitapturleri` FOREIGN KEY (`tur_id`) REFERENCES `kitapturleri` (`tur_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- kutuphane.kitaplar: ~0 rows (yaklaşık) tablosu için veriler indiriliyor
DELETE FROM `kitaplar`;
/*!40000 ALTER TABLE `kitaplar` DISABLE KEYS */;
/*!40000 ALTER TABLE `kitaplar` ENABLE KEYS */;

-- tablo yapısı dökülüyor kutuphane.kitapturleri
DROP TABLE IF EXISTS `kitapturleri`;
CREATE TABLE IF NOT EXISTS `kitapturleri` (
  `tur_id` tinyint NOT NULL AUTO_INCREMENT,
  `tur_adi` varchar(40) DEFAULT NULL,
  PRIMARY KEY (`tur_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- kutuphane.kitapturleri: ~0 rows (yaklaşık) tablosu için veriler indiriliyor
DELETE FROM `kitapturleri`;
/*!40000 ALTER TABLE `kitapturleri` DISABLE KEYS */;
/*!40000 ALTER TABLE `kitapturleri` ENABLE KEYS */;

-- tablo yapısı dökülüyor kutuphane.odunckitaplar
DROP TABLE IF EXISTS `odunckitaplar`;
CREATE TABLE IF NOT EXISTS `odunckitaplar` (
  `id` int NOT NULL AUTO_INCREMENT,
  `ogr_no` int DEFAULT NULL,
  `kitap_id` int DEFAULT NULL,
  `verilistarihi` date DEFAULT NULL,
  `teslimtarihi` date NOT NULL,
  `aciklama` varchar(200) NOT NULL DEFAULT '',
  PRIMARY KEY (`id`),
  KEY `fk_odunc_kitaplar_ogrenciler` (`ogr_no`),
  KEY `fk_odunc_kitaplar_kitaplar` (`kitap_id`),
  CONSTRAINT `fk_odunc_kitaplar_kitaplar` FOREIGN KEY (`kitap_id`) REFERENCES `kitaplar` (`kitap_id`),
  CONSTRAINT `fk_odunc_kitaplar_ogrenciler` FOREIGN KEY (`ogr_no`) REFERENCES `ogrenciler` (`ogrenci_no`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- kutuphane.odunckitaplar: ~0 rows (yaklaşık) tablosu için veriler indiriliyor
DELETE FROM `odunckitaplar`;
/*!40000 ALTER TABLE `odunckitaplar` DISABLE KEYS */;
/*!40000 ALTER TABLE `odunckitaplar` ENABLE KEYS */;

-- tablo yapısı dökülüyor kutuphane.ogrenciler
DROP TABLE IF EXISTS `ogrenciler`;
CREATE TABLE IF NOT EXISTS `ogrenciler` (
  `ogrenci_no` int NOT NULL,
  `ad` varchar(25) DEFAULT NULL,
  `soyad` varchar(25) DEFAULT NULL,
  `sinif` tinyint DEFAULT NULL,
  `cinsiyet` varchar(7) DEFAULT NULL,
  `telefon` varchar(12) DEFAULT NULL,
  PRIMARY KEY (`ogrenci_no`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- kutuphane.ogrenciler: ~0 rows (yaklaşık) tablosu için veriler indiriliyor
DELETE FROM `ogrenciler`;
/*!40000 ALTER TABLE `ogrenciler` DISABLE KEYS */;
INSERT INTO `ogrenciler` (`ogrenci_no`, `ad`, `soyad`, `sinif`, `cinsiyet`, `telefon`) VALUES
	(111, 'dsf', 'sdfs', 10, 'kız', '12324'),
	(123, 'Serkan', 'Aydın', 12, 'erkek', '123123'),
	(125, 'kübra', 'cgtl', 10, 'kız', '05453947787');
/*!40000 ALTER TABLE `ogrenciler` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
