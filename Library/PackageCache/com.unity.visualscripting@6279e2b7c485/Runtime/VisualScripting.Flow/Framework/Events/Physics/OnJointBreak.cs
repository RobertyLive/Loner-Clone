.menu-header{
    display: flex;
    gap: 25px;
    justify-content: center;
    margin: 50px 0;
}

article{
    position: relative;
}

.bg-header::before{
    content: '';
            position: absolute;
            top: 0;
            left: 0;
            right: 0;
            bottom: 0;
            background-image: url("../imgs/processador.jpg");
            height: 100%;
            background-size: 200%;
            background-position: right center;
            background-repeat: no-repeat;
            opacity: 0.1;
            z-index: -1; 
}

.bg-header{
    box-shadow: inset 0 60px #161616; 
}


.text-header{
    display: grid;
    justify-items: center;
    gap: 10px;
}

img{
    position: relative;
}

.estrelas{
    width: 10%;
    height: 100%;
}

.capa-jogo{
    display: flex;
    max-width: 100%;
    width: 70%;
    margin: 0 0 0 0;
    /* opacity: 0.3; */
}
.text-na