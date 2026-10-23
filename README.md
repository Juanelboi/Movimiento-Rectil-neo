# Fundamentos del Desarrollo de Videojuegos
## Movimiento Rectilíneo

1.
a. ira dando pasos más pequeños que el Vector en si entero pero seguirá yendo al infinito al solo reducirse una vez el vector de direcc
b. Se ve como la capsula se mantiene en el suelo

c. Se observa como la capsula se mueve también en el eje y permanece en el aire

d. Modifique el script para que vaya incrementando la y del objetivo y vaya despegándose poco a poco del suelo. También cambié la multiplicación por Delta Time para que se pudiera apreciar mejor el movimiento
 
<img width="640" height="360" alt="vuelo" src="https://github.com/user-attachments/assets/54959a05-0cdb-4358-ab15-014eeb209224" />

*Despegue del objeto con `Translate`.*

---
2. 
a. Se mueve Igual que en los anteriores
b. ahora el cilindro se mueve a una velocidad reducida al normalizar el vector pero parece que va a tirones

<img width="640" height="360" alt="2b" src="https://github.com/user-attachments/assets/3077895f-50f4-49a8-b3bc-ba1768467de8" />

c. No cambie la velocidad de 0.1f por eso se ve la velocidad tan reducida pero ahora se mueve de manera fluida

<img width="640" height="360" alt="2c" src="https://github.com/user-attachments/assets/32443c9f-2818-4a9a-b0aa-9d81e413a2cf" />

---
3. Introduje una textura a la capsula para que se pudiera ver el el cambio de dirección que hace la capsula para dirigirse al punto

 <img width="640" height="360" alt="3" src="https://github.com/user-attachments/assets/0ed5e51a-ed4a-4eb4-8aff-bd28a2a000e1" />

 ---
 4. Aplico un draw ray para que se vea hacia dónde se dirige la capsula 

<img width="640" height="360" alt="4" src="https://github.com/user-attachments/assets/88f2e7e9-7f4a-4394-bd6d-d4db5e3dd538" />

---
5. Añadí el cubo con control de movimiento movimiento siendo este el target de la capsula y al darle al espacio le aumenta la velocidad 

<img width="1080" height="608" alt="5" src="https://github.com/user-attachments/assets/e3de9102-17dc-41a0-bf84-4e125ba18e6e" />

---
6.
