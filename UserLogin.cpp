// Manuel Lago
/* Program asks the user to enter username and password up to 3 times
 * until it is valid. If he fails 3 times, the program ends with an
 * error message */

#include <iostream>

using namespace std;

int main()
{
    string user, password;
    const string validUser = "manuel", validPassword = "1234";
    int times = 0;
    
    do
    {
        cout << "Enter your username: ";
        cin >> user;
        
        cout << "Enter your password: ";
        cin >> password;
        
        if (( user == validUser ) && ( password == validPassword ))
        {
            times = 3;
            cout << "User & password correct";
        }
        else
        {
            cout << "User or password not correct" << endl;
            times++;
        }
    } while ( times != 3 );
    return 0;
}
