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
	    VARCHAR(10)
	    CONSTRAINT pk_Doctor_No	/*��������Լ��	*/							
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
	   ('D001','κ����',HashBytes('MD5','001'),1),
	   ('D002','���',HashBytes('MD5','002'),4),
	   ('D003','�ܲ���',HashBytes('MD5','003'),3),
	   ('D004','����',HashBytes('MD5','004'),2)
select * from tb_Doctor

DROP TABLE tb_Offices
CREATE TABLE tb_Offices
       (OfficesNo
	   INT
	   CONSTRAINT pk_Offices_OfficesNo	/*��������Լ��	*/							
	   PRIMARY KEY(OfficesNo)		
	   NOT NULL,
	   Name
	   VARCHAR(20))

INSERT tb_Offices
       (OfficesNo,Name)
	   VALUES
	   (1,'�����ڿ�'),
	   (2,'�����ڿ�'),
	   (3,'�ۿ�'),
	   (4,'�ڷ��ڿ�') 

DROP TABLE tb_Patient
CREATE TABLE tb_Patient
       (No
	   VARCHAR(10)
	   CONSTRAINT pk_Patient_No	/*��������Լ��	*/							
	   PRIMARY KEY(No)		
	   NOT NULL,
	   Name
	   VARCHAR(20),
	   Gender
	   VARCHAR(5),
	   IsMarried  --���
	   BIT,
	   Nation     --����
	   VARCHAR(20),
	   Career     --ְ����ݣ�
	   VARCHAR(20),
	   Address    --����
	   VARCHAR(200),
	   WorkPlace  --��λ
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
	   ('0015','����','��',1,'��','��ʦ','��������','������ʦ������','1991/01/01',1),
	   ('0016','�Ű�','Ů',0,'��','ѧ��','��������','XX','2010/01/01',1),
	   ('0017','�ž�','Ů',3,'��','��ѧ��','��������','XX','2003/01/01',1),
	   ('0018','��ʮ','��',1,'��','��ʦ','��������','������ʦ������','1991/01/01',1),
	   ('0019','��ʮһ','Ů',0,'��','ѧ��','��������','XX','2010/01/01',1),
	   ('0020','��ʮ��','Ů',3,'��','��ѧ��','��������','XX','2003/01/01',1),

	   ('0005','���','��',1,'��','��ʦ','��������','������ʦ������','1991/01/01',1),
	   ('1143868','�Դ���','Ů',0,'��','��ʦ','��������','���ݴ����׶�԰','2000/01/01',4),
	   ('1225754','�����','��',1,'��','���н�ʦ','��������','���ŵ�һ��ѧ','1971/01/01',3),
	   ('1213180','�ž���','��',1,'��','����','�Ĵ��ɶ�','XX','1976/01/01',4),
	   ('1217483','����','Ů',0,'��','��ѧ��','���ճ���','XX','2001/01/01',4),
	   ('1221686','������','��',0,'��','��ʦ','��������','XX','1988/01/01',4),
	   ('1225980','����˫','Ů',0,'��','��ѧ��','��������','XX','1999/01/01',4),
	   ('1216315','������','��',0,'��','д��','��������','XX','1996/01/01',3),
	   ('1133395','����','Ů',0,'��','ѧ��','��������','XX','2010/01/01',3),
	   ('1228012','������','Ů',3,'��','��ѧ��','��������','XX','2003/01/01',3),
	   ('0006','�����','��',1,'��','��ʦ','��������','������ʦ������','1991/01/01',1),
	   ('0007','����','Ů',0,'��','ѧ��','��������','XX','2010/01/01',4),
	   ('0008','����','Ů',3,'��','��ѧ��','��������','XX','2003/01/01',3),
	   ('0009','��һ','��',1,'��','��ʦ','��������','������ʦ������','1991/01/01',1),
	   ('0010','�Ŷ�','Ů',0,'��','ѧ��','��������','XX','2010/01/01',1),
	   ('0011','����','Ů',3,'��','��ѧ��','��������','XX','2003/01/01',1),
	   ('0012','����','��',1,'��','��ʦ','��������','������ʦ������','1991/01/01',2),
	   ('0013','����','Ů',0,'��','ѧ��','��������','XX','2010/01/01',2),
	   ('0014','����','Ů',3,'��','��ѧ��','��������','XX','2003/01/01',2)

SELECT * FROM tb_Patient 

DROP TABLE tb_MedicalRecord
CREATE TABLE tb_MedicalRecord
       (No
	   VARCHAR(10)
	   NOT NULL,
	   ThisNo  --����סԺID(סԺ��)
	   VARCHAR(10)
	   NOT NULL,
	   Name
	   VARCHAR(20),
	   InHospitalCount  --סԺ����
	   INT,
	   BedNo  --����
	   VARCHAR(10),
	   OfficesNo  --��Ժ����
	   INT,
	   InDate  --��Ժ����
	   DATE, 
	   MainDiagnoseContent  --��Ҫ���
	   VARCHAR(200),
	   Doctor  --ҽ��
	   VARCHAR(20),
	   OtherSitiuation  --ת�����
	   VARCHAR(200),
	   OutOfficesNo  --��Ժ����
	   INT,
	   OutDate
	   DATE,
	   IsToHospital  --�Ƿ�סԺ��״̬��
	   BIT,
	   Category
	   BIT,
	   CONSTRAINT pk_MedicalRecord_No_TiHsNo	/*��������Լ��	*/							
	   PRIMARY KEY(No,ThisNo))	


DELETE tb_MedicalRecord
INSERT tb_MedicalRecord
       (No,ThisNo,Name,InHospitalCount,BedNo,OfficesNo,InDate,MainDiagnoseContent,Doctor,OtherSitiuation,OutOfficesNo,OutDate,IsToHospital,Category)
	   VALUES
	   ('0005','M0001','���',2,'0001',1,'2020/04/01','��������Ⱦ','κ����','','','',1,1),
	   ('1143868','M0002','�Դ���',1,'0002',4,'2020/04/01','�����Ⱦ','���','','','',1,1),
	   ('1225754','M0003','�����',4,'0003',3,'2020/04/07','����Ĥ�³�Ѫ','�ܲ���','','','',1,0),
	   ('1213180','M0004','�ž���',1,'0004',4,'2020/04/01','��֢','���','','','',0,0),
	   ('1217483','M0005','����',4,'0005',4,'2020/04/03','����','���','','','',1,1),
	   ('1221686','M0006','������',3,'0006',4,'2020/04/08','���մ���','���','','','',0,0),
	   ('1225980','M0007','����˫',2,'0007',4,'2020/04/09','����','���','','','',0,1),
	   ('1216315','M0008','������',2,'0008',3,'2020/04/01','����Ĥ�³�Ѫ','�ܲ���','','','',0,0),
	   ('1133395','M0009','����',1,'0009',3,'2020/04/01','����','�ܲ���','','','',0,1),
	   ('1228012','M0010','������',1,'0010',3,'2020/04/01','����','','','','',0,0)
INSERT tb_MedicalRecord
       (No,ThisNo,Name,InHospitalCount,BedNo,OfficesNo,InDate,MainDiagnoseContent,Doctor,OtherSitiuation,OutOfficesNo,OutDate,IsToHospital,Category)
	   VALUES
	   ('0006','M0011','�����',2,'0001',1,'2020/04/01','��������Ⱦ','κ����','','','',1,1),
	   ('0007','M0012','����',1,'0002',4,'2020/04/01','�����Ⱦ','���','','','',1,1),
	   ('0008','M0013','����',4,'0003',3,'2020/04/07','����Ĥ�³�Ѫ','�ܲ���','','','',1,0)


SELECT * FROM tb_MedicalRecord 

SELECT No,InHospitalNo,Name,BedNo,MainDiagnoseContent,Doctor FROM tb_MedicalRecord




	   SELECT p.No AS Patient,p.Name,p.Gender,p.Career,p.Birthday,mr.ThisNo,MR.InHospitalCount,MR.OfficesNo,p.Picture,mr.InDate,MR.OutOfficesNo,MR.OutDate,MR.OtherSitiuation
	   FROM tb_Patient AS P JOIN tb_MedicalRecord AS MR ON P.No=MR.No
	   WHERE p.Name=''
	   
	   --�������ű�
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


		SELECT MR.No AS ����ID,MR.InHospitalNo AS סԺ��,MR.Name AS ����,P.Gender AS �Ա�,MR.BedNo AS ����,MR.MainDiagnoseContent AS ��Ҫ���,MR.Doctor AS ����ҽ�� 
                                       FROM tb_Patient AS P
                                       JOIN tb_MedicalRecord AS MR ON P.No = MR.No
                                       WHERE IsToHospital = 0
                                       ORDER BY InHospitalNo


		SELECT MR.No,P.Gender,MR.Name,MR.ThisNo FROM tb_MedicalRecord AS MR
		JOIN tb_Patient AS P ON MR.No=P.No
		WHERE Doctor='���' AND IsToHospital=0


CREATE TABLE tb_DoctorAdviceCategory
       (No
	   INT
	   CONSTRAINT pk_DoctorAdviceCategory_No	/*��������Լ��	*/							
	   PRIMARY KEY(No)		
	   NOT NULL,
	   Name
	   VARCHAR(20))

INSERT tb_DoctorAdviceCategory
       (No,Name)
	   VALUES
	   (1,'ҩ��'),
	   (2,'����'),
	   (3,'����'),
	   (4,'��ʳ'),
	   (5,'���'),
	   (6,'����'),
	   (7,'����'),
	   (8,'����')

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
	   Nnit     --��λ
	   VARCHAR(20),
	   Way
	   VARCHAR(20),
	   Frequency
	   VARCHAR(20),
	   Combo  --�ײ�
	   VARCHAR(20),
	   CONSTRAINT pk_DoctorAdvice_No_Combo	/*��������Լ��	*/							
	   PRIMARY KEY(No,Combo)	
	   )

DELETE tb_DoctorAdvice
INSERT tb_DoctorAdvice
       (No,LongOrShort,CategoryNo,Content,HowMuch,Nnit,Way,Frequency,Combo)
	   VALUES
	   (1,'����',3,'��������','','','','','�ײ�һ'),
	   (2,'����',4,'����ʳ','','','','','�ײ�һ'),
	   (3,'����',1,'�ȷ�ù��IV��','1','g','�ڷ�','3/1��','�ײ�һ'),
	   (4,'����',1,'10%������ע��Һ','250','ml','����','1/1��','�ײ�һ')

SELECT distinct Combo FROM tb_DoctorAdvice 
SELECT * FROM tb_DoctorAdvice

INSERT tb_DoctorAdvice
       (No,LongOrShort,CategoryNo,Content,HowMuch,Nnit,Way,Frequency,Combo)
	   VALUES
	   (1,'����',3,'��������','','','','','�ײ�һ')

SELECT distinct COUNT(1) FROM tb_DoctorAdvice WHERE Combo='�ײ�һ'


DROP TABLE tb_Medicines
CREATE TABLE tb_Medicines
       (No
	   INT
	   CONSTRAINT pk_Medicines_No	/*��������Լ��	*/							
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
	   (1,'���������鰷Ƭ','FuFangAnFenWanPian'
	   ,'�����ڻ�����ͨ��ð�������Ը�ð����ķ��ȡ�ͷʹ����֫��ʹ�������硢�����顢��������ʹ��֢״��'
	   ,'�ڷ������ˣ�һ��1Ƭ��һ��2�Ρ�'
	   ,'���ظ������ܲ�ȫ�߽��á�'),
	   (2,'С�����ȿȴ��ڷ�Һ','XiaoErFeiReKeChuanKouFuYe'
	   ,'���Ƚⶾ�����λ�̵��������а���ڷ������·��ȡ�������΢��纮�����ԡ�̵�ƣ���洭Ϣ���ڸɶ��ʡ�'
	   ,'�ڷ���1����3��ÿ��10������һ��3�Σ�4����7��ÿ��10������һ��4�Σ�8����12��ÿ��20������һ��3�Ρ�'
	   ,'�в���ȷ��'),
	   (3,'��������Ƭ','FuFangDanShenPian'
	   ,'���˵���顣'
	   ,'�ڷ���'
	   ,'�в���ȷ��')

SELECT No,ThisNo,Name,BedNo,MainDiagnoseContent,Doctor from tb_MedicalRecord
select * from tb_MedicalRecord

drop table tb_Template
CREATE TABLE tb_Template
       (No
	   INT
	   Identity(1,1)
	   CONSTRAINT pk_Tamplate_No	/*��������Լ��	*/							
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
	   ('�����¼','����'),
	   ('��Ƽ�¼','����'),
	   ('����ģ��һ','����')

DELETE tb_Template 
INSERT tb_Template(Name,Category) VALUES ('1','1')

drop table tb_DoctorChooseTemplate
CREATE TABLE tb_DoctorChooseTemplate
       (DoctorNo
	   varchar(10)	  
	   NOT NULL,
	   TemplateNo
	   int
	   CONSTRAINT pk_DoctorChooseTemplate_DoctorNo_TemplateNo	/*��������Լ��	*/							
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

select * from tb_MedicalRecord
