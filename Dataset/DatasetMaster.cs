using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using turn.ClassControl;

namespace turn.Dataset
{
public class DatasetMaster
   {
         
     public List<ClientControl> clientControls = new List<ClientControl>();
     public List<ControlAnimal> controlAnimals = new List<ControlAnimal>();
     public List<Medic> medics=new List<Medic>();
     public List<Clinic> clinics = new List<Clinic>();

     public void InsertClient(ClientControl client)
     {
         if (client != null)
         {
             clientControls.Add(client);
             Console.WriteLine();
         }
     }

     public void DeleteClient(ClientControl client, int id)
     {
         if (client != null)
         {
             for (int i = 0; i < clientControls.Count; i++)
             {
                 if (clientControls[i].IdCliente == id)
                 {
                     clientControls.RemoveAt(i);
                 }
             }
         }
         Console.WriteLine();

     }

     public void InsertAnimal(ControlAnimal animal)
     {
         if (animal != null)
         {
             controlAnimals.Add(animal);
             Console.WriteLine();
         }
     }

     public void DeleteAnimal(ControlAnimal animal, int id)
     {
         if (animal != null)
         {
             for (int i = 0; i < controlAnimals.Count; i++)
             {
                 if (controlAnimals[i].IdAnimal == id)
                 {
                     controlAnimals.RemoveAt(id);
                 }
             }

             Console.WriteLine();
         }

     }


     public void InsertDoctor(Medic medic)
     {
         if(medic != null)
         {
             medics.Add(medic);
             Console.WriteLine();
         }
     }

     public void InsertClinic(Clinic clinic){
            if(clinic!=null){
                clinics.Add(clinic);
            }
     }
 


    


     public void ImpressClint(ClientControl client)
     {
         if (client != null)
         {
             foreach (ClientControl c in clientControls)
             {
                 Console.WriteLine($"ID:{c.IdCliente}");
                 Console.WriteLine($"Name:{c.Name}");
                 Console.WriteLine($"Sex:{c.Sex}");
                 Console.WriteLine($"Age:{c.Age}");
                 Console.WriteLine($"Email:{c.Email}");
                 Console.WriteLine($"CPF:{c.CPF}");
                 Console.WriteLine($"Data:{c.Data.ToLongDateString()}");
                 Console.WriteLine();

             }
             {

             }
         }
     }



     public void ImpressAnimal(ControlAnimal animal)
     {
         if (animal != null)
         {
             foreach (ControlAnimal a in controlAnimals)
             {
                 Console.WriteLine($"ID:{a.IdAnimal}");
                 Console.WriteLine($"Name:{a.Name}");
                 Console.WriteLine($"Sex:{a.Sex}");
                 Console.WriteLine($"Age:{a.Age}");
                 Console.WriteLine($"Email:{a.Raca}");
                 Console.WriteLine($"Data:{a.Data.ToLongDateString()}");
                 Console.WriteLine();

             }
             {

             }
         }
     }



     public void ImpressDoctor(Medic doctor)
     {
         if (doctor != null)
         {
             foreach (Medic m in medics)
             {
                 Console.WriteLine($"Nome:{m.Nome}");
                 Console.WriteLine($"Dep:{m.DepM}");
                 Console.WriteLine();

             }
             {

             }
         }
     }









     public void UpdateClient_cpf(ClientControl client, int id, string cpf
        )
     {
         if (client != null)
         {
             if (client.IdCliente == id)
                 foreach (ClientControl c in clientControls)
                 {
                     if (c.IdCliente == id)
                     {
                         c.CPF = cpf;
                     }
                 }
         }
         Console.WriteLine();
     }

     public void UpdateClient_data(ClientControl client, int id,
        DateTime data)
     {
         if (client != null)
         {
             foreach (ClientControl c in clientControls)
             {
                 if (c.IdCliente != id)
                 {
                     c.Data = data;
                 }
             }
         }
         Console.WriteLine();
     }


     public void UpdateClient_email(ClientControl client, int id, string email
       )
     {
         if (client != null)
         {
             foreach (ClientControl c in clientControls)
                 if (client.IdCliente == id)
                 {
                     client.Email = email;

                 }
         }
         Console.WriteLine();
     }


     public void UpdateClient_nome(ClientControl client, int id, string name
       )
     {
         if (client != null)
         {
             foreach (ClientControl c in clientControls)
             {
                 if (c.IdCliente == id)
                 {
                     c.Name = name;
                 }
             }
         }
         Console.WriteLine();
     }



     public void Updateanimal_nome(ControlAnimal animal, 
     int id, 
     string name
       )
     {
         if (animal != null)
         {
             foreach (ControlAnimal a in controlAnimals)
             {
                 if (a.IdAnimal == id)
                 {
                     a.Name = name;
                 }
             }
         }
         Console.WriteLine();
     }


     public void Updateanimal_data(ControlAnimal animal, int id, DateTime data
      )
     {
         if (animal != null)
         {
             foreach (ControlAnimal a in controlAnimals)
             {
                 if (a.IdAnimal == id)
                 {
                     a.Data = data;
                 }
             }
         }
         Console.WriteLine();
     }



     public void ImpressFileClient(ClientControl client, string path)
     {
         foreach (ClientControl c in clientControls)
         {
             if (client != null)
             {
                 using (StreamWriter ws = File.AppendText(path))
                 {
                     ws.WriteLine($"ID:{c.IdCliente}");
                     ws.WriteLine($"Name:{c.Name}");
                     ws.WriteLine($"Sex:{c.Sex}");
                     ws.WriteLine($"Age:{c.Age}");
                     ws.WriteLine($"Data:{c.Data}");
                     ws.WriteLine($"Email:{c.Email}");
                     ws.WriteLine($"CPF:{c.CPF}");
                     ws.WriteLine();

                 }

             }
         }
     }



         public void ImpressFileAnimal(ControlAnimal animal, string path)
         {
             foreach (ControlAnimal a in controlAnimals)
             {
                 if (animal != null)
                 {
                     using (StreamWriter ws = File.AppendText(path))
                     {
                         ws.WriteLine($"ID:{a.IdAnimal}");
                         ws.WriteLine($"Name:{a.Name}");
                         ws.WriteLine($"Sex:{a.Sex}");
                         ws.WriteLine($"Age:{a.Age}");
                         ws.WriteLine($"Data:{a.Data}");
                         ws.WriteLine($"Raça:{a.Raca}");
                         ws.WriteLine();

                     }

                 }
             }


         }



    public  List<ClientControl> CheckClient(Medic medic, int id){
        if(medic!=null){
            for(int i=0;i<medics.Count;i++){
                if(medics[i].ClientControl.IdCliente==id){
                     Console.WriteLine($"the client {medics[i].ClientControl.Name} will be attended by  doctor {medic.Nome} in date,{medics[i].ClientControl.Data.ToLongDateString()}"); 
                     break;
                }
                else{
                    return null;
                } 
            }
        }
         Console.WriteLine();
        return clientControls;
       
     }




       public  List<ControlAnimal> CheckAniaml(Medic medic, int id){
        if(medic!=null){
            for(int i=0;i<medics.Count;i++){
                if(medics[i].ControlAnimal.IdAnimal==id){
                     Console.WriteLine($"the animal {medics[i].ControlAnimal.Name} will be attended by  doctor {medic.Nome} in date,{medics[i].ControlAnimal.Data.ToLongDateString()}");
                                   
                }
                
            }
        }
        return controlAnimals;
     }



    


    public void impressAnimalClient1(Medic medic,string path,int x){
        if(medic!=null){
            if(x==1){
                foreach(Medic m in medics){
                    using(StreamWriter ws= File.AppendText(path)){
                     ws.WriteLine($"Dep:{m.DepM}");
                     ws.WriteLine($"Doctor:{m.Nome}");
                     ws.WriteLine($"Pacient:{m.ControlAnimal.IdAnimal};{m.ControlAnimal.Name};{m.ControlAnimal.Raca};{m.ControlAnimal.Data.ToShortDateString()}");
                     Console.WriteLine();
                       
                        
                    }

                }
            }
            else  if(x==2){
               foreach(Medic m in  medics){ 
                using(StreamWriter ws= File.AppendText(path)){
                     ws.WriteLine($"Dep:{m.DepM}");
                     ws.WriteLine($"Doctor:{m.Nome}");
                     ws.WriteLine($"Pacient:{m.ClientControl.IdCliente};{m.ClientControl.Name};{m.ClientControl.Age};{m.ClientControl.Data.ToShortDateString()},{m.ClientControl.Age},{m.ClientControl.CPF},{m.ClientControl.Email}");
                     Console.WriteLine();
                       
                        
                    }
               }

            }
        }
    }



        public List <Medic> impressClinic(Medic medic,int x ){
             if(medic!=null){
                if(x==1){
                    foreach(Medic m in medics){
                        Console.WriteLine($"Clinic of people's:");
                         Console.WriteLine($"ID:{m.ClientControl.IdCliente}");
                          Console.WriteLine($"AGE:{m.ClientControl.Age}");
                           Console.WriteLine($"CPF:{m.ClientControl.CPF}");
                            Console.WriteLine($"EMAIL:{m.ClientControl.Email}");
                             Console.WriteLine($"DATA:{m.ClientControl.Data.ToLongDateString()}");   
                             Console.WriteLine();
                    }
                }
             
                else if(x==2){
                    foreach(Medic m in medics){
                        Console.WriteLine($"Clinic of Animals:");
                         Console.WriteLine($"ID:{m.ControlAnimal.IdAnimal}");
                          Console.WriteLine($"NAME:{m.ControlAnimal.Name}");
                           Console.WriteLine($"AGE:{m.ControlAnimal.Age}");
                            Console.WriteLine($"RACA:{m.ControlAnimal.Raca}");
                             Console.WriteLine($"Name:{m.ControlAnimal.Data.ToShortDateString()}"); 
                             Console.WriteLine();  
                    }
                         
                    }
                
                }
                return medics;
             }





         public void impressClinicfile(Clinic clinic,string path,int x){
        if(clinic!=null){
            if(x==1){
                foreach(Clinic c in clinics){
                    using(StreamWriter ws= File.AppendText(path)){
                     ws.WriteLine($"Clinic:{c.NameClinic}");
                     ws.WriteLine($"Name of doctor:{c.medics.Nome}");
                     ws.WriteLine($"Pacient:{c.medics.ClientControl.IdCliente};{c.medics.ClientControl.Age};{c.medics.ClientControl.Email};{c.medics.ClientControl.CPF},{c.medics.ClientControl.Data.ToShortDateString()}");
                     Console.WriteLine();
                       
                        
                    }

                }
            }
            else  if(x==2){
               foreach(Clinic c in clinics){ 
                using(StreamWriter ws= File.AppendText(path)){
                     ws.WriteLine($"Clinic:{c.NameClinic}");
                     ws.WriteLine($"Doctor of animal:{c.medics.Nome}");
                     ws.WriteLine($"Pacient:{c.medics.ControlAnimal.IdAnimal};{c.medics.ControlAnimal.Age};{c.medics.ControlAnimal.Raca};{c.medics.ControlAnimal.Data.ToLongDateString()}");
                     Console.WriteLine();
                       
                        
                    }
               }

            }
        }
    }





        }

    }
    


