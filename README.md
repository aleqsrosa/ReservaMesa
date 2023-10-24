# ReservaMesa
 FIAP - Tech Challenge 

# ReservaMesa
strongly-typed id

Domínio – Restaurante, servir comida e experiências para o cliente.
Subdomínio principal – fazer comida
Subdomínio de Suporte – Cozinha, operacional (garçom, estacionamento)
Subdomínio genérico – Tecnologia, RH, Marketing, financeiro

Linguagem ubíqua – cliente, 
----------------------------------------------------------------------

Funcionalidades
- cadastro do restaurante
* nome

- cadastro de cliente 
* nome, contato, data de nascimento

- reserva
* quantidade de pessoas
* data e horário da reserva
* quem está reservando
* realizar reserva
* cancelar reserva


Loja (loja representa uma unidade de uma rede de restaurante)
- horario de funcionamento,
- endereço,
- capacidade
- contato

---------------------------------------------------------
- Objeto de valor
* Endereço do restaurante
* Nome completo 

-Entidade
* Loja 
* Cliente
* Reserva
* Mesa
* Rede de resturante


- Loja
---------------------------------------------------------
Regras de negócio
- editar reserva no máximo 24h de antecedencia (alterar reserva) DAVI
<!-- - será permitido selecionar uma quantidade maior do que a mesa de maior capacidade do restaurante,   considerando que exista disponibilidade na capacidade  -->
- verificar se a quantidade de pessoas na reserva execede a capacidade do máxima e disponível da loja para aquele dia. FILLIPE
- máximo de lugares por reserva de 10 FILLIPE
- seleciona mesa disponível, data e hora da reserva OK
- edição somente poderá ser feita no restaurante selecionado previamente OK
- Lista de espera, cliente pode se cadastrar na fila de espera e caso exista disponiblidade ele seja notificado  (extra)
- permanência da reserva (extra)

---------------------------------------------------------
* Para fazer
- Ajustar controllers 
    -- correção url. ex(cliente) OK

- Testar todos os fluxos 
    -- teste geral da api,

- documentação PEDRO
    -- README completo

- Regra de negócio 
    -- validar todas as regras

- extra
    -- Fazer as validações a nível de camada de aplicação
    -- Especificar melhor os DTOs na camada de aplicação
    -- Tratar melhos as mensagens de erro
    -- Permitir com que a loja possa alterar a capacidade individual de reserva