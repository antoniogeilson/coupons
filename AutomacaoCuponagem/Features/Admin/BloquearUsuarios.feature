#language: pt-BR
Funcionalidade: Admin_BloquearUsuarios

@web
Esquema do Cenario: 1-Bloquear_Usuario

	Dado visualizo Painel Administrativo - opção Bloqueados
	E bloqueio o cnpj do EC <cnpj>
	Quando acesso Painel de Promoções com usuário bloqueado <cnpj>
	Então visualizo Mensagem de Usuário Bloqueado.
	E o campo Criar Promoção está desabilitado
	
Exemplos: 
	| cnpj           |
	| 12345678908888 |
