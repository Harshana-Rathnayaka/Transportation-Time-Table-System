create table schedules (
id int identity(1,1) primary key,
route varchar(3),
start_from varchar(100),
ends_at varchar(100),
departure_time time(7),
type varchar(150),
)