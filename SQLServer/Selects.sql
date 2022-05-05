--Listar todos os clientes do estado de SP que tenham mais de 60% das parcelas pagas.

select c.IdCliente, c.Nome, c.UF, c.Celular 
  from tbCliente c 
  inner join tbClienteFinanciamento cf on c.IdCliente = cf.IdCliente 
  inner join tbFinanciamentoParcela fp on cf.IdClienteFinanciamento = fp.IdClienteFinanciamento 
  where c.UF = 'SP'
  group by c.IdCliente, c.Nome, c.UF, c.Celular, cf.ParcelasTotal
  having (((convert(float,count(fp.NumeroParcela)) / convert(float,cf.ParcelasTotal)*100)) > 60)

--Listar os primeiros 4 clientes que tenham alguma parcela com mais de 05 dias atrasadas (DataVencimento maior que data atual E data pagamento nula)

select top 4 c.IdCliente, c.Nome, c.UF, c.Celular
  from tbFinanciamentoParcela fp
 inner join tbClienteFinanciamento cf on fp.IdClienteFinanciamento = cf.IdClienteFinanciamento 
 inner join tbCliente c on  cf.IdCliente = c.IdCliente 
where fp.DtVencimentoParcela < (GETDATE() -5) and fp.DtPagamentoParcela is null


-- Listar todos os clientes que já atrasaram em algum momento duas ou mais parcelas em mais de 10 dias, e que o valor do financiamento seja maior que R$ 10.000,00.

select distinct top 4  c.IdCliente, c.Nome, c.UF, c.Celular
  from tbFinanciamentoParcela fp
 inner join tbClienteFinanciamento cf on fp.IdClienteFinanciamento = cf.IdClienteFinanciamento 
 inner join tbCliente c on  cf.IdCliente = c.IdCliente 
where DATEDIFF(d,fp.DtVencimentoParcela, fp.DtPagamentoParcela) > 10
and cf.ValorTotal > 10000





