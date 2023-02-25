#include <iostream>
using namespace std;

int main()
{
    int numbers[10][10];
    int choose_number_1, choose_number_2;
    int number_existed_1 = 0, number_existed_2 = 0;

    // get items of array from user
    cout << "please enter number of array : " << endl;
    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            cin >> numbers[i][j];
        }
    }

    cout << endl;
    cout << "please enter choose number 1: " << endl;
    cin >> choose_number_1;

    cout << "please enter choose number 2 : " << endl;
    cin >> choose_number_2;

    // search in array for exist chosen number
    for (int j = 0; j < 10; j++)
    {
        for (int i = 0; i < 10; i++)
        {
            if (numbers[i][j] == choose_number_1)
            {
                number_existed_1 += 1;
            }

            else if (numbers[i][j] == choose_number_2)
            {
                number_existed_2 += 1;
            }
        }
    }

    cout << "number of repeated chosen number 1 in this array is : " << number_existed_1 << endl;
    cout << "number of repeated chosen number 2 in this array is : " << number_existed_2 << endl;

    return 0;
}