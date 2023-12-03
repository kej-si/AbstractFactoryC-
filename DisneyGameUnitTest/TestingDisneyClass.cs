using AbstractFactory;

namespace DisneyGameUnitTest
{
    public class TestingDisneyClass
    {
        [Fact]
        public void Test1()
        {
            try
            {
                //Arrange; creating the obj for level1 snowwhite
                IDisneyFactory level1Hero = new Level1_SnowWhite();

                // act executing the 
                IHero herocreate = level1Hero.CreateHero();

                //assert = the value should not be null
                Assert.NotNull(herocreate);
            }
            catch (Exception ex)
            {
                //the exeption message in case sth went wrong
                Console.WriteLine(ex.Message);
            }
        }
    }
    public class DisneyCartoonTesting_LevelsUnitest2
    {
        [Fact]
        public void Level2_Anastasia_Wicked_Creation()
        {
            try
            {
                //Arrange; create the obj 
                IDisneyFactory level2Wicked = new Level2_Anastasia();

                // act executing
                IHero wickedcreate = level2Wicked.CreateHero();

                //assert if its null is wrong
                Assert.NotNull(wickedcreate);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    public class DisneyCartoonTesting_LevelsUnitest3
    {
        [Fact]
        public void Level3_WALLE_Weapon_Creation()
        {
            try
            {
                //Arrange; create the obj
                IDisneyFactory level3Weapon = new Level3_WallE();

                // act executing
                IHero weaponcreate = level3Weapon.CreateHero();

                //assert 
                Assert.NotNull(weaponcreate);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    public class DisneyCartoonTesting_LevelsUnitest4
    {
        [Fact]
        public void Level4_PeterPan_Place_Creation()
        {
            try
            {
                //Arrange; create the obj
                IDisneyFactory level4Place = new Level4_PeterPan();

                // act execute
                IHero placecreate = level4Place.CreateHero();

                //assert
                Assert.NotNull(placecreate);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    public class DisneyCartoonTesting_LevelsUnitest5
    {
        [Fact]
        public void Level5_Mulan_GameLevel_Initialize()
        {
            try
            {
                //this is to check weather gamelevel is successfully initialized
                //arrange creating the instance of L5Mulan 
                IDisneyFactory factory = new Level5_Mulan();
                //act creates the obj with factory as the parameter stimulates the starting of the gamelevel using L5M
                GameLevel gameLevel = new GameLevel(factory);
                //assert to verify it aint null
                Assert.NotNull(gameLevel);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}