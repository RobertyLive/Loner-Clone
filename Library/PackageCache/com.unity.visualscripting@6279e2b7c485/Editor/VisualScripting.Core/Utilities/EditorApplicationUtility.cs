<!DOCTYPE html>
<html class="html-body" lang="en" id="document">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
</head>

<body>
    <!--Getting Started Page Content Start--DO NOT TRANSLATE THIS COMMENT-->
    <div id="simple-page">
        <div id="header">
            <header>
                <img class="vsls-icon" src="https://aka.ms/vsls-icon" />
                <div class="header-text">
                    <h1 class="vsls-header">Visual Studio Live Share</h1>
                    <h2 class="real-time-header">Совместная разработка в реальном времени</h2>
                </div>
            </header>
            <div class="clearfix"></div>
            <h4 id="simple-page-welcome-title">Добро пожаловать в Visual Studio Live Share!</h4>
        </div>
        <div id="simple-page-sections">
            <div id="user-guide" class="simple-page-section">
                <div class="simple-page-icon">
                    <span class="ms-Icon ms-Icon--BookAnswers"></span>
                </div>
                <p>Хотите узнать, как использовать Live Share?</p>
                <a class="simple-page-button" href="https://docs.microsoft.com/en-us/visualstudio/liveshare/use/vs" target="_blank">Руководство пользователя</a>
            </div>

            <div id="join-yourself" class="simple-page-section">
                <div class="simple-page-icon">
                    <span class="ms-Icon ms-Icon--Touch"></span>
                </div>
                <p>Сведения о том, как использовать Live Share</p>
                <button class="simple-page-button" id="simple-page-join-yourself-button">Присоединяйтесь</button>
            </div>

            <div id="copy-link" class="simple-page-section">
                <div class="simple-page-icon">
                    <span class="ms-Icon ms-Icon--PageLink"></span>
                </div>
                <p>Приглашайте других пользователей в сеанс по электронной почте или в чате</p>
                <button id="simple-page-url-copy-button" class="simple-page-button">Копировать ссылку</button>
            </div>
        </div>
    </div>
    <div id="control-page">
        <div id="header">
            <header>
                <img class="vsls-icon" src="https://aka.ms/vsls-icon" />
                <div class="header-text">
                    <h1 class="vsls-header">Visual Studio Live Share</h1>
                    <h2 class="real-time-header">Совместная разработка в реальном времени</h2>
                </div>
            </header>
            <div class="clearfix"></div>
            <h4>Добро пожаловать в Visual Studio Live Share!</h4>
        </div>
        <p> Начните работу со своей командой в режиме совместного редактирования и отладки за несколько простых шагов:</p>

        <div id="step-sign-in" class="step">
            <section class="features-section">
                <div class="liveshare-action-signin clearfix">
                    <button id="sign-in-button">Начать вход</button>
                    <div class="why-details">
                        <h3 id="why-sign-in">Для чего нужен вход?</h3>
                        <p>
                            При совместной работе важно, чтобы другие пользователи могли определить, кем именно вы являетесь, и не сомневаться,
                            предоставляя вам доступ к своему коду и среде разработки. После входа вы получите права на чтение и запись, чтобы иметь возможность редактировать код вместе с организатором.
                        </p>
                        <p>
                            Чтобы упростить начало работы,
                            вы можете войти в систему с помощью существующей учетной записи GitHub или Майкрософт.
                        </p>
                    </div>
                </div>
            </section>
        </div>

        <div id="step-sign-in-before-share" class="step">
            <section class="features-section">
                <div class="liveshare-action-signin clearfix">
                    <button id="sign-in-button-before-share">Начать вход</button>
                    <div class="why-details">
                        <h3 id="why-sign-in">Для чего нужен вход?</h3>
                        <p>
                            При совместной работе важно, чтобы другие пользователи могли определить, кем именно вы являетесь, и не сомневаться,
                            предоставляя вам доступ к своему коду и среде разработки. После входа вы сможете предоставить другим пользователям доступ к вашей рабочей области и работать с ними совместно.
                        </p>
                        <p>
                            Чтобы упростить начало работы,
                            вы можете войти в систему с помощью существующей учетной записи GitHub или Майкрософт.
                        </p>
                    </div>
                </div>
            </section>
        </div>

        <div id="step-share" class="step">
            <section class="features-section">
                <div class="features-section__icon">
                    <span class="ms-Icon ms-Icon--Share"></span>
                </div>
                <div class="features-section__body">
                    <h3 class="section-heads">Общий доступ</h3>
                    <p>Нажмите кнопку <i>Live Share</i> в правом верхнем углу, которая откроет общий доступ к вашему проекту, и скопируйте уникальный URL-адрес сеанса в буфер обмена.</p>
                    <!--<img src="https://aka.ms/vsls/quickstart/share" width="136px" alt="Элемент строки состояния общей папки Visual Studio Code" />-->
                    <p>При предоставлении общего доступа в первый раз вам потребуется войти в систему (с помощью учетной записи GitHub или Майкрософт), чтобы другие участники совместной работы могли идентифицировать вас.</p>
                    <img  class="signin-image" src="https://aka.ms/vsls/vs-signin" />
                    <blockquote>
                        <p>В Windows может потребоваться разрешить Live Share открыть порт брандмауэра, чтобы разрешить одноранговые подключения.</p>
                    </blockquote>
                    <p>
                </div>
            </section>
        </div>

        <div id="step-joined-Edit" class="step">
            <section class="features-section">
                <div class="features-section__icon">
                    <span class="ms-Icon ms-Icon--Edit"></span>
                </div>
                <div class="features-section__body">
                    <h3 class="section-heads">Изменить</h3>
                    <p>Теперь, находясь в сеансе совместной работы, вы можете перемещать курсор, редактировать и выделять текст, а также просматривать аналогичные действия других участников.</p>
                    <p>Вы можете получить доступ ко всем функциям Live Share, щелкнув раскрывающееся меню "Присоединенные" или значки участников в правом верхнем углу.</p>
                    <p>Здесь вы можете просмотр