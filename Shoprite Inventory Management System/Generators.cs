using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoprite_Inventory_Management_System
{
    internal class Generators
    {
        public Generators()
        {

        }
        public string randomPassword(int length)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringPassword = new char[length];
            var random = new Random();

            for (int index = 0; index < stringPassword.Length; index++)
            {
                stringPassword[index] = chars[random.Next(chars.Length)];
            }

            return new string(stringPassword);
        }

        public string randomPincode(int length)
        {
            var chars = "0123456789";
            var stringPassword = new char[length];
            var random = new Random();

            for (int index = 0; index < stringPassword.Length; index++)
            {
                stringPassword[index] = chars[random.Next(chars.Length)];
            }

            return new string(stringPassword);
        }

        public string randomProductcode(int length)
        {
            var chars = "AEIOU0123456789";
            var productPassword = new char[length];
            var random = new Random();

            for (int index = 0; index < productPassword.Length; index++)
            {
                productPassword[index] = chars[random.Next(chars.Length)];
            }

            return new string(productPassword);
        }
    }
}
