namespace LearnWords
{
  public class Program
  {
    static void Main(string[] args)
    {
      LearnWordsApp learnWordsApp = new();
      learnWordsApp.Run();
    }
  }

  public class LearnWordsApp
  {
    private readonly IUserInteraction _userInteraction;
    private readonly IRepositoryInteraction _reposittoryInteraction;

    public LearnWordsApp(
      IUserInteraction userInteraction,
      IRepositoryInteraction reposittoryInteraction)
    {
      _userInteraction = userInteraction;
      _reposittoryInteraction = reposittoryInteraction;
    }

    public void Run()
    {
      // print the main menu
      ConsoleUserInteraction consoleUserInteraction = new();

      consoleUserInteraction.ShowMainMenu();

      Console.WriteLine("""
        ---------------------------
        -------Learning Words------
        ---------------------------

        Enter a letter in parenthesis to choose the option:
        1. Practice
          Select a vocabulary to practice:
            1. LT_EN_Fruits.txt
            2. EN_LT_Fruits.txt
        2. Back to main menu
        2. Create Vocabulary
        3. Edit Vocabulary
        4. Statistics
        5. Quit
        """);

      _userInteraction.PromptUserToSelectMenuItem();

      _userInteraction.Read();

      _userInteraction.Exit();


      //• words list
      // • user
      // • statistics
      // • hints
    }
  }
}
