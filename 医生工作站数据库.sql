IF DB_ID('DataBase_DoctorWorkStation') IS NOT NULL					
DROP DATABASE DataBase_DoctorWorkStation;				
CREATE DATABASE DataBase_DoctorWorkStation
ON						
	(NAME='DataFile_1'					
	,FILENAME='D:\数据库作业-林立老师\DataBase_DoctorWorkStation\DataFile_1.mdf')					
LOG ON						
	(NAME='LogFile_1'					
	,FILENAME='D:\数据库作业-林立老师\DataBase_DoctorWorkStation\LogFile_1.ldf');

DROP TABLE tb_Doctor
CREATE TABLE tb_Doctor
       (No
	    VARCHAR(10)
	    CONSTRAINT pk_Doctor_No	/*创建主键约束	*/							
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
	   ('D001','张三',HashBytes('MD5','001'),'呼吸内科'),
	   ('D002','李四',HashBytes('MD5','002'),'眼科'),
	   ('D003','王五',HashBytes('MD5','003'),'消化内科')

SELECT * FROM tb_Doctor
DROP TABLE tb_Patient
CREATE TABLE tb_Patient
       (No
	   VARCHAR(10)
	   CONSTRAINT pk_Patient_No	/*创建主键约束	*/							
	   PRIMARY KEY(No)		
	   NOT NULL,
	   Name
	   VARCHAR(20),
	   Gender
	   BIT,
	   Age
	   INT,
	   IsMarried  --婚否
	   BIT,
	   Nation     --民族
	   VARCHAR(20),
	   Career     --职别（身份）
	   VARCHAR(20),
	   Address    --籍贯
	   VARCHAR(200),
	   WorkPlace  --单位
	   VARCHAR(200),
	   Birthday
	   DATE,
	   Picture
	   VARBINARY(MAX))
delete tb_Patient
INSERT tb_Patient
       (No,Name,Gender,Age,IsMarried,Nation,Career,Address,WorkPlace,Birthday)
	   VALUES
	   ('0005','李焕',1,30,1,'汉','律师','福建福州','福州律师事务所','1991/01/01'),
	   ('1143868','赵春兰',0,21,0,'汉','幼师','福建福州','福州春天幼儿园','2000/01/01'),
	   ('1225754','韩凤革',1,50,1,'汉','高中教师','福建厦门','厦门第一中学','1971/01/01')

SELECT * FROM tb_Patient

DROP TABLE tb_MedicalRecord
CREATE TABLE tb_MedicalRecord
       (No
	   VARCHAR(10)
	   NOT NULL,
	   ThisNo  --本次住院ID
	   VARCHAR(10)
	   NOT NULL,
	   Name
	   VARCHAR(20),
	   InHospitalNo  --住院号
	   VARCHAR(10),
	   InHospitalCount  --住院次数
	   INT,
	   BedNo  --床号
	   VARCHAR(10),
	   OfficesNo  --入院科室
	   INT,
	   InDate  --入院日期
	   DATE, 
	   MainDiagnoseContent  --主要诊断
	   VARCHAR(200),
	   Doctor  --医生
	   VARCHAR(20),
	   OtherSitiuation  --转科情况
	   VARCHAR(200),
	   OutOfficesNo  --出院科室
	   INT,
	   OutDate
	   DATE,
	   CONSTRAINT pk_MedicalRecord_No_TiHsNo	/*创建主键约束	*/							
	   PRIMARY KEY(No,ThisNo))	


DELETE tb_MedicalRecord
INSERT tb_MedicalRecord
       (No,ThisNo,Name,InHospitalNo,InHospitalCount,BedNo,OfficesNo,InDate,MainDiagnoseContent,Doctor,OtherSitiuation,OutOfficesNo,OutDate)
	   VALUES
	   ('0005','M0001','李焕','I0001',2,'0001',1,'2020/04/01','呼吸道感染','张三','','',''),
	   ('1143868','M0002','赵春兰','I0002',1,'0002',4,'2020/04/01','泌尿感染','钱六','','',''),
	   ('1225754','M0003','韩凤革','I0003',4,'0003',3,'2020/04/01','蛛网膜下出血','李四','','','')

SELECT * FROM tb_MedicalRecord 

DROP TABLE tb_Offices
CREATE TABLE tb_Offices
       (OfficesNo
	   INT
	   CONSTRAINT pk_Offices_OfficesNo	/*创建主键约束	*/							
	   PRIMARY KEY(OfficesNo)		
	   NOT NULL,
	   Name
	   VARCHAR(20))

INSERT tb_Offices
       (OfficesNo,Name)
	   VALUES
	   (1,'呼吸内科'),
	   (2,'消化内科'),
	   (3,'眼科'),
	   (4,'内分泌科')

	   SELECT p.No AS Patient,p.Name,p.Gender,p.Career,p.Birthday,mr.InHospitalNo,MR.InHospitalCount,MR.OfficesNo,p.Picture,mr.InDate,MR.OutOfficesNo,MR.OutDate,MR.OtherSitiuation
	   FROM tb_Patient AS P JOIN tb_MedicalRecord AS MR ON P.No=MR.No
	   WHERE P.No='1143868'
	   
	   --更新两张表
	   BEGIN TRAN
	   UPDATE tb_Patient 
	   SET Name='',Gender='',Career='',Birthday=''
	   WHERE No=''
	   UPDATE tb_MedicalRecord
	   SET InHospitalNo='',InHospitalCount='',OfficesNo='',InDate='',OtherSitiuation='',OutOfficesNo='',OutDate=''
	   WHERE No=''
	   COMMIT



	    SELECT * FROM tb_Offices






