//cliente e onde mora

SELECT c.NOME, c.CONTATO, e.RUA, e.NUMERO 
FROM CLIENTE c
JOIN ENDERECO e ON c.ID = e.CLIENTE_ID;

//endereço das ordens de serviço e datas

SELECT e.RUA, e.NUMERO, os.ID as ID_ORDEM, os.DATA, os.DESCRICAO
FROM ENDERECO e
JOIN ORDEM_SERVICO os ON e.ID = os.ENDERECO_ID;

//ordem de serviço e pagamento

SELECT os.ID as ID_ORDEM, os.STATUS, p.DESCRICAO as METODO_PAGAMENTO, p.VALOR
FROM ORDEM_SERVICO os
JOIN PAGAMENTO p ON os.ID = p.ORDEM_SERVICO_ID;

//ordem de serviço e serviços

SELECT os.ID as ID_ORDEM, s.DESCRICAO as NOME_SERVICO, s.VALOR
FROM ORDEM_SERVICO os
JOIN SERVICO_ORDEM_SERVICO sos ON os.ID = sos.ORDEM_SERVICO_ID
JOIN SERVICO s ON sos.SERVICO_ID = s.ID;

//////////////////////////////////////////////////////
/////////             JOINS		//////////////
//////////////////////////////////////////////////////

//total gasto e quantidade de ordens de serviço por cliente

SELECT 
    c.NOME, 
    COUNT(os.ID) AS total_ordens, 
    SUM(p.VALOR) AS valor_total_gasto
FROM CLIENTE c
JOIN ENDERECO e ON c.ID = e.CLIENTE_ID
JOIN ORDEM_SERVICO os ON e.ID = os.ENDERECO_ID
JOIN PAGAMENTO p ON os.ID = p.ORDEM_SERVICO_ID
GROUP BY c.ID, c.NOME
ORDER BY valor_total_gasto DESC;

//serviços mais solicitados e valor gerado por eles

SELECT 
    s.DESCRICAO AS servico, 
    COUNT(sos.ORDEM_SERVICO_ID) AS vezes_solicitado, 
    SUM(s.VALOR) AS valor_total_gerado
FROM SERVICO s
JOIN SERVICO_ORDEM_SERVICO sos ON s.ID = sos.SERVICO_ID
GROUP BY s.ID, s.DESCRICAO
ORDER BY vezes_solicitado DESC;

//valor arrecadado por método de pagamento

SELECT 
    p.DESCRICAO AS metodo_pagamento, 
    COUNT(os.ID) AS quantidade_vendas, 
    SUM(p.VALOR) AS total_arrecadado,
    SUM(p.DESCONTO) AS total_descontos_cedidos
FROM PAGAMENTO p
JOIN ORDEM_SERVICO os ON p.ORDEM_SERVICO_ID = os.ID
GROUP BY p.DESCRICAO
ORDER BY total_arrecadado DESC;