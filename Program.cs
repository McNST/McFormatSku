using TextCopy;

Console.Clear();
Console.WriteLine("Formatiere die Fehler Sku's und Lade in Clipboard:");
Console.WriteLine(FormatSKU() );


Console.WriteLine("\nFormatiere die Minus Bestand Sku's und Lade in Clipboard:\n");
Console.WriteLine(FormatSKU());

Console.WriteLine("\nFormatiere die Falschdatum Sku's und Lade in Clipboard:\n");
Console.WriteLine(FormatSKU());

string FormatSKU()
{
    string AllSku = "";
    string ReadSKU;
    string[] sku;
    bool whilebool = true;
    Console.WriteLine("Gebe die Liste der Sku´s an (Press ENDE to Confirm)");
    do
    {
        var Keyinfo = Console.ReadKey(true);
        if (Keyinfo.Key != ConsoleKey.End)
        {
            ReadSKU = Console.ReadLine();
            if (!string.IsNullOrEmpty(ReadSKU) && ReadSKU != "")
                AllSku += $"{ReadSKU},";
        }
        else
        { whilebool = false; }
    } while (whilebool);
    Console.Clear();
    sku = AllSku.Split(",");
    AllSku = "";
    foreach (string skuItem in sku)
    {
        if (!string.IsNullOrEmpty(skuItem) && skuItem != "")
        {
            //Console.Write($"{skuItem}|");
            AllSku += $"{skuItem}|";
        }
    }
    ClipboardService.SetText(AllSku);

    return AllSku;
}
