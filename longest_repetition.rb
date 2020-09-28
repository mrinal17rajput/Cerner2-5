#include<bits/stdc++.h>
//cerner_2^5_2020
using namespace std;

int main() {
   
    int t;
   
    cin >> t;
    int x = 1;
    while(t--) {
       
        bool ret = true;
        int n, a, b, c;
        cin >> n >> a >> b >> c;
        //a tells me how many buildings have height greater than arr[0]
        // b tells me how many buildings have height greater than arr[n-1]
       
        // 3 3 2
        // 1 5 5 1 2
        // first c location should have space so that the a values can be filled there
        int arr[n];
        for(int i = 0; i < n; i++) {
            arr[i] = n;
        }
       
        int a_minus_c = a - c;
       
        int b_minus_c = b - c;
       
        int a_space = a_minus_c;
       
        for(int i = 0; i < a_space; i++) {
            arr[i] = (i == 0) ? 1: arr[i-1] + 1;
        }
       
        int b_space = n - a; // space I have
        int b_extra = b_space - b_minus_c;
       
        if (b_extra < 0) {
            cout << "Case #" << x << ": IMPOSSIBLE\n";
            x++;
            continue;
        }
       
        int i = a;
        int num = 0;
        while(b_extra--) {
           
            arr[i] = (i == a) ? 1: arr[i-1] + 1;
            num = max(num, arr[i]);
            i++;
        }
        int p = i;

        while(b_minus_c--) {
            arr[i] = (i == p) ? num+1 : arr[i-1] - 1;
            i++;
        }
       
        cout << "Case #" << x << ":";
        for(auto m: arr) {
            cout << " " << m;
        }
       
        cout << "\n";
        x++;
       
    }
}