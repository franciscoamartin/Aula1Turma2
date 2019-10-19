$(document).ready( /* após carregar o site executa o conteudo aqui dentro */
    function() {

        $('input[name="valorReal"]').mask("000.000,00");

        $('input[name="btnConverter"]').click(function() { /* informamos o botrao do click que ira chamar o alerta*/

            var url = "https://olinda.bcb.gov.br/olinda/servico/PTAX/versao/v1/odata/CotacaoDolarDia(dataCotacao=@dataCotacao)?@dataCotacao=%2710-16-2019%27&$top=100&$format=json";

            $.getJSON(url, function(data) {
                var valorDolar = data.value[0].cotacaoVenda;
                var valorReal = $('input[name="valorReal"]').val()
                    .replace(".", "")
                    .replace(",", ".");

                // var convercao = valorReal / valorDolar;

                var convercao = (valorReal / valorDolar).toLocaleString('en-US', { minimumFractionDigits: 2, currency: 'USD' });

                $('input[name="valorDolar"]').val(convercao);
            });

        });

        //Colocamos a mask em nosso campo 999.999,00
        //$('input[name="valoreal"]').mask("000.000,00");
        $('input[name="valorReal"]').maskMoney({
            showSymbol: false,
            symbol: "R$",
            decimal: ",",
            thousands: "."
        });
    }
);

$(document).on('keypress', function(e) {
    if (e.which === 13) {
        $('input[name="btnConverter"]').click();
    }
});