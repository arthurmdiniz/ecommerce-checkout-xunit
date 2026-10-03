# Ecommerce Checkout com xUnit

Projeto de exemplo em .NET para praticar testes automatizados com xUnit sobre regras de negócio de checkout e fidelidade.

## Visão geral

Este repositório contém uma classe `PedidoService` responsável por regras de negócio fundamentais de um e-commerce:

- geração de código de rastreio
- cálculo de pontos de fidelidade
- definição de direito a frete grátis

## Estrutura do projeto

- `EcommerceCheckout.App` — biblioteca com a lógica de negócio
- `EcommerceCheckout.Tests` — testes unitários com xUnit

## Métodos implementados

### `GerarCodigoRastreio(string regiao, int numeroPedido)`

Cria um código de rastreio no formato:

```text
REGIAO-0000
```

Exemplo:

```text
SUDESTE-0042
```

Comportamento:

- a região é convertida para maiúsculas
- o número do pedido é formatado com 4 dígitos

### `CalcularPontosFidelidade(int valorTotal)`

Calcula os pontos de fidelidade com base no valor do pedido.

Fórmula:

```text
(valorTotal / 10) * 2
```

Exemplo:

```text
150 -> 30
```

### `TemDireitoAFreteGratis(int valorTotal, bool eClienteVIP)`

Define se o cliente tem direito ao frete grátis.

Regras:

- `true` quando `valorTotal >= 200`
- `true` quando `eClienteVIP == true`
- `false` para cliente comum com valor abaixo de 200

## Cobertura dos testes

A suíte de testes cobre os cenários principais da classe `PedidoService`:

1. `GerarCodigoRastreio_DeveGerarMascaraExata`
   - valida o formato do código de rastreio

2. `CalcularPontosFidelidade_DeveCalcularPontosCorretamente`
   - valida o cálculo de pontos

3. `FreteGratis_DeveSerVerdadeiroParaClienteVipAbaixoDeDuzentosReais`
   - valida o caso VIP abaixo de 200

4. `FreteGratis_DeveSerFalsoParaClienteNaoVipAbaixoDeDuzentosReais`
   - valida o caso não VIP abaixo de 200

## Pré-requisitos

- .NET SDK 10.0 ou superior
- VS Code, terminal PowerShell ou bash

## Executando os testes

Na raiz do projeto, execute:

```bash
dotnet test EcommerceCheckout.Tests/EcommerceCheckout.Tests.csproj --nologo
```

## Resultado esperado

Ao final da execução, o comando deve retornar sucesso com todos os testes aprovados.

Exemplo de resultado esperado:

```text
Resumo do teste: total: 4; falhou: 0; bem-sucedido: 4; ignorado: 0
```

## Observação

Este projeto é um exemplo didático para demonstrar como escrever testes unitários em .NET com xUnit e validar regras de negócio de forma simples e objetiva.

## Sobre o Autor

Ajustado e documentado por **Arthur Marques Diniz**.

*   **GitHub:** [@arthurmdiniz](https://github.com)
*   **LinkedIn:** [arthurmdiniz](https://www.linkedin.com/in/arthurmdiniz/)
*   **E-mail:** arthurmdiniz@outlook.com.br

Sinta-se à vontade para enviar *pull requests*, reportar problemas ou propor melhorias!