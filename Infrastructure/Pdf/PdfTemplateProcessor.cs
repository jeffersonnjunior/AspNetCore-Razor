using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Infrastructure.Pdf;

public static class PdfTemplateProcessor
{
    public static string ReplacePlaceholders(string template, IDictionary<string, string> values)
    {
        if (string.IsNullOrEmpty(template) || values == null)
            return template;

        return Regex.Replace(template, @"\{\{(\w+)\}\}", match =>
        {
            var key = match.Groups[1].Value;
            return values.TryGetValue(key, out var value) ? value : match.Value;
        });
    }
}