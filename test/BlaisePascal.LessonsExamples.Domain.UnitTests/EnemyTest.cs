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
          
            //Assert
            Assert.Null(newEnemy.GetName());
        }

        [Fact]

        public void EnemyName_TheNameCannotBeEmpty()
        {
            Enemy newEnemy = new Enemy();

            newEnemy.SetName(" ");

            Assert.Null(newEnemy.GetName());
        }

        
        [Fact]
        public void EnemyHealth_NewHealthMustBePositive()
        {
            //Arrange 
            Enemy newEnemy = new Enemy();

            //Act
            newEnemy.SetHealth(1);

            //Assert
            Assert.Equal(1, newEnemy.Health); //Health solo perchè l'abbiamo resa una property, sennò newEnemy.getHealth()
        }


        [Fact]
        
        public void EnemyHealth_HealthCannotBeOver100()
        {
            //Arrange
            Enemy newEnemy = new Enemy();

            //Act
            newEnemy.SetHealth(100);
            newEnemy.SetHealth(101);

            //Assert
            Assert.Equal(100, newEnemy.Health);

        }

        [Fact]

        public void EnemyHealth_HealthCannotBeNegative()
        {
            //Arrange
            Enemy newEnemy = new Enemy();

            //Act
            newEnemy.SetHealth(100);
            newEnemy.SetHealth(-3);

            //Assert
            Assert.Equal(100, newEnemy.Health);


        }
        [Fact]
        public void EnemyHealth_HealthCanBeBetween_1And100()
        {
            //Assert
            Enemy newEnemy = new Enemy();

            //Act
            newEnemy.SetHealth(32);

            //Assert
            Assert.Equal(32, newEnemy.Health);

        }

        [Fact]
        public void TakeDamage_WhenTheEnemyIsAlive_AndDamageIsMinorThanHealthThenTakeDamage()
        {
            //Arrange
            Enemy newEnemy = new Enemy();

            //Act
            newEnemy.SetHealth(100);           
            newEnemy.TakeDamage(20);
           
            //Assert
            Assert.Equal(80, newEnemy.Health);
            
        }

        [Fact]
        public void TakeDamage_WhenDamageIsNegativeHealthDoesNotDecrease()
        {
            //Arrange
            Enemy newEnemy = new Enemy();

            //Act
            newEnemy.SetHealth(100);
            newEnemy.TakeDamage(-20);

            //Assert
            Assert.Equal(100, newEnemy.Health);

        }

        [Fact]
        public void TakeDamage_WhenDamageIsBiggerThanHealth_HealthIs0()
        {
            //Arrange
            Enemy newEnemy = new Enemy();

            //Act
            newEnemy.SetHealth(100);
            newEnemy.TakeDamage(120);

            //Assert
            Assert.Equal(0, newEnemy.Health);

        }

        [Fact]
        public void TakeDamage_WhenDamageIsEqualToHealth_HealthIs0()
        {
            //Arrange
            Enemy newEnemy = new Enemy();

            //Act
            newEnemy.SetHealth(100);
            newEnemy.TakeDamage(100);

            //Assert
            Assert.Equal(0, newEnemy.Health);

        }

        [Fact]
        public void Heal_WhenAmountIsValid_HealthMustIncrease()
        {   
            //Arrange
            Enemy newEnemy = new Enemy();
            
            //Act
            newEnemy.SetHealth(80);
            newEnemy.Heal(10);

            //Assert
            Assert.Equal(90, newEnemy.Health);
        }

        [Fact]
        public void Heal_HealAmountCannotBeNegative()
        {
            //Arrange
            Enemy newEnemy = new Enemy();

            //Act
            newEnemy.SetHealth(80);
            newEnemy.Heal(-10);

            //Assert
            Assert.Throws<ArgumentException>
        }
    }
            
}
