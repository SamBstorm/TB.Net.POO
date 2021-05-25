using System;

namespace TB.Net.POO.Delegues
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Démo Micro-Onde
            //Microonde mo = new Microonde();

            //switch (Console.ReadLine())
            //{
            //    case "1":
            //        mo.Program += mo.Defrost;
            //        break;
            //    case "2":
            //        mo.Program += mo.Grill;
            //        break;
            //    case "3":
            //        mo.Program += mo.Reheat;
            //        break;
            //    default:
            //        break;
            //}
            //mo.Program(); 
            #endregion
            #region Lecteur CD
            //CompactDisc CD = new CompactDisc(0, 120, 240, 360, 480, 600, 720, 840, 960, 1080, 1200);
            //CompactDiscPlayer player = new CompactDiscPlayer();
            //player.CurrentDisk = CD;

            //player.AddTrack(player.SelectTrack(3));
            //player.AddTrack(player.SelectTrack(3));
            //player.AddTrack(player.SelectTrack(5));
            //player.AddTrack(player.SelectTrack(7));
            //player.AddTrack(player.SelectTrack(2));
            //player.AddTrack(player.SelectTrack(1));

            //player.Play(); 
            #endregion

            #region IDE avec plug-in
            VisualStudioCode vsc = new VisualStudioCode(
                new VisualStudioCodeExtension { Name ="C# easy refactoring"},
                new VisualStudioCodeExtension { Name ="C# compilator"},
                new VisualStudioCodeExtension { Name ="JS debugger"},
                new VisualStudioCodeExtension { Name ="Angular debugger"},
                new VisualStudioCodeExtension { Name ="Launch in browser"}
                );
            #endregion
        }
    }
}
