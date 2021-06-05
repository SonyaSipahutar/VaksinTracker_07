CREATE DATABASE Vaksin_07
--terdapat total 6 tabel, 3 tabel lagi akan dicreate oleh WCF yaitu ketiga service yang sudah dibuat

CREATE TABLE Akun (
	id_akun INT NOT NULL IDENTITY(1,1),
	username VARCHAR (20) NOT NULL,
	password VARCHAR(30) NOT NULL,
	PRIMARY KEY (id_akun));

CREATE TABLE RoleMaster (
	id_role INT NOT NULL IDENTITY(1,1),
	nama_role VARCHAR (20) NOT NULL,
	PRIMARY KEY (id_role));

CREATE TABLE AkunRoleMapping(
	id_akunrole INT NOT NULL IDENTITY(1,1),
	id_akun INT NOT NULL,
	id_role INT NOT NULL,
	PRIMARY KEY (id_akunrole),
	FOREIGN KEY (id_akun) REFERENCES Akun(id_akun),
	FOREIGN KEY (id_role) REFERENCES RoleMaster(id_role));

insert into Akun values
	('sonya', 'sonya123'),
	('jennifer', 'jeni123'),
	('henny', 'henny123'),
	('andre', 'andre123'),
	('rstrutung', 'rstrutung899'),
	('masyarakat', 'masyarakat'),
	('bpom', 'bpom'),
	('produsen', 'produsen'),
	('rumahsakit', 'rumahsakit'),;

insert into RoleMaster values
	('Masyarakat'),
	('BPOM'),
	('Produsen'),
	('RumahSakit');

insert into AkunRoleMapping values
	('1','1'),
	('2','2'),
	('3','3'),
	('4','1'),
	('5','4'),
	('6','1'),
	('7','2'),
	('8','3'),
	('9','4');

--data berikut di insert apabila serviceCekDataNik sudah bisa dijalankan
insert into Data_Penduduk values
	('987659876545', 'sonya', 'tarutung', 'perempuan'),
	('763547990090', 'henny', 'sibolga', 'perempuan'),
	('987678789000', 'andre', 'medan', 'laki-laki'),
	('687689899909', 'jennifer', 'balige', 'perempuan'),
	('123456756780', 'mustika', 'balige', 'perempuan'),
	('098765434567', 'nursista', 'sibolga', 'perempuan'),
	('422353454545', 'pahala', 'medan', 'laki-laki');

--data berikut di insert apabila serviceKonfirmasiVaksin sudah bisa dijalankan
insert into Data_Pasien values
	('000001','NR01Y21','098765434567'),
	('000002','NR02Y21','763547990090');

select * from VaksinDatas
select * from Data_Pasien