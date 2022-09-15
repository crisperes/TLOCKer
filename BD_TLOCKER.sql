create database BD_TLOCKER;

use BD_TLOCKER;

CREATE TABLE TB_USUARIO (
  TB_USUARIO_ID INT(11) NOT NULL AUTO_INCREMENT,
  TB_USUARIO_NOME VARCHAR(255),
  TB_USUARIO_CPF VARCHAR(11),
  TB_USUARIO_EMAIL VARCHAR(255),
  TB_USUARIO_TELEFONE VARCHAR(15),
  TB_USUARIO_LOGIN VARCHAR(15),
  TB_USUARIO_SENHA VARCHAR(40),
  RECUPERARSENHA INT,
  PRIMARY KEY(TB_USUARIO_ID)
) ENGINE = innodb;

CREATE TABLE TB_PAGAMENTO (
  TB_PAGAMENTO_ID INT(11) NOT NULL AUTO_INCREMENT,
  TB_PAGAMENTO_RESPONSAVEL VARCHAR(25) NOT NULL,
  TB_PAGAMENTO_DATA DATE NOT NULL,
  TB_PAGAMENTO_VALOR DECIMAL(10,2) NOT NULL,
  TB_ARMARIO_ID INT (11) NOT NULL,
  PRIMARY KEY(TB_PAGAMENTO_ID)
);

CREATE TABLE TB_ALUNO (
  TB_ALUNO_RM INT(15) NOT NULL,
  TB_ALUNO_TURMA VARCHAR(10) NOT NULL,
  TB_ALUNO_NOME VARCHAR(255) NOT NULL,
  TB_ALUNO_CPF VARCHAR(11) NOT NULL,
  TB_ALUNO_EMAIL VARCHAR(255) NOT NULL,
  TB_ALUNO_TELEFONE VARCHAR(15) NOT NULL,
  TB_ALUNO_RESP_NOME VARCHAR(255) NULL,
  TB_ALUNO_RESP_CPF VARCHAR(11) NULL,
  TB_ALUNO_RESP_EMAIL VARCHAR(255) NULL,
  TB_ALUNO_RESP_TELEFONE VARCHAR(15) NULL,
  PRIMARY KEY(TB_ALUNO_RM)
);

CREATE TABLE TB_ARMARIO (
  TB_ARMARIO_ID INT(11) NOT NULL,
  TB_ARMARIO_STATUS VARCHAR(25) NOT NULL,
  TB_ARMARIO_VALOR DECIMAL(10,2) NOT NULL,
  TB_ARMARIO_DESCRICAO VARCHAR(45) NOT NULL,
  TB_ARMARIO_LOCAL VARCHAR(15) NULL,
  PRIMARY KEY(TB_ARMARIO_ID)
);

CREATE TABLE TB_LOCACAO (
  TB_LOCACAO_ID INT(11) NOT NULL AUTO_INCREMENT,
  TB_LOCACAO_DATA DATE NOT NULL,
  TB_LOCACAO_TIPO VARCHAR(15) NOT NULL,
  TB_LOCACAO_VALOR DECIMAL(10,2) NOT NULL,
  TB_ALUNO_RM INT(15) NOT NULL,
  TB_ARMARIO_ID int(11) NOT NULL,
  TB_USUARIO_ID INT(11),
  TB_PAGAMENTO_ID INT(11),
  PRIMARY KEY(TB_LOCACAO_ID)	
  );
  
ALTER TABLE tb_locacao 
ADD CONSTRAINT PK_aluno_FK_locacao 
FOREIGN KEY (tb_aluno_rm) 
REFERENCES tb_aluno (tb_aluno_rm) ON DELETE RESTRICT;


ALTER TABLE tb_locacao 
ADD CONSTRAINT PK_armario_FK_locacao 
FOREIGN KEY (tb_armario_id) 
REFERENCES tb_armario (tb_armario_id) ON DELETE RESTRICT;


ALTER TABLE tb_pagamento 
ADD CONSTRAINT PK_armario_FK_pagamento 
FOREIGN KEY (tb_armario_id) 
REFERENCES tb_armario (tb_armario_id) ON DELETE RESTRICT;

-- STORED PROCEDURES

-- SP LOGIN
DELIMITER $$
CREATE PROCEDURE sp_Login (in login varchar(40), in senha varchar(15))
BEGIN

select * from TB_USUARIO where TB_USUARIO_LOGIN = login and TB_USUARIO_SENHA = senha; 

END $$

DELIMITER ;

-- SP RECUPERAR SENHA
DELIMITER $$
CREATE DEFINER = 'root'@'localhost' PROCEDURE sp_Recuperar (in email varchar(255))
BEGIN

declare codigo int;

if ((select TB_USUARIO_EMAIL from TB_USUARIO where TB_USUARIO_EMAIL = email) = email) then

	set codigo := (select TB_USUARIO_ID from TB_USUARIO where TB_USUARIO_ID = email);
    update TB_USUARIO set RECUPERARSENHA = floor(rand()*99999) where TB_USUARIO_ID = codigo;
    select TB_USUARIO_ID, TB_USUARIO_EMAIL, RECUPERARSENHA from TB_USUARIO where TB_USUARIO_EMAIL = email;
    
end if;

END $$

DELIMITER ;

-- SP VERIFICAR CODIGO
DELIMITER $$
CREATE DEFINER = 'root'@'localhost' PROCEDURE sp_VerificarCodigo (in email varchar(255), in codigo int)
BEGIN

select TB_USUARIO_ID from TB_USUARIO where TB_USUARIO_EMAIL = email and RECUPERARSENHA = codigo;

END $$

DELIMITER ;