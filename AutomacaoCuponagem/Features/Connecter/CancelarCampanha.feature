#language: pt-BR
Funcionalidade: Connecter_Cancelar Campanha

@web
Esquema do Cenario: 1-Cancelar_Campanha - Botão Voltar

	Dado visualizo a tela Painel de Campanhas
	E crio uma Campanha para Cancelamento <nomeFantasia>, <cnpjCentral>, <tipoRestaurante>, <tipoCozinha>, <tipoPromocao>, <valorPromocao>
	E visualizo uma Campanha Ativa <nomeFantasia>, <valorPromocao>
	E acesso Detalhe da Campanha
	E visualizo os Detalhes da Campanha <nomeFantasia>
	E pressiono Botao Cancelar Campanha
	E visualizo Mensagem de Confirmacao de Cancelamento de Campanha
	Quando pressiono Botao Voltar(Campanha)
	Então visualizo os Detalhes da Campanha
	E visualizo Detalhe da Campanha Ativa
Exemplos: 
	| nomeFantasia    | cnpjCentral    | tipoRestaurante | tipoCozinha | tipoPromocao | valorPromocao |
	| Restaurante XYZ | 10541663000177 | Lanches         | Brasileiro  | Percentual   | 11            |

@web
Esquema do Cenario: 1-Cancelar_Campanha
	Dado visualizo a tela Painel de Campanhas
	E crio uma Campanha para Cancelamento <nomeFantasia>, <cnpjCentral>, <tipoRestaurante>, <tipoCozinha>, <tipoPromocao>, <valorPromocao>
	E visualizo uma Campanha Ativa <nomeFantasia>, <valorPromocao>
	E acesso Detalhe da Campanha
	E visualizo os Detalhes da Campanha <nomeFantasia>
	E pressiono Botao Cancelar Campanha
	E visualizo Mensagem de Confirmacao de Cancelamento de Campanha
	Quando pressiono Botao Confirmar(Campanha)
	Então Mensagem de Cancelamento de Campanha Com Sucesso
	E visualizo Detalhe da Campanha Cancelada
Exemplos: 
	| nomeFantasia    | cnpjCentral    | tipoRestaurante | tipoCozinha | tipoPromocao | valorPromocao |
	| Restaurante XYZ | 10541663000177 | Lanches         | Brasileiro  | Percentual   | 11            |

