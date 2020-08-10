create database ParkingProject

use ParkingProject

create table vehicle_reg
(
	vid int primary key identity,
	vname varchar(40) not null,
	ent varchar(20) not null,
	ext varchar(20),
	slot varchar(10),
	type varchar(10) not null,
	duration int,
	charge bigint,
)

insert into vehicle_reg values('','',null,'','',0,0)

drop table vehicle_reg

create table avalslotlight
( slot varchar(10) not null unique )

drop table avalslotlight
drop table engslotlight

create table engslotlight
( slot varchar(10) not null unique )

create table engslotheavy
( slot varchar(10) not null unique )

create table avalslotheavy
( slot varchar(10) not null unique )

insert Into avalslotlight values('F1-1')
insert Into avalslotlight values('F1-2')
insert Into avalslotlight values('F1-3')
insert Into avalslotlight values('F1-4')
insert Into avalslotlight values('F1-5')
insert Into avalslotlight values('F1-6')
insert Into avalslotlight values('F1-7')
insert Into avalslotlight values('F1-8')
insert Into avalslotlight values('F1-9')
insert Into avalslotlight values('F1-10')
insert Into avalslotlight values('F1-11')
insert Into avalslotlight values('F1-12')
insert Into avalslotlight values('F1-13')
insert Into avalslotlight values('F1-14')
insert Into avalslotlight values('F1-15')
insert Into avalslotlight values('F1-16')
insert Into avalslotlight values('F1-17')
insert Into avalslotlight values('F1-18')
insert Into avalslotlight values('F1-19')
insert Into avalslotlight values('F1-20')
insert Into avalslotlight values('F1-21')
insert Into avalslotlight values('F1-22')
insert Into avalslotlight values('F1-23')
insert Into avalslotlight values('F1-24')
insert Into avalslotlight values('F1-25')


insert Into avalslotheavy values('F2-1')
insert Into avalslotheavy values('F2-2')
insert Into avalslotheavy values('F2-3')
insert Into avalslotheavy values('F2-4')
insert Into avalslotheavy values('F2-5')
insert Into avalslotheavy values('F2-6')
insert Into avalslotheavy values('F2-7')
insert Into avalslotheavy values('F2-8')
insert Into avalslotheavy values('F2-9')
insert Into avalslotheavy values('F2-10')
insert Into avalslotheavy values('F3-1')
insert Into avalslotheavy values('F3-2')
insert Into avalslotheavy values('F3-3')
insert Into avalslotheavy values('F3-4')
insert Into avalslotheavy values('F3-5')
insert Into avalslotheavy values('F3-6')
insert Into avalslotheavy values('F3-7')
insert Into avalslotheavy values('F3-8')
insert Into avalslotheavy values('F3-9')
insert Into avalslotheavy values('F3-10')

select count(*) cs from avalslotheavy

select count(*) from avalslotlight


CREATE PROC COUNTSLOT(@p int out)
as
BEGIN
   SELECT @p=count(*)  from avalslotheavy
   
END


CREATE PROC COUNTSLOTlIGHT(@p int out)
as
BEGIN
   SELECT @p=count(*)  from avalslotlight
   
END


declare @c int

exec COUNTSLOTlIGHT @c out

select @c

drop proc COUNTSLOT

