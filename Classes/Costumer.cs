using System;
namespace Classes
{
	public class Costumer
	{
        public Costumer()
        {
            //Constructor.
        }

        public Costumer(int id,string Name,string LastName,string City)
		{
			this.Id = Id;
			this.Name = Name;
			this.LastName = LastName;
			this.City = City;
		}

        //Bunlara property denir.

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}



/* 

Bunlara property denir.
    public string Name { get; set; }
Bunlara Field denir.
    public string Name; 

 */  