#language: pt-BR
Funcionalidade: Cuponagem_LoginCuponagem
	Realizar Login no Ambiente de Testes

@web
Cenario: 1- Realizar_Login_Cuponagem
	Dado que estou na tela de Login Cuponagem Fake
	E preencho os campos CNPJ e Token
	Quando pressiono botão Entrar
	Então visualizo a tela Painel de Promocoes
