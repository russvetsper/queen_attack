using System.Collections.Generic;

namespace ChessMove.Objects
{
  public class Queen
  {
    private int _x_queen;
    private int _y_queen;
    private bool _attackStatus;

    public Queen(int x, int y)
    {
      _x_queen = x;
      _y_queen = y;
      _attackStatus = false;
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

    public bool GetAttackStatus()
    {
      return _attackStatus;
    }
    public void SetAttackStatus(bool newAttack)
    {
      _attackStatus = newAttack;
    }

    public bool CanAttack(int x_Other, int y_Other)
    {
      int x_Queen = this.GetX_Queen();
      int y_Queen = this.GetY_Queen();

      if (x_Queen == x_Other)
      {
        return true;
      }
      else if (y_Queen == y_Other)
      {
        return true;
      }
      else if (
        (y_Queen - y_Other) ==
        ((x_Queen - x_Other) / (y_Queen - y_Other)) *
        (x_Queen - x_Other)
      )
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
