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

    public int GetX_Queen()
    {
      return _x_queen;
    }
    public void SetX_Queen(int newX)
    {
      _x_queen = newX;
    }

    public int GetY_Queen()
    {
      return _y_queen;
    }
    public void SetY_Queen(int newY)
    {
      _y_queen = newY;
    }

    public bool CanAttack(int x, int y)
    {
      int _x_other = x;
      int _y_other = y;
      return false;
    }
  }
}
