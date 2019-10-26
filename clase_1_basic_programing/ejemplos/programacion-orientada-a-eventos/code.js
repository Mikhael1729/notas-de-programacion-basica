class Calculadora {
  sumatoria(inicio, fin) {
    let total = 0;

    for (let i = 0; i <= fin; i++) {
      total = total + i;
    }

    return total;
  }
}

// function sumatoriaDeclarativa(inicio, fin, i=0) {
//   if (i > fin)
//     return 0;

//   return inicio + i + sumatoriaDeclarativa(inicio, fin, i+1);;
// }

function sumatoria() {
  // Instanciando calculadora.
  let calculadora = new Calculadora();

  // Obteniendo valores de los campos de texto.
  let inicio = parseInt(document.getElementById("inicio").value, 10);
  let fin = parseInt(document.getElementById("fin").value, 10);

  // Realizando la suma en el rango indicado usando la calculadora.
  let total = calculadora.sumatoria(inicio, fin);

  // console.log('total -->', sumatoriaDeclarativa(inicio, fin));

  // Mostrando valor en el contendor.
  let div = document.getElementById("resultado");
  div.innerHTML = total;
}

