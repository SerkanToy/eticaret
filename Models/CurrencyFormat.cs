using System.Globalization;

namespace eticaret.Models
{
    public class CurrencyFormat
    {
        public CurrencyFormat() { }
        public void Currency() {
            CultureInfo ci = new CultureInfo("tr-TR", false);

            // Output floating point values
            double floating = 3.40822;
            Console.WriteLine($"C: {floating.ToString("C05", ci)}");           // Displays "C: $10,761.94"
            Console.WriteLine($"E: {floating.ToString("E03", ci)}");         // Displays "E: 1.076E+004"
            Console.WriteLine($"F: {floating.ToString("F04", ci)}");         // Displays "F: 10761.9376"
            Console.WriteLine($"G: {floating.ToString("G", ci)}");           // Displays "G: 10761.937554"
            Console.WriteLine($"N: {floating.ToString("N03", ci)}");         // Displays "N: 10,761.938"
            Console.WriteLine($"P: {(floating / 10000).ToString("P02", ci)}"); // Displays "P: 107.62 %"
            Console.WriteLine($"R: {floating.ToString("R03", ci)}");           // Displays "R: 10761.937554"
            Console.WriteLine();

            // Output integral values
            int integral = 340822;
            Console.WriteLine($"C: {integral.ToString("C02", ci)}");           // Displays "C: $8,395.00"
            Console.WriteLine($"D: {integral.ToString("D06", ci)}");          // Displays "D: 008395"
            Console.WriteLine($"E: {integral.ToString("E03", ci)}");         // Displays "E: 8.395E+003"
            Console.WriteLine($"F: {integral.ToString("F01", ci)}");         // Displays "F: 8395.0"
            Console.WriteLine($"G: {integral.ToString("G", ci)}");           // Displays "G: 8395"
            Console.WriteLine($"N: {integral.ToString("N01", ci)}");         // Displays "N: 8,395.0"
            Console.WriteLine($"P: {integral.ToString("P02", ci)}"); // Displays "P: 83.95 %"
            Console.WriteLine($"X: 0x{integral.ToString("X", ci)}");           // Displays "X: 0x20CB"
            Console.WriteLine();

        }
    }
}
