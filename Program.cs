//Escribe un porgrama capaz de decodicficar Rot-13, ignorando minúsculas y puntuación.
Console.WriteLine("Escribe el mensaje cifrado (EN MAYÚSCULAS): ");
string cipher = Console.ReadLine();
string mensaje = Decipher(cipher);
Console.WriteLine("La oración descifrada es: " + mensaje);
static string Decipher(string cipher)
{
    char[] ch = cipher.ToCharArray();
    for (int i = 0; i < ch.Length; i++)
    {
        int letra = Convert.ToInt32(ch[i]);
        if (letra >= 'A' &&  letra <= 'Z')
        {
            if (letra > 'M')
            {
                letra -= 13;
            }
            else
            {
                letra += 13;
            }
        }
        ch[i]=Convert.ToChar(letra);
    }
    return new string(ch);
}