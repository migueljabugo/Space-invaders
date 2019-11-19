# Space invaders

## Two-line
El juego consiste en matar naves enemigas, mientras tienes que esquivar los disparos de los enemigos. El jugador tiene 3 vidas. Vas ganando puntos matando a los enemigos.




## Ganar o perder
* Ganar-> No se gana nunca
* Perder-> Se pierde una vez se pierdan las 3 vidas.




## Elementos del juego
- 3 vidas
- 5 tipos de enemigos: Se mueven horizontal y vertical, cada vez que hace dos ciclos en horizontal bajan una posición. Disparan al jugador. Cada enemigo muere con un disparo recibido. Si el jugador elimina una fila de enemigos los enemigos bajan una fila. 
  - Invasor grande : 10 puntos.
  - Invasor medio : 20 puntos.
  - Invasor pequeño : 30 puntos.
  - OVNI (No dispara, actúa como bono y aparece siempre en la parte superior) : entre 50 y 300 puntos.
  -BOSS (Jefe final. Al matar a todos los invasores, aparecerá el jefe final con algunos invasores a su lado y dispararán ambos.)


Los puntos que da el OVNI depende del número de disparos que has hecho. Para que de 300 puntos el disparo con el que le derribas es el número 23, 38, 53, etc. (progresando de 15 en 15)
  - Escudos: habrá un determinado número y se destruirán al recibir 3 disparos de los enemigos.
  - Los invasores se van moviendo cada vez más rápido.
  - puntuación.
  - Los disparos : Solo se podrá disparar una vez hasta que colisione la bala con un invasor o llegue hasta arriba.
  - Texto Game Over
  - Texto score
  - Texto High-score
  - nave del jugador: tiene 3 vidas y se pierde una con cada disparo recibido. Se mueve horizontalmente. Al salir por el límite de la izquierda, aparece en la derecha, y viceversa.

# Caracteristicas
- Juego en 2D
- Ranking score




# Scripts
- Script generador de invaders
- Script ScoreManager
- Script ScoreText

