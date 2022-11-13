# Trabalho prático Integração de Sistemas de Informação 2022/2023
## Como fazer tudo acontecer:
* [Fazer instalação do Visual Studio](https://visualstudio.microsoft.com/downloads/)
* [Fazer instalação do pentaho Kettle](https://www.hitachivantara.com/en-us/products/lumada-dataops/data-integration-analytics/download-pentaho.html?ecid=ps_emea_dx_en_sssem340&utm_source=google&utm_medium=paid-search&utm_campaign=1-1-TwoG-global-brand-All_Seg-FY22-Q1-EMEA-OAPS&utm_keyword=pentaho%20kettle&gclid=Cj0KCQiAyMKbBhD1ARIsANs7rEFl2R7qVo6O2zOrqXuLJo8f7iJwPQ3gZDieJVLQfLrvL_xxBCj0_i0aAmJ7EALw_wcB&gclid=Cj0KCQiAyMKbBhD1ARIsANs7rEFl2R7qVo6O2zOrqXuLJo8f7iJwPQ3gZDieJVLQfLrvL_xxBCj0_i0aAmJ7EALw_wcB) 
* [Fazer a isntalação base dados MongoDB](https://www.mongodb.com/try/download/community)
* [Fazer instalação do mosquitto](https://mosquitto.org/download/)
### **Depois de todas as instalações efetuadas seguir os seguintes passos:**

* Compilar o projeto que se encontra na pasta "inputs" para ter um ficheiro json de entrada de dados no Kettle
* Abra a interface do Pentaho Kettle com o nome de "Spoon.bat"
* Abra o Job do projeto que se encotra dentro da pasta "Jobs", chamado de "jobCarros.kjb"
* Efetue a compilação desse Job e veja os resultados na pasta "resultados", que se encontra no seguinte caminho: "Jobs -> Transformacoes -> resultados"
* Verifique também os resultados obtidos na base dados MongoDb
* Abra três separadores na linha de comandos, execute-os todos em modo de administrador, execute os seguintes passos:
1. Vá até há pasta do mosquitto e execute o seguinte comando : **mosquitto.exe -v** acabou de iniciar o broker
2. No outro terminal vá novamente á pasta do mosquitto e execute o seguinte comando: **.\mosquitto_sub.exe -t carros/# --pretty**, acabou de meter o broker em escuta de dados
3. Por último no outro terminal execute o seguinte comando: "Node-Red"
* Abra num separador o link de execução do Node Red.
* No Node Red faça o import do Json que se encotra dentro da pasta do projeto "Node Red"
* Num outro separador abra o link do node red incluindo o "/ui" exemplo: "http://127.0.0.1:1880/ui"
* Faça Deploy no Node Red e de seguida execute novamente o job no pentaho kettle
* A magia aconteceu :magic_wand:
