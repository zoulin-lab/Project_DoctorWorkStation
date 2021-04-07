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
	   ('D001','����',HashBytes('MD5','001'),'�����ڿ�'),
	   ('D002','����',HashBytes('MD5','002'),'�ۿ�'),
	   ('D003','����',HashBytes('MD5','003'),'�����ڿ�')

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
	   BIT,
	   Age
	   INT,
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
       (No,Name,Gender,Age,IsMarried,Nation,Career,Address,WorkPlace,Birthday)
	   VALUES
	   ('0005','���',1,30,1,'��','��ʦ','��������','������ʦ������','1991/01/01'),
	   ('1143868','�Դ���',0,21,0,'��','��ʦ','��������','���ݴ����׶�԰','2000/01/01'),
	   ('1225754','�����',1,50,1,'��','���н�ʦ','��������','���ŵ�һ��ѧ','1971/01/01')

SELECT * FROM tb_Patient

DROP TABLE tb_MedicalRecord
CREATE TABLE tb_MedicalRecord
       (No
	   VARCHAR(10)
	   NOT NULL,
	   ThisNo  --����סԺID
	   VARCHAR(10)
	   NOT NULL,
	   Name
	   VARCHAR(20),
	   InHospitalNo  --סԺ��
	   VARCHAR(10),
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
	   CONSTRAINT pk_MedicalRecord_No_TiHsNo	/*��������Լ��	*/							
	   PRIMARY KEY(No,ThisNo))	


DELETE tb_MedicalRecord
INSERT tb_MedicalRecord
       (No,ThisNo,Name,InHospitalNo,InHospitalCount,BedNo,OfficesNo,InDate,MainDiagnoseContent,Doctor,OtherSitiuation,OutOfficesNo,OutDate)
	   VALUES
	   ('0005','M0001','���','I0001',2,'0001',1,'2020/04/01','��������Ⱦ','����','','',''),
	   ('1143868','M0002','�Դ���','I0002',1,'0002',4,'2020/04/01','�����Ⱦ','Ǯ��','','',''),
	   ('1225754','M0003','�����','I0003',4,'0003',3,'2020/04/01','����Ĥ�³�Ѫ','����','','','')

SELECT * FROM tb_MedicalRecord 

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

	   SELECT p.No AS Patient,p.Name,p.Gender,p.Career,p.Birthday,mr.InHospitalNo,MR.InHospitalCount,MR.OfficesNo,p.Picture,mr.InDate,MR.OutOfficesNo,MR.OutDate,MR.OtherSitiuation
	   FROM tb_Patient AS P JOIN tb_MedicalRecord AS MR ON P.No=MR.No
	   WHERE P.No='1143868'
	   
	   --�������ű�
	   BEGIN TRAN
	   UPDATE tb_Patient 
	   SET Name='',Gender='',Career='',Birthday=''
	   WHERE No=''
	   UPDATE tb_MedicalRecord
	   SET InHospitalNo='',InHospitalCount='',OfficesNo='',InDate='',OtherSitiuation='',OutOfficesNo='',OutDate=''
	   WHERE No=''
	   COMMIT



	    SELECT * FROM tb_Offices






