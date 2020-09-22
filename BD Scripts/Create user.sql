--select db
use AnimalSpawn
-- create login
create LOGIN KennetAvila 
WITH PASSWORD = '123456'
--create dbuser with default_Schema
create user KennetAvila from login KennetAvila
with default_Schema = AnimalSpawn
--permissions to db user
grant select, insert, update, delete to KennetAvila