#language: pt-BR
Funcionalidade: Cuponagem_Cadastrar Promoção

@web
Esquema do Cenario: 1-Criar_Promocao-Porcentagem
	Dado visualizo a tela Painel de Promocoes Com EC Cadastrado
	E pressiono no botão Criar Promoção
	E preencho os dados da Promocao (Porcentagem) <percentual>
	E pressiono botão Proximo Passo (Promocao)
	E visualizo tela para confirmacao(Porcentagem) <percentual>
	Quando pressiono botão Criar Promocao
	Então visualizo a Mensagem de Confirmacao
	E Cupom de Porcentagem Criado(Porcentagem) <percentual>
	Exemplos: 
	| percentual |
	|    15      |
	
@web
Esquema do Cenario: 2-Criar_Promocao-Valor
	Dado visualizo a tela Painel de Promocoes Com EC Cadastrado
	E pressiono no botão Criar Promoção
	E preencho os dados da Promocao (Valor) <valor>
	E pressiono botão Proximo Passo (Promocao)
	E visualizo tela para confirmacao(Valor) <valor>
	Quando pressiono botão Criar Promocao
	Então visualizo a Mensagem de Confirmacao
	E Cupom de Valor Criado(Valor) <valor>
	Exemplos:
	| valor |
	| 19    |
		
@web
Esquema do Cenario: 3-Criar_Promocao-Brinde
	Dado visualizo a tela Painel de Promocoes Com EC Cadastrado
	E pressiono no botão Criar Promoção
	E preencho os dados da Promocao (Brinde) <brinde>
	E pressiono botão Proximo Passo (Promocao)
	E visualizo tela para confirmacao(Brinde) <brinde>
	Quando pressiono botão Criar Promocao
	Então visualizo a Mensagem de Confirmacao
	E Cupom de Brinde Criado(Brinde) <brinde>
	Exemplos:
	| brinde |
	| Café   |


