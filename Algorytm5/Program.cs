List<string> listOfWords = new List<string>() { "eat", "ate", "apt", "pat", "tea", "now" };

var listOfGroupAnagram = GetAllAnagramsGroupFromList(listOfWords);

foreach(var group in listOfGroupAnagram)
{
    foreach(var word in group)
    {
        Console.Write($"{word},");
    }
    Console.WriteLine();
}

List<IGrouping<string,string>> GetAllAnagramsGroupFromList(List<string> words)
{
    return words.GroupBy(word => word = string.Concat(word.OrderBy(ch => ch))).ToList();
}
