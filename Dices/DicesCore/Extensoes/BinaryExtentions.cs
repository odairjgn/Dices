using System;

namespace DicesCore.Extensoes
{
    public static class BinaryExtentions
    {
        public static string GetB64FromByteArray(this byte[] data)
        {
            try
            {
                return Convert.ToBase64String(data);
            }
            catch
            {
                return null;
            }
        }

        public static byte[] GetByteArrayFromB64(this string data)
        {
            try
            {
                return Convert.FromBase64String(data);
            }
            catch
            {
                return null;
            }
        }
    }
}
