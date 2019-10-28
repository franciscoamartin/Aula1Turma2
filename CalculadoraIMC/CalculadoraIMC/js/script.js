$('#show').click(function () {
    var formCampos = $('#formenviar').serialize(); //captura todos os campos inputs da div formenviar

    $.get("http://localhost:58570/api/CalculoIdade?" + formCampos, function (data) { //busca a api onde contem o calculo
        $('#resultadoIMC').val(data) //adiciona os dados obtidos aqui.
    });

    $.get("http://localhost:58570/api/Imc/Msg?" + formCampos, function (data) {
        $('#msg').val(data)
    });
}); 



$("#limpar").click(function () {
    var myInputs = $('input[type="text"]');
    myInputs.val("");
});