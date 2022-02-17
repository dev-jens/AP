# Functioneel design
De app heeft een simpel design zodat elke gebruiker er makkelijk mee overweg kan. De GUI moet zich automatisch aanpassen aan de hand van het apparaat waar de gebruiker de app op gebruikt. 

Wanneer u de app opent ziet u een inlogscherm. U kan inloggen met de inlogknop, indien u nog geen account heeft kan u zich hier ook registreren. Wanneer u uw wachtwoord bent vergeten is er ook een optie om via de link uw wachtwoord te wijzigen. Afhankelijk van de rol van uw account, biedt de applicatie verschillende functies. 

<img src="./assets/Login-Wireframe.jpg" alt="Login WF"> 

Na het inloggen als standaardgebruiker (ondernemer) zal er een startpagina verschijnen waar u een kredietaanvraag kan indienen, dit is hier aanwezig om het hoofdproces van de applicatie meteen toegankelijk te maken vanaf de klant is ingelogd. 
U dient de details van de aanvraag te beschrijven en de reden van de aanvraag tot krediet in te geven in de inputvelden. Er zal ook een uploadzone beschikbaar zijn om info zoals offertes en plannen voor het te financieren project te uploaden. Het systeem zal op basis van deze gegevens ratio's gaan berekenen die dan zullen resulteren in een feedbackdocument met een goedkeuring of afkeuring.  

<img src="./assets/Aanvraag-Wireframe.png" alt="Aanvraag WF">

Er is een drop-down menu beschikbaar waar u door op het bijhorende veld te klikken naar verschillende pagina's kunt navigeren.

Eens geretourneerd door de kredietbeoordelaar zal er een manier zijn voor standaardgebruikers en kantoormedewerkers om het feedbackbestand te lezen, deze bestanden vindt de gebruiker onder 'feedback' in het drop-down menu. Bij de kantoormedewerker zullen hier verschillende feedbackdocumenten te zien zijn van meerdere klanten. Gebruikers kunnen hier ook de status van hun aanvraag controleren. Wanneer de aanvraag op groen staat zal de gebruiker de mogelijkheid hebben om op de 'contract' knop te drukken. Dit lijdt de gebruiker naar de contractpagina en zal een automatische download starten van het beschikbare contract.

<img src="./assets/Feedback-Wireframe.png" alt="Feedback WF">

Op de pagina van het contract kan men het contract digitaal ondertekenen of uploaden in de uploadzone indien op papier getekend. Met het downloaden van de aflossingstabel zal u een pdf gedownload krijgen met de volgende info:
- Het geleend bedrag
- De interestvoet
- Het termijn
- De interval

<img src="./assets/Contract-Wireframe.png" alt="Contract WF">

De kredietbeoordelaar zal toegang hebben tot een lijst met alle oranje kredietaanvragen die naar hem zijn doorgestuurd. Als de kredietbeoordelaar één van deze aanvragen selecteert wordt een Excel-bestand gedownload. In dit document zijn alle ratio's beschreven met de juiste kleurcode, zodat de kredietbeoordelaar de onvoldoende gescoorde ratio's kan beoordelen. Daarna zal hij in de lijst een optie hebben om deze goed of af te keuren. 

<img src="./assets/KB-Wireframe.png" alt="KB WF">

De commerciele directie kan het aantal aanvragen en het aantal direct goedgekeurde/afgewezen kredieten bekijken. Op basis van deze informatie kunnen zij hun medewerkers evalueren. De directie heeft ook beschikking over rollenbeheer. Zij kunnen in het overzicht van hun medewerkers voor elke persoon het wachtwoord en de rol wijzigen maar ook het account verwijderen.

De afdeling Compliance krijgt meldingen bij verdachte aanvragen (te grote bedragen, bepaalde sectoren vb kansspelen). Ze hebben toegang tot een lijst van verdachte meldingen. Wanneer men op een melding klikt kunnen ze de bedragen, oorsprong van de aanvraag, etc. evalueren om na te gaan of dit een frauduleuze aanvraag is. Ze hebben dan ook de mogelijkheid via een knop om deze aanvraag af te keuren en te rapporteren aan de NBB. 

Het Departement Sustainability heeft enkel toegang tot een overzicht van de kredietaanvragen in de vorm van een lijst.