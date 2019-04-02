#language: pt-BR
Funcionalidade: Login
	Essa função realiza login
@web
Cenario: Realizar Login
	Dado que estou na tela de Login 
	E preencho o campo CNPJ
	E preencho o campo Senha
	E preencho o campo Captcha
	Quando pressiono botão Avançar
	Então visualizo a tela Home
