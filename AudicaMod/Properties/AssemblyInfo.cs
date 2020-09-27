using System.Resources;
using System.Reflection;
using System.Runtime.InteropServices;
using MelonLoader;
using AudicaModding;

[assembly: AssemblyTitle("Custom Difficulty Names")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("MeepsKitten")]
[assembly: AssemblyProduct("Custom Difficulty Names Mod")]
[assembly: AssemblyCopyright("Created by MeepsKitten")]
[assembly: AssemblyTrademark("MeepsKitten")]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
//[assembly: Guid("")]
[assembly: AssemblyVersion("1.1.1")]
[assembly: AssemblyFileVersion("1.1.1")]
[assembly: NeutralResourcesLanguage("en")]
[assembly: MelonInfo(typeof(AudicaModding.CustomDifficultyNames), "Custom Difficulty Names", "1.0.0", "MeepsKitten")]


// Create and Setup a MelonModGame to mark a Mod as Universal or Compatible with specific Games.
// If no MelonModGameAttribute is found or any of the Values for any MelonModGame on the Mod is null or empty it will be assumed the Mod is Universal.
// Values for MelonModGame can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame("Harmonix Music Systems, Inc.", "Audica")]