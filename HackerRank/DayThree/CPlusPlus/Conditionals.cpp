#include <bits/stdc++.h>

using namespace std;



int main()
{
    int N;
    cin >> N;
    cin.ignore(numeric_limits<streamsize>::max(), '\n');
    
    if(N %2 > 0){
        cout << "Weird" << endl;
    }
    
    if( N < 6  && N % 2 == 0){
         cout << "Not Weird" << endl;
    }
    
    if( N >= 6 && N <=20 && N % 2 == 0){
        cout << "Weird" << endl;
    }
    
    if( N > 20 && N % 2 == 0){
        cout << "Not Weird" << endl;
    }

    return 0;
}
