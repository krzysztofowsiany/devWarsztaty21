sudo docker build . -t scoreservice:latest #buduje obraz na podstawie pliku Dockerfile, .-wykonuje w bierzacej lokacji

sudo docker images #listuje wszystkie obrazy jakie stworzone 

sudo docker run -d scoreservice:latset #uruchamianie -d oznacza ze w osobnym procesie w tle działa

sudo docker ps -al #pokaze procesy dockeraZ

DOCKER WYMAGA BY BYŁ ZAWSZE 1 PROCES, nie uruchomienie spowodowało wyjśćie z kontenera


po każdej aktualizacji Dockerfile, wykonyjemy docker build . -t scoreservice:latest

sudo docker stop stoic_space # zatrzymanie dockera po nazwie albo HASH

sudo docker rm stoic_space # usuwamy dockera po nazwie albo HASH


ALPINE  - specjalna dystrybucja linuxa bardzo mała do budowania konteenra


sudo docker run -d -p 5001:5001 scoreservice:latest # dostep po zmapowaniu portu

sudo docker logs hungry_lumiere #logi z uruchomione aplikacji

sudo docker rmi HASH # usuwanie obrazu z systemu UWAGA kasuje swoje warstwy i moze coś popsuć

sudo docker inspect hyngry_lumiere # pokazuje to co jest w dockerze