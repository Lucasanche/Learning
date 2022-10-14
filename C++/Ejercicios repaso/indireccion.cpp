# include<iostream>
# include<cstdlib>
# include<cstdio>
# include<cstring>
# include <windows.h>
# include <ctime>
# include <wchar.h>

using namespace std;

main (){
	setlocale(LC_ALL, "");
    int a=4;
    int *b=&a;
    cout << *b << endl;

}
