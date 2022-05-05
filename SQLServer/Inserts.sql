
INSERT INTO tbCliente values ('Cliente A','SP','(11) 99867-5309')
GO
INSERT INTO tbCliente values ('Cliente B','SP','(11) 98866-5310')
GO
INSERT INTO tbCliente values ('Cliente C','MG','(11) 97865-5311')
GO
INSERT INTO tbCliente values ('Cliente D','MG','(11) 96864-5312')
GO
INSERT INTO tbCliente values ('Cliente E','RS','(11) 95863-5313')
GO
INSERT INTO tbCliente values ('Cliente F','RS','(11) 94862-5314')
GO
INSERT INTO tbCliente values ('Cliente G','PE','(11) 93861-5315')
GO
INSERT INTO tbCliente values ('Cliente H','PE','(11) 92860-5316')
GO

INSERT INTO tbFinanciamento values ('Crédito Direto - Taxa de 2 % ao mês', 2, 'mes', 'PF')
GO
INSERT INTO tbFinanciamento values ('Crédito Consignado - Taxa de 1 % ao mês', 1, 'mes', 'PF')
GO
INSERT INTO tbFinanciamento values ('Crédito Pessoa Jurídica - Taxa de 5% ao mês', 5, 'mes', 'PJ')
GO
INSERT INTO tbFinanciamento values ('Crédito Pessoa Física - Taxa de 3% ao mês', 3, 'mes', 'PF')
GO
INSERT INTO tbFinanciamento values ('Crédito Imobiliário - Taxa de 9% ao ano', 9, 'ano', 'PF')
GO

INSERT INTO tbClienteFinanciamento values (1, 1, 12, 10000,'2022-05-20 00:00:00.000')
GO
INSERT INTO tbClienteFinanciamento values (1, 2, 12,100000,'2022-05-20 00:00:00.000')
GO
INSERT INTO tbClienteFinanciamento values (2, 3, 10, 20000,'2022-05-20 00:00:00.000')
GO
INSERT INTO tbClienteFinanciamento values (2, 4, 6, 30000,'2022-05-20 00:00:00.000')
GO
INSERT INTO tbClienteFinanciamento values (3, 5, 8, 40000,'2022-05-20 00:00:00.000')
GO
INSERT INTO tbClienteFinanciamento values (3, 2,8, 130000,'2022-05-20 00:00:00.000')
GO
INSERT INTO tbClienteFinanciamento values (4, 3, 6, 50000,'2022-05-20 00:00:00.000')
GO
INSERT INTO tbClienteFinanciamento values (4, 5, 6, 60000,'2022-05-20 00:00:00.000')
GO
INSERT INTO tbClienteFinanciamento values (5, 1, 5, 70000,'2022-05-20 00:00:00.000')
GO
INSERT INTO tbClienteFinanciamento values (5, 2, 9, 80000,'2022-05-20 00:00:00.000')
GO
INSERT INTO tbClienteFinanciamento values (6, 3, 10, 90000,'2022-05-20 00:00:00.000')
GO
INSERT INTO tbClienteFinanciamento values (6, 4, 10,17700,'2022-05-20 00:00:00.000')
GO
INSERT INTO tbClienteFinanciamento values (7, 5, 10,180000,'2022-05-20 00:00:00.000')
GO
INSERT INTO tbClienteFinanciamento values (7, 1, 8,190000,'2022-05-20 00:00:00.000')
GO
INSERT INTO tbClienteFinanciamento values (8, 2, 6,100600,'2022-05-20 00:00:00.000')
GO
INSERT INTO tbClienteFinanciamento values (8, 4, 6, 100700,'2022-05-20 00:00:00.000')
GO


INSERT INTO tbFinanciamentoParcela VALUES (1, 1, 10, '2022-03-20 00:00:00.000', '2022-05-19 00:00:00.000')
GO
INSERT INTO tbFinanciamentoParcela VALUES (1, 2, 10, '2022-04-20 00:00:00.000', '2022-05-19 00:00:00.000')
GO
INSERT INTO tbFinanciamentoParcela VALUES (1, 3, 10, '2022-05-20 00:00:00.000', '2022-05-19 00:00:00.000')
GO
INSERT INTO tbFinanciamentoParcela VALUES (4, 1, 20, '2022-05-20 00:00:00.000', '2022-06-19 00:00:00.000')
GO
INSERT INTO tbFinanciamentoParcela VALUES (4, 2, 20, '2022-06-20 00:00:00.000', null)
GO
INSERT INTO tbFinanciamentoParcela VALUES (4, 3, 20, '2022-07-20 00:00:00.000', null)
GO
INSERT INTO tbFinanciamentoParcela VALUES (4, 4, 20, '2022-08-20 00:00:00.000', null)
GO
INSERT INTO tbFinanciamentoParcela VALUES (6, 1, 30, '2022-02-20 00:00:00.000', '2022-02-28 00:00:00.000')
GO
INSERT INTO tbFinanciamentoParcela VALUES (6, 2, 30, '2022-03-20 00:00:00.000', '2022-03-19 00:00:00.000')
GO
INSERT INTO tbFinanciamentoParcela VALUES (6, 3, 30, '2022-04-20 00:00:00.000', '2022-04-21 00:00:00.000')
GO
INSERT INTO tbFinanciamentoParcela VALUES (6, 4, 30, '2022-05-20 00:00:00.000', '2022-05-28 00:00:00.000')
GO
INSERT INTO tbFinanciamentoParcela VALUES (6, 5, 30, '2022-06-20 00:00:00.000', null)
GO
INSERT INTO tbFinanciamentoParcela VALUES (14, 1, 40, '2021-05-20 00:00:00.000', '2022-05-19 00:00:00.000')
GO
INSERT INTO tbFinanciamentoParcela VALUES (14, 2, 40, '2021-06-20 00:00:00.000', null)
GO
INSERT INTO tbFinanciamentoParcela VALUES (13, 1, 40, '2022-05-20 00:00:00.000', '2022-05-19 00:00:00.000')
GO
INSERT INTO tbFinanciamentoParcela VALUES (13, 2, 40, '2022-06-20 00:00:00.000', null)
GO
INSERT INTO tbFinanciamentoParcela VALUES (13, 3, 50, '2022-06-20 00:00:00.000', null)
GO
INSERT INTO tbFinanciamentoParcela VALUES (13, 4, 50, '2022-07-22 00:00:00.000', null)
GO
INSERT INTO tbFinanciamentoParcela VALUES (13, 5, 50, '2022-08-24 00:00:00.000', null)
GO
INSERT INTO tbFinanciamentoParcela VALUES (9, 1, 140, '2021-05-20 00:00:00.000', '2022-05-19 00:00:00.000')
GO
INSERT INTO tbFinanciamentoParcela VALUES (9, 2, 140, '2021-06-20 00:00:00.000', null)
GO
INSERT INTO tbFinanciamentoParcela VALUES (10, 1, 150, '2022-05-20 00:00:00.000', '2022-05-19 00:00:00.000')
GO
INSERT INTO tbFinanciamentoParcela VALUES (10, 2, 150, '2022-06-20 00:00:00.000', null)
GO
INSERT INTO tbFinanciamentoParcela VALUES (10, 3, 150, '2022-06-20 00:00:00.000', null)
GO
INSERT INTO tbFinanciamentoParcela VALUES (10, 4, 150, '2022-07-22 00:00:00.000', null)
GO
INSERT INTO tbFinanciamentoParcela VALUES (10, 5, 150, '2022-08-24 00:00:00.000', null)
GO














