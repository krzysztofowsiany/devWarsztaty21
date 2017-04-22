FROM ubuntu:xenial

#instalujemy paczki w kontenerze
RUN apt-get update \    
    && apt-get install -y --no-install-recommends \        
    ca-certificates \        
    curl \        
    apt-transport-https \ 
&& rm -rf /var/lib/apt/lists/* 

RUN sh -c 'echo "deb [arch=amd64] https://apt-mo.trafficmanager.net/repos/dotnet-release/ xenial main" > /etc/apt/sources.list.d/dotnetdev.list' 

RUN apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 417A0893 \    
    && apt-get update \   
    && apt-get install -y dotnet-dev-1.0.1

#RUN aplikuje zmiane na obraz
RUN mkdir /usr/share/app
COPY . /usr/share/app

#ustawiamy roboczy katalog
WORKDIR /usr/share/app/src/ScoreService.API

RUN dotnet restore \    
    && dotnet build 

#udostepniamy dockera na porcie 5001
EXPOSE 5001 

#tylko jedno CMD na kontener, wykonuje operacje w kontenerze
CMD ["dotnet", "run"]