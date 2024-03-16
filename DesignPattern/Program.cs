using System;
using DesignPattern.Builder_Pattern.facadeBuilder;

namespace DesignPattern;




internal class Program
{
    private static void Main(string[] args)
    {
        var pb = new PersonBuilder();
        var person = pb
            .Lives.At("Meethadid")
                  .In("Mansourah")
                  .WithPostCode("123")
            .Works.At("Amazon")
                  .AsA("Lawyer")
                  .Earning(150000);

    }
}