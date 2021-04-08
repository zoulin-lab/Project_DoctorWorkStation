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
	   ('1225754','�����',1,50,1,'��','���н�ʦ','��������','���ŵ�һ��ѧ','1971/01/01'),
	   ('1213180','�ž���',1,45,1,'��','����','�Ĵ��ɶ�','XX','1976/01/01'),
	   ('1217483','����',0,20,0,'��','��ѧ��','���ճ���','XX','2001/01/01'),
	   ('1221686','������',1,33,0,'��','��ʦ','��������','XX','1988/01/01'),
	   ('1225980','����˫',0,22,0,'��','��ѧ��','��������','XX','1999/01/01'),
	   ('1216315','������',1,25,0,'��','д��','��������','XX','1996/01/01'),
	   ('1133395','����',0,11,0,'��','ѧ��','��������','XX','2010/01/01'),
	   ('1228012','������',0,18,3,'��','��ѧ��','��������','XX','2003/01/01')

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
	   IsToHospital  --�Ƿ�סԺ��״̬��
	   BIT,
	   CONSTRAINT pk_MedicalRecord_No_TiHsNo	/*��������Լ��	*/							
	   PRIMARY KEY(No,ThisNo))	


DELETE tb_MedicalRecord
INSERT tb_MedicalRecord
       (No,ThisNo,Name,InHospitalNo,InHospitalCount,BedNo,OfficesNo,InDate,MainDiagnoseContent,Doctor,OtherSitiuation,OutOfficesNo,OutDate,IsToHospital)
	   VALUES
	   ('0005','M0001','���','I0001',2,'0001',1,'2020/04/01','��������Ⱦ','κ����','','','',1),
	   ('1143868','M0002','�Դ���','I0002',1,'0002',4,'2020/04/01','�����Ⱦ','���','','','',1),
	   ('1225754','M0003','�����','I0003',4,'0003',3,'2020/04/07','����Ĥ�³�Ѫ','�ܲ���','','','',1),
	   ('1213180','M0004','�ž���','I0004',1,'0004',4,'2020/04/01','��֢','���','','','',0),
	   ('1217483','M0005','����','I0005',4,'0005',4,'2020/04/03','����','���','','','',1),
	   ('1221686','M0006','������','I0006',3,'0006',4,'2020/04/08','���մ���','���','','','',0),
	   ('1225980','M0007','����˫','I0007',2,'0007',4,'2020/04/09','����','���','','','',0),
	   ('1216315','M0008','������','I0008',2,'0008',3,'2020/04/01','����Ĥ�³�Ѫ','�ܲ���','','','',0),
	   ('1133395','M0009','����','I0009',1,'0009',3,'2020/04/01','����','�ܲ���','','','',0),
	   ('1228012','M0010','������','I0010',1,'0010',3,'2020/04/01','����','κ����','','','',0)

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






