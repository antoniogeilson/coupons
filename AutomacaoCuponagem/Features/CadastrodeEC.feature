#language: pt-BR
Funcionalidade: CadastrodeEC
	
@web
Cenario: Redirecionamento Para Tela de Cadastro (Via URL)
	Dado que faço o login com EC Sem Cadastro
	Quando o EC acessar o cadastro de Promo diretamente (via URL)
	Então o EC é direcionado para o cadastro de EC