explain SELECT * FROM blutel.endereco where rua = 'Rua XV de Novembro';

/*

Resultado antes da criação do index:

id | select_type | table    | partitions | type | possible_keys | key  | key_len | ref   | rows | filtered | Extra       |
1  | SIMPLE      | endereco | NULL       | ALL  | NULL          | NULL | NULL    | NULL  | 100  | 10.00    | Using where |

*/

create index rua_nome_idx on blutel.endereco(rua);
explain SELECT * FROM blutel.endereco where rua = 'Rua XV de Novembro';

/*

Resultado depois da criação do index:

id | select_type | table    | partitions | type | possible_keys | key          | key_len | ref   | rows | filtered | Extra |
1  | SIMPLE      | endereco | NULL       | ref  | rua_nome_idx  | rua_nome_idx | 1023    | const | 10   | 100.00   | NULL  |

*/

/*

Comparando os dados de resposta, percebe-se que a consulta consultou 10x menos dados, ou seja, foi 10x mais rápida.

*/ 