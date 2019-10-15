
$(document).ready(
  function(){
    $('input[name="cpf"]').mask("000.000.000-00");
    $('input[type="button"]').click(function(){
      var idade = $('input[name="idade"]').val();
      var nome = $('input[name="nome"]').val();

      if (idade <= 18) {
        alert("O formulario nao aceita menores de 18 anos");
        window.location = "https://www.google.com.br";
      }else{
        alert("Ola " + nome + " bem vindo");
        window.location = "https://www.ambev.com.br";
      }
    });
  }
);
