using System.Collections.Generic;
using Xamarin.Forms;

namespace GroupAssignmentMAPP
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new SplashPage());

		}

		public Pizza ActivePizza { get; set; } //Variable to store Pizza the user selected in MainPage
		public Pizzas ActivePizzaList = MakePizzas(); //This stores the list of available pizzas
		public List<Pizza> cart = new List<Pizza>(); //Variable to store the list of pizzas the user added to cart
		public string DeliveryType; //Global variable to store delivery type between pages
		public string GrandTotalGlobal; //Global variable to store grand total between pages
		public List<Pizza> PurchaseHistory = new List<Pizza>(); // Variable to store checkout history
		public bool Checkedout = false;
		public static Pizzas MakePizzas() //Function to make current pizza list
		{
			Pizzas pizzas = new Pizzas("Pizzas"); //Making a new Pizzas object
			pizzas.PizzasList.Add(new Pizza(1, "Hawaiian", 19.99, 19.99, "Ham, pineapple, mushrooms", "Large", "hawaiian.png")); //Adding pizzas to object
			pizzas.PizzasList.Add(new Pizza(2, "The Meatfielder", 19.99, 19.99, "Pepperoni, ham, chorizo, pork meatballs and smoked bacon rashers", "Large", "meatfielder.jpg"));
			pizzas.PizzasList.Add(new Pizza(3, "Absolute Banger", 19.99, 19.99, "Pepperoni, sausage, chorizo, hotdog slices and mozzarella cheese", "Large", "absolutebanger.jpg"));
			pizzas.PizzasList.Add(new Pizza(4, "The Cheeseburger", 19.99, 19.99, "Double ground beef with fresh tomatoes, onions, sliced gherkins and drizzled with our special burger sauce", "Large", "cheeseburger.jpg"));
			pizzas.PizzasList.Add(new Pizza(5, "The Festive One", 19.99, 19.99, "Sage & onion turkey, sausage smoked bacon, onions and mozzerella cheese on Pizza 4 Life's tomato sauce base", "Large", "thefestiveone.jpg"));
			pizzas.PizzasList.Add(new Pizza(6, "Original Cheese and Tomato", 17.99, 17.99, "Our original Cheese & Tomato pizza with even more cheese", "Large", "cheeseandtomato.jpg"));
			pizzas.PizzasList.Add(new Pizza(7, "Vegi Supreme", 19.99, 19.99, "Onions, green and red peppers, sweetcorn, mushrooms, tomatoes", "Large", "vegisupreme.jpg"));
			pizzas.PizzasList.Add(new Pizza(8, "American Hot", 19.99, 19.99, "Onions, pepperoni, jalapeno peppers", "Large", "americanhot.jpg"));
			pizzas.PizzasList.Add(new Pizza(9, "Chicken Feast", 19.99, 19.99, "Chicken, mushrooms, sweetcorn", "Large", "chickenfeast.jpg"));

			return pizzas;
		}

		public bool LoggedIn; //Global variable to store if the user is logged in or not

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
