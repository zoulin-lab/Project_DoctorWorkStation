IF DB_ID('DataBase_DoctorWorkStation') IS NOT NULL					
DROP DATABASE DataBase_DoctorWorkStation;				
CREATE DATABASE DataBase_DoctorWorkStation
ON						
	(NAME='DataFile_1'					
	,FILENAME='D:\���ݿ���ҵ-������ʦ\DataBase_DoctorWorkStation\DataFile_1.mdf')					
LOG ON						
	(NAME='LogFile_1'					
	,FILENAME='D:\���ݿ���ҵ-������ʦ\DataBase_DoctorWorkStation\LogFile_1.ldf');

DROP TABLE tb_Doctor
CREATE TABLE tb_Doctor
       (No
	    VARCHAR(6)
	    CONSTRAINT pk_Doctor_No	/*��������Լ��	*/							
	    PRIMARY KEY(No)		
	    NOT NULL,
	    Name
	    VARCHAR(20),
	    Password
	    VARCHAR(20)
	    NOT NULL,
	    Offices
	    VARCHAR(20)
	   )
DELETE tb_Doctor
INSERT tb_Doctor
       (No,Name,Password,Offices)
	   VALUES
	   ('D001','����',HashBytes('MD5','001'),'�ۿ�'),
	   ('D002','����',HashBytes('MD5','002'),'�ۿ�'),
	   ('D003','����',HashBytes('MD5','003'),'���ǿ�')

SELECT * FROM tb_Doctor
