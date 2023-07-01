using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace turn.ClassControl
{
    public class ClientControl
    {
    public int IdCliente { get; set; }
    public string Name { get; set; }
    public string Sex { get; set; }
    public int Age { get; set; }
    public DateTime Data { get; set; }
    public string Email { get; set; }
    public string CPF { get; set; }

    public ClientControl(int idCliente, string name, string sex, int age, DateTime data, string email, string cPF)
    {
     
        IdCliente = idCliente;
        Name = name;
        Sex = sex;
        Age = age;
        Data = data;
        Email = email;
        CPF = cPF;
    }


    public ClientControl()
    {


    }
  }
}
