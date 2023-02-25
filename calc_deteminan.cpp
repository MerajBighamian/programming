#include <iostream>
using namespace std;

int main()
{
    int numbers[3][3];
    int determinan;

    // get items of array from user
    cout << "please enter number of array : " << endl;
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            cin >> numbers[i][j];
        }
    }


    determinan = (numbers[0][0] * ((numbers[1][1] * numbers[2][2]) - (numbers[1][2] * numbers[2][1]))) - (numbers[0][1] * ((numbers[1][0] * numbers[2][2]) - (numbers[1][2] * numbers[2][0]))) + (numbers[0][2] * ((numbers[1][0] * numbers[2][1]) - (numbers[1][1] * numbers[2][0])));

    


    cout << "determinan of this array is : " << determinan << endl;

    return 0;
}