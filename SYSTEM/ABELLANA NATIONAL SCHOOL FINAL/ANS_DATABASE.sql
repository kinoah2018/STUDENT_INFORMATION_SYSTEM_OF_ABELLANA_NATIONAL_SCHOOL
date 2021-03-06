CREATE DATABASE ANS_DATABASE
USE ANS_DATABASE

USE MASTER
DROP DATABASE ANS_DATABASE


--------USER MASTER-FILE-------------------------------------------------------

CREATE TABLE TBL_USERS
(
USER_ID INT IDENTITY(1,1) PRIMARY KEY,
USER_LASTNAME VARCHAR(50) NOT NULL,
USER_FIRSTNAME VARCHAR(50) NOT NULL,
USER_MIDDLENAME VARCHAR(50) ,
USER_USERNAME VARCHAR(50) NOT NULL,
USER_PASSWORD VARCHAR(50) NOT NULL,
USER_CONTACT VARCHAR(50) NOT NULL,
ISACTIVE BIT DEFAULT 1,
USER_DATEADDED DATETIME DEFAULT GETDATE(),
USER_CREATOR VARCHAR(50) NOT NULL,
USER_TYPEID INT FOREIGN KEY REFERENCES TBL_USERTYPE(USER_TYPEID),
USER_IMAGE VARCHAR(MAX)
)

INSERT INTO TBL_USERS VALUES('Z','Z','Z','1','1234','Z',NULL,NULL,'A',1,'SDAFSDA');

select * from TBL_USERS
--------USERTYPE MASTER-FILE-------------------------------------------------------

CREATE TABLE TBL_USERTYPE
(
USER_TYPEID INT IDENTITY(1,1) PRIMARY KEY,
USER_TYPE VARCHAR(50)
)

-------- USER PROCEDURE SAVE ---------------------------------------------------

ALTER PROCEDURE SP_USERSAVE
@USER_LASTNAME VARCHAR (50),
@USER_FIRSTNAME VARCHAR (50),
@USER_MIDDLENAME VARCHAR (50),
@USER_USERNAME VARCHAR (50),
@USER_PASSWORD VARCHAR (MAX),
@USER_CONTACTNO VARCHAR (50), 
@USER_CREATOR VARCHAR (50),
@USER_TYPE INT,
@USER_IMAGE VARCHAR(MAX)
AS 
BEGIN
INSERT INTO TBL_USERS VALUES(@USER_LASTNAME,@USER_FIRSTNAME,@USER_MIDDLENAME,@USER_USERNAME,@USER_PASSWORD,@USER_CONTACTNO,NULL,NULL,@USER_CREATOR,@USER_TYPE,@USER_IMAGE);
END

-------- USER PROCEDURE UPDATE --------------------------------------------------

ALTER PROCEDURE SP_USERUPDATE
@USER_ID INT,
@USER_LASTNAME VARCHAR (50),
@USER_FIRSTNAME VARCHAR (50),
@USER_MIDDLENAME VARCHAR (50),
@USER_USERNAME VARCHAR (50),
@USER_CONTACT VARCHAR (50),
@ISACTIVE BIT,
@USER_DATEADDED DATETIME,
@USER_CREATOR VARCHAR (50),
@USER_IMAGE VARCHAR(MAX)
AS 
BEGIN
UPDATE TBL_USERS
SET USER_LASTNAME = @USER_LASTNAME, USER_FIRSTNAME = @USER_FIRSTNAME, USER_MIDDLENAME = @USER_MIDDLENAME,
	USER_USERNAME = @USER_USERNAME, USER_CONTACT = @USER_CONTACT, ISACTIVE = @ISACTIVE,
	USER_DATEADDED = @USER_DATEADDED, USER_CREATOR = @USER_CREATOR  ,USER_IMAGE = @USER_IMAGE
WHERE USER_ID = @USER_ID
END
---------PROCEDURE UPDATE PASSWORD--------------------------------------------------

ALTER PROCEDURE SP_CHANGEPASSWORD
@USER_ID INT,
@USER_PASSWORD VARCHAR(50)
AS
BEGIN
UPDATE TBL_USERS SET USER_PASSWORD = @USER_PASSWORD
WHERE USER_ID = @USER_ID
END
---------PROCEDURE VERIFY PASSWORD----------------------------------------------------

ALTER PROCEDURE SP_VERIFYPASSWORD
@USER_ID VARCHAR(50),
@USER_PASSWORD VARCHAR(MAX)
AS
BEGIN
SELECT USER_PASSWORD FROM TBL_USERS WHERE USER_PASSWORD = @USER_PASSWORD AND USER_ID = @USER_ID
END
-------- USER PROCEDURE VIEW ---------------------------------------------------------

ALTER PROCEDURE SP_USERVIEW
AS
BEGIN
SELECT * FROM TBL_USERS
END
-------- USER PROCEDURE VIEW ---------------------------------------------------------

ALTER PROCEDURE SP_USERSEARCH
@SEARCHKEY VARCHAR(MAX)
AS
BEGIN
SELECT * FROM TBL_USERS
WHERE USER_LASTNAME LIKE @SEARCHKEY + '%' 
END

-------STUENT MASTER-FILE--------------------------------------------------------------

CREATE TABLE TBL_STUDENT
(
ST_ID int identity(1,1) PRIMARY KEY,
ST_FIRSTNAME VARCHAR(50) NOT NULL,
ST_MIDDLENAME VARCHAR(50),
ST_LASTNAME VARCHAR(50) NOT NULL,
ST_YEARLEVEL VARCHAR(50) NOT NULL,
ST_SCHOOLYEAR VARCHAR(50) NOT NULL,
ST_BIRTHDATE DATE NOT NULL,
ST_AGE INT NOT NULL,
ST_BIRTHPLACE VARCHAR(50) NOT NULL,	
ST_ADDRESS VARCHAR(50) NOT NULL,
ST_GENDER VARCHAR(50) NOT NULL,
ST_CONTACTNUMBER VARCHAR(50),
ISACTIVE BIT DEFAULT 1,
ST_HEIGHT DECIMAL NOT NULL,
ST_WEIGHT DECIMAL NOT NULL,
ST_BLOODPRESSURE INT NOT NULL,
P_ID INT FOREIGN KEY REFERENCES TBL_PARENT(P_ID),
SEC_ID INT FOREIGN KEY REFERENCES TBL_SECTION(SEC_ID)
)
--------STUDENT PROCEDURE_SAVE---------------------------------------------------

CREATE PROCEDURE SP_STSAVE
@ST_FIRSTNAME VARCHAR(50),
@ST_MIDDLENAME VARCHAR(50),
@ST_LASTNAME VARCHAR(50),
@ST_YEARLEVEL VARCHAR(50),
@ST_SCHOOLYEAR VARCHAR(50),
@ST_BIRTHDATE DATE,
@ST_AGE INT,
@ST_BIRTHPLACE VARCHAR(50),	
@ST_ADDRESS VARCHAR(50),
@ST_GENDER VARCHAR(50),
@ST_CONTACTNUMBER VARCHAR(50),
@ISACTIVE BIT,
@ST_HEIGHT DECIMAL,
@ST_WEIGHT DECIMAL,
@ST_BLOODPRESSURE INT,
@P_ID INT,
@SEC_ID INT
AS
BEGIN
INSERT INTO TBL_STUDENT VALUES
(@ST_FIRSTNAME,@ST_MIDDLENAME,@ST_LASTNAME,@ST_YEARLEVEL,@ST_SCHOOLYEAR,@ST_BIRTHDATE,@ST_AGE,@ST_BIRTHPLACE,@ST_ADDRESS,@ST_GENDER,@ST_CONTACTNUMBER,@ISACTIVE,@ST_HEIGHT,@ST_WEIGHT,@ST_BLOODPRESSURE,@P_ID,@SEC_ID)
END

--------STUDENT PROCEDURE_UPDATE---------------------------------------------------

CREATE PROCEDURE SP_STUPDATE
@ST_ID INT,
@ST_FIRSTNAME VARCHAR(50),
@ST_MIDDLENAME VARCHAR(50),
@ST_LASTNAME VARCHAR(50),
@ST_YEARLEVEL VARCHAR(50),
@ST_SCHOOLYEAR VARCHAR(50),
@ST_BIRTHDATE DATE,
@ST_AGE INT,
@ST_BIRTHPLACE VARCHAR(50),	
@ST_ADDRESS VARCHAR(50),
@ST_GENDER VARCHAR(50),
@ST_CONTACTNUMBER VARCHAR(50),
@ISACTIVE BIT,
@ST_HEIGHT DECIMAL,
@ST_WEIGHT DECIMAL,
@ST_BLOODPRESSURE INT,
@P_ID INT,
@SEC_ID INT
AS
BEGIN
UPDATE TBL_STUDENT
SET	   ST_FIRSTNAME=@ST_FIRSTNAME,ST_MIDDLENAME=@ST_MIDDLENAME,ST_LASTNAME=@ST_LASTNAME,ST_YEARLEVEL=@ST_YEARLEVEL,ST_BIRTHDATE=@ST_BIRTHDATE,ST_ADDRESS=@ST_ADDRESS,
	   ST_GENDER=@ST_GENDER,ST_CONTACTNUMBER=@ST_CONTACTNUMBER,ISACTIVE=@ISACTIVE,ST_HEIGHT=@ST_HEIGHT,ST_WEIGHT=@ST_WEIGHT,ST_BLOODPRESSURE=@ST_BLOODPRESSURE,P_ID=@P_ID,
	   SEC_ID=@SEC_ID
WHERE  ST_ID = @ST_ID
END

--------STUDENT PROCEDURE_VIEW---------------------------------------------------

CREATE PROCEDURE SP_STVIEW
AS
BEGIN
SELECT * FROM TBL_STUDENT
END

--------STUDENT PROCEDURE_SEARCH---------------------------------------------------

CREATE PROCEDURE SP_STSEARCH
@SEARCH_KEY VARCHAR(MAX)
AS
BEGIN
SELECT * FROM TBL_STUDENT 
WHERE ST_FIRSTNAME LIKE @SEARCH_KEY + '%' OR ST_LASTNAME LIKE @SEARCH_KEY + '%'
END

--------PARENT MASTER-FILE-------------------------------------------------------------

CREATE TABLE TBL_PARENT 
(
P_ID INT IDENTITY(1,1) PRIMARY KEY,
P_NAME VARCHAR(50) NOT NULL,
P_CONTACT VARCHAR(50) NOT NULL,
P_OCCUPATION VARCHAR(50) NOT NULL,
P_TYPE VARCHAR(50) NOT NULL
)

--------GRADE MASTER-FILE-------------------------------------------------------------

CREATE TABLE TBL_GRADE
(
GRADE_ID INT IDENTITY(1,1) PRIMARY KEY,
ST_ID INT FOREIGN KEY REFERENCES TBL_STUDENT(ST_ID),
GRADEPERIOD VARCHAR(50) NOT NULL,
GRADE DECIMAL NOT NULL,
GRADESUBJECT VARCHAR(50) NOT NULL,
SUBJECT_ID INT FOREIGN KEY REFERENCES TBL_SUBJECT(SUBJECT_ID)
)

--------SUBJECT MASTER-FILE------------------------------------------------------------

CREATE TABLE TBL_SUBJECT
(
SUBJECT_ID INT IDENTITY(1,1) PRIMARY KEY,
SUBJECT VARCHAR(50) NOT NULL
)

--------SECTIONSUBJECT MASTER-FILE-----------------------------------------------------

CREATE TABLE TBL_SECTIONSUBJECT
(
SECSUB_ID INT IDENTITY(1,1) PRIMARY KEY,
SUBJECT_ID INT  FOREIGN KEY REFERENCES TBL_SUBJECT(SUBJECT_ID),
SEC_ID INT  FOREIGN KEY REFERENCES TBL_SECTION(SEC_ID),
)

--------SECTION MASTER-FILE------------------------------------------------------------

CREATE TABLE TBL_SECTION
(
SEC_ID INT IDENTITY(1,1) PRIMARY KEY,
SEC_NAME VARCHAR(50) NOT NULL,SEC_CAPACITY INT NOT NULL
)

--------REQUIRMENTS MASTER-FILE--------------------------------------------------------

CREATE TABLE TBL_REQUIRMENTS
(
REQ_ID INT IDENTITY(1,1) PRIMARY KEY,
REQ_NAME VARCHAR(50) NOT NULL,
REQ_DETAILS VARCHAR(50) NOT NULL,
ST_ID INT FOREIGN KEY REFERENCES TBL_STUDENT(ST_ID),
REQ_ADDED DATETIME NOT NULL
)

--------BOOKS MASTER-FILE--------------------------------------------------------------

CREATE TABLE TBL_BOOKS
(
B_ID INT IDENTITY(1,1) PRIMARY KEY,
B_BOOKNAME VARCHAR (50) NOT NULL,
B_YEARLEVEL VARCHAR (50) NOT NULL
)

--------PAYMENTDETAILS MASTER-FILE-----------------------------------------------------

CREATE TABLE TBL_PAYMENTDETAILS
(
PD_ID INT IDENTITY(1,1) PRIMARY KEY,
ST_ID INT FOREIGN KEY REFERENCES TBl_STUDENT(ST_ID),
PAYMENTDESC VARCHAR(50) NOT NULL,
PAYMENTAMOUNT MONEY NOT NULL
)

--------TEACHER MASTER-FILE-------------------------------------------------------------

CREATE TABLE TBL_TEACHER
(
T_ID INT IDENTITY(1,1) PRIMARY KEY,
T_FIRSTNAME  VARCHAR(50) NOT NULL,
T_MIDDLENAME VARCHAR(50),
T_LASTNAME VARCHAR(50) NOT NULL,
T_GENDER VARCHAR(50) NOT NULL,
T_BIRTHDATE DATE NOT NULL,
ISACTIVE BIT,
T_CONTACTNUMBER VARCHAR(50) NOT NULL,
SEC_ID INT  FOREIGN KEY REFERENCES TBL_SECTION(SEC_ID),
)

--------TEACHERSECTION MASTER-FILE------------------------------------------------------

CREATE TABLE TBL_TEACHERSECTION
(
TS_ID INT IDENTITY(1,1) PRIMARY KEY,
SECSUB_ID INT  FOREIGN KEY REFERENCES TBL_SECTION(SEC_ID)
)

--------TEACHERSCHEDULE MASTER-FILE-----------------------------------------------------

CREATE TABLE TBL_TEACHERSCHEDULE
(
TSCHED_ID INT IDENTITY(1,1) PRIMARY KEY,
TS_ID INT FOREIGN KEY REFERENCES TBL_TEACHERSECTION(TS_ID),
TIMESTART TIME NOT NULL,
TIMEEND TIME NOT NULL
)

