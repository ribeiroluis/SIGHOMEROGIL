/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     27/12/2012 11:18:14                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ACESSOSISTEMA') and o.name = 'FK_ACESSOSI_REFERENCE_FUNCIONA')
alter table ACESSOSISTEMA
   drop constraint FK_ACESSOSI_REFERENCE_FUNCIONA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ACESSOSISTEMA') and o.name = 'FK_ACESSOSI_REFERENCE_TIPOACES')
alter table ACESSOSISTEMA
   drop constraint FK_ACESSOSI_REFERENCE_TIPOACES
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ACESSOSISTEMA') and o.name = 'FK_ACESSOSI_REFERENCE_SETOR')
alter table ACESSOSISTEMA
   drop constraint FK_ACESSOSI_REFERENCE_SETOR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BAIRRO') and o.name = 'FK_BAIRRO_REFERENCE_CIDADES')
alter table BAIRRO
   drop constraint FK_BAIRRO_REFERENCE_CIDADES
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BAIXAESTOQUE') and o.name = 'FK_BAIXAEST_REFERENCE_ITENSEST')
alter table BAIXAESTOQUE
   drop constraint FK_BAIXAEST_REFERENCE_ITENSEST
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BAIXAESTOQUE') and o.name = 'FK_BAIXAEST_REFERENCE_ESTOQUE')
alter table BAIXAESTOQUE
   drop constraint FK_BAIXAEST_REFERENCE_ESTOQUE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BAIXAESTOQUE') and o.name = 'FK_BAIXAEST_REFERENCE_USUARIO')
alter table BAIXAESTOQUE
   drop constraint FK_BAIXAEST_REFERENCE_USUARIO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BAIXAESTOQUE') and o.name = 'FK_BAIXAEST_REFERENCE_DISPENSA')
alter table BAIXAESTOQUE
   drop constraint FK_BAIXAEST_REFERENCE_DISPENSA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CEP') and o.name = 'FK_CEP_REFERENCE_CIDADES')
alter table CEP
   drop constraint FK_CEP_REFERENCE_CIDADES
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CEP') and o.name = 'FK_CEP_REFERENCE_BAIRRO')
alter table CEP
   drop constraint FK_CEP_REFERENCE_BAIRRO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DISPENSACAO') and o.name = 'FK_DISPENSA_REFERENCE_FUNCIONA')
alter table DISPENSACAO
   drop constraint FK_DISPENSA_REFERENCE_FUNCIONA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DISPENSACAO') and o.name = 'FK_DISPENSA_REFERENCE_USUARIO')
alter table DISPENSACAO
   drop constraint FK_DISPENSA_REFERENCE_USUARIO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DISPENSACAO') and o.name = 'FK_DISPENSA_REFERENCE_TIPOUSUA')
alter table DISPENSACAO
   drop constraint FK_DISPENSA_REFERENCE_TIPOUSUA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ITENSDISPENSACAO') and o.name = 'FK_ITENSDIS_REFERENCE_DISPENSA')
alter table ITENSDISPENSACAO
   drop constraint FK_ITENSDIS_REFERENCE_DISPENSA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ITENSDISPENSACAO') and o.name = 'FK_ITENSDIS_REFERENCE_ESTOQUE')
alter table ITENSDISPENSACAO
   drop constraint FK_ITENSDIS_REFERENCE_ESTOQUE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ITENSDISPENSACAO') and o.name = 'FK_ITENSDIS_REFERENCE_ITENSEST')
alter table ITENSDISPENSACAO
   drop constraint FK_ITENSDIS_REFERENCE_ITENSEST
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ITENSESTOQUE') and o.name = 'FK_ITENSEST_REFERENCE_ESTOQUE')
alter table ITENSESTOQUE
   drop constraint FK_ITENSEST_REFERENCE_ESTOQUE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MEDICAMENTOS_USUARIO_CRONICO') and o.name = 'FK_MEDICAME_REFERENCE_ITENSEST')
alter table MEDICAMENTOS_USUARIO_CRONICO
   drop constraint FK_MEDICAME_REFERENCE_ITENSEST
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MEDICAMENTOS_USUARIO_CRONICO') and o.name = 'FK_MEDICAME_REFERENCE_ESTOQUE')
alter table MEDICAMENTOS_USUARIO_CRONICO
   drop constraint FK_MEDICAME_REFERENCE_ESTOQUE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MEDICAMENTOS_USUARIO_CRONICO') and o.name = 'FK_MEDICAME_REFERENCE_USUARIO')
alter table MEDICAMENTOS_USUARIO_CRONICO
   drop constraint FK_MEDICAME_REFERENCE_USUARIO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MEDICAMENTOS_USUARIO_CRONICO') and o.name = 'FK_MEDICAME_REFERENCE_TIPOUSUA')
alter table MEDICAMENTOS_USUARIO_CRONICO
   drop constraint FK_MEDICAME_REFERENCE_TIPOUSUA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('USUARIO') and o.name = 'FK_USUARIO_REFERENCE_CEP')
alter table USUARIO
   drop constraint FK_USUARIO_REFERENCE_CEP
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('USUARIO') and o.name = 'FK_USUARIO_REFERENCE_TIPOUSUA')
alter table USUARIO
   drop constraint FK_USUARIO_REFERENCE_TIPOUSUA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ACESSOSISTEMA')
            and   type = 'U')
   drop table ACESSOSISTEMA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BAIRRO')
            and   type = 'U')
   drop table BAIRRO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BAIXAESTOQUE')
            and   type = 'U')
   drop table BAIXAESTOQUE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CEP')
            and   type = 'U')
   drop table CEP
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CIDADES')
            and   type = 'U')
   drop table CIDADES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DISPENSACAO')
            and   type = 'U')
   drop table DISPENSACAO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ESTOQUE')
            and   type = 'U')
   drop table ESTOQUE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FUNCIONARIO')
            and   type = 'U')
   drop table FUNCIONARIO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ITENSDISPENSACAO')
            and   type = 'U')
   drop table ITENSDISPENSACAO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ITENSESTOQUE')
            and   type = 'U')
   drop table ITENSESTOQUE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MEDICAMENTOS_USUARIO_CRONICO')
            and   type = 'U')
   drop table MEDICAMENTOS_USUARIO_CRONICO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SETOR')
            and   type = 'U')
   drop table SETOR
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TIPOACESSO')
            and   type = 'U')
   drop table TIPOACESSO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TIPOUSUARIO')
            and   type = 'U')
   drop table TIPOUSUARIO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('USUARIO')
            and   type = 'U')
   drop table USUARIO
go

/*==============================================================*/
/* Table: ACESSOSISTEMA                                         */
/*==============================================================*/
create table ACESSOSISTEMA (
   IDUSUARIO            int                  identity(1,1),
   IDFUNCIONARIO        int                  not null,
   IDFORMAACESSO        int                  not null,
   IDSETOR              int                  not null,
   LOGIN                varchar(50)          not null,
   SENHA                varchar(20)          not null,
   constraint PK_ACESSOSISTEMA primary key (IDUSUARIO)
)
go

/*==============================================================*/
/* Table: BAIRRO                                                */
/*==============================================================*/
create table BAIRRO (
   IDBAIRRO             int                  not null,
   BAIRRO               varchar(20)          not null,
   IDCIDADE             int                  not null,
   constraint PK_BAIRRO primary key (IDBAIRRO)
)
go

/*==============================================================*/
/* Table: BAIXAESTOQUE                                          */
/*==============================================================*/
create table BAIXAESTOQUE (
   IDBAIXAESTOQUE       int                  identity(1,1),
   IDMEDICAMENTO        int                  not null,
   IDDESCRICAO          int                  not null,
   IDUSUARIO            int                  null,
   IDDISPENSACAO        int                  null,
   DATA                 date                 not null,
   MOTIVO               varchar(250)         not null,
   QUANTIDADE           int                  not null,
   constraint PK_BAIXAESTOQUE primary key (IDBAIXAESTOQUE)
)
go

/*==============================================================*/
/* Table: CEP                                                   */
/*==============================================================*/
create table CEP (
   CEP                  int                  not null,
   ENDERECO             varchar(200)         not null,
   IDCIDADE             int                  not null,
   IDBAIRRO             int                  not null,
   constraint PK_CEP primary key (CEP)
)
go

/*==============================================================*/
/* Table: CIDADES                                               */
/*==============================================================*/
create table CIDADES (
   IDCIDADE             int                  not null,
   CIDADE               varchar(200)         not null,
   UF                   varchar(2)           not null,
   constraint PK_CIDADES primary key (IDCIDADE)
)
go

/*==============================================================*/
/* Table: DISPENSACAO                                           */
/*==============================================================*/
create table DISPENSACAO (
   IDDISPENSACAO        int                  identity(1,1),
   DATADISPENSACAO      date                 not null,
   IDUSUARIO            int                  not null,
   TIPOUSUARIO          int                  null,
   IDFUNCIONARIO        int                  not null,
   constraint PK_DISPENSACAO primary key (IDDISPENSACAO)
)
go

/*==============================================================*/
/* Table: ESTOQUE                                               */
/*==============================================================*/
create table ESTOQUE (
   IDDESCRICAO          int                  identity(1,1),
   DESCRICAO            varchar(250)         not null,
   CODIGO               varchar(10)          not null,
   constraint PK_ESTOQUE primary key (IDDESCRICAO)
)
go

/*==============================================================*/
/* Table: FUNCIONARIO                                           */
/*==============================================================*/
create table FUNCIONARIO (
   IDFUNCIONARIO        int                  identity(1,1),
   NOME                 varchar(250)         not null,
   MATRICULA            varchar(8)           null,
   constraint PK_FUNCIONARIO primary key (IDFUNCIONARIO)
)
go

/*==============================================================*/
/* Table: ITENSDISPENSACAO                                      */
/*==============================================================*/
create table ITENSDISPENSACAO (
   IDITENSDISPENSACAO   int                  identity(1,1),
   IDDISPENSACAO        int                  null,
   IDDESCRICAO          int                  null,
   IDMEDICAMENTO        int                  null,
   QUANTIDADE           int                  not null,
   constraint PK_ITENSDISPENSACAO primary key (IDITENSDISPENSACAO)
)
go

/*==============================================================*/
/* Table: ITENSESTOQUE                                          */
/*==============================================================*/
create table ITENSESTOQUE (
   IDMEDICAMENTO        int                  identity(1,1),
   IDDESCRICAO          int                  not null,
   VALIDADE             date                 not null,
   QUANTIDADE           int                  not null,
   constraint PK_ITENSESTOQUE primary key (IDMEDICAMENTO)
)
go

/*==============================================================*/
/* Table: MEDICAMENTOS_USUARIO_CRONICO                          */
/*==============================================================*/
create table MEDICAMENTOS_USUARIO_CRONICO (
   IDCRONICOS           int                  identity(1,1),
   IDMEDICAMENTO        int                  not null,
   IDDESCRICAO          int                  not null,
   IDUSUARIO            int                  null,
   IDTIPOUSUARIO        int                  null,
   QUANTIDADE           int                  not null,
   constraint PK_MEDICAMENTOS_USUARIO_CRONIC primary key (IDCRONICOS)
)
go

/*==============================================================*/
/* Table: SETOR                                                 */
/*==============================================================*/
create table SETOR (
   IDSETOR              int                  identity(1,1),
   NOME                 varchar(50)          not null,
   constraint PK_SETOR primary key (IDSETOR)
)
go

/*==============================================================*/
/* Table: TIPOACESSO                                            */
/*==============================================================*/
create table TIPOACESSO (
   IDFORMAACESSO        int                  identity(1,1),
   DESCRICAO            varchar(200)         not null,
   ACESSOTOTAL          bit                  not null,
   constraint PK_TIPOACESSO primary key (IDFORMAACESSO)
)
go

/*==============================================================*/
/* Table: TIPOUSUARIO                                           */
/*==============================================================*/
create table TIPOUSUARIO (
   IDTIPOUSUARIO        int                  identity(1,1),
   TIPOUSUARIO          varchar(50)          not null,
   constraint PK_TIPOUSUARIO primary key (IDTIPOUSUARIO)
)
go

/*==============================================================*/
/* Table: USUARIO                                               */
/*==============================================================*/
create table USUARIO (
   IDUSUARIO            int                  identity(1,1),
   TIPOUSUARIO          int                  null,
   PRONTUARIO           int                  null,
   NOME                 varchar(250)         not null,
   DTNASCIMENTO         date                 null,
   CEP                  int                  null,
   ENDNUMERO            int                  null,
   ENDCOMPLEMENTO       varchar(20)          null,
   CPF                  varchar(11)          null,
   NOMEMAE              varchar(250)         null,
   constraint PK_USUARIO primary key (IDUSUARIO)
)
go

alter table ACESSOSISTEMA
   add constraint FK_ACESSOSI_REFERENCE_FUNCIONA foreign key (IDFUNCIONARIO)
      references FUNCIONARIO (IDFUNCIONARIO)
go

alter table ACESSOSISTEMA
   add constraint FK_ACESSOSI_REFERENCE_TIPOACES foreign key (IDFORMAACESSO)
      references TIPOACESSO (IDFORMAACESSO)
go

alter table ACESSOSISTEMA
   add constraint FK_ACESSOSI_REFERENCE_SETOR foreign key (IDSETOR)
      references SETOR (IDSETOR)
go

alter table BAIRRO
   add constraint FK_BAIRRO_REFERENCE_CIDADES foreign key (IDCIDADE)
      references CIDADES (IDCIDADE)
go

alter table BAIXAESTOQUE
   add constraint FK_BAIXAEST_REFERENCE_ITENSEST foreign key (IDMEDICAMENTO)
      references ITENSESTOQUE (IDMEDICAMENTO)
go

alter table BAIXAESTOQUE
   add constraint FK_BAIXAEST_REFERENCE_ESTOQUE foreign key (IDDESCRICAO)
      references ESTOQUE (IDDESCRICAO)
go

alter table BAIXAESTOQUE
   add constraint FK_BAIXAEST_REFERENCE_USUARIO foreign key (IDUSUARIO)
      references USUARIO (IDUSUARIO)
go

alter table BAIXAESTOQUE
   add constraint FK_BAIXAEST_REFERENCE_DISPENSA foreign key (IDDISPENSACAO)
      references DISPENSACAO (IDDISPENSACAO)
go

alter table CEP
   add constraint FK_CEP_REFERENCE_CIDADES foreign key (IDCIDADE)
      references CIDADES (IDCIDADE)
go

alter table CEP
   add constraint FK_CEP_REFERENCE_BAIRRO foreign key (IDBAIRRO)
      references BAIRRO (IDBAIRRO)
go

alter table DISPENSACAO
   add constraint FK_DISPENSA_REFERENCE_FUNCIONA foreign key (IDFUNCIONARIO)
      references FUNCIONARIO (IDFUNCIONARIO)
go

alter table DISPENSACAO
   add constraint FK_DISPENSA_REFERENCE_USUARIO foreign key (IDUSUARIO)
      references USUARIO (IDUSUARIO)
go

alter table DISPENSACAO
   add constraint FK_DISPENSA_REFERENCE_TIPOUSUA foreign key (TIPOUSUARIO)
      references TIPOUSUARIO (IDTIPOUSUARIO)
go

alter table ITENSDISPENSACAO
   add constraint FK_ITENSDIS_REFERENCE_DISPENSA foreign key (IDDISPENSACAO)
      references DISPENSACAO (IDDISPENSACAO)
go

alter table ITENSDISPENSACAO
   add constraint FK_ITENSDIS_REFERENCE_ESTOQUE foreign key (IDDESCRICAO)
      references ESTOQUE (IDDESCRICAO)
go

alter table ITENSDISPENSACAO
   add constraint FK_ITENSDIS_REFERENCE_ITENSEST foreign key (IDMEDICAMENTO)
      references ITENSESTOQUE (IDMEDICAMENTO)
go

alter table ITENSESTOQUE
   add constraint FK_ITENSEST_REFERENCE_ESTOQUE foreign key (IDDESCRICAO)
      references ESTOQUE (IDDESCRICAO)
         on update cascade on delete cascade
go

alter table MEDICAMENTOS_USUARIO_CRONICO
   add constraint FK_MEDICAME_REFERENCE_ITENSEST foreign key (IDMEDICAMENTO)
      references ITENSESTOQUE (IDMEDICAMENTO)
go

alter table MEDICAMENTOS_USUARIO_CRONICO
   add constraint FK_MEDICAME_REFERENCE_ESTOQUE foreign key (IDDESCRICAO)
      references ESTOQUE (IDDESCRICAO)
go

alter table MEDICAMENTOS_USUARIO_CRONICO
   add constraint FK_MEDICAME_REFERENCE_USUARIO foreign key (IDUSUARIO)
      references USUARIO (IDUSUARIO)
go

alter table MEDICAMENTOS_USUARIO_CRONICO
   add constraint FK_MEDICAME_REFERENCE_TIPOUSUA foreign key (IDTIPOUSUARIO)
      references TIPOUSUARIO (IDTIPOUSUARIO)
go

alter table USUARIO
   add constraint FK_USUARIO_REFERENCE_CEP foreign key (CEP)
      references CEP (CEP)
go

alter table USUARIO
   add constraint FK_USUARIO_REFERENCE_TIPOUSUA foreign key (TIPOUSUARIO)
      references TIPOUSUARIO (IDTIPOUSUARIO)
go

