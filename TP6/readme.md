##¿String es una tipo por valor o un tipo por referencia?
Aunque string es un tipo de referencia, se definen los operadores de igualdad == y != para comparar los valores de los objetos string, no las referencias. Esto hace que las pruebas de igualdad entre cadenas sean más intuitivas. Las cadenas son inmutables: el contenido de un objeto de cadena no se puede modificar una vez creado el objeto, aunque la sintaxis parezca indicar que se puede hacer. 

##¿Qué secuencias de escape tiene el tipo string?
Las secuencias de escape son:
```bash
\ '- comilla simple (0x0027)
\ "- comillas dobles (0x0022)
\\ - barra invertida (0x005C)
\ 0 - nulo (0x0000)
\ a - alerta (0x0007)
\ b - retroceso (0x0008)
\ f - alimentación de formulario (0x000C)
\ n - nueva línea (0x000A)
\ r - retorno de carro (0x000D)
\ t - pestaña horizontal (0x0009)
\ v - pestaña vertical (0x000B)
\ u0000 - \ uFFFF - Carácter Unicode
\ x0 - \ xFFFF - Carácter Unicode (código con longitud variable)
\ U00000000 - \ U0010FFFF - Carácter Unicode (para generar sustitutos)
```
##¿Qué sucede cuando utiliza el carácter @ antes de una cadena de texto?
El carácter @ actúa como prefijo de un elemento de código que el compilador debe interpretar como un identificador en lugar de como una palabra clave de C#.