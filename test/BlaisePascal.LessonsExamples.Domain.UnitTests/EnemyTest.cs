namespace BlaisePascal.LessonsExamples.Domain.UnitTests
{
    public class EnemyTest
    {
        [Fact]
        public void EnemyName_WhenNameIsValid_TheNameMustBeAssignedCorrectly()
        {
            // Arrange
            //primo costruttore senza parametri
            Enemy newEnemy = new Enemy();

            //Act
            newEnemy.SetName("Stefano");

            //Assert
            Assert.Equal("Stefano", newEnemy.GetName());
        
        }

        [Fact]
        public void EnemyName_TheNameCannotBeNull()
        {
            //Arrange
            Enemy newEnemy = new Enemy();

            //Act
            newEnemy.SetName(null);
            Assert.Null(newEnemy.GetName());
        }

        [Fact]

        public void EnemyName_TheNameCannotBeEmpty()
        {
            Enemy newEnemy = new Enemy();

            newEnemy.SetName(" ");

            Assert.Null(newEnemy.GetName());
        }

        

        
    }
            
}
