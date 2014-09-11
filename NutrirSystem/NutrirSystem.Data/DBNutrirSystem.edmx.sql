
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 09/11/2014 01:37:28
-- Generated from EDMX file: C:\Users\Lucas Corrêa\Documents\GitHub\NutrirSystemRepositorio\NutrirSystem\NutrirSystem.Data\DBNutrirSystem.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DBNutrirSystem];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__Consulta__idPaci__33D4B598]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Consulta] DROP CONSTRAINT [FK__Consulta__idPaci__33D4B598];
GO
IF OBJECT_ID(N'[dbo].[FK__Consulta__Medida__35BCFE0A]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Consulta] DROP CONSTRAINT [FK__Consulta__Medida__35BCFE0A];
GO
IF OBJECT_ID(N'[dbo].[FK__Consulta__Nutric__36B12243]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Consulta] DROP CONSTRAINT [FK__Consulta__Nutric__36B12243];
GO
IF OBJECT_ID(N'[dbo].[FK__Consulta__Pagame__34C8D9D1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Consulta] DROP CONSTRAINT [FK__Consulta__Pagame__34C8D9D1];
GO
IF OBJECT_ID(N'[dbo].[FK__Convenio__Pacien__267ABA7A]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Convenio] DROP CONSTRAINT [FK__Convenio__Pacien__267ABA7A];
GO
IF OBJECT_ID(N'[dbo].[FK__Paciente__Dieta__21B6055D]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoa_Paciente] DROP CONSTRAINT [FK__Paciente__Dieta__21B6055D];
GO
IF OBJECT_ID(N'[dbo].[FK__Paciente__Habito__20C1E124]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoa_Paciente] DROP CONSTRAINT [FK__Paciente__Habito__20C1E124];
GO
IF OBJECT_ID(N'[dbo].[FK_Dieta_Usa_ProdutoClinica_Dieta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Dieta_Usa_ProdutoClinica] DROP CONSTRAINT [FK_Dieta_Usa_ProdutoClinica_Dieta];
GO
IF OBJECT_ID(N'[dbo].[FK_Dieta_Usa_ProdutoClinica_ProdutosClinica]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Dieta_Usa_ProdutoClinica] DROP CONSTRAINT [FK_Dieta_Usa_ProdutoClinica_ProdutosClinica];
GO
IF OBJECT_ID(N'[dbo].[FK_Paciente_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoa_Paciente] DROP CONSTRAINT [FK_Paciente_inherits_Pessoa];
GO
IF OBJECT_ID(N'[dbo].[FK_Funcionario_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoa_Funcionario] DROP CONSTRAINT [FK_Funcionario_inherits_Pessoa];
GO
IF OBJECT_ID(N'[dbo].[FK_Nutricionista_inherits_Funcionario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoa_Nutricionista] DROP CONSTRAINT [FK_Nutricionista_inherits_Funcionario];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Consulta]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Consulta];
GO
IF OBJECT_ID(N'[dbo].[Convenio]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Convenio];
GO
IF OBJECT_ID(N'[dbo].[Dieta]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Dieta];
GO
IF OBJECT_ID(N'[dbo].[Habitos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Habitos];
GO
IF OBJECT_ID(N'[dbo].[MedidasCorporais]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MedidasCorporais];
GO
IF OBJECT_ID(N'[dbo].[Pagamento]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pagamento];
GO
IF OBJECT_ID(N'[dbo].[Pessoa]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoa];
GO
IF OBJECT_ID(N'[dbo].[ProdutosClinica]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProdutosClinica];
GO
IF OBJECT_ID(N'[dbo].[Pessoa_Paciente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoa_Paciente];
GO
IF OBJECT_ID(N'[dbo].[Pessoa_Funcionario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoa_Funcionario];
GO
IF OBJECT_ID(N'[dbo].[Pessoa_Nutricionista]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoa_Nutricionista];
GO
IF OBJECT_ID(N'[dbo].[Dieta_Usa_ProdutoClinica]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Dieta_Usa_ProdutoClinica];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Consulta'
CREATE TABLE [dbo].[Consulta] (
    [idConsulta] decimal(5,0)  NOT NULL,
    [statusConsulta] int  NULL,
    [data] datetime  NOT NULL,
    [hora] int  NOT NULL,
    [tipoConsulta] int  NULL,
    [Nutricionista] decimal(11,0)  NOT NULL,
    [cpfPaciente] decimal(11,0)  NOT NULL,
    [Pagamento] decimal(10,0)  NULL,
    [MedidasCorporais] decimal(5,0)  NOT NULL
);
GO

-- Creating table 'Convenio'
CREATE TABLE [dbo].[Convenio] (
    [numPlano] decimal(5,0)  NOT NULL,
    [nome] varchar(80)  NOT NULL,
    [Paciente] decimal(11,0)  NOT NULL
);
GO

-- Creating table 'Dieta'
CREATE TABLE [dbo].[Dieta] (
    [idDieta] decimal(10,0)  NOT NULL,
    [dieta1] varchar(80)  NOT NULL
);
GO

-- Creating table 'Habitos'
CREATE TABLE [dbo].[Habitos] (
    [IdHabito] decimal(5,0)  NOT NULL,
    [descricaoHabitosEsportivos] varchar(80)  NULL,
    [descricaoHabitosAlimentares] varchar(80)  NOT NULL
);
GO

-- Creating table 'MedidasCorporais'
CREATE TABLE [dbo].[MedidasCorporais] (
    [idMedidasCorporais] decimal(5,0)  NOT NULL,
    [peso] float  NULL,
    [imc] float  NULL,
    [altura] float  NULL,
    [massaMagra] float  NULL,
    [percGordura] float  NULL,
    [glicemia] float  NULL
);
GO

-- Creating table 'Pagamento'
CREATE TABLE [dbo].[Pagamento] (
    [idPagamento] decimal(10,0)  NOT NULL,
    [valor] decimal(5,0)  NOT NULL,
    [formaPagamento] int  NOT NULL,
    [statusPagamento] int  NOT NULL
);
GO

-- Creating table 'Pessoa'
CREATE TABLE [dbo].[Pessoa] (
    [cpf] decimal(11,0)  NOT NULL,
    [nome] varchar(80)  NOT NULL,
    [rua] varchar(80)  NOT NULL,
    [numero] decimal(5,0)  NOT NULL,
    [bairro] varchar(80)  NULL,
    [cidade] varchar(80)  NULL,
    [estado] varchar(80)  NULL,
    [sexo] int  NOT NULL,
    [email] varchar(80)  NULL,
    [dataNascimento] datetime  NOT NULL,
    [telefone] varchar(80)  NOT NULL,
    [celular] varchar(80)  NULL,
    [apelido] varchar(80)  NULL
);
GO

-- Creating table 'ProdutosClinica'
CREATE TABLE [dbo].[ProdutosClinica] (
    [idProdutosClinica] decimal(10,0)  NOT NULL,
    [nome] varchar(80)  NOT NULL,
    [gordura] varchar(80)  NOT NULL,
    [carboidratos] varchar(80)  NOT NULL,
    [fibra] varchar(80)  NOT NULL,
    [sodio] varchar(80)  NOT NULL
);
GO

-- Creating table 'Pessoa_Paciente'
CREATE TABLE [dbo].[Pessoa_Paciente] (
    [objetivo] varchar(80)  NOT NULL,
    [esportesPraticados] varchar(80)  NULL,
    [tipoSanguineo] int  NOT NULL,
    [Dieta] decimal(10,0)  NOT NULL,
    [Habitos] decimal(5,0)  NOT NULL,
    [cpf] decimal(11,0)  NOT NULL
);
GO

-- Creating table 'Pessoa_Funcionario'
CREATE TABLE [dbo].[Pessoa_Funcionario] (
    [usuario] varchar(20)  NOT NULL,
    [password] varchar(80)  NOT NULL,
    [salario] decimal(12,0)  NOT NULL,
    [perfil] int  NOT NULL,
    [cpf] decimal(11,0)  NOT NULL
);
GO

-- Creating table 'Pessoa_Nutricionista'
CREATE TABLE [dbo].[Pessoa_Nutricionista] (
    [crm] decimal(5,0)  NOT NULL,
    [cpf] decimal(11,0)  NOT NULL
);
GO

-- Creating table 'Dieta_Usa_ProdutoClinica'
CREATE TABLE [dbo].[Dieta_Usa_ProdutoClinica] (
    [Dieta_idDieta] decimal(10,0)  NOT NULL,
    [ProdutosClinica_idProdutosClinica] decimal(10,0)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [idConsulta] in table 'Consulta'
ALTER TABLE [dbo].[Consulta]
ADD CONSTRAINT [PK_Consulta]
    PRIMARY KEY CLUSTERED ([idConsulta] ASC);
GO

-- Creating primary key on [numPlano] in table 'Convenio'
ALTER TABLE [dbo].[Convenio]
ADD CONSTRAINT [PK_Convenio]
    PRIMARY KEY CLUSTERED ([numPlano] ASC);
GO

-- Creating primary key on [idDieta] in table 'Dieta'
ALTER TABLE [dbo].[Dieta]
ADD CONSTRAINT [PK_Dieta]
    PRIMARY KEY CLUSTERED ([idDieta] ASC);
GO

-- Creating primary key on [IdHabito] in table 'Habitos'
ALTER TABLE [dbo].[Habitos]
ADD CONSTRAINT [PK_Habitos]
    PRIMARY KEY CLUSTERED ([IdHabito] ASC);
GO

-- Creating primary key on [idMedidasCorporais] in table 'MedidasCorporais'
ALTER TABLE [dbo].[MedidasCorporais]
ADD CONSTRAINT [PK_MedidasCorporais]
    PRIMARY KEY CLUSTERED ([idMedidasCorporais] ASC);
GO

-- Creating primary key on [idPagamento] in table 'Pagamento'
ALTER TABLE [dbo].[Pagamento]
ADD CONSTRAINT [PK_Pagamento]
    PRIMARY KEY CLUSTERED ([idPagamento] ASC);
GO

-- Creating primary key on [cpf] in table 'Pessoa'
ALTER TABLE [dbo].[Pessoa]
ADD CONSTRAINT [PK_Pessoa]
    PRIMARY KEY CLUSTERED ([cpf] ASC);
GO

-- Creating primary key on [idProdutosClinica] in table 'ProdutosClinica'
ALTER TABLE [dbo].[ProdutosClinica]
ADD CONSTRAINT [PK_ProdutosClinica]
    PRIMARY KEY CLUSTERED ([idProdutosClinica] ASC);
GO

-- Creating primary key on [cpf] in table 'Pessoa_Paciente'
ALTER TABLE [dbo].[Pessoa_Paciente]
ADD CONSTRAINT [PK_Pessoa_Paciente]
    PRIMARY KEY CLUSTERED ([cpf] ASC);
GO

-- Creating primary key on [cpf] in table 'Pessoa_Funcionario'
ALTER TABLE [dbo].[Pessoa_Funcionario]
ADD CONSTRAINT [PK_Pessoa_Funcionario]
    PRIMARY KEY CLUSTERED ([cpf] ASC);
GO

-- Creating primary key on [cpf] in table 'Pessoa_Nutricionista'
ALTER TABLE [dbo].[Pessoa_Nutricionista]
ADD CONSTRAINT [PK_Pessoa_Nutricionista]
    PRIMARY KEY CLUSTERED ([cpf] ASC);
GO

-- Creating primary key on [Dieta_idDieta], [ProdutosClinica_idProdutosClinica] in table 'Dieta_Usa_ProdutoClinica'
ALTER TABLE [dbo].[Dieta_Usa_ProdutoClinica]
ADD CONSTRAINT [PK_Dieta_Usa_ProdutoClinica]
    PRIMARY KEY NONCLUSTERED ([Dieta_idDieta], [ProdutosClinica_idProdutosClinica] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [cpfPaciente] in table 'Consulta'
ALTER TABLE [dbo].[Consulta]
ADD CONSTRAINT [FK__Consulta__idPaci__33D4B598]
    FOREIGN KEY ([cpfPaciente])
    REFERENCES [dbo].[Pessoa_Paciente]
        ([cpf])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__Consulta__idPaci__33D4B598'
CREATE INDEX [IX_FK__Consulta__idPaci__33D4B598]
ON [dbo].[Consulta]
    ([cpfPaciente]);
GO

-- Creating foreign key on [MedidasCorporais] in table 'Consulta'
ALTER TABLE [dbo].[Consulta]
ADD CONSTRAINT [FK__Consulta__Medida__35BCFE0A]
    FOREIGN KEY ([MedidasCorporais])
    REFERENCES [dbo].[MedidasCorporais]
        ([idMedidasCorporais])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__Consulta__Medida__35BCFE0A'
CREATE INDEX [IX_FK__Consulta__Medida__35BCFE0A]
ON [dbo].[Consulta]
    ([MedidasCorporais]);
GO

-- Creating foreign key on [Nutricionista] in table 'Consulta'
ALTER TABLE [dbo].[Consulta]
ADD CONSTRAINT [FK__Consulta__Nutric__36B12243]
    FOREIGN KEY ([Nutricionista])
    REFERENCES [dbo].[Pessoa_Nutricionista]
        ([cpf])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__Consulta__Nutric__36B12243'
CREATE INDEX [IX_FK__Consulta__Nutric__36B12243]
ON [dbo].[Consulta]
    ([Nutricionista]);
GO

-- Creating foreign key on [Pagamento] in table 'Consulta'
ALTER TABLE [dbo].[Consulta]
ADD CONSTRAINT [FK__Consulta__Pagame__34C8D9D1]
    FOREIGN KEY ([Pagamento])
    REFERENCES [dbo].[Pagamento]
        ([idPagamento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__Consulta__Pagame__34C8D9D1'
CREATE INDEX [IX_FK__Consulta__Pagame__34C8D9D1]
ON [dbo].[Consulta]
    ([Pagamento]);
GO

-- Creating foreign key on [Paciente] in table 'Convenio'
ALTER TABLE [dbo].[Convenio]
ADD CONSTRAINT [FK__Convenio__Pacien__267ABA7A]
    FOREIGN KEY ([Paciente])
    REFERENCES [dbo].[Pessoa_Paciente]
        ([cpf])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__Convenio__Pacien__267ABA7A'
CREATE INDEX [IX_FK__Convenio__Pacien__267ABA7A]
ON [dbo].[Convenio]
    ([Paciente]);
GO

-- Creating foreign key on [Dieta] in table 'Pessoa_Paciente'
ALTER TABLE [dbo].[Pessoa_Paciente]
ADD CONSTRAINT [FK__Paciente__Dieta__21B6055D]
    FOREIGN KEY ([Dieta])
    REFERENCES [dbo].[Dieta]
        ([idDieta])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__Paciente__Dieta__21B6055D'
CREATE INDEX [IX_FK__Paciente__Dieta__21B6055D]
ON [dbo].[Pessoa_Paciente]
    ([Dieta]);
GO

-- Creating foreign key on [Habitos] in table 'Pessoa_Paciente'
ALTER TABLE [dbo].[Pessoa_Paciente]
ADD CONSTRAINT [FK__Paciente__Habito__20C1E124]
    FOREIGN KEY ([Habitos])
    REFERENCES [dbo].[Habitos]
        ([IdHabito])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK__Paciente__Habito__20C1E124'
CREATE INDEX [IX_FK__Paciente__Habito__20C1E124]
ON [dbo].[Pessoa_Paciente]
    ([Habitos]);
GO

-- Creating foreign key on [Dieta_idDieta] in table 'Dieta_Usa_ProdutoClinica'
ALTER TABLE [dbo].[Dieta_Usa_ProdutoClinica]
ADD CONSTRAINT [FK_Dieta_Usa_ProdutoClinica_Dieta]
    FOREIGN KEY ([Dieta_idDieta])
    REFERENCES [dbo].[Dieta]
        ([idDieta])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ProdutosClinica_idProdutosClinica] in table 'Dieta_Usa_ProdutoClinica'
ALTER TABLE [dbo].[Dieta_Usa_ProdutoClinica]
ADD CONSTRAINT [FK_Dieta_Usa_ProdutoClinica_ProdutosClinica]
    FOREIGN KEY ([ProdutosClinica_idProdutosClinica])
    REFERENCES [dbo].[ProdutosClinica]
        ([idProdutosClinica])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Dieta_Usa_ProdutoClinica_ProdutosClinica'
CREATE INDEX [IX_FK_Dieta_Usa_ProdutoClinica_ProdutosClinica]
ON [dbo].[Dieta_Usa_ProdutoClinica]
    ([ProdutosClinica_idProdutosClinica]);
GO

-- Creating foreign key on [cpf] in table 'Pessoa_Paciente'
ALTER TABLE [dbo].[Pessoa_Paciente]
ADD CONSTRAINT [FK_Paciente_inherits_Pessoa]
    FOREIGN KEY ([cpf])
    REFERENCES [dbo].[Pessoa]
        ([cpf])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [cpf] in table 'Pessoa_Funcionario'
ALTER TABLE [dbo].[Pessoa_Funcionario]
ADD CONSTRAINT [FK_Funcionario_inherits_Pessoa]
    FOREIGN KEY ([cpf])
    REFERENCES [dbo].[Pessoa]
        ([cpf])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [cpf] in table 'Pessoa_Nutricionista'
ALTER TABLE [dbo].[Pessoa_Nutricionista]
ADD CONSTRAINT [FK_Nutricionista_inherits_Funcionario]
    FOREIGN KEY ([cpf])
    REFERENCES [dbo].[Pessoa_Funcionario]
        ([cpf])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------