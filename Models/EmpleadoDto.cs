namespace TestApi.Models
{
    public class EmpleadoDto
    {
        public int id { get; set; }
        public string nombre { get; set; }
         public int edad { get; set; }
        public float salario { get; set; }
    }


    public class RootObject
    {     
    public List<EmpleadoDto> empleados { get; set; }
    }


}
