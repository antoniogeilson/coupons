#language: pt-BR
Funcionalidade: Cuponagem_Relançar Promoção

@web
Esquema do Cenario: 1-Relancar_Promo_Botao_Voltar
	Dado visualizo a tela Painel de Promocoes Com EC Cadastrado
	E visualizo uma Promoção(Porcentagem) Expirada <percentual>
	E acesso Detalhe da Promocao
	E visualizo os Detalhes da Promocao Expirada
	E pressiono Botao Relancar Promocao
	E visualizo Mensagem de Confirmacao
	Quando pressiono Botao Voltar(Mensagem)
	Então visualizo os Detalhes da Promocao Expirada
	Exemplos: 
	| percentual |
	|    15      |
		
@web
Esquema do Cenario: 2-Relancar_Promo_Porcentagem
	Dado visualizo a tela Painel de Promocoes Com EC Cadastrado
	E visualizo uma Promoção(Porcentagem) Expirada <percentual>
	E acesso Detalhe da Promocao
	E visualizo os Detalhes da Promocao Expirada
	E pressiono Botao Relancar Promocao
	E visualizo Mensagem de Confirmacao
	Quando pressiono Botao Relancar Promocao (Mensagem)
	Então visualizo Mensagem de Confirmacao
	E visualizo uma Promoção Relancada Ativa
	Exemplos: 
	| percentual |
	|    15      |

@web
Esquema do Cenario: 3-Relancar_Promo_Valor
	Dado visualizo a tela Painel de Promocoes Com EC Cadastrado
	E visualizo uma Promoção(valor) Expirada <valor>
	E acesso Detalhe da Promocao
	E visualizo os Detalhes da Promocao Expirada
	E pressiono Botao Relancar Promocao
	Quando pressiono Botao Relancar Promocao (Mensagem)
	Então visualizo Mensagem de Confirmacao
	E visualizo uma Promoção Relancada Ativa
	Exemplos: 
	| valor |
	| 15,00 |

@web
Esquema do Cenario: 4-Relancar_Promo_Brinde
	Dado visualizo a tela Painel de Promocoes Com EC Cadastrado
	E visualizo uma Promoção(brinde) Expirada <brinde>
	E acesso Detalhe da Promocao
	E visualizo os Detalhes da Promocao Expirada
	E pressiono Botao Relancar Promocao
	Quando pressiono Botao Relancar Promocao (Mensagem)
	Então visualizo Mensagem de Confirmacao
	E visualizo uma Promoção Relancada Ativa
	Exemplos: 
	| brinde       |
	| refrigerante |
		