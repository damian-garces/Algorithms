public class AlienDictionary
{
  public bool IsAlienSorted(List<string> words, string order)
  {
    int wordsLength = words.Count;
    Dictionary<char, int> orderMap = new Dictionary<char, int>();

    // Crear el mapa de orden en O(1)
    for (int i = 0; i < order.Length; i++)
    {
      orderMap[order[i]] = i;
    }

    // Comparar pares de palabras en O(n * m)
    for (int i = 0; i < wordsLength - 1; i++)
    {
      string word1 = words[i];
      string word2 = words[i + 1];
      int minLength = Math.Min(word1.Length, word2.Length);
      
      bool isSorted = false; 

      for (int j = 0; j < minLength; j++)
      {
        int order1 = orderMap[word1[j]];
        int order2 = orderMap[word2[j]];

        if (order1 < order2)
        {
          isSorted = true;
          break; // Se confirma el orden correcto, no hay necesidad de seguir
        }
        else if (order1 > order2)
        {
          return false; // Orden incorrecto, se puede salir inmediatamente
        }
      }

      // Si word1 es prefijo de word2 pero más largo, está mal ordenado
      if (!isSorted && word1.Length > word2.Length)
      {
        return false;
      }
    }

    return true;
  }
}