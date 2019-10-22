$('#ceporigem').mask("00000-000");
$('#cepdestino').mask("00000-000");

$('#limpar').click(function () {
    ClearScreen();
});



function ClearScreen() {
    var myInputs = $('input[type="text"]');
    myInputs.val("");
}


