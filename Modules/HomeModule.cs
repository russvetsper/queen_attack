using Nancy;
using System.Collections.Generic;
using ChessMove.Objects;
namespace ChessMove
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {

      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Post["/coordinates_set"] = _ => {
        Queen newQueen = new Queen(Request.Form["queen-x"], Request.Form["queen-y"]);
        if (newQueen.CanAttack(Request.Form["other-x"], Request.Form["other-y"]))
        {
          newQueen.SetAttackStatus(true);
        };
        return View["coordinates_set.cshtml", newQueen];
      };
    }
  }
}
