$(document).ready( /* após carregar o site executa o conteudo aqui dentro */
    function() {
        $('button[name="btnBoasVindas"]').click(function() { /* informamos o botrao do click que ira chamar o alerta*/
            var nomeusuario = $('input[name="nomeUsuario"]').val(); /*obtemos o valor digitado*/
            $('span[name="usuariotexto"]').text(nomeusuario);

            $('button[name="usuariotexto"]').click();
            /*alert("Seja bem vindo " + nomeUsuario + " ao nosso sistema de cervejaria."); apresentacao do alerta*/

        });
    });

/* 
$(document).on('keypress', function(e) {
    if (e.which == 13) {
        $('input[name=btnBoasVindas"]').click();
    }
});
*/