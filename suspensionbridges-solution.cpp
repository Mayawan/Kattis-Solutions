#include <iostream>
#include <cmath>
using namespace std;
typedef long double ld;
const long long inf = 1e18 + 10;
const ld prec = 0.000000000001;
ld LDsinh(ld x){
  return (exp(x) - exp(-x))/2;
}

ld LDcosh(ld x){
  return (exp(x) + exp(-x))/2;
}

bool funcCheck(ld a, ld d, ld s){
  return a + s >= a * LDcosh(d/(2 * a));
}
int main() {
  ld d, s;
  cin >> d >> s;
  ld low = 0;
  ld high = inf;
  while (high - low > prec){
    ld mid = (high + low) / 2;
    if (funcCheck(mid, d, s)) high = mid;
    else low = mid;
  }
  ld a = high;
  ld ans = 2 * a * LDsinh(d/(2*a));
  cout << fixed;
  cout.precision(9);
  cout << ans;
}
