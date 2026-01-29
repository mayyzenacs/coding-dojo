#include <stdio.h>
#include <stdlib.h>

// O Conversor de Tempo Crie um programa que peça ao usuário um valor em segundos (ex: 7500) e o programa deve imprimir quanto isso vale em: Horas : Minutos : Segundos.


int main(void) {



	int seconds_entry;
	printf("Digite os segundos: "); 
	if (scanf("%d", &seconds_entry) != 1) {
		printf("Digite um numero válido");
		return 1;
	}

	int horas = seconds_entry / 3600;
	int minutos = (seconds_entry % 3600) / 60;
	int seconds = (seconds_entry % 3600) % 60;
	printf("%02d Horas %02d Minutos %02d Segundos\n", horas, minutos, seconds);


	return 0;
}
