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
        Queen newQueen = new Queen(1,2);
        return View["coordinates_set.cshtml", newQueen];
      };
    }
  }
}
