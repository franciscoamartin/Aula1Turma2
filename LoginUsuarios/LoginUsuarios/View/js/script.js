
var Cadastro =
{
    Nome: "teste",
    Senha: "senha",
    Login: "login",
    Email: "email"
}

var ArrayCadastro = [Cadastro];

$(document).ready(
    function () {
        $('#show').click(function () {

            //alert(JSON.stringify(ArrayDogs));

            var stringTemplate = "Registrado com sucesso:\n\n";

            for (var i = 0; i < ArrayCadastro.length; i++) {
                stringTemplate += ArrayCadastro[i].Name + "\r\n";
            }

            alert(stringTemplate);
            ClearScreen();
        });

        $('#save').click(function () {
            var NovoCadastro =
            {
                Email: $('#email').val(),
                Senha: $('#senha').val(),
                Login: $('#login').val(),
                Nome: $('#nome').val()


            }

            ArrayCadastro.push(NovoCadastro);
            var stringResult = "Cadastro salvo!\r\nEmail: " + NovoCadastro.email + "\r\nLogin: " + NovoCadastro.Login + " \r\nnome " + + NovoCadastro.Nome + "\r\nSenha: " + NovoCadastro.Senha;
            alert(stringResult);
            ClearScreen();

        });

    });
function ClearScreen() {
    var myInputs = $('input[type="text"]');
    myInputs.val("");
}



