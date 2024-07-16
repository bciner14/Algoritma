public class InputParser
{
    public (string, int) ParseInput(string input)
    {
        var parts = input.Split(',');
        if (parts.Length != 2)
        {
            throw new ArgumentException("Invalid input format. Expected format: <string>,<index>");
        }

        string text = parts[0];
        if (!int.TryParse(parts[1], out int index))
        {
            throw new ArgumentException("Invalid index value.");
        }

        return (text, index);
    }
}
