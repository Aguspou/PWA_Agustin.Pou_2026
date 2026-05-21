var enlaces = document.querySelectorAll('.enlace-nav');
var secciones = document.querySelectorAll('.seccion-pagina');
var botonInicio = document.querySelector('.boton-hero');
var botonesCalcular = document.querySelectorAll('.boton-calcular');

function mostrarSeccion(cualSeccion) {

    for (var i = 0; i < secciones.length; i++) {
        secciones[i].classList.remove('activo');
    }


    // muestro solo la que quiero
    var seccion = document.getElementById(cualSeccion);
    seccion.classList.add('activo');

    //Act
    for (var i = 0; i < enlaces.length; i++) {
        enlaces[i].classList.remove('activo');
        if (enlaces[i].getAttribute('data-pagina') == cualSeccion) {
            enlaces[i].classList.add('activo');
        }
    }

    window.scrollTo(0, 0);
}

//SPA
for (var i = 0; i < enlaces.length; i++) {
    enlaces[i].onclick = function (evento) {
        evento.preventDefault();
        var pag = this.getAttribute('data-pagina');
        mostrarSeccion(pag);
    }
}


if (botonInicio) {
    botonInicio.onclick = function () {
        var pag = this.getAttribute('data-pagina');
        mostrarSeccion(pag);
    }
}

var formulario = document.getElementById('formularioContacto');

if (formulario) {
    formulario.onsubmit = function (evento) {
        evento.preventDefault();

        var nombre = document.getElementById('nombre').value;
        var email = document.getElementById('email').value; // Este es el correo destino
        var guitarra = document.getElementById('guitarra').value;
        var mensaje = document.getElementById('mensaje').value;

        var cuerpoMensaje = "¡Hola " + nombre + "! Gracias por tu consulta." + "%0D%0A%0D%0A" +
            "Aquí tienes la copia de tu mensaje enviado a Guitar Vault:" + "%0D%0A" +
            "-----------------------------" + "%0D%0A" +
            "Tu Nombre: " + nombre + "%0D%0A" +
            "Tu Email: " + email + "%0D%0A" +
            "Guitarra de Interés: " + guitarra + "%0D%0A" +
            "Mensaje Enviado: " + mensaje;

        var mailtoLink = "mailto:" + email +
            "?subject=Copia de tu Consulta a Guitar Vault&body=" + encodeURIComponent(cuerpoMensaje);


        window.open(mailtoLink, '_self');
        alert('Gracias ' + nombre + '! Se abrirá tu programa de correo para que puedas enviarte una copia del mensaje a tu email (' + email + ').');

        formulario.reset();

    }
}

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


// para ver si lee bien la pagina
// console.log(cualSeccion);