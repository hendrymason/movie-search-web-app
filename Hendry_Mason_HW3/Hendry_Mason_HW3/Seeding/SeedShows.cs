using Hendry_Mason_HW3.DAL;
using Hendry_Mason_HW3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hendry_Mason_HW3.Seeding
{
	public static class SeedShows
	{
		public static void SeedAllShows(AppDbContext db)
		{
			//Create a new list for all of the shows
			List<Show> AllShows = new List<Show>();
			AllShows.Add(new Show
			{
				UniqueIdentifier = 1001,
				ShowType = ShowType.Movie,
				Title = "Killer Klowns from Outer Space",
				Director = "Stephen Chiodo",
				Cast = "Grant Cramer, Suzanne Snyder, John Allen Nelson, John Vernon, Michael S. Siegel, Peter Licassi, Royal Dano, Christopher Titus, Irene Michaels, Karla Sue Krull",
				DateAdded = new DateTime(2020, 4, 1),
				ReleaseYear = 1988,
				Rating = Rating.PG13,
				Duration = "86 min",
				Description = "An alien band of killer clowns descends from the cosmos to harvest scores of small-town victims, cocooning their prey in cotton candy to eat later.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cult Movies"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1002,
				ShowType = ShowType.Movie,
				Title = "The Social Network",
				Director = "David Fincher",
				Cast = "Jesse Eisenberg, Andrew Garfield, Justin Timberlake, Armie Hammer, Max Minghella, Josh Pence, Brenda Song, Rashida Jones, John Getz, David Selby",
				DateAdded = new DateTime(2020, 4, 1),
				ReleaseYear = 2010,
				Rating = Rating.PG13,
				Duration = "121 min",
				Description = "Director David Fincher's biographical drama chronicles the meteoric rise of Facebook CEO Mark Zuckerberg from Harvard sophomore to Internet superstar.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1003,
				ShowType = ShowType.Movie,
				Title = "The Runaways",
				Director = "Floria Sigismondi",
				Cast = "Kristen Stewart, Dakota Fanning, Michael Shannon, Stella Maeve, Scout Taylor-Compton, Alia Shawkat, Riley Keough, Johnny Lewis, Tatum O'Neal, Brett Cullen, Hannah Marks",
				DateAdded = new DateTime(2020, 4, 1),
				ReleaseYear = 2010,
				Rating = Rating.R,
				Duration = "107 min",
				Description = "This biopic charts the rise of the rebellious California girls who formed the 1970s rock group the Runaways, paving the way for future girl musicians.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1004,
				ShowType = ShowType.TV,
				Title = "Nailed It",
				Director = "",
				Cast = "Nicole Byer, Jacques Torres",
				DateAdded = new DateTime(2020, 4, 1),
				ReleaseYear = 2020,
				Rating = Rating.TVPG,
				Duration = "4 Seasons",
				Description = "Home bakers with a terrible track record take a crack at re-creating edible masterpieces for a $10,000 prize. It's part reality contest, part hot mess.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Reality TV"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1005,
				ShowType = ShowType.Movie,
				Title = "Coffee & Kareem",
				Director = "Michael Dowse",
				Cast = "Ed Helms, Taraji P. Henson, Terrence Little Gardenhigh, Betty Gilpin",
				DateAdded = new DateTime(2020, 4, 3),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "88 min",
				Description = "An inept Detroit cop must team up with his girlfriend's foul-mouthed young son when their first crack at bonding time uncovers a criminal conspiracy.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Action & Adventure"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1006,
				ShowType = ShowType.Movie,
				Title = "Angel Has Fallen",
				Director = "Ric Roman Waugh",
				Cast = "Gerard Butler, Morgan Freeman, Nick Nolte, Danny Huston, Jada Pinkett Smith, Lance Reddick, Tim Blake Nelson, Piper Perabo",
				DateAdded = new DateTime(2020, 4, 4),
				ReleaseYear = 2019,
				Rating = Rating.R,
				Duration = "121 min",
				Description = "Secret Service agent Mike Banning is caught in the crossfire when he's framed for a deadly attack on the president and forced to run for his life.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Action & Adventure"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1007,
				ShowType = ShowType.Movie,
				Title = "Dark Light",
				Director = "Padraig Reynolds",
				Cast = "Jessica Madsen, Opal Littleton, Ed Brody, Kristina Clifford, Ben Sullivan, Gerald Tyler, Weston Meredith",
				DateAdded = new DateTime(2020, 4, 5),
				ReleaseYear = 2019,
				Rating = Rating.TVMA,
				Duration = "90 min",
				Description = "Implicated in her daughter's disappearance, a mother searches for answers when she returns to an old family home that may have an unwanted visitor.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Horror"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1008,
				ShowType = ShowType.Movie,
				Title = "Mine 9",
				Director = "Eddie Mensore",
				Cast = "Terry Serpico, Kevin Sizemore, Mark Ashworth, Clint James, Drew Starkey, Erin Elizabeth Burns",
				DateAdded = new DateTime(2020, 4, 6),
				ReleaseYear = 2019,
				Rating = Rating.TVMA,
				Duration = "83 min",
				Description = "A methane explosion leaves a group of miners trapped two miles deep into the earth with a small oxygen supply and desperate for any means of survival.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1009,
				ShowType = ShowType.Movie,
				Title = "The Ghost Who Walks",
				Director = "Cody Stokes",
				Cast = "Garland Scott, Frank Mosley, Alexia Rasmussen, Gil Darnell, Dasha Nekrasova, Nattalyee Randall, Linda Kennedy, Peter Mayer, Curtis York, Dennis Lebby",
				DateAdded = new DateTime(2020, 4, 7),
				ReleaseYear = 2019,
				Rating = Rating.TVMA,
				Duration = "107 min",
				Description = "Desperate to meet his daughter, a convict cuts a deal by ratting out his old boss. Free and searching for his family, he must dodge a hit on his life.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1010,
				ShowType = ShowType.TV,
				Title = "Brews Brothers",
				Director = "",
				Cast = "Alan Aisenberg, Mike Castle, Carmen Flood, Marques Ray",
				DateAdded = new DateTime(2020, 4, 10),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "1 Season",
				Description = "Two rival brothers must work together to keep their brewery in business, but shenanigans keep foaming up their company with chaos.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1011,
				ShowType = ShowType.Movie,
				Title = "The Main Event",
				Director = "Jay Karas",
				Cast = "Seth Carr, Tichina Arnold, Adam Pally, Ken Marino, Mike 'The Miz' Mizanin, Momona Tamada, Keith Lee, Babatunde Aiyegbusi, Kofi Kingston",
				DateAdded = new DateTime(2020, 4, 10),
				ReleaseYear = 2020,
				Rating = Rating.TVG,
				Duration = "103 min",
				Description = "Using special powers from a magical mask, a young WWE fan causes chaos when he enters a wrestling competition and fights an intimidating rival.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Family"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1012,
				ShowType = ShowType.Movie,
				Title = "Bleed for This",
				Director = "Ben Younger",
				Cast = "Miles Teller, Aaron Eckhart, Katey Sagal, Ciar??n Hinds, Ted Levine, Jordan Gelber, Amanda Clayton, Daniel Sauli, Christine Evangelista, Tina Casciani",
				DateAdded = new DateTime(2020, 4, 11),
				ReleaseYear = 2016,
				Rating = Rating.R,
				Duration = "120 min",
				Description = "After a devastating injury derails his career, scrappy world champion boxer Vinny Pazienza determines to make an against-all-odds comeback.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1013,
				ShowType = ShowType.TV,
				Title = "Married at First Sight",
				Director = "",
				Cast = "Viviana Coles, Calvin Roberson, Pepper Schwartz",
				DateAdded = new DateTime(2020, 4, 13),
				ReleaseYear = 2019,
				Rating = Rating.TV14,
				Duration = "1 Season",
				Description = "Set up by experts, four couples meet at the altar for the first time and test their compatibility after the wedding.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Reality TV"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1014,
				ShowType = ShowType.Movie,
				Title = "A Champion Heart",
				Director = "David de Vos",
				Cast = "Mandy Grace, David de Vos, Donna Rusch, Devan Key, Isabella Mancuso, Ariana Guido",
				DateAdded = new DateTime(2020, 4, 14),
				ReleaseYear = 2018,
				Rating = Rating.G,
				Duration = "90 min",
				Description = "When a grieving teen must work off her debt to a ranch, she cares for a wounded horse that teaches her more about healing than she expected.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Family"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1015,
				ShowType = ShowType.TV,
				Title = "Outer Banks",
				Director = "",
				Cast = "Chase Stokes, Madelyn Cline, Madison Bailey, Jonathan Daviss, Rudy Pankow, Charles Esten, Adina Porter, Austin North, Drew Starkey",
				DateAdded = new DateTime(2020, 4, 15),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "1 Season",
				Description = "On an island of haves and have-nots, teen John B enlists his three best friends to hunt for a legendary treasure linked to his father's disappearance.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Action & Adventure"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1016,
				ShowType = ShowType.Movie,
				Title = "LeapFrog: Numberland",
				Director = "Ron Myrick",
				Cast = "Jeannie Elias, Kat Feller, Sandy Fox, Cindy Robinson, Richard Rosenblatt",
				DateAdded = new DateTime(2020, 4, 15),
				ReleaseYear = 2011,
				Rating = Rating.TVY,
				Duration = "33 min",
				Description = "With transport support from their magic car, Axel, the LeapFrog pets make a new friend named Max, who helps them learn counting skills in Numberland.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Family"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1017,
				ShowType = ShowType.Movie,
				Title = "Puerto Ricans in Paris",
				Director = "Ian Edelman",
				Cast = "Luis Guzm??n, Edgar Garcia, Alice Taglioni, Rosie Perez, Miriam Shor, Fr??d??ric Anscombre, Rosario Dawson, Julie Ferrier, Micha??l Cohen, Ravi Patel",
				DateAdded = new DateTime(2020, 4, 16),
				ReleaseYear = 2015,
				Rating = Rating.R,
				Duration = "82 min",
				Description = "New York police detectives Luis and Eddie experience culture shock and adventure when they head to Paris to track down a stolen couture handbag.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1018,
				ShowType = ShowType.Movie,
				Title = "Jem and the Holograms",
				Director = "Jon M. Chu",
				Cast = "Aubrey Peeples, Stefanie Scott, Hayley Kiyoko, Aurora Perrineau, Juliette Lewis, Molly Ringwald, Ryan Guzman, Nathan Moore, Barnaby Carpenter, Nicholas Braun",
				DateAdded = new DateTime(2020, 4, 16),
				ReleaseYear = 2015,
				Rating = Rating.PG,
				Duration = "119 min",
				Description = "After becoming an overnight star via the internet, teenage rocker Jem and her sisters journey to LA, where fame, fun and a family mystery await.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1019,
				ShowType = ShowType.Movie,
				Title = "The Green Hornet",
				Director = "Michel Gondry",
				Cast = "Seth Rogen, Jay Chou, Cameron Diaz, Tom Wilkinson, Christoph Waltz, David Harbour, Edward James Olmos, Jamie Harris, Chad L. Coleman, Edward Furlong",
				DateAdded = new DateTime(2020, 4, 18),
				ReleaseYear = 2011,
				Rating = Rating.PG13,
				Duration = "119 min",
				Description = "A hard-partying heir dons a disguise to fight crime after hours. But with no talents or skills, he relies on his friend, a martial-arts genius.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Action & Adventure"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1020,
				ShowType = ShowType.TV,
				Title = "The Midnight Gospel",
				Director = "",
				Cast = "Duncan Trussell, Phil Hendrie, Drew Pinsky, Joey Diaz, Natasha Leggero, Johnny Pemberton, Christina Pazsitzky, Anne Lamott, Damien Echols, Trudy Goodman, Maria Bamford, Pauly Shore, Doug Lussenhop, David Nichtern, Steve Little, Caitlin Doughty, Stephen Root",
				DateAdded = new DateTime(2020, 4, 20),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "1 Season",
				Description = "Traversing trippy worlds inside his universe simulator, a space caster explores existential questions about life, death and everything in between.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1021,
				ShowType = ShowType.Movie,
				Title = "Circus of Books",
				Director = "Rachel Mason",
				Cast = "",
				DateAdded = new DateTime(2020, 4, 22),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "87 min",
				Description = "For decades, a nice Jewish couple ran Circus of Books, a porn shop and epicenter for gay LA. Their director daughter documents their life and times.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Documentary"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1022,
				ShowType = ShowType.Movie,
				Title = "Django Unchained",
				Director = "Quentin Tarantino",
				Cast = "Jamie Foxx, Christoph Waltz, Leonardo DiCaprio, Kerry Washington, Samuel L. Jackson, Walton Goggins, Dennis Christopher, James Remar, David Steen, Dana Gourrier, Nichole Galicia, Laura Cayouette, Ato Essandoh, Sammi Rotibi, Escalante Lundy, Don Johnson",
				DateAdded = new DateTime(2020, 4, 25),
				ReleaseYear = 2012,
				Rating = Rating.R,
				Duration = "165 min",
				Description = "Accompanied by a German bounty hunter, a freed slave named Django travels across America to free his wife from a sadistic plantation owner.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1023,
				ShowType = ShowType.TV,
				Title = "Coronavirus, Explained",
				Director = "",
				Cast = "",
				DateAdded = new DateTime(2020, 4, 26),
				ReleaseYear = 2020,
				Rating = Rating.TVPG,
				Duration = "1 Season",
				Description = "In 2020, the world changed. This topical series examines the coronavirus pandemic, the efforts to combat it and ways to manage its mental health toll.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Docuseries"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1024,
				ShowType = ShowType.TV,
				Title = "Never Have I Ever",
				Director = "",
				Cast = "Maitreyi Ramakrishnan, Poorna Jagannathan, Richa Moorjani, Jaren Lewison, Darren Barnet, John McEnroe, Ramona Young, Lee Rodriguez, Sendhil Ramamurthy, Adam Shapiro, Niecy Nash, Cocoa Brown, Lily D. Moore, Eddie Liu",
				DateAdded = new DateTime(2020, 4, 27),
				ReleaseYear = 2020,
				Rating = Rating.TV14,
				Duration = "1 Season",
				Description = "After a traumatic year, all an Indian-American teen wants is to go from pariah to popular, but friends, family and feelings won't make it easy on her.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1025,
				ShowType = ShowType.Movie,
				Title = "Dangerous Lies",
				Director = "Michael M. Scott",
				Cast = "Camila Mendes, Jessie T. Usher, Jamie Chung, Cam Gigandet, Sasha Alexander, Elliott Gould",
				DateAdded = new DateTime(2020, 4, 30),
				ReleaseYear = 2020,
				Rating = Rating.TV14,
				Duration = "97 min",
				Description = "A broke caregiver unexpectedly inherits her patient's estate, but dark secrets swirl around her newfound wealth, tangling her in deceit and danger.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Thriller"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1026,
				ShowType = ShowType.Movie,
				Title = "Den of Thieves",
				Director = "Christian Gudegast",
				Cast = "Gerard Butler, Pablo Schreiber, O'Shea Jackson Jr., 50 Cent, Meadow Williams, Maurice Compte, Brian Van Holt, Evan Jones, Mo McRae, Kaiwi Lyman",
				DateAdded = new DateTime(2020, 5, 1),
				ReleaseYear = 2018,
				Rating = Rating.R,
				Duration = "140 min",
				Description = "A highly skilled crew of bank robbers plotting a heist at the supposedly impenetrable Federal Reserve faces off against an elite unit of L.A. cops.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Action & Adventure"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1027,
				ShowType = ShowType.Movie,
				Title = "The Half Of It",
				Director = "Alice Wu",
				Cast = "Leah Lewis, Daniel Diemer, Alexxis Lemire, Wolfgang Novogratz, Collin Chou, Becky Ann Baker, Enrique Murciano, Macintyre Dixon, Catherine Curtin",
				DateAdded = new DateTime(2020, 5, 1),
				ReleaseYear = 2020,
				Rating = Rating.PG13,
				Duration = "105 min",
				Description = "When smart but cash-strapped teen Ellie Chu agrees to write a love letter for a jock, she doesn't expect to become his friend - or fall for his crush.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1028,
				ShowType = ShowType.Movie,
				Title = "I Am Divine",
				Director = "Jeffrey Schwarz",
				Cast = "",
				DateAdded = new DateTime(2020, 5, 1),
				ReleaseYear = 2013,
				Rating = Rating.TVMA,
				Duration = "90 min",
				Description = "This captivating documentary explores the life and work of filmmaker John Waters's muse: internationally celebrated drag superstar Divine.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Documentary"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1029,
				ShowType = ShowType.Movie,
				Title = "All Day and a Night",
				Director = "Joe Robert Cole",
				Cast = "Jeffrey Wright, Ashton Sanders, Regina Taylor, Yahya Abdul-Mateen II, Isaiah John, Kelly Jenrette, Shakira Ja-nai Paye",
				DateAdded = new DateTime(2020, 5, 1),
				ReleaseYear = 2020,
				Rating = Rating.R,
				Duration = "122 min",
				Description = "While serving life in prison, a young man looks back at the people, the circumstances and the system that set him on the path toward his crime.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1030,
				ShowType = ShowType.Movie,
				Title = "For Colored Girls",
				Director = "Tyler Perry",
				Cast = "Kimberly Elise, Janet Jackson, Loretta Devine, Thandie Newton, Anika Noni Rose, Kerry Washington, Tessa Thompson, Phylicia Rashad, Whoopi Goldberg, Omari Hardwick, Macy Gray, Michael Ealy, Richard Lawson, Hill Harper, Khalil Kain",
				DateAdded = new DateTime(2020, 5, 1),
				ReleaseYear = 2010,
				Rating = Rating.R,
				Duration = "134 min",
				Description = "This adaptation of Ntozake Shange's play consists of a series of poetic vignettes that explore the lives of modern African American women.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1031,
				ShowType = ShowType.TV,
				Title = "Hollywood",
				Director = "",
				Cast = "David Corenswet, Darren Criss, Patti LuPone, Jeremy Pope, Jim Parsons, Laura Harrier, Joe Mantello, Dylan McDermott, Jake Picking, Holland Taylor, Samara Weaving",
				DateAdded = new DateTime(2020, 5, 1),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "1 Season",
				Description = "In post-World War II Hollywood, an ambitious group of aspiring actors and filmmakers will do almost anything to make their showbiz dreams come true.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1032,
				ShowType = ShowType.Movie,
				Title = "Madagascar: Escape 2 Africa",
				Director = "Eric Darnell, Tom McGrath",
				Cast = "Ben Stiller, Chris Rock, David Schwimmer, Jada Pinkett Smith, Sacha Baron Cohen, Cedric the Entertainer, Andy Richter, Bernie Mac, Alec Baldwin, Sherri Shepherd",
				DateAdded = new DateTime(2020, 5, 1),
				ReleaseYear = 2008,
				Rating = Rating.PG,
				Duration = "91 min",
				Description = "A botched rescue strands Alex the lion and his companions in Africa. Sadly, Alex discovers he has little in common with the locals.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Family"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1033,
				ShowType = ShowType.TV,
				Title = "WWII in HD",
				Director = "",
				Cast = "Gary Sinise, Rob Lowe, Josh Lucas, Justin Bartha, Amy Smart, LL Cool J, Steve Zahn, Jason Ritter, Ron Livingston, Tim DeKay, Mark Hefti, James Kyson, Rob Corddry",
				DateAdded = new DateTime(2020, 5, 2),
				ReleaseYear = 2009,
				Rating = Rating.TV14,
				Duration = "1 Season",
				Description = "Rare color footage interwoven with firsthand interviews and diary entries bring to life the global sweep of World War II via those who were there.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Docuseries"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1034,
				ShowType = ShowType.Movie,
				Title = "Bennett's War",
				Director = "Alex Ranarivelo",
				Cast = "Michael Roark, Trace Adkins, Ali Afshar, Allison Paige, Tony Panterra, Brando Eaton, Hunter Clowdus, Michael King",
				DateAdded = new DateTime(2020, 5, 2),
				ReleaseYear = 2019,
				Rating = Rating.PG13,
				Duration = "94 min",
				Description = "A medically discharged soldier attempts an improbable return to motorcycle racing to win enough prize money to save his father's farm.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1035,
				ShowType = ShowType.Movie,
				Title = "The Stand at Paxton County",
				Director = "Brett Hedlund",
				Cast = "Jacqueline Toboni, Michael O'Neill, Tyler Jacob Moore, Christopher McDonald, Sean O'Bryan, Blake Sheldon, Zoe Kanters, Greg Perrow, Tanner Thomason",
				DateAdded = new DateTime(2020, 5, 2),
				ReleaseYear = 2020,
				Rating = Rating.R,
				Duration = "103 min",
				Description = "A military veteran comes home to find her father harassed by a sheriff intent on confiscating the livestock on their ranch under shady pretenses.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1036,
				ShowType = ShowType.Movie,
				Title = "Roped",
				Director = "Shaun Paul Piccinino",
				Cast = "Josh Swickard, Casper Van Dien, Lorynn York, Christina Moore, John Schneider, Michael Roark, Shane Graham, Cooper Lundeen, Javicia Leslie, Spencer Neville",
				DateAdded = new DateTime(2020, 5, 2),
				ReleaseYear = 2020,
				Rating = Rating.PG,
				Duration = "90 min",
				Description = "A star cowboy in a traveling rodeo gets thrown off course when he falls in love with the daughter of a tough-minded town councilman.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Family"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1037,
				ShowType = ShowType.Movie,
				Title = "Becoming",
				Director = "Nadia Hallgren",
				Cast = "Michelle Obama",
				DateAdded = new DateTime(2020, 5, 6),
				ReleaseYear = 2020,
				Rating = Rating.PG,
				Duration = "89 min",
				Description = "Join former first lady Michelle Obama in an intimate documentary looking at her life, hopes and connection with others as she tours with Becoming.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Documentary"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1038,
				ShowType = ShowType.TV,
				Title = "Dead to Me",
				Director = "",
				Cast = "Christina Applegate, Linda Cardellini, James Marsden, Max Jenkins, Sam McCarthy, Luke Roessler, Edward Asner",
				DateAdded = new DateTime(2020, 5, 8),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "2 Seasons",
				Description = "A hotheaded widow searching for the hit-and-run driver who mowed down her husband befriends an eccentric optimist who isn't quite what she seems.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1039,
				ShowType = ShowType.Movie,
				Title = "John Henry",
				Director = "Will Forbes",
				Cast = "Terry Crews, Ludacris, Jamila Velazquez, J.J. Soria, Ken Foree, Daffany Clark, Kimberly Hebert-Gregory, Tyler Alvarez",
				DateAdded = new DateTime(2020, 5, 9),
				ReleaseYear = 2020,
				Rating = Rating.R,
				Duration = "92 min",
				Description = "A reformed LA gang member upends his peaceful new life when he steps in to protect two young immigrants from his violent former leader.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1040,
				ShowType = ShowType.TV,
				Title = "Charmed",
				Director = "",
				Cast = "Madeleine Mantock, Sarah Jeffery, Melonie Diaz, Rupert Evans, Ser'Darius Blain, Ellen Tamaki, Charlie Gillespie",
				DateAdded = new DateTime(2020, 5, 9),
				ReleaseYear = 2019,
				Rating = Rating.TV14,
				Duration = "2 Seasons",
				Description = "After their mother's tragic death, a trio of sisters bond over their newfound powers, vanquish demons and band together to defend their magical legacy.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1041,
				ShowType = ShowType.TV,
				Title = "Grey's Anatomy",
				Director = "",
				Cast = "Ellen Pompeo, Sandra Oh, Katherine Heigl, Justin Chambers, Patrick Dempsey, Chandra Wilson, T.R. Knight, James Pickens Jr., Isaiah Washington, Sara Ramirez, Eric Dane, Chyler Leigh, Kate Walsh, Kevin McKidd, Jessica Capshaw",
				DateAdded = new DateTime(2020, 5, 9),
				ReleaseYear = 2019,
				Rating = Rating.TV14,
				Duration = "16 Seasons",
				Description = "Intern (and eventual resident) Meredith Grey finds herself caught up in personal and professional passions with fellow doctors at a Seattle hospital.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Romance"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1042,
				ShowType = ShowType.Movie,
				Title = "Love Is Blind",
				Director = "Andy Delaney, Monty Whitebloom",
				Cast = "Shannon Tarbet, Aidan Turner, Benjamin Walker, Matthew Broderick, Chlo?? Sevigny, Mark Blum, Jason Fuchs, Kabby Borders",
				DateAdded = new DateTime(2020, 5, 12),
				ReleaseYear = 2019,
				Rating = Rating.TVMA,
				Duration = "93 min",
				Description = "Diagnosed with selective perception, a young woman is prescribed by a psychotherapist to spend time with a troubled man she cannot see.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1043,
				ShowType = ShowType.TV,
				Title = "Avatar: The Last Airbender",
				Director = "",
				Cast = "Zach Tyler, Mae Whitman, Jack De Sena, Dee Bradley Baker, Dante Basco, Jessie Flower, Mako Iwamatsu",
				DateAdded = new DateTime(2020, 5, 15),
				ReleaseYear = 2007,
				Rating = Rating.TVY7,
				Duration = "3 Seasons",
				Description = "Siblings Katara and Sokka wake young Aang from a long hibernation and learn he's an Avatar, whose air-bending powers can defeat the evil Fire Nation.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Classics"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1044,
				ShowType = ShowType.TV,
				Title = "Patriot Act with Hasan Minhaj",
				Director = "",
				Cast = "Hasan Minhaj",
				DateAdded = new DateTime(2020, 5, 17),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "6 Seasons",
				Description = "Every Sunday, Hasan Minhaj brings an incisive and nuanced perspective to global news, politics and culture in his unique comedy series.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Stand-Up Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1045,
				ShowType = ShowType.TV,
				Title = "Patton Oswalt: I Love Everything",
				Director = "Marcus Raboy",
				Cast = "Patton Oswalt, Bob Rubin",
				DateAdded = new DateTime(2020, 5, 19),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "1 Season",
				Description = "Turning 50. Finding love again. Buying a house. Experiencing existential dread at Denny's. Life comes at Patton Oswalt fast in this stand-up special.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Stand-Up Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1046,
				ShowType = ShowType.Movie,
				Title = "I Will Follow",
				Director = "Ava DuVernay",
				Cast = "Salli Richardson-Whitfield, Michole Briana White, Omari Hardwick, Tracie Thoms, Dijon Talton, Damone Roberts, Blair Underwood, Beverly Todd",
				DateAdded = new DateTime(2020, 5, 20),
				ReleaseYear = 2010,
				Rating = Rating.TV14,
				Duration = "80 min",
				Description = "Devastated after her aunt dies, Maye moves out of the home they shared and copes with her grief, yet finds comfort in the kindness of other mourners.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1047,
				ShowType = ShowType.TV,
				Title = "Supergirl",
				Director = "Jesse Warn",
				Cast = "Melissa Benoist, Mehcad Brooks, Chyler Leigh, Jeremy Jordan, David Harewood, Calista Flockhart, Emma Tremblay, Adrian Pasdar, Katie McGrath, David St. Louis, Odette Annable, Floriana Lima, Erica Durance",
				DateAdded = new DateTime(2020, 5, 25),
				ReleaseYear = 2019,
				Rating = Rating.TV14,
				Duration = "5 Seasons",
				Description = "To avert a disaster, Kara Danvers reveals her powers and true identity: She is Superman's cousin, now known as Supergirl, protector of National City.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Action & Adventure"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1048,
				ShowType = ShowType.Movie,
				Title = "Norm of the North: Family Vacation",
				Director = "Anthony Bell",
				Cast = "Andrew Toth, Lisa Durupt, Jonathan Holmes, Paul Dobson, Cole Howard, Brian Drummond, Jennifer Cameron",
				DateAdded = new DateTime(2020, 5, 25),
				ReleaseYear = 2020,
				Rating = Rating.TVY7,
				Duration = "89 min",
				Description = "Stressed by his duties as king and father, Norm must secretly find his stolen crown while taking his family on a much-needed vacation.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Family"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1049,
				ShowType = ShowType.TV,
				Title = "Space Force",
				Director = "",
				Cast = "Steve Carell, John Malkovich, Ben Schwartz, Diana Silvers, Tawny Newsome, Jimmy O. Yang, Don Lake, Lisa Kudrow, Fred Willard, Spencer House, Owen Daniels, Hector Duran, Chris Gethard, Aparna Nancherla",
				DateAdded = new DateTime(2020, 5, 29),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "1 Season",
				Description = "A four-star general begrudgingly teams up with an eccentric scientist to get the U.S. military's newest agency - Space Force - ready for lift-off.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1050,
				ShowType = ShowType.Movie,
				Title = "Hulk Vs.",
				Director = "Sam Liu, Frank Paur",
				Cast = "Fred Tatasciore, Matthew Wolf, Graham McTavish, Grey DeLisle, Kari Wahlgren, Bryce Johnson, Janyse Jaud, Jay Brazeau, Jonathan Holmes, Paul Dobson, Michael Adamthwaite, French Tickner, Nicole Oliver, Qayam Devji, Steve Blum, Mark Acheson, Colin Murdock, Nolan North, Tom Kane",
				DateAdded = new DateTime(2020, 6, 1),
				ReleaseYear = 2009,
				Rating = Rating.PG13,
				Duration = "83 min",
				Description = "This action-packed animated double feature pits the Hulk against two of the Marvel Universe's most powerful characters: Wolverine and Thor.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Action & Adventure"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1051,
				ShowType = ShowType.Movie,
				Title = "The Car",
				Director = "Elliot Silverstein",
				Cast = "James Brolin, Kathleen Lloyd, John Marley, R.G. Armstrong, John Rubinstein, Elizabeth Thompson, Roy Jenson, Kim Richards, Kyle Richards",
				DateAdded = new DateTime(2020, 6, 1),
				ReleaseYear = 1977,
				Rating = Rating.PG,
				Duration = "96 min",
				Description = "In his small Southwestern town, sheriff Wade Parent must find out who - or what - is running people down via a mysterious, driverless black sedan.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Cult Movies"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1052,
				ShowType = ShowType.Movie,
				Title = "The Help",
				Director = "Tate Taylor",
				Cast = "Emma Stone, Viola Davis, Bryce Dallas Howard, Octavia Spencer, Jessica Chastain, Ahna O'Reilly, Allison Janney, Anna Camp, Cicely Tyson, Mike Vogel, Sissy Spacek, Mary Steenburgen, Carol Sutton, Dana Ivey, Amy Beckwith, Aunjanue Ellis, Kelsey Scott, Lauren Miller, Tarra Riggs, Wes Chatham, Ashley Johnson, Roslyn Ruff",
				DateAdded = new DateTime(2020, 6, 1),
				ReleaseYear = 2011,
				Rating = Rating.PG13,
				Duration = "147 min",
				Description = "A young, white writer stirs up the status quo in 1960s Mississippi by interviewing Black housemaids and bringing their stories to the masses.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1053,
				ShowType = ShowType.Movie,
				Title = "The Show",
				Director = "Giancarlo Esposito",
				Cast = "Josh Duhamel, Giancarlo Esposito, Famke Janssen, Sarah Wayne Callies, Caitlin Fitzgerald, Chris Ellis, Lucia Walters, James Franco",
				DateAdded = new DateTime(2020, 6, 1),
				ReleaseYear = 2017,
				Rating = Rating.TVMA,
				Duration = "105 min",
				Description = "A disillusioned reality TV host and an idealistic producer are lured by their network into producing a show in which participants kill themselves.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1054,
				ShowType = ShowType.Movie,
				Title = "Lady Bird",
				Director = "Greta Gerwig",
				Cast = "Saoirse Ronan, Laurie Metcalf, Tracy Letts, Lucas Hedges, Timoth??e Chalamet, Beanie Feldstein, Lois Smith, Stephen Henderson, Odeya Rush, Jordan Rodrigues",
				DateAdded = new DateTime(2020, 6, 3),
				ReleaseYear = 2017,
				Rating = Rating.R,
				Duration = "94 min",
				Description = "An intrepid high schooler in Sacramento undergoes the trials of love, family and self-discovery as she dreams of escaping to college on the East Coast.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1055,
				ShowType = ShowType.Movie,
				Title = "Spelling the Dream",
				Director = "Sam Rega",
				Cast = "",
				DateAdded = new DateTime(2020, 6, 3),
				ReleaseYear = 2020,
				Rating = Rating.TVG,
				Duration = "83 min",
				Description = "Following four hopeful competitors, this documentary explores Indian Americans' decades-long success at the biggest spelling contest in the U.S.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Family"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1056,
				ShowType = ShowType.TV,
				Title = "Queer Eye",
				Director = "",
				Cast = "Bobby Berk, Karamo Brown, Tan France, Antoni Porowski, Jonathan Van Ness",
				DateAdded = new DateTime(2020, 6, 5),
				ReleaseYear = 2020,
				Rating = Rating.TV14,
				Duration = "5 Seasons",
				Description = "An all-new 'Fab Five' advise men on fashion, grooming, food, culture and design in this modern reboot of the Emmy Award-winning reality series.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Reality TV"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1057,
				ShowType = ShowType.TV,
				Title = "Hannibal",
				Director = "",
				Cast = "Hugh Dancy, Mads Mikkelsen, Caroline Dhavernas, Hettienne Park, Laurence Fishburne, Scott Thompson, Aaron Abrams, Gillian Anderson, Lara Jean Chorostecki",
				DateAdded = new DateTime(2020, 6, 6),
				ReleaseYear = 2015,
				Rating = Rating.TVMA,
				Duration = "3 Seasons",
				Description = "This drama series focuses on the early years of the relationship between FBI criminal profiler Will Graham and homicidal cannibal Dr. Hannibal Lecter.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Horror"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1058,
				ShowType = ShowType.Movie,
				Title = "Before I Fall",
				Director = "Ry Russo-Young",
				Cast = "Zoey Deutch, Halston Sage, Erica Tremblay, Logan Miller, Cynthy Wu, Kian Lawley, Jennifer Beals, Medalion Rahimi, Diego Boneta, Elena Kampouris, Liv Hewson, G. Hannelius, Nicholas Lea, Claire Margaret Corlett, Roan Curtis",
				DateAdded = new DateTime(2020, 6, 8),
				ReleaseYear = 2017,
				Rating = Rating.PG13,
				Duration = "98 min",
				Description = "Forced to continually relive the day she dies in a car crash, a privileged high schooler must unravel the cosmic mystery of her suddenly looping life.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1059,
				ShowType = ShowType.TV,
				Title = "DC's Legends of Tomorrow",
				Director = "Rob Seidenglanz",
				Cast = "Victor Garber, Brandon Routh, Caity Lotz, Franz Drameh, Amy Pemberton, Dominic Purcell, Maisie Richardson-Sellers, Nick Zano, Arthur Darvill, Wentworth Miller, Tala Ashe, Adam Tsekhman, Christina Brucato, Simon Merrells, Nils Hognestad, Jes Macallan, Keiynan Lonsdale",
				DateAdded = new DateTime(2020, 6, 10),
				ReleaseYear = 2020,
				Rating = Rating.TV14,
				Duration = "5 Seasons",
				Description = "A mysterious 'time master' from the future unites an unlikely group of superheroes and villains to save the world from a powerful evil.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Action & Adventure"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1060,
				ShowType = ShowType.TV,
				Title = "Lenox Hill",
				Director = "",
				Cast = "",
				DateAdded = new DateTime(2020, 6, 10),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "1 Season",
				Description = "Four doctors at New York's storied Lenox Hill Hospital balance their personal lives and their dedication to their patients in this documentary series.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Docuseries"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1061,
				ShowType = ShowType.Movie,
				Title = "Jo Koy: In His Elements",
				Director = "Michael McKay",
				Cast = "Jo Koy, Andrew Lopez, Joey Guila, Andrew Orolfo",
				DateAdded = new DateTime(2020, 6, 12),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "55 min",
				Description = "Jo Koy brings the laughs and beats to Manila, spotlighting local culture in a one-of-a-kind show featuring Filipino American comedians, DJs and B-boys.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Stand-Up Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1062,
				ShowType = ShowType.TV,
				Title = "How to Get Away with Murder",
				Director = "",
				Cast = "Viola Davis, Billy Brown, Alfred Enoch, Jack Falahee, Katie Findlay, Aja Naomi King, Matt McGorry, Karla Souza, Charlie Weber, Liza Weil",
				DateAdded = new DateTime(2020, 6, 13),
				ReleaseYear = 2020,
				Rating = Rating.TV14,
				Duration = "6 Seasons",
				Description = "Brilliant criminal defense attorney and law professor Annalise Keating, plus five of her students, become involved in a twisted murder case.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Crime"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1063,
				ShowType = ShowType.Movie,
				Title = "The Darkness",
				Director = "Greg McLean",
				Cast = "Kevin Bacon, Radha Mitchell, David Mazouz, Lucy Fry, Matt Walsh, Jennifer Morrison, Parker Mack, Paul Reiser, Ming-Na Wen, Tara Lynne Barr",
				DateAdded = new DateTime(2020, 6, 16),
				ReleaseYear = 2016,
				Rating = Rating.PG13,
				Duration = "92 min",
				Description = "After bringing home a set of mysterious stones from the Grand Canyon, a boy unleashes an ancient force that begins to terrorize his family.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Horror"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1064,
				ShowType = ShowType.TV,
				Title = "The Order",
				Director = "",
				Cast = "Jake Manley, Sarah Grey, Max Martini, Matt Frewer, Adam DiMarco, Katharine Isabelle, Louriza Tronco, Aaron Hale, Devery Jacobs, Thomas Elms, Dylan Playfair, Ian Tracey, Sam Trammell",
				DateAdded = new DateTime(2020, 6, 18),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "2 Seasons",
				Description = "Out to avenge his mother's death, a college student pledges a secret order and lands in a war between werewolves and practitioners of dark magic.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Horror"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1065,
				ShowType = ShowType.TV,
				Title = "Babies",
				Director = "",
				Cast = "",
				DateAdded = new DateTime(2020, 6, 19),
				ReleaseYear = 2020,
				Rating = Rating.TV14,
				Duration = "2 Seasons",
				Description = "From nature to nurture, this docuseries explores the groundbreaking science that reveals how infants discover life during their very first year.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Docuseries"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1066,
				ShowType = ShowType.TV,
				Title = "Floor Is Lava",
				Director = "",
				Cast = "Rutledge Wood",
				DateAdded = new DateTime(2020, 6, 19),
				ReleaseYear = 2020,
				Rating = Rating.TVPG,
				Duration = "1 Season",
				Description = "Teams compete to navigate rooms flooded with lava by leaping from chairs, hanging from curtains and swinging from chandeliers. Yes, really.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Reality TV"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1067,
				ShowType = ShowType.Movie,
				Title = "Dark Skies",
				Director = "Scott Stewart",
				Cast = "Keri Russell, Josh Hamilton, J.K. Simmons, Dakota Goyo, Kadan Rockett, L.J. Benet, Rich Hutchman, Myndy Crist, Annie Thurman, Jake Brennan",
				DateAdded = new DateTime(2020, 6, 22),
				ReleaseYear = 2013,
				Rating = Rating.PG13,
				Duration = "97 min",
				Description = "A couple has trouble convincing friends and neighbors that an alien is entering their house each night to terrorize their children.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Horror"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1068,
				ShowType = ShowType.Movie,
				Title = "Athlete A",
				Director = "Bonni Cohen, Jon Shenk",
				Cast = "",
				DateAdded = new DateTime(2020, 6, 24),
				ReleaseYear = 2020,
				Rating = Rating.PG13,
				Duration = "104 min",
				Description = "This documentary focuses on the gymnasts who survived USA Gymnastics doctor Larry Nassar's abuse and the reporters who exposed USAG's toxic culture.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Documentary"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1069,
				ShowType = ShowType.Movie,
				Title = "Eurovision Song Contest: The Story of Fire Saga",
				Director = "David Dobkin",
				Cast = "Will Ferrell, Rachel McAdams, Dan Stevens, Melissanthi Mahut, Mikael Persbrandt, ??lafur Darri ??lafsson, Graham Norton, Demi Lovato, Pierce Brosnan",
				DateAdded = new DateTime(2020, 6, 26),
				ReleaseYear = 2020,
				Rating = Rating.PG13,
				Duration = "124 min",
				Description = "Two small-town singers chase their pop star dreams at a global music competition, where high stakes, scheming rivals and onstage mishaps test their bond.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1070,
				ShowType = ShowType.Movie,
				Title = "George Lopez: We'll Do It For Half",
				Director = "Troy Miller",
				Cast = "George Lopez",
				DateAdded = new DateTime(2020, 6, 30),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "52 min",
				Description = "Comedian George Lopez tackles the future and the past of Latinx culture in America, touching on immigration, his tough relatives, aging and much more.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Stand-Up Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1071,
				ShowType = ShowType.Movie,
				Title = "Fiddler on the Roof",
				Director = "Norman Jewison",
				Cast = "Topol, Norma Crane, Leonard Frey, Molly Picon, Paul Mann, Rosalind Harris, Michele Marsh, Neva Small, Paul Michael Glaser, Ray Lovelock",
				DateAdded = new DateTime(2020, 7, 1),
				ReleaseYear = 1971,
				Rating = Rating.G,
				Duration = "181 min",
				Description = "This adaptation of the musical chronicles the trials of a Jewish peasant, his wife, and their three strong-willed daughters in pre-revolutionary Russia.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Classics"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1072,
				ShowType = ShowType.TV,
				Title = "Kingdom",
				Director = "",
				Cast = "Frank Grillo, Kiele Sanchez, Matt Lauria, Jonathan Tucker, Nick Jonas, Joanna Going, Juliette Jackson, Paul Walter Hauser, Joe Stevenson",
				DateAdded = new DateTime(2020, 7, 1),
				ReleaseYear = 2017,
				Rating = Rating.TVMA,
				Duration = "3 Seasons",
				Description = "Struggling to keep his training center afloat, a former MMA legend faces more challenges as he tries to manage a complicated family dynamic.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1073,
				ShowType = ShowType.Movie,
				Title = "A Walk to Remember",
				Director = "Adam Shankman",
				Cast = "Mandy Moore, Shane West, Peter Coyote, Daryl Hannah, Lauren German, Clayne Crawford, Al Thompson",
				DateAdded = new DateTime(2020, 7, 1),
				ReleaseYear = 2002,
				Rating = Rating.PG,
				Duration = "102 min",
				Description = "When bad boy Landon is cast opposite campus bookworm Jamie in a high school play, romance blooms - until tragedy threatens to tear them apart.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Romance"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1074,
				ShowType = ShowType.TV,
				Title = "Supermarket Sweep",
				Director = "",
				Cast = "",
				DateAdded = new DateTime(2020, 7, 2),
				ReleaseYear = 1993,
				Rating = Rating.TVG,
				Duration = "1 Season",
				Description = "In this iconic game show, contestants answer food trivia questions then race against the clock while stuffing their carts for massive grocery gains.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Reality TV"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1075,
				ShowType = ShowType.Movie,
				Title = "November Criminals",
				Director = "Sacha Gervasi",
				Cast = "Ansel Elgort, Chloe Grace Moretz, David Strathairn, Catherine Keener, Terry Kinney, Cory Hardrict, Philip Ettinger, Danny Flaherty, Victor Williams, Tessa Albertson",
				DateAdded = new DateTime(2020, 7, 3),
				ReleaseYear = 2017,
				Rating = Rating.PG13,
				Duration = "86 min",
				Description = "Dissatisfied with the police's progress, a teen and his best friend investigate their classmate's murder, treading down a dark path to the uneasy truth.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1076,
				ShowType = ShowType.Movie,
				Title = "Desperados",
				Director = "LP",
				Cast = "Nasim Pedrad, Anna Camp, Lamorne Morris, Heather Graham, Robbie Amell, Sarah Burns, Jessica Chaffin",
				DateAdded = new DateTime(2020, 7, 3),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "107 min",
				Description = "After drunkenly sending a cringeworthy email, hopeless romantic Wes heads to Mexico with her best friends to erase the note before her new love reads it.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Romance"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1077,
				ShowType = ShowType.Movie,
				Title = "Mucho Mucho Amor: The Legend of Walter Mercado",
				Director = "Cristina Costantini, Kareem Tabsch",
				Cast = "Walter Mercado",
				DateAdded = new DateTime(2020, 7, 8),
				ReleaseYear = 2020,
				Rating = Rating.TV14,
				Duration = "96 min",
				Description = "Dazzling and tender-hearted, legendary astrologer Walter Mercado vanished at the peak of his fame. This documentary poignantly explains what happened.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Documentary"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1078,
				ShowType = ShowType.Movie,
				Title = "The Old Guard",
				Director = "Gina Prince-Bythewood",
				Cast = "Charlize Theron, KiKi Layne, Marwan Kenzari, Luca Marinelli, Harry Melling, Van Veronica Ngo, Matthias Schoenaerts, Chiwetel Ejiofor",
				DateAdded = new DateTime(2020, 7, 10),
				ReleaseYear = 2020,
				Rating = Rating.R,
				Duration = "126 min",
				Description = "Four undying warriors who've secretly protected humanity for centuries become targeted for their mysterious powers just as they discover a new immortal.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Action & Adventure"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1079,
				ShowType = ShowType.Movie,
				Title = "The Claudia Kishi Club",
				Director = "Sue Ding",
				Cast = "",
				DateAdded = new DateTime(2020, 7, 10),
				ReleaseYear = 2020,
				Rating = Rating.TV14,
				Duration = "17 min",
				Description = "Asian American creatives pay passionate tribute to the iconic, stereotype-busting 'Baby-Sitters Club' character in this heartfelt documentary short.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Documentary"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1080,
				ShowType = ShowType.TV,
				Title = "Down to Earth with Zac Efron",
				Director = "",
				Cast = "Zac Efron, Darin Olien",
				DateAdded = new DateTime(2020, 7, 10),
				ReleaseYear = 2020,
				Rating = Rating.TVPG,
				Duration = "1 Season",
				Description = "Actor Zac Efron journeys around the world with wellness expert Darin Olien in a travel show that explores healthy, sustainable ways to live.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Docuseries"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1081,
				ShowType = ShowType.TV,
				Title = "The Business of Drugs",
				Director = "",
				Cast = "Amaryllis Fox",
				DateAdded = new DateTime(2020, 7, 14),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "1 Season",
				Description = "To understand the origins and true impact of the business of drugs, a former CIA analyst investigates the economics of six illicit substances.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Docuseries"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1082,
				ShowType = ShowType.Movie,
				Title = "Fatal Affair",
				Director = "Peter Sullivan",
				Cast = "Nia Long, Omar Epps, Stephen Bishop, Maya Stojan, Aubrey Cleland, Carolyn Hennesy",
				DateAdded = new DateTime(2020, 7, 16),
				ReleaseYear = 2020,
				Rating = Rating.TV14,
				Duration = "90 min",
				Description = "A lawyer is caught in a terrifying game of cat and mouse when a drink with an old friend escalates into an obsession that jeopardizes everyone she loves.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Thriller"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1083,
				ShowType = ShowType.TV,
				Title = "The Last Dance",
				Director = "",
				Cast = "Michael Jordan, Scottie Pippen, Dennis Rodman",
				DateAdded = new DateTime(2020, 7, 19),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "1 Season",
				Description = "This docuseries gives a definitive account of Michael Jordan's career and the 1990s Chicago Bulls, packed with unaired footage from the 1997-98 season.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Docuseries"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1084,
				ShowType = ShowType.TV,
				Title = "Fear City: New York vs The Mafia",
				Director = "",
				Cast = "",
				DateAdded = new DateTime(2020, 7, 22),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "1 Season",
				Description = "Five Mafia families ruled New York with a bloody fist in the 1970s and '80s, until a group of federal agents tried the unthinkable: taking them down.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Crime"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1085,
				ShowType = ShowType.TV,
				Title = "Sinatra: All or Nothing at All",
				Director = "Alex Gibney",
				Cast = "",
				DateAdded = new DateTime(2020, 7, 23),
				ReleaseYear = 2015,
				Rating = Rating.TV14,
				Duration = "1 Season",
				Description = "Legendary crooner Frank Sinatra's life and talent are captured in this documentary series featuring fond memories from friends, family and colleagues.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Docuseries"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1086,
				ShowType = ShowType.Movie,
				Title = "Hickok",
				Director = "Timothy Woodward Jr.",
				Cast = "Luke Hemsworth, Trace Adkins, Kris Kristofferson, Bruce Dern, Cameron Richardson, Kaiwi Lyman, Hunter Fischer, Robert Catrini, Britain Simons",
				DateAdded = new DateTime(2020, 7, 24),
				ReleaseYear = 2017,
				Rating = Rating.TVMA,
				Duration = "88 min",
				Description = "While serving as the marshal of rowdy Abilene, Kansas, 'Wild Bill' Hickok uses guns and gall to tidy up the lawless frontier town.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Action & Adventure"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1087,
				ShowType = ShowType.Movie,
				Title = "Dragons: Rescue Riders: Secrets of the Songwing",
				Director = "Greg Rankin, TJ Sullivan",
				Cast = "Noah Kaye Bentley, Brennley Brown, Zach Callison, Nicolas Cantu, Skai Jackson, Marsai Martin, Andre Robinson, Carlos Alazraqui, Ren??e Elise Goldsberry",
				DateAdded = new DateTime(2020, 7, 24),
				ReleaseYear = 2020,
				Rating = Rating.TVY,
				Duration = "46 min",
				Description = "When a musical dragon with a beautiful voice hypnotizes the dragons and people of Huttsgalor, the Rescue Riders have to find a way to break the spell.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Family"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1088,
				ShowType = ShowType.Movie,
				Title = "Banana Split",
				Director = "Ben Kasulke",
				Cast = "Hannah Marks, Liana Liberato, Dylan Sprouse, Luke Spencer Roberts, Jessica Hecht, Addison Riecke, Meagan Kimberly Smith, Haley Ramm",
				DateAdded = new DateTime(2020, 7, 26),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "84 min",
				Description = "Despite leaving for college, a heartsick teen tries to build a new friendship with a kindred spirit even though she's dating her ex-boyfriend.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1089,
				ShowType = ShowType.TV,
				Title = "Last Chance U",
				Director = "",
				Cast = "John Franklin III, DJ Law, Buddy Stephens, Brittany Wagner, Ronald Ollie",
				DateAdded = new DateTime(2020, 7, 28),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "5 Seasons",
				Description = "In a docuseries set at one of NCAA football's most fertile recruiting grounds, guys with red flags seek to prove their worth on the field and in class.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Docuseries"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1090,
				ShowType = ShowType.Movie,
				Title = "Tread",
				Director = "Paul Solet",
				Cast = "",
				DateAdded = new DateTime(2020, 7, 29),
				ReleaseYear = 2019,
				Rating = Rating.TVMA,
				Duration = "88 min",
				Description = "This documentary reconstructs the pivotal moments that drove a man on a rampage to destroy a small town with a bulldozer he fortified in secret.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Documentary"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1091,
				ShowType = ShowType.Movie,
				Title = "The Speed Cubers",
				Director = "Sue Kim",
				Cast = "",
				DateAdded = new DateTime(2020, 7, 29),
				ReleaseYear = 2020,
				Rating = Rating.TVPG,
				Duration = "41 min",
				Description = "This documentary captures the extraordinary twists and turns in the journeys of Rubik's Cube-solving champions Max Park and Feliks Zemdegs.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Documentary"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1092,
				ShowType = ShowType.Movie,
				Title = "Sugar High",
				Director = "Ariel Boles",
				Cast = "Hunter March",
				DateAdded = new DateTime(2020, 7, 31),
				ReleaseYear = 2020,
				Rating = Rating.TVG,
				Duration = "44 min",
				Description = "Talented sugar artists compete for $10,000 over two rounds of competition -  candy and sugar sculpture - in this 'Sugar Rush' spinoff special.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Family"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1093,
				ShowType = ShowType.Movie,
				Title = "Rogue Warfare: The Hunt",
				Director = "Mike Gunther",
				Cast = "Will Yun Lee, Jermaine Love, Rory Markham, Bertrand-Xavier Corbi, Katie Keene, Fernando Chien, Gina DeCesare, Michael Blalock, Chris Mulkey, Stephen Lang",
				DateAdded = new DateTime(2020, 8, 1),
				ReleaseYear = 2020,
				Rating = Rating.R,
				Duration = "104 min",
				Description = "When their leader is captured by an extremist organization, a special forces team stages a perilous rescue mission as time runs out.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Action & Adventure"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1094,
				ShowType = ShowType.Movie,
				Title = "Mr. Deeds",
				Director = "Steve Brill",
				Cast = "Adam Sandler, Winona Ryder, Peter Gallagher, Jared Harris, Allen Covert, Erick Avari, John Turturro, Peter Dante, Conchata Ferrell, Steve Buscemi",
				DateAdded = new DateTime(2020, 8, 1),
				ReleaseYear = 2002,
				Rating = Rating.PG13,
				Duration = "97 min",
				Description = "After inheriting a media empire, humble Longfellow Deeds moves to the Big Apple, where a reporter and a company bigwig are waiting to pounce on him.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1095,
				ShowType = ShowType.Movie,
				Title = "Death at a Funeral",
				Director = "Neil LaBute",
				Cast = "Chris Rock, Martin Lawrence, Tracy Morgan, Danny Glover, James Marsden, Luke Wilson, Zoe Saldana, Regina Hall, Columbus Short, Peter Dinklage, Kevin Hart, Loretta Devine, Regine Nehy, Keith David, Ron Glass",
				DateAdded = new DateTime(2020, 8, 1),
				ReleaseYear = 2010,
				Rating = Rating.R,
				Duration = "93 min",
				Description = "When a Los Angeles family's patriarch dies, his dutiful eldest son plans the funeral - which becomes a fiasco thanks to a colorful cast of attendees.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1096,
				ShowType = ShowType.Movie,
				Title = "Killing Hasselhoff",
				Director = "Darren Grant",
				Cast = "Ken Jeong, David Hasselhoff, Jim Jefferies, Jon Lovitz, Rhys Darby, Dan Bakkedahl, Jennifer Ikeda, Will Sasso, Colton Dunn",
				DateAdded = new DateTime(2020, 8, 1),
				ReleaseYear = 2017,
				Rating = Rating.R,
				Duration = "80 min",
				Description = "In major debt to a loan shark, a nightclub owner who's entered in a celebrity death pool tries to murder a famous figure for half a million dollars.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1097,
				ShowType = ShowType.TV,
				Title = "Moesha",
				Director = "",
				Cast = "Brandy Norwood, William Allen Young, Sheryl Lee Ralph, Countess Vaughn, Lamont Bentley, Shar Jackson, Marcus T. Paulk, Yvette Wilson",
				DateAdded = new DateTime(2020, 8, 1),
				ReleaseYear = 2000,
				Rating = Rating.TVPG,
				Duration = "6 Seasons",
				Description = "Navigating the twists and firsts of high school, Moesha juggles friendships, romance and the occasional drama while trying to keep her family together.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1098,
				ShowType = ShowType.Movie,
				Title = "Remember Me",
				Director = "Allen Coulter",
				Cast = "Robert Pattinson, Emilie de Ravin, Chris Cooper, Lena Olin, Pierce Brosnan, Tate Ellington, Ruby Jerins, Gregory Jbara, Meghan Markle",
				DateAdded = new DateTime(2020, 8, 1),
				ReleaseYear = 2010,
				Rating = Rating.PG13,
				Duration = "112 min",
				Description = "Tyler's still feeling lost following the tragedy that's strained his relationship with his father when he meets Ally, a girl who understands his pain.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1099,
				ShowType = ShowType.Movie,
				Title = "Almost Love",
				Director = "Mike Doyle",
				Cast = "Scott Evans, Augustus Prew, Kate Walsh, Michelle Buteau, Zo?? Chao, Patricia Clarkson, Colin Donnell, Christopher Gray",
				DateAdded = new DateTime(2020, 8, 2),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "92 min",
				Description = "A close crew of striving New Yorkers experiences both joy and heartache in their romantic and professional lives.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1100,
				ShowType = ShowType.Movie,
				Title = "Pick of the Litter",
				Director = "Dana Nachman, Don Hardy Jr.",
				Cast = "",
				DateAdded = new DateTime(2020, 8, 2),
				ReleaseYear = 2018,
				Rating = Rating.TVPG,
				Duration = "81 min",
				Description = "Five Labrador puppies embark on a 20-month training to pass the milestones on their journey to becoming guide dogs for people with visual impairment.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Family"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1101,
				ShowType = ShowType.TV,
				Title = "Immigration Nation",
				Director = "",
				Cast = "",
				DateAdded = new DateTime(2020, 8, 3),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "1 Season",
				Description = "With unprecedented access to ICE operations, as well as moving portraits of immigrants, this docuseries takes a deep look at US immigration today.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Docuseries"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1102,
				ShowType = ShowType.TV,
				Title = "World's Most Wanted",
				Director = "",
				Cast = "",
				DateAdded = new DateTime(2020, 8, 5),
				ReleaseYear = 2020,
				Rating = Rating.TV14,
				Duration = "1 Season",
				Description = "Suspected of heinous crimes, they've avoided capture despite massive rewards and global investigations. A docuseries profiling the world's most wanted.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Crime"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1103,
				ShowType = ShowType.Movie,
				Title = "Work It",
				Director = "Laura Terruso",
				Cast = "Sabrina Carpenter, Jordan Fisher, Liza Koshy, Keiynan Lonsdale, Michelle Buteau, Drew Ray Tanner",
				DateAdded = new DateTime(2020, 8, 7),
				ReleaseYear = 2020,
				Rating = Rating.TV14,
				Duration = "94 min",
				Description = "A brilliant but clumsy high school senior vows to get into her late father's alma mater by transforming herself and a misfit squad into dance champions.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1104,
				ShowType = ShowType.Movie,
				Title = "The Magic School Bus Rides Again Kids In Space",
				Director = "Richard Weston",
				Cast = "Kate McKinnon, Matthew Mucci, Mikaela Blake, Gabby Clarke, Roman Lutterotti, Leke Maceda-Rustecki, Birva Pandya, Lynsey Pham, Kaden Stephen",
				DateAdded = new DateTime(2020, 8, 7),
				ReleaseYear = 2020,
				Rating = Rating.TVY,
				Duration = "46 min",
				Description = "The Magic School Bus kids blast into orbit -  and onto the International Space Station - only to find themselves on the run from a giant tardigrade!",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Family"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1105,
				ShowType = ShowType.Movie,
				Title = "The Lost Husband",
				Director = "Vicky Wight",
				Cast = "Leslie Bibb, Josh Duhamel, Nora Dunn, Sharon Lawrence, Callie Hope Haverda, Roxton Garcia",
				DateAdded = new DateTime(2020, 8, 10),
				ReleaseYear = 2020,
				Rating = Rating.PG13,
				Duration = "110 min",
				Description = "Looking to start anew, a widow retreats with her children to her aunt's goat farm, where the ranch's manager helps her navigate country life and loss.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1106,
				ShowType = ShowType.Movie,
				Title = "Mr. Peabody & Sherman",
				Director = "Rob Minkoff",
				Cast = "Ty Burrell, Max Charles, Ariel Winter, Stephen Colbert, Leslie Mann, Stanley Tucci, Allison Janney, Mel Brooks, Patrick Warburton, Stephen Tobolowsky, Lake Bell",
				DateAdded = new DateTime(2020, 8, 11),
				ReleaseYear = 2014,
				Rating = Rating.PG,
				Duration = "93 min",
				Description = "Resurrected from the 1960s animated series 'Rocky and Bullwinkle,' canine genius Mr. Peabody and young Sherman take a dizzying ride through time.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Family"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1107,
				ShowType = ShowType.Movie,
				Title = "Safety Not Guaranteed",
				Director = "Colin Trevorrow",
				Cast = "Aubrey Plaza, Mark Duplass, Jake Johnson, Mary Lynn Rajskub, Jeff Garlin, Kristen Bell, Jenica Bergere, Karan Soni",
				DateAdded = new DateTime(2020, 8, 13),
				ReleaseYear = 2012,
				Rating = Rating.R,
				Duration = "86 min",
				Description = "A team of journalists are sent to find out who's behind a classified ad seeking a companion for time travel, then must decide how to approach him.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Romance"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1108,
				ShowType = ShowType.Movie,
				Title = "Project Power",
				Director = "Henry Joost, Ariel Schulman",
				Cast = "Jamie Foxx, Joseph Gordon-Levitt, Dominique Fishback, Rodrigo Santoro, Courtney B. Vance, Amy Landecker, Machine Gun Kelly, Tait Fletcher, Allen Maldonado, Andrene Ward-Hammond",
				DateAdded = new DateTime(2020, 8, 14),
				ReleaseYear = 2020,
				Rating = Rating.R,
				Duration = "113 min",
				Description = "An ex-soldier, a teen and a cop collide in New Orleans as they hunt for the source behind a dangerous new pill that grants users temporary superpowers.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Action & Adventure"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1109,
				ShowType = ShowType.TV,
				Title = "Teenage Bounty Hunters",
				Director = "",
				Cast = "Anjelica Bette Fellini, Maddie Phillips, Kadeem Hardison, Virginia Williams, Mackenzie Astin, Shirley Rumierk, Myles Evans, Devon Hales, Spencer House, Eric Graise, Charity Cervantes, Wynn Everett, Method Man",
				DateAdded = new DateTime(2020, 8, 14),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "1 Season",
				Description = "Twin sisters Sterling and Blair balance teen life at an elite Southern high school with an unlikely new career as butt-kicking bounty hunters.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Crime"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1110,
				ShowType = ShowType.TV,
				Title = "The Game",
				Director = "",
				Cast = "Tia Mowry-Hardrict, Pooch Hall, Coby Bell, Wendy Raquel Robinson, Hosea Chanchez, Brittany Daniel, Barry Floyd",
				DateAdded = new DateTime(2020, 8, 15),
				ReleaseYear = 2008,
				Rating = Rating.TV14,
				Duration = "3 Seasons",
				Description = "Medical school student Melanie adjusts to life in the world of professional sports when her boyfriend Derwin becomes a pro football player.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Romance"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1111,
				ShowType = ShowType.TV,
				Title = "High Score",
				Director = "",
				Cast = "",
				DateAdded = new DateTime(2020, 8, 19),
				ReleaseYear = 2020,
				Rating = Rating.TV14,
				Duration = "1 Season",
				Description = "This docuseries traces the history of classic video games, featuring insights from the innovators who brought these worlds and characters to life.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Docuseries"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1112,
				ShowType = ShowType.TV,
				Title = "DeMarcus Family Rules",
				Director = "",
				Cast = "",
				DateAdded = new DateTime(2020, 8, 19),
				ReleaseYear = 2020,
				Rating = Rating.TV14,
				Duration = "1 Season",
				Description = "Rascal Flatts bassist Jay DeMarcus and ex-beauty queen Allison DeMarcus write their own rules for juggling family and fun in this reality show.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Reality TV"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1113,
				ShowType = ShowType.Movie,
				Title = "John Was Trying to Contact Aliens",
				Director = "",
				Cast = "",
				DateAdded = new DateTime(2020, 8, 20),
				ReleaseYear = 2020,
				Rating = Rating.TVPG,
				Duration = "17 min",
				Description = "A rural electronics whiz broadcasts radio signals into space and monitors for signs of aliens, but makes a more important connection here on Earth.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Documentary"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1114,
				ShowType = ShowType.TV,
				Title = "Hoops",
				Director = "",
				Cast = "Jake Johnson, Ron Funches, Cleo King, Natasha Leggero, A.D. Miles, Rob Riggle, Steve Berg, Eric Edelstein, Ben Hoffman, Mary Holland, Gil Ozeri, Sam Richardson, Nick Swardson",
				DateAdded = new DateTime(2020, 8, 21),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "1 Season",
				Description = "A foul-mouthed high school basketball coach is sure he'll hit the big leagues if he can only turn his terrible team around. Good luck with that.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1115,
				ShowType = ShowType.Movie,
				Title = "1BR",
				Director = "David Marmor",
				Cast = "Nicole Brydon Bloom, Giles Matthey, Taylor Nichols, Alan Blumenfeld, Celeste Sully, Susan Davis, Clayton Hoff, Earnestine Phillips",
				DateAdded = new DateTime(2020, 8, 23),
				ReleaseYear = 2019,
				Rating = Rating.TVMA,
				Duration = "90 min",
				Description = "Seeking her independence, a young woman moves to Los Angeles and settles into a cozy apartment complex with a disturbing sense of community.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Horror"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1116,
				ShowType = ShowType.Movie,
				Title = "Septembers of Shiraz",
				Director = "Wayne Blair",
				Cast = "Adrien Brody, Salma Hayek, Shohreh Aghdashloo, Alon Aboutboul, Navid Navid, Ariana Molkara, Nasser Memarzia, Jamie Ward, Anthony Azizi, Liron Levo, Gabriella Wright",
				DateAdded = new DateTime(2020, 8, 24),
				ReleaseYear = 2016,
				Rating = Rating.PG13,
				Duration = "110 min",
				Description = "In post-revolution Tehran, a wealthy Jewish businessman is summarily jailed and tortured, but along with his wife, he fights for answers and freedom.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1117,
				ShowType = ShowType.TV,
				Title = "Trinkets",
				Director = "",
				Cast = "Brianna Hildebrand, Kiana Madeira, Quintessa Swindell, Brandon Butler, Odiseas Georgiadis, Henry Zaga, Larry Sullivan, Larisa Oleynik",
				DateAdded = new DateTime(2020, 8, 25),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "2 Seasons",
				Description = "A grieving teen finds an unexpected connection with two classmates at her new high school after they all land in the same Shoplifters Anonymous group.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1118,
				ShowType = ShowType.Movie,
				Title = "Making The Witcher",
				Director = "Nathan Wiley",
				Cast = "Henry Cavill, Anya Chalotra, Freya Allan, Eamon Farren, Mimi Ndiweni, Adam Levy, MyAnna Buring, Joey Batey, Lauren Schmidt Hissrich, Tomasz Bagi??ski, Andrew Laws, Sneha Koorse, Declan De Barra, Beau DeMayo, Simon Emanuel, Iv??n Poh??rnok, Tim Aslam, Charlotte Br??ndstr??m",
				DateAdded = new DateTime(2020, 8, 26),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "33 min",
				Description = "Journey into the extraordinary world of 'The Witcher' from casting the roles to Jaskier's catchy song in this behind-the-scenes look at the series.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Documentary"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1119,
				ShowType = ShowType.Movie,
				Title = "The Young Messiah",
				Director = "Cyrus Nowrasteh",
				Cast = "Adam Greaves-Neal, Sara Lazzaro, Vincent Walsh, Sean Bean, Jonathan Bailey, Agni Scott",
				DateAdded = new DateTime(2020, 8, 27),
				ReleaseYear = 2016,
				Rating = Rating.PG13,
				Duration = "111 min",
				Description = "Tormented by a demon and on the run from a Roman centurion, a 7-year-old Jesus and his parents, Mary and Joseph, flee Egypt for Nazareth.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1120,
				ShowType = ShowType.Movie,
				Title = "Night Comes On",
				Director = "Jordana Spiro",
				Cast = "Dominique Fishback, Tatum Marilyn Hall, Nastashia Fuller, Angel Bismark Curiel, John Earl Jelks, Max Casella, James McDaniel, Cymbal Byrd",
				DateAdded = new DateTime(2020, 8, 27),
				ReleaseYear = 2018,
				Rating = Rating.TVMA,
				Duration = "87 min",
				Description = "A teen fresh out of juvenile detention tries to rescue her sister from foster care in order to exact revenge on their father for their mother's murder.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1121,
				ShowType = ShowType.Movie,
				Title = "The Frozen Ground",
				Director = "Scott Walker",
				Cast = "Nicolas Cage, John Cusack, Vanessa Hudgens, Dean Norris, Radha Mitchell, 50 Cent, Kevin Dunn, Olga Valentina, Michael McGrady, Jodi Lyn O'Keefe",
				DateAdded = new DateTime(2020, 8, 27),
				ReleaseYear = 2013,
				Rating = Rating.R,
				Duration = "106 min",
				Description = "In this fact-based thriller, an Alaska state trooper pursuing a serial killer teams with a 17-year-old-prostitute who escaped the predator's clutches.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1122,
				ShowType = ShowType.Movie,
				Title = "A Princess for Christmas",
				Director = "Michael Damian",
				Cast = "Katie McGrath, Sir Roger Moore, Sam Heughan, Travis Turner, Leilah de Meza, Miles Richardson, Charlotte Salt",
				DateAdded = new DateTime(2020, 8, 28),
				ReleaseYear = 2011,
				Rating = Rating.TVPG,
				Duration = "91 min",
				Description = "At the invitation of a relative, young Jules Daly travels with her niece and nephew to a castle in Europe, where Jules falls for a dashing prince.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Romance"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1123,
				ShowType = ShowType.Movie,
				Title = "Blaze",
				Director = "Ethan Hawke",
				Cast = "Benjamin Dickey, Alia Shawkat, Josh Hamilton, Charlie Sexton, Sam Rockwell, Wyatt Russell, Steve Zahn, Kris Kristofferson, Richard Linklater, David Kallaway, Ritchie Montgomery",
				DateAdded = new DateTime(2020, 8, 30),
				ReleaseYear = 2018,
				Rating = Rating.R,
				Duration = "129 min",
				Description = "An influential, if unsung country songwriter reflects on his career, and how the love of his life drove him to write his most personal music.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1124,
				ShowType = ShowType.Movie,
				Title = "The Debt Collector 2",
				Director = "Jesse V. Johnson",
				Cast = "Scott Adkins, Louis Mandylor, Vladimir Kulich, Marina Sirtis, Ski Carr, Charity Collins, Mayling Ng, Josef Cannon, Jermaine Jacox, Vernon Wells",
				DateAdded = new DateTime(2020, 8, 31),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "97 min",
				Description = "French and Sue have two days to collect on three debts, using as much force as it takes - all while evading the wrath of a crime lord out for revenge.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Action & Adventure"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1125,
				ShowType = ShowType.Movie,
				Title = "Wildlife",
				Director = "Paul Dano",
				Cast = "Carey Mulligan, Ed Oxenbould, Bill Camp, Jake Gyllenhaal, Mollie Milligan, Darryl Cox",
				DateAdded = new DateTime(2020, 9, 1),
				ReleaseYear = 2018,
				Rating = Rating.PG13,
				Duration = "105 min",
				Description = "A teen's life in 1960 Montana grows complicated when his father is fired, his mother returns to work, and the strain on the family begins to show.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1126,
				ShowType = ShowType.Movie,
				Title = "The Muppets",
				Director = "James Bobin",
				Cast = "Jason Segel, Amy Adams, Chris Cooper, Rashida Jones, Kermit the Frog, Miss Piggy, Fozzie Bear, Gonzo, Muppets, Steve Whitmire, Eric Jacobson, Dave Goelz, Bill Barretta, David Rudman, Matt Vogel, Peter Linz",
				DateAdded = new DateTime(2020, 9, 1),
				ReleaseYear = 2011,
				Rating = Rating.PG,
				Duration = "104 min",
				Description = "When the Muppets learn that their beloved theater is slated for demolition, the gang reunite to raise the $10 million they need to save it.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Family"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1127,
				ShowType = ShowType.Movie,
				Title = "Muppets Most Wanted",
				Director = "James Bobin",
				Cast = "Ricky Gervais, Ty Burrell, Tina Fey, Kermit the Frog, Miss Piggy, Fozzie Bear, Gonzo, Muppets, Steve Whitmire, Eric Jacobson, Dave Goelz, Bill Barretta, David Rudman, Matt Vogel, Peter Linz",
				DateAdded = new DateTime(2020, 9, 1),
				ReleaseYear = 2014,
				Rating = Rating.PG,
				Duration = "110 min",
				Description = "In the middle of their global tour, the Muppets inadvertently get mixed up in a perilous drama involving a gang of international jewel thieves.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Family"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1128,
				ShowType = ShowType.Movie,
				Title = "Barbie Princess Adventure",
				Director = "Conrad Helten",
				Cast = "America Young, Erica Lindbeck, Ritesh Rajan, Dave Fennoy, Stephanie Sheh, Cristina Milizia, Desirae Whitfield, Emma Galvin, Angelo Restaino, Eamon Brennan, Ogie Banks",
				DateAdded = new DateTime(2020, 9, 1),
				ReleaseYear = 2020,
				Rating = Rating.TVY,
				Duration = "72 min",
				Description = "Through music and magic, Barbie learns what it's like to be a modern princess when she trades places with a royal lookalike.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Family"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1129,
				ShowType = ShowType.Movie,
				Title = "Love, Guaranteed",
				Director = "Mark Steven Johnson",
				Cast = "Rachael Leigh Cook, Damon Wayans Jr., Heather Graham, Caitlin Howden, Brendan Taylor, Sebastian Billingsley-Rodriguez, Sean Amsing, Lisa Durupt, Alvin Sanders, Jed Rees, Kandyse McClure",
				DateAdded = new DateTime(2020, 9, 3),
				ReleaseYear = 2020,
				Rating = Rating.TVPG,
				Duration = "91 min",
				Description = "Sparks fly when a crusading but cash-strapped attorney takes on a charming client looking to sue a dating site that guarantees its users will find love.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Romance"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1130,
				ShowType = ShowType.Movie,
				Title = "I'm Thinking of Ending Things",
				Director = "Charlie Kaufman",
				Cast = "Jessie Buckley, Jesse Plemons, Toni Collette, David Thewlis, Guy Boyd",
				DateAdded = new DateTime(2020, 9, 4),
				ReleaseYear = 2020,
				Rating = Rating.R,
				Duration = "135 min",
				Description = "Nothing is as it seems when a woman experiencing misgivings about her new boyfriend joins him on a road trip to meet his parents at their remote farm.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1131,
				ShowType = ShowType.Movie,
				Title = "Waiting for 'Superman'",
				Director = "Davis Guggenheim",
				Cast = "",
				DateAdded = new DateTime(2020, 9, 7),
				ReleaseYear = 2010,
				Rating = Rating.PG,
				Duration = "111 min",
				Description = "This dynamic documentary weaves together stories about students, educators and reformers to shed light on America's failing public school system.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Documentary"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1132,
				ShowType = ShowType.Movie,
				Title = "The Social Dilemma",
				Director = "Jeff Orlowski",
				Cast = "Skyler Gisondo, Kara Hayward, Vincent Kartheiser",
				DateAdded = new DateTime(2020, 9, 9),
				ReleaseYear = 2020,
				Rating = Rating.PG13,
				Duration = "94 min",
				Description = "This documentary-drama hybrid explores the dangerous human impact of social networking, with tech experts sounding the alarm on their own creations.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Documentary"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1133,
				ShowType = ShowType.Movie,
				Title = "The Babysitter: Killer Queen",
				Director = "McG",
				Cast = "Judah Lewis, Jenna Ortega, Emily Alyn Lind, Andrew Bachelor, Robbie Amell, Bella Thorne, Hana Mae Lee, Ken Marino, Leslie Bibb, Chris Wylde, Carl McDowell",
				DateAdded = new DateTime(2020, 9, 10),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "102 min",
				Description = "Two years after Cole survived a satanic blood cult, he's living another nightmare: high school. And the demons from his past? Still making his life hell.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Horror"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1134,
				ShowType = ShowType.TV,
				Title = "Girlfriends",
				Director = "",
				Cast = "Tracee Ellis Ross, Golden Brooks, Persia White, Jill Marie Jones, Reginald C. Hayes",
				DateAdded = new DateTime(2020, 9, 11),
				ReleaseYear = 2007,
				Rating = Rating.TV14,
				Duration = "8 Seasons",
				Description = "Four close friends in Los Angeles challenge and support each other through life's triumphs and disasters. Sophisticated, relatable and always funny.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1135,
				ShowType = ShowType.Movie,
				Title = "How to Train Your Dragon 2",
				Director = "Dean DeBlois",
				Cast = "Jay Baruchel, Cate Blanchett, Gerard Butler, Craig Ferguson, America Ferrera, Jonah Hill, Christopher Mintz-Plasse, T.J. Miller, Kristen Wiig, Djimon Hounsou, Kit Harington",
				DateAdded = new DateTime(2020, 9, 11),
				ReleaseYear = 2014,
				Rating = Rating.PG,
				Duration = "102 min",
				Description = "Hiccup, Toothless and a mysterious dragon rider join forces to protect the island of Berk from a power-hungry warrior with a dragon army of his own.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Family"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1136,
				ShowType = ShowType.Movie,
				Title = "Tortilla Soup",
				Director = "Maria Ripoll",
				Cast = "Hector Elizondo, Jacqueline Obradors, Elizabeth Pe??a, Tamara Mello, Nikolai Kinski, Raquel Welch, Joel Joan, Paul Rodriguez, Constance Marie, Julio Oscar Mechoso",
				DateAdded = new DateTime(2020, 9, 15),
				ReleaseYear = 2001,
				Rating = Rating.PG13,
				Duration = "104 min",
				Description = "Widower Martin is a restaurateur with a booming business and three headstrong daughters who leave the house to pursue their individual destinies.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1137,
				ShowType = ShowType.TV,
				Title = "Cold Case Files Classic",
				Director = "",
				Cast = "Bill Kurtis",
				DateAdded = new DateTime(2020, 9, 15),
				ReleaseYear = 1999,
				Rating = Rating.TVMA,
				Duration = "1 Season",
				Description = "Through forensic science and criminal psychology, an elite breed of detectives reexamine long-unsolved crimes to deliver justice and the truth.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Crime"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1138,
				ShowType = ShowType.Movie,
				Title = "East Side Sushi",
				Director = "Anthony Lucero",
				Cast = "Diana Elizabeth Torres, Yutaka Takeuchi, Rodrigo Duarte Clark, Kaya Jade Aguirre, Roji Oyama, Lane Nishikawa, Miyoko Sakatani",
				DateAdded = new DateTime(2020, 9, 15),
				ReleaseYear = 2015,
				Rating = Rating.PG,
				Duration = "106 min",
				Description = "She's not the usual candidate for the role, but a dogged Mexican-American mother makes it her mission to become a talented sushi chef.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1139,
				ShowType = ShowType.TV,
				Title = "Challenger",
				Director = "",
				Cast = "",
				DateAdded = new DateTime(2020, 9, 16),
				ReleaseYear = 2020,
				Rating = Rating.TV14,
				Duration = "1 Season",
				Description = "Engineers, officials and the crew members' families provide their perspective on the 1986 Space Shuttle Challenger disaster and its aftermath.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Docuseries"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1140,
				ShowType = ShowType.Movie,
				Title = "Residue",
				Director = "Merawi Gerima",
				Cast = "Obinna Nwachukwu, Dennis Lindsey, Taline Stewart, Derron Scott, Jamal Graham, JaCari Dye, Julian Selman, Melody Tally, Ramon Thompson, Hasinatu Camara",
				DateAdded = new DateTime(2020, 9, 17),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "90 min",
				Description = "A young screenwriter returns to his hometown to write a script based on his childhood and discovers his neighborhood has been gentrified.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1141,
				ShowType = ShowType.TV,
				Title = "The Blacklist",
				Director = "",
				Cast = "James Spader, Megan Boone, Diego Klattenhoff, Ryan Eggold, Harry Lennix, Amir Arison, Hisham Tawfiq, Mozhan Marno",
				DateAdded = new DateTime(2020, 9, 18),
				ReleaseYear = 2019,
				Rating = Rating.TV14,
				Duration = "7 Seasons",
				Description = "After turning himself in, a brilliant fugitive offers to help the FBI bag other baddies, but only if rookie profiler Elizabeth Keen is his partner.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Crime"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1142,
				ShowType = ShowType.TV,
				Title = "The American Barbecue Showdown",
				Director = "",
				Cast = "Lyric Lewis, Rutledge Wood",
				DateAdded = new DateTime(2020, 9, 18),
				ReleaseYear = 2020,
				Rating = Rating.TVG,
				Duration = "1 Season",
				Description = "Eight of the country's best backyard smokers and pitmasters vie for the title of American Barbecue Champion in a fierce but friendly faceoff.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Reality TV"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1143,
				ShowType = ShowType.Movie,
				Title = "Kiss the Ground",
				Director = "Joshua Tickell, Rebecca Harrell Tickell",
				Cast = "Woody Harrelson",
				DateAdded = new DateTime(2020, 9, 22),
				ReleaseYear = 2020,
				Rating = Rating.TVG,
				Duration = "85 min",
				Description = "Science experts and celebrity activists unpack the ways in which the earth's soil may be the key to combating climate change and preserving the planet.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Documentary"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1144,
				ShowType = ShowType.TV,
				Title = "The Playbook",
				Director = "",
				Cast = "",
				DateAdded = new DateTime(2020, 9, 22),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "1 Season",
				Description = "Coaches with championship resumes share their personal rules for success in sports and life in this reflective and inspiring documentary series.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Docuseries"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1145,
				ShowType = ShowType.Movie,
				Title = "Waiting...",
				Director = "Rob McKittrick",
				Cast = "Ryan Reynolds, Anna Faris, Justin Long, David Koechner, Luis Guzm??n, Chi McBride, John Francis Daley, Kaitlin Doubleday, Rob Benedict, Alanna Ubach, Vanessa Lengies, Dane Cook",
				DateAdded = new DateTime(2020, 9, 23),
				ReleaseYear = 2005,
				Rating = Rating.R,
				Duration = "94 min",
				Description = "Employees turn up the antics during an eight-hour shift at the restaurant Shenaniganz when new opportunities call and boredom gets the best of them.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1146,
				ShowType = ShowType.TV,
				Title = "The Chef Show",
				Director = "",
				Cast = "Jon Favreau, Roy Choi",
				DateAdded = new DateTime(2020, 9, 24),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "4 Seasons",
				Description = "Writer, director and food enthusiast Jon Favreau and chef Roy Choi explore food in and out of the kitchen with accomplished chefs and celebrity friends.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Docuseries"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1147,
				ShowType = ShowType.TV,
				Title = "Sneakerheads",
				Director = "",
				Cast = "Allen Maldonado, Andrew Bachelor, Jearnest Corchado, Matthew Josten, Yaani King Mondschein, Justin Lee, Aja Evans",
				DateAdded = new DateTime(2020, 9, 25),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "1 Season",
				Description = "Family man Devin falls back into his sneaker obsession after his pal Bobby talks him into a wheeling-dealing scheme to score a mythical pair of kicks.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1148,
				ShowType = ShowType.TV,
				Title = "The Good Place",
				Director = "",
				Cast = "Kristen Bell, Ted Danson, William Jackson Harper, Jameela Jamil, D'Arcy Carden, Manny Jacinto",
				DateAdded = new DateTime(2020, 9, 26),
				ReleaseYear = 2020,
				Rating = Rating.TV14,
				Duration = "4 Seasons",
				Description = "Due to an error, self-absorbed Eleanor Shellstrop arrives at the Good Place after her death. Determined to stay, she tries to become a better person.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1149,
				ShowType = ShowType.Movie,
				Title = "Bully",
				Director = "Lee Hirsch",
				Cast = "",
				DateAdded = new DateTime(2020, 9, 29),
				ReleaseYear = 2012,
				Rating = Rating.PG13,
				Duration = "98 min",
				Description = "This eye-opening documentary tracks the stories of five different families whose children are struggling to defend themselves from school bullies.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Documentary"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1150,
				ShowType = ShowType.Movie,
				Title = "Michelle Buteau: Welcome to Buteaupia",
				Director = "Page Hurwitz",
				Cast = "Michelle Buteau",
				DateAdded = new DateTime(2020, 9, 29),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "59 min",
				Description = "Scene-stealing queen Michelle Buteau dazzles with real talk on relationships, parenthood, cultural differences and the government workers who adore her.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Stand-Up Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1151,
				ShowType = ShowType.TV,
				Title = "Man with a Plan",
				Director = "",
				Cast = "Matt LeBlanc, Liza Snyder, Grace Kaufman, Matthew McCann, Hala Finley, Matt Cook, Jessica Chaffin",
				DateAdded = new DateTime(2020, 9, 30),
				ReleaseYear = 2020,
				Rating = Rating.TVPG,
				Duration = "4 Seasons",
				Description = "When his wife Andi returns to work, contractor Adam Burns becomes a stay-at-home dad and discovers that parenting is a tougher job than he realized.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1152,
				ShowType = ShowType.Movie,
				Title = "The Boys in the Band: Something Personal",
				Director = "",
				Cast = "Jim Parsons, Zachary Quinto, Matt Bomer, Andrew Rannells, Charlie Carver, Robin de Jes??s, Brian Hutchison, Michael Benjamin Washington, Tuc Watkins, Joe Mantello, Ned Martel, Mart Crowley",
				DateAdded = new DateTime(2020, 9, 30),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "28 min",
				Description = "Decades after his play first put gay life center stage, Mart Crowley joins the cast and crew of the 2020 film to reflect on the story's enduring legacy.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Documentary"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1153,
				ShowType = ShowType.Movie,
				Title = "American Murder: The Family Next Door",
				Director = "Jenny Popplewell",
				Cast = "",
				DateAdded = new DateTime(2020, 9, 30),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "84 min",
				Description = "Using raw, firsthand footage, this documentary examines the disappearance of Shanann Watts and her children, and the terrible events that followed.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Documentary"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1154,
				ShowType = ShowType.Movie,
				Title = "The Boys in the Band",
				Director = "Joe Mantello",
				Cast = "Jim Parsons, Zachary Quinto, Matt Bomer, Andrew Rannells, Charlie Carver, Robin de Jes??s, Brian Hutchison, Michael Benjamin Washington, Tuc Watkins",
				DateAdded = new DateTime(2020, 9, 30),
				ReleaseYear = 2020,
				Rating = Rating.R,
				Duration = "122 min",
				Description = "At a birthday party in 1968 New York, a surprise guest and a drunken game leave seven gay friends reckoning with unspoken feelings and buried truths.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1155,
				ShowType = ShowType.Movie,
				Title = "Big Daddy",
				Director = "Dennis Dugan",
				Cast = "Adam Sandler, Joey Lauren Adams, Jon Stewart, Cole Sprouse, Dylan Sprouse, Josh Mostel, Leslie Mann, Allen Covert, Rob Schneider, Kristy Swanson",
				DateAdded = new DateTime(2020, 10, 1),
				ReleaseYear = 1999,
				Rating = Rating.PG13,
				Duration = "93 min",
				Description = "Dumped by his girlfriend because he refuses to accept responsibility, overgrown adolescent Sonny Koufax adopts a 5-year-old to prove he's a grownup.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1156,
				ShowType = ShowType.TV,
				Title = "The Unicorn",
				Director = "",
				Cast = "Walton Goggins, Rob Corddry, Michaela Watkins, Omar Benson Miller, Maya Lynne Robinson, Ruby Jay, Makenzie Moss",
				DateAdded = new DateTime(2020, 10, 1),
				ReleaseYear = 2019,
				Rating = Rating.TV14,
				Duration = "1 Season",
				Description = "A widowed father of two girls navigates the world of dating, surprised to learn that many women consider him a hot commodity.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1157,
				ShowType = ShowType.Movie,
				Title = "Free State of Jones",
				Director = "Gary Ross",
				Cast = "Matthew McConaughey, Gugu Mbatha-Raw, Mahershala Ali, Keri Russell, Christopher Berry, Sean Bridgers, Jacob Lofland, Thomas Francis Murphy, Bill Tangradi",
				DateAdded = new DateTime(2020, 10, 1),
				ReleaseYear = 2016,
				Rating = Rating.R,
				Duration = "139 min",
				Description = "A Mississippi farmer turns outlaw as he leads a ragtag band of fellow Civil War deserters and escaped slaves in a rebellion against the Confederacy.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1158,
				ShowType = ShowType.Movie,
				Title = "We Have Always Lived in the Castle",
				Director = "Stacie Passon",
				Cast = "Taissa Farmiga, Alexandra Daddario, Crispin Glover, Sebastian Stan, Paula Malcomson, Peter Coonan, Ian Toner, Joanne Crawford",
				DateAdded = new DateTime(2020, 10, 1),
				ReleaseYear = 2018,
				Rating = Rating.TV14,
				Duration = "95 min",
				Description = "The fragile and secretive world of two sisters and their uncle crumbles when their charming cousin arrives with eyes toward the family fortune.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1159,
				ShowType = ShowType.TV,
				Title = "Evil",
				Director = "",
				Cast = "Katja Herbers, Mike Colter, Aasif Mandvi, Michael Emerson, Christine Lahti, Kurt Fuller, Marti Matulis",
				DateAdded = new DateTime(2020, 10, 1),
				ReleaseYear = 2019,
				Rating = Rating.TV14,
				Duration = "1 Season",
				Description = "A forensic psychologist partners with a Catholic priest-in-training to investigate miracles and demonic possession in this supernatural drama.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1160,
				ShowType = ShowType.TV,
				Title = "Emily in Paris",
				Director = "",
				Cast = "Lily Collins, Philippine Leroy-Beaulieu, Ashley Park, Lucas Bravo, Kate Walsh, Samuel Arnold, Bruno Gouery, Camille Razat",
				DateAdded = new DateTime(2020, 10, 2),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "1 Season",
				Description = "After landing her dream job in Paris, Chicago marketing exec Emily Cooper embraces her adventurous new life while juggling work, friends and romance.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Romance"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1161,
				ShowType = ShowType.Movie,
				Title = "Saturday Church",
				Director = "Damon Cardasis",
				Cast = "Luka Kain, Regina Taylor, Margot Bingham, Marquis Rodriguez, Mj Rodriguez, Indya Moore, Alexia Garcia, Kate Bornstein, Peter Kim, Jaylin Fletcher",
				DateAdded = new DateTime(2020, 10, 6),
				ReleaseYear = 2017,
				Rating = Rating.TVMA,
				Duration = "83 min",
				Description = "A teen struggling with gender identity and family tensions seeks hope and support in New York City's underground LGBTQ ballroom community.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1162,
				ShowType = ShowType.Movie,
				Title = "Walk Away from Love",
				Director = "Christopher Nolen",
				Cast = "Noree Victoria, Brad James, Robert Christopher Riley, Brely Evans, Sabrina Revelle",
				DateAdded = new DateTime(2020, 10, 6),
				ReleaseYear = 2017,
				Rating = Rating.TV14,
				Duration = "81 min",
				Description = "Heartbroken from her last relationship, an attorney is wary of falling in love again. But crossing paths with an ex upends her plans to finally move on.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1163,
				ShowType = ShowType.Movie,
				Title = "Hubie Halloween",
				Director = "Steve Brill",
				Cast = "Adam Sandler, Kevin James, Julie Bowen, Ray Liotta, Steve Buscemi, Maya Rudolph, Rob Schneider, June Squibb, Kenan Thompson, Tim Meadows, Michael Chiklis, Karan Brar, George Wallace, Paris Berelc, Noah Schnapp, China Anne McClain, Colin Quinn, Kym Whitley, Lavell Crawford, Mikey Day, Jackie Sandler, Sadie Sandler, Sunny Sandler",
				DateAdded = new DateTime(2020, 10, 7),
				ReleaseYear = 2020,
				Rating = Rating.PG13,
				Duration = "104 min",
				Description = "Hubie's not the most popular guy in Salem, Mass., but when Halloween turns truly spooky, this good-hearted scaredy-cat sets out to keep his town safe.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Horror"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1164,
				ShowType = ShowType.TV,
				Title = "Deaf U",
				Director = "",
				Cast = "",
				DateAdded = new DateTime(2020, 10, 9),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "1 Season",
				Description = "In this reality series, a tight-knit group of Deaf and hard of hearing students share their stories and explore life at Gallaudet University.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Docuseries"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1165,
				ShowType = ShowType.TV,
				Title = "The Haunting of Bly Manor",
				Director = "",
				Cast = "Victoria Pedretti, Oliver Jackson-Cohen, Henry Thomas, Amelia Eve, T'Nia Miller, Rahul Kohli, Tahirah Sharif, Amelie Bea Smith, Benjamin Evan Ainsworth",
				DateAdded = new DateTime(2020, 10, 9),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "1 Season",
				Description = "Dead doesn't mean gone. An au pair plunges into an abyss of chilling secrets in this gothic romance from the creator of 'The Haunting of Hill House.'",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Horror"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1166,
				ShowType = ShowType.Movie,
				Title = "House of the Witch",
				Director = "Alex Merkin",
				Cast = "Emily Bader, Darren Mann, Michelle Randolph, Coy Stewart, Jesse Pepe, Arden Belle, Joel Nagle, Nolan Bateman",
				DateAdded = new DateTime(2020, 10, 11),
				ReleaseYear = 2017,
				Rating = Rating.TVMA,
				Duration = "86 min",
				Description = "A group of daring teens finds themselves in a fight for their lives inside a haunted house when a sinister spirit crashes their Halloween party.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Horror"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1167,
				ShowType = ShowType.Movie,
				Title = "BLACKPINK: Light Up the Sky",
				Director = "Caroline Suh",
				Cast = "Blackpink",
				DateAdded = new DateTime(2020, 10, 14),
				ReleaseYear = 2020,
				Rating = Rating.TV14,
				Duration = "80 min",
				Description = "Record-shattering Korean girl band BLACKPINK tell their story ??? and detail the hard-fought journey of the dreams and trials behind their meteoric rise.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Documentary"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1168,
				ShowType = ShowType.Movie,
				Title = "Batman: The Killing Joke",
				Director = "Sam Liu",
				Cast = "Kevin Conroy, Mark Hamill, Tara Strong, Ray Wise, John DiMaggio, Robin Atkin Downes, Brian George, JP Karliak, Andrew Kishino, Nolan North",
				DateAdded = new DateTime(2020, 10, 15),
				ReleaseYear = 2016,
				Rating = Rating.R,
				Duration = "77 min",
				Description = "The Joker makes life hell for the Gordon family in a monstrous attempt to prove to Batman that one bad day can drive a good man to madness.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Action & Adventure"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1169,
				ShowType = ShowType.TV,
				Title = "Half & Half",
				Director = "",
				Cast = "Rachel True, Essence Atkins, Telma Hopkins, Chico Benymon, Valarie Pettiford, Alec Mapa",
				DateAdded = new DateTime(2020, 10, 15),
				ReleaseYear = 2005,
				Rating = Rating.TV14,
				Duration = "4 Seasons",
				Description = "After two estranged half-sisters in their twenties find their lives suddenly entwined, they grow closer as they get to know more about each other.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1170,
				ShowType = ShowType.TV,
				Title = "Social Distance",
				Director = "",
				Cast = "Danielle Brooks, Oscar Nunez, Mike Colter, Heather Burns, Okieriete Onaodowan, Ajay Naidu, Shakira Barrera, Steven Weber, Helena Howard, Daphne Rubin-Vega, Guillermo Diaz, Miguel Sandoval, Camila Perez, Gianna Aragon, Tom Costanzo, Luca Costanzo, Olli Haaskivi, Marsha Stephanie Blake, Isabella Ferreira, Rocco Luna",
				DateAdded = new DateTime(2020, 10, 15),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "1 Season",
				Description = "Filmed in isolation, this narrative anthology series features both dark and funny takes on how people strive to stay connected while staying apart.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1171,
				ShowType = ShowType.TV,
				Title = "One on One",
				Director = "",
				Cast = "Flex Alexander, Kyla Pratt, Kelly Perine, Sicily Johnson, Robert Ri'chard",
				DateAdded = new DateTime(2020, 10, 15),
				ReleaseYear = 2006,
				Rating = Rating.TV14,
				Duration = "5 Seasons",
				Description = "When his ex-wife lands a job abroad, athlete-turned-sportscaster Flex Washington assumes full-time custody of their teenage daughter, Breanna.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1172,
				ShowType = ShowType.Movie,
				Title = "A Babysitter's Guide to Monster Hunting",
				Director = "Rachel Talalay",
				Cast = "Tamara Smart, Oona Laurence, Tom Felton, Troy Leigh-Anne Johnson, Lynn Masako Cheng, Ty Consiglio, Ian Ho, Indya Moore, Alessio Scalzotto, Tamsen McDonough",
				DateAdded = new DateTime(2020, 10, 15),
				ReleaseYear = 2020,
				Rating = Rating.TVPG,
				Duration = "99 min",
				Description = "Recruited by a secret society of babysitters, a high schooler battles the Boogeyman and his monsters when they nab the boy she's watching on Halloween.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Family"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1173,
				ShowType = ShowType.Movie,
				Title = "ParaNorman",
				Director = "Sam Fell, Chris Butler",
				Cast = "Kodi Smit-McPhee, Tucker Albrizzi, Anna Kendrick, Casey Affleck, Christopher Mintz-Plasse, Leslie Mann, Jeff Garlin, Elaine Stritch, Bernard Hill, Jodelle Ferland, Tempestt Bledsoe, Alex Borstein, John Goodman",
				DateAdded = new DateTime(2020, 10, 18),
				ReleaseYear = 2012,
				Rating = Rating.PG,
				Duration = "93 min",
				Description = "When an army of zombies invades a small town, it's up to an odd local boy with a knack for communicating with the dead to save the day.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Family"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1174,
				ShowType = ShowType.Movie,
				Title = "Tremors: Shrieker Island",
				Director = "Don Michael Paul",
				Cast = "Michael Gross, Jon Heder, Caroline Langrishe, Cassie Clare, Matthew Douglas, Sahajak Boonthanakit, David Asavanond, Jackie Cruz, Richard Brake",
				DateAdded = new DateTime(2020, 10, 20),
				ReleaseYear = 2020,
				Rating = Rating.PG13,
				Duration = "102 min",
				Description = "When massive mutant creatures infiltrate an island nature preserve, scientists recruit a legendary monster hunter to battle the beasts.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Action & Adventure"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1175,
				ShowType = ShowType.Movie,
				Title = "Bending the Arc",
				Director = "Kief Davidson, Pedro Kos",
				Cast = "",
				DateAdded = new DateTime(2020, 10, 22),
				ReleaseYear = 2017,
				Rating = Rating.TVMA,
				Duration = "102 min",
				Description = "This documentary follows a group of ambitious advocates whose mission to save lives in Haiti turns into a global fight for health care and justice.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Documentary"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1176,
				ShowType = ShowType.TV,
				Title = "Move",
				Director = "Thierry Demaiziere, Alban Teurlai",
				Cast = "",
				DateAdded = new DateTime(2020, 10, 23),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "1 Season",
				Description = "Discover the brilliant dancers and choreographers who are shaping the art of movement around the world in this documentary series.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Docuseries"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1177,
				ShowType = ShowType.TV,
				Title = "The Queen's Gambit",
				Director = "",
				Cast = "Anya Taylor-Joy, Bill Camp, Marielle Heller, Thomas Brodie-Sangster, Moses Ingram, Harry Melling, Isla Johnston, Christiane Seidel, Rebecca Root, Chloe Pirrie, Jacob Fortune-Lloyd",
				DateAdded = new DateTime(2020, 10, 23),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "1 Season",
				Description = "In a 1950s orphanage, a young girl reveals an astonishing talent for chess and begins an unlikely journey to stardom while grappling with addiction.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1178,
				ShowType = ShowType.TV,
				Title = "Blood of Zeus",
				Director = "",
				Cast = "Derek Phillips, Jason O'Mara, Claudia Christian, Mamie Gummer, Jessica Henwick, Elias Toufexis, Chris Diamantopoulos, Adetokumboh M'Cormack, Matthew Mercer, Melina Kanakaredes, Danny Jacobs, Matt Lowe, Adam Croasdell, Jennifer Hale, David Shaughnessy, Fred Tatasciore, Vanessa Marshall",
				DateAdded = new DateTime(2020, 10, 27),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "1 Season",
				Description = "A commoner living in ancient Greece, Heron discovers his true heritage as a son of Zeus, and his purpose: to save the world from a demonic army.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Family"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1179,
				ShowType = ShowType.Movie,
				Title = "Metallica Through The Never",
				Director = "Nimrod Antal",
				Cast = "Dane DeHaan, James Hetfield, Lars Ulrich, Kirk Hammett, Robert Trujillo",
				DateAdded = new DateTime(2020, 10, 28),
				ReleaseYear = 2013,
				Rating = Rating.R,
				Duration = "93 min",
				Description = "As heavy metal band Metallica tears up the stage, a young roadie is sent on an urgent errand. But his mission soon takes a surreal turn.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1180,
				ShowType = ShowType.Movie,
				Title = "Holidate",
				Director = "John Whitesell",
				Cast = "Emma Roberts, Luke Bracey, Kristin Chenoweth, Frances Fisher, Jessica Capshaw, Andrew Bachelor, Cynthy Wu, Alex Moffat, Manish Dayal",
				DateAdded = new DateTime(2020, 10, 28),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "105 min",
				Description = "Fed up with being single on holidays, two strangers agree to be each other's platonic plus-ones all year long, only to catch real feelings along the way.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Romance"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1181,
				ShowType = ShowType.TV,
				Title = "Marvel's Agents of S.H.I.E.L.D.",
				Director = "",
				Cast = "Clark Gregg, Ming-Na Wen, Brett Dalton, Chloe Bennet, Iain De Caestecker, Elizabeth Henstridge, Adrianne Palicki, Luke Mitchell, Henry Simmons",
				DateAdded = new DateTime(2020, 10, 30),
				ReleaseYear = 2020,
				Rating = Rating.TV14,
				Duration = "7 Seasons",
				Description = "Agent Phil Coulson, seen in action in Marvel's The Avengers, assembles a team of top S.H.I.E.L.D. agents to investigate bizarre threats.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Action & Adventure"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1182,
				ShowType = ShowType.TV,
				Title = "Somebody Feed Phil",
				Director = "",
				Cast = "Philip Rosenthal",
				DateAdded = new DateTime(2020, 10, 30),
				ReleaseYear = 2020,
				Rating = Rating.TV14,
				Duration = "4 Seasons",
				Description = "'Everybody Loves Raymond' creator Phil Rosenthal travels the globe to take in the local cuisine and culture of Bangkok, Lisbon, Mexico City and more.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Docuseries"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1183,
				ShowType = ShowType.Movie,
				Title = "Hidden in Plain Sight",
				Director = "Stacia Crawford",
				Cast = "Victoria Barabas, Gino Anthony Pesi, Jake Allyn, Deborah Van Valkenburgh, Jessica Meraz, Jack Fisher, Eve Sigall, Jerod Meagher",
				DateAdded = new DateTime(2020, 10, 30),
				ReleaseYear = 2019,
				Rating = Rating.TV14,
				Duration = "87 min",
				Description = "A woman stages her own suicide but still lives in fear of her abusive ex-boyfriend tracking her down and stealing the son he never knew he had.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1184,
				ShowType = ShowType.Movie,
				Title = "Easy A",
				Director = "Will Gluck",
				Cast = "Emma Stone, Penn Badgley, Amanda Bynes, Dan Byrd, Thomas Haden Church, Patricia Clarkson, Cam Gigandet, Lisa Kudrow, Malcolm McDowell, Aly Michalka",
				DateAdded = new DateTime(2020, 11, 1),
				ReleaseYear = 2010,
				Rating = Rating.PG13,
				Duration = "92 min",
				Description = "When a lie about Olive's reputation transforms her from anonymous to infamous at her high school, she decides to embrace a provocative new persona.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1185,
				ShowType = ShowType.Movie,
				Title = "Jumping the Broom",
				Director = "Salim Akil",
				Cast = "Angela Bassett, Paula Patton, Laz Alonso, Loretta Devine, Meagan Good, Tasha Smith, Julie Bowen, DeRay Davis, Valarie Pettiford, Pooch Hall, Tenika Davis, T.D. Jakes, Mike Epps, Romeo Miller, Marguerite McNeil, El DeBarge, Brian Stokes Mitchell, Gary Dourdan",
				DateAdded = new DateTime(2020, 11, 1),
				ReleaseYear = 2011,
				Rating = Rating.PG13,
				Duration = "113 min",
				Description = "After a whirlwind romance, a couple rushes to say 'I do' at the bride's family estate on Martha's Vineyard, where their relations meet - and clash.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1186,
				ShowType = ShowType.Movie,
				Title = "Wheels of Fortune",
				Director = "Shaun Paul Piccinino",
				Cast = "Matt Jones, Noureen DeWulf, John Ducey, Matty Cardarople, Jeff Fahey, Christina Moore, Gabriel Tigerman, Ali Afshar, Tyler Jacob Moore, Jessica Serfaty",
				DateAdded = new DateTime(2020, 11, 1),
				ReleaseYear = 2020,
				Rating = Rating.R,
				Duration = "107 min",
				Description = "To claim a big inheritance, a down-on-his-luck mechanic must win a series of competitions as outlined in his birth father's will.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1187,
				ShowType = ShowType.Movie,
				Title = "Paul Blart: Mall Cop",
				Director = "Steve Carr",
				Cast = "Kevin James, Keir O'Donnell, Jayma Mays, Raini Rodriguez, Shirley Knight, Stephen Rannazzisi, Peter Gerety, Bobby Cannavale, Adam Ferrara, Jamal Mixon, Adhir Kalyan, Gary Valentine",
				DateAdded = new DateTime(2020, 11, 1),
				ReleaseYear = 2009,
				Rating = Rating.PG,
				Duration = "91 min",
				Description = "An overzealous security guard finds himself in over his head when he tries to thwart a criminal mastermind's plot to rob an entire shopping mall.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1188,
				ShowType = ShowType.Movie,
				Title = "Little Monsters",
				Director = "Richard Greenberg",
				Cast = "Fred Savage, Howie Mandel, Daniel Stern, Margaret Whitton, Rick Ducommun, Frank Whaley, Ben Savage, William Murray Weiss, Devin Ratray, Amber Barretto",
				DateAdded = new DateTime(2020, 11, 1),
				ReleaseYear = 1989,
				Rating = Rating.PG,
				Duration = "102 min",
				Description = "Brian knows there are creatures under his bed. When he faces his fears and confronts them, however, he makes some hilariously weird new friends.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Family"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1189,
				ShowType = ShowType.Movie,
				Title = "Christmas Break-In",
				Director = "Michael Kampa",
				Cast = "Danny Glover, Denise Richards, Cameron Seely, Sean O'Bryan, Katrina Begin, Jake Van Wagoner, Douglas Spain, Dawson Ehlke",
				DateAdded = new DateTime(2020, 11, 1),
				ReleaseYear = 2019,
				Rating = Rating.TVPG,
				Duration = "87 min",
				Description = "Stranded at school before holiday break, a precocious girl gets into the spirit of saving when a trio of robbers trespass and hold the janitor hostage.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Family"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1190,
				ShowType = ShowType.TV,
				Title = "60 Days In",
				Director = "",
				Cast = "",
				DateAdded = new DateTime(2020, 11, 1),
				ReleaseYear = 2019,
				Rating = Rating.TVMA,
				Duration = "1 Season",
				Description = "Recruited by a sheriff, volunteers infiltrate county prisons to expose corruption and crime from within the system in this docuseries.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Reality TV"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1191,
				ShowType = ShowType.Movie,
				Title = "A New York Christmas Wedding",
				Director = "Otoja Abit",
				Cast = "Nia Fairweather, Chris Noth, Cooper Koch, Tyra Ferrell, Denny Dillon, Adriana DeMeo, Otoja Abit, David Anzuelo, Camilla Harden, Natasha Goodman, Avery Whitted, Tony D. Head, Joe Perrino",
				DateAdded = new DateTime(2020, 11, 5),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "90 min",
				Description = "As her wedding nears, a bride-to-be is visited by an angel who reveals what could have been if she'd followed feelings for her childhood best friend.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1192,
				ShowType = ShowType.Movie,
				Title = "Operation Christmas Drop",
				Director = "Martin Wood",
				Cast = "Kat Graham, Alexander Ludwig, Virginia Madsen, Janet Kidder, Jeff Joseph, Bethany Brown, Trezzo Mahoro, Rohan Campbell, Aliza Vellani, Aaron Douglas, Xavier de Guzman, Bruce Best",
				DateAdded = new DateTime(2020, 11, 5),
				ReleaseYear = 2020,
				Rating = Rating.TVG,
				Duration = "96 min",
				Description = "A by-the-book political aide falls for a big-hearted Air Force pilot while looking to shut down his tropical base and its airborne Christmas tradition.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Family"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1193,
				ShowType = ShowType.TV,
				Title = "DASH & LILY",
				Director = "",
				Cast = "Midori Francis, Austin Abrams, Dante Brown, Troy Iwata",
				DateAdded = new DateTime(2020, 11, 10),
				ReleaseYear = 2020,
				Rating = Rating.TV14,
				Duration = "1 Season",
				Description = "Opposites attract at Christmas as cynical Dash and sunny Lily trade messages and dares in a red notebook they pass back and forth around New York City.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Romance"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1194,
				ShowType = ShowType.Movie,
				Title = "Jingle Jangle: A Christmas Journey",
				Director = "David E. Talbert",
				Cast = "Forest Whitaker, Keegan-Michael Key, Hugh Bonneville, Anika Noni Rose, Madalen Mills, Phylicia Rashad, Ricky Martin, Justin Cornwell, Sharon Rose, Lisa Davina Phillip, Kieron Dyer",
				DateAdded = new DateTime(2020, 11, 13),
				ReleaseYear = 2020,
				Rating = Rating.PG,
				Duration = "124 min",
				Description = "Decades after his trusted apprentice betrayed him, a once-joyful toymaker finds new hope when his kind and curious granddaughter comes into his life.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Family"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1195,
				ShowType = ShowType.TV,
				Title = "American Horror Story",
				Director = "",
				Cast = "Evan Peters, Sarah Paulson, Jessica Lange, Denis O'Hare, Kathy Bates, Angela Bassett, Lily Rabe, Frances Conroy, Cheyenne Jackson, Emma Roberts, Taissa Farmiga, Wes Bentley, Finn Wittrock, Chloe Sevigny, Zachary Quinto, Jamie Brewer, Naomi Grossman, Dylan McDermott, Gabourey Sidibe, Lady Gaga, Mare Winningham",
				DateAdded = new DateTime(2020, 11, 13),
				ReleaseYear = 2019,
				Rating = Rating.TVMA,
				Duration = "9 Seasons",
				Description = "This twisted Emmy-winning drama plays upon the power of supernatural fears and everyday horrors, exploring humankind's unsettling capacity for evil.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Horror"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1196,
				ShowType = ShowType.Movie,
				Title = "Killer Cove",
				Director = "Damian Romay",
				Cast = "Haley Webb, Donny Boaz, Cathy Baron, Jason Alan Smith, Dennis Staroselsky, Owen Miller, Shawn Fitzgibbon",
				DateAdded = new DateTime(2020, 11, 14),
				ReleaseYear = 2019,
				Rating = Rating.TV14,
				Duration = "87 min",
				Description = "An unlucky woman finds a solution for her hateful ex, a trying job hunt and a stalker through a charming P.I. - only to endure a new set of problems.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Thriller"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1197,
				ShowType = ShowType.Movie,
				Title = "White Christmas",
				Director = "Michael Curtiz",
				Cast = "Bing Crosby, Danny Kaye, Rosemary Clooney, Vera-Ellen, Dean Jagger, Mary Wickes, John Brascia, Anne Whitfield, George Chakiris",
				DateAdded = new DateTime(2020, 11, 15),
				ReleaseYear = 1954,
				Rating = Rating.TVG,
				Duration = "120 min",
				Description = "Two war buddies fall for two sisters and follow the girls to a resort owned by their former commanding officer, who is in danger of losing the place.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Classics"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1198,
				ShowType = ShowType.Movie,
				Title = "Cloudy with a Chance of Meatballs 2",
				Director = "Cody Cameron, Kris Pearn",
				Cast = "Bill Hader, Anna Faris, James Caan, Will Forte, Andy Samberg, Benjamin Bratt, Neil Patrick Harris, Terry Crews, Kristen Schaal",
				DateAdded = new DateTime(2020, 11, 15),
				ReleaseYear = 2013,
				Rating = Rating.PG,
				Duration = "95 min",
				Description = "Inventor Flint Lockwood battles mutant food beasts created by his notorious machine, including shrimpanzees, tacodiles and jellyfish sandwiches.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Family"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1199,
				ShowType = ShowType.TV,
				Title = "America's Next Top Model",
				Director = "",
				Cast = "Tyra Banks",
				DateAdded = new DateTime(2020, 11, 15),
				ReleaseYear = 2013,
				Rating = Rating.TV14,
				Duration = "2 Seasons",
				Description = "Supermodel Tyra Banks created and executive-produced this reality series that chronicles the transformation of young women into potential supermodels.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Reality TV"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1200,
				ShowType = ShowType.TV,
				Title = "Survivor",
				Director = "",
				Cast = "Jeff Probst, Jerri Manthey, Colby Donaldson, Rupert Boneham, Parvati Shallow, Rob Mariano, Amanda Kimmel, James Clement, Amber Brkich, Alicia Calaway, Ethan Zohn, Tina Wesson",
				DateAdded = new DateTime(2020, 11, 15),
				ReleaseYear = 2014,
				Rating = Rating.TV14,
				Duration = "2 Seasons",
				Description = "In this long-running reality competition series, players battle the elements and each other as they vie for $1 million and the title of Sole Survivor.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Reality TV"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1201,
				ShowType = ShowType.TV,
				Title = "We Are the Champions",
				Director = "",
				Cast = "",
				DateAdded = new DateTime(2020, 11, 17),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "1 Season",
				Description = "Explore an array of unique competitions, from the quirky to the bizarre, and meet their passionate communities in this docuseries.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Docuseries"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1202,
				ShowType = ShowType.TV,
				Title = "Holiday Home Makeover with Mr. Christmas",
				Director = "",
				Cast = "Benjamin Bradley",
				DateAdded = new DateTime(2020, 11, 18),
				ReleaseYear = 2020,
				Rating = Rating.TVG,
				Duration = "1 Season",
				Description = "Interior designer Benjamin 'Mr. Christmas' Bradley works with a trusty team of 'elves' to help families transform their homes for the holidays.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Reality TV"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1203,
				ShowType = ShowType.Movie,
				Title = "The Princess Switch: Switched Again",
				Director = "Mike Rohl",
				Cast = "Vanessa Hudgens, Nick Sagar, Sam Palladio, Mia Lloyd, Lachlan Nieboer, Ricky Norwood, Florence Hall, Suanne Braun, Mark Fleischmann",
				DateAdded = new DateTime(2020, 11, 19),
				ReleaseYear = 2020,
				Rating = Rating.TVG,
				Duration = "97 min",
				Description = "When Margaret's Christmas coronation complicates her love life, her double Stacy steps in to save the day. But will a third look-alike ruin their plan?",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Romance"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1204,
				ShowType = ShowType.TV,
				Title = "Voices of Fire",
				Director = "",
				Cast = "Pharrell Williams",
				DateAdded = new DateTime(2020, 11, 20),
				ReleaseYear = 2020,
				Rating = Rating.TVPG,
				Duration = "1 Season",
				Description = "In this faith-based docuseries, Bishop Ezekiel Williams builds an inspiring, nontraditional gospel choir with the help of superstar nephew Pharrell.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Docuseries"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1205,
				ShowType = ShowType.Movie,
				Title = "The App That Stole Christmas",
				Director = "Monica Floyd",
				Cast = "Jackie Long, Diane Marie Howard, Jaylin Hall, Miguel A. Nunez Jr., Ray J, JayQ The Legend, J. Anthony Brown, Kenny Rhodes, Amber Cosich",
				DateAdded = new DateTime(2020, 11, 20),
				ReleaseYear = 2020,
				Rating = Rating.TVPG,
				Duration = "64 min",
				Description = "A tech entrepreneur's Christmas shopping app is a smashing success, but he starts to realize his invention might be ruining the holiday spirit.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Family"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1206,
				ShowType = ShowType.Movie,
				Title = "Alien Xmas",
				Director = "Stephen Chiodo",
				Cast = "Keythe Farley, Dee Bradley Baker, Kaliayh Rhambo, Michelle Deco, Barbara Goodson",
				DateAdded = new DateTime(2020, 11, 20),
				ReleaseYear = 2020,
				Rating = Rating.TVY,
				Duration = "42 min",
				Description = "A young elf mistakes a tiny alien for a Christmas gift, not knowing her new plaything has plans to destroy Earth's gravity - and steal all the presents.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Family"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1207,
				ShowType = ShowType.Movie,
				Title = "Dolly Parton's Christmas on the Square",
				Director = "Debbie Allen",
				Cast = "Dolly Parton, Christine Baranski, Treat Williams, Jenifer Lewis, Josh Segarra, Jeanine Mason, Mary Lane Haskell",
				DateAdded = new DateTime(2020, 11, 22),
				ReleaseYear = 2020,
				Rating = Rating.TVPG,
				Duration = "99 min",
				Description = "Seasonal cheer comes to a screeching halt when a cold-hearted woman tries to sell her hometown's land. Can music, magic and memories change her mind?",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Romance"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1208,
				ShowType = ShowType.Movie,
				Title = "Hard Kill",
				Director = "Matt Eskandari",
				Cast = "Jesse Metcalfe, Bruce Willis, Natalie Eva Marie, Lala Kent, Texas Battle, Swen Temmel, Sergio Rizzuto, Tyler Jon Olson, Jon Galanis",
				DateAdded = new DateTime(2020, 11, 23),
				ReleaseYear = 2020,
				Rating = Rating.R,
				Duration = "98 min",
				Description = "When a billionaire hires a team of mercenaries for protection, they soon realize world-changing technology and his daughter's life are also at stake.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Action & Adventure"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1209,
				ShowType = ShowType.Movie,
				Title = "The 2nd",
				Director = "Brian Skiba",
				Cast = "Ryan Phillippe, Casper Van Dien, Jack Griffo, Lexi Simonsen, Richard Burgi, William Katt, Samaire Armstrong, William McNamara, Jacob Grodnik",
				DateAdded = new DateTime(2020, 11, 30),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "93 min",
				Description = "A Secret Service agent is drawn into a terrorist plot when his son's classmate, the daughter of a Supreme Court Justice, is targeted for kidnapping.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Action & Adventure"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1210,
				ShowType = ShowType.Movie,
				Title = "Spookley and the Christmas Kittens",
				Director = "Bernie Denk",
				Cast = "Vlasta Vrana, Sonja Ball, Craig Francis, Richard C. Jones, Michael Perron, Terrence Scammell, Bruce Dinsmore, Jennifer Seguin, Daniel Brochu",
				DateAdded = new DateTime(2020, 11, 30),
				ReleaseYear = 2019,
				Rating = Rating.TVY,
				Duration = "45 min",
				Description = "When a green cat and three stray kittens wind up at Holiday Hill Farm, Spookley the Square Pumpkin and his friends help the felines find their way home.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Family"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1211,
				ShowType = ShowType.Movie,
				Title = "Chef",
				Director = "Jon Favreau",
				Cast = "Jon Favreau, Sofia Vergara, John Leguizamo, Scarlett Johansson, Dustin Hoffman, Oliver Platt, Bobby Cannavale, Amy Sedaris, Robert Downey Jr., Emjay Anthony, Russell Peters",
				DateAdded = new DateTime(2020, 12, 1),
				ReleaseYear = 2014,
				Rating = Rating.R,
				Duration = "115 min",
				Description = "After igniting a Twitter war with a well-known culinary critic, a Los Angeles chef packs his knives, heads home to Miami and opens a food truck.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1212,
				ShowType = ShowType.Movie,
				Title = "A Thin Line Between Love & Hate",
				Director = "Martin Lawrence",
				Cast = "Martin Lawrence, Lynn Whitfield, Regina King, Bobby Brown, Della Reese, Daryl Mitchell, Roger Mosley, Malinda Williams, Roger E. Mosley, Simbi Khali, Tangie Ambrose, Wendy Raquel Robinson, Stacii Jae Johnson, Faizon Love, Miguel A. Nunez Jr., Tracy Morgan",
				DateAdded = new DateTime(2020, 12, 1),
				ReleaseYear = 1996,
				Rating = Rating.R,
				Duration = "108 min",
				Description = "When a philandering club promoter sets out to woo a rich, glamorous woman, he has no clue just how much mayhem he's about to unleash on his life.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1213,
				ShowType = ShowType.Movie,
				Title = "50 First Dates",
				Director = "Peter Segal",
				Cast = "Adam Sandler, Drew Barrymore, Rob Schneider, Sean Astin, Lusia Strus, Dan Aykroyd, Amy Hill, Allen Covert, Blake Clark, Maya Rudolph",
				DateAdded = new DateTime(2020, 12, 1),
				ReleaseYear = 2004,
				Rating = Rating.PG13,
				Duration = "99 min",
				Description = "After falling for a pretty art teacher who has no short-term memory, a marine veterinarian has to win her over again every single day.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1214,
				ShowType = ShowType.TV,
				Title = "The Holiday Movies That Made Us",
				Director = "",
				Cast = "",
				DateAdded = new DateTime(2020, 12, 1),
				ReleaseYear = 2020,
				Rating = Rating.TVPG,
				Duration = "1 Season",
				Description = "Unwrap the real stories behind these iconic Christmas blockbusters, thanks to insider interviews and behind-the-scenes peeks.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Docuseries"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1215,
				ShowType = ShowType.Movie,
				Title = "Monster House",
				Director = "Gil Kenan",
				Cast = "Mitchel Musso, Sam Lerner, Spencer Locke, Steve Buscemi, Kathleen Turner, Jason Lee, Jon Heder, Maggie Gyllenhaal, Catherine O'Hara, Fred Willard, Nick Cannon, Kevin James",
				DateAdded = new DateTime(2020, 12, 1),
				ReleaseYear = 2006,
				Rating = Rating.PG,
				Duration = "91 min",
				Description = "A trio of friends sets out to expose the terrors of a vacant neighborhood house, which appears to have a craving for people - and a life of its own.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Family"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1216,
				ShowType = ShowType.TV,
				Title = "Ink Master",
				Director = "",
				Cast = "Dave Navarro, Chris Nunez, Oliver Peck",
				DateAdded = new DateTime(2020, 12, 1),
				ReleaseYear = 2012,
				Rating = Rating.TV14,
				Duration = "2 Seasons",
				Description = "Ten of the country's most skilled tattoo artists compete for $100,000 and the title of Ink Master in this high-stakes elimination competition.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Reality TV"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1217,
				ShowType = ShowType.TV,
				Title = "Are You The One",
				Director = "",
				Cast = "Ryan Devlin",
				DateAdded = new DateTime(2020, 12, 1),
				ReleaseYear = 2014,
				Rating = Rating.TV14,
				Duration = "2 Seasons",
				Description = "Determined by a dating algorithm, a group of single contestants must identify their perfect matches for a shot at love and a cash prize.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Reality TV"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1218,
				ShowType = ShowType.Movie,
				Title = "Runaway Bride",
				Director = "Garry Marshall",
				Cast = "Julia Roberts, Richard Gere, Joan Cusack, Hector Elizondo, Rita Wilson, Paul Dooley, Christopher Meloni, Donal Logue, Reg Rogers, Yul Vazquez, Jane Morris, Lisa Roberts, Kathleen Marshall, Jean Schertler, Tom Hines",
				DateAdded = new DateTime(2020, 12, 1),
				ReleaseYear = 1999,
				Rating = Rating.PG,
				Duration = "116 min",
				Description = "Sparks fly when a newspaper columnist writes a one-sided, sexist story about a commitment-phobic bride who abandoned three men at the altar.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Romance"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1219,
				ShowType = ShowType.Movie,
				Title = "The Adventures of Sharkboy and Lavagirl",
				Director = "Robert Rodriguez",
				Cast = "Taylor Lautner, Taylor Dooley, Cayden Boyd, George Lopez, David Arquette, Kristin Davis, Jacob Davich, Sasha Pieterse, Rico Torres",
				DateAdded = new DateTime(2020, 12, 2),
				ReleaseYear = 2005,
				Rating = Rating.PG,
				Duration = "93 min",
				Description = "A 10-year-old dreamer's imaginary friends - mighty Sharkboy and fire-producing Lavagirl - come to life to seek his help battling a nefarious baddie.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Family"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1220,
				ShowType = ShowType.TV,
				Title = "Mr. Iglesias",
				Director = "",
				Cast = "Gabriel Iglesias, Sherri Shepherd, Jacob Vargas, Maggie Geha, Richard Gant, Cree Cicchino, Fabrizio Guido, Oscar Nu??ez",
				DateAdded = new DateTime(2020, 12, 8),
				ReleaseYear = 2020,
				Rating = Rating.TV14,
				Duration = "3 Seasons",
				Description = "Hilarious high school teacher Gabriel Iglesias tries to make a difference in the lives of some smart but underperforming students at his alma mater.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1221,
				ShowType = ShowType.Movie,
				Title = "Triple 9",
				Director = "John Hillcoat",
				Cast = "Casey Affleck, Chiwetel Ejiofor, Anthony Mackie, Aaron Paul, Clifton Collins Jr., Norman Reedus, Woody Harrelson, Kate Winslet, Teresa Palmer, Michael Kenneth Williams, Gal Gadot",
				DateAdded = new DateTime(2020, 12, 8),
				ReleaseYear = 2016,
				Rating = Rating.R,
				Duration = "115 min",
				Description = "A group of dirty Atlanta cops blackmailed by the Russian mob plan a seemingly impossible heist that sets off an explosive chain reaction of violence.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1222,
				ShowType = ShowType.Movie,
				Title = "Spirit Riding Free: Ride Along Adventure",
				Director = "Beth Sleven, Allan Jacobsen, Kevin Wotton",
				Cast = "Amber Frank, Bailey Gambertoglio, Sydney Park, Katey Sagal, Rachel Kimsey, Darcy Rose Byrnes, Duncan Joiner, Bella Aboulhosn, Kai Scott",
				DateAdded = new DateTime(2020, 12, 8),
				ReleaseYear = 2020,
				Rating = Rating.TVY7,
				Duration = "79 min",
				Description = "Join Lucky and her friends on an interactive mission to save Maricela's beloved mare from greedy horse thieves who've taken her captive with a wild herd.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Family"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1223,
				ShowType = ShowType.Movie,
				Title = "Bobbleheads The Movie",
				Director = "Kirk Wise",
				Cast = "Jennifer Coolidge, Karen Fukuhara, Khary Payton, Julian Sands, Brenda Song, Luke Wilson, Cher",
				DateAdded = new DateTime(2020, 12, 8),
				ReleaseYear = 2020,
				Rating = Rating.PG,
				Duration = "83 min",
				Description = "A team of bobbleheads band together to defend their collector's home when uninvited relatives barge in looking to steal from his prized collection.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Family"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1224,
				ShowType = ShowType.Movie,
				Title = "The Prom",
				Director = "Ryan Murphy",
				Cast = "Meryl Streep, James Corden, Nicole Kidman, Kerry Washington, Andrew Rannells, Keegan-Michael Key, Jo Ellen Pellman, Ariana DeBose, Mary Kay Place, Kevin Chamberlin, Tracey Ullman, Logan Riley, Sofia Deler, Nico Greetham, Nathaniel J. Potvin",
				DateAdded = new DateTime(2020, 12, 11),
				ReleaseYear = 2020,
				Rating = Rating.PG13,
				Duration = "132 min",
				Description = "A group of down-on-their-luck Broadway stars shake up a small Indiana town as they rally behind a teen who just wants to attend prom with her girlfriend.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1225,
				ShowType = ShowType.Movie,
				Title = "Giving Voice",
				Director = "James D. Stern, Fernando Villena",
				Cast = "Viola Davis, Denzel Washington, Stephen Henderson, Freedom Martin, Nia Sarfo, Cody Merridith, Gerardo Navarro, Aaron Guy, Callie Holley",
				DateAdded = new DateTime(2020, 12, 11),
				ReleaseYear = 2020,
				Rating = Rating.PG13,
				Duration = "91 min",
				Description = "Six ambitious student actors audition for the prestigious August Wilson Monologue Competition, culminating in a riveting final round on Broadway.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Documentary"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1226,
				ShowType = ShowType.Movie,
				Title = "Canvas",
				Director = "Frank E. Abney III",
				Cast = "",
				DateAdded = new DateTime(2020, 12, 11),
				ReleaseYear = 2020,
				Rating = Rating.G,
				Duration = "9 min",
				Description = "After a heartbreaking loss, a grandfather struggling to reclaim his passion for painting finds the inspiration to create again.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Family"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1227,
				ShowType = ShowType.Movie,
				Title = "A California Christmas",
				Director = "Shaun Paul Piccinino",
				Cast = "Lauren Swickard, Josh Swickard, Ali Afshar, David Del Rio, Natalia Mann, Katelyn Epperly, Gunnar Anderson, Julie Lancaster, Amanda Detmer",
				DateAdded = new DateTime(2020, 12, 14),
				ReleaseYear = 2020,
				Rating = Rating.PG13,
				Duration = "107 min",
				Description = "With his carefree lifestyle on the line, a wealthy charmer poses as a ranch hand to get a hardworking farmer to sell her family's land before Christmas.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Romance"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1228,
				ShowType = ShowType.TV,
				Title = "Tiny Pretty Things",
				Director = "",
				Cast = "Lauren Holly, Kylie Jefferson, Casimere Jollette, Brennan Clost, Barton Cowperthwaite, Bayardo De Murguia, Damon J. Gillespie, Anna Maiche, Daniela Norman, Michael Hsu Rosen, Tory Trowbridge",
				DateAdded = new DateTime(2020, 12, 14),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "1 Season",
				Description = "When an attack brings down the star student at an elite ballet school, her replacement enters a world of lies, betrayal, and cutthroat competition.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Thriller"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1229,
				ShowType = ShowType.TV,
				Title = "Song Exploder",
				Director = "",
				Cast = "Hrishikesh Hirway",
				DateAdded = new DateTime(2020, 12, 15),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "2 Seasons",
				Description = "Get inspired as musicians dig deep into the creative process of songwriting and reveal their intimate thoughts in a series based on the hit podcast.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Docuseries"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1230,
				ShowType = ShowType.TV,
				Title = "The Challenge",
				Director = "",
				Cast = "Jamie Chung, Landon Lueck, Diem Brown, Mike 'The Miz' Mizanin, Darrell Taylor, Wes Bergmann, Jodi Weatherton, Brad Fiorenza, Cara Maria Sorbello, Zachary Nichols, Turabi 'Turbo' Camkiran, Theo Campbell",
				DateAdded = new DateTime(2020, 12, 15),
				ReleaseYear = 2006,
				Rating = Rating.TV14,
				Duration = "2 Seasons",
				Description = "Reality show alumni must compete in grueling physical contests and survive eliminations amid cutthroat alliances and steamy hookups to win big money.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Reality TV"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1231,
				ShowType = ShowType.TV,
				Title = "Black Ink Crew New York",
				Director = "",
				Cast = "Ceaser Emanuel, Dutchess Lattimore, Puma Robinson, Alex Estevez, Sassy Bermudez",
				DateAdded = new DateTime(2020, 12, 15),
				ReleaseYear = 2014,
				Rating = Rating.TV14,
				Duration = "2 Seasons",
				Description = "At a Black-owned-and-operated hotspot for ink in Harlem, tattoo king Ceaser looks to expand his empire while working with a rambunctious crew.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Reality TV"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1232,
				ShowType = ShowType.Movie,
				Title = "Nocturnal Animals",
				Director = "Tom Ford",
				Cast = "Amy Adams, Jake Gyllenhaal, Michael Shannon, Aaron Taylor-Johnson, Isla Fisher, Ellie Bamber, Armie Hammer, Karl Glusman, Laura Linney, Michael Sheen, Andrea Riseborough",
				DateAdded = new DateTime(2020, 12, 16),
				ReleaseYear = 2016,
				Rating = Rating.R,
				Duration = "117 min",
				Description = "Reading her ex-husband's violent novel manuscript destabilizes gallery owner Susan's life, upending her present while digging up their past.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1233,
				ShowType = ShowType.Movie,
				Title = "Incarnate",
				Director = "Brad Peyton",
				Cast = "Aaron Eckhart, Carice van Houten, Catalina Sandino Moreno, David Mazouz, Keir O'Donnell, Matt Nable, Emily Jackson, Paul Vincent O'Connor, Natalija Nogulich, John Pirruccello, Mark Steger, Emjay Anthony, Karolina Wydra",
				DateAdded = new DateTime(2020, 12, 16),
				ReleaseYear = 2016,
				Rating = Rating.PG13,
				Duration = "87 min",
				Description = "An unconventional demon hunter faces his greatest challenge when he steps inside the subconscious mind of a boy possessed by a powerful entity.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Horror"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1234,
				ShowType = ShowType.TV,
				Title = "Schulz Saves America",
				Director = "Alexx Media",
				Cast = "Andrew Schulz",
				DateAdded = new DateTime(2020, 12, 17),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "1 Season",
				Description = "Comedian Andrew Schulz takes on the year's most divisive topics in this fearlessly unfiltered and irreverent four-part special.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Stand-Up Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1235,
				ShowType = ShowType.Movie,
				Title = "Guest House",
				Director = "Sam Macaroni",
				Cast = "Pauly Shore, Mike Castle, Aimee Teegarden, Billy Zane, Charlotte McKinney, Louis Ferrigno,  Jr., Erik Griffin, Bobby Lee, Punkie Johnson, Mikaela Hoover, Chris Kattan, Steve-O",
				DateAdded = new DateTime(2020, 12, 18),
				ReleaseYear = 2020,
				Rating = Rating.R,
				Duration = "84 min",
				Description = "The only downside to a young couple's new dream home - and fresh start - is the nightmare of the raucous houseguest in back who refuses to leave.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1236,
				ShowType = ShowType.TV,
				Title = "Jeopardy!",
				Director = "",
				Cast = "Alex Trebek",
				DateAdded = new DateTime(2020, 12, 18),
				ReleaseYear = 2019,
				Rating = Rating.TVG,
				Duration = "2 Seasons",
				Description = "Alex Trebek hosts one of TV's longest-running game shows, where a trio of players buzz in with their knowledge of history, arts, pop culture and more.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Reality TV"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1237,
				ShowType = ShowType.Movie,
				Title = "After We Collided",
				Director = "Roger Kumble",
				Cast = "Josephine Langford, Hero Fiennes Tiffin, Dylan Sprouse, Selma Blair, Louise Lombard, Shane Paul McGhie, Candice King, Charlie Weber, Khadijha Red Thunder, Inanna Sarkis, Pia Mia, Samuel Larsen, Dylan Arnold, Karimah Westbrook, Rob Estes",
				DateAdded = new DateTime(2020, 12, 22),
				ReleaseYear = 2020,
				Rating = Rating.R,
				Duration = "105 min",
				Description = "Tessa fell hard and fast for Hardin, but after a betrayal tears them apart, she must decide whether to move on - or trust him with a second chance.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1238,
				ShowType = ShowType.Movie,
				Title = "The Midnight Sky",
				Director = "George Clooney",
				Cast = "George Clooney, Felicity Jones, Kyle Chandler, Demi??n Bichir, David Oyelowo, Tiffany Boone, Caoilinn Springall, Sophie Rundle, Ethan Peck",
				DateAdded = new DateTime(2020, 12, 23),
				ReleaseYear = 2020,
				Rating = Rating.PG13,
				Duration = "119 min",
				Description = "In the aftermath of a global catastrophe, a lone scientist in the Arctic races to contact a crew of astronauts with a warning not to return to Earth.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1239,
				ShowType = ShowType.Movie,
				Title = "We Can Be Heroes",
				Director = "Robert Rodriguez",
				Cast = "YaYa Gosselin, Pedro Pascal, Priyanka Chopra, Isaiah Russell-Bailey, Akira Akbar, Christian Slater, Boyd Holbrook, Adriana Barraza, Taylor Dooley, Vivien Lyra Blair, Hala Finley, Lyon Daniels, Sung Kang, Christopher McDonald, Andy Walken, Lotus Blossom, Haley Reinhart, Nathan Blair, Dylan Henry Lau, Andrew Diaz",
				DateAdded = new DateTime(2020, 12, 25),
				ReleaseYear = 2020,
				Rating = Rating.PG,
				Duration = "101 min",
				Description = "When alien invaders capture Earth's superheroes, their kids must learn to work together to save their parents - and the planet.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Family"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1240,
				ShowType = ShowType.TV,
				Title = "Bridgerton",
				Director = "",
				Cast = "Adjoa Andoh, Julie Andrews, Lorraine Ashbourne, Jonathan Bailey, Ruby Barker, Sabrina Bartlett, Harriet Cains, Bessie Carter, Nicola Coughlan, Phoebe Dynevor, Ruth Gemmell, Florence Hunt, Claudia Jessie, Ben Miller, Luke Newton, Rege-Jean Page, Golda Rosheuvel, Luke Thompson, Will Tilston, Polly Walker",
				DateAdded = new DateTime(2020, 12, 25),
				ReleaseYear = 2020,
				Rating = Rating.TVMA,
				Duration = "1 Season",
				Description = "The eight close-knit siblings of the Bridgerton family look for love and happiness in London high society. Inspired by Julia Quinn's bestselling novels.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Romance"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1241,
				ShowType = ShowType.Movie,
				Title = "Cops and Robbers",
				Director = "Arnon Manor, Timothy Ware-Hill",
				Cast = "Timothy Ware-Hill",
				DateAdded = new DateTime(2020, 12, 28),
				ReleaseYear = 2020,
				Rating = Rating.PG13,
				Duration = "8 min",
				Description = "Animation and activism unite in this multimedia spoken-word response to police brutality and racial injustice.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1242,
				ShowType = ShowType.Movie,
				Title = "Rango",
				Director = "Gore Verbinski",
				Cast = "Johnny Depp, Isla Fisher, Abigail Breslin, Ned Beatty, Alfred Molina, Bill Nighy, Stephen Root, Harry Dean Stanton, Timothy Olyphant, Ray Winstone",
				DateAdded = new DateTime(2020, 12, 28),
				ReleaseYear = 2011,
				Rating = Rating.PG,
				Duration = "110 min",
				Description = "When he becomes lost in the desert, pet chameleon Rango pretends he's a tough guy and ends up sheriff of a corrupt and violent frontier town.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Family"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1243,
				ShowType = ShowType.TV,
				Title = "Dare Me",
				Director = "",
				Cast = "Willa Fitzgerald, Herizen Guardiola, Marlo Kelly, Rob Heaps, Zach Roerig, Paul Fitzgerald, Alison Thornton, Tammy Blanchard, Amanda Brugel, Chris Zylka",
				DateAdded = new DateTime(2020, 12, 30),
				ReleaseYear = 2019,
				Rating = Rating.TVMA,
				Duration = "1 Season",
				Description = "Relationships topple and loyalties flip when an icy new cheerleading coach takes over the high school squad ruled by Beth and her devoted BFF, Addy.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Crime"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1244,
				ShowType = ShowType.Movie,
				Title = "Alaska Is a Drag",
				Director = "Shaz Bennett",
				Cast = "Martin L. Washington Jr., Maya Washington, Matt Dallas, Christopher O'Shea, Jason Scott Lee, Margaret Cho, Kevin Daniels, John Fleck, Nia Peeples, Adam Tomei",
				DateAdded = new DateTime(2020, 12, 31),
				ReleaseYear = 2017,
				Rating = Rating.TVMA,
				Duration = "83 min",
				Description = "Tormented by bullies, an aspiring drag star working at an Alaskan cannery becomes a skilled fighter and is tapped for competition by a boxing coach.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1245,
				ShowType = ShowType.TV,
				Title = "Chilling Adventures of Sabrina",
				Director = "",
				Cast = "Kiernan Shipka, Ross Lynch, Miranda Otto, Lucy Davis, Chance Perdomo, Michelle Gomez, Richard Coyle, Jaz Sinclair, Lachlan Watson, Tati Gabrielle, Adeline Rudolph, Abigail Cowen, Gavin Leatherwood, Bronson Pinchot",
				DateAdded = new DateTime(2020, 12, 31),
				ReleaseYear = 2020,
				Rating = Rating.TV14,
				Duration = "4 Seasons",
				Description = "Magic and mischief collide as half-human, half-witch Sabrina navigates between two worlds: mortal teen life and her family's legacy, the Church of Night.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Horror"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1246,
				ShowType = ShowType.Movie,
				Title = "Into the Wild",
				Director = "Sean Penn",
				Cast = "Emile Hirsch, Marcia Gay Harden, William Hurt, Jena Malone, Brian Dierker, Catherine Keener, Vince Vaughn, Kristen Stewart, Hal Holbrook, Zach Galifianakis",
				DateAdded = new DateTime(2021, 1, 1),
				ReleaseYear = 2007,
				Rating = Rating.R,
				Duration = "148 min",
				Description = "A young man gives up everything - including his trust fund and ties to a seemingly stable family - to lead a solitary life in the wild.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Action & Adventure"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1247,
				ShowType = ShowType.Movie,
				Title = "Killers",
				Director = "Robert Luketic",
				Cast = "Katherine Heigl, Ashton Kutcher, Tom Selleck, Catherine O'Hara, Katheryn Winnick, Kevin Sussman, Lisa Ann Walter, Casey Wilson, Rob Riggle, Martin Mull, Alex Borstein",
				DateAdded = new DateTime(2021, 1, 1),
				ReleaseYear = 2010,
				Rating = Rating.PG13,
				Duration = "100 min",
				Description = "After a whirlwind romance, Jen and Spencer settle into married life - until Spencer's secret past as a hit man shakes up their suburban bliss.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Action & Adventure"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1248,
				ShowType = ShowType.Movie,
				Title = "30 Minutes or Less",
				Director = "Ruben Fleischer",
				Cast = "Jesse Eisenberg, Danny McBride, Aziz Ansari, Nick Swardson, Dilshad Vadsaria, Michael Pe??a, Bianca Kajlich, Fred Ward",
				DateAdded = new DateTime(2021, 1, 1),
				ReleaseYear = 2011,
				Rating = Rating.R,
				Duration = "83 min",
				Description = "Two crooks planning a bank heist wind up abducting a pizza delivery driver and force him to commit the robbery with a strict time limit.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Action & Adventure"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1249,
				ShowType = ShowType.TV,
				Title = "Cobra Kai",
				Director = "",
				Cast = "Ralph Macchio, William Zabka, Xolo Maridue??a, Martin Kove, Mary Mouser, Tanner Buchanan, Courtney Henggeler, Jacob Bertrand",
				DateAdded = new DateTime(2021, 1, 1),
				ReleaseYear = 2021,
				Rating = Rating.TV14,
				Duration = "3 Seasons",
				Description = "Decades after the tournament that changed their lives, the rivalry between Johnny and Daniel reignites in this sequel to the 'Karate Kid' films.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Action & Adventure"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1250,
				ShowType = ShowType.Movie,
				Title = "Bonnie and Clyde",
				Director = "Arthur Penn",
				Cast = "Warren Beatty, Faye Dunaway, Michael J. Pollard, Gene Hackman, Estelle Parsons, Denver Pyle, Dub Taylor, Evans Evans, Gene Wilder",
				DateAdded = new DateTime(2021, 1, 1),
				ReleaseYear = 1967,
				Rating = Rating.R,
				Duration = "111 min",
				Description = "Bonnie Parker and Clyde Barrow are young, in love and on the run during a bullet-riddled bank robbery spree across Depression-ravaged America.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Classics"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1251,
				ShowType = ShowType.Movie,
				Title = "Cool Hand Luke",
				Director = "Stuart Rosenberg",
				Cast = "Paul Newman, George Kennedy, J.D. Cannon, Lou Antonio, Robert Drivas, Strother Martin, Jo Van Fleet, Harry Dean Stanton, Dennis Hopper, Joe Don Baker, James Gammon, Wayne Rogers",
				DateAdded = new DateTime(2021, 1, 1),
				ReleaseYear = 1967,
				Rating = Rating.TV14,
				Duration = "127 min",
				Description = "Luke Jackson likes to do things his own way, which leads to a world of hurt when he ends up in a prison camp - and on the wrong side of its warden.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Classics"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1252,
				ShowType = ShowType.Movie,
				Title = "What's Eating Gilbert Grape",
				Director = "Lasse Hallstrom",
				Cast = "Johnny Depp, Leonardo DiCaprio, Juliette Lewis, Mary Steenburgen, Darlene Cates, Laura Harrington, Mary Kate Schellhardt, Kevin Tighe, John C. Reilly, Crispin Glover",
				DateAdded = new DateTime(2021, 1, 1),
				ReleaseYear = 1993,
				Rating = Rating.PG13,
				Duration = "118 min",
				Description = "In a backwater Iowa town, young Gilbert is torn between taking care of his troubled family and a girl who shows him new possibilities for his life.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Classics"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1253,
				ShowType = ShowType.Movie,
				Title = "Julie & Julia",
				Director = "Nora Ephron",
				Cast = "Meryl Streep, Amy Adams, Stanley Tucci, Chris Messina, Linda Emond, Helen Carey, Mary Lynn Rajskub, Jane Lynch, Joan Juliet Buck",
				DateAdded = new DateTime(2021, 1, 1),
				ReleaseYear = 2009,
				Rating = Rating.PG13,
				Duration = "123 min",
				Description = "In this heartwarming tale, Julie Powell decides to spice up her uneventful life by cooking all 524 recipes outlined in Julia Child's classic cookbook.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1254,
				ShowType = ShowType.Movie,
				Title = "The Naked Gun: From the Files of Police Squad!",
				Director = "David Zucker",
				Cast = "Leslie Nielsen, Priscilla Presley, George Kennedy, Ricardo Montalban, O.J. Simpson, Raye Birk, Susan Beaubian, Nancy Marchand",
				DateAdded = new DateTime(2021, 1, 1),
				ReleaseYear = 1988,
				Rating = Rating.PG13,
				Duration = "85 min",
				Description = "Hapless cop Frank Drebin causes more problems than he solves while trying to stop a deadly plot involving Queen Elizabeth II.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1255,
				ShowType = ShowType.Movie,
				Title = "Mystic Pizza",
				Director = "Donald Petrie",
				Cast = "Annabeth Gish, Julia Roberts, Lili Taylor, Vincent D'Onofrio, William R. Moses, Adam Storke, Conchata Ferrell, Joanna Merlin, Porscha Radcliffe, John Fiore",
				DateAdded = new DateTime(2021, 1, 1),
				ReleaseYear = 1988,
				Rating = Rating.R,
				Duration = "104 min",
				Description = "In a small fishing town, three teenage girls from blue-collar families navigate life and love while working in a pizza parlor.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1256,
				ShowType = ShowType.Movie,
				Title = "Can't Hardly Wait",
				Director = "Harry Elfont, Deborah Kaplan",
				Cast = "Jennifer Love Hewitt, Ethan Embry, Charlie Korsmo, Lauren Ambrose, Peter Facinelli, Seth Green, Michelle Brookhurst, Alexander Martin, Erik Palladino, Channon Roe, Sean Patrick Thomas",
				DateAdded = new DateTime(2021, 1, 1),
				ReleaseYear = 1998,
				Rating = Rating.PG13,
				Duration = "101 min",
				Description = "At a wild high school graduation party, aspiring writer Preston hopes to declare his love to popular girl Amanda, who just got dumped by the class jock.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1257,
				ShowType = ShowType.Movie,
				Title = "17 Again",
				Director = "Burr Steers",
				Cast = "Zac Efron, Leslie Mann, Matthew Perry, Thomas Lennon, Michelle Trachtenberg, Melora Hardin, Sterling Knight, Hunter Parrish, Nicole Sullivan, Allison Miller",
				DateAdded = new DateTime(2021, 1, 1),
				ReleaseYear = 2009,
				Rating = Rating.PG13,
				Duration = "102 min",
				Description = "Nearing a midlife crisis, thirty-something Mike wishes for a 'do-over' and that's exactly what he gets when he wakes up to find he's 17 again.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1258,
				ShowType = ShowType.Movie,
				Title = "Mean Girls 2",
				Director = "Melanie Mayron",
				Cast = "Meaghan Martin, Maiara Walsh, Jennifer Stone, Nicole Gale Anderson, Claire Holt, Diego Boneta, Linden Ashby, Rhoda Griffis, Mike Pniewski, Patrick Johnson, Tim Meadows",
				DateAdded = new DateTime(2021, 1, 1),
				ReleaseYear = 2011,
				Rating = Rating.PG13,
				Duration = "98 min",
				Description = "The father of a high school pariah offers to pay another student's way through college if she makes friends with his outcast daughter.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Comedy"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1259,
				ShowType = ShowType.Movie,
				Title = "Good Hair",
				Director = "Jeff Stilson",
				Cast = "Chris Rock, Nia Long, Maya Angelou, Ice-T, Eve, Meagan Good, Al Sharpton, KRS-One, Raven-Symone",
				DateAdded = new DateTime(2021, 1, 1),
				ReleaseYear = 2009,
				Rating = Rating.PG13,
				Duration = "96 min",
				Description = "Chris Rock hops around the world going from beauty salons to science labs to comb through the mystery of Black hair.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Documentary"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1260,
				ShowType = ShowType.Movie,
				Title = "The Creative Brain",
				Director = "Jennifer Beamish, Toby Trackman",
				Cast = "David Eagleman",
				DateAdded = new DateTime(2021, 1, 1),
				ReleaseYear = 2019,
				Rating = Rating.TV14,
				Duration = "53 min",
				Description = "Neuroscientist David Eagleman taps into the creative process of various innovators while exploring brain-bending, risk-taking ways to spark creativity.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Documentary"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1261,
				ShowType = ShowType.Movie,
				Title = "The Minimalists: Less Is Now",
				Director = "",
				Cast = "",
				DateAdded = new DateTime(2021, 1, 1),
				ReleaseYear = 2021,
				Rating = Rating.TV14,
				Duration = "54 min",
				Description = "They've built a movement out of minimalism. Longtime friends Joshua Fields Millburn and Ryan Nicodemus share how our lives can be better with less.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Documentary"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1262,
				ShowType = ShowType.TV,
				Title = "Headspace Guide to Meditation",
				Director = "",
				Cast = "Andy Puddicombe",
				DateAdded = new DateTime(2021, 1, 1),
				ReleaseYear = 2021,
				Rating = Rating.TVG,
				Duration = "1 Season",
				Description = "Headspace takes a friendly, animated look at the benefits of meditation while offering techniques and guided meditations to jump-start your practice.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Docuseries"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1263,
				ShowType = ShowType.Movie,
				Title = "Mud",
				Director = "Jeff Nichols",
				Cast = "Matthew McConaughey, Reese Witherspoon, Tye Sheridan, Jacob Lofland, Sam Shepard, Ray McKinnon, Sarah Paulson, Michael Shannon, Joe Don Baker, Paul Sparks",
				DateAdded = new DateTime(2021, 1, 1),
				ReleaseYear = 2012,
				Rating = Rating.PG13,
				Duration = "131 min",
				Description = "Two Mississippi teens meet peculiar drifter Mud and get caught up in his web of tall tales about lost love, crimes of passion and bounty hunters.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1264,
				ShowType = ShowType.Movie,
				Title = "Gimme Shelter",
				Director = "Ron Krauss",
				Cast = "Vanessa Hudgens, James Earl Jones, Rosario Dawson, Ann Dowd, Stephanie Szostak, Emily Meade, Brendan Fraser, Dascha Polanco",
				DateAdded = new DateTime(2021, 1, 1),
				ReleaseYear = 2013,
				Rating = Rating.PG13,
				Duration = "101 min",
				Description = "After running away from her abusive mother, a streetwise teen seeks refuge with her father, but he rejects her when he learns that she's pregnant.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1265,
				ShowType = ShowType.TV,
				Title = "Jenni Rivera: Mariposa de Barrio",
				Director = "",
				Cast = "Angelica Celaya, Gabriel Porras, Rosalinda Rodri?guez, Samadhi Zendejas, Tony Garza, Regina Orqui?n, Enrique Montano, Adrian Carvajal, Emmanuel Morales, Adriano Zendejas, Xavier Ruvalcaba, Raul Sandoval, Mauricio Novoa, Uriel del Toro, Ana Wolfermann, Stephanie Arcila, Vanessa Pose, Alma Matrecito",
				DateAdded = new DateTime(2021, 1, 1),
				ReleaseYear = 2017,
				Rating = Rating.TVMA,
				Duration = "1 Season",
				Description = "This drama follows Mexican-American singer Jenni Rivera's unlikely rise from suicidal pregnant teen and abused wife to banda superstar.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1266,
				ShowType = ShowType.Movie,
				Title = "Cloudy with a Chance of Meatballs",
				Director = "Phil Lord, Christopher Miller",
				Cast = "Bill Hader, Anna Faris, James Caan, Andy Samberg, Bruce Campbell, Mr. T, Bobb'e J. Thompson, Benjamin Bratt, Neil Patrick Harris, Al Roker",
				DateAdded = new DateTime(2021, 1, 1),
				ReleaseYear = 2009,
				Rating = Rating.PG,
				Duration = "90 min",
				Description = "When inventor Flint Lockwood makes clouds rain food, the citizens of Chewandswallow can feed themselves. But a bowl of disaster is about to overflow.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Family"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1267,
				ShowType = ShowType.Movie,
				Title = "Full Out 2: You Got This!",
				Director = "Jeff Deverett",
				Cast = "Sydney Cope, Logan Edra, Liza Wilk, Braedyn Bruner, Billie Merritt",
				DateAdded = new DateTime(2021, 1, 1),
				ReleaseYear = 2020,
				Rating = Rating.TVY,
				Duration = "91 min",
				Description = "With a championship on the line, Chayse and her gymnastics team look to a local break-dancer for all the right moves to rise above their competition.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Family"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1268,
				ShowType = ShowType.TV,
				Title = "Dream Home Makeover",
				Director = "",
				Cast = "",
				DateAdded = new DateTime(2021, 1, 1),
				ReleaseYear = 2021,
				Rating = Rating.TVG,
				Duration = "2 Seasons",
				Description = "Dreams come true for real families looking for the perfect home tailored to their own unique style, thanks to Shea and Syd McGee of Studio McGee.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Reality TV"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1269,
				ShowType = ShowType.Movie,
				Title = "The American President",
				Director = "Rob Reiner",
				Cast = "Michael Douglas, Annette Bening, Martin Sheen, Michael J. Fox, David Paymer, Samantha Mathis, John Mahoney, Anna Deavere Smith, Nina Siemaszko, Wendie Malick, Shawna Waldron, Richard Dreyfuss, Joshua Malina",
				DateAdded = new DateTime(2021, 1, 1),
				ReleaseYear = 1995,
				Rating = Rating.PG13,
				Duration = "113 min",
				Description = "The widowed president strikes up a romance with a beautiful Washington lobbyist - but can the couple keep their private and political lives separate?",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Romance"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1270,
				ShowType = ShowType.Movie,
				Title = "Playing for Keeps",
				Director = "Gabriele Muccino",
				Cast = "Gerard Butler, Jessica Biel, Catherine Zeta-Jones, Dennis Quaid, Uma Thurman, Judy Greer, Noah Lomax, James Tupper, Abella Wyss, Grant Goodman",
				DateAdded = new DateTime(2021, 1, 3),
				ReleaseYear = 2012,
				Rating = Rating.PG13,
				Duration = "106 min",
				Description = "A washed-up, former soccer star attempts to rebuild his relationship with his son and ex-wife by coaching his son's soccer team.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Romance"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1271,
				ShowType = ShowType.Movie,
				Title = "An Imperfect Murder",
				Director = "James Toback",
				Cast = "Sienna Miller, Alec Baldwin, Charles Grodin, Colleen Camp, John Buffalo Mailer, Nick Mathews, Steven Prescod, Oliver 'Power' Grant, James Toback",
				DateAdded = new DateTime(2021, 1, 13),
				ReleaseYear = 2017,
				Rating = Rating.R,
				Duration = "71 min",
				Description = "Haunted by a nightmare involving her abusive ex-boyfriend, an actress begins to question her reality and whether the incident took place.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1272,
				ShowType = ShowType.Movie,
				Title = "What Would Sophia Loren Do?",
				Director = "Ross Kauffman",
				Cast = "Nancy 'Vincenza Careri' Kulik, Sophia Loren",
				DateAdded = new DateTime(2021, 1, 15),
				ReleaseYear = 2021,
				Rating = Rating.TV14,
				Duration = "32 min",
				Description = "In this delightful short documentary, an Italian American grandmother and film buff finds strength and joy in the life of her screen idol, Sophia Loren.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Documentary"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1273,
				ShowType = ShowType.Movie,
				Title = "Hook",
				Director = "Steven Spielberg",
				Cast = "Dustin Hoffman, Robin Williams, Julia Roberts, Bob Hoskins, Maggie Smith, Caroline Goodall, Charlie Korsmo, Amber Scott, Laurel Cronin, Phil Collins",
				DateAdded = new DateTime(2021, 1, 15),
				ReleaseYear = 1991,
				Rating = Rating.PG,
				Duration = "142 min",
				Description = "Peter Pan, now grown up and a workaholic, must return to Neverland to save his kids from the clutches of vengeful pirate Captain Hook.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Family"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1274,
				ShowType = ShowType.Movie,
				Title = "The Vanished",
				Director = "Peter Facinelli",
				Cast = "Thomas Jane, Anne Heche, Jason Patric, John D. Hickman, Peter Facinelli, Alex Haydon, Aleksei Archer, Kristopher Wente",
				DateAdded = new DateTime(2021, 1, 15),
				ReleaseYear = 2020,
				Rating = Rating.R,
				Duration = "115 min",
				Description = "When their daughter disappears during a family vacation, two terrified parents launch their own investigation that soon exposes local secrets.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Thriller"),
			}) ;

			AllShows.Add(new Show
			{
				UniqueIdentifier = 1275,
				ShowType = ShowType.Movie,
				Title = "Radium Girls",
				Director = "Lydia Dean Pilcher, Ginny Mohler",
				Cast = "Joey King, Abby Quinn, Cara Seymour, Scott Shepherd, Susan Heyward, Neal Huff, Collin Kelly-Sordelet, John Bedford Lloyd, Joe Grifasi, Colby Minifie",
				DateAdded = new DateTime(2021, 1, 16),
				ReleaseYear = 2018,
				Rating = Rating.TV14,
				Duration = "103 min",
				Description = "When the women at a radium factory begin to fall gravely and inexplicably ill, Bessie and her co-workers set out to expose a corporate cover-up.",
				Category = db.Categories.FirstOrDefault(c => c.CategoryName == "Drama"),
			}) ;

			//create some counters to help debug problems
			Int32 intShowID = 0;
			String strShowTitle = "Start";

			//loop through the list to add or update the job posting
			try
			{
				foreach (Show seedShow in AllShows)
				{
					//update the counters
					intShowID = seedShow.ShowID;
					strShowTitle = seedShow.Title;
					//see if the show is already in the database using the UniqueIdentifier
					Show dbShow = db.Shows.FirstOrDefault(s => s.UniqueIdentifier == seedShow.UniqueIdentifier);

					//if dbShow is null, show is not in database
					if (dbShow == null)
					{
						//Add the show to the database
						db.Shows.Add(seedShow);
						db.SaveChanges();
					}
					else //the show is in the database - reset all fields except ID and Unique Identifier
					{
						dbShow.ShowType = seedShow.ShowType;
						dbShow.Title = seedShow.Title;
						dbShow.Director = seedShow.Director;
						dbShow.Cast = seedShow.Cast;
						dbShow.DateAdded = seedShow.DateAdded;
						dbShow.ReleaseYear = seedShow.ReleaseYear;
						dbShow.Rating = seedShow.Rating;
						dbShow.Duration = seedShow.Duration;
						dbShow.Description = seedShow.Description;
						dbShow.Category = seedShow.Category;
						db.SaveChanges();
					}
				}
			}
			catch (Exception ex) //throw error if there is a problem in the database
			{
				StringBuilder msg = new StringBuilder();
				msg.Append("There was a problem adding the show with the title: ");
				msg.Append(strShowTitle);
				msg.Append(" (ShowID: ");
				msg.Append(intShowID);
				msg.Append(")");
				throw new Exception(msg.ToString(), ex);
			}
		}
	}
}
