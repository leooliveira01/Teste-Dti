# Sistema de PetShop🐕🐩

### Intrução para rodar o projeto

- Primeiramente o ideal é clonar o repositório. Para clonar deve seguir os seguintes passos:
   - Copie a URL do repositório.
   - Abra Git Bash.
   - Altere o diretório de trabalho atual para o local em que deseja ter o diretório clonado.
   - Digite git clone e cole a URL já copiada.
   - E por fim Pressione enter para criar seu clone local.
- Após clonar o reposítorio deve rodar o comando com a versão latest do node.
- Rodar o camando npm install e depois rodar o comando npm run dev .
- Para funcionar corretamente o backend precisa ser executado antes, com isso assim que ele for executado, crie um arquivo .env na raiz do projeto do projeto e coloque o endereço da API na variável VITE_API_URL.

### Decisões de Projeto Frontend
- Utilizei o Vite que é uma  ferramenta de construção moderna para projetos React, escolhida por sua facilidade de uso e por ser uma das maneiras mais atualizadas de criar um projeto React. Motivo que considerei para usar essa ferramenta:
   - Tem desempenho superior  em comparação com outras ferramentas de construção React.
- Escolhi a biblioteca Shadcn que utiliza o Tailwind CSS para aumentar a produtividade no desenvolvimento.  Motivos que considerei para usar essa biblioteca:
   - Acelera o desenvolvimento de interfaces de usuário.
   - Ela facilita na ciração de interfaces responsivas.
- Uma outra biblioteca que utilizei foi a Zod, ela é de validação de formulários robusta e fácil de usar que garante a integridade dos dados inseridos pelos usuários. Motivo que considerei para usar ela:
  - Simplifica a validação de formulários complexos.
- E por fim a ultima biblioteca que utilizei foi a Axios ela é uma lib de HTTP cliente leve e popular que facilita a comunicação com o back-end. Motivo que considerei para usar ela:
  - Facilita a comunicação com APIs RESTful

### Decisões de Projeto Frontend 
- Escolhe desenvolver uma API em .NET com C# utilizando o ASP.NET Core 6.0 no Visual Studio demonstra uma visão estratégica e tecnicamente sólida para meu projeto backend. Na minha opnião as vantagens de desevolver em .NET são:
   - Robustez.
   - Confiabilidade.
   - Segura.
- As principais classe que usei no Backend:
- Classe Model
   - A classe model chamada no meu projeto de PetShopModel foi utilizada para declarar as variaveis usada na classe Controller como a Data, qtdgrande e qtdpequenos. Ela também pode ser usada para propriedades e regras de validação 
 - Classe Controller
   - A classe controller chamada de PetShopController no meu projeto foi fundamental para o desenvolvimento do backend nela contém o roteamento e processamento de solicitações HTTP, e nela também foi feita a 
    lógica dos métodos usados para calcular o preço a quantidade de cachorros grandes e pequenos e a data.
- Classe Program
  - E por fim a classe Program é fundamental para a configuração do ambiente de hospedagem, o pipeline de requisição, os serviços e a inicialização da aplicação. É onde a configuração inicial da aplicação é concluída, preparando a API para receber e processar requisições HTTP.

### Teste do Sistemas ✅
- Segue abaixo um print do sistema funcionando.
![image](https://github.com/leooliveira01/Teste-Dti/assets/102445641/c6b6de44-0d6b-443e-9632-c5b97ff6222f)

### Observação 
- Gostaria de compartilhar que durante o desenvolvimento da minha API Encontrei um problema técnico relacionado ao erro de CORS. O erro de CORS se manifestou quando tentei que uma aplicação front-end  acessasse minha API backend Por causa desse erro, o navegador da aplicação front-end, por questões de segurança, bloqueou a solicitação. Para resolver esse problema eu implementei um método na classe Program do backend  minha API pode ser acessada de várias fontes.
- 

   

