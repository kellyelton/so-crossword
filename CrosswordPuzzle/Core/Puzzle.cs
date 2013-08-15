namespace CrosswordPuzzle.Core
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Puzzle
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public IEnumerable<PuzzleWord> Words { get; set; }

        public Puzzle()
        {
            Width = 10;
            Height = 10;
            Words = new List<PuzzleWord>();
        }
    }

    public class PuzzleWord
    {
        public int Id { get; set; }
        public int X { get; set; } 
        public int Y { get; set; }
        public string Word { get; set; }
        public string Hint { get; set; }
        public EnumWordDirection Direction { get; set; }

    }

    public enum EnumWordDirection
    {
        Across,
        Down
    }

    public interface IPuzzleSerializer<T>
    {
        Puzzle Deserialize(T puzzle);

        T Serialize(Puzzle puzzle);
    }

    public class TextPuzzleSerializer : IPuzzleSerializer<string>
    {
        public Puzzle Deserialize(string puzzle)
        {
            var ret = new Puzzle();
            using (var sr = new StringReader(puzzle))
            {
                var line = sr.ReadLine();
                while (line != null)
                {
                    line = line.Trim();
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    var firstChar = line[0];
                    if(Char.IsPunctuation(firstChar) || Char.IsLetter(firstChar))
                    {
                        // Read word

                    }
                    else if (Char.IsDigit(firstChar))
                    {
                        // Read details

                    }
                }
            }
        }

        public string Serialize(Puzzle puzzle)
        {
            throw new System.NotImplementedException();
        }
    }
}
