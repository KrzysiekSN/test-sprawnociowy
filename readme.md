no cześć, chyba finito 
wersja unity 6000.6.2f1

- W jaki sposób obliczyłeś kierunek i rotację pocisku?
	- kierunek pocisku obliczyłem używająć mathf.2tan i przeliczając to potem używając Mathf.rad2deg, 
	- potem przy ustawianiu kierunku obiektu spluwy odjąłem 90 stopni żeby się ona bezpośrednio patrzyła w kierunku myszki.

- W jaki sposób Object Pool (bullet pool) radzi sobie z odzyskiwaniem i ponownym wysyłaniem pocisków?
	- Przy rozpoczęciu rozgrywki tworzą się 64 pociski i od razu dodawany do bullet pool
	- Przy wysyłaniu pocisku jest on aktywowany (.setActive(true) ) i wysyłany w kierunku ustawianym przy wystrzeliwaniu pocisków (skrypt spluwaKod). Jest też parent ustawiany na null
	- Po 2 sekundach pocisk jest dezaktywowany a jego parent ustawiany spowrotem jako bullet pool

- Jaki był najtrudniejszy, nieznany koncept z którym spotkałeś się podczas wykonywania tego zadania i w jaki sposób udało ci się go zrozumieć/zaimplementować?
	-Z racji takiej iż to był mój pierwszy projekt bez tutoriali youtubie (używałem za to postów na forum co znalazłem/innych dokumentacji) to wiele było ciężkich rzeczy, ale dwoma najcięższymi były zdecydowanie
		- ustawianie kątu wystrzeliwania pocisków (wciąż niezbyt czaje tego 2Atan/Rad2Deg (muszę bardziej się podszkolić)
		- branie dzieci z puli (cały czas próbowałem używać GetChildCount)
