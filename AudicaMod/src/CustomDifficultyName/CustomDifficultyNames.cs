using MelonLoader;
using UnityEngine;
using TMPro;
using System.Collections;
using Harmony;
using System;
using System.Linq;

//[assembly: MelonOptionalDependencies("CustomSongDataLoader")]


namespace AudicaModding
{
    public class CustomDifficultyNames : MelonMod
    {
        public static IEnumerator ChangeNamesLP(LaunchPanel __instance)
        {
            yield return new WaitForSeconds(0.05f);

            var song = SongDataHolder.I.songData;

            if (!CustomSongDataLoader.SongHasCustomData(song.songID))
                yield break;

            if (CustomSongDataLoader.SongHasCustomDataKey(song.songID, "customExpert"))
            {
                __instance.expert.GetComponentInChildren<TextMeshPro>().text = CustomSongDataLoader.GetCustomData<string>(song.songID, "customExpert");
            }
            else
            {
                __instance.expert.GetComponentInChildren<TextMeshPro>().text = "Expert";
            }

            if (CustomSongDataLoader.SongHasCustomDataKey(song.songID, "customAdvanced"))
            {
                __instance.hard.GetComponentInChildren<TextMeshPro>().text = CustomSongDataLoader.GetCustomData<string>(song.songID, "customAdvanced");
            }
            else
            {
                __instance.hard.GetComponentInChildren<TextMeshPro>().text = "Advanced";

            }

            if (CustomSongDataLoader.SongHasCustomDataKey(song.songID, "customModerate"))
            {
                __instance.normal.GetComponentInChildren<TextMeshPro>().text = CustomSongDataLoader.GetCustomData<string>(song.songID, "customModerate");
            }
            else
            {
                __instance.normal.GetComponentInChildren<TextMeshPro>().text = "Moderate";

            }

            if (CustomSongDataLoader.SongHasCustomDataKey(song.songID, "customBeginner"))
            {
                __instance.easy.GetComponentInChildren<TextMeshPro>().text = CustomSongDataLoader.GetCustomData<string>(song.songID, "customBeginner");
            }
            else
            {
                __instance.easy.GetComponentInChildren<TextMeshPro>().text = "Beginner";

            }
        }

        public static IEnumerator ChangeNamesDS(DifficultySelect __instance)
        {
            yield return new WaitForSeconds(0.05f);

            var song = SongDataHolder.I.songData;

            if (!CustomSongDataLoader.SongHasCustomData(song.songID))
                yield break;

            if (CustomSongDataLoader.SongHasCustomDataKey(song.songID, "customExpert"))
            {
                __instance.expert.label.SetText(CustomSongDataLoader.GetCustomData<string>(song.songID, "customExpert"));
            }
            else
            {
                __instance.expert.label.text = "Expert";
            }

            if (CustomSongDataLoader.SongHasCustomDataKey(song.songID, "customAdvanced"))
            {
                __instance.hard.label.SetText(CustomSongDataLoader.GetCustomData<string>(song.songID, "customAdvanced"));
            }
            else
            {
                __instance.hard.label.text = "Advanced";

            }

            if (CustomSongDataLoader.SongHasCustomDataKey(song.songID, "customModerate"))
            {
                __instance.normal.label.SetText(CustomSongDataLoader.GetCustomData<string>(song.songID, "customModerate"));
            }
            else
            {
                __instance.normal.label.text = "Moderate";

            }

            if (CustomSongDataLoader.SongHasCustomDataKey(song.songID, "customBeginner"))
            {
                __instance.easy.label.SetText(CustomSongDataLoader.GetCustomData<string>(song.songID, "customBeginner"));
            }
            else
            {
                __instance.easy.label.text = "Beginner";
            }



        }

        [HarmonyPatch(typeof(LaunchPanel), "OnEnable", new Type[0])]
        private static class DisplayCustomNameLP
        {
            private static void Prefix(LaunchPanel __instance)
            {
                if (MelonHandler.Mods.Any(it => it.Info.SystemType.Name == nameof(CustomSongDataLoader)))                {
                    IEnumerator coroutine = ChangeNamesLP(__instance);
                    MelonCoroutines.Start(coroutine);
                }
                else
                    MelonLogger.LogError("Custom Song Data mod not detected, Custom difficulty names will not run");
            }

        }

        [HarmonyPatch(typeof(DifficultySelect), "OnEnable", new Type[0])]
        private static class DisplayCustomNameDS
        {
            private static void Prefix(DifficultySelect __instance)
            {
                if (MelonHandler.Mods.Any(it => it.Info.SystemType.Name == nameof(CustomSongDataLoader)))
                {
                    IEnumerator coroutine = ChangeNamesDS(__instance);
                    MelonCoroutines.Start(coroutine);
                }
                else
                    MelonLogger.LogError("Custom Song Data mod not detected, Custom difficulty names will not run");
            }

    }
    }
}
