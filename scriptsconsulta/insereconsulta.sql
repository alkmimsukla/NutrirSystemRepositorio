USE [DBNutrirSystem]
GO

INSERT INTO [dbo].[Consulta]
           ([idConsulta]
           ,[statusConsulta]
           ,[tipoConsulta]
           ,[DataHora]
           ,[Paciente_cpf]
           ,[Funcionario_cpf]
           ,[MedidasCorporais_idMedidasCorporais])
     VALUES
           (4
           ,2
           ,5
           ,'2014-10-01 00:00:00.000'
           ,64692138807
           ,55555555555
           ,4)
GO


