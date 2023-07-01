using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace turn.ClassControl
{
public class Medic
    {

 public string Nome { get; set; }
 public string DepM { get; set;}
 public ClientControl ClientControl {get;set;}
 public ControlAnimal ControlAnimal {get;set;}


 public Medic()
 {

 }

 public Medic(ClientControl clientControl,string dep,string name)
 {
   
   ClientControl=clientControl;
   DepM=dep;
   Nome=name;
 }

 public Medic(ControlAnimal controlAnimal,string dep,string name) {
  ControlAnimal=controlAnimal;
  DepM=dep;
  Nome=name;
 }
} 
}
    


