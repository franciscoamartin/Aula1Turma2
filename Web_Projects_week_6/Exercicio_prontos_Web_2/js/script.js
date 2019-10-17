$(document).ready( /* após carregar o site executa o conteudo aqui dentro */
    function() {
        $('input[name="btnConverter"]').click(function() { /* informamos o botrao do click que ira chamar o alerta*/
            var valorDolar = 4.16;
            var valorReal = $('input[name="valorReal"]').val()
                .replace(".", "")
                .replace(",", ".");

            var convercao = valorReal / valorDolar;

            $('input[name="valorDolar"]').val(convercao);

        });

        $('input[name="valorReal"]').mask("000.000,00");
    });