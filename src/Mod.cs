using System.Drawing;
using GMSL;
using Underanalyzer;
using UndertaleModLib;
using UndertaleModLib.Util;
using UndertaleModLib.Models;

namespace forceresolution;

public class Mod : GMSLMod
{
    // Runs when patching the game when changes are detected.
    public override void Patch()
    {
        Console.WriteLine($"[forceResolution]: Adding code...");
        AddCode();
    }

    // Runs before every startup.
    public override void Start() {}

    public void AddCode()
    {
        HookCodeFromFile("fix_song_select_shift_bug.gml", "gml_Object_o_songselect_Create_0");
        CreateObjectCodeFromFile("fix_songobject_leak.gml", "o_songobject", EventType.CleanUp);
    }
}
