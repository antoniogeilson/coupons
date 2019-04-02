#language: pt-BR
Funcionalidade: Cuponagem_Cadastrar Dados do EC
	
@web
Cenario: 1- Validar_Redirecionamento_Tela_Cadastro_do_EC(Via URL)
	Dado que faço o login com EC Sem Cadastro do Estabelecimento
	Quando acesso a tela de Cadastro de Promocao via URL
	Então sou direcionado para a tela de cadastro de EC

@web
Cenario: 2- Validar_Redirecionamento_Tela_Cadastro_do_EC(BotaoCriarPromocao)
	Dado que faço o login com EC Sem Cadastro do Estabelecimento
	Quando pressiono no botão Criar Promoção(EC_Sem_Cadastro)
	Então sou direcionado para a tela de cadastro de EC

@web
Cenario: 3-Cadastro_de_EC_(Validar_Campos_Obrigatórios)
	Dado que faço o login com EC Sem Cadastro do Estabelecimento
	E pressiono no botão Criar Promoção(EC_Sem_Cadastro)
	E sou direcionado para a tela de cadastro de EC
	Quando pressiono no botão Prosseguir
	Então visualizo mensagem de Campos Obrigatórios
		
@web
Esquema do Cenario: 4-Cadastrar_EC(Com_Sucesso)
	Dado visualizo a tela Painel de Promocoes
	E pressiono no botão Criar Promoção(EC_Sem_Cadastro)
	E sou direcionado para a tela de cadastro de EC
	E preencho os dados do Estabelecimento <nomeFantasia>, <cep>, <numero>, <complemento>, <tipoEstabelecimento>, <tipoCozinha>
	E pressiono no botão Prosseguir
	E preencho os dados da Promocao (Valor) <valor>
	E pressiono botão Proximo Passo (Promocao)
	E visualizo dados para confirmacao <nomeFantasia>, <tipoEstabelecimento>, <tipoCozinha>
	Quando pressiono botão Criar Promocao
	Então visualizo a Mensagem de Confirmacao
	Exemplos:
	| nomeFantasia | cep      | numero | complemento | tipoEstabelecimento | tipoCozinha | valor |
	| ABC          | 01010001 | 123    | bloco b     | Lanches             | Vegetariano | 19    |
		
@web
Cenario: 5-Confirmar_Cadastro_de_EC
	Dado que faço o login com EC Com Cadastro do Estabelecimento
	Quando pressiono no botão Criar Promoção
	Então visualizo a tela Criar Promocao - Dados da Promocao

@web
Esquema do Cenario: 6-Cadastrar_EC_(CEP_Regional)
	Dado visualizo a tela Painel de Promocoes
	E pressiono no botão Criar Promoção(EC_Sem_Cadastro)
	E sou direcionado para a tela de cadastro de EC
	E preencho os dados do Estabelecimento. Com CEP Unico <nomeFantasia>, <cep>, <endereco>, <numero>, <bairro> , <tipoEstabelecimento>, <tipoCozinha>
	E pressiono no botão Prosseguir
	E preencho os dados da Promocao (Valor) <valor>
	E pressiono botão Proximo Passo (Promocao)
	E visualizo dados para confirmacao <nomeFantasia>, <tipoEstabelecimento>, <tipoCozinha>
	Quando pressiono botão Criar Promocao
	Então visualizo a Mensagem de Confirmacao
	Exemplos:
	| nomeFantasia       | cep      | endereco         | numero | bairro | tipoEstabelecimento | tipoCozinha | valor |
	| Comercio da Cidade | 62170000 | Rua José Teodoro | 71     | Centro | Food Truck          | Brasileiro  | 2     |
	
@web
Esquema do Cenario: 7-Cadastrar_EC_(CEP_Invalido)
	Dado visualizo a tela Painel de Promocoes
	E pressiono no botão Criar Promoção(EC_Sem_Cadastro)
	E sou direcionado para a tela de cadastro de EC
	Quando preencho campo CEP com valor inválido <cep>
	Então visualizo a Mensagem de Cep Inválido
	Exemplos:
	| cep      |
	| 99999999 |
