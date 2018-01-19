Create database test
use test
create table users(userID int identity(1,1), 
firstname varchar(30), 
lastname varchar(30),
position varchar(30),
username varchar(30), 
passwords varchar(10))


select* from users

insert into users values('นรากร','สิทตะวงค์','ผู้ดูแลระบบ','u01','u01')
insert into users values('วนิดา','โพธิ์อนัน','ธุรการ','u02','u02')
insert into users values('กัมปนาท','เสมา','บัญชี','u03','u03')
insert into users values('มนัส','ทัพอาสา','บุคคล','u04','04')
insert into users values('กนกวงศ์','โชติกุล','การตลาด','u05','u05')
