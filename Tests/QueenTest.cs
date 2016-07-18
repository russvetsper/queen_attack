using Xunit;
using ChessMove.Objects;

namespace ChessMove
{
  public class ChessMoveTest
  {
    [Fact]
    public void CanAttack_ForMatchingX_true()
    {
      Queen testQueen = new Queen(4,1);
      Assert.Equal(true, testQueen.CanAttack(4, 5));
    }
  }
}
