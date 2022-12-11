namespace subsistemas
{
    

class cfachada{
    private infinix infinix =new infinix("infinix","64gb","4","250");
   private nokia nokia=new nokia ("nokia","32gb","2","150");
    private sansumg sansumg=new sansumg("sansumg","32gb","4","200");
    public void compra(){
       infinix.imprimir();
        nokia.imprimir();
        sansumg.imprimir();
    }
}
}