#language: pt-BR
Funcionalidade: Cuponagem_Cancelar Promoção

@web
Esquema do Cenario: 1-Cancelar_Promocao - Botão Voltar
	Dado visualizo a tela Painel de Promocoes Com EC Cadastrado
	E visualizo uma Promocao Ativa <percentual>
	E acesso Detalhe da Promocao
	E visualizo os Detalhes da Promocao
	E pressiono Botao Cancelar Promocao
	E visualizo Mensagem de Confirmacao de Cancelamento
	Quando pressiono Botao Voltar(Confirmacao)
	Então visualizo os Detalhes da Promocao
	E visualizo Promocao com Status Ativa
Exemplos: 
	| percentual |
	|    15      |
	
@web
Esquema do Cenario: 2-Cancelar_Promocao
	Dado visualizo a tela Painel de Promocoes Com EC Cadastrado
	E visualizo uma Promocao Ativa <percentual>
	E acesso Detalhe da Promocao
	E visualizo os Detalhes da Promocao
	E pressiono Botao Cancelar Promocao
	E visualizo Mensagem de Confirmacao de Cancelamento
	Quando pressiono Botao Cancelar Promocao (Confirmacao)
	Então visualizo Mensagem de Confirmação
	E visualizo Promocao com Status Cancelada
	Exemplos: 
	| percentual |
	|    15      |
