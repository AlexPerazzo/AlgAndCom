using System.Numerics;
using System.Runtime;

namespace AlgorithmLib;

public class RSA
{
    private static (BigInteger, BigInteger, BigInteger) Euclid(BigInteger a, BigInteger b)
    {
        // ADD CODE HERE AND FIX RETURN STATEMENT
        if (b == 0)
        {
            return (a, 1, 0);
        }

        (var gcd, var i, var j) = Euclid(b, a % b);
        return (gcd, j, i - ((a / b) * j));
        
        // return (-1, -1, -1);
    }

    private static BigInteger ModularExponentiation(BigInteger x, BigInteger y, BigInteger n)
    {
        // ADD CODE HERE AND FIX RETURN STATEMENT
        if (y == 0)
        {
            return 1;
        }

        if (y % 2 == 0)
        {
            var z = ModularExponentiation(x, y / 2, n);
            return (z * z) % n;
        }
        else
        {
            var z = ModularExponentiation(x, (y - 1) / 2, n);
            return (z * z * x) % n;
        }
        // return -1;
    }

    public static BigInteger GeneratePrivateKey(BigInteger p, BigInteger q, BigInteger e) 
    {
        // ADD CODE HERE AND FIX RETURN STATEMENT
        var r = (p - 1) * (q - 1);
        (var gcd, var i, var _) = Euclid(e, r);

        //C# doesn't handle negative mod properly, so we have to make sure it's positive
        if (i < 0)
        {
            i += r;
        }
        return i % r;
    }

    public static BigInteger Encrypt(BigInteger value, BigInteger e, BigInteger n)
    {
        return ModularExponentiation(value, e, n);
    }

    public static BigInteger Decrypt(BigInteger value, BigInteger d, BigInteger n)
    {
        
        return ModularExponentiation(value,d,n);
    }


}