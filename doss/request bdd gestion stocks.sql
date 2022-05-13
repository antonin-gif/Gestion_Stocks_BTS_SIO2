DROP DATABASE IF EXISTS APPGESTIONDESTOCKS;

CREATE DATABASE IF NOT EXISTS APPGESTIONDESTOCKS;
USE APPGESTIONDESTOCKS;
# -----------------------------------------------------------------------------
#       TABLE : USER
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS USER
 (
   ID INTEGER(2) NOT NULL AUTO_INCREMENT  ,
   PRENOM VARCHAR(128) NOT NULL  ,
   NOM VARCHAR(128) NOT NULL  ,
   MAIL VARCHAR(128) NOT NULL  ,
   MDP VARCHAR(128) NOT NULL  
   , PRIMARY KEY (ID) 
 ) ;

# -----------------------------------------------------------------------------
#       TABLE : FACTURE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS FACTURE
 (
   ID INTEGER(2) NOT NULL AUTO_INCREMENT  ,
   ID_CLIENT INTEGER(2) NOT NULL  ,
   ADRESSE VARCHAR(128) NOT NULL  ,
   DATELIVRAISONFACTURE DATE NOT NULL  ,
   DATEFACTURE DATE NOT NULL  ,
   LIVRAISONEFFECTUEE BOOL NOT NULL  ,
   PRIXFACTURE INTEGER(2) NOT NULL  
   , PRIMARY KEY (ID) 
 ) ;


# -----------------------------------------------------------------------------
#       TABLE : FOURNISSEUR
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS FOURNISSEUR
 (
   ID INTEGER(2) NOT NULL AUTO_INCREMENT  ,
   NOM VARCHAR(128) NOT NULL  ,
   ADRESSE VARCHAR(128) NOT NULL  ,
   MAIL VARCHAR(128) NOT NULL  ,
   TELEPHONE VARCHAR(128) NOT NULL  
   , PRIMARY KEY (ID) 
 ) ;

# -----------------------------------------------------------------------------
#       TABLE : COMMANDE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS COMMANDE
 (
   ID INTEGER(2) NOT NULL AUTO_INCREMENT  ,
   ID_FOURNISSEUR INTEGER(2) NOT NULL  ,
   DATELIVRAISONCOMMANDE DATE NOT NULL  ,
   DATECOMMANDE DATE NOT NULL  ,
   PRIXCOMMANDE INTEGER(2) NOT NULL  ,
   LIVRAISONCOMMANDEEFFECTUEE BOOL NOT NULL  
   , PRIMARY KEY (ID) 
 ) ;

# -----------------------------------------------------------------------------
#       TABLE : CLIENT
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS CLIENT
 (
   ID INTEGER(2) NOT NULL AUTO_INCREMENT  ,
   NOM VARCHAR(128) NOT NULL  ,
   PRENOM VARCHAR(128) NOT NULL  ,
   TELEPHONE VARCHAR(128) NOT NULL  
   , PRIMARY KEY (ID) 
 ) ;

# -----------------------------------------------------------------------------
#       TABLE : PRODUIT
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS PRODUIT
 (
   ID INTEGER(2) NOT NULL AUTO_INCREMENT  ,
   ID_EMPLACEMENT INTEGER(2) NOT NULL  ,
   NOM VARCHAR(128) NOT NULL  ,
   POIDS INTEGER(2) NOT NULL  ,
   PRIXVENTE INTEGER(2) NOT NULL  
   , PRIMARY KEY (ID) 
 ) ;

# -----------------------------------------------------------------------------
#       TABLE : EMPLACEMENT_STOCK
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS EMPLACEMENT_STOCK
 (
   ID INTEGER(2) NOT NULL AUTO_INCREMENT  ,
   ALLEE CHAR(32) NOT NULL  ,
   PLACE INTEGER(2) NOT NULL  ,
   ETAGE INTEGER(2) NOT NULL  
   , PRIMARY KEY (ID) 
 ) ;

# -----------------------------------------------------------------------------
#       TABLE : COMMANDESDETAILS
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS COMMANDESDETAILS
 (
   ID_COMMANDE INTEGER(2) NOT NULL  ,
   ID_PRODUIT INTEGER(2) NOT NULL  ,
   QUANTITEPRODUITSACHETES INTEGER(2) NOT NULL  ,
   PRIX INTEGER(2) NOT NULL  
   , PRIMARY KEY (ID_COMMANDE,ID_PRODUIT) 
 ); 

# -----------------------------------------------------------------------------
#       TABLE : FACTURATION
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS FACTURATION
 (
   ID_PRODUIT INTEGER(2) NOT NULL  ,
   ID_FACTURE INTEGER(2) NOT NULL  ,
   QUANTITEPRODUITSVENDUS INTEGER(2) NOT NULL  ,
   PRIX INTEGER(2) NOT NULL
   , PRIMARY KEY (ID_PRODUIT,ID_FACTURE) 
 ); 

# -----------------------------------------------------------------------------
#       CREATION DES REFERENCES DE TABLE
# -----------------------------------------------------------------------------


ALTER TABLE FACTURE 
  ADD FOREIGN KEY FK_FACTURE_CLIENT (ID_CLIENT)
      REFERENCES CLIENT (ID) ;


ALTER TABLE COMMANDE 
  ADD FOREIGN KEY FK_COMMANDE_FOURNISSEUR (ID_FOURNISSEUR)
      REFERENCES FOURNISSEUR (ID) ;


ALTER TABLE PRODUIT 
  ADD FOREIGN KEY FK_PRODUIT_EMPLACEMENT_STOCK (ID_EMPLACEMENT)
      REFERENCES EMPLACEMENT_STOCK (ID) ;


ALTER TABLE COMMANDESDETAILS 
  ADD FOREIGN KEY FK_COMMANDESDETAILS_COMMANDE (ID_COMMANDE)
      REFERENCES COMMANDE (ID) ;


ALTER TABLE COMMANDESDETAILS 
  ADD FOREIGN KEY FK_COMMANDESDETAILS_PRODUIT (ID_PRODUIT)
      REFERENCES PRODUIT (ID) ;


ALTER TABLE FACTURATION 
  ADD FOREIGN KEY FK_FACTURATION_PRODUIT (ID_PRODUIT)
      REFERENCES PRODUIT (ID) ;


ALTER TABLE FACTURATION 
  ADD FOREIGN KEY FK_FACTURATION_FACTURE (ID_FACTURE)
      REFERENCES FACTURE (ID) ;