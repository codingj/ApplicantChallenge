var result = BeregnFakultet(0);
Console.WriteLine(result);

int BeregnFakultet(int n)
{
    return n == 0 ? 1 : n * BeregnFakultet(n - 1);
}