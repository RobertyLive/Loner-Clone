===============================================================================
=    Benvenuto  alla   G u i d a    all'Editor   V I M   -    Versione 1.7    =
===============================================================================
=			  C A P I T O L O   DUE				      =
===============================================================================

     Hic Sunt Dracones: Se questa è la prima volta che vi accostate a vim
     e preferite iniziare dal capitolo introduttivo, gentilmente immettete
     :q<INVIO> e poi iniziate da quello.

     Il tempo necessario per completare questo capitolo è di circa 8-10
     minuti, a seconda del tempo utilizzato per fare delle prove.

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
			Lezione 2.1.1: I REGISTRI CON NOME


         ** Copiare due parole in registri diversi e poi incollarle **

  1. Spostate il cursore alla riga qui sotto marcata con --->

  2. Andate su una lettera qualsiasi di 'Edward' e battete "ayiw

MNEMONICO: nel registro(") di nome (a) (y)copia (i)interna (w)parola

  3. Spostatevi alla parola 'biscotti' (fc o 2fb o $b o /bis<INVIO>)
     e battete   "byiw

  4. Andate su una lettera qualsiasi di 'Vince' e battete   ciw<C-r>a<ESC>

MNEMONICO: (c)cambia (i)interna (w)parola con <Contenuto (r)egistro> di nome (a)

  5. Andate su una lettera qualsiasi di 'dolci' e battete   ciw<C-r>b<ESC>

--->  a) Edward sarà d'ora in poi responsabile della razione di biscotti
      b) Come compito, Vince sarà il solo a decidere riguardo ai dolci

NOTA: Anche una parola cancellata può essere inviata ad un registro, p.es.,
      "sdiw cancellerà (d) la parola sotto il cursore (iw) e la metterà
      nel registro (s)
RIFERIMENTI: 	Registri 	  :h registers
		Registri con nome :h quotea
		Movimento	  :h motion.txt<INVIO> /inner<INVIO>
		CTRL-R		  :h insert<INVIO> /CTRL-R<INVIO>

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

			Lezione 2.1.2: IL REGISTRO DELLE ESPRESSIONI


	       ** Inserire al volo risultati di un calcolo **

  1. Spostate il cursore alla riga qui sotto marcata con --->

  2. Andate su un punto qualsiasi del numero fornito

  3. Battete ciw<C-r>=60*60*24<INVIO>

  4. Sulla riga seguente, entrate in modo Insert e aggiungete
     la data di oggi con <C-r>=system('date')<INVIO>

NOTA: Tutte le chiamate a sistema dipendono dal S.O., p.es., in ambiente
      Windows si usa    system('date /t')   o  :r!date /t

---> Non ricordo il numero esatto di secondi in un giorno, è 84600?
     La data di oggi è: 

NOTA: Lo stesso risultato si può ottenere con   :pu=system('date')
      o, ancora più brevemente, con  :r!date

RIFERIMENTI: 	Registro espressioni	:h quote=

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

			Lezione 2.1.3: I REGISTRI NUMERATI


	    ** Battere yy e dd per vedere l'effetto sui registri **

  1. Spostate il cursore alla riga qui sotto marcata con --->

  2. Copiate (yy) la riga stessa e controllate i registri con :reg<INVIO>

  3. Cancellate la riga che inizia con "0." con "cdd, poi controllate i
     registri (Dove vi aspettate sia finita la riga cancellata?)

  4. Continuate a cancellare ogni riga seguente, controllando ogni volta
     con :reg il risultato
NOTA: Dovreste notare che le righe cancellate per prime scendono nella
      lista, man mano che vengono aggiunte nuove righe cancellate
  5. Poi incollate (p) i seguenti registri nell'ordine; c, 7, 4, 8, 2.+
     ossia "cp "7p ...

---> 0. Questo
     9. dondolante
     8. messaggio
     7. è
     6. in
     5. asse
     4. un
     3. guerresco
     2. segreto
     1. tributo

NOTA: Le cancellazioni di righe intere (dd) sopravvivono nei registri numerati
      molto più a lungo delle copie di righe intere (yy), o delle
      cancellazioni che implicano movimenti minori

RIFERIMENTI: 	Registri numerati 	:h quote0

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

			Lezione 2.1.4: IL FASCINO DELLE MARCATURE


	         ** Evitare di contare le righe di codice **

NOTA: Un problema frequente quando si scrivono programmi �