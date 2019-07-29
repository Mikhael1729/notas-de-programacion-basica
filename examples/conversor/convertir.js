convertir(n) {
  let list = [128, 64, 32, 16, 8, 4, 2, 1];
  let convertido = "";

  for(let i = 0; i <= 7; i++) {
    if(n - list[i] < 0) 
      convertido = convertido + '0';
    else
       convertido = convertido + '1';
  }

  return convertido;
}

let a = 15;
let b = convertir(15);

console.log(b);


