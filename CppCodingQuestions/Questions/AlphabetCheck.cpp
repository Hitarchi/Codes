#include<iostream>
#include<cstring>

using namespace std;

int main() {
    char str[];
    int count = 0, check;

    //loop to count the number of alphabets in str
    for(int i = 0; i <= strlen(str); ++i) {

        //check if srt[i] is an alphabet
        check = isalpha(str[i]);

        //increment count if str[i] is an alphabet
        if(check) {
            ++count;
        }
    }
    cout<<"Number of alphabet characters: "<<count<<endl;
    cout<<"Number of non-alphabetic characters: "<< strlen(str) - count;

    return 0;
}