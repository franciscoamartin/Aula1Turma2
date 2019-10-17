
$(document).ready(
  function(){
    $('input[type="button"]').click(function(){
      var nome = $('input[name="nome"]').val();

      if (nome.length > 1) {
        $('input[name="nome"]').val("");
        $('#exampleModal').show();


      }else{
        alert("Preencha os dados corretamente");
      }
    });
  }
);
$('#exampleModal').on('show.bs.modal', function (e) {
  var nomes = $('#nome').val();
  $('#nome').html(nomes);
});
