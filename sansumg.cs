  namespace subsistemas
  {
    
  
  class sansumg:baracel{
public sansumg (string nombre,string almacenamiento,string ram,string prosupuesto):base(nombre,almacenamiento,ram,prosupuesto){
           
}
public override void imprimir(){
    Console.WriteLine("el nombre  del telefono es  "  + nombre  +  "  su almacenamiento es "  + almacenamiento + "  su ram es " + ram + " y el valor es " + prosupuesto );
}

}
  }