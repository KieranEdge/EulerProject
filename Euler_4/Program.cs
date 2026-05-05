using Euler_4.Helpers;

List<int> listOfProducts = ProductMultiplier.ReturnProductsInRange(100, 999);

int maxPalindromeProduct = 0;

foreach (int product in listOfProducts)
{
    if (PalindromeChecker.IsThisNumberAPalindrome(product))
    {
        if(product > maxPalindromeProduct)
        {
            maxPalindromeProduct = product;
        }
    }
}

Console.WriteLine(maxPalindromeProduct);