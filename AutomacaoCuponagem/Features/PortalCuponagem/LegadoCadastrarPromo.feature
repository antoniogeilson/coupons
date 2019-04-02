	#language: pt-BR
Funcionalidade: Cuponagem_Legado_Criar_Promo
	Esta Funcionalidade Valida o Cadastro de Promoção - Entrega 1
		
@web
Esquema do Cenario: 1- Cadastro de Promoção - Porcentagem
	Dado que estou na tela de Criar Promoção 
	E preencho os dados do Estabelecimento <nomeFantasia>, <cep>, <numero>, <complemento>, <tipoEtabelecimento>, <tipoCozinha>
	E pressiono botão Proximo Passo (Estabelecimento) 
	E preencho os dados da Promocao (Porcentagem) <percentual>
	E pressiono botão Proximo Passo (Promocao)
	E visualizo dados para confirmacao <nomeFantasia>, <tipoEstabelecimento>, <tipoCozinha>
	Quando pressiono botão Criar Promocao
	Então visualizo a Mensagem de Confirmacao
	Exemplos: 
	| nomeFantasia | cep      | numero | complemento | tipoEstabelecimento | tipoCozinha | percentual |
	| ABC          | 01010001 | 123    | bloco b     | Executivo           | Brasileiro  | 1          |
		
@web
Esquema do Cenario: 2- Cadastro de Promoção - Valor
	Dado que estou na tela de Criar Promoção 
	E preencho os dados do Estabelecimento <nomeFantasia>, <cep>, <numero>, <complemento>, <tipoEtabelecimento>, <tipoCozinha>
	E pressiono botão Proximo Passo (Estabelecimento)
	E preencho os dados da Promocao (Valor) <valor>
	E pressiono botão Proximo Passo (Promocao)
	E visualizo dados para confirmacao <nomeFantasia>, <tipoEstabelecimento>, <tipoCozinha>
	Quando pressiono botão Criar Promocao
	Então visualizo a Mensagem de Confirmacao
	Exemplos: 
	| nomeFantasia | cep      | numero | complemento | tipoEstabelecimento | tipoCozinha | valor |
	| EFC          | 02020020 | 345    | bloco c     | Executivo           | Brasileiro  | 1     |

@web
Esquema do Cenario: 3- Cadastro de Promoção - Brinde
Dado que estou na tela de Criar Promoção 
	E preencho os dados do Estabelecimento <nomeFantasia>, <cep>, <numero>, <complemento>, <tipoEtabelecimento>, <tipoCozinha>
	E pressiono botão Proximo Passo (Estabelecimento)
	E preencho os dados da Promocao (Brinde) <brinde>
	E pressiono botão Proximo Passo (Promocao)
	E visualizo dados para confirmacao <nomeFantasia>, <tipoEstabelecimento>, <tipoCozinha>
	Quando pressiono botão Criar Promocao
	Então visualizo a Mensagem de Confirmacao
	Exemplos: 
	| nomeFantasia | cep      | numero | complemento | tipoEstabelecimento | tipoCozinha | brinde |
	| WYZ          | 03030030 | 679    | bloco J     | Executivo           | Brasileiro  | cafe   |
	