# Cronômetro Pomodoro

## Sobre o Projeto
O **Cronômetro Pomodoro** é um aplicativo desenvolvido em C# que simula a técnica de produtividade Pomodoro. A técnica Pomodoro consiste em períodos de trabalho focado seguidos por curtos intervalos de descanso. Esse cronômetro ajuda a gerenciar e otimizar o tempo de trabalho e descanso, aumentando a produtividade e melhorando o foco durante as tarefas.

### Funcionalidades

- **Contagem de tempo**: Permite contar um tempo específico para atividades variadas.
- **Contagem regressiva**: Realiza uma contagem regressiva para um determinado tempo.
- **Técnica Pomodoro**: Executa ciclos de 25 minutos de trabalho seguidos de 5 minutos de descanso, repetindo o ciclo.
- **Exibição visual**: Utiliza barras de progresso para exibir o tempo restante em tempo real.
- **Modo de pausa e reinício**: A qualquer momento, você pode pausar e reiniciar a contagem do cronômetro.

## Tecnologias Utilizadas

- **Linguagem**: C#
- **Plataforma**: .NET Console Application
- **Funcionalidade**: Contagem de tempo, contagem regressiva, e interface simples de usuário para interatividade.

## Exemplo de Uso

Cronômetro Pomodoro - Bem Vindo!
================================
1-Contagem de tempo
2-Contagem regressiva
3-Técnica Pomodoro (25m de trabalho + 5m de descanso)
4-Sair
Escolha uma opção: 1

Quanto tempo deseja contar? 10m

Iniciando cronômetro para 10 minutos...
Tempo restante: 10m 00s
[####################]
Tempo restante: 9m 59s
[################### ]
Tempo restante: 9m 58s
[################### ]
...
Tempo restante: 00m 01s
[                 -]
Aperte enter para continuar.

================================
Escolha uma opção: 2

Quanto tempo deseja contar? 10r

Iniciando contagem regressiva de 10 segundos...
Tempo restante: 10s
[####################]
Tempo restante: 9s
[################### ]
Tempo restante: 8s
[##################  ]
...
Tempo restante: 1s
[                 -]
Contagem finalizada! Aperte enter para continuar.

================================
Escolha uma opção: 3

Iniciando ciclo Pomodoro... (25 minutos de trabalho + 5 minutos de descanso)
Trabalho - 25 minutos
Tempo restante: 25m 00s
[####################]
Tempo restante: 24m 59s
[################### ]
Tempo restante: 24m 58s
[################### ]
...
Tempo restante: 00m 01s
[                 -]

Hora do descanso! (5 minutos)
Tempo restante: 5m 00s
[####################]
Tempo restante: 4m 59s
[################### ]
Tempo restante: 4m 58s
[################### ]
...
Tempo restante: 00m 01s
[                 -]

Ciclo concluído! Aperte enter para iniciar novamente ou 0 para sair.


## Como Usar

1. Clone o repositório ou faça o download do código fonte.
2. Compile e execute o programa em um ambiente que suporte C# (como o Visual Studio ou Visual Studio Code).
3. No menu principal, escolha uma das opções: 
    - **Contagem de tempo**: para contar um tempo definido de sua escolha.
    - **Contagem regressiva**: para contar regressivamente a partir de um tempo específico.
    - **Técnica Pomodoro**: para iniciar o ciclo Pomodoro com 25 minutos de trabalho seguidos por 5 minutos de descanso.
4. Acompanhe o progresso através da barra de tempo e os minutos restantes.
5. Quando o tempo acabar, a opção para iniciar novamente estará disponível.

## Melhorias Futuras
- Implementação de um contador de ciclos Pomodoro para exibir quantos ciclos de trabalho e descanso foram completados.
- Opção de personalizar os tempos de trabalho e descanso.
- Salvar o histórico de uso em arquivos ou banco de dados.
- Interface gráfica (GUI) para uma melhor experiência do usuário.
- Notificações de alerta sonoras ou visuais no final de cada ciclo de trabalho e descanso.
