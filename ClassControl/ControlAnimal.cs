using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace turn.ClassControl
{
    public class ControlAnimal
    {
            public int IdAnimal { get; set; }
    public string Name { get; set; }
    public string Sex { get; set; }
    public int Age { get; set; }
    public DateTime Data { get; set; }
    public string Raca { get; set; }

    public ControlAnimal(int idAnimal, string name, string sex, int age, DateTime data, string raca)
    {

        IdAnimal = idAnimal;
        Name = name;
        Sex = sex;
        Age = age;
        Data = data;
        Raca = raca;
    }
    public ControlAnimal()
    {

    }
} 

}
