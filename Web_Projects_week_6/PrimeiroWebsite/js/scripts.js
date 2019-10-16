
$(document).ready(
    function () {
    /* Chamamos a funcao */

        atualizaData()
    });

/* Função atualiza data */
function atualizaData() {
    setInterval(function () {
        $('span[name="data_atual"]').text(Date());

    }, 100);
}