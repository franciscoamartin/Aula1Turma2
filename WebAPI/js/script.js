$(document).ready(
    function () {
        $('#cepentrada').mask("00000-000");

        $('input[id="btnMostrar"]').click(
            function () {

                $.get(`https://viacep.com.br/ws/${$('input[name="CEPEntrada"]').val()}/json/`, function (data) { //meio para acrescentar string url com dados 
                    if (data.erro) {
                        alert("CEP nao encontrado.");
                        return false;
                    }
                        $('input[name="bairro"]').val(data.bairro);
                        $('input[name="localidade"]').val(data.localidade);
                        $('input[name="uf"]').val(data.uf);
                        $('input[name="logradouro"]').val(data.logradouro);
                  
                });
            }
        );
    }
);
