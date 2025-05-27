[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/24pP-Pw_)
# ¿String es una tipo por valor o un tipo por referencia?
Es un tipo por referencia.

# ¿Qué secuencias de escape tiene el tipo string?
Las secuencias de escape que tiene el tipo string (caracteres especiales que se representan con una barra invertida (`\`) seguida de un carácter que tiene un significado especial dentro de una cadena) más comunes en C# son:
- `\\`: Barra invertida literal.
- `\"`: Comilla doble literal.
- `\n`: Nueva línea.
- `\r`: Retorno de carro.
- `\t`: Tabulación horizontal.
- `\v`: Tabulación vertical.
- `\0`: Carácter nulo.
- `\'`: Comilla simple literal.

# ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
- Cuando se usa el @ delante de una cadena, se ignora los caracteres de escape, como \n, \t, etc.
- Cuando se usa $, se puede incluir variables o expresiones dentro de una cadena de texto, usando {}.