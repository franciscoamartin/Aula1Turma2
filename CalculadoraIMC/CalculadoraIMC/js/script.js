$('#show').click(function () {
    var formCampos = $('#formenviar').serialize();

    $.get("http://localhost:58570/api/CalculoIdade?" + formCampos, function (data) {
        $('#resultadoIMC').val(data)
    });
}); 



$("#limpar").click(function () {
    var myInputs = $('input[type="text"]');
    myInputs.val("");
});