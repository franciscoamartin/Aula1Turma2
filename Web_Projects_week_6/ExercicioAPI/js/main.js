var meuUsuario = { nome: "DOG", idade: 10, raca: "Poddle", coloracao: "Preta" };

$(document).ready(
    function() {

        $('input[name="nome"]').val(meuUsuario.nome);
        $('input[name="idade"]').val(meuUsuario.idade);
        $('input[name="raca"]').val(meuUsuario.raca);
        $('input[name="coloracao"]').val(meuUsuario.coloracao);


        $('input[name="btnCadastrar"]').click(function() {
            var nome = meuUsuario.nome = $('input[name="nome"]').val();
            var idade = meuUsuario.idade = $('input[name="idade"]').val();
            var raca = meuUsuario.raca = $('input[name="raca"]').val();
            var coloracao = meuUsuario.coloracao = $('input[name="coloracao"]').val();
            alert("\nNome do Pet: " + nome + "\nIdade do Pet: " + idade + "\nRaça do Pet: " + raca + "\nColoração do Pet: " + coloracao);

        });

        $('input[name="btnMostrar"]').click(function() {
            alert("\nNome do Pet: " + meuUsuario.nome + "\nIdade do Pet: " + meuUsuario.idade + "\nRaça do Pet: " + meuUsuario.raca + "\nColoração do Pet: " + meuUsuario.coloracao);

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