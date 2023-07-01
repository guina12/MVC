using System.IO;
using System.Collections.Generic;
using  turn.ClassControl;
using turn.Dataset;
using  turn.DomainException;

namespace MVC
{
    class Curse
    {
        static void Main(string[] arsg)
        {

            DatasetMaster datasetMaster = new DatasetMaster();
            ClientControl clientControl = new ClientControl();
            ControlAnimal animal = new ControlAnimal();
            Clinic clinic=new Clinic();
            Medic medic = new Medic();
            try
            {
                string path = @"C:\Users\Aguinaldo\Downloads\mulonde3.txt";
                int menu_control = 1;
                while (menu_control > 0)
                {

                    Console.WriteLine("----------------------------");
                    Console.WriteLine("******* _Menu_*********");
                    Console.WriteLine("1-Clients.");
                    Console.WriteLine("2-Animals.");
                    Console.WriteLine("3-Medics.");
                    Console.WriteLine("4-Clinic.");
                    
                    Console.Write("Insert a option:");
                    int menu_option = int.Parse(Console.ReadLine());
                    switch (menu_option)
                    {
                        case 1:
                            int control_option_1 = 1;
                            while (control_option_1 > 0)
                            {
                                Console.WriteLine("*----- Client ------*");
                                Console.WriteLine();
                                Console.WriteLine("1-Insert client.");
                                Console.WriteLine("2-Delete client.");
                                Console.WriteLine("3-List.");
                                Console.WriteLine("4-Update");

                                Console.WriteLine("5-Export File");
                                Console.Write("Choice a  option:");
                                int choice_option_1 = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                switch (choice_option_1)
                                {
                                    case 1:
                                            
                                            Console.Write($"ID:");
                                            int id_cl=int.Parse(Console.ReadLine());
                                            Console.Write("Your name:");
                                            string name_client = Console.ReadLine();
                                            Console.Write("Your sex:");
                                            string sex_client = Console.ReadLine();
                                            Console.Write("Your age:");
                                            int age_client = int.Parse(Console.ReadLine());
                                            Console.Write("Your date (dd/mm/yyyy):");
                                            DateTime data_client = DateTime.Parse(Console.ReadLine());
                                            Console.Write("Your Email:");
                                            string email_client = Console.ReadLine();
                                            Console.Write("Your cpf:");
                                            string cpf_client = Console.ReadLine();
                                            clientControl = new ClientControl(
                                            id_cl, name_client, sex_client, age_client, data_client, email_client, cpf_client
                                         );
                                            datasetMaster.clientControls.Add(clientControl);
                                        
                                        break;


                                    case 2:
                                        Console.WriteLine();
                                        Console.Write("insert a id to remove the client if exist:");
                                        int id_ = int.Parse(Console.ReadLine());
                                        datasetMaster.DeleteClient(clientControl, id_);
                                        break;


                                    case 3:

                                        datasetMaster.ImpressClint(clientControl);
                                        Console.WriteLine();
                                        break;

                                    case 4:
                                        Console.WriteLine();
                                        Console.WriteLine("1-Update Name:");
                                        Console.WriteLine("2-Update Data:");
                                        Console.WriteLine("3-Update Email:");
                                        Console.WriteLine("4-Update CPF:");
                                        Console.Write("Choice option:");
                                        int op = int.Parse(Console.ReadLine());
                                        Console.WriteLine();
                                        switch (op)
                                        {
                                            case 1:

                                                Console.Write("insert a id:");
                                                int id = int.Parse(Console.ReadLine());
                                                Console.Write("insert a name:");
                                                string name = Console.ReadLine();
                                                datasetMaster.UpdateClient_nome(clientControl, id, name);
                                                break;

                                            case 2:
                                                Console.Write("insert a id:");
                                                int id_1 = int.Parse(Console.ReadLine());
                                                DateTime data = DateTime.Parse(Console.ReadLine());
                                                datasetMaster.UpdateClient_data(clientControl, id_1, data);
                                                break;


                                            case 3:
                                                Console.Write("insert a id:");
                                                int id_2 = int.Parse(Console.ReadLine());
                                                string email = Console.ReadLine();
                                                datasetMaster.UpdateClient_email(clientControl, id_2, email);
                                                break;

                                            case 4:
                                                Console.Write("insert a id:");
                                                int id_3 = int.Parse(Console.ReadLine());
                                                Console.Write("insert a cpf:");
                                                string cpf = Console.ReadLine();
                                                datasetMaster.UpdateClient_cpf(clientControl, id_3, cpf);
                                                break;
                                        }



                                    break;   
                                    case 5:
                                        datasetMaster.ImpressFileClient(clientControl, path);
                                        break;
                                    default:
                                        Console.WriteLine("['ERROR']");
                                        break;

                                }
                                Console.WriteLine();
                                Console.Write("Do you wanna continued ? [0-finish/1-continued]:");
                                int option_sub_1 = int.Parse(Console.ReadLine());
                                if (option_sub_1 == 0)
                                {
                                    control_option_1 = control_option_1 - 100;
                                }
                                else if (option_sub_1 == 1)
                                {
                                    control_option_1 = control_option_1 + 1;
                                }


                            }
                            break;

                        case 2:
                            int control_option_2 = 1;
                            while (control_option_2 > 0)
                            {
                                Console.WriteLine("*----- Animal ------*");
                                Console.WriteLine();
                                Console.WriteLine("1-Insert animal.");
                                Console.WriteLine("2-Delete animal.");
                                Console.WriteLine("3-Listing .");
                                Console.WriteLine("4-Update.");
                                Console.WriteLine("5-Export.");
                                Console.Write("Insert a option:");
                                int choice_option_2 = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                switch (choice_option_2)
                                {
                                    case 1:
                                            Console.WriteLine("");
                                            Console.Write("ID:");
                                            int id_a=int.Parse(Console.ReadLine());
                                            Console.Write("Your name:");
                                            string name_animal = Console.ReadLine();
                                            Console.Write("Your sex:");
                                            string sex_animal = Console.ReadLine();
                                            Console.Write("Your age:");
                                            int age_animal = int.Parse(Console.ReadLine());
                                            Console.Write("Your data (dd/mm/yyyy):");
                                            DateTime date_animal = DateTime.Parse(Console.ReadLine());
                                            Console.Write("Your raca:");
                                            string raca_animal = Console.ReadLine();
                                            animal = new ControlAnimal(
                                              id_a, name_animal, sex_animal, age_animal, date_animal, raca_animal
                                            );
                                            datasetMaster.controlAnimals.Add(animal);

                                        
                                        break;

                                    case 2:
                                        Console.Write("Insert a id to delete  if exit.");
                                        int id_animal = int.Parse(Console.ReadLine());
                                        datasetMaster.DeleteAnimal(animal, id_animal);
                                        break;
                                    case 3:
                                        datasetMaster.ImpressAnimal(animal);
                                        break;

                                    case 4:
                                        Console.WriteLine("");
                                        Console.WriteLine("1-Update Name");
                                        Console.WriteLine("2-Update data");
                                        Console.Write("Choice a option to update.");
                                        int up_option = int.Parse(Console.ReadLine());
                                        Console.WriteLine();
                                        switch (up_option)
                                        {
                                            case 1:
                                                Console.Write("insert a id to update:");
                                                int id_ = int.Parse(Console.ReadLine());
                                                Console.Write("insert a name :");
                                                string name = Console.ReadLine();
                                                datasetMaster.Updateanimal_nome(animal, id_,name);
                                                break;
                                            case 2:
                                                Console.Write("insert a id to update:");
                                                int id_1 = int.Parse(Console.ReadLine());
                                                Console.Write("insert a data :");
                                                DateTime data = DateTime.Parse(Console.ReadLine());
                                                datasetMaster.Updateanimal_data(animal, id_1, data);
                                                break;
                                        }
                                        break;
                                    case 5:
                                        Console.WriteLine();
                                        datasetMaster.ImpressFileAnimal(animal, path);
                                        break;
                                    default:
                                        Console.WriteLine("['ERROR']");
                                        break;
                                      
                                }
                                Console.Write("Do you wanna continued ? [0-finish/1-continued]:");
                                int option_sub_1 = int.Parse(Console.ReadLine());
                                if (option_sub_1 == 0)
                                {
                                    control_option_2 = control_option_2 - 100;
                                }
                                else if (option_sub_1 == 1)
                                {
                                    control_option_2 = control_option_2 + 1;
                                }

                            }
                            break;
                        case 3:
                            Console.WriteLine("*-----Medic-----*");
                            Console.WriteLine();
                            Console.WriteLine("1-Medic Register:");
                            Console.WriteLine("2-List Medic");
                            Console.WriteLine("3-Export.");
                            Console.WriteLine("4-Check Pacient/Animal.");
                            Console.Write("Choice a option:");
                            int option_medic = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            switch (option_medic)
                            {
                                case 1:
                                
                                    Console.Write("Name:");
                                    string name_medic = Console.ReadLine();
                                    Console.Write("Dep:");
                                    string dep = Console.ReadLine();
                                    Console.Write("IS client or animal ?:[1-Client/2-Animal]:");
                                    int  op=int.Parse(Console.ReadLine());
                                    if(op==1){
                                     medic=new Medic(clientControl,dep,name_medic);
                                     datasetMaster.InsertDoctor(medic);
                                    }
                                    else if(op==2){
                                        medic = new  Medic(animal,dep,name_medic);
                                        datasetMaster.InsertDoctor(medic);
                                    }
                                    
                                    break;
                                case 2:
                                    datasetMaster.ImpressDoctor(medic);
                                    break;
                                case 3:
                                    Console.Write("Export-[1-Animal/2-Client]:");
                                    int x=int.Parse(Console.ReadLine());
                                    datasetMaster.impressAnimalClient1(medic,path,x);
                                    break;

                                case 4:
                                    Console.WriteLine("1-Check pacient");
                                    Console.WriteLine("2-Check Animal");
                                    Console.Write("Choice option:");
                                    int op_doc = int.Parse(Console.ReadLine());
                                    Console.WriteLine();

                                    switch (op_doc)
                                    {
                                        case 1:
                                            Console.Write("insert a id to check the pacient:");
                                            int id_cl = int.Parse(Console.ReadLine());
                                            datasetMaster.CheckClient(medic,id_cl);
                                            break;
                                        case 2:
                                            Console.Write("insert a id to check the animal:");
                                            int id_ani = int.Parse(Console.ReadLine());
                                            datasetMaster.CheckAniaml(medic, id_ani);
                                            break;
                                        default:
                                            Console.Write("['ERROR']");
                                            break;

                                    }
                                    break;
                                default:
                                    Console.Write("['ERROR']");
                                    break;
                            }
                        
                        break;
                        case 4:
                          Console.WriteLine("1-Insert Clinic");
                          Console.WriteLine("2-Impress clinic");
                          Console.WriteLine("3-Export Clinic");
                          Console.Write("Choice :");
                          int choice_=int.Parse(Console.ReadLine());
                          Console.WriteLine();
                          switch(choice_){

                            case 1:
                              Console.Write("Name of clinic:");
                              string name_clinic=Console.ReadLine();
                              clinic=new Clinic(name_clinic,medic);
                              datasetMaster.InsertClinic(clinic);
                          break;
                          case 2:
                          Console.Write("choice an option to impress a clinic of entities [1-client/2-Animal]");
                          int op_=int.Parse(Console.ReadLine());
                          Console.WriteLine();
                          datasetMaster.impressClinic(medic,op_);
                          break;

                          case 3:
                          Console.Write("choice an option to export a file of clinic [1-client/2-Animal]");
                          int op_cli=int.Parse(Console.ReadLine());
                          datasetMaster.impressClinicfile(clinic,path,op_cli);
                          break;

                        

                          }
                       
                          
                        
                        break;    
                        default:
                            Console.WriteLine("['ERROR']");
                        break;
                                   
                    }

                    Console.WriteLine("Do you wanna finish the program ? [0-finish/1-continued]");
                    int option_menu = int.Parse(Console.ReadLine());
                    if (option_menu == 0)
                    {
                        menu_control = menu_control - 100;
                    }
                    else if (option_menu == 1)
                    {
                        menu_control = menu_control + 1;
                    }
                }
            }
            catch (Domain d)
            {
                Console.WriteLine($"['ERROR']  message ! {d.Message}");
            }
            catch (IOException e)
            {
                Console.WriteLine($"[ERROR] message ! {e.Message}");
            }

            catch (Exception e)
            {
                Console.WriteLine($"[ERROR] message  ! {e.Message}");
            }

            
            
        }
    }
}
