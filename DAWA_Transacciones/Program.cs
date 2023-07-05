using DAWA_Transacciones.Models;

class Program
{
    static void Main(string[] args)
    {
        addTemaSolistaTransaction();
    }

    public static void addTemaSolistaTransaction()
    {
        Console.WriteLine("Metodo agregar tema musical de solista");

        DBContext context = new DBContext();
        Cantante cantante = new Cantante();
        Album album = new Album();
        Musica musica = new Musica();
        var transaction = context.Database.BeginTransaction();

        try
        {
            //Agregar Autor
            cantante.Nombre = "Daddy Yankee";
            cantante.Nacionalidad = "Puertoriqueño";
            cantante.Genero = 'M';
            cantante.Estado = true;
            context.Cantante.Add(cantante);
            context.SaveChanges();

            //Agregar Album
            album.Nombre = "Barrio Fino";
            album.Periodo = 2004;
            album.Sello = "Cartel Record";
            album.Estado = true;
            context.Album.Add(album);
            context.SaveChanges();

            //Agregar Cancion
            musica.Nombre = "Gasolina";
            musica.AutorId = cantante.AutorId;
            musica.AlbumId = album.AlbumId;
            musica.Estado = true;
            context.Musica.Add( musica);
            context.SaveChanges();

            transaction.Commit();
            Console.WriteLine("Datos agregados exitosamente");
        }
        catch (Exception e)
        {
            transaction.Rollback();
            Console.WriteLine("Error " + e.ToString());
        }
    }
}
