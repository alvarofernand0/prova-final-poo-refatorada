# Sistema de Streaming

## Objetivo 🎧

Desenvolver um sistema de backend para uma plataforma de streaming (semelhante ao Spotify/Netflix) que gerencie diferentes tipos de conteúdo, aplique regras de negócio para reprodução e gere relatórios.

## Contexto

A plataforma deve suportar **Filmes**, **Músicas** e **Podcasts**. Todos possuem características em comum (como Título, Ano, Avaliação) e uma duração. No entanto, cada um se comporta de maneira diferente ao ser reproduzido.

---

## 🛠️ Requisitos de Negócio (O que o sistema deve fazer)

Cabe a você definir a melhor modelagem (Classes, Interfaces, Structs, etc.) para atender aos requisitos abaixo.

### 1. Modelagem Eficiente de Dados

- O sistema precisa gerenciar filmes, músicas e podcasts de forma unificada, mas respeitando suas particularidades.
- A **Duração** do conteúdo deve ser tratada como um dado leve e imutável, contendo minutos e segundos. Justifique sua escolha de tipo (Valor ou Referência) para este dado.
- **Filmes** possuem Diretor e Gênero.
- **Músicas** possuem Artista e Álbum.
- **Podcasts** possuem Host e Número do Episódio.

### 2. Comportamento de Reprodução

- O sistema deve garantir que **qualquer** tipo de conteúdo possa ser reproduzido e pausado.
- Embora a ação seja a mesma ("Reproduzir"), a implementação real varia:
    - Ao reproduzir um **Filme**, deve-se exibir o diretor na saída.
    - Ao reproduzir uma **Música**, deve-se exibir o artista.
    - Podcasts seguem o padrão básico mas exibem o Host.

### 3. Validação e Segurança

- O sistema deve impedir que conteúdos sejam reproduzidos por usuários cujas idades sejam menores que as classificações indicativas presentes nos conteúdos.
- Caso essa regra seja violada, o fluxo além de "impedir" a reprodução do conteúdo, ele deve disparar uma notificação de negócio específica que obrigatoriamente deve ser tratada por quem chamou o método.

### 4. Gerenciamento de Coleções (Playlists)

- O sistema precisa de uma estrutura de **Playlist** flexível.
- Essa playlist deve ser capaz de armazenar **apenas** tipos derivados de Conteúdo, mas deve ser genérica o suficiente para não precisar ser reescrita para cada novo tipo.
- Deve permitir adicionar, remover e listar itens.

### 5. Relatórios Inteligentes

O setor de dados solicitou as seguintes extrações (utilize **LINQ com Sintaxe de Método** (Lambda Expressions) para isso):

1.  Listar todos os conteúdos de um gênero específico (ex: "Drama" ou "Rock"), resolvendo as diferenças de propriedades entre os tipos se necessário.
2.  Listar conteúdos ordenados pelo ano (do mais novo para o mais antigo).
3.  Gerar uma projeção de dados contendo apenas o Nome do conteúdo e uma string formatada "Info: [Ano]".
4.  Agrupar os conteúdos pelo Ano de Lançamento.

