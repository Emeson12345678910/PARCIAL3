using TERCER_PARCIAL_PROGRAAM;

using (var contexto = new Context())
{
    contexto.Database.EnsureCreated();

    bool continuar = true;
    while (continuar)
    {
        Console.WriteLine("Ingrese un Id: ");
        int Id = int.Parse(Console.ReadLine());

        Console.WriteLine("\nIngrese el nombre del estudiante: ");
        string estudiante = Console.ReadLine();

        Console.WriteLine("\nIngrese las notas de sus parciales: ");
        double parciales = float.Parse(Console.ReadLine());

        Console.WriteLine("\nIngrese la nota de sus laboratorios: ");
        double laboratorios = float.Parse(Console.ReadLine());

        Console.WriteLine("\nIngrese la nota final: ");
        double final = float.Parse(Console.ReadLine());

        var Notas = new NOTAS
        {
            id = Id,
            estudiante = estudiante,
            parciales = parciales,
            laboratorios = laboratorios,
            final = final,
        };

        contexto.Add(Notas);
        contexto.SaveChanges();

        Console.Write("¿Desea agregar otro registro? (S/N): ");
        string notafinal = Console.ReadLine();
        continuar = (notafinal.ToLower() == "s");
    }
}














//using TERCER_PARCIAL_PROGRAAM;

//using (var context = new Context())
//{
//    Console.WriteLine("Lista de Estudiantes de la base de datos:");
//    foreach (var datos in context.NOTAS.ToList())
//    {
//        Console.WriteLine($"ID: {datos.id}, Nombre: {datos.estudiante}, nota del laboratorio: {datos.laboratorios}, nota final: {datos.final},");
//    }
//}


