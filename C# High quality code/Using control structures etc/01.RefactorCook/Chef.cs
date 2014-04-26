public class Chef
    {
	    public void Cook()
        {
            Potato potato = this.GetPotato();
            Carrot carrot = this.GetCarrot();
            Bowl bowl = this.GetBowl();
            
            this.Peel(potato);      
            this.Peel(carrot);
            this.Cut(potato);
            this.Cut(carrot);

            bowl.Add(carrot);        
            bowl.Add(potato);
        }

        private Bowl GetBowl()
        {
            // TODO...
        }

        private Carrot GetCarrot()
        {
            // TODO...
        }

        private Potato GetPotato()
        {
            // TODO...
        }

        private void Cut(Vegetable vegetable)
        {
            // TODO...
        }  
    }