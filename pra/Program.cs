using pra;

NewMethod();

static void NewMethod()
{
    List<Figuras> cad = new List<Figuras>();
    int opcion;
    do
    {
        Console.WriteLine("++++++++++++++++++++PARA RESOLVER EJERCICIOS DE AREAS++++++++++++++");
        Console.WriteLine("1. Para poder comenzar a resolver amiguito:    =)");
        Console.WriteLine("2. Para poder finalizar todo amiguito:   =)");
        opcion = int.Parse(Console.ReadLine());


        switch (opcion)
        {
            case 1:
                Figuras.crear(cad);
            break;
        
        
            
        
        
        
        
        }
    
    
    }while (opcion !=2 );







}
