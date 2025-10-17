using static System.Net.Mime.MediaTypeNames;

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
            Assert.Equal("Stefano", newEnemy.Name);
        
        }

        [Fact]
        public void EnemyName_TheNameCannotBeNull()
        {
            //Arrange
            Enemy newEnemy = new Enemy();
          
            //Assert
            Assert.Null(newEnemy.Name);
        }

        [Fact]

        public void EnemyName_TheNameCannotBeEmpty()
        {
            Enemy newEnemy = new Enemy();

            newEnemy.SetName(" ");

            Assert.Null(newEnemy.Name);
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
            Assert.True(newEnemy.IsAlive);

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
            Assert.True(newEnemy.IsAlive);

        }

        [Fact]
        public void EnemyTakeDamage_WhenTheEnemyIsAlive_AndDamageIsMinorThanHealthThenTakeDamage()
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
        public void EnemyTakeDamage_WhenDamageIsNegative_ShouldThrowAgumentException()
        {
            //Arrange
            Enemy newEnemy = new Enemy("Goblin");
            int damage = -5;           

            //Assert          
            Assert.Throws<ArgumentException>(() => newEnemy.TakeDamage(damage));
        }
           

        [Fact]
        public void EnemyTakeDamage_WhenDamageIsBiggerThanHealth_HealthIs0()
        {
            //Arrange
            Enemy newEnemy = new Enemy();

            //Act
            newEnemy.SetHealth(100);
            newEnemy.TakeDamage(120);

            //Assert
            Assert.Equal(0, newEnemy.Health);
            Assert.False(newEnemy.IsAlive);
        }

        [Fact]
        public void EnemyTakeDamage_WhenDamageIsEqualToHealth_HealthIs0()
        {
            //Arrange
            Enemy newEnemy = new Enemy();

            //Act
            newEnemy.SetHealth(100);
            newEnemy.TakeDamage(100);

            //Assert
            Assert.Equal(0, newEnemy.Health);
            Assert.False(newEnemy.IsAlive);

        }

        [Fact]
        public void EnemyHeal_WhenAmountIsValid_HealthMustIncrease()
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
        public void EnemyHeal_HealAmountCannotBeNegative()
        {
            //Arrange
            Enemy newEnemy = new Enemy();
            int healAmount = -1;

            //Act
            newEnemy.SetHealth(80);

            //Assert

            Assert.Throws<ArgumentException>(() => newEnemy.Heal(healAmount));

        }


        [Fact]
        public void EnemyHeal_WhenHealAmountIsGreaterThanMaxHealth_HealthIsEqualToMaxHealth()
        {
            //Arrange
            Enemy newEnemy = new Enemy();
            

            //Act
            newEnemy.SetHealth(100);
            newEnemy.Heal(120);


            //Assert
            Assert.Equal(100, newEnemy.Health);
            
           

        }
    }
            
}
