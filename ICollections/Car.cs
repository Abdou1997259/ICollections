using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICollections
{
    public class Car:IComparable
    {


        public int Id { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public override int GetHashCode()
        {
            int key = 7;
            int hashCode=key*3 +Id.GetHashCode();
            hashCode=hashCode*3 +Model.GetHashCode();

            return hashCode;

        }
        public override bool Equals(object? obj)
        {
            if (obj is null)
                return false;
            if (obj is not Car car)
                return false;
            return this.Equals(car.Id) && this.Equals(car.Model);
        }
        public override string ToString()
        {
            return $"Id : {this.Id} Model : {this.Model} Price : {this.Price}";
        }

        public int CompareTo(object obj)
        {
            if (object.ReferenceEquals(this,obj))
                return 0;
            if (obj is null)
                return -1;
            return this.Id.CompareTo(((Car)obj).Id);
        }
    }
}
