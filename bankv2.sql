/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2005                    */
/* Created on:     29-May-22 9:18:35 PM                         */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ACCOUNT') and o.name = 'FK_ACCOUNT_HAS_CUSTOMER')
alter table ACCOUNT
   drop constraint FK_ACCOUNT_HAS_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BANK_BRANCH') and o.name = 'FK_BANK_BRA_HAS_BRANC_BANK')
alter table BANK_BRANCH
   drop constraint FK_BANK_BRA_HAS_BRANC_BANK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CUSTOMER') and o.name = 'FK_CUSTOMER_HAS_CUSTO_BANK_BRA')
alter table CUSTOMER
   drop constraint FK_CUSTOMER_HAS_CUSTO_BANK_BRA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DEAL_WITH') and o.name = 'FK_DEAL_WIT_DEALS_CUSTOMER')
alter table DEAL_WITH
   drop constraint FK_DEAL_WIT_DEALS_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DEAL_WITH') and o.name = 'FK_DEAL_WIT_DEAL_WITH_EMPLOYEE')
alter table DEAL_WITH
   drop constraint FK_DEAL_WIT_DEAL_WITH_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EMPLOYEE') and o.name = 'FK_EMPLOYEE_WORKS_IN_BANK_BRA')
alter table EMPLOYEE
   drop constraint FK_EMPLOYEE_WORKS_IN_BANK_BRA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LOAN') and o.name = 'FK_LOAN_HANDLE_EMPLOYEE')
alter table LOAN
   drop constraint FK_LOAN_HANDLE_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LOAN') and o.name = 'FK_LOAN_OFFERS_BANK_BRA')
alter table LOAN
   drop constraint FK_LOAN_OFFERS_BANK_BRA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LOAN') and o.name = 'FK_LOAN_REQUEST_CUSTOMER')
alter table LOAN
   drop constraint FK_LOAN_REQUEST_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LOAN_TYPES') and o.name = 'FK_LOAN_TYP_HAS_LTYPE_BANK_BRA')
alter table LOAN_TYPES
   drop constraint FK_LOAN_TYP_HAS_LTYPE_BANK_BRA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHONE_NUMBER') and o.name = 'FK_PHONE_NU_HAS_NUMBE_CUSTOMER')
alter table PHONE_NUMBER
   drop constraint FK_PHONE_NU_HAS_NUMBE_CUSTOMER
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ACCOUNT')
            and   name  = 'HAS_FK'
            and   indid > 0
            and   indid < 255)
   drop index ACCOUNT.HAS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ACCOUNT')
            and   type = 'U')
   drop table ACCOUNT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BANK')
            and   type = 'U')
   drop table BANK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BANK_BRANCH')
            and   name  = 'HAS_BRANCH_FK'
            and   indid > 0
            and   indid < 255)
   drop index BANK_BRANCH.HAS_BRANCH_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BANK_BRANCH')
            and   type = 'U')
   drop table BANK_BRANCH
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CUSTOMER')
            and   name  = 'HAS_CUSTOMERS_FK'
            and   indid > 0
            and   indid < 255)
   drop index CUSTOMER.HAS_CUSTOMERS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CUSTOMER')
            and   type = 'U')
   drop table CUSTOMER
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DEAL_WITH')
            and   name  = 'DEAL_WITH_FK'
            and   indid > 0
            and   indid < 255)
   drop index DEAL_WITH.DEAL_WITH_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DEAL_WITH')
            and   name  = 'DEALS_FK'
            and   indid > 0
            and   indid < 255)
   drop index DEAL_WITH.DEALS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DEAL_WITH')
            and   type = 'U')
   drop table DEAL_WITH
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('EMPLOYEE')
            and   name  = 'WORKS_IN_FK'
            and   indid > 0
            and   indid < 255)
   drop index EMPLOYEE.WORKS_IN_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EMPLOYEE')
            and   type = 'U')
   drop table EMPLOYEE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LOAN')
            and   name  = 'REQUEST_FK'
            and   indid > 0
            and   indid < 255)
   drop index LOAN.REQUEST_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LOAN')
            and   name  = 'HANDLE_FK'
            and   indid > 0
            and   indid < 255)
   drop index LOAN.HANDLE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LOAN')
            and   name  = 'OFFERS_FK'
            and   indid > 0
            and   indid < 255)
   drop index LOAN.OFFERS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LOAN')
            and   type = 'U')
   drop table LOAN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LOAN_TYPES')
            and   name  = 'HAS_LTYPES_FK'
            and   indid > 0
            and   indid < 255)
   drop index LOAN_TYPES.HAS_LTYPES_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LOAN_TYPES')
            and   type = 'U')
   drop table LOAN_TYPES
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PHONE_NUMBER')
            and   name  = 'HAS_NUMBER_FK'
            and   indid > 0
            and   indid < 255)
   drop index PHONE_NUMBER.HAS_NUMBER_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PHONE_NUMBER')
            and   type = 'U')
   drop table PHONE_NUMBER
go

/*==============================================================*/
/* Table: ACCOUNT                                               */
/*==============================================================*/
create table ACCOUNT (
   ANUM                 numeric(8)           not null,
   SSN                  numeric(8)           not null,
   LOAN_TYPE            varchar(12)          not null,
   BALANCE              money                not null,
   constraint PK_ACCOUNT primary key nonclustered (ANUM)
)
go

/*==============================================================*/
/* Index: HAS_FK                                                */
/*==============================================================*/
create index HAS_FK on ACCOUNT (
SSN ASC
)
go

/*==============================================================*/
/* Table: BANK                                                  */
/*==============================================================*/
create table BANK (
   CODE                 numeric(3)           not null,
   NAME                 varchar(10)          not null,
   CITY                 varchar(10)          not null,
   STREET               varchar(10)          not null,
   DISTRICT             varchar(10)          not null,
   constraint PK_BANK primary key nonclustered (CODE)
)
go

/*==============================================================*/
/* Table: BANK_BRANCH                                           */
/*==============================================================*/
create table BANK_BRANCH (
   BNUM                 numeric(3)           not null,
   CODE                 numeric(3)           not null,
   CITY                 varchar(10)          not null,
   STREET               varchar(10)          not null,
   DISTRICT             varchar(10)          not null,
   constraint PK_BANK_BRANCH primary key nonclustered (BNUM)
)
go

/*==============================================================*/
/* Index: HAS_BRANCH_FK                                         */
/*==============================================================*/
create index HAS_BRANCH_FK on BANK_BRANCH (
CODE ASC
)
go

/*==============================================================*/
/* Table: CUSTOMER                                              */
/*==============================================================*/
create table CUSTOMER (
   SSN                  numeric(8)           not null,
   BNUM                 numeric(3)           not null,
   FNAME                varchar(12)          not null,
   LNAME                varchar(12)          not null,
   CITY                 varchar(10)          not null,
   STREET               varchar(10)          not null,
   DISTRICT             varchar(10)          not null,
   constraint PK_CUSTOMER primary key nonclustered (SSN)
)
go

/*==============================================================*/
/* Index: HAS_CUSTOMERS_FK                                      */
/*==============================================================*/
create index HAS_CUSTOMERS_FK on CUSTOMER (
BNUM ASC
)
go

/*==============================================================*/
/* Table: DEAL_WITH                                             */
/*==============================================================*/
create table DEAL_WITH (
   SSN                  numeric(8)           not null,
   EMPID                numeric(8)           not null,
   DNUM                 int                  not null,
   constraint PK_DEAL_WITH primary key (SSN, EMPID)
)
go

/*==============================================================*/
/* Index: DEALS_FK                                              */
/*==============================================================*/
create index DEALS_FK on DEAL_WITH (
SSN ASC
)
go

/*==============================================================*/
/* Index: DEAL_WITH_FK                                          */
/*==============================================================*/
create index DEAL_WITH_FK on DEAL_WITH (
EMPID ASC
)
go

/*==============================================================*/
/* Table: EMPLOYEE                                              */
/*==============================================================*/
create table EMPLOYEE (
   EMPID                numeric(8)           not null,
   BNUM                 numeric(3)           not null,
   FNAME                varchar(12)          not null,
   LNAME                varchar(12)          not null,
   constraint PK_EMPLOYEE primary key nonclustered (EMPID)
)
go

/*==============================================================*/
/* Index: WORKS_IN_FK                                           */
/*==============================================================*/
create index WORKS_IN_FK on EMPLOYEE (
BNUM ASC
)
go

/*==============================================================*/
/* Table: LOAN                                                  */
/*==============================================================*/
create table LOAN (
   LOANID               numeric(8)           not null,
   EMPID                numeric(8)           not null,
   BNUM                 numeric(3)           not null,
   SSN                  numeric(8)           not null,
   LOAN_TYPE            varchar(12)          not null,
   AMOUNT               money                not null,
   constraint PK_LOAN primary key nonclustered (LOANID)
)
go

/*==============================================================*/
/* Index: OFFERS_FK                                             */
/*==============================================================*/
create index OFFERS_FK on LOAN (
BNUM ASC
)
go

/*==============================================================*/
/* Index: HANDLE_FK                                             */
/*==============================================================*/
create index HANDLE_FK on LOAN (
EMPID ASC
)
go

/*==============================================================*/
/* Index: REQUEST_FK                                            */
/*==============================================================*/
create index REQUEST_FK on LOAN (
SSN ASC
)
go

/*==============================================================*/
/* Table: LOAN_TYPES                                            */
/*==============================================================*/
create table LOAN_TYPES (
   LOAN_TYPE            varchar(12)          null,
   BRANCH_NUM           numeric(3)           not null,
   BNUM                 numeric(3)           not null,
   constraint PK_LOAN_TYPES primary key nonclustered (BRANCH_NUM)
)
go

/*==============================================================*/
/* Index: HAS_LTYPES_FK                                         */
/*==============================================================*/
create index HAS_LTYPES_FK on LOAN_TYPES (
BNUM ASC
)
go

/*==============================================================*/
/* Table: PHONE_NUMBER                                          */
/*==============================================================*/
create table PHONE_NUMBER (
   PNUMBER              numeric(11)          not null,
   SSN                  numeric(8)           not null,
   constraint PK_PHONE_NUMBER primary key nonclustered (PNUMBER)
)
go

/*==============================================================*/
/* Index: HAS_NUMBER_FK                                         */
/*==============================================================*/
create index HAS_NUMBER_FK on PHONE_NUMBER (
SSN ASC
)
go

alter table ACCOUNT
   add constraint FK_ACCOUNT_HAS_CUSTOMER foreign key (SSN)
      references CUSTOMER (SSN)
go

alter table BANK_BRANCH
   add constraint FK_BANK_BRA_HAS_BRANC_BANK foreign key (CODE)
      references BANK (CODE)
go

alter table CUSTOMER
   add constraint FK_CUSTOMER_HAS_CUSTO_BANK_BRA foreign key (BNUM)
      references BANK_BRANCH (BNUM)
go

alter table DEAL_WITH
   add constraint FK_DEAL_WIT_DEALS_CUSTOMER foreign key (SSN)
      references CUSTOMER (SSN)
go

alter table DEAL_WITH
   add constraint FK_DEAL_WIT_DEAL_WITH_EMPLOYEE foreign key (EMPID)
      references EMPLOYEE (EMPID)
go

alter table EMPLOYEE
   add constraint FK_EMPLOYEE_WORKS_IN_BANK_BRA foreign key (BNUM)
      references BANK_BRANCH (BNUM)
go

alter table LOAN
   add constraint FK_LOAN_HANDLE_EMPLOYEE foreign key (EMPID)
      references EMPLOYEE (EMPID)
go

alter table LOAN
   add constraint FK_LOAN_OFFERS_BANK_BRA foreign key (BNUM)
      references BANK_BRANCH (BNUM)
go

alter table LOAN
   add constraint FK_LOAN_REQUEST_CUSTOMER foreign key (SSN)
      references CUSTOMER (SSN)
go

alter table LOAN_TYPES
   add constraint FK_LOAN_TYP_HAS_LTYPE_BANK_BRA foreign key (BNUM)
      references BANK_BRANCH (BNUM)
go

alter table PHONE_NUMBER
   add constraint FK_PHONE_NU_HAS_NUMBE_CUSTOMER foreign key (SSN)
      references CUSTOMER (SSN)
go

