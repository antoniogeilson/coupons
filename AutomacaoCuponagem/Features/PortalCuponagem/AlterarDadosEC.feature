#language: pt-BR
Funcionalidade: Cuponagem_Alterar Dados do EC

@web
Cenario: 1- Validar_Acesso_Alteração_do_EC(Via URL)
	Dado que faço o login com EC Com Cadastro do Estabelecimento
	Quando acesso a tela de Alteração de Dados do EC via URL
	Então sou direcionado para a tela de Alteração de Dados Do EC 
	
@web
Cenario: 2- Validar_Acesso_Alteração_do_EC(Via Botão)
	Dado que faço o login com EC Com Cadastro do Estabelecimento
	Quando acesso a tela de Alteração de Dados do EC via Botão
	Então sou direcionado para a tela de Alteração de Dados Do EC 
		
@web
Cenario: 3- Validar_Redirecionamento_Tela_Cadastro_do_EC(Via URL)
	Dado que faço o login com EC Sem Cadastro do Estabelecimento
	Quando acesso a tela de Alteração de Dados do EC via URL
	Então sou direcionado para a tela de cadastro de EC
	
@web
Cenario: 4- Validar_Redirecionamento_Tela_Alteração_do_EC(Via URL)
	Dado que faço o login com EC Com Cadastro do Estabelecimento
	Quando acesso a tela de Cadastro de Dados do EC via URL
	Então sou direcionado para a tela de Alteração de Dados Do EC 

#//Verificar Com TW pois os campos não estão sendo limpos	
@web
Cenario: 5-Alterar_Dados_do_EC(Validar_Campos_Obrigatórios)
	Dado que faço o login com EC Com Cadastro do Estabelecimento
	E acesso a tela de Alteração de Dados do EC via URL
	E sou direcionado para a tela de Alteração de Dados Do EC 
	E limpo os campos obrigatórios
	Quando pressiono botão Salvar
	Então visualizo mensagem de Campos Obrigatórios (Tela de Alteração)
	
@web
Cenario: 6-Alterar_Dados_EC(Mensagem_Confirmação)
	Dado que faço o login com EC Com Cadastro do Estabelecimento
	E acesso a tela de Alteração de Dados do EC via URL
	E atualizo os dados do Estabelecimento
	Quando pressiono botão Salvar
	Então visualizo a Mensagem de Confirmacao (Alteração EC)
	
#//Verificar Com TW pois o script não pega os valores dos campos
@web
Cenario: 7-Alterar_Dados_EC(Alteração_Com_Sucesso)
	Dado que faço o login com EC Com Cadastro do Estabelecimento
	E acesso a tela de Alteração de Dados do EC via URL
	E atualizo os dados do Estabelecimento
	E pressiono botão Salvar
	Quando acesso a tela de Alteração de Dados do EC via URL
	Então visualizo dados do EC Alterados
