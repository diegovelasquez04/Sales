namespace Sales.Infrastructure
{
    using ViewModels;
   public class InstaLocator
    {
        public MainViewModel Main { get; set; }
        public InstaLocator()
        {
            this.Main = new MainViewModel();
        }
    }
}
