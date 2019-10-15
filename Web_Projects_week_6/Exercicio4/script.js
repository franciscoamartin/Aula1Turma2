
$(document).ready(
  function(){
    $('input[name="cpf"]').mask("000.000.000-00");
    $('input[type="button"]').click(function(){
      var idade = $('input[name="idade"]').val();
      var nome = $('input[name="nome"]').val();
      var cpf = $('input[name="cpf"]').val();

      if (nome.length > 1 && idade.length > 1 && cpf.length == 14) {
        alert("O formulario foi preenchido com sucesso");
        $('input[name="idade"]').val("");
        $('input[name="nome"]').val("");
        $('input[name="cpf"]').val("");

      }else{
        alert("Preencha os dados corretamente");
      }
    });
  }
);
