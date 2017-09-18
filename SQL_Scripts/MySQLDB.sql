-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema mysqlamqdatas
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mysqlamqdatas
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mysqlamqdatas` DEFAULT CHARACTER SET utf8 ;
USE `mysqlamqdatas` ;

-- -----------------------------------------------------
-- Table `mysqlamqdatas`.`tableclassify`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mysqlamqdatas`.`tableclassify` (
  `ClsID` INT(11) NOT NULL AUTO_INCREMENT,
  `altLim` INT(11) NULL DEFAULT NULL,
  `ustLim` INT(11) NULL DEFAULT NULL,
  `birLim` INT(11) NULL DEFAULT NULL,
  `someText` VARCHAR(255) NULL DEFAULT NULL,
  PRIMARY KEY (`ClsID`),
  UNIQUE INDEX `ClsID_UNIQUE` (`ClsID` ASC))
ENGINE = InnoDB
AUTO_INCREMENT = 6
DEFAULT CHARACTER SET = utf8;

-- -----------------------------------------------------
-- Instert default value to Table `mysqlamqdatas`.`tableclassify`
-- -----------------------------------------------------

INSERT INTO `mysqlamqdatas`.`tableclassify`(`altLim`,`ustLim`,`birLim`,`someText`)
VALUES(50,100,66,"default")


-- -----------------------------------------------------
-- Table `mysqlamqdatas`.`tablemydata`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mysqlamqdatas`.`tablemydata` (
  `ID` INT(11) NOT NULL AUTO_INCREMENT,
  `val` DOUBLE NULL DEFAULT NULL,
  `sometext` VARCHAR(200) NULL DEFAULT NULL,
  `recievedate` DATETIME NULL DEFAULT NULL,
  PRIMARY KEY (`ID`))
ENGINE = InnoDB
AUTO_INCREMENT = 142
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `mysqlamqdatas`.`tableerrorlog`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mysqlamqdatas`.`tableerrorlog` (
  `ErrorID` INT(11) NOT NULL AUTO_INCREMENT,
  `ErrDateTime` DATETIME NULL DEFAULT NULL,
  `ErrNote` VARCHAR(45) NULL DEFAULT NULL,
  `DataID` INT(11) NULL DEFAULT NULL,
  `ClsID` INT(11) NULL DEFAULT NULL,
  PRIMARY KEY (`ErrorID`),
  INDEX `ClsID_idx` (`ClsID` ASC),
  INDEX `DataID_idx` (`DataID` ASC),
  CONSTRAINT `ClsID`
    FOREIGN KEY (`ClsID`)
    REFERENCES `mysqlamqdatas`.`tableclassify` (`ClsID`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `DataID`
    FOREIGN KEY (`DataID`)
    REFERENCES `mysqlamqdatas`.`tablemydata` (`ID`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 128
DEFAULT CHARACTER SET = utf8;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
