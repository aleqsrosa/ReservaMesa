# Nome Projeto:

Projeto Gestão de Reservas de Mesas de Redes de Restaurantes.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

# Descrição do projeto:
  
Projeto desenvolvido pelo grupo de estudos da Pós Tech FIAP do curso: Arquitetura de Sistemas .NET com Azure. Trata-se de um sistema que possui a finalidade de gerenciar e otimizar o processo de reservas de mesas de uma rede de restaurantes. Portanto, o responsável pela rede/restaurante, realizará o seu cadastro na aplicação, no qual poderá disponibilizar a capacidade da loja para a realização das reservas.<br>
Uma vez que a loja estiver cadastrada, o cliente poderá reservar mesas para uma data específica naquela loja.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

# Participantes do projeto:
  
- [Alex dos Santos Rosa](https://github.com/aleqsrosa); 
-	[Davi Emanuel Torres de Souza Nogueira](https://github.com/daviEmanuelNogueira);
-	[Fillipe Luis da Silva](https://github.com/fillipelsilva);
-	[Pedro Henrique Sousa de Abreu](https://github.com/PedroAbreuHS).

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

# Requisitos Funcionais:
  
-	Possuir lista de lojas disponíveis por rede;
-	Apresentar a listagem de mesas disponíveis para reservas conforme a loja escolhida;
-	Ter API para reservar as mesas conforme a loja escolhida, disponibilidade, horário e a capacidade.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

# Critérios de Aceite (Requisitos mínimos – Regras de Negócios):

-	Ajustes e edições de reserva só serão permitidos com mais de 24 horas de antecedência;
-	Ajustes e edições de reserva só serão permitidos no restaurante, previamente, selecionado;
-	Possível selecionar apenas as mesas disponíveis, não reservadas, contendo data e turno da reserva;
-	Mesas com capacidade máxima de dez lugares;
-	Será possível selecionar uma quantidade maior de lugares, uma mesa possui cinco lugares, considerando que exista disponibilidade na capacidade do restaurante (o restaurante poderá ajustar mesas, juntando e etc...);
-	Máximo de lugares por reserva.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

# Desenvolvimento (Como rodar):
  
Para executar esses projetos você precisa seguir as etapas abaixo:
-	Acessar o repositório do projeto através do link: https://github.com/aleqsrosa/ReservaMesa/tree/main;
-	Baixar o zip do projeto ou fazer um fork do mesmo;
-	Execute o projeto de API;
-	Seguir o seguinte fluxo: cadastrar uma rede de restaurantes, cadastrar uma loja, cadastrar um cliente, assim conseguirá registrar uma reserva;
-	Fazer as chamadas REST através do Swagger que será iniciado juntamente com a aplicação.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

# Banco de dados:
  
Este projeto está usando SQL Server, você pode usar uma instância que instalou em seu desktop. 
Não será necessário alterar a connection string, pois o projeto foi configurado para utilização de uma instância padrão (local) considerando autenticação do próprio Windows, bastando apenas abrir o package manager console e rodar o comando update-database apontando para o projeto reserva.infra.data.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

# API:
Esta API foi desenvolvida em .NET 7 e é um padrão simples para separar as soluções em algumas camadas. 
Para executar este projeto você pode usar VS Code ou VS 2022.

