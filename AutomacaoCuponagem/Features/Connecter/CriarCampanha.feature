#language: pt-BR
Funcionalidade: Connecter_Criar Campanha Connecter	

@web
Esquema do Cenario: 1-Criar_Promocao_Porcentagem_No_Connecter
	Dado visualizo a tela Tela de Lista de Campanhas No Connecter
	E pressiono no botão Criar Campanha
	E visualizo a tela de Criar Campanha
	E preencho os dados do Solicitante(Porcentagem) <nomeFantasia>, <cnpjCentral>, <tipoRestaurante>, <tipoCozinha>, <tipoPromocao>, <valorPromocao>
	E realizo a importação das Lojas Participantes
	E realizo a importação dos CPFs Impactados
	E realizo a importação da Arte da Promoção
	Quando pressiono botão Confirmar Campanha
	Então visualizo a Mensagem de Confirmacao(Connecter)
	E Cupom de Porcentagem Criado no Connecter <nomeFantasia>, <valorPromocao>
	Exemplos: 
	| nomeFantasia    | cnpjCentral    | tipoRestaurante | tipoCozinha | tipoPromocao | valorPromocao |
	| Restaurante XYZ | 10541663000177 | Lanches         | Brasileiro  | Percentual   | 11            |

@web	
Esquema do Cenario: 2-Criar_Promocao_Valor_No_Connecter
	Dado visualizo a tela Tela de Lista de Campanhas No Connecter
	E pressiono no botão Criar Campanha
	E visualizo a tela de Criar Campanha
	E preencho os dados do Solicitante(Valor) <nomeFantasia>, <cnpjCentral>, <tipoRestaurante>, <tipoCozinha>, <tipoPromocao>, <valorPromocao>
	E realizo a importação das Lojas Participantes
	E realizo a importação dos CPFs Impactados
	E realizo a importação da Arte da Promoção
	Quando pressiono botão Confirmar Campanha
	Então visualizo a Mensagem de Confirmacao(Connecter)
	E Cupom de Desconto - Valor Criado no Connecter <nomeFantasia>, <valorPromocao>
	Exemplos: 
	| nomeFantasia         | cnpjCentral    | tipoRestaurante | tipoCozinha | tipoPromocao | valorPromocao |
	| Restaurante do Pedro | 10541663000188 | Prato Feito     | Nordestino  | Dinheiro     | 22            |

@web	
Esquema do Cenario: 3-Criar_Promocao_Brinde_No_Connecter
	Dado visualizo a tela Tela de Lista de Campanhas No Connecter
	E pressiono no botão Criar Campanha
	E visualizo a tela de Criar Campanha
	E preencho os dados do Solicitante(Brinde) <nomeFantasia>, <cnpjCentral>, <tipoRestaurante>, <tipoCozinha>, <tipoPromocao>
	E realizo a importação das Lojas Participantes
	E realizo a importação dos CPFs Impactados
	E realizo a importação da Arte da Promoção
	Quando pressiono botão Confirmar Campanha
	Então visualizo a Mensagem de Confirmacao(Connecter)
	E Cupom de Brinde Criado no Connecter <nomeFantasia>
	Exemplos: 
	| nomeFantasia       | cnpjCentral    | tipoRestaurante | tipoCozinha | tipoPromocao |
	| Restaurante Azulão | 10541663000188 | Lanches         | Brasileiro  | Brinde       |

@web	
Cenario: 4-Criar_Promocao_Campos_Obrigatorios
	Dado visualizo a tela Tela de Lista de Campanhas No Connecter
	E pressiono no botão Criar Campanha
	E visualizo a tela de Criar Campanha
	E realizo a importação das Lojas Participantes
	E realizo a importação dos CPFs Impactados
	E realizo a importação da Arte da Promoção
	Quando pressiono botão Confirmar Campanha(Desabilidado)
	Então visualizo Campos Dados do Solicitante Sem Preenchimento
