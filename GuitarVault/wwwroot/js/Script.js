var botonesCalcular = document.querySelectorAll('.boton-calcular');

// FUNCIONALIDAD DE CÁLCULO SIMPLE (En Kilogramos)
function calcularTensionEstimada(tipo) {
    var tensionKg = 0;
    var unidad = "kilogramos (kg)";

    // Asignación de valores de tensión estimada en KILOGRAMOS, adaptados del cálculo anterior (libras / 2.2)
    if (tipo === 'clasica') {
        // Tensión total estimada de un juego de cuerdas de Nylon (low tension)
        tensionKg = 34 + Math.floor(Math.random() * 3);
    } else if (tipo === 'acustica') {
        // Tensión total estimada de un juego de cuerdas de Acero (light gauge)
        tensionKg = 72 + Math.floor(Math.random() * 5);
    } else if (tipo === 'electrica') {
        // Tensión total estimada de un juego de cuerdas de Acero Niquelado (super light gauge)
        tensionKg = 41 + Math.floor(Math.random() * 3);
    } else {
        return "No hay datos de tensión para este tipo.";
    }

    var resultado = tensionKg + " " + unidad;

    alert('Tensión Estimada para ' + tipo.toUpperCase() + ':\nLa tensión total promedio sobre el mástil es de ' + resultado + '.\n\n(Este es un valor simulado para ilustrar la fuerza que soporta el instrumento.)');
}

for (var i = 0; i < botonesCalcular.length; i++) {
    botonesCalcular[i].onclick = function () {
        var tipoGuitarra = this.getAttribute('data-tipo');
        calcularTensionEstimada(tipoGuitarra);
    }
}

