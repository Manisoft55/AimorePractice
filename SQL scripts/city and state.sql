CREATE TABLE STATES
(
STATEID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
StateName nvarchar(250) not null ,
CreatedDate datetime not null
)

CREATE TABLE CITY
(
CityId INT NOT NULL PRIMARY KEY IDENTITY(1,1),
CityName nvarchar(250) not null,
StateId int not null,
CreatedDate datetime not null
)

insert into states(StateName, CreatedDate) values
('Telegana', getdate())

insert into CITY(CityName, StateId, CreatedDate) values
('New Delhi', 10 , getdate())

select * from STATES

select * from city

SELECT S.StateName, C.CityName,SD.SampleName FROM STATES S JOIN CITY C ON S.STATEID = C.STATEID
join SampleData SD on s.STATEID = SD.Id

-- Inner join
SELECT 'Inner Join'
SELECT S.StateName, C.CityName FROM STATES S INNER JOIN CITY C ON S.STATEID = C.STATEID

-- LEFT join
SELECT 'LEFT Join'
SELECT S.StateName, C.CityName FROM STATES S LEFT JOIN CITY C ON S.STATEID = C.STATEID

-- RIGHT join
SELECT 'RIGHT Join'
SELECT S.StateName, C.CityName FROM STATES S RIGHT JOIN CITY C ON S.STATEID = C.STATEID

-- FULL OUTER join
SELECT 'FULL OUTER Join'
SELECT S.StateName, C.CityName FROM STATES S FULL OUTER JOIN CITY C ON S.STATEID = C.STATEID

SELECT StateId, StateName FROM STATES 
UNION
SELECT CityId, CityName FROM CITY

SELECT StateName FROM STATES 
UNION ALL
SELECT CityName FROM CITY

