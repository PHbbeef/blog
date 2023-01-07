# include<iostream>

void memory_dump(void *ptr, int len)
 {
    int i;
    printf("%p\n", ptr);
    for (i = 0; i < len; i++) {
        if (i % 8 == 0 && i != 0)
            printf(" ");
        if (i % 16 == 0 && i != 0)
            printf("\n");
        printf("%02x ", *((uint8_t *)ptr + i));
    }
    printf("\n");
 }

int main()
{
    using namespace std;

    char A = 8;
    char B[A];
    cin.getline(B,A);
    memory_dump(&B,sizeof(B));
    cout << B << endl;
}