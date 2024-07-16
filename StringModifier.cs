public class StringModifier
{
    public string RemoveCharacterAtIndex(string text, int index)
    {
        if (index < 0 || index >= text.Length)
        {
            return text;
        }

        return text.Remove(index, 1);
    }
}
