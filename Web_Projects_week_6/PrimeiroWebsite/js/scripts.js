
$(document).ready(
    function () {
    /* Chamamos a funcao */

        atualizaData()
    });

/* Fun��o atualiza data */
function atualizaData() {
    setInterval(function () {
        $('span[name="data_atual"]').text(Date());

    }, 100);
}