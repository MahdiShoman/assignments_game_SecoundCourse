using UnityEngine;

public class CustomObject 
{
   public  int ID { get; set; }
   public string Name { get; set; } 
   public CustomObject(int id , string name ) {
    ID = id;
    Name = name;
   }
   

   //ToString
   public override string ToString(){

   return $"Object [ID: {ID}, Name: {Name}]";
}

    //Equals method

    // public override bool Equals(object obj){
    //     if (obj == null || GetType() != obj.GetType())
    //         return false;

    //     var newObj = (CustomObject)obj;
    //     return ID == newObj.ID && Name == newObj.Name;
    // }

    //operator == method
    public static bool operator == (CustomObject obj1, CustomObject obj2){
        return obj1.ID == obj2.ID && obj1.Name == obj2.Name;
    }

    //operator != method
    public static bool operator !=(CustomObject obj1, CustomObject obj2){
        return !(obj1 == obj2);
    }

}
