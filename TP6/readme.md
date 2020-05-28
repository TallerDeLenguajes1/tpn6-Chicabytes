##�String es una tipo por valor o un tipo por referencia?
Aunque string es un tipo de referencia, se definen los operadores de igualdad == y != para comparar los valores de los objetos string, no las referencias. Esto hace que las pruebas de igualdad entre cadenas sean m�s intuitivas. Las cadenas son inmutables: el contenido de un objeto de cadena no se puede modificar una vez creado el objeto, aunque la sintaxis parezca indicar que se puede hacer. 

##�Qu� secuencias de escape tiene el tipo string?
Las secuencias de escape son:
```bash
\ '- comilla simple (0x0027)
\ "- comillas dobles (0x0022)
\\ - barra invertida (0x005C)
\ 0 - nulo (0x0000)
\ a - alerta (0x0007)
\ b - retroceso (0x0008)
\ f - alimentaci�n de formulario (0x000C)
\ n - nueva l�nea (0x000A)
\ r - retorno de carro (0x000D)
\ t - pesta�a horizontal (0x0009)
\ v - pesta�a vertical (0x000B)
\ u0000 - \ uFFFF - Car�cter Unicode
\ x0 - \ xFFFF - Car�cter Unicode (c�digo con longitud variable)
\ U00000000 - \ U0010FFFF - Car�cter Unicode (para generar sustitutos)
```
##�Qu� sucede cuando utiliza el car�cter @ antes de una cadena de texto?
El car�cter @ act�a como prefijo de un elemento de c�digo que el compilador debe interpretar como un identificador en lugar de como una palabra clave de C#.