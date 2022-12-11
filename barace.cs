using System;
namespace subsistemas
{
    

 public abstract class baracel{
    public string nombre {get;set;}
    public string almacenamiento {get;set;}
    public string ram {get;set;}
    public string prosupuesto {get;set;}
    public baracel(string nombre,string almacenamiento,string ram,string prosupuesto){
        this.nombre=nombre;
        this.almacenamiento=almacenamiento;
        this.ram=ram;
        this.prosupuesto=prosupuesto;
        
    }
    public abstract void imprimir();
 }
}
 
