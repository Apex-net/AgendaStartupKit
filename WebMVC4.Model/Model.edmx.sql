-- --------------------------------------------------
-- Entity Designer DDL Script for Oracle database
-- --------------------------------------------------
-- Date Created: 02/11/2015 12.49.10
-- Generated from EDMX file: C:\Work\StartupKit\WebMVC4.Model\Model.edmx
-- --------------------------------------------------

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------
-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

-- DROP TABLE "AGE_UTENTI";

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'AGE_UTENTI'
CREATE TABLE "UNIBOCCONI_AGE20_DEV"."AGE_UTENTI" (
   "UserId" VARCHAR2 (255 CHAR) NOT NULL,
   "Nome" NVARCHAR2 (50) ,
   "Cognome" NVARCHAR2 (50) 
);


-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on "UserId"in table 'AGE_UTENTI'
ALTER TABLE "UNIBOCCONI_AGE20_DEV"."AGE_UTENTI"
ADD CONSTRAINT "PK_AGE_UTENTI"
   PRIMARY KEY ("UserId" )
   ENABLE
   VALIDATE;


-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
