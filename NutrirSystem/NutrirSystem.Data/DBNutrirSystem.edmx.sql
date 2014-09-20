
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 09/20/2014 02:15:05
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

IF OBJECT_ID(N'[dbo].[FK_Dieta_Usa_ProdutoClinica_Dieta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Dieta_Usa_ProdutoClinica] DROP CONSTRAINT [FK_Dieta_Usa_ProdutoClinica_Dieta];
GO
IF OBJECT_ID(N'[dbo].[FK_Dieta_Usa_ProdutoClinica_ProdutosClinica]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Dieta_Usa_ProdutoClinica] DROP CONSTRAINT [FK_Dieta_Usa_ProdutoClinica_ProdutosClinica];
GO
IF OBJECT_ID(N'[dbo].[FK_MedidasCorporaisConsulta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Consulta] DROP CONSTRAINT [FK_MedidasCorporaisConsulta];
GO
IF OBJECT_ID(N'[dbo].[FK_ConsultaPaciente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Consulta] DROP CONSTRAINT [FK_ConsultaPaciente];
GO
IF OBJECT_ID(N'[dbo].[FK_FuncionarioConsulta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Consulta] DROP CONSTRAINT [FK_FuncionarioConsulta];
GO
IF OBJECT_ID(N'[dbo].[FK_CartaoCreditoPagamento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CartaoCreditoSet] DROP CONSTRAINT [FK_CartaoCreditoPagamento];
GO
IF OBJECT_ID(N'[dbo].[FK_PagamentoConsulta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pagamento] DROP CONSTRAINT [FK_PagamentoConsulta];
GO
IF OBJECT_ID(N'[dbo].[FK_PacienteDieta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoa_Paciente] DROP CONSTRAINT [FK_PacienteDieta];
GO
IF OBJECT_ID(N'[dbo].[FK_PacienteConvenio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoa_Paciente] DROP CONSTRAINT [FK_PacienteConvenio];
GO
IF OBJECT_ID(N'[dbo].[FK_Paciente_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoa_Paciente] DROP CONSTRAINT [FK_Paciente_inherits_Pessoa];
GO
IF OBJECT_ID(N'[dbo].[FK_Funcionario_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoa_Funcionario] DROP CONSTRAINT [FK_Funcionario_inherits_Pessoa];
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
IF OBJECT_ID(N'[dbo].[CartaoCreditoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CartaoCreditoSet];
GO
IF OBJECT_ID(N'[dbo].[Pessoa_Paciente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoa_Paciente];
GO
IF OBJECT_ID(N'[dbo].[Pessoa_Funcionario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoa_Funcionario];
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
    [tipoConsulta] int  NULL,
    [DataHora] datetime  NOT NULL,
    [MedidasCorporais_idMedidasCorporais] decimal(5,0)  NOT NULL,
    [MedidasCorporais_idMedidasCorporais1] decimal(5,0)  NOT NULL,
    [Paciente_cpf] decimal(11,0)  NOT NULL,
    [Funcionario_cpf] decimal(11,0)  NOT NULL
);
GO

-- Creating table 'Convenio'
CREATE TABLE [dbo].[Convenio] (
    [numPlano] decimal(5,0)  NOT NULL,
    [nome] varchar(80)  NOT NULL
);
GO

-- Creating table 'Dieta'
CREATE TABLE [dbo].[Dieta] (
    [idDieta] decimal(10,0)  NOT NULL,
    [dieta] varchar(500)  NOT NULL
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
    [statusPagamento] int  NOT NULL,
    [Data] datetime  NOT NULL,
    [Consulta_idConsulta] decimal(5,0)  NOT NULL
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

-- Creating table 'CartaoCreditoSet'
CREATE TABLE [dbo].[CartaoCreditoSet] (
    [Id] decimal(18,0) IDENTITY(1,1) NOT NULL,
    [Bandeira] int  NOT NULL,
    [Titular] nvarchar(max)  NOT NULL,
    [numParc] decimal(18,0)  NOT NULL,
    [valorParc] decimal(18,0)  NOT NULL,
    [Pagamento_idPagamento] decimal(10,0)  NOT NULL
);
GO

-- Creating table 'Pessoa_Paciente'
CREATE TABLE [dbo].[Pessoa_Paciente] (
    [objetivo] varchar(500)  NOT NULL,
    [esportesPraticados] varchar(80)  NULL,
    [tipoSanguineo] int  NOT NULL,
    [descHabitosEsp] varchar(300)  NULL,
    [descHabitosAli] varchar(300)  NULL,
    [cpf] decimal(11,0)  NOT NULL,
    [Dieta_idDieta] decimal(10,0)  NULL,
    [Convenio_numPlano] decimal(5,0)  NULL
);
GO

-- Creating table 'Pessoa_Funcionario'
CREATE TABLE [dbo].[Pessoa_Funcionario] (
    [usuario] varchar(20)  NOT NULL,
    [password] varchar(80)  NOT NULL,
    [salario] decimal(12,0)  NOT NULL,
    [perfil] int  NOT NULL,
    [CRN] decimal(18,0)  NULL,
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

-- Creating primary key on [Id] in table 'CartaoCreditoSet'
ALTER TABLE [dbo].[CartaoCreditoSet]
ADD CONSTRAINT [PK_CartaoCreditoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
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

-- Creating primary key on [Dieta_idDieta], [ProdutosClinica_idProdutosClinica] in table 'Dieta_Usa_ProdutoClinica'
ALTER TABLE [dbo].[Dieta_Usa_ProdutoClinica]
ADD CONSTRAINT [PK_Dieta_Usa_ProdutoClinica]
    PRIMARY KEY NONCLUSTERED ([Dieta_idDieta], [ProdutosClinica_idProdutosClinica] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

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

-- Creating foreign key on [MedidasCorporais_idMedidasCorporais1] in table 'Consulta'
ALTER TABLE [dbo].[Consulta]
ADD CONSTRAINT [FK_MedidasCorporaisConsulta]
    FOREIGN KEY ([MedidasCorporais_idMedidasCorporais1])
    REFERENCES [dbo].[MedidasCorporais]
        ([idMedidasCorporais])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MedidasCorporaisConsulta'
CREATE INDEX [IX_FK_MedidasCorporaisConsulta]
ON [dbo].[Consulta]
    ([MedidasCorporais_idMedidasCorporais1]);
GO

-- Creating foreign key on [Paciente_cpf] in table 'Consulta'
ALTER TABLE [dbo].[Consulta]
ADD CONSTRAINT [FK_ConsultaPaciente]
    FOREIGN KEY ([Paciente_cpf])
    REFERENCES [dbo].[Pessoa_Paciente]
        ([cpf])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ConsultaPaciente'
CREATE INDEX [IX_FK_ConsultaPaciente]
ON [dbo].[Consulta]
    ([Paciente_cpf]);
GO

-- Creating foreign key on [Funcionario_cpf] in table 'Consulta'
ALTER TABLE [dbo].[Consulta]
ADD CONSTRAINT [FK_FuncionarioConsulta]
    FOREIGN KEY ([Funcionario_cpf])
    REFERENCES [dbo].[Pessoa_Funcionario]
        ([cpf])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FuncionarioConsulta'
CREATE INDEX [IX_FK_FuncionarioConsulta]
ON [dbo].[Consulta]
    ([Funcionario_cpf]);
GO

-- Creating foreign key on [Pagamento_idPagamento] in table 'CartaoCreditoSet'
ALTER TABLE [dbo].[CartaoCreditoSet]
ADD CONSTRAINT [FK_CartaoCreditoPagamento]
    FOREIGN KEY ([Pagamento_idPagamento])
    REFERENCES [dbo].[Pagamento]
        ([idPagamento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CartaoCreditoPagamento'
CREATE INDEX [IX_FK_CartaoCreditoPagamento]
ON [dbo].[CartaoCreditoSet]
    ([Pagamento_idPagamento]);
GO

-- Creating foreign key on [Consulta_idConsulta] in table 'Pagamento'
ALTER TABLE [dbo].[Pagamento]
ADD CONSTRAINT [FK_PagamentoConsulta]
    FOREIGN KEY ([Consulta_idConsulta])
    REFERENCES [dbo].[Consulta]
        ([idConsulta])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PagamentoConsulta'
CREATE INDEX [IX_FK_PagamentoConsulta]
ON [dbo].[Pagamento]
    ([Consulta_idConsulta]);
GO

-- Creating foreign key on [Dieta_idDieta] in table 'Pessoa_Paciente'
ALTER TABLE [dbo].[Pessoa_Paciente]
ADD CONSTRAINT [FK_PacienteDieta]
    FOREIGN KEY ([Dieta_idDieta])
    REFERENCES [dbo].[Dieta]
        ([idDieta])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PacienteDieta'
CREATE INDEX [IX_FK_PacienteDieta]
ON [dbo].[Pessoa_Paciente]
    ([Dieta_idDieta]);
GO

-- Creating foreign key on [Convenio_numPlano] in table 'Pessoa_Paciente'
ALTER TABLE [dbo].[Pessoa_Paciente]
ADD CONSTRAINT [FK_PacienteConvenio]
    FOREIGN KEY ([Convenio_numPlano])
    REFERENCES [dbo].[Convenio]
        ([numPlano])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PacienteConvenio'
CREATE INDEX [IX_FK_PacienteConvenio]
ON [dbo].[Pessoa_Paciente]
    ([Convenio_numPlano]);
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

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------