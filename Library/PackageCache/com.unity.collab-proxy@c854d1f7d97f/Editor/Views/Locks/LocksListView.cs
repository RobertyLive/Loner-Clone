<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@400;600;700&family=Potta+One&display=swap"
        rel="stylesheet">
    <link rel="stylesheet" href="style.css">
    <title>Document</title>
</head>

<body>
    <header>
        <nav>
            <ul class="menu-header">
                <li>JOGO</li>
                <li>INICIO</li>
                <li>GALERIA</li>
            </ul>
        </nav>
    </header>

    <article>
        <div class="bg-header">
            <div class="text-header">
                <h1 class="text-name">Bem Vindo a Brain Tek</h1>
                <p class="decoration">Do seu cotidiano para um jogo</p>
                <img class="estrelas" src="./imgs/estrela.png" alt="">
                <img class="capa-jogo" src="./imgs/Resize/CapaJogo.jpg" alt="Brain Tek - Capa do Jogo">
                <p class="text-infor">Brain Tek é um jogo de tabuleiro educativo e divertido que simula a criação e
                    funcionamento de
                    circuito
                    elétricos!
                </p>
            </div>
        </div>
    </article>

    <section>
        <div class="container-novidade">
            <h2 class="novidade">Novidades</h2>
            <h3 class="atualizacao">Atualizações recentes</h3>
            <div class="grid-novidade">
                <div class="bg-novidade">
                    <h3>Novo Suporte</h3>
                    <p class="texto-atualizacao">A nova atualização inclui melhorias e aperfeiçoamento no uso!</p>
                    <span class="path">Patch 5.x.24</span>
                </div>
                <div class="bg-novidade">
                    <h3>Novos Desafios</h3>
                    <p class="texto-atualizacao">Criação de projetos ainda mais desafiadores e criativos</p>
                    <span class="path">Patch 5.x.24</span>
                </div>
            </div>
        </div>
    </section>

    <section>
        <div class="bg-roadmap">
            <div class="container gridRoadMap">
                <h1 class="titleRoadmap">RoadMap Brain Tek</h1>
                <div class="group-01">
                    <h2>Saiba o caminho!</h2>
                    <p>Chegue ao destino, se transforme em forma de energia!</p>
                    <img src="./imgs/CérebroAzul.jpg" alt="">
                </div>

                <div class="group-02">
                    <h2>Responda as perguntas!</h2>
                    <p>Chegue ao destino, se transforme em forma de energia!</p>
                    <img src="./imgs/Cubo.jpg" alt="Cubo-img">
                </div>

                <div class="group-01 level-3">
                    <h2>Responda as perguntas!</h2>
                    <p>Chegue ao destino, se transforme em forma de energia!</p>
                    <img src="./imgs/Arvore.jpg" alt="Arvore-img">
                </div>

                <div class="group-02 level-4">
                    <h2>Responda as perguntas!</h2>
                    <p>Chegue ao destino, se transforme em forma de energia!</p>
                    <img src="./imgs/CérebroAzul.jpg" alt="Cerebro-img">
                </div>
                <div class="text-complete">
                    <p>Um jogo que vai além das referencias</p>
                    <p>Um jogo que vai além das referencias</p>
                    <p>Um jogo que vai além das referencias</p>
                    <p>Um jogo que vai além das referencias</p>
                </div>
            </div>
        </div>
    </section>

    <article>
        <div class="container bg-comojogar">
            <div class="rules">
                <h1>Como Jogar?</h1>
                <p class="enfase">Aprenda as regras básicas do jogo</p>
                <div>
                    <h2>1º Configurações Inicais</h2>
                    <ol>
                        <li>Tabuleiro em escala gigante com quadrados coloridos (Branco, Verde, Azul, Amarelo, Vermelho e Marrom).
                        </li>
                        <li>Cada jogador é uma peça e avança no tabuleiro conforme o número sorteado no dado.
                        </li>
                        <li>Perguntas e desafios são organizados previamente por nível de dificuldade.
                        </li>
                    </ol>
                </div>

                <div>
                    <h2>2º Regras para as cores dos Quadrados</h2>
                    <ol>
                        <li class="topics"><span class="text-force">Branco (Neutro)</span>
                            <ol class="noTopic">
                                <li>Sem efeitos, apenas para preencher o caminho.</li>
                            </ol>
                        </li>
                        <li class="topics"><span class="text-force">Verde (Benefícios)</span>
                            <ol class="noTopic">
                                <li>Ganhar bônus, como avançar 2 casas ou jogar novamente.
                                </li>
                            </ol>
                        </li>
                        <li class="topics"><span class="text-force">Azul (Perguntas Fáceis)</span> 
                            <ol class="noTopic">
                                <li><span style="color: green; font-weight: bold;font-size: .85rem;">Acertou</span>: Avança 1(uma) casa.</li>
                                <li><span style="color: red; font-weight: bold;font-size: .85rem;">Errou</span>: Recua 2(duas) casas.</li>
                            </ol>
                        </li>
                        <li class="topics"> <span class="text-force">Amarelo(Perguntas Médias/Díficeis)</span> 
                            <ol class="noTopic">
                                <li><span style="color: green; font-weight: bold; font-size: .85rem;">Acertou</span>: Avança 2(duas) casas.</li>
                                <li><span style="color: red; font-weight: bold;font-size: .85rem;">Errou</span>: Recua 1(uma) casa.</li>
                            </ol>
                        </li>
                        <li class="topics"><span class="text-force">Vermelho (Penalidades)</span>
                            <ol class="noTopic">
                                <li>Penalidades automáticas como: voltar 3 casas, pular a vez ou ficar preso em uma “pane elétrica” (responder uma pergunta obrigatória para sair).
                                </li>
                            </ol>
                        </li>
                        <li class="topics"><span class="text-force">Marrom (Montagem do Circuito): </span> <p>O jogador deve montar um circuito conforme o desafio indicado.</p>
                            <ol class="noTopic">
                                <li><li><span style="color: green; font-weight: bold;font-size: .85rem;">Acertou</span>: Avança 3(três) casas</li>
                                <li><span style="color: red; font-weight: bold;font-size: .85rem;">Errou</span>: Recua 2(duas) casas</li>
                            </ol>
                        </li>

                    </ol>
                </div>

                <div>
                    <h2>3º Pergunta Final</h2>
                    <p class="lineText">Para vencer o jogo, o jogador precisa parar na última casa e responder uma pergunta de dificuldade alta ou montar um circuito final.
                    </p>
                </div>
                <div>
                    <h2>4º Extra - Adicionar Emoção</h2>
                    <p class="lineText">Se quiser, você pode incluir um dado especial com efeitos extras (ex.: "jogue novamente", "volte 1 casa", etc.), para deixar a dinâmica mais divertida.</p>
                </div>
            </div>
        </div>
    </article>

    <article>
        <div class="container">
            <h1 class="size-text">Criadores do jogo</h1>
            <div class="grid-container">
                <div class="grid-devs">
                    <img src="./imgs/admin resize/Ray.jpg" alt="IMG-RAIANE">
                    <h3>Raiane</h3>
                    <span>CEO</span>
                    <p>tal tal tal tal tal</p>
                </div>

                <div class="grid-devs">
                    <img src="./imgs/admin resize/bruna.jpg" alt="IMG-BRUNA">
  