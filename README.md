# CEIF
> O CEIF (Controle ao Estacionamento do Instituto Federal) é um sistema de cadastro e controle para veículos que utilizam o estacionamento do Instituto Federal Câmpus Cubatão, desenvolvido por alunos do curso ADS.

## Proposta
O propósito desse projeto é oferecer um sistema simples, eficiente e intuitivo para o controle e gerenciamento dos veículos que utilizam o estacionamento do Instituto Federal em sua rotina diária. O sistema contempla duas interfaces principais: uma para os administradores, que serão responsáveis pela gestão dos veículos cadastrados e das permissões de acesso ao estacionamento; e outra voltada para os usuários finais, proporcionando uma experiência simplificada para o seu cadastro e a busca de suas informações dentro do próprio sistema.
A interface destinada aos usuários foi projetada para garantir uma experiência intuitiva e simplificada durante o processo de cadastro. Além disso, ao adentrarem o campus, os funcionários terão a opção de validar o acesso dos veículos através dessa interface, o que proporciona uma camada adicional de segurança ao ambiente. Essa funcionalidade simplifica o fluxo de entrada e oferece uma verificação adicional quando necessária, aprimorando ainda mais a segurança do câmpus. Para os administradores, o sistema oferece uma ampla gama de funcionalidades que simplificam o controle e a gestão do estacionamento. Sua interface disponibiliza ferramentas completas para o gerenciamento eficiente dos cadastros de veículos e usuários, garantindo uma administração precisa e abrangente.
Em suma, este sistema visa simplificar o controle de acesso ao estacionamento e oferecer uma solução moderna e eficaz para o gerenciamento de veículos de alunos e profissionais do Instituto Federal, promovendo uma gestão mais organizada e segura do espaço destinado aos veículos.

## Arquitetura do Projeto
O projeto de controle de acesso ao estacionamento do Instituto Federal foi estruturado com base na arquitetura Model-View-Controller (MVC), adotando uma abordagem modular que separa as principais funcionalidades do sistema em três camadas distintas. 
A camada __Model__ gerencia e manipula os dados do sistema, incluindo o cadastro de usuários e veículos, interagindo com o banco de dados. A camada **View** é responsável por apresentar as informações aos usuários de forma compreensível e interativa, abrangendo interfaces para cadastro, administração e autenticação. E a camada **Controller** atua como intermediário, gerenciando as interações do usuário, processando as requisições e manipulando os dados entre a camada Model e a View. O maior benefício da implementação do MVC é a clara separação de responsabilidades entre as camadas, facilitando a manutenção, expansão e organização do código.

Demonstração de como a arquitetura MVC funciona ([fonte da imagem](https://medium.com/@joespinelli_6190/mvc-model-view-controller-ef878e2fd6f5)).

![](/imgs/Screenshot_0.png "img0")


Nas próximas seções, explicaremos algumas partes do código em seções específicas, demonstrando como as camadas do modelo MVC se integram e interagem entre si e entender diferentes componentes da arquitetura do projeto.

### Front-end
O ***front-end*** de um sistema é a interface com a qual o usuário interage diretamente. É a parte do sistema que o usuário vê, interage e utiliza para realizar operações. No projeto, ele engloba as páginas web utilizadas pelos usuários para realizar operações como cadastro e visualização de informações relevantes. Componentes do front-end incluem a estrutura de HTML para o layout, estilos CSS para a apresentação visual e JavaScript para interatividade e dinamismo.
O frontend do sistema de controle de acesso ao estacionamento do Instituto Federal foi desenvolvido com foco na facilidade de uso e na eficiência da interação do usuário. O painel dos usuários oferece uma interface intuitiva, apresentando as opções: 'Já Possuo Cadastro', que direciona para a busca de cadastros existentes no sistema, permitindo aos usuários localizar suas informações, e 'Não Possuo Cadastro', que inicia o processo de criação de um novo cadastro. Além disso, a tela principal do sistema oferece uma visão clara e direta das funcionalidades disponíveis, facilitando o acesso às diferentes seções do sistema, como o painel do administrador. Este último proporciona ferramentas aos administradores do sistema para gerenciar e controlar os cadastros dos usuários. Uma das funcionalidades-chave é a busca de cadastros, que permite aos administradores pesquisar informações dos usuários cadastrados, como nome, CNH, telefone e outras informações relevantes.

**Imagens do sistema:**

![Página home do projeto.](/imgs/Screenshot_1.png "img1")

![Página sobre do projeto.](/imgs/Screenshot_7.png "img7")

![Verificação dos administradores.](/imgs/Screenshot_2.png "img2")

![Painel de controle dos administradores.](/imgs/Screenshot_3.png "img3")

![Edição de cadastros.](/imgs/Screenshot_4.png "img4")

![Exclusão de cadastros.](/imgs/Screenshot_5.png "img5")

![Cadastro dos veículos.](/imgs/Screenshot_6.png "img6")

![Painel dos usuários.](/imgs/Screenshot_8.png "img8")

![Pesquisa dos cadastros.](/imgs/Screenshot_9.png "img9")


### Back-end
Resumidamente, o ***back-end*** de um sistema é a parte responsável pela lógica e processamento dos dados que não são visíveis para os usuários finais. No contexto do nosso projeto, ele desempenha o papel de gerenciamento dos dados, na lógica de negócios e nas interações com o banco de dados. Ele é responsável por receber solicitações do front-end, processar essas requisições, realizar validações, acessar o banco de dados e enviar respostas de volta ao front-end.
No contexto deste projeto, a utilização de diferentes pacotes provenientes da biblioteca Entity Framework Core é essencial para garantir a interação adequada com o banco de dados e a manipulação eficiente dos dados do sistema:
* **Microsoft.EntityFrameworkCore**: Este é o pacote principal do Entity Framework Core. Ele fornece os recursos fundamentais para mapeamento objeto-relacional, operações de consulta e atualização de dados em um banco de dados.

* **Microsoft.EntityFrameworkCore.Design**: Este pacote oferece ferramentas de design e scaffolding para ajudar no desenvolvimento do EF Core. Contém comandos de linha de comando para geração de código e migrações.

* **Microsoft.EntityFrameworkCore.Relational**: Este pacote contém funcionalidades básicas do EF Core que são comuns a todos os bancos de dados relacionais suportados. Ele fornece recursos de nível mais baixo para interação com o banco de dados.

* **Microsoft.EntityFrameworkCore.SqlServer**: É específico para SQL Server e oferece suporte adicional para recursos e funcionalidades específicas desse banco de dados quando usado em conjunto com o EF Core.

* **Microsoft.EntityFrameworkCore.Tools**: Contém ferramentas adicionais para migrações de banco de dados e interações com bancos de dados durante o desenvolvimento. Ele fornece comandos de scaffolding e migração para auxiliar no gerenciamento das alterações no esquema do banco de dados ao longo do tempo.

Os arquivos [Alunos.cs](RegistroCarrosdosAlunosIF/Controllers/Alunos.cs) e [Cadastros.cs](\RegistroCarrosdosAlunosIF/Controllers/Cadastros.cs) são controladores cruciais para o sistema de cadastro de alunos. Ambos gerenciam ações relacionadas aos cadastros, como visualização, criação, edição e exclusão. No Alunos.cs, há métodos para direcionar para diferentes páginas, como a página inicial, a exibição de dados de cadastros e a criação de novos cadastros. Já o Cadastros.cs possui funcionalidades mais amplas, incluindo a listagem de todos os cadastros, edição, exclusão, e ações relacionadas à administração, como confirmação de acesso administrativo. Ambos os controladores interagem com a interface de repositório de cadastros para manipulação de dados no banco, realizando operações de acordo com as requisições dos usuários.


[CadastrosRepositorio.cs](RegistroCarrosdosAlunosIF/Repositorio/CadastrosRepositorio.cs) é um componente essencial que atua como um repositório para interação com o banco de dados no contexto do sistema de cadastro de alunos do Instituto Federal. Este arquivo contém a classe que implementa interface ICadastrosRepositorio. Aqui, são definidos métodos para realizar operações CRUD (Create, Read, Update, Delete) no banco de dados. Por exemplo, métodos como Adicionar, BuscarTodos, BuscarDados, Alterar e Apagar são responsáveis por adicionar novos cadastros, buscar todos os cadastros existentes, buscar dados de um cadastro específico, atualizar e excluir cadastros. A utilização do contexto do banco de dados _bancoContext é usada para realizar essas operações de banco de dados utilizando Entity Framework Core. Além disso, há a implementação de métodos como AutoAtt, responsável por atualizar automaticamente os dados do cadastro, e CarregarUltimo, que carrega o último cadastro registrado no banco.


Como mencionado acima, o arquivo [ICadastrosRepositorio.cs](RegistroCarrosdosAlunosIF/Repositorio/ICadastrosRepositorio.cs) define a interface que descreve os métodos que devem ser implementados pelo repositório de cadastros. Essa interface contém definições abstratas dos métodos de operações CRUD mencionados anteriormente, como Apagar, AutoAtt, CarregarUltimo, BuscarDados, BuscarTodos, Adicionar e Alterar. Essa estrutura de interface permite a padronização dos métodos que devem ser implementados pelo repositório de cadastros, garantindo coesão e facilitando a manutenção do código.


Os modelos [CadastroModels.cs](RegistroCarrosdosAlunosIF/Models/CadastrosModel.cs) e [ErrorViewModels.cs](RegistroCarrosdosAlunosIF/Models/ErrorViewModel.cs) definem a estrutura dos dados para os cadastros de alunos e para a exibição de erros no sistema, respectivamente. CadastroModels.cs especifica os campos necessários para o cadastro, como Prontuário, Nome, CNH, Email, entre outros, incluindo validações como obrigatoriedade e formato dos dados. Por outro lado, ErrorViewModels.cs é responsável por exibir informações úteis em caso de ocorrência de erros no sistema, como a identificação única da requisição e se o identificador da requisição está visível.


Essas seções de código e modelos oferecem uma visão geral do funcionamento do projeto, mas para melhor entendimento, é recomendado observar o sistema em funcionamento, interagindo com as diferentes funcionalidades para compreender melhor o fluxo de dados, a lógica de negócios e a interação entre os componentes do backend.

## Manual dos Usuários

**Acesse a página principal e clique na opção "Não possuo cadastro":**

![](/imgs/Screenshot_10.png "img10")

**Preencha os campos com seus dados:**

![](/imgs/Screenshot_11.png "img11")

**Pronto, você foi cadastrado com sucesso! Para acessar seu cadastro, basta ir na opção "Buscar Cadastro" e digitar sua matrícula.**

![](/imgs/Screenshot_12.png "img12")
![](/imgs/Screenshot_13.png "img13")

Este projeto foi realizado pelos alunos: Bruno Souza CB3025411;
 Gabriel Afonso CB3026167;
 Gabriel Ribeiro CB3021726;
 Luan dos Santos CB3025977;
 Pedro Perpétuo CB3021688.
