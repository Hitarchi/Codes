using System;
public class CheckVowels {
    public static void Main(string[] args) {
        String str;
        int i,len,vowel;
        str = "Welcome to the world of c#";
        vowel = 0;
        len = str.Length();
        for(i=0; i<len; i++) {
            if(str[i]=='a' ||str[i]=='e' ||str[i]=='i' ||str[i]=='o' ||str[i]=='u'
            str[i]=='A' ||str[i]=='E' ||str[i]=='I' ||str[i]=='O' ||str[i]=='U')
            {
                vowel++;
            }
        }
        Console.WriteLine("Vowels in a string: "+vowel);
    }
}