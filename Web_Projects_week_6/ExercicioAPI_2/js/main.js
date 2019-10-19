var bicicleta = { marca: "Caloi", valor: 1000, peso: "70" };

$(document).ready(
    function() {

        $('input[name="marca"]').val(bicicleta.marca);
        $('input[name="valor"]').val(bicicleta.valor);
        $('input[name="peso"]').val(bicicleta.peso);



        $('input[name="btnCadastrar"]').click(function() {
            var marca = bicicleta.marca = $('input[name="marca"]').val();
            var valor = bicicleta.valor = $('input[name="valor"]').val();
            var peso = bicicleta.peso = $('input[name="peso"]').val();
            alert("\nMarca da Bicicleta " + marca + "\nValor da Bicicleta: " + valor + "\nPeso da Bicicleta: " + peso);

        });

        $('input[name="btnMostrar"]').click(function() {
            alert("\nMarca da Bicicleta " + bicicleta.marca + "\nValor da Bicicleta: " + bicicleta.valor + "\nPeso da Bicicleta: " + bicicleta.peso);

        });
    }
);