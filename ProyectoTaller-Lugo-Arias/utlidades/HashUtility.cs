using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;


namespace ProyectoTaller_Lugo_Arias.utlidades
{
    public static class HashUtility
    {
        // Método para crear un hash de una cadena de texto
        public static byte[] GetHash(string inputString)
        {
            using (HashAlgorithm algorithm = SHA512.Create())
            {
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
            }
        }

        // Método para comparar dos hashes
        public static bool VerifyHash(string inputString, byte[] storedHash)
        {
            byte[] inputHash = GetHash(inputString);
            for (int i = 0; i < inputHash.Length; i++)
            {
                if (inputHash[i] != storedHash[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
