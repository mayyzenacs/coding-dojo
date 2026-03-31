#include <stdio.h>
#include <stdlib.h>



int main(void) {

	int a = 10; 
	int *p1 = &a;
	int **p2 = &p1;
	
	printf("a: %d, &a = %p\n", a, &a);
	printf("p1: %d, &p1 = %p", p1, &p1);

	

	return 0;
}
