# Cronômetro e Pomodoro em C#

Este projeto é um cronômetro simples e uma ferramenta de Pomodoro implementada em C#. Ele permite que os usuários contem o tempo em segundos, minutos ou horas, além de oferecer uma contagem regressiva e um modo Pomodoro para gerenciamento de tempo.

## Funcionalidades

- **Cronômetro**: Contagem progressiva de tempo em segundos, minutos ou horas.
- **Contagem Regressiva**: Contagem regressiva de tempo a partir de um valor especificado.
- **Modo Pomodoro**: Ciclos de 25 minutos de trabalho e 5 minutos de descanso, repetidos 4 vezes.
- **Interface de Linha de Comando (CLI)**: Interface simples e intuitiva para interação com o usuário.

## Como Funciona

O programa começa exibindo um menu com as opções disponíveis. O usuário pode escolher entre:

- **Segundos (s)**: Contagem de tempo em segundos (ex: `10s`).
- **Minutos (m)**: Contagem de tempo em minutos (ex: `5m`).
- **Horas (h)**: Contagem de tempo em horas (ex: `2h`).
- **Contagem Regressiva (r)**: Contagem regressiva a partir de um valor especificado (ex: `10r`).
- **Pomodoro (p)**: Inicia um ciclo de Pomodoro com 25 minutos de trabalho e 5 minutos de descanso.
- **Sair (0)**: Encerra o programa.

## Exemplo de Uso

Aqui está um exemplo de como usar o programa:
```
Opções:
S = Segundos => 10s = 10 segundos
M = Minuto => 1m = 1 minuto
H = Hora => 1h = 1 hora
R = Contagem Regressiva => 10r = 10 segundos regressivos
P = Pomodoro (25 min trabalho, 5 min descanso)
0 = Sair
Quanto tempo deseja contar? 10s

Preparar...
Apontar...
Agora!!!

Tempo decorrido: 0 segundos
[--------------------]

Tempo decorrido: 1 segundos
[#-------------------]

...

Tempo decorrido: 10 segundos
[####################]

Cronômetro finalizado!
```

### Modo Pomodoro

```
Opções:
S = Segundos => 10s = 10 segundos
M = Minuto => 1m = 1 minuto
H = Hora => 1h = 1 hora
R = Contagem Regressiva => 10r = 10 segundos regressivos
P = Pomodoro (25 min trabalho, 5 min descanso)
0 = Sair
Quanto tempo deseja contar? p

🍅 Pomodoro 1 - Foco! (25 min)
Preparar...
Apontar...
Agora!!!

Tempo restante: 1500 segundos
[####################]

...

Tempo restante: 0 segundos
[--------------------]

☕ Hora do descanso! (5 min)
Preparar...
Apontar...
Agora!!!

Tempo restante: 300 segundos
[####################]
```
...

🎉 Parabéns! Você concluiu um ciclo completo de Pomodoro!


## Como Executar

1. Clone o repositório para sua máquina local.
2. Abra o projeto em um ambiente de desenvolvimento compatível com C# (ex: Visual Studio).
3. Compile e execute o projeto.

## Requisitos

- .NET SDK instalado.
- Ambiente de desenvolvimento compatível com C# (opcional, mas recomendado).

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou pull requests para melhorar o projeto.

## Licença

Este projeto está licenciado sob a licença MIT. Consulte o arquivo `LICENSE` para mais detalhes.
