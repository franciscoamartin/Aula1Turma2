var meuPet = { nome: "DOG", idade: 10, raca: "Poddle", coloracao: "Preta" };

$(document).ready(
    function() {

        $('input[name="nome"]').val(meuPet.nome);
        $('input[name="idade"]').val(meuPet.idade);
        $('input[name="raca"]').val(meuPet.raca);
        $('input[name="coloracao"]').val(meuPet.coloracao);


        $('input[name="btnCadastrar"]').click(function() {
            var nome = meuPet.nome = $('input[name="nome"]').val();
            var idade = meuPet.idade = $('input[name="idade"]').val();
            var raca = meuPet.raca = $('input[name="raca"]').val();
            var coloracao = meuPet.coloracao = $('input[name="coloracao"]').val();
            alert("\nNome do Pet: " + nome + "\nIdade do Pet: " + idade + "\nRaça do Pet: " + raca + "\nColoração do Pet: " + coloracao);
            // var cleiton = [meuUsuario.nome];
            // localStorage.setItem("teste", JSON.stringify(cleiton));
            LimparTela();
        });

        $('input[name="btnMostrar"]').click(function() {
            alert("\nNome do Pet: " + meuPet.nome + "\nIdade do Pet: " + meuPet.idade + "\nRaça do Pet: " + meuPet.raca + "\nColoração do Pet: " + meuPet.coloracao);

        });
    }
);

function readURL(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function(e) {
            $('#image')
                .attr('src', e.target.result)
                .width(350)
                .height(250);
        };

        reader.readAsDataURL(input.files[0]);
    }
}

function LimparTela() {
    var meusInputs = $('input[type="text"]'); //obtemos os campos

    // for (var i = 0; i < meusInputs.length; i++) { //loop para todos os campos
    meusInputs.val("");
}