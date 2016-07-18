using Xunit;
using ChessMove.Objects;

namespace ChessMove
{
  public class ChessMoveTest
  {
    [Fact]
    public void CanAttack_ForMatchingX_true()
    {
      Queen testQueen = new Queen(1,1);
      Assert.Equal(true, testQueen.CanAttack(1, 2));
    }
    [Fact]
    public void CanAttack_ForNonMatchingX_false()
    {
      Queen testQueen = new Queen(1,1);
      Assert.Equal(false, testQueen.CanAttack(2,3));
    }
    [Fact]
    public void CanAttack_ForMatchingY_true()
    {
      Queen testQueen = new Queen(4,8);
      Assert.Equal(true, testQueen.CanAttack(5,8));
    }
    [Fact]
    public void CanAttack_ForMatchingDiag_true()
    {
      Queen testQueen = new Queen(1,1);
      Assert.Equal(true, testQueen.CanAttack(8,8));
    }
  }
}
