using System;

namespace TextBasedRPG

{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// setting up game loop
			bool gameisrunning = true;
			string start = "0";

			// main menu

			while (start != "1") { 
				Console.Clear ();

                Console.WriteLine ("LOCKED IN");
                Console.WriteLine ("Press 1 to start");
                Console.WriteLine ("Press 2 to quit");
			
                
				start = Console.ReadLine ();
				if (start == "1") {
					Console.Clear ();
				} else if (start == "2") {
					Environment.Exit (0);
				}
			}

			// game loop

			while (gameisrunning == true) { 
				Player player1 = new Player ();
				Random rng = new Random ();
				Console.WriteLine (rng.Next (1, 5));
				BabyEnemy BabyEnemy1 = new BabyEnemy ();
				player1.takeDamage (BabyEnemy1.BabyAttack);
				Console.WriteLine (player1.Health);
				

				Console.ReadLine ();
				Console.Clear ();
				string choice = "0";
				while (choice != "1" && choice != "2") {
					Console.WriteLine ("Unfamiliar Robot: Hello, didnt know if you were ever going to wake up, my name is RR2.");
					Console.WriteLine ("RR2: You might be wondering where you are, id like to tell you, you've been locked in.");
					Console.WriteLine ("RR2: Im here to help, you are being tested, there is a way to get out.");
					Console.WriteLine ("RR2: First you must choose how you want to make it out, sneaky, or aggressive.");
					Console.WriteLine ("");
					Console.WriteLine ("1) Sneaky");
					Console.WriteLine ("2) Aggressive");
					Console.WriteLine ("");
					choice = Console.ReadLine ();
					Console.Clear ();
				}

				// choosing choice and setting into player1 using method ChosenPath

				if (choice == "1") {
					Console.Clear ();
					Console.WriteLine ("RR2: Sneaky, the art of surpise, you must be nimble, and act fast!");
					Console.WriteLine ("RR2: This isnt going to be easy.");
					player1.ChosenPath ("Sneaky");
				} else if (choice == "2") {
					Console.Clear ();
					Console.WriteLine ("Well well well, I cant blame a man whos locked in to want to try and break out as aggressively as possible, we will see.");
					Console.WriteLine ("You must not hesitate, and have no fear if you want to make it out of here.");
					player1.ChosenPath ("Aggressive");
				}

				// regular text follows

				Console.WriteLine ("");
				Console.WriteLine ("Press any key to continue");
				Console.WriteLine ("");
				Console.ReadKey ();
				Console.Clear ();
				Console.WriteLine ("You walk out of the cellar you were awoken in, only to see another man, chained up, yelling to be unchained.");
				Console.WriteLine ("");
				Console.WriteLine ("Next");
				Console.WriteLine ("");
				Console.ReadKey ();
				Console.Clear ();
				Console.WriteLine ("Chained Man: Oi! you! unchain me!");
				Console.WriteLine ("");
				Console.WriteLine ("Next");
				Console.WriteLine ("");
				Console.ReadKey ();
				Console.Clear ();
				Console.WriteLine ("Chained Man: Please mate, i dont know how i've gotten here");
				Console.WriteLine ("");
				Console.WriteLine ("Next");
				Console.WriteLine ("");
				Console.ReadKey ();
				string answer1 = "0";
				string answer2 = "0";

				// forcing  response of the proper options

				while (answer1 != "1" && answer1 != "2") {
					Console.Clear ();
					Console.WriteLine ("Chained Man: You've found me mate, I thought I was dead.");
				    Console.WriteLine ("1) Who are you?");
					Console.WriteLine ("2) Ignore him");
					Console.WriteLine ("");
					answer1 = Console.ReadLine ();
				}
				if (answer1 == "1" && player1.Path == "Sneaky") {
					while (answer2 != "1") {
						Console.Clear ();
						Console.WriteLine ("You: Who are you?");
						Console.WriteLine ("You: you have to be quiet, or they're going to hear us. we're locked in.");
						Console.WriteLine ("");
						Console.WriteLine ("Chained man: *whispers* alright mate, ill listen to you, as long as you unchain me!");
						Console.WriteLine ("You proceed to unchain him");
                        Console.WriteLine("Chained Man: Im Charlie, what do they call you?");
						Console.WriteLine ("Enter your name:");
						Console.WriteLine ("");
						player1.Name = Console.ReadLine ();
						Console.Clear ();
						Console.WriteLine ("Your name is {0}, alright mate.", player1.Name);
						Console.WriteLine ("");
						Console.WriteLine ("1) Yes");
						Console.WriteLine ("Enter) No");
						Console.WriteLine ("");
						answer2 = Console.ReadLine (); 
					}
					Console.Clear ();
					Console.WriteLine ("You: '{0}'", player1.Name);
					Console.WriteLine ("");
					Console.WriteLine ("Charlie: Okay...{0}.", player1.Name);
					Console.WriteLine ("Charlie: Nice to meet ya. Do you have a plan to get the hell outta here?");
					Console.ReadLine ();
					Console.WriteLine ("");
					Console.WriteLine ("Next");
					Console.WriteLine ("");
					Console.ReadKey ();
				} else if (answer1 == "1" && player1.Path == "Aggressive") {
					while (answer2 != "1") {
						Console.Clear ();
						Console.WriteLine ("You: Who are you?");
						Console.WriteLine ("You: We dont have much time, im breaking you out!");
						Console.WriteLine ("Chained Man: Oi, thats the style mate!");
						Console.WriteLine ("You begin to unchain the man");
						Console.WriteLine ("Chained Man: Im Charlie, what do they call you mate?");
						Console.WriteLine ("Enter your name:");
						Console.WriteLine ("");
						player1.Name = Console.ReadLine ();
						Console.Clear ();
						Console.WriteLine ("Your name is {0}, alright mate", player1.Name);
						Console.WriteLine ("");
						Console.WriteLine ("1) Yes");
						Console.WriteLine ("Enter) No");
						Console.WriteLine ("");
						answer2 = Console.ReadLine ();
					}
					Console.Clear ();
					Console.WriteLine ("You: '{0}'", player1.Name);
					Console.WriteLine ("");
					Console.WriteLine ("Charlie: Okay nice to meet ya {0}.", player1.Name);
					Console.WriteLine ("Do you have a plan on how to get us outta here?");
					Console.WriteLine ("");
					Console.WriteLine ("Next");
					Console.WriteLine ("");
					Console.ReadKey ();
				} else if (answer1 != "1") {
					while (answer1 != "1") {
						Console.Clear ();
						Console.WriteLine ("Your conscious kicks in and you decide to help");
						Console.WriteLine ("");
						Console.WriteLine ("1) Who are you?");
						Console.WriteLine ("2) Wait for him to yell again");
						Console.WriteLine ("");
						answer1 = Console.ReadLine ();
					}
					if (answer1 == "1" && player1.Path == "Sneaky") {
                        while (answer2 != "1")
                        {
                            Console.Clear();
                            Console.WriteLine("You: Who are you?");
                            Console.WriteLine("You: you have to be quiet, or they're going to hear us. we're locked in.");
                            Console.WriteLine("");
                            Console.WriteLine("Chained man: *whispers* alright mate, ill listen to you, as long as you unchain me!");
                            Console.WriteLine("You proceed to unchain him");
                            Console.WriteLine("Chained Man: Im Charlie, what do they call you?");
                        Console.WriteLine("Enter your name:");
                            Console.WriteLine("");
                            player1.Name = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("Your name is {0}, alright mate.", player1.Name);
                            Console.WriteLine("");
                            Console.WriteLine("1) Yes");
                            Console.WriteLine("Enter) No");
                            Console.WriteLine("");
                            answer2 = Console.ReadLine();
                        }
                        Console.Clear();
                        Console.WriteLine("You: '{0}'", player1.Name);
                        Console.WriteLine("");
                        Console.WriteLine("Charlie: Okay...{0}.", player1.Name);
                        Console.WriteLine("Charlie: Nice to meet ya. Do you have a plan to get the hell outta here?");
                        Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("Next");
                        Console.WriteLine("");
                        Console.ReadKey();


                    } else if (answer1 == "1" && player1.Path == "Aggressive") {
                        while (answer2 != "1")
                        {
                            Console.Clear();
                            Console.WriteLine("You: Who are you?");
                            Console.WriteLine("You: We dont have much time, im breaking you out!");
                            Console.WriteLine("Chained Man: Oi, thats the style mate!");
                            Console.WriteLine("You begin to unchain the man");
                            Console.WriteLine("Chained Man: Im Charlie, what do they call you mate?");
                            Console.WriteLine("Enter your name:");
                            Console.WriteLine("");
                            player1.Name = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("Your name is {0}, alright mate", player1.Name);
                            Console.WriteLine("");
                            Console.WriteLine("1) Yes");
                            Console.WriteLine("Enter) No");
                            Console.WriteLine("");
                            answer2 = Console.ReadLine();
                        }
                        Console.Clear();
                        Console.WriteLine("You: '{0}'", player1.Name);
                        Console.WriteLine("");
                        Console.WriteLine("Charlie: Okay nice to meet ya {0}.", player1.Name);
                        Console.WriteLine("Do you have a plan on how to get us outta here?");
                        Console.WriteLine("");
                        Console.WriteLine("Next");
                        Console.WriteLine("");
                        Console.ReadKey();
                    }
				}
				player1.gainLevel (1);
				player1.scoreIncrease (100);
				string answer3 = "0";
				Console.Clear ();
				Console.WriteLine ("*You just gained a level!*");
				Console.WriteLine ("");
				Console.WriteLine ("*Your level is now {0}.*", player1.Level);
				Console.WriteLine ("*Your score is now {0}.*", player1.Score);
				Console.WriteLine ("");
				Console.WriteLine ("Next");
				Console.WriteLine ("");
				Console.ReadKey ();
				while (answer3 != "1" && answer3 != "2") {
					Console.Clear ();
					Console.WriteLine ("Charlie: 'So, {0}. Are we getting outta here? I wanna find the wanker who did this. And whats that robot doing with you?", player1.Name);
					Console.WriteLine ("RR2: Im here to help, you need to relax.");
                    Console.WriteLine("Charlie: This robot is pretty fishy. And were locked in a room, how in the hell are we getting help! ");
					Console.WriteLine ("1) Try to open the door at the end of the room. ");
					Console.WriteLine ("2) 'Think of a plan in case the door is booby trapped.");
					Console.WriteLine ("");
					answer3 = Console.ReadLine ();
				}
				if (answer3 == "1") {
					Console.Clear ();
					Console.WriteLine ("You: Lets get out of here");
					Console.WriteLine ("you run to the only door of the room.");
					Console.WriteLine ("RR2: I wouldnt do that if i were you. its been booby trapped, it wouldnt be that easy.");
					Console.WriteLine ("You: Thank you RR2. I dont know what i was thinking");
					Console.WriteLine ("Charlie: Is there anything in your cellar we could use to set the trap off?");
				} else if (answer3 == "2") {
					Console.Clear ();
					Console.WriteLine ("You: Lets play it safe, if theres guards on the other side of that door, were toast, it could also be booby trapped.");
					Console.WriteLine ("");
					Console.WriteLine ("Charlie: Screw this, im getting outta here!");
					Console.WriteLine ("RR2: I wouldnt do that if i were you.");
					Console.WriteLine ("Charlie runs to the door only to be electricuted by the door, Charlie is dead");
                    Console.WriteLine("RR2: check your cellar for anything you can use to get around that door");
				}
				string answer4 = "0";
				Console.WriteLine ("");
				Console.WriteLine ("Next");
				Console.WriteLine ("");
				player1.foundRubberBoots ();
				Console.ReadKey ();
				while (answer4 != "2") {
					Console.Clear ();
					Console.WriteLine ("You look into your cellar too see a pair of rubber boots.");
					Console.WriteLine ("These should increase your health by 5");
					Console.WriteLine ("");
					Console.WriteLine ("1) Check your Health");
					Console.WriteLine ("2) You: Just some rubber boots.");
					Console.WriteLine ("");
					answer4 = Console.ReadLine ();
					if (answer4 == "1") {
						Console.Clear ();
						Console.WriteLine ("You have {0} health.", player1.Health);
						Console.WriteLine ("");
						Console.WriteLine ("Press Enter to exit");
						Console.WriteLine ("");
						Console.ReadKey ();
					} 
				}
				string answer5 = "0";
				while (answer5 != "1" && answer5 != "2") {
					Console.Clear ();
					Console.WriteLine ("You: Just some rubber boots");
					Console.WriteLine ("");
					Console.WriteLine ("RR2: try to use those boots to open that door, maybe wear them on your hands?");
					Console.WriteLine ("");
					Console.WriteLine ("1) Okay I trust you");
					Console.WriteLine ("2) Wait why?");
					Console.WriteLine ("");
					answer5 = Console.ReadLine ();
				} 
              
				if (answer5 == "1") {
					Console.Clear ();
					Console.WriteLine ("You: I see, due to the electricity that is triggered when you touch the door, the Rubber Boots can absorb the damage,");
					Console.WriteLine ("");
					Console.WriteLine ("RR2: Precisely.");
					Console.WriteLine ("");
					Console.WriteLine ("Next");
					Console.WriteLine ("");
					Console.ReadKey ();
					Console.Clear ();
					Console.WriteLine ("You touch the door, boots absorbing the shock, you start turning the handle to realize that its open..");
					Console.WriteLine ("The door slowly starts to creep open,you're hesitant, but you continue.");
					Console.WriteLine ("");
					Console.WriteLine ("Next");
					Console.WriteLine ("");
					Console.ReadKey ();
					Console.Clear ();
					Console.WriteLine ("You start to shake and every question that has been passing through your mind is about to answered");
					Console.WriteLine ("");
					Console.WriteLine ("you look back towards RR2 thinking it might be your last moment");
					Console.WriteLine ("");
					Console.WriteLine ("Next");
                    Console.WriteLine("the door opens, to reveal a baby standing in the doorway. It attacks!");

            
					Console.WriteLine ("");
					Console.ReadKey ();
					Console.Clear ();
				}
					else if (answer5 == "2") { 
						Console.Clear ();
						Console.WriteLine ("You: Why?");
						Console.WriteLine("");
						Console.WriteLine ("Charlie: yeah id like to know why");
						Console.WriteLine ("RR2: my scanners are picking up an electric current on that door, the boots will absorb that electricity.");
						Console.WriteLine ("Next");
						Console.WriteLine ("");
						Console.ReadKey ();
						Console.Clear();
						Console.WriteLine ("You walk towards the door. Charlie next to you.");
						Console.WriteLine ("You slowly turn the knob on the door realizing its open");
						Console.WriteLine ("");
						Console.WriteLine ("Next");
						Console.WriteLine ("");
						Console.ReadKey ();
						Console.Clear();
						Console.WriteLine ("Your hands shake as you open the door wondering whats going to happen next");
						Console.WriteLine ("All your questions are about to be answered.");
						Console.WriteLine ("");
						Console.WriteLine ("Next");
						Console.WriteLine ("");
						Console.ReadKey ();
						Console.Clear();
						Console.WriteLine ("The door opens to reveal a baby standing in the doorway, it attacks!");
						Console.WriteLine ("");
						Console.WriteLine ("Next");
						Console.WriteLine ("");
						Console.ReadKey ();
						Console.Clear();
				
						Console.WriteLine ("");
						if (player1.Path == "Sneaky") {
							Console.WriteLine("The baby is much too powerful for you, you close the door, you realize you are forever locked in");
						} else if (player1.Path == "Aggressive") {
							Console.WriteLine("The baby is much to powerful for you, you close the door, you realize you a forever locked in");
						}
					Console.ReadKey ();



						
					





					



					gameisrunning = false;
				}
				if (player1.Health <= 0) {
					Console.Clear ();
					Console.WriteLine ("thanks for playing...you've been LOCKED IN");
					
				} else if (player1.Health > 0) {
					Console.Clear ();
				
				
					Console.WriteLine ("thanks for playing... you've been LOCKED IN");
				}
			}
		}
	}
	}
