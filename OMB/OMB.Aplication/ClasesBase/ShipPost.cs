namespace OMB.Aplication.ClasesBase;

public class ShipPost{
    public int Id {get; set;} //No sé si sirve de algo
    public int ShipId {get; set;}
    public DateTime posted {get; set;}

    public ShipPost(int ShipId){
        this.ShipId = ShipId;
        this.posted = DateTime.Now; //Creo que esto está bien??
    }
}