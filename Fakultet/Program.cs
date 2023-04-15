var result = BeregnFakultet(6);
Console.WriteLine(result);

int BeregnFakultet(int n)
{
    return n == 0 ? 1 : n * BeregnFakultet(n - 1);
}