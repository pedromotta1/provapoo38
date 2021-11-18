create database pedro38;
use pedro38;

create table login(
id int auto_increment primary key,
nome varchar(50) not null,
senha varchar(50) not null
)ENGINE = innodb;

create table jogos(
id int auto_increment primary key,
nome varchar(50) not null,
preco double not null
)ENGINE = innodb;

create table vendedor(
id int auto_increment primary key,
nome_vendedor varchar(50) not null,
quantidade int not null
)ENGINE = innodb;

alter table vendedor add constraint fk_id foreign key (id) references jogos (id); 

