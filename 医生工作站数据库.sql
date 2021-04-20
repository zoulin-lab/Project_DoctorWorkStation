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
	    Offices
	    VARCHAR(20)
	   )
DELETE tb_Doctor
INSERT tb_Doctor
       (No,Name,Password,Offices)
	   VALUES
	   ('D001','κ����',HashBytes('MD5','001'),'�����ڿ�'),
	   ('D002','���',HashBytes('MD5','002'),'�ڷ��ڿ�'),
	   ('D003','�ܲ���',HashBytes('MD5','003'),'�ۿ�'),
	   ('D004','����',HashBytes('MD5','004'),'�����ڿ�')

SELECT * FROM tb_Doctor 

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
	   Picture
	   VARBINARY(MAX))
delete tb_Patient
INSERT tb_Patient
       (No,Name,Gender,IsMarried,Nation,Career,Address,WorkPlace,Birthday)
	   VALUES
	   ('0005','���','��',1,'��','��ʦ','��������','������ʦ������','1991/01/01'),
	   ('1143868','�Դ���','Ů',0,'��','��ʦ','��������','���ݴ����׶�԰','2000/01/01'),
	   ('1225754','�����','��',1,'��','���н�ʦ','��������','���ŵ�һ��ѧ','1971/01/01'),
	   ('1213180','�ž���','��',1,'��','����','�Ĵ��ɶ�','XX','1976/01/01'),
	   ('1217483','����','Ů',0,'��','��ѧ��','���ճ���','XX','2001/01/01'),
	   ('1221686','������','��',0,'��','��ʦ','��������','XX','1988/01/01'),
	   ('1225980','����˫','Ů',0,'��','��ѧ��','��������','XX','1999/01/01'),
	   ('1216315','������','��',0,'��','д��','��������','XX','1996/01/01'),
	   ('1133395','����','Ů',0,'��','ѧ��','��������','XX','2010/01/01'),
	   ('1228012','������','Ů',3,'��','��ѧ��','��������','XX','2003/01/01')

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

SELECT * FROM tb_MedicalRecord 

SELECT No,InHospitalNo,Name,BedNo,MainDiagnoseContent,Doctor FROM tb_MedicalRecord


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

DELETE tb_DoctorAdvice WHERE No=1