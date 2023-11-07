using System;
using ClubMembershipApplication.Views;
namespace ClubMembershipApplication
{
    class Program
    {
        static void Main()
        {
            IView mainView = Factory.GetMainViewObject();
            mainView.RunView();

            Console.ReadKey();
        }
    }
}