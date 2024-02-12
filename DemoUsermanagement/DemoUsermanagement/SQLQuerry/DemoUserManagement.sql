/*CREATE TABLE UserDetails (
    UserID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    FathersName VARCHAR(50),
    MothersName VARCHAR(50),
    DateOfBirth DATE
);

CREATE TABLE AddressDetails (
    AddressID INT PRIMARY KEY,
    UserID INT FOREIGN KEY REFERENCES UserDetails(UserID),
    AddressType INT
);

CREATE TABLE Country (
    CountryID INT PRIMARY KEY
);

CREATE TABLE State (
    StateID INT PRIMARY KEY,
    CountryID INT FOREIGN KEY REFERENCES Country(CountryID)
);
*/
-- table Country add CountryName varchar(100);
--alter table State add StateName varchar(100);
-- Add 5 random country names to the Country table
/*INSERT INTO Country (CountryID,CountryName)
VALUES (1,'India'), (2,'United States'), (3,'United Kingdom'), (4,'Australia'), (5,'Canada');
-- Add 5 states for each country
DECLARE @IndiaID INT, @USID INT, @UKID INT, @AustraliaID INT, @CanadaID INT;


SELECT @IndiaID = CountryID FROM Country WHERE CountryName = 'India';
SELECT @USID = CountryID FROM Country WHERE CountryName = 'United States';
SELECT @UKID = CountryID FROM Country WHERE CountryName = 'United Kingdom';
SELECT @AustraliaID = CountryID FROM Country WHERE CountryName = 'Australia';
SELECT @CanadaID = CountryID FROM Country WHERE CountryName = 'Canada';

-- Add states for India
INSERT INTO State (StateID,StateName, CountryID) VALUES
(1,'Maharashtra', @IndiaID),
(2,'Uttar Pradesh', @IndiaID),
(3,'Bihar', @IndiaID),
(4,'West Bengal', @IndiaID),
(5,'Madhya Pradesh', @IndiaID);

-- Add states for United States
INSERT INTO State (StateID,StateName, CountryID) VALUES
(6,'California', @USID),
(7,'Texas', @USID),
(8,'Florida', @USID),
(9,'New York', @USID),
(10,'Illinois', @USID);

-- Add states for United Kingdom
INSERT INTO State (StateID,StateName, CountryID) VALUES
(11,'England', @UKID),
(12,'Scotland', @UKID),
(13,'Wales', @UKID),
(14,'Northern Ireland', @UKID),
(15,'London', @UKID);

-- Add states for Australia
INSERT INTO State (StateID,StateName, CountryID) VALUES
(16,'New South Wales', @AustraliaID),
(17,'Queensland', @AustraliaID),
(18,'Victoria', @AustraliaID),
(19,'Western Australia', @AustraliaID),
(20,'South Australia', @AustraliaID);

-- Add states for Canada
INSERT INTO State (StateID,StateName, CountryID) VALUES
(21,'Ontario', @CanadaID),
(22,'Quebec', @CanadaID),
(23,'British Columbia', @CanadaID),
(24,'Alberta', @CanadaID),
(25,'Manitoba', @CanadaID);
[dbo].[Country]
[dbo].[State]*/