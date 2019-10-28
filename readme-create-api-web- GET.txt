new solution
add project
web asp net framework
web api - desmarcar-https
 na pasta controller add controller -web api2 empty - nomear o arquivo.
criar metodo dentro da classe que foi criada

public string Get(){
return "texto"
}

rodar o servico para verificar se está tudo ok
usar postman
copiar o localhost/111111
e mais o projeto
localhost/111111/api/calcularIMC
colar no postman e verificar se retornou os dados que consta no calculoIMCcontroller , por exemplo"texto".

criar outro metodo onde é feito um override 

public string Get(double peso, double altura,string nome){
var imc =  peso/ (altura*altura);

return $"{nome} seu imc é {imc.tostring("N2")}";
}



opcao2 - com webview e server GET

new solution
create asp net web
empty e sem https
new html page  - index.html
new folder js e css
add script.js
add bootstrap via nuget.
install jquery via nuget
 jquery primeiro
e por ultimo o popper.js
arrastar bootstrap.css
e final pasta javascript
add tbm a pasta css no header
montar os divs. container fluid- row-inputs
adicionar o <form name"formImc"> englobando os divs.
iniciar os scripts.
$document ready function --add o alert para verificar se está linkado corretamente o script
chamar a funcao click do botao
var informacaos = $('form[name="formImc"]').serialize();
var  url= "url"
$.get("url" + informacoes, function (data)){
alert (data);
sempre iniciar o server para poder rodar o aplicativo.
adicionar o corns
comando  para console -- install-package microsoft-aspnet.webapi.cors  --via nuget via console.
habilitar o cors
no arquivo webapiconfig  
add config .enableCors(); dentro do metodo register 
na controller - calculoController devemos add em cima da classe [EnableCors(origins: "*", headers: "*", methods: "*")]   e inportar o cors
remover informacoes fixas do link
testar

link do projeto

https://github.com/darkeght/AtividadeCorreios/tree/CriacaoProjeto

