#include <iostream>

using namespace std;

int digit_sum(int num)
{
  int sum = 0;
  while(num)
  {
    sum += num % 10;
    num /= 10;
  }

  return sum;
}

int main() {
  int l,d,x;
  cin >> l >> d >> x;

  for(int i = l; i <= d; i++)
  {
    if(digit_sum(i) == x)
    {
      cout << i << endl;
      break;
    }
  }

  for(int i = d; i >= l; i--)
  {
    if(digit_sum(i) == x)
    {
      cout << i << endl;
      break;
    }
  }
}
