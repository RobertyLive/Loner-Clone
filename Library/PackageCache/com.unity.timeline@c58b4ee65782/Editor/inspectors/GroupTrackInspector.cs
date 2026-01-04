.bg-roadmap{
    background-image: url("../imgs/Percurso.jpg");
    background-repeat: no-repeat;
    background-size: cover;
}

.gridRoadMap{
    display: grid;
    grid-template-columns: 1fr;
}

.titleRoadmap{
    grid-column: 1/-1;
    margin: 30px 0 40px 0;
    font-size: 1.7rem;
}

.group-01{
    margin-bottom: 50px;
}

.group-02{
    margin: 100px 0;
}

.group-01, .group-02{
    display: grid;
    grid-template-columns: 1fr 1fr;
    gap: 4px 15px;
}

.group-01 img{
    grid-column: 2;
    grid-row: 1/3;
    width: 150px;
    border-radius: 5px;

}

.group-02 img{
    grid-row: 1/3;
    width: 150px;
    border-radius: 5px;
    justify-self: end;
}

.group-01 h2{
    font-size: 1.3rem;
    text-align: end;
}

.group-02 h2{
    font-size: 1.3rem;
}
.group-01 p{
    text-align: end;
    max-width: 20ch;
    font-size: .9rem;
}

.level-3{
    margin: 200px 0 100px 0;
}

.text-complete{
    margin-bottom: 100px;
}

.text-complete img{
    place-self: center;
    display: block;
}



@media(width < 340px){
    .bg-roadmap{
        background-image: none;
    }

    .gridRoadMap{
        margin: 0 auto;
    }
    .group-01, .group-02{
        margin: 15px;
    }

    .text-complete{
        display: none;
    }

    .group-01 h2, .group-02 h2{
        font-size: 1rem;
    }

    .group-01 p, .group-02 p{
        font-size: 0.8rem;
    }
    .text-complete{
        display: none;
    }
}

@media(width>460px){
    /* .bg-roadmap{
        background-image: none;
    }
    .gridRoadMap{
        gap: 25px;
    }
    .group-01, .group-02{
        margin: 15px;
    }

    .text-complete{
        display: none;
    }

    .group-01, .group-02{
        width: 400px;
        justify-content: center;
    }
    .group-01 h2, .group-02 h2{
        font-size: 1.5rem;
    }

    .group-01 p, .group-02 p{
        font-size: 0.8rem;
        max-width: 25ch;
    }

    .group-01 p{
        text-align: end;
        justify-self: end;
    } */
}

@media(width>800px){
    .gridRoadMap{
        justify-content: center;
        justify-items: center;
    }

    .bg-roadmap{
        /* display: none; */
    }

    .titleRoadmap{
        font-size: 2.5rem;
    }

    .group-01, .group-02{
        width: 800px;
        margin: 0 auto;
        grid-template-rows: auto auto;
        /* align-items: center; */

        margin-bottom: 80px;
    }

    .group-01 h2, .group-02 h2{
        font-size: 2rem;
    }

    .group-01 p, .group-02 p{
        font-size: 1rem;
    }

    .group-01 img, .group-02 img{
        width: 70%;
    }

    .group-02{
        width: 600px;
    }
}


@media(width<620){
    .gridRoadMap{
        width: 400px;
    }
    .group-01, .group-02{
        width: 300px;
        margin: 0 auto;
        grid-template-rows: auto auto;
        /* align-items: center; */

        margin-bottom: 80px;
    }
}

@media(width>350px) {
    .bg-roadmap{
        box-shadow: inset 0 200px 0px #161616;
    }
    .gridRoadMap{
        gap: 25px;
    }
    .group-01, .group-02{
        margin: 15px;
    }

    .text-complete{
        display: none;
    }

    .group-01, .group-02{
        width: 400px;
        justify-content: center;
        gap: 25px 15px;
    }

    .group-01 img, .group-02 img{
        justify-self: center;
    }
    
    .group-02{
        margin-top: 170px;
        

    }

    .level-3{
        margin-top:320px;
    }

    .group-04{
        margin-top: 200px;
        margin-bottom: 200px;
    }
    .group-01 h2, .group-02 h2{
        font-size: 1.5rem;
    }

    .group-01 p, .group-02 p{
        font-size: 0.8rem;
        max-width: 25ch;
    }

    .group-01 p{
        text-align: end;
        justify-self: end;
    }

    .titleRoadmap{
        font-size: 2rem;
        max-width: 8ch;
        margin: 0;
        
    }
}




@media(width<620){
    .gridRoadMap{
        width: 400px;
    }
    .group-01, .group-02{
        width: 300px;
        margin: 0 auto;
        grid-template-rows: auto auto;
        /* align-items: center; */