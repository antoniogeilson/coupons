#language: pt-BR
Funcionalidade: Connecter_LoginConnecter
	Realizar Login no Ambiente de Desenvolvimento do Connecter

@web
Cenario: 1- Realizar_Login_Connecter
	Dado que estou na tela de Login do Connecter
	E preencho os campos Usuario e Senha(Connecter)
	Quando pressiono botão Entrar(Connecter)
	Então visualizo a tela Painel de Campanhas