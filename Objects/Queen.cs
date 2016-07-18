using System.Collections.Generic;

namespace ChessMove.Objects
{
  public class Queen
  {
    private int _x_queen;
    private int _y_queen;

    public Queen(int x, int y)
    {
      _x_queen = x;
      _y_queen = y;
    }

    public bool CanAttack(int x, int y)
    {
      int _x_other = x;
      int _y_other = y;
      return false;
    }
  }
}
