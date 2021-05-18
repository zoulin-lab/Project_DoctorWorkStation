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
	    OfficeNo
	    int
	   )

DELETE tb_Doctor
INSERT tb_Doctor
       (No,Name,Password,OfficeNo)
	   VALUES
	   ('D001','魏爱东',HashBytes('MD5','001'),1),
	   ('D002','李君',HashBytes('MD5','002'),4),
	   ('D003','周彩云',HashBytes('MD5','003'),3),
	   ('D004','马勇',HashBytes('MD5','004'),2),
	   ('D005','梁一一',HashBytes('MD5','005'),1),
	   ('D006','张强',HashBytes('MD5','006'),1),
	   ('D007','王小二',HashBytes('MD5','007'),1)
select * from tb_Doctor

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

CREATE TABLE tb_Bed
       (No
	   INT
	   CONSTRAINT pk_Bed_No	/*创建主键约束	*/							
	   PRIMARY KEY(No)		
	   NOT NULL,
	   Name
	   VARCHAR(20))

	   delete tb_Bed
INSERT tb_Bed
       (No,Name)
	   VALUES
	   (1,'0001'),(2,'0002'),(3,'0003'),(4,'0004'),(5,'0005'),
	   (6,'0006'),(7,'0007'),(8,'0008'),(9,'0009'),(10,'0010'),
	   (11,'0011'),(12,'0012'),(13,'0013'),(14,'0014'),(15,'0015'),
	   (16,'0016'),(17,'0017'),(18,'0018'),(19,'0019'),(20,'0020')

select No,Name from tb_Bed where Name not in(select BedNo from tb_MedicalRecord) 



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
	   VARCHAR(5),
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
	   OfficeNo
	   int,
	   Picture
	   VARBINARY(MAX))
delete tb_Patient
INSERT tb_Patient
       (No,Name,Gender,IsMarried,Nation,Career,Address,WorkPlace,Birthday,OfficeNo)
	   VALUES
	   ('0015','张七','男',1,'汉','律师','福建福州','福州律师事务所','1991/01/01',1),
	   ('0016','张八','女',0,'汉','学生','福建漳州','XX','2010/01/01',1),
	   ('0017','张九','女',3,'汉','大学生','福建福州','XX','2003/01/01',1),
	   ('0018','张十','男',1,'汉','律师','福建福州','福州律师事务所','1991/01/01',1),
	   ('0019','张十一','女',0,'汉','学生','福建漳州','XX','2010/01/01',1),
	   ('0020','张十二','女',3,'汉','大学生','福建福州','XX','2003/01/01',1),

	   ('0005','李焕','男',1,'汉','律师','福建福州','福州律师事务所','1991/01/01',1),
	   ('1143868','赵春兰','女',0,'汉','幼师','福建福州','福州春天幼儿园','2000/01/01',4),
	   ('1225754','韩凤革','男',1,'汉','高中教师','福建厦门','厦门第一中学','1971/01/01',3),
	   ('1213180','张久礼','男',1,'汉','工人','四川成都','XX','1976/01/01',4),
	   ('1217483','孙桂菊','女',0,'汉','大学生','江苏常州','XX','2001/01/01',4),
	   ('1221686','刘海峰','男',0,'汉','画师','福建厦门','XX','1988/01/01',4),
	   ('1225980','马乃双','女',0,'汉','大学生','福建长乐','XX','1999/01/01',4),
	   ('1216315','郭建峰','男',0,'汉','写手','福建福州','XX','1996/01/01',3),
	   ('1133395','王研','女',0,'汉','学生','福建漳州','XX','2010/01/01',3),
	   ('1228012','孙兰芹','女',3,'汉','大学生','福建福州','XX','2003/01/01',3),
	   ('0006','李焕二','男',1,'汉','律师','福建福州','福州律师事务所','1991/01/01',1),
	   ('0007','焕二','女',0,'汉','学生','福建漳州','XX','2010/01/01',4),
	   ('0008','李三','女',3,'汉','大学生','福建福州','XX','2003/01/01',3),
	   ('0009','张一','男',1,'汉','律师','福建福州','福州律师事务所','1991/01/01',1),
	   ('0010','张二','女',0,'汉','学生','福建漳州','XX','2010/01/01',1),
	   ('0011','张三','女',3,'汉','大学生','福建福州','XX','2003/01/01',1),
	   ('0012','张四','男',1,'汉','律师','福建福州','福州律师事务所','1991/01/01',2),
	   ('0013','张五','女',0,'汉','学生','福建漳州','XX','2010/01/01',2),
	   ('0014','张六','女',3,'汉','大学生','福建福州','XX','2003/01/01',2)

SELECT * FROM tb_Patient 

DROP TABLE tb_MedicalRecord
CREATE TABLE tb_MedicalRecord
       (No
	   VARCHAR(10)
	   NOT NULL,
	   ThisNo  --本次住院ID(住院号)
	   VARCHAR(10)
	   NOT NULL,
	   Name
	   VARCHAR(20),
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
	   IsToHospital  --是否住院（状态）
	   BIT,
	   Category
	   BIT,
	   CONSTRAINT pk_MedicalRecord_No_TiHsNo	/*创建主键约束	*/							
	   PRIMARY KEY(No,ThisNo))	


DELETE tb_MedicalRecord
INSERT tb_MedicalRecord
       (No,ThisNo,Name,InHospitalCount,BedNo,OfficesNo,InDate,MainDiagnoseContent,Doctor,OtherSitiuation,OutOfficesNo,OutDate,IsToHospital,Category)
	   VALUES
	   ('0005','M0001','李焕',2,'0001',1,'2020/04/01','呼吸道感染','魏爱东','','','',1,1),
	   ('1143868','M0002','赵春兰',1,'0002',4,'2020/04/01','泌尿感染','李君','','','',1,1),
	   ('1225754','M0003','韩凤革',4,'0003',3,'2020/04/07','蛛网膜下出血','周彩云','','','',1,0),
	   ('1213180','M0004','张久礼',1,'0004',4,'2020/04/01','尿毒症','李君','','','',0,0),
	   ('1217483','M0005','孙桂菊',4,'0005',4,'2020/04/03','待查','李君','','','',1,1),
	   ('1221686','M0006','刘海峰',3,'0006',4,'2020/04/08','发烧待查','李君','','','',0,0),
	   ('1225980','M0007','马乃双',2,'0007',4,'2020/04/09','待查','李君','','','',0,1),
	   ('1216315','M0008','郭建峰',2,'0008',3,'2020/04/01','视网膜下出血','周彩云','','','',0,0),
	   ('1133395','M0009','王研',1,'0009',3,'2020/04/01','待查','周彩云','','','',0,1),
	   ('1228012','M0010','孙兰芹',1,'0010',3,'2020/04/01','待查','魏爱东','','','',0,0)
INSERT tb_MedicalRecord
       (No,ThisNo,Name,InHospitalCount,BedNo,OfficesNo,InDate,MainDiagnoseContent,Doctor,OtherSitiuation,OutOfficesNo,OutDate,IsToHospital,Category)
	   VALUES
	   ('0006','M0011','李焕二',2,'0011',1,'2020/04/01','呼吸道感染','魏爱东','','','',1,1),
	   ('0007','M0012','焕二',1,'0012',4,'2020/04/01','泌尿感染','李君','','','',1,1),
	   ('0008','M0013','李三',4,'0013',3,'2020/04/07','蛛网膜下出血','周彩云','','','',1,0)


SELECT * FROM tb_MedicalRecord 

SELECT No,InHospitalNo,Name,BedNo,MainDiagnoseContent,Doctor FROM tb_MedicalRecord




	   SELECT p.No AS Patient,p.Name,p.Gender,p.Career,p.Birthday,mr.ThisNo,MR.InHospitalCount,MR.OfficesNo,p.Picture,mr.InDate,MR.OutOfficesNo,MR.OutDate,MR.OtherSitiuation
	   FROM tb_Patient AS P JOIN tb_MedicalRecord AS MR ON P.No=MR.No
	   WHERE p.Name=''
	   
	   --更新两张表
	   BEGIN TRAN
	   UPDATE tb_Patient 
	   SET Name='',Gender='',Career='',Birthday=''
	   WHERE Name=''
	   UPDATE tb_MedicalRecord
	   SET InHospitalNo='',InHospitalCount='',OfficesNo='',InDate='',OtherSitiuation='',OutOfficesNo='',OutDate=''
	   WHERE Name=''
	   COMMIT



	    SELECT * FROM tb_Patient
		SELECT * FROM tb_MedicalRecord
		SELECT No,InHospitalNo,Name,BedNo,MainDiagnoseContent,Doctor FROM tb_MedicalRecord

		SELECT MR.No,MR.InHospitalNo,MR.Name,P.Gender,MR.BedNo,MR.MainDiagnoseContent,MR.Doctor 
		FROM tb_Patient AS P
		JOIN tb_MedicalRecord AS MR ON P.No=MR.No
		WHERE IsToHospital=1
		ORDER BY InHospitalNo


		SELECT MR.No AS 病人ID,MR.InHospitalNo AS 住院号,MR.Name AS 姓名,P.Gender AS 性别,MR.BedNo AS 床号,MR.MainDiagnoseContent AS 主要诊断,MR.Doctor AS 经治医生 
                                       FROM tb_Patient AS P
                                       JOIN tb_MedicalRecord AS MR ON P.No = MR.No
                                       WHERE IsToHospital = 0
                                       ORDER BY InHospitalNo


		SELECT MR.No,P.Gender,MR.Name,MR.ThisNo FROM tb_MedicalRecord AS MR
		JOIN tb_Patient AS P ON MR.No=P.No
		WHERE Doctor='李君' AND IsToHospital=0


CREATE TABLE tb_DoctorAdviceCategory
       (No
	   INT
	   CONSTRAINT pk_DoctorAdviceCategory_No	/*创建主键约束	*/							
	   PRIMARY KEY(No)		
	   NOT NULL,
	   Name
	   VARCHAR(20))

INSERT tb_DoctorAdviceCategory
       (No,Name)
	   VALUES
	   (1,'药疗'),
	   (2,'处置'),
	   (3,'护理'),
	   (4,'膳食'),
	   (5,'检查'),
	   (6,'检验'),
	   (7,'手术'),
	   (8,'麻醉')

SELECT * FROM tb_DoctorAdviceCategory

DROP TABLE tb_DoctorAdvice
CREATE TABLE tb_DoctorAdvice
       (No
	   INT
	   NOT NULL,
	   LongOrShort
	   VARCHAR(20),
	   CategoryNo
	   INT,
	   Content
	   VARCHAR(255),
	   HowMuch
	   VARCHAR(20),
	   Nnit     --单位
	   VARCHAR(20),
	   Way
	   VARCHAR(20),
	   Frequency
	   VARCHAR(20),
	   Combo  --套餐
	   VARCHAR(20),
	   --StartTime
	   --DateTime,
	   --DoDateTime
	   --DateTime,
	   --StopDateTime
	   --DateTime,
	   CONSTRAINT pk_DoctorAdvice_No_Combo	/*创建主键约束	*/							
	   PRIMARY KEY(No,Combo)	
	   )

DELETE tb_DoctorAdvice
INSERT tb_DoctorAdvice
       (No,LongOrShort,CategoryNo,Content,HowMuch,Nnit,Way,Frequency,Combo)
	   VALUES
	   (1,'长期',3,'二级护理','','','','','套餐一'),
	   (2,'长期',4,'半流食','','','','','套餐一'),
	   (3,'长期',1,'先锋霉素IV号','1','g','口服','3/1日','套餐一'),
	   (4,'长期',1,'10%葡萄糖注射液','250','ml','静滴','1/1日','套餐一')

SELECT * FROM tb_DoctorAdvice 
SELECT LongOrShort,CategoryNo,Content,HowMuch,Nnit,Way,Frequency FROM tb_DoctorAdvice AS DA 
JOIN tb_DoctorAdviceCategory AS DAC ON DA.CategoryNo=DAC.No

INSERT tb_DoctorAdvice
       (No,LongOrShort,CategoryNo,Content,HowMuch,Nnit,Way,Frequency,Combo)
	   VALUES
	   (1,'长期',3,'二级护理','','','','','套餐一')

SELECT distinct COUNT(1) FROM tb_DoctorAdvice WHERE Combo='套餐一'


DROP TABLE tb_Medicines
CREATE TABLE tb_Medicines
       (No
	   INT
	   CONSTRAINT pk_Medicines_No	/*创建主键约束	*/							
	   PRIMARY KEY(No)		
	   NOT NULL,
	   CName
	   VARCHAR(255),
	   EName
	   VARCHAR(255),
	   PharmacologicalActions
	   VARCHAR(255),
	   Usage
	   VARCHAR(255),
	   Taboo
	   VARCHAR(255)
	   )

INSERT tb_Medicines
       (No,CName,EName,PharmacologicalActions,Usage,Taboo)
	   VALUES
	   (1,'复方氨酚烷胺片','FuFangAnFenWanPian'
	   ,'适用于缓解普通感冒及流行性感冒引起的发热、头痛、四肢酸痛、打喷嚏、流鼻涕、鼻塞、咽痛等症状。'
	   ,'口服。成人，一次1片，一日2次。'
	   ,'严重肝肾功能不全者禁用。'),
	   (2,'小儿肺热咳喘口服液','XiaoErFeiReKeChuanKouFuYe'
	   ,'清热解毒，宣肺化痰，用于热邪犯于肺卫所致发热、汗出、微恶风寒、咳嗽、痰黄，或兼喘息、口干而渴。'
	   ,'口服，1岁至3岁每次10毫升，一日3次；4岁至7岁每次10毫升，一日4次；8岁至12岁每次20毫升，一日3次。'
	   ,'尚不明确。'),
	   (3,'复方丹参片','FuFangDanShenPian'
	   ,'详见说明书。'
	   ,'口服。'
	   ,'尚不明确。')

SELECT No,ThisNo,Name,BedNo,MainDiagnoseContent,Doctor from tb_MedicalRecord
select * from tb_MedicalRecord

drop table tb_Template
CREATE TABLE tb_Template
       (No
	   INT
	   Identity(1,1)
	   CONSTRAINT pk_Tamplate_No	/*创建主键约束	*/							
	   PRIMARY KEY(No)		
	   NOT NULL,
	   Name
	   VARCHAR(20),
	   Category
	   VARCHAR(20)
	   )

INSERT tb_Template
       (Name,Category)
	   VALUES
	   ('会议记录','科室'),
	   ('入科记录','个人'),
	   ('病历模板一','公用')

DELETE tb_Template 
INSERT tb_Template(Name,Category) VALUES ('1','1')

drop table tb_DoctorChooseTemplate
CREATE TABLE tb_DoctorChooseTemplate
       (DoctorNo
	   varchar(10)	  
	   NOT NULL,
	   TemplateNo
	   int
	   CONSTRAINT pk_DoctorChooseTemplate_DoctorNo_TemplateNo	/*创建主键约束	*/							
	   PRIMARY KEY(DoctorNo,TemplateNo)	
	   )

select * from tb_DoctorChooseTemplate

delete tb_DoctorChooseTemplate
insert tb_DoctorChooseTemplate(DoctorNo,TemplateNo) 
values('D001',1)

select t.No,t.Name,t.Category from tb_DoctorChooseTemplate as dct
join tb_Template as t  on DCT.TemplateNo=T.No

select p.No,p.Name,p.Gender,p.IsMarried,p.Nation,p.Career,p.Address,p.WorkPlace,p.Birthday,o.Name as OfficeName from tb_Patient as p
join tb_Offices as o on p.OfficeNo=o.OfficesNo 
where OfficeNo=1

SELECT * FROM tb_Patient where OfficeNo=1 

 select p.No,p.Name,p.Gender,p.IsMarried,p.Nation,p.Career,p.Address,p.WorkPlace,p.Birthday,o.Name as OfficeName from tb_Patient as p
                                       join tb_Offices as o on p.OfficeNo=o.OfficesNo 
                                       where OfficeNo=1 and No not in (select No from tb_MedicalRecord)
   select * from tb_MedicalRecord where OfficesNo=1                                    
delete tb_MedicalRecord where No='0009'

SELECT MR.No AS 病人ID ,P.Gender AS 性别 ,MR.Name AS 名字,MR.ThisNo AS 住院号 FROM tb_MedicalRecord AS MR
		                                JOIN tb_Patient AS P ON MR.No=P.No
		                                WHERE (Doctor='魏爱东' AND IsToHospital=0) OR (Doctor='' AND IsToHospital=0)

  select * from tb_Template
  select * from tb_Offices
  select No,Name,OfficeNo from tb_Doctor
  select No,Name,ThisNo,BedNo,MainDiagnoseContent from tb_MedicalRecord where BedNo=''

  select No,Name from tb_Bed where Name not in(select BedNo from tb_MedicalRecord) 

  SELECT MR.No AS 病人ID ,P.Gender AS 性别 ,MR.Name AS 名字,MR.ThisNo AS 住院号 FROM tb_MedicalRecord AS MR
		                                JOIN tb_Patient AS P ON MR.No=P.No
		                                WHERE (Doctor='魏爱东' AND IsToHospital!=1 And BedNo!='') OR (Doctor='' AND IsToHospital!=1 And BedNo!='' ) 


DROP TABLE tb_PatientDoctorAdvice
CREATE TABLE tb_PatientDoctorAdvice
       (PatientNo  --病人ID
	   VARCHAR(10)
	   NOT NULL,
	   DoctorAdviceNo  --医嘱编号
	   INT
	   NOT NULL,
	   LongOrShort --长期短期
	   VARCHAR(20),
	   CategoryNo --种类
	   INT,
	   StartDateTime  --开始时间
	   DateTime,
	   Content --内容
	   VARCHAR(255),
	   HowMuch --剂量
	   VARCHAR(20),
	   Nnit     --单位
	   VARCHAR(20),
	   Way  --途径
	   VARCHAR(20),
	   Frequency  --频次
	   VARCHAR(20),
	   DoDateTime  --执行时间
	   DateTime,
	   StopDateTime  --结束时间
	   DateTime,
	   CONSTRAINT pk_PatientDoctorAdvice_PatientNo_DoctorAdviceNo	/*创建主键约束	*/							
	   PRIMARY KEY(PatientNo,DoctorAdviceNo)	
	   )

insert tb_PatientDoctorAdvice(PatientNo,DoctorAdviceNo,LongOrShort,CategoryNo,StartDateTime,Content,HowMuch,Nnit,Way,Frequency,DoDateTime,StopDateTime)
Values('0005',1,'长期',3,'2021-03-03','一级护理','','','','','2021-03-04','2021-06-06'),
      ('0005',2,'短期',4,'2021-03-03','多喝热水少吃辣','','','','','2021-03-04','2021-05-05'),
	  ('0005',3,'短期',1,'2021-03-03','葡萄糖','1','g','口服','1/1日','2021-03-04','2021-05-05'),
	  ('0005',4,'短期',1,'2021-03-03','生理盐水','300','ml','静滴','1/2日','2021-03-04','2021-05-05')

select * from tb_PatientDoctorAdvice as pda join tb_DoctorAdviceCategory as dac on pda.CategoryNo=dac.No
where PatientNo=''
select p.Name,mr.BedNo,p.Gender,p.Birthday from tb_MedicalRecord as mr join tb_Patient as p on mr.No=p.No
where p.No='0005'
select p.Name,mr.BedNo,p.Gender,p.Birthday from tb_MedicalRecord as mr join tb_Patient as p on mr.No=p.No
                                        where p.No='0005'

select LongOrShort,CategoryNo,Content,HowMuch,Nnit,Way,Frequency from tb_PatientDoctorAdvice

SELECT LongOrShort,CategoryNo,Content,HowMuch,Nnit,Way,Frequency FROM tb_DoctorAdvice AS DA 
JOIN tb_DoctorAdviceCategory AS DAC ON DA.CategoryNo=DAC.No
WHERE Combo=''


SELECT LongOrShort,CategoryNo,Content,HowMuch,Nnit,Way,Frequency FROM tb_DoctorAdvice AS DA 
                                         JOIN tb_DoctorAdviceCategory AS DAC ON DA.CategoryNo=DAC.No
                                         WHERE Combo='套餐一'

SELECT LongOrShort,CategoryNo,StartTime,Content,HowMuch,Nnit,Way,Frequency,DoDateTime,StopDateTime FROM tb_DoctorAdvice AS DA 
                                         JOIN tb_DoctorAdviceCategory AS DAC ON DA.CategoryNo=DAC.No
                                         WHERE Combo=''