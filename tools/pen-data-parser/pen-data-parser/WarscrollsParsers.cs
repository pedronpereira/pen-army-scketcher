using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace pen_data_parser
{
    internal class WarscrollsParsers
    {
        public List<Warscroll> Parse(string resource)
        {
            var result = new List<Warscroll>();

            using (var fileStream = new FileStream(resource, FileMode.Open, FileAccess.Read))
            {
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        if (line.StartsWith("- "))
                        {
                            var parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                            var warscroll = GetWarscroll(parts);

                            if(warscroll == null) continue;

                            result.Add(warscroll);
                        }

                    }
                }
            }

            return result;
        }

        private Warscroll GetWarscroll(string[] parts)
        {
            var warscroll = new Warscroll();
            int nextIndex = GetName(parts, 1, warscroll);

            warscroll.UnitSizeMin = GetInt(parts[nextIndex]);
            warscroll.UnitSizeMax = GetInt(parts[++nextIndex]);
            warscroll.Points = GetInt(parts[++nextIndex]);

            if (parts.Length > nextIndex+1 && !string.IsNullOrEmpty(parts[nextIndex+1]))
            {
                warscroll.Role = parts[++nextIndex].Replace(",", string.Empty);
                warscroll.Notes = string.Join(" ", parts.Skip(nextIndex));
            }

            return warscroll;
        }

        private static int GetInt(string s)
        {
            int.TryParse(s, out var size);
            return size;
        }

        private static int GetName(string[] parts, int startIndex, Warscroll warscroll)
        {
            var name = string.Empty;
            for (var index = startIndex; index < parts.Length; index++)
            {
                var t = parts[index];
                int k = 0;

                if (int.TryParse(t, out k))
                {
                    warscroll.Name = name.TrimStart();
                    return index;
                }

                name += $" {t}";
            }

            return -1;
        }
    }

    internal class Warscroll
    {
        public string Name { get; set; }
        public int UnitSizeMin { get; set; }
        public int UnitSizeMax { get; set; }
        public int Points { get; set; }
        public string Role { get; set; }
        public string Notes { get; set; }
    }
}
